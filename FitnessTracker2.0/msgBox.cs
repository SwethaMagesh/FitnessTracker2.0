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
    public partial class msgBox : Form
    {
        
        public msgBox(string text)
        {
            
            InitializeComponent();
            MsgTextedit.Text = text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void msgBox_Load(object sender, EventArgs e)
        {

        }

       
    }
}
