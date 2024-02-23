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
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using static System.Collections.Specialized.BitVector32;

namespace FaceRecognize
{
    public partial class Form2 : Form
    {
        List<Medicine> list = new List<Medicine>();
        public Form2(String id=null)
        {
            InitializeComponent();
            if (Auth.client_id != null)
            {
                tbID.Text = Auth.client_id;
            }
            else if (id != null)
            {
                tbID.Text = id; 
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            int dose = int.Parse(tbDose.Text.Trim());
            String session = "";
            foreach (String item in clbSession.CheckedItems) {
                session += item + " ";
            }
            int days = int.Parse(tbNumDay.Text.Trim());
            int total = dose * clbSession.CheckedItems.Count * days;

            Medicine med = new Medicine(tbMedName.Text.Trim(), session, dose, days, total, tbNote.Text);

            list.Add(med);
            gridPres.DataSource = null;
            gridPres.DataSource = list;
            formatGridView();

            gridPres.Refresh();
        }

        private void formatGridView()
        {
            gridPres.Columns[0].HeaderText = "Medicine name";
            gridPres.Columns[0].Width = 180;
            gridPres.Columns[1].HeaderText = "Session";
            gridPres.Columns[1].Width = 150;
            gridPres.Columns[2].HeaderText = "Dose";
            gridPres.Columns[2].Width = 99;
            gridPres.Columns[3].HeaderText = "Number of days";
            gridPres.Columns[3].Width = 110;
            gridPres.Columns[4].HeaderText = "Total";
            gridPres.Columns[4].Width = 70;
            gridPres.Columns[5].HeaderText = "Note";
            gridPres.Columns[5].Width = 260;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "")
            {
                MessageBox.Show("ID field cannot be blank");
                return;
            }
            bool f = false;
            foreach(Medicine medicine in list)
            {
                var data = new Medicine(medicine.name, medicine.session, medicine.dose, medicine.numOfDays, medicine.total, medicine.note);
             
                SetResponse response = await Auth.mclient.SetAsync("Prescriptions/" + tbID.Text +"/" +medicine.name, data);
                Patient result = response.ResultAs<Patient>();
                if (result == null) { f = true; }

            }
            if (f)
            {
                MessageBox.Show("Failed! \n Id: " + tbID.Text);
            }
            else
            {
                MessageBox.Show("Prescription added! \n Id: " + tbID.Text);
            }
            
        }
        private async void receiveInfo()
        {
            FirebaseResponse response = await Auth.mclient.GetAsync("Prescriptions/" + tbID.Text);
            Dictionary<string, Medicine> data = JsonConvert.DeserializeObject<Dictionary<string, Medicine>>(response.Body.ToString());
            if(data == null)
            {
                MessageBox.Show("No prescription was found");
                return;
            }
            list.Clear();
            foreach( Medicine item in data.Values) {

                //Medicine med = new Medicine(item.Value.name, item.Value.session, item.Value.dose, item.Value.numOfDays, item.Value.total);
                list.Add(item);
            }

            gridPres.DataSource = null;
            gridPres.DataSource = list;
            formatGridView();

            gridPres.Refresh();
            MessageBox.Show("Patient's prescription was loaded!\n" +"ID: " + tbID.Text);

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            if(tbID.Text != "")
            {
                receiveInfo();
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "")
            {
                MessageBox.Show("ID field cannot be blank");
                return;
            }
            receiveInfo();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            list.Clear();
            gridPres.DataSource = null;
            gridPres.DataSource = list;
            formatGridView();

            gridPres.Refresh();
        }

        private void tbDose_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbNumDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
    }
}
