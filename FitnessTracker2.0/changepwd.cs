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
    public partial class changepwd : Form
    {
        public static string constr = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        MySqlConnection con1 = new MySqlConnection(constr);
        public changepwd()
        {
            InitializeComponent();
        }

        static bool ValidatePassword(string passWord)
        {
            int validConditions = 0;
            foreach (char c in passWord)
            {
                if (c >= 'a' && c <= 'z')
                {
                    validConditions++;
                    break;
                }
            }
            foreach (char c in passWord)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    validConditions++;
                    break;
                }
            }
            if (validConditions == 0 || validConditions == 1) return false;
            foreach (char c in passWord)
            {
                if (c >= '0' && c <= '9')
                {
                    validConditions++;
                    break;
                }
            }
            if (validConditions == 2) return false;
            if (validConditions == 3)
            {
                char[] special = { '@', '#', '$', '%', '^', '&', '+', '=' }; // or whatever
                if (passWord.IndexOfAny(special) == -1) return false;
            }
            return true;
        }
        private void changeP_Click(object sender, EventArgs e)
        {
            Console.WriteLine(ValidatePassword(pwd.Text).ToString());
            if (userName.Text == "")
                MessageBox.Show("Please do enter user name it is mandatory!", "Validation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            else if (pwd.Text == "")
                MessageBox.Show("Password Mandatory!", "Password Validation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            else if (pwd.Text.Length < 6)
                MessageBox.Show("Minimum 6 characters required", "Password Validation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            else if (!ValidatePassword(pwd.Text))
                MessageBox.Show("Check the criteria for password; Minimum 1 special character, number and Uppercase alphabet", "Password Validatation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (newPwd.Text != pwd.Text)
                MessageBox.Show("Re enter password carefully!");
            else
            {
                try
                {
                    con1.Open();
                    string cmdstr = "update user set password ='" + pwd.Text + "' where name='" + userName.Text + "';";
                    MySqlCommand cmd = new MySqlCommand(cmdstr, con1);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password changed successfully!!", "Change Password");
                    Form1 newform = new Form1();
                    newform.Show();
                    this.Close();

                }
                catch (Exception test)
                {
                    MessageBox.Show("Unable to change the password due to error! " + test.Message);
                }

            }
        }

        private void changepwd_Load(object sender, EventArgs e)
        {
            userName.Text = Program.userName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newformm = new Form1();
            newformm.Show();
            this.Close();
        }
    }
}
