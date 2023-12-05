using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognize.Properties;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
namespace FaceRecognize
{
    public partial class Form3 : Form
    {
        String basePath = @"..\..\";
        IFirebaseClient client;
        private String Id;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "G4GUZnW4cd9AkPP7NOzYGy55NoPWtzxd7lI7nygU",
            BasePath = "https://facerecognition-6c037-default-rtdb.asia-southeast1.firebasedatabase.app/"

        };
        public Form3(String id = "")
        {
            InitializeComponent();
            Id = id;
            if (Id != "")
            {
                tbID.Text = Id;
            }
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "")
            {
                MessageBox.Show("ID field cannot be blank");
                return;
            }
            var data = new Patient
            {
                Id = tbID.Text,
                Name = tbName.Text,
                Diasease = tbDisease.Text,
                Phone = tbPhone.Text,
                dob = dtpDoB.Text,
                start_date = dtpStart.Text,
                end_date = dtpEnd.Text

            };
            SetResponse response = await client.SetAsync("Patients/" + tbID.Text, data);
            Patient result = response.ResultAs<Patient>();

            MemoryStream ms = new MemoryStream();
            pbImage.Image.Save(ms, ImageFormat.Jpeg);

            byte[] a = ms.GetBuffer();

            String output = Convert.ToBase64String(a);

            var img = new Image_class
            {
                Img = output
            };

            SetResponse response2 = await client.SetAsync("Images/" + tbID.Text, img);
            Image_class result2 = response.ResultAs<Image_class>();

            MessageBox.Show("Patient added! \n Id: " + result.Id);
        }

        private void clear_All_textBox()
        {
            tbID.Clear();
            tbName.Clear();
            tbDisease.Clear();
            tbPhone.Clear();
        }


        private void btnReceive_Click(object sender, EventArgs e)
        {
            if(tbID.Text == "")
            {
                MessageBox.Show("ID field cannot be blank");
                return;
            }
            receiveInfo();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {
                MessageBox.Show("Connection to database failed");
            }
            
            if(Id != "")
            {
                receiveInfo();
                
            }

        }

        private async void receiveInfo()
        {
            FirebaseResponse response = await client.GetAsync("Patients/" + tbID.Text);
            Patient obj = response.ResultAs<Patient>();

            if (obj != null)
            {
                tbID.Text = obj.Id;
                tbName.Text = obj.Name;
                tbDisease.Text = obj.Diasease;
                tbPhone.Text = obj.Phone;
                dtpDoB.Value = DateTime.ParseExact(obj.dob, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                dtpStart.Value = DateTime.ParseExact(obj.start_date, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                dtpEnd.Value = DateTime.ParseExact(obj.end_date, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            }
            else
            {
                clear_All_textBox();
                pbImage.Image = Image.FromFile(basePath + @"Resources\pngegg.png");
                MessageBox.Show("No patient was found");
            }

            FirebaseResponse response2 = await client.GetAsync("Images/" + tbID.Text);
            Image_class obj2 = response2.ResultAs<Image_class>();

            if (obj2 != null && obj2.Img != null)
            {
                byte[] b = Convert.FromBase64String(obj2.Img);

                MemoryStream ms = new MemoryStream();
                ms.Write(b, 0, Convert.ToInt32(b.Length));

                Bitmap bm = new Bitmap(ms, false);

                ms.Dispose();

                pbImage.Image = bm;
            }
            else
            {
                pbImage.Image = Image.FromFile(basePath + @"Resources\pngegg.png");
                MessageBox.Show("No image was found");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Image Files(*.jpg) | *.jpg";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(ofd.FileName);
                pbImage.Image = img;
            }
        }

        private void btnPres_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(tbID.Text.Trim());
            f2.Show();

        }


    }
}
