using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_gestion_des_ventes
{
    public partial class dashboard1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );
        public dashboard1()
        {
            InitializeComponent(); 
        }

        private void facture_Click(object sender, EventArgs e)
        {
            factures f2 = new factures();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();

            this.Hide();
        }

        private void client_Click(object sender, EventArgs e)
        {
            clients f2 = new clients();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();

            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            departements f2 = new departements();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();

            this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            commandes f2 = new commandes();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            produits f2 = new produits();
             f2.AllowDrop = true;
             f2.Show();
             f2.BringToFront();
             this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            categories f2 = new categories();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLog f2 = new FormLog();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        { 
           


        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

            if(FormLog.phot== "karim@gmail.com")
            {
                pictureBox3.Image = gestion_ventes.Properties.Resources.Sans_titre_modified;
                textBox3.Text = "Nom : Karim";
                textBox2.Text = "ID : 157488";
            }
            else
            {
                pictureBox3.Image = gestion_ventes.Properties.Resources.khaoul;
                textBox3.Text = "Nom : Khaoula";
                textBox2.Text = "ID : 164775";
            }
        }
    }
}
