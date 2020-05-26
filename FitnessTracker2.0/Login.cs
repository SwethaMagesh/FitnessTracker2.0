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

        private void button1_Click(object sender, EventArgs e)
        {
            myparent.openChildForm(new CreateAcnt(myparent));
            myparent.hidesub();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            myparent.openChildForm(new ForgotPassword());
            myparent.hidesub();
        }
    }
}
