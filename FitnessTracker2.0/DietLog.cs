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
using System.Drawing.Imaging;

namespace FitnessTracker2._0
{
    public partial class DietLog : Form
    {
        public static string constr = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        //private readonly object dietname;
        MySqlConnection con1 = new MySqlConnection(constr);
        int logno1 = 0, check = 0;
        int uid = 0;
        
        public DietLog()
        {
            InitializeComponent();
            fillcombo();
            FindingUser();
            dietintake();
            AlreadyTaken();
            


        }

       
        void FindingUser()
        {

            con1.Open();
            string Query = "select * from user where name='" + Program.userName + "';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(Query, con1);
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
            con1.Close();
        }

        void fillcombo()
        {
            con1.Open();
            string Query = "select * from ft.dietmaster";
            MySqlCommand cmdDatabase = new MySqlCommand(Query, con1);
            MySqlDataReader myReader;
            try
            {
                myReader = cmdDatabase.ExecuteReader();
                while (myReader.Read())
                {
                    string sName = myReader.GetString("DietName");
                    diet.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con1.Close();

        }

        void AlreadyTaken()
        {
            con1.Open();
            string Query = "";
            if (logno1 == 0)
            {
                Query = "select  * from dietchart d join dietmaster m on d.DietId=m.DietId where dietDate=CURDATE() and UserId=" + uid + ";";
            }
            else
            {
                Query = " select  * from dietchart d join dietmaster m on d.DietId=m.DietId where dietDate=CURDATE() and UserId=" + uid + " and Logno=" + logno1 + ";";
            }
            MySqlCommand cmd = new MySqlCommand(Query, con1);
            MySqlDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                string sName = myReader.GetString("DietName");
                diettoday.Items.Add(sName);
                diettoday.SetItemChecked(check, true);
                logno1++;
                check++;
            }
            con1.Close();
        }

        

        private void dietsubmit_Click_1(object sender, EventArgs e)
        {
            int id = 0;
            decimal carbo = 0, protein = 0, vitamin = 0, fat = 0, calories = 0;
            con1.Open();
            string junk;

            string Query = "select max(LogNo)+1 as Log from dietchart;";
            MySqlCommand cmd = new MySqlCommand(Query, con1);
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

            con1.Close();
            con1.Open();
            //To get activity id from master table using activity name
            Query = "select * from dietmaster where dietname='" + diet.Text + "' ;";
            cmd = new MySqlCommand(Query, con1);
            try
            {
                // 
                // 
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    id = myReader.GetInt32("DietID");
                }
                // con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con1.Close();




            con1.Open();
            Query = "select * from dietmaster where dietname='" + diet.Text + "';";



            try
            {
                //condatabase.Open();
                cmd = new MySqlCommand(Query, con1);
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {

                    carbo = myReader.GetDecimal("Carbo");
                    protein = myReader.GetDecimal("Protein");
                    vitamin = myReader.GetDecimal("Vitamin");
                    fat = myReader.GetDecimal("Fat");
                    junk = myReader.GetString("isJunk");
                    calories = myReader.GetDecimal("CaloriesperS");
                }



                // MessageBox.Show("Result is" + temp +" "+x +" "+CaloriesBurnt);
                //condatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con1.Close();
            con1.Open();
            string serve = serving_no.Value.ToString();
            int x = Convert.ToInt32(serve);

            decimal c = x * carbo;
            decimal p = x * protein;
            decimal v = x * vitamin;
            decimal f = x * fat;
            // int j = x * junk;
            decimal ca = x * calories;
            Query = "insert into dietchart(LogNo,dietDate, noOfServings,Userid,DietID,carbo,Protein,Vitamin,Fat,CaloriesIntake,Remark) values("
                                        + logno1 + ",CURDATE()," + x + "," + uid + "," + id + "," + c + "," + p + "," + v + "," + f + "," + ca + ",'" + remarks.Text + "');";

            try
            {

                cmd = new MySqlCommand(Query, con1);
                cmd.ExecuteNonQuery();
                con1.Close();
                //dietintake();
                //MessageBox.Show("Saved Successfully");
                
                msgBox msg = new msgBox("Saved Sucessfully!!!");
                msg.StartPosition = FormStartPosition.Manual;
                msg.Left = 300;
                msg.Top = 200; 
                msg.ShowDialog();

                AlreadyTaken();


                //condatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con1.Close();
        }

        private void serving_no_ValueChanged(object sender, EventArgs e)
        {
            int id = 0;
            con1.Open();
            //To get activity id from master table using activity name
            string Query = "select * from dietmaster where dietname='" + diet.Text + "' ;";
            MySqlCommand cmd = new MySqlCommand(Query, con1);
            MySqlDataReader myReader;
            try
            {
                // 
                // 
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    id = myReader.GetInt32("DietID");
                }
                // con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con1.Close();
            decimal carbo = 0, protein = 0, vitamin = 0, fat = 0, calories = 0;
            string junk = "";
            con1.Open();
            Query = "select * from dietmaster where dietname='" + diet.Text + "';";



            try
            {
                //condatabase.Open();
                cmd = new MySqlCommand(Query, con1);
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {

                    carbo = myReader.GetDecimal("Carbo");
                    protein = myReader.GetDecimal("Protein");
                    vitamin = myReader.GetDecimal("Vitamin");
                    fat = myReader.GetDecimal("Fat");
                    junk = myReader.GetString("isJunk");
                    calories = myReader.GetDecimal("CaloriesperS");
                }



                // MessageBox.Show("Result is" + temp +" "+x +" "+CaloriesBurnt);
                //condatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con1.Close();
            string serve = serving_no.Value.ToString();
            int x = Convert.ToInt32(serve);

            decimal c = x * carbo;
            decimal p = x * protein;
            decimal v = x * vitamin;
            decimal f = x * fat;
            // int j = x * junk;
            decimal ca = x * calories;

            carbo_in.Text = c.ToString();
            protein_in.Text = p.ToString();
            vitamin_in.Text = v.ToString();
            fat_in.Text = f.ToString();
            //junks.Text = j.ToString();
            cal_in.Text = ca.ToString();

        }

        void dietintake()
        {
            con1.Open();
            string Query = "";
            if (logno1 == 0)
            {
                Query = "select * from dietmaster natural join dietchart where dietdate=CURDATE() and userid=" + uid + " and logno=" + logno1 + ";";

            }
            else
            {
                Query = "select * from dietmaster natural join dietchart  where dietdate=CURDATE() and userid=" + uid + " and logno=" + logno1 + ";";

            }
            MySqlCommand cmd = new MySqlCommand(Query, con1);
            MySqlDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                string sName = myReader.GetString("DietName");
                //diettoday.Items.Add(sName);


                //diettoday.Items.Add("Carbohydrates" + " - " + carbo + " mins ");
                //diettoday.SetItemChecked(check, true);
                logno1++;
                check++;
            }
            con1.Close();
        }
    }

}
