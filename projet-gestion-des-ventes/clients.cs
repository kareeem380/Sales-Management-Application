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
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace projet_gestion_des_ventes
{
    public partial class clients : Form
    {
        bool sidebarExpand;
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


        public clients()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormLog f2 = new FormLog();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();

            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void produit_Load(object sender, EventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void facture_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void profil_Click(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {

            if (sidebarExpand)
            {
                sidebar.Width = -10;
                MenuCon.Width = -10;
                departement.Width = -10;
                categorie.Width = -10; produit.Width = -10;
                commande.Width = -10;
                client.Width = -10;
                profil.Width = -10;
                facture.Width = -10;
                if ((sidebar.Width == sidebar.MinimumSize.Width) && (MenuCon.Width == MenuCon.MinimumSize.Width) && (client.Width == client.MinimumSize.Width) && (profil.Width == profil.MinimumSize.Width) && (facture.Width == facture.MinimumSize.Width))
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }

            }
            else
            {
                sidebar.Width += 10;
                profil.Width += 10;
                MenuCon.Width += 10;
                client.Width += 10;
                produit.Width += 10;
                commande.Width += 10;
                categorie.Width += 10;
                departement.Width += 10;
                facture.Width += 10;

                if ((sidebar.Width == sidebar.MaximumSize.Width) && (MenuCon.Width == MenuCon.MaximumSize.Width) && (client.Width == client.MaximumSize.Width) && (profil.Width == produit.MaximumSize.Width) && (commande.Width == commande.MaximumSize.Width) && (categorie.Width == categorie.MaximumSize.Width) && (departement.Width == departement.MaximumSize.Width) && (produit.Width == produit.MaximumSize.Width) && (facture.Width == facture.MaximumSize.Width))
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }

            }
        }

        private void sidebar_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void MenuCon_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            
        }

        private void departement_Click(object sender, EventArgs e)
        {
            departements f2 = new departements();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();

            this.Hide();
        }

        private void client_Click(object sender, EventArgs e)
        {

        }

        private void facture_Click_1(object sender, EventArgs e)
        {
            factures f2 = new factures();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();

            this.Hide();
        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            FormLog f2 = new FormLog();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();
        }
    }
}
