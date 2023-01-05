using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_gestion_des_ventes
{
    public partial class spinners : Form
    {
        public spinners()
        {
            InitializeComponent();
            circularProgressBar1.Value = 0;
        }

        private void spinners_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBar1.Value += 5;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString() + "%"; 
            if (circularProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                this.Hide();
                dashboard1 f2 = new dashboard1();
                f2.AllowDrop = true;
                f2.Show();
                f2.BringToFront();
            }
        }

        private void Prog_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
