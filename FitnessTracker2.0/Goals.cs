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
    public partial class Goals : Form
    {
        public static string constr1 = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        MySqlConnection condatabase = new MySqlConnection(constr1);
        Form1 myparent;
        int j = 0, uid = 0;
        public Goals(Form1 source)
        {
            this.myparent = source;
            InitializeComponent();
            FindingUser();
            
            goalselected(0);
            selectact();
            GoalDiet();
        }
        void calculateRecommendation()
        {
            try
            {
                condatabase.Open();
                string Query = "select weight,category from user where userid=" + uid;

                MySqlCommand cmd = new MySqlCommand(Query, condatabase);
                MySqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    int w = dr.GetInt32("weight");
                    double ratio;
                    string cat = dr.GetString("category");
                    if (cat == "High physical Activity")
                        ratio = 1.75;
                    else if (cat == "Low physical Activity")
                        ratio = 1.25;
                    else
                        ratio = 1.55;

                    double rec = 44 * w * ratio;
                    Console.WriteLine(cat);
                    AddDietGoal.Text = "You are recommended for a minimum diet goal of " + rec.ToString() + " calories ! Add some 500 cal or something depending on your workout plan!!";

                }
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }
        void selectact()
        {
            condatabase.Open();
            string Query = "select * from activitymaster;";
            MySqlCommand cmd = new MySqlCommand(Query, condatabase);
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                string sName = myReader.GetString("ActivityName");
                actname.Items.Add(sName);
            }
            condatabase.Close();
        }
        void goalselected(int i)
        {
            string Query;
            condatabase.Open();
            if (i == 0)
            {
                Query = "select * from ft.activitymaster where ActivityID in (select ActivityID from ft.mustdo where userid=" + uid + ") ;";

            }
            else
            {
                Query = "select * from ft.activitymaster where ActivityID=" + i + "; ";

            }
            MySqlCommand cmd = new MySqlCommand(Query, condatabase);
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();

            while (myReader.Read())
            {
                string sName = myReader.GetString("ActivityName");
                SetUrGoal.Items.Add(sName);
                SetUrGoal.SetItemChecked(j, true);
                j++;
            }
            condatabase.Close();
        }
       


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            myparent.openChildForm(new activityGoatEdit());
            myparent.hidesub();
        }
        void GoalDiet()
        {
            condatabase.Open();
            decimal gl = 0;
            string Query = "select * from user where Userid=" + uid + ";";
            try
            {
                MySqlCommand cmd = new MySqlCommand(Query, condatabase);
                MySqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    gl = myReader.GetDecimal("GoalCalorieIntake");
                }
                //string glS = Convert.ToString(gl);
                if (gl == 0)
                {
                    AddDiet.Text = "ADD";
                    condatabase.Close();
                    Console.WriteLine("does it recommend?");
                    calculateRecommendation();
                    
                    

                }
                else
                {
                    DietGoal.Text = Convert.ToString(gl);
                    AddDiet.Text = "EDIT";
                    AddDietGoal.Text = "Calories To Be Taken : " + gl;
                    //SetUrGoal.Items.Add("Calories To Be Taken-"+gl);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            condatabase.Close();

        }
        void FindingUser()
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

        private void AddDiet_Click(object sender, EventArgs e)
        {

            try
            {
                string goal = DietGoal.Text;
                double gl = Convert.ToDouble(goal);
                string Query = " update user set GoalCalorieIntake=" + gl + " where Userid=" + uid + ";";
                condatabase.Open();
                MySqlCommand cmd = new MySqlCommand(Query, condatabase);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Added successfully");
                msgBox msg = new msgBox("Editted Successfully!!!");
                msg.StartPosition = FormStartPosition.Manual;
                msg.Left = 1000;
                msg.Top = 500;

                msg.ShowDialog();

                AddDiet.Enabled = false;
                condatabase.Close();
                GoalDiet();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void actname_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            condatabase.Open();
            string Query1 = "select * from activitymaster a join mustdo m on a.activityid=m.activityid where userid=" + uid + ";";
            MySqlCommand cmd = new MySqlCommand(Query1, condatabase);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string actname1 = reader.GetString("Activityname");
                if (actname.Text == actname1)
                {                   
                    addact.Enabled = false;
                    MessageBox.Show("" + actname.Text + " is already there");
                    break;
                }
                else
                    addact.Enabled = true;
            }
            condatabase.Close();
        }

        private void addact_Click(object sender, EventArgs e)
        {
            condatabase.Open();
            string sName = actname.Text;
            string Query = "select * from ft.activitymaster where ActivityName='" + sName + "';";
            MySqlCommand cmddb = new MySqlCommand(Query, condatabase);
            MySqlDataReader myReader;
            try
            {
                int id = 0;
                myReader = cmddb.ExecuteReader();
                while (myReader.Read())
                {
                    id = myReader.GetInt32("ActivityID");
                    condatabase.Close();
                    goalselected(id);
                    break;

                }
                condatabase.Open();
                if (id != 0)
                {
                    string Query3 = "insert into ft.mustdo values(" + uid + "," + id + "," + actdur.Text + ")";
                    MySqlCommand cmd = new MySqlCommand(Query3, condatabase);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Saved Successfully");
                    msgBox msg = new msgBox("Saved Successfully!!!");
                    msg.StartPosition = FormStartPosition.Manual;
                    msg.Left = 1000;
                    msg.Top = 500;
                    msg.ShowDialog();
                    //this.Close();
                    //myparent.openChildForm(new HomePage(myparent));
                    

                }
                condatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            // string Query1 = "insert into user(;";
        }

        private void Goals_Load(object sender, EventArgs e)
        {

        }

        private void DietGoal_TextChanged_1(object sender, EventArgs e)
        {
            AddDiet.Enabled = true;
        }

        
    }
}
