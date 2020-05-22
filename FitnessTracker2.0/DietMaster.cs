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
    public partial class DietMaster : Form
    {
        public static string constr = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        MySqlConnection con1 = new MySqlConnection(constr);
        public static string res = "1";
        public DietMaster()
        {
            InitializeComponent();
            FindDID();
        }


        public int FindDID()
        {
            string cmd = "select max(dietid)+1 as did from ft.DietMaster;";
            MySqlCommand cmds = new MySqlCommand(cmd, con1);
            MySqlDataReader reader;
            try
            {
                con1.Open();
                reader = cmds.ExecuteReader();

                if (reader.Read() && !reader.IsDBNull(0))
                {
                    res = reader.GetInt16(0).ToString();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            con1.Close();
            return 0;
        }

        private void DietMaster_Load(object sender, EventArgs e)
        {
            string Query = "select DietID,DietName from ft.DietMaster";
            MySqlCommand cmds = new MySqlCommand(Query, con1);
            MySqlDataReader reader;
            try
            {
                con1.Open();
                reader = cmds.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader.GetString(0);
                    string name = reader.GetString(1);
                    listBox1.Items.Add(id + ". " + name);
                }

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            con1.Close();
        }

        private void EXISTING_Enter(object sender, EventArgs e)
        {

            string cmds = "select * from ft.DietMaster";
            MySqlCommand cmd = new MySqlCommand(cmds, con1);
            MySqlDataReader reader;
            try
            {
                con1.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader.GetString("DietName");
                    DietName.AppendText(name);
                }
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message);
            }
            con1.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (DietName.Text == "" && carbo.Text == "" && prot.Text == "" && vit.Text == "" && fat.Text == "" && cal.Text == "" && other.Text == "")
            {
                MessageBox.Show("Please fill all the details ");
            }

            // string calories = cal.ToString();
            // string car = carbo.ToString();
            // string pro = prot.ToString();
            // string vitamin = vit.ToString();
            // string fats = fat.ToString();
            // string others = other.ToString();
            //string others = textBox7.ToString();
            else
            {
                try
                {
                    FindDID();
                    string JUNK = string.Empty;
                    if (Yes.Checked && No.Checked)
                        MessageBox.Show("Select whether the food is junk or not! Enter one value please!");
                    if (Yes.Checked)
                        JUNK = "Yes";
                    else if (No.Checked)
                        JUNK = "No";
                    else
                        MessageBox.Show("Select yes or no");
                    con1.Open();
                    string Query = "insert into DietMaster values (" + res + ",' " + DietName.Text + " ',' " + carbo.Text + " ', ' " + prot.Text + " ',' " + vit.Text + " ',' " + fat.Text + " ', ' " + cal.Text + " ',' " + other.Text + " ',' " + JUNK + " ');";
                    MySqlCommand cmd = new MySqlCommand(Query, con1);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Details saved successfully");


                    listBox1.Items.Add(res + " . " + DietName.Text);
                    Resettingvalues();



                }
                catch (MySqlException er)
                {
                    MessageBox.Show(er.Message);
                }
                catch (SystemException err)
                {
                    MessageBox.Show(err.Message);
                }
                con1.Close();
            }
            void Resettingvalues()
            {
                DietName.Text = "";
                carbo.Text = "";
                prot.Text = "";
                vit.Text = "";
                fat.Text = "";
                cal.Text = "";
                other.Text = "";
                Yes.Checked = false;
                No.Checked = false;
            }







        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click_1(object sender, EventArgs e)
        {
            if (DietName.Text == "" && carbo.Text == "" && prot.Text == "" && vit.Text == "" && fat.Text == "" && cal.Text == "" && other.Text == "")
            {
                MessageBox.Show("Please fill all the details ");
            }

            // string calories = cal.ToString();
            // string car = carbo.ToString();
            // string pro = prot.ToString();
            // string vitamin = vit.ToString();
            // string fats = fat.ToString();
            // string others = other.ToString();
            //string others = textBox7.ToString();
            else
            {
                try
                {
                    FindDID();
                    string JUNK = string.Empty;
                    if (Yes.Checked && No.Checked)
                        MessageBox.Show("Select whether the food is junk or not! Enter one value please!");
                    if (Yes.Checked)
                        JUNK = "Yes";
                    else if (No.Checked)
                        JUNK = "No";
                    else
                        MessageBox.Show("Select yes or no");
                    con1.Open();
                    string Query = "insert into DietMaster values (" + res + ",'" + DietName.Text + " ',' " + carbo.Text + " ', ' " + prot.Text + " ',' " + vit.Text + " ',' " + fat.Text + " ', ' " + cal.Text + " ',' " + other.Text + " ',' " + JUNK + " ');";
                    MySqlCommand cmd = new MySqlCommand(Query, con1);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Details saved successfully");
                    msgBox msg = new msgBox("Saved Successfully!!!");
                    msg.StartPosition = FormStartPosition.Manual;
                    msg.Left = 300;
                    msg.Top = 200;
                   msg.ShowDialog();


                    listBox1.Items.Add(res + " . " + DietName.Text);
                    Resettingvalues();



                }
                catch (MySqlException er)
                {
                    MessageBox.Show(er.Message);
                }
                catch (SystemException err)
                {
                    MessageBox.Show(err.Message);
                }
                con1.Close();
            }
            void Resettingvalues()
            {
                DietName.Text = "";
                carbo.Text = "";
                prot.Text = "";
                vit.Text = "";
                fat.Text = "";
                cal.Text = "";
                other.Text = "";
                Yes.Checked = false;
                No.Checked = false;
            }







        }
    }
}
