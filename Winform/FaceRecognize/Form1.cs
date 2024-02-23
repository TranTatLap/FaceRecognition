using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using AForge.Video;
using AForge.Video.DirectShow;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
   
namespace FaceRecognize
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection cameras;
        private VideoCaptureDevice cam;
        private Form3 f3;
        String basePath = @"..\..\";
        public Form1()
        {
            InitializeComponent();
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in cameras)
            {
                cbTypeCam.Items.Add(info.Name);
            }
            try
            {
                cbTypeCam.SelectedIndex = 0;
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
            
            btnDetail.Visible = false;
            clear_textBox();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Stop_cam();
            try
            {
                cam = new VideoCaptureDevice(cameras[cbTypeCam.SelectedIndex].MonikerString);
                cam.NewFrame += Cam_NewFrame;
                cam.Start();
            }catch (Exception ex) {
                MessageBox.Show(ex.Message); 
            }
            
        }
        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            picCam.Image = bitmap;
        }

        private void Stop_cam()
        {
            if (cam != null && cam.IsRunning)
            {
                cam.SignalToStop();
                cam.WaitForStop();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {

            picRes.Image = Image.FromFile(basePath + @"Resources\0.png");
            btnStart.PerformClick();
            btnDetail.Visible = false;
            clear_textBox();

            if (f3 != null)
            {
                f3.Hide();
            }

        }
        private async void receiveInfo()
        {
            Auth.client_id = "123455";
            FirebaseResponse response = await Auth.mclient.GetAsync("Patients/" + Auth.client_id);
            Patient obj = response.ResultAs<Patient>();

            if (obj != null)
            {
                tbDoB.Visible = true;
                tbId.Visible = true;
                tbName.Visible = true;
                pbAvatar.Visible = true;

                tbId.Text = obj.Id;
                tbName.Text = obj.Name;
                tbDoB.Text = obj.dob;

                byte[] b = Convert.FromBase64String(obj.Img);

                MemoryStream ms = new MemoryStream();
                ms.Write(b, 0, Convert.ToInt32(b.Length));

                Bitmap bm = new Bitmap(ms, false);

                ms.Dispose();

                pbAvatar.Image = bm;
            }
            else
            {
                clear_textBox();


                pbAvatar.Image = null;
                MessageBox.Show("No patient was found");
            }

        }

        private void clear_textBox()
        {
            tbId.Clear();
            tbName.Clear();
            tbDoB.Clear();
            tbId.Visible = false; 
            tbName.Visible = false;
            tbDoB.Visible=false;

            pbAvatar.Image = null;
            pbAvatar.Visible = false;
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory =@"D:\Document\GitHub\FaceRecognition\Winform\Images";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picCam.Image.Save(saveFileDialog1.FileName);
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Stop_cam();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void picCam_Click(object sender, EventArgs e)
        {
            picRes.Image = Image.FromFile(basePath + @"Resources\1.png");
            picCam.SizeMode = PictureBoxSizeMode.StretchImage;

            if (cam != null && cam.IsRunning)
            {
                cam.SignalToStop();
                cam.WaitForStop();
            }

            picCam.Image = Image.FromFile(basePath + @"Resources\cam_off.png");
            receiveInfo();
            btnDetail.Visible = true;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Auth.client_id = null;
        }
    }
}
