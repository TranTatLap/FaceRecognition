using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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
using System.Xml.Linq;

namespace FaceRecognize
{
    public partial class Form_user : Form
    {
        public Form_user()
        {
            InitializeComponent();
        }
        private async void receiveInfo()
        {
            try
            {
                FirebaseResponse response = await Auth.mclient.GetAsync("Users/" + Auth.uid);
                User obj = response.ResultAs<User>();


                if (obj != null)
                {
                    tbFullname.Text = obj.Fullname;
                    dtpDoB.Value = DateTime.ParseExact(obj.Dob, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    tbEmail.Text = obj.Email;

                    byte[] b = Convert.FromBase64String(obj.Img);

                    MemoryStream ms = new MemoryStream();
                    ms.Write(b, 0, Convert.ToInt32(b.Length));

                    Bitmap bm = new Bitmap(ms, false);

                    ms.Dispose();

                    pbAvatar.Image = bm;
                }
                else
                {
                    pbAvatar.Image = null;
                    MessageBox.Show("No patient was found");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        private void Form_user_Load(object sender, EventArgs e)
        {
            receiveInfo();
        }

        private void pbAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Image Files(*.jpg) | *.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(ofd.FileName);
                pbAvatar.Image = img;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Auth.uid=null;
            Auth.client_id=null;

            Form_login f = new Form_login();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbFullname.Text == "" || dtpDoB.Text == "")
            {
                MessageBox.Show("All field cannot be blank");
                return;
            }
            MemoryStream ms = new MemoryStream();
            pbAvatar.Image.Save(ms, ImageFormat.Jpeg);

            byte[] a = ms.GetBuffer();

            String img_base64 = Convert.ToBase64String(a);
            var data = new User(tbFullname.Text, dtpDoB.Text.Trim(), tbEmail.Text, img_base64);
            SetResponse response = await Auth.mclient.SetAsync("Users/" + Auth.uid, data);
            User result = response.ResultAs<User>();

            MessageBox.Show("User information updated! \n Id: " + Auth.client_id);
        }
    }
}
