using Firebase.Auth.Providers;
using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using System.Security.Cryptography;
using FireSharp.Response;
using Newtonsoft.Json;
using RestSharp.Authenticators;

namespace FaceRecognize
{
    public partial class Form_signup : Form
    {
        public Form_signup()
        {
            InitializeComponent();
        }


        private async void btnSignup_Click(object sender, EventArgs e)
        {
            pbLoading.Visible = true;
            if(string.IsNullOrEmpty(tbFullname.Text) || string.IsNullOrEmpty(tbEmail.Text) 
                || string.IsNullOrEmpty(dtpDoB.Text) || string.IsNullOrEmpty(tbPass.Text) || string.IsNullOrEmpty(tbcPass.Text))
            {
                pbLoading.Visible = false;
                MessageBox.Show("Please fill in all information");
                return;
            } 
            else if (!tbPass.Text.Equals(tbcPass.Text)){
                pbLoading.Visible = false;
                MessageBox.Show("Confirm password is incorrect");
                return;
            }
            else
            {
                try
                {
                    var auth = await Auth.authClient.CreateUserWithEmailAndPasswordAsync(tbEmail.Text.Trim(), tbPass.Text);
                    var user = auth.User;
                    String uid = null;
                    if (user != null)
                    {
                        uid = user.Uid.ToString();
                        Auth.uid = uid;
                    }
                    else
                    {
                        pbLoading.Visible = false;
                        MessageBox.Show("Failed. Please contact the administrator");
                        return;
                    }

                    var data = new User(tbFullname.Text.Trim(), dtpDoB.Text.Trim());

                    SetResponse response = await Auth.mclient.SetAsync("Users/" + uid, data);
                    Patient result = response.ResultAs<Patient>();
                    if (result == null)
                    {
                        pbLoading.Visible = false;
                        MessageBox.Show("Failed. Please contact the administrator");
                        return;
                    }
                    pbLoading.Visible = false;
                    if (MessageBox.Show("Sign up successfully! \nBack to login?", "Successful!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Close();
                    };
                }
                catch (Exception ex)
                {
                    pbLoading.Visible = false;
                    string[] parts = ex.Message.Split(' ');
                    if( ex.Message.Length > 50)
                    {
                        MessageBox.Show(parts[parts.Length - 1]);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }

                    
                }

            }

            
        }

        private void Form_signup_Load(object sender, EventArgs e)
        {
            Auth.mclient  = new FireSharp.FirebaseClient(Auth.mconfig);
            //mclient = new FireSharp.FirebaseClient(Auth.mconfig);
            if (Auth.mclient == null)
            {
                MessageBox.Show("Connection to database failed");
            }
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            this.Close();    
        }
    }
}
