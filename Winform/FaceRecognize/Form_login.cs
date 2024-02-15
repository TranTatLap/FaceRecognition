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
        public static FirebaseAuthConfig config = new FirebaseAuthConfig
        {
            ApiKey = "AIzaSyCkiRh6pOgqJHc6_u0Z_5jRWEkbbKvmyXY",
            AuthDomain = "facerecognition-6c037.firebaseapp.com",
            Providers = new FirebaseAuthProvider[]
            {
                new EmailProvider()
            }

        };
        FirebaseAuthClient client = new FirebaseAuthClient(config);
        public Form_login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            pbLoading.Visible = true;
            try
            {
                _ = await client.SignInWithEmailAndPasswordAsync(tbEmail.Text,tbPass.Text);
                pbLoading.Visible = false;
                tbPass.Clear();
                tbEmail.Clear();
                this.Hide();
                Form4 form = new Form4();
                form.ShowDialog();
                form = null;
                this.Show();
            }
            catch {
                pbLoading.Visible = false;
                MessageBox.Show("Login failed!");
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
