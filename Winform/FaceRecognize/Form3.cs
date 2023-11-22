using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
namespace FaceRecognize
{
    public partial class Form3 : Form
    {
        IFirebaseClient client;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "G4GUZnW4cd9AkPP7NOzYGy55NoPWtzxd7lI7nygU",
            BasePath = "https://facerecognition-6c037-default-rtdb.asia-southeast1.firebasedatabase.app/"

        };
        public Form3()
        {
            InitializeComponent();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var data = new Patient
            {
                Id = tbID.Text,
                Name = tbName.Text,
                Diasease = tbDisease.Text,
                Pres = tbPres.Text,
                dob = dtpDoB.Text,
                start_date = dtpStart.Text,
                end_date = dtpEnd.Text

            };
            SetResponse response = await client.SetAsync("Patients/" + tbID.Text, data);
            Patient result = response.ResultAs<Patient>();

            MessageBox.Show("Patient added! \n Id: " + result.Id);
        }

        private async void btnReceive_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetAsync("Patients/" + tbID.Text);
            Patient obj = response.ResultAs<Patient>();
            
            tbID.Text = obj.Id;
            tbName.Text = obj.Name;
            tbDisease.Text = obj.Diasease;
            tbPres.Text = obj.Pres;
            dtpDoB.Value = DateTime.ParseExact(obj.dob, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            dtpStart.Value = DateTime.ParseExact(obj.start_date, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            dtpEnd.Value = DateTime.ParseExact(obj.end_date, "MM/dd/yyyy", CultureInfo.InvariantCulture);


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {
                MessageBox.Show("Connection to database failed");
            }
        }
    }
}
