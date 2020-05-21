using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker2._0
{
    public partial class Form1 : Form
    {
        public int cnt = 1;
        public Form1()
        {
            InitializeComponent();
            customDesign();
            openChildForm(new Login(this));
            this.navpanel1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void customDesign()
        {
            actpanel1.Visible = false;
            dietpanel1.Visible = false;

        }
        public void hidesub()
        {
            if (actpanel1.Visible == true)
                actpanel1.Visible = false;
            if (dietpanel1.Visible == true)
                dietpanel1.Visible = false;

        }
        private void showsub(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesub();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void dietmain_Click(object sender, EventArgs e)
        {
            showsub(dietpanel1);
        }

       
        private Form activenow = null;
        public void toggleNav()
        {
            if (navpanel1.Visible == false)
                navpanel1.Visible = true;
            else
                navpanel1.Visible = false;
        }
        public void openChildForm(Form child)
        { 

            if (activenow != null)
                activenow.Close();
            activenow = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            childpanel1.Controls.Add(child);
            childpanel1.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void HomePage_Click(object sender, EventArgs e)
        {

        }

        private void goal_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Goals(this));
            hidesub();
        }

        private void profile_Click_1(object sender, EventArgs e)
        {
            openChildForm(new UserPage(this));
            hidesub();
        }

        private void dietlog_Click_1(object sender, EventArgs e)
        {
            openChildForm(new DietLog());
            hidesub();
        }

        private void newdiet_Click_1(object sender, EventArgs e)
        {
            openChildForm(new DietMaster());
            hidesub();
        }

        private void diettoday_Click_1(object sender, EventArgs e)
        {
            openChildForm(new DDietToday());
            hidesub();

        }

        private void numbersdiet_Click_1(object sender, EventArgs e)
        {
            openChildForm(new dietCum());
            hidesub();
        }

        private void actMain_Click_1(object sender, EventArgs e)
        {
            showsub(actpanel1);

        }

        private void acttoday_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ActDReport());
            hidesub();

        }

        private void actmaster_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ActivityMaster());
            hidesub();
        }

        private void actlog_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ActLog());
            hidesub();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Login(this));
            navpanel1.Visible = false;
            Program.userName = "";
        }

        private void actnumbers_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ActCum());
            hidesub();

        }

        

       

        private void HomePage_Click_1(object sender, EventArgs e)
        {
            openChildForm(new HomePage(this));
            hidesub();
        }
    }
}
