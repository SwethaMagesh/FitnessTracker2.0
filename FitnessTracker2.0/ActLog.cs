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
    public partial class ActLog : Form
    {
        public static string constr1 = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        MySqlConnection condatabase = new MySqlConnection(constr1);
        int logno1 = 0, check = 0;
        int uid = 0;
        public ActLog()
        {
            InitializeComponent();
            FindingUser();
            GoalsToDo();
            fillcombo();
            ActDone();
        }
        void fillcombo()
        {
            condatabase.Open();
            string Query = "select * from ft.activitymaster";
            MySqlCommand cmdDatabase = new MySqlCommand(Query, condatabase);
            MySqlDataReader myReader;
            try
            {
                myReader = cmdDatabase.ExecuteReader();
                while (myReader.Read())
                {
                    string sName = myReader.GetString("ActivityName");
                    actiname.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            condatabase.Close();
        }


        private void ActLog_Load(object sender, EventArgs e)
        {

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



        
        void GoalsToDo()
        {
            condatabase.Open();
            string goals;
            int j = 1;
            string Query = " select * from activitymaster natural join mustdo where userid=" + uid + ";";
            MySqlCommand cmd = new MySqlCommand(Query, condatabase);
            MySqlDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                string sName = myReader.GetString("Activityname");
                int dur = myReader.GetInt32("Actduration");
                goals = j + ". " + sName + " - " + dur + " mins";
                j++;
                goalsdo.Items.Add(goals);
            }

            condatabase.Close();
        }


        private void finishbut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void actsub_Click(object sender, EventArgs e)
        {
            int id = 0;
            float CaloriesBurnt = 0;
            string intensity = " ", ActName = "";
            //To insert the logno into the activitychart table
            condatabase.Open();
            string Query = "select max(LogNo)+1 as Log from activitychart;";
            MySqlCommand cmd = new MySqlCommand(Query, condatabase);
            MySqlDataReader myReader;
            try
            {
                //condatabase.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    logno1 = myReader.GetInt32("Log");
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            condatabase.Close();
            condatabase.Open();
            //To get activity id from master table using activity name
            Query = "select * from activitymaster where activityname='" + actiname.Text + "' ;";
            cmd = new MySqlCommand(Query, condatabase);
            try
            {
                // 
                // 
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    id = myReader.GetInt32("ActivityID");
                    CaloriesBurnt = myReader.GetFloat("CaloriesPerMin");
                    ActName = myReader.GetString("ActivityName");
                }
                // condatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            condatabase.Close();
            //To get type of activity(high or low)
            if (workhigh.Checked && worklow.Checked)
                MessageBox.Show("Select Anyone type");
            else if (workhigh.Checked)
                intensity = workhigh.Text;
            else if (worklow.Checked)
                intensity = worklow.Text;
            else
                MessageBox.Show("Please Enter the Workout Intensity");
            //To calculate the Calories burnt
            string duration = "";
            duration = actdur1.Text;
            int x = Convert.ToInt32(duration);


            float temp = x * CaloriesBurnt;
            condatabase.Open();
            Query = "insert into activitychart(LogNo,Adate,AID,Duration,Type,CaloriesBurnt,UserID,Remark) values(" + logno1 + ",CURDATE()," + id + "," + x + ",'" + intensity + "'," + temp + "," + uid + ",'" + actrem1.Text + "');";
            try
            {
                // condatabase.Open();
                cmd = new MySqlCommand(Query, condatabase);
                cmd.ExecuteNonQuery();
                condatabase.Close();
                ActDone();
                Console.WriteLine(logno1);
                //MessageBox.Show("Saved Successfully");
                msgBox msg = new msgBox("Saved Successfully!!!");
                msg.StartPosition = FormStartPosition.Manual;
                msg.Left = 300;
                msg.Top = 200;
                msg.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                condatabase.Close();
            }

        }


        void ActDone()
        {
            condatabase.Open();
            string Query = "";
            if (logno1 == 0)
            {
                Query = "select * from activitymaster join activitychart on activityid=aid where adate=CURDATE() and userid=" + uid + ";";
            }
            else
            {
                Query = "select * from activitymaster join activitychart on activityid=aid where adate=CURDATE() and userid=" + uid + " and logno=" + logno1 + ";";
            }
            MySqlCommand cmd = new MySqlCommand(Query, condatabase);
            MySqlDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                string sName = myReader.GetString("ActivityName");
                int dur = myReader.GetInt32("duration");
                acthis.Items.Add(sName + " - " + dur + " mins ");
                acthis.SetItemChecked(check, true);
                logno1++;
                check++;
            }
            condatabase.Close();
        }

    }
}
