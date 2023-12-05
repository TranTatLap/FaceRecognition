using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        private Rectangle originalRectangel;
        private Rectangle originalFormSize;
        private Form3 f3;
        String basePath = @"..\..\";
        IFirebaseClient client;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "G4GUZnW4cd9AkPP7NOzYGy55NoPWtzxd7lI7nygU",
            BasePath = "https://console.firebase.google.com/u/0/project/facerecognition-6c037/database/facerecognition-6c037-default-rtdb/data/~2F"

        };

        public Form1()
        {
            InitializeComponent();
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in cameras)
            {
                cbTypeCam.Items.Add(info.Name);
            }
            cbTypeCam.SelectedIndex = 0;
            btnDetail.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Stop_cam();
            cam = new VideoCaptureDevice(cameras[cbTypeCam.SelectedIndex].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam.Start();
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

            if (f3 != null)
            {
                f3.Hide();
            }

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

            client = new FireSharp.FirebaseClient(config);
            if(client == null)
            {
                MessageBox.Show("Connection to database failed");
            }

        }

        private void Form1_Resize_1(object sender, EventArgs e)
        {
            //sizeControl(originalRectangel, picCam);
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

            btnDetail.Visible = true;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            f3 = new Form3("123455");
            f3.Show();

        }
    }
}
