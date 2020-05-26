using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Mail;
namespace FitnessTracker2._0
{
    public partial class Login : Form
    {
        Form1 myparent;
        public static string constr = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        MySqlConnection con1 = new MySqlConnection(constr);
        public Login(Form1 source)
        {
            this.myparent = source;
            InitializeComponent();
        }
        private void MailSent(string email,string pass)
        {
            
            try
            {

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("thisisourprojectx@gmail.com");
                msg.To.Add(email);
                msg.Subject = "RESET the password for ODYSSEY";
                msg.Body = "You can now reset the password. Your old password was " + pass + "\n Enter your old password to login and you can use the change password facility ";


                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "thisisourprojectx@gmail.com";
                ntcd.Password = "piddS1623140714";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);

                MessageBox.Show("A Mail is sent to ur registered mailid");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

            private void login1_Click(object sender, EventArgs e)
        {
           
                try
                {
                    if (user.Text == "" || password.Text == "")
                        MessageBox.Show("Please enter all mandatory fields");
                    else
                    {
                        con1.Open();
                        string command = "select password from user where name='" + user.Text + "';";
                        MySqlCommand cmd = new MySqlCommand(command, con1);
                        MySqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            string pd = dr.GetString(0);
                            if (pd == password.Text)
                            {
                                //correct password
                                {
                                    Program.userName = user.Text;

                                //code for home page
                                    this.Close();
                                    myparent.toggleNav();
                                myparent.openChildForm(new HomePage(myparent));
                                    

                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorrect  password ! try again!!");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Incorrect user name !", "Attention required");
                        }
                    }

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
                con1.Close();



            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            myparent.openChildForm(new CreateAcnt(myparent));
            myparent.hidesub();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string email = "", pass = "";
            try
            {
                con1.Open();
                string command = "select password,email from user where name='" + user.Text + "';";
                MySqlCommand cmd = new MySqlCommand(command, con1);
                MySqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    email = dr.GetString(1);
                    pass = dr.GetString(0);
                }
                else
                {
                    msgBox msg = new msgBox("No such username, So please try again!!");
                    msg.StartPosition = FormStartPosition.Manual;

                    msg.Left = 1000;
                    msg.Top = 500;

                    msg.ShowDialog();
                }

                MailSent(email, pass);

            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message, "ERROR in sending mail");
            }
            con1.Close();
        }
    }

       
    }
