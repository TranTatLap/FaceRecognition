using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FaceRecognize
{
    public partial class Form_user : Form
    {
        IFirebaseClient client;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "G4GUZnW4cd9AkPP7NOzYGy55NoPWtzxd7lI7nygU",
            BasePath = "https://facerecognition-6c037-default-rtdb.asia-southeast1.firebasedatabase.app/"

        };
        public Form_user()
        {
            InitializeComponent();
        }
        private async void receiveInfo()
        {
            FirebaseResponse response = await client.GetAsync("Users/" + Auth.uid);
            User obj = response.ResultAs<User>();
            

            //if (obj != null)
            //{
            //    tbDoB.Visible = true;
            //    tbId.Visible = true;
            //    tbName.Visible = true;
            //    pbAvatar.Visible = true;

            //    tbId.Text = obj.Id;
            //    tbName.Text = obj.Name;
            //    tbDoB.Text = obj.dob;

            //    byte[] b = Convert.FromBase64String(obj.Img);

            //    MemoryStream ms = new MemoryStream();
            //    ms.Write(b, 0, Convert.ToInt32(b.Length));

            //    Bitmap bm = new Bitmap(ms, false);

            //    ms.Dispose();

            //    pbAvatar.Image = bm;
            //}
            //else
            //{
            //    clear_textBox();
            //    pbAvatar.Image = null;
            //    MessageBox.Show("No patient was found");
            //}

        }

        private void Form_user_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {
                MessageBox.Show("Connection to database failed");
            }
        }
    }
}
