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
    public partial class activityGoatEdit : Form
    {
        int i = 1, uid = 0;
        public static string constr1 = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        MySqlConnection condatabase = new MySqlConnection(constr1);
        public activityGoatEdit()
        {
            InitializeComponent();
            FindingUser();
            setact();
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
        void setact()
        {

            Label label;
            TextBox textbox;
            condatabase.Open();
            string Query = "select * from ft.mustdo natural join ft.activitymaster where userid=" + uid + ";";
            MySqlCommand cmd = new MySqlCommand(Query, condatabase);
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                label = new Label();
                label.Name = "lbl" + i.ToString();
                //label.Tag = i.ToString();
                label.Text = myReader.GetString("ActivityName");
                label.AutoSize = true;
                label.Location = new Point(219,120+ i * 60);
                label.Font = new Font("Microsoft Sans Serif", 10);
                textbox = new TextBox();
                textbox.Text = myReader.GetString("ActDuration");
                //textbox.Tag = i.ToString();
                textbox.Name = "txt" + i.ToString();
                textbox.Location = new Point(393, 120+60 * i);
                textbox.Font = new Font("Microsoft Sans Serif", 10);
                this.Controls.Add(label);
                this.Controls.Add(textbox);
                i++;
            }
            condatabase.Close();
        }

       
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            int k;
            string[] t = new string[50];
            string[] s = new string[50];
            for (k = 1; k < i; k++)
            {
                t[k] = ((TextBox)this.Controls["txt" + k.ToString()]).Text;
                s[k] = ((Label)this.Controls["lbl" + k.ToString()]).Text;
            }
            for (int j = 1; j < k; j++)
            {
                condatabase.Open();
                string Query = "update  mustdo set Actduration=" + t[j] + " where ActivityID in (select ActivityID from activitymaster where ActivityName='" + s[j] + "' and userid=" + uid + ");";
                MySqlCommand cmd = new MySqlCommand(Query, condatabase);
                cmd.ExecuteNonQuery();
                condatabase.Close();
            }
            msgBox msg = new msgBox("Updated Successfully");
            msg.StartPosition = FormStartPosition.Manual;
            msg.Left = 300;
            msg.Top = 200;
            msg.Show();

        }

       


    }
}
