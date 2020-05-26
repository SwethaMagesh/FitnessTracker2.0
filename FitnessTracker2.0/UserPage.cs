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
using System.Globalization;
namespace FitnessTracker2._0
{
    public partial class UserPage : Form
    {
        public static string constr = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        MySqlConnection con1 = new MySqlConnection(constr);
        public static string res = "1", dob = "", cur = "";
        Form1 myparent;
        public UserPage(Form1 mypar)
        {
            InitializeComponent();
            this.myparent = mypar;
        }
        private bool phone_Text()
        {
            foreach (char a in phone.Text)
            {
                if (!(a >= '0' && a <= '9' || a == '+'))
                {
                    MessageBox.Show("Enter a valid phone number!", "Phone number validation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return false;
                }


            }


            if (phone.TextLength < 10)
            {
                MessageBox.Show("Enter a valid phone number!", "Phone number validation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return false;
            }

            else
                return true;

        }
       

        private bool email_Text()
        {
            //char[] test = { '@', '.' };
            if (email.Text.IndexOf('@') == -1)
                MessageBox.Show("Enter a valid Email address!", "Email validation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            else if (email.Text.IndexOf('.') == -1)
                MessageBox.Show("Enter a valid Email address!", "Email validation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            else
                return true;
            return false;

        }
        private void Updatenew_Click(object sender, EventArgs e)
        {
            dob = agebox.Value.ToString("yyyy-MM-dd");

            string gender = string.Empty;
            if (male.Checked && female.Checked)
                MessageBox.Show("Select one gender");
            if (male.Checked)
                gender = "Male";
            else if (female.Checked)
                gender = "Female";
            else
                MessageBox.Show("Please select a gender:");
            if (!email_Text())
                return;
            if (!phone_Text())
                return;

            string height = ht.Value.ToString();
            string weight = wt.Value.ToString();

            string Query = "update user set dob='" + dob + "',gender='" + gender + "',weight=" + weight + ",height=" + height + ",category='" + category.SelectedItem + "',phoneNo='" + phone.Text + "',email='" + email.Text + "' where name='" + name.Text + "' and userid=" + cur;
            MySqlCommand cmd = new MySqlCommand(Query, con1);


            try
            {

                con1.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Updated Successfully");
                msgBox msg = new msgBox("Updated Successfully!!!");
                msg.StartPosition = FormStartPosition.Manual;
                msg.Left = 1000;
                msg.Top = 500;

                msg.ShowDialog();

                con1.Close();
                this.Close();
                myparent.openChildForm(new HomePage(myparent));
                //  this.Close();

            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message);
            }
            catch (SystemException er)
            {
                MessageBox.Show(er.Message);
            }
            con1.Close();



        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            // findUID();
            string q = "Select dob,gender,height,weight,category,phoneNo,email,userid from user where name='" + Program.userName + "';";
            MySqlCommand cmd = new MySqlCommand(q, con1);
            name.Text = Program.userName;
            if (Program.userName != "")
            {

                try
                {
                    con1.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        cur = dr.GetString(7);
                        phone.Text = dr.GetString(5);
                        email.Text = dr.GetString(6);
                        ht.Value = dr.GetInt16(2);
                        wt.Value = dr.GetInt16(3);
                        category.SelectedItem = dr.GetString(4);
                        string temp = dr.GetString(1);
                        if (temp == "Male")
                            male.Checked = true;
                        else
                            female.Checked = true;
                        DateTime tempo = dr.GetDateTime(0);
                        // MessageBox.Show(tempo.ToString());
                        // DateTime test= DateTime.ParseExact(temp, "dd-MM-yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                        //MessageBox.Show(test.ToString());
                        agebox.Value = tempo;
                        name.Text = Program.userName;
                        Save.Enabled = false;
                        Save.Visible = false;

                    }
                    else
                    {
                        Updatenew.Enabled = false;
                        Updatenew.Visible = false;
                        ChangePWD.Enabled = false;
                        ChangePWD.Visible = false;
                    }
                }
                catch (MySqlException er)
                { MessageBox.Show(er.Message); }
                con1.Close();
            }

        }

        private void ChangePWD_Click(object sender, EventArgs e)
        {
            this.Close();
            myparent.openChildForm(new ChangePassword());
            myparent.toggleNav();
        }

        public int findUID()
        {
            string cmds = "Select max(userid)+1 as id from ft.user";
            MySqlCommand cmd = new MySqlCommand(cmds, con1);
            try
            {
                con1.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read() && !dr.IsDBNull(0))
                {

                    res = dr.GetInt16(0).ToString();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            con1.Close();
            return 0;
        }
        private void Save_Click(object sender, System.EventArgs e)
        {
            dob = agebox.Value.ToString("yyyy-MM-dd");
            findUID();

            string gender = string.Empty;
            if (male.Checked && female.Checked)
                MessageBox.Show("Select one gender");
            if (male.Checked)
                gender = "Male";
            else if (female.Checked)
                gender = "Female";
            else
            { MessageBox.Show("Please select a gender:"); return; }
            if (!email_Text())
                return;
            if (!phone_Text())
                return;

            string height = ht.Value.ToString();
            string weight = wt.Value.ToString();

            string Query = "insert into user (userid,name,password,dob,gender,phoneNo,email,height,weight,category,GoalCalorieIntake) values (" + res + ",'" + name.Text + "','" + CreateAcnt.password + "','" + dob + "','" + gender + "','" + phone.Text + "','" + email.Text + "'," + height + "," + weight + ",'" + category.SelectedItem.ToString() + "',0);";
            MySqlCommand cmd = new MySqlCommand(Query, con1);


            try
            {

                con1.Open();
                cmd.ExecuteNonQuery();


                //MessageBox.Show("Saved Successfully! Now you re ready to rock!! Please go set the goals ! You can check if our advised goals are sufficient ", "Getting Ready", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                msgBox msg = new msgBox("Profile Created Successfully!!Set your Goal and rock!!!!");
                msg.StartPosition = FormStartPosition.Manual;
                msg.Left = 1000;
                msg.Top = 500;

                msg.ShowDialog();
                this.Close();
                myparent.openChildForm(new HomePage(myparent, "Set your Goal and track your fitness"));



            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message);
            }
            catch (SystemException er)
            {
                MessageBox.Show(er.Message);
            }
            con1.Close();


        }

    }
}
