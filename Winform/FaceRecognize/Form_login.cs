using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Auth.Repository;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FaceRecognize
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            pbLoading.Visible = true;
            try
            {
                var auth = await Auth.authClient.SignInWithEmailAndPasswordAsync(tbEmail.Text,tbPass.Text);
                Auth.uid = auth.User.Uid;
                pbLoading.Visible = false;
                tbPass.Clear();
                tbEmail.Clear();

                Auth.mclient = new FireSharp.FirebaseClient(Auth.mconfig);

                if (Auth.mclient == null)
                {
                    MessageBox.Show("Connection to database failed");
                    return;
                }

                Form4 f = new Form4();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }  
            catch (Exception ex){
                pbLoading.Visible = false;
                MessageBox.Show("Login failed!\nPlease check your email and password again.");
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_signup form = new Form_signup();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
