import cv2
import os


cap = cv2.VideoCapture(1)
cap.set(3,640)
cap.set(4,480)

imgBackground = cv2.imread('Resources/bg.png')
img = cv2.imread('Resources/background.png')

img = cv2.resize(img, (640, 480))

folderModePath = 'Resources/Modes'
modePathList = os.listdir(folderModePath)
imgModeList = []

for path in modePathList:
    imgModeList.append(cv2.imread(os.path.join(folderModePath, path)))
while True:
    # success, img = cap.read()

    imgBackground[162:162 + 480, 55:55 + 640] = img
    imgBackground[33:33 + 659, 793:793 + 446] = imgModeList[5]
    # cv2.imshow("Webcam", img)
    cv2.imshow("Face Attendance", imgBackground)
    cv2.waitKey(1)