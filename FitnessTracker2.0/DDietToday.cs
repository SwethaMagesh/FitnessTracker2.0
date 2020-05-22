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
    public partial class DDietToday : Form
    {
        public static string constr = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        MySqlConnection con1 = new MySqlConnection(constr);
        public string userid = "";
        public static int i = 0;
        public double calToday = 0.0, goals = 0.0;
        public double c, v, p, f, o;
        public DDietToday()
        {
           
            InitializeComponent();
            findUser();
            GeneratePie();

            FillJunkBox();
        }
        void findUser()
        {
            //find userid
            if (Program.userName == "")
            { MessageBox.Show("Please Login to view the report !"); this.Close(); }

            else
            {
                string q = "select userid from user where name ='" + Program.userName + "'";
                try
                {
                    con1.Open();
                    MySqlCommand cmd = new MySqlCommand(q, con1);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        userid = dr.GetString(0);

                    }

                }
                catch (MySqlException er)
                {
                    con1.Close();
                }
                con1.Close();
            }

        }
        void FillJunkBox()
        {
            try
            {
                int i = 1;
                con1.Open();
                string query = "select distinct a.Dietid,b.dietname from dietchart a join dietmaster b on a.dietid=b.dietid where b.isjunk='Yes' and a.dietdate=curdate() and userid=" + userid + " ; ";
                MySqlCommand cmd = new MySqlCommand(query, con1);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string junk1 = dr.GetString(1);
                    listBox1.Items.Add(i.ToString() + ". " + junk1);
                    i++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con1.Close();
        }
        void GeneratePie()
        {
            chart1.Titles.Add("Nutrient Proportion");

            try
            {
                con1.Open();
                string query = "Select * from dietcharttoday where userid=" + userid;
                MySqlCommand cmd = new MySqlCommand(query, con1);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    c = dr.GetDouble("c");
                    p = dr.GetDouble("p");
                    v = dr.GetDouble("v");
                    f = dr.GetDouble("f");
                    o = (dr.IsDBNull(5)) ? 0.00 : dr.GetDouble("o");
                    calToday = dr.GetDouble("cal");

                }
                dr.Close();

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error in DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                string query = "select GoalCalorieIntake  from user where userid=" + userid;
                MySqlCommand cmd = new MySqlCommand(query, con1);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    goals = dr.GetDouble(0);
                }

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error in DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con1.Close();
            chart1.Series[0].IsValueShownAsLabel = false;
            //chart1.Series[0].IsXValueIndexed = true;
            chart1.Series[0].Points.AddXY("Carbo", c);
            chart1.Series[0].Points.AddXY("Protein", p);
            chart1.Series[0].Points.AddXY("Vit", v);
            chart1.Series[0].Points.AddXY("Fat", f);
            chart1.Series[0].Points.AddXY("Others", o);
            progressBar1.Maximum = Convert.ToInt32(goals);

            int calDis = Convert.ToInt32(calToday);
            DESC.Text = "Consumed " + calToday.ToString() + " out of " + goals.ToString();
            if (calDis > progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Maximum;
                //MessageBox.Show("You Have EATEN EXCESS! ", "More cal today", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DESC.Text += " (You have EATEN EXCESS)";
            }
            else
            {
                progressBar1.Value = calDis;
            }


        }
    }
}
