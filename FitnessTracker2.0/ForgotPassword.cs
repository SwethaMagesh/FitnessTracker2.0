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

namespace FitnessTracker2._0
{
    
    public partial class ForgotPassword : Form
    {
        public static string constr1 = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        MySqlConnection condatabase = new MySqlConnection(constr1);
        Form1 myparent;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
                }
                if(Mail!="")
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        MailMessage mm = new MailMessage();
                        mm.From = new MailAddress("odysseyfitnesstracker@gmail.com");
                        mm.Subject = "Password Recovery";
                        mm.Body = string.Format("Hii{0},<br/><br/>Your Password is {1}.<br/><br/>Thank You.", username, password);
                        mm.IsBodyHtml = true;
                        mm.To.Add(new MailAddress(Mail));
                        SmtpClient smtp = new SmtpClient();
                        smtp.Host = "smtp.gmail.com";
                        smtp.UseDefaultCredentials = false;

                        // NetworkCredential NetworkCred = new NetworkCredential();
                        //NetworkCred.UserName = "odysseyfitnesstracker@gmail.com";
                        //NetworkCred.Password = "odyssey@123";

                        smtp.Credentials = new System.Net.NetworkCredential("odysseyfitnesstracker@gmail.com", "odyssey@123");
                        smtp.Port = 587;
                        smtp.EnableSsl = true;
                        smtp.Send(mm);
                        LblText.ForeColor = Color.Green;
                        LblText.Text = "Password has been sent to your registered email address";

                    }
                    else
                    {
                        LblText.ForeColor = Color.Red;
                        LblText.Text = "This email address does not match our records";
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
            Login lo = new Login(myparent);
            myparent.openChildForm(lo);
        }
    }
}
