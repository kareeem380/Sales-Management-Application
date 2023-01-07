using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_gestion_des_ventes
{
    
    public partial class factures : Form
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
        public factures()
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

        private void factures_Load(object sender, EventArgs e)
        {
            if (FormLog.phot == "karim@gmail.com")
            {
                pictureBox2.Image = gestion_ventes.Properties.Resources.Sans_titre_modified;
                textBox8.Text = "Nom : Karim";
                textBox1.Text = "ID : 157488";
            }
            else
            {
                pictureBox2.Image = gestion_ventes.Properties.Resources.khaoul;
                textBox8.Text = "Nom : Khaoula";
                textBox1.Text = "ID : 164775";
            }
            // TODO: This line of code loads data into the '_gestion_des_ventesDataSet8.commande_details' table. You can move, or remove it, as needed.
            this.commande_detailsTableAdapter4.Fill(this._gestion_des_ventesDataSet8.commande_details);
            // TODO: This line of code loads data into the '_gestion_des_ventesDataSet5.commande' table. You can move, or remove it, as needed.
            this.commandeTableAdapter.Fill(this._gestion_des_ventesDataSet5.commande);
            // TODO: This line of code loads data into the '_gestion_des_ventesDataSet7.commande_details' table. You can move, or remove it, as needed.
            //this.commande_detailsTableAdapter3.Fill(this._gestion_des_ventesDataSet7.commande_details);
            // TODO: This line of code loads data into the '_gestion_des_ventesDataSet6.commande_details' table. You can move, or remove it, as needed.
            //this.commande_detailsTableAdapter2.Fill(this._gestion_des_ventesDataSet6.commande_details);
            // TODO: This line of code loads data into the '_gestion_des_ventesDataSet5.facture' table. You can move, or remove it, as needed.
            this.factureTableAdapter.Fill(this._gestion_des_ventesDataSet5.facture);
            // TODO: This line of code loads data into the '_gestion_des_ventesDataSet5.commande_details' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the '_gestion_des_ventesDataSet1.commande_details' table. You can move, or remove it, as needed.
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        

      

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormLog f2 = new FormLog();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();

        }

        private void menuButton_Click_1(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            departements f2 = new departements();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();

            this.Hide();
        }

        private void facture_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click_3(object sender, EventArgs e)
        {
            this.Hide();
            FormLog f2 = new FormLog();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();
        }

       

        private void departement_Click_1(object sender, EventArgs e)
        {
            departements f2 = new departements();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();

            this.Hide();
        }

        private void produit_Click(object sender, EventArgs e)
        {
            produits f2 = new produits();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();
            this.Hide();
        }

        private void categorie_Click(object sender, EventArgs e)
        {
            categories f2 = new categories();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();

            this.Hide();
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
                popo.Width = -10;
                profil.Width = -10;
                facture.Width = -10;
                if ((sidebar.Width == sidebar.MinimumSize.Width) && (MenuCon.Width == MenuCon.MinimumSize.Width) && (popo.Width == popo.MinimumSize.Width) && (profil.Width == profil.MinimumSize.Width) && (facture.Width == facture.MinimumSize.Width))
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
                popo.Width += 10;
                produit.Width += 10;
                commande.Width += 10;
                categorie.Width += 10;
                departement.Width += 10;
                facture.Width += 10;

                if ((sidebar.Width == sidebar.MaximumSize.Width) && (MenuCon.Width == MenuCon.MaximumSize.Width) && (popo.Width == popo.MaximumSize.Width) && (profil.Width == produit.MaximumSize.Width) && (commande.Width == commande.MaximumSize.Width) && (categorie.Width == categorie.MaximumSize.Width) && (departement.Width == departement.MaximumSize.Width) && (produit.Width == produit.MaximumSize.Width) && (facture.Width == facture.MaximumSize.Width))
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }

            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void MenuCon_Click_1(object sender, EventArgs e)
        {

        }

        private void sidebar_Click_1(object sender, EventArgs e)
        {

        }

        private void profil_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void commande_Click_1(object sender, EventArgs e)
        {
            commandes f2 = new commandes();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();
            this.Hide();
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void popo_Click(object sender, EventArgs e)
        {
            clients f2 = new clients();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();

            this.Hide();
        }

        private void facture_Click(object sender, EventArgs e)
        {
            factures f2 = new factures();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();

            this.Hide();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void prod_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JBLMVJ1;Initial Catalog=gestion-des-ventes;Integrated Security=True");
            con.Open();
            SqlCommand cmd2 = new SqlCommand("select p.prod_name from [gestion-des-ventes].[dbo].[produit]  p, [gestion-des-ventes].[dbo].[commande_details] c where p.prod_id=c.prod_id and p.prod_id=14");
            
            SqlCommand cmd = new SqlCommand("SELECT c.[comd_id], p.[prod_name], c.[prod_price], c.[prod_quantity], c.[ttp] FROM [gestion-des-ventes].[dbo].[commande_details] c JOIN [gestion-des-ventes].[dbo].[produit] p ON c.prod_id = p.prod_id WHERE c.comd_id = @comd_id", con);
            cmd.Parameters.AddWithValue("@comd_id", prod.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tableCom = new DataTable();
            da.Fill(tableCom);
            guna2DataGridView2.DataSource = tableCom;
            guna2DataGridView2.Columns[0].HeaderText = "ID ";
            guna2DataGridView2.Columns[1].HeaderText = "Nom ";
            guna2DataGridView2.Columns[2].HeaderText = "Prix ";
            guna2DataGridView2.Columns[3].HeaderText = "Quantité ";
            guna2DataGridView2.Columns[4].HeaderText = "Total ";
        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {


            // Add a title to the document
            e.Graphics.DrawString("Facture", new Font("Arial", 40, FontStyle.Bold), Brushes.Black, new Point(320, 30));
            e.Graphics.DrawString("ID Client =  "+ prod.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(150, 120));
            // Add some text to the document
            e.Graphics.DrawString("Date: " + DateTime.Now.ToString("dd/MM/yyyy"), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(150, 140));
            e.Graphics.DrawString("Détails de votre facture :", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(150, 160));
            

            // Connect to the database and execute the query
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-JBLMVJ1;Initial Catalog=gestion-des-ventes;Integrated Security=True");
            cn.Open();
            string query = "SELECT  p.[prod_name], c.[prod_price], c.[prod_quantity], c.[ttp] FROM [gestion-des-ventes].[dbo].[commande_details] c JOIN [gestion-des-ventes].[dbo].[produit] p ON c.prod_id = p.prod_id WHERE c.comd_id = @comd_id";

            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@comd_id", prod.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            // Draw the table header
            int y = 75;
            string dashligne = "------------------------------------------------------------------------------------------------------";
            int yy = 200;
            e.Graphics.DrawString(dashligne, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(140,75+yy));
            e.Graphics.DrawString("Nom Produit : ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(150, 100+yy));
            e.Graphics.DrawString("Price : ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(300, 100+yy));
            e.Graphics.DrawString("Quantité : ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(450, 100+yy));
            e.Graphics.DrawString("Total : ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(600, 100+yy));
            e.Graphics.DrawString(dashligne, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(140, 125+yy));
            y = y+75+yy;

            decimal total = 0;
            while (reader.Read())
            {
                // Print the value of the current row
                int x = 150;
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    e.Graphics.DrawString(reader[i].ToString(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(x, y));
                    x += 150;
                }
                y += 30;

                // Calculate the total
                
                total += reader.GetOrdinal("ttp");
            }
            y += 30;
            float r;

            string connectionstring = "Data Source=DESKTOP-JBLMVJ1;Initial Catalog=gestion-des-ventes;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT SUM(ttp) as total FROM commande_details WHERE comd_id = @comd_id", conn);
                cmd2.Parameters.AddWithValue("@comd_id", prod.Text);
                object result = cmd2.ExecuteScalar();
                r = (int)result;
                conn.Close();
            }

            // Print the total
            e.Graphics.DrawString("Total: " + r.ToString("C"), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(600, y));
            e.Graphics.DrawString("Thank you for your business!", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(150, y+20));





            // Close the connection and reader
            reader.Close();
            cn.Close();



        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
