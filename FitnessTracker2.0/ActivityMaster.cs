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
    public partial class ActivityMaster : Form
    {
        public static string constr = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        MySqlConnection con1 = new MySqlConnection(constr);
        public static string res = "1";
        public ActivityMaster()
        {
            InitializeComponent();
        }
        public int findAID()
        {
            string cmds = "Select max(Activityid)+1 as id from ft.activitymaster";
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

        private void ActivityMaster_Load(object sender, EventArgs e)
        {
            string Query = "select ActivityID,ActivityName from ActivityMaster";
            MySqlCommand cmd = new MySqlCommand(Query, con1);
            try
            {
                con1.Open();
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string id = myreader.GetString(0);
                    string name = myreader.GetString(1);
                    listBox1.Items.Add(id + ") " + name);
                }

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            con1.Close();
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "" || cal.Text == "")
            {
                MessageBox.Show("Please fill all values");
            }
            else
            {
                try
                {
                    findAID();
                    con1.Open();
                    string cmdquery = "insert into activitymaster values(" + res + ",'" + nameBox.Text + "','" + cal.Text + "');";
                    MySqlCommand cmd = new MySqlCommand(cmdquery, con1);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Successfully SAVED");
                    msgBox msg = new msgBox("Saved Successfully!!!");
                    msg.StartPosition = FormStartPosition.Manual;
                    msg.Left = 300;
                    msg.Top = 200;
                    msg.ShowDialog();
                    listBox1.Items.Add(res + ") " + nameBox.Text);
                    nameBox.Text = ""; cal.Text = "";


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con1.Close();
            }
        }

    }
}
