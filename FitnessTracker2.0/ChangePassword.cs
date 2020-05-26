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
    public partial class ChangePassword : Form
    {
        public static string constr1 = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        MySqlConnection condatabase = new MySqlConnection(constr1);        
        int uid = 0;
        public ChangePassword()
        {
            InitializeComponent();
            findingUser();
        }
        void findingUser()
        {
            condatabase.Open();
            string Query = "select * from user where name='" + Program.userName + "';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(Query, condatabase);
                MySqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    uid = myReader.GetInt32("UserID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            condatabase.Close();
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

        private void UpdatePWD_Click(object sender, EventArgs e)
        {
            string pass = string.Empty;
            //condatabase.Open();
            string Query = "select * from user where Userid=" + uid + ";";
            MySqlCommand cmd = new MySqlCommand(Query, condatabase);
            MySqlDataReader myReader = cmd.ExecuteReader();
            while(myReader.Read())
            {
                pass = myReader.GetString("Password");
            }
            condatabase.Close();
            if (CurrentPWD.Text == "")
                MessageBox.Show("Please fill all dateils");
            else if (NewPWD.Text == "")
                MessageBox.Show("please fill all details");
            else if (ConfirmPWD.Text == "")
                MessageBox.Show("Please fill all details");
            else if (!ValidatePassword(NewPWD.Text))
            {
                MessageBox.Show("Check the criteria for password; Minimum 1 special character, number and Uppercase alphabet", "Password Validatation", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // NewPWD.ForeColor = Color.Red;
            }
            else if (NewPWD.Text != ConfirmPWD.Text)
            {
                MessageBox.Show("Re enter the password carefully");
               // ConfirmPWD.ForeColor = Color.Red;
            }
            else if (pass != CurrentPWD.Text)
            {
                MessageBox.Show("Enter your current password correclty");
                //CurrentPWD.ForeColor = Color.Red;
            }
            else
            {
                condatabase.Open();
                Query = "update user set Password='" + NewPWD.Text+ "' where Userid=" + uid + ";";
                cmd = new MySqlCommand(Query, condatabase);
                try
                {
                    cmd.ExecuteNonQuery();
                    msgBox msg = new msgBox("Password Updated Successfully");
                    msg.StartPosition = FormStartPosition.Manual;

                    msg.Left = 1000;
                    msg.Top = 500;

                    msg.ShowDialog();
                }
                catch(Exception ex)
                { }

            }
            condatabase.Close();

            
        }

        private void CurrentPWD_TextChanged(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;
        }

        private void NewPWD_TextChanged(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;
        }

        private void ConfirmPWD_TextChanged(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;
        }
    }
}
