import os
import torch
from PIL import Image
from torchvision import transforms
from transformers import AutoImageProcessor, AutoModelForImageClassification
import flwr as fl
import torch.optim as optim
from torch.utils.data import DataLoader, Dataset

# Load model directly
processor = AutoImageProcessor.from_pretrained("KietZer0/ViT_LFW_Model4")
model = AutoModelForImageClassification.from_pretrained("KietZer0/ViT_LFW_Model4")

# Define your transformation
transform = transforms.Compose([
    transforms.Resize((224, 224)),
    transforms.ToTensor(),
])


# Load your dataset
class ImageDataset(Dataset):
    def __init__(self, img_folder):
        self.subfolders = [f.path for f in os.scandir(img_folder) if f.is_dir()]
        self.label_dict = {os.path.basename(folder): i for i, folder in enumerate(self.subfolders)}
        self.images = [(Image.open(os.path.join(folder, f)), os.path.basename(os.path.dirname(os.path.join(folder, f))))
                       for folder in self.subfolders for f in os.listdir(folder)]

    def __len__(self):
        return len(self.images)

    def __getitem__(self, idx):
        img, label = self.images[idx]
        img = transform(img)
        label = self.label_dict[label]
        return img, label


# Define your Flower client
class ImageClassificationClient(fl.client.NumPyClient):
    def __init__(self, img_folder):
        self.dataset = ImageDataset(img_folder)
        self.dataloader = DataLoader(self.dataset, batch_size=32, shuffle=True, num_workers=2)

    def get_parameters(self, config):
        return [val.cpu().detach().numpy() for _, val in model.named_parameters()]

    def set_parameters(self, parameters):
        params_dict = zip([name for name, _ in model.named_parameters()], parameters)
        state_dict = {name: torch.Tensor(val) for name, val in params_dict}
        model.load_state_dict(state_dict, strict=True)

    def fit(self, parameters, config):
        self.set_parameters(parameters)
        model.train()
        optimizer = optim.SGD(model.parameters(), lr=0.001, momentum=0.9)
        criterion = torch.nn.CrossEntropyLoss()

        for epoch in range(2):
            running_loss = 0.0
            for i, (inputs, labels) in enumerate(self.dataloader, 0):
                optimizer.zero_grad()
                outputs = model(inputs)
                loss = criterion(outputs.logits, labels)
                loss.backward()
                optimizer.step()
                running_loss += loss.item()
                if i % 200 == 199:  # print every 200 mini-batches
                    print('[%d, %5d] loss: %.3f' %
                          (epoch + 1, i + 1, running_loss / 200))
                    running_loss = 0.0

        print('Finished Training')
        return self.get_parameters(config), len(self.dataset), {}

    def evaluate(self, parameters, config):
        self.set_parameters(parameters)
        model.eval()
        correct = 0
        total = 0
        with torch.no_grad():
            for images, labels in self.dataloader:
                outputs = model(images)
                _, predicted = torch.max(outputs.logits.data, 1)
                total += labels.size(0)
                correct += (predicted == labels).sum().item()

        print('Accuracy of the network on the test images: %d %%' % (
                100 * correct / total))

        return len(self.dataset), float(correct) / total, len(self.dataset)


# Start Flower server
fl.client.start_numpy_client(server_address='127.0.0.1:8080', client=ImageClassificationClient('D:/NCKH/Patients'))
