using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Configuration;
using System.Net.Mail;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Tulpep.NotificationWindow;

namespace FitnessTracker2._0
{
    
    public partial class ForgotPassword : Form
    {
        public static string constr1 = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        MySqlConnection condatabase = new MySqlConnection(constr1);
        Form1 myparent;
        public ForgotPassword(Form1 source)
        {
            this.myparent = source;
            InitializeComponent();
            Usertxt.Text = Program.userName;
            LblText.Text = "";
            
            
        }

       

        private void SendMail_Click(object sender, EventArgs e)
        {
            
            condatabase.Open();
            string username = string.Empty;
            string password = string.Empty;
            string Mail = string.Empty;
            string Query = "select * from user where Name='" + Usertxt.Text + "';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(Query, condatabase);
                MySqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    Mail = myReader.GetString("Email");
                    password = myReader.GetString("Password");
                    username = Usertxt.Text;
                }
                if(Mail!="")
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        MailMessage mm = new MailMessage();
                        mm.From = new MailAddress("odysseyfitnesstracker@gmail.com");
                        mm.Subject = "Password Recovery";
                        mm.Body = string.Format("Hello {0},<br/><br/>Your current Password is {1}. You can now login to Odyssey! Have a great day.<br/><br/>Your fitness tracker, <br/> Odyssey", username, password);
                        mm.IsBodyHtml = true;
                        mm.To.Add(new MailAddress(Mail));
                        SmtpClient smtp = new SmtpClient();
                        smtp.Host = "smtp.gmail.com";
                        smtp.UseDefaultCredentials = false;

                        

                        smtp.Credentials = new System.Net.NetworkCredential("odysseyfitnesstracker@gmail.com", "odyssey@123");
                        smtp.Port = 587;
                        smtp.EnableSsl = true;
                        smtp.Send(mm);
                        LblText.ForeColor = Color.Green;
                        LblText.Text = "Password has been sent to your registered email address";
                        {
                            PopupNotifier popup = new PopupNotifier();
                            popup.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("icon");
                            popup.TitleText = "Password recovery";
                            popup.ContentText = "Check out your inbox. You have a recovery mail sent to "+ Mail;
                            popup.Popup();

                        }

                    }
                   

                }
                else
                {
                    LblText.ForeColor = Color.Red;
                    LblText.Text = "Your Username is not valid";
                }
            }
            catch (Exception ex)
            {
            }
            condatabase.Close();
               
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GoLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            myparent.openChildForm(new Login(myparent));
        }
    }
}
