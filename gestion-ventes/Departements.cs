using System.Runtime.InteropServices;
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
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace projet_gestion_des_ventes
{
    public partial class departements : Form
    {
        bool sidebarExpand;
        public string id;

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
        public departements()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }
        private void departements_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JBLMVJ1;Initial Catalog=gestion-des-ventes;Integrated Security=True");
            //SqlConnection con = new SqlConnection("Data Source=MY-LAPTOP\\SQLEXPRESS;Initial Catalog=gestion-ventes;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(" SELECT * From [user]", con);
            DataTable dtable = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dtable);
            


        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            FormLog f2 = new FormLog();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();

            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebar_Click(object sender, EventArgs e)
        {

        }
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void client_Click(object sender, EventArgs e)
        {
            clients f2 = new clients();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();

            this.Hide();
        }

        private void facture_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            FormLog f2 = new FormLog();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();

            this.Hide();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void departements_Load_1(object sender, EventArgs e)
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
            // TODO: This line of code loads data into the '_gestion_des_ventesDataSet1.departement' table. You can move, or remove it, as needed.
            this.departementTableAdapter.Fill(this._gestion_des_ventesDataSet1.departement);

        }

        private void menuButton_Click_1(object sender, EventArgs e)
        {
           
        }

        private void departement_Click(object sender, EventArgs e)
        {

        }

        private void produit_Click_1(object sender, EventArgs e)
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

        private void commande_Click_1(object sender, EventArgs e)
        {
            commandes f2 = new commandes();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sidebarTimer_Tick_1(object sender, EventArgs e)
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

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLog f2 = new FormLog();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();
        }

        private void categorie_Click_1(object sender, EventArgs e)
        {
            categories f2 = new categories();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();

            this.Hide();
        }

        
       

        private void popo_Click(object sender, EventArgs e)
        {
            clients f2 = new clients();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();

            this.Hide();
        }

        private void facture_Click_1(object sender, EventArgs e)
        {
            factures f2 = new factures();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();

            this.Hide();
        }

        private void departement_Click_1(object sender, EventArgs e)
        {

        }
        public void actualiser()
        {

            departements f2 = new departements();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();
            this.Hide();

        }

        private void ajouter_Click(object sender, EventArgs e)
        {

            String Nom;
           
            Nom = nom.Text;
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JBLMVJ1;Initial Catalog=gestion-des-ventes;Integrated Security=True");

            if (Nom == "" )
            {
                MessageBox.Show("Veuillez remplir les champs !!");
            }
            else
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[departement] values (@dep_name)", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("dep_name", nom.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Insersion effectuée");
                this.actualiser();
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];
            nom.Text = row.Cells[1].Value.ToString();
            
            this.id = row.Cells[0].Value.ToString();
        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];
            nom.Text = row.Cells[1].Value.ToString();
          
            this.id = row.Cells[0].Value.ToString();
        }

        private void modifier_Click(object sender, EventArgs e)
        {

            String Nom;

            Nom = nom.Text;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JBLMVJ1;Initial Catalog=gestion-des-ventes;Integrated Security=True");

            if (Nom == "")
            {
                MessageBox.Show("Veuillez remplir les champs !!");
            }
            else
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[departement] SET dep_name = @dep_name  WHERE dep_id = @dep_id", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@dep_name", nom.Text);
                cmd.Parameters.AddWithValue("@dep_id", this.id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Modification effectuée");
                this.actualiser();
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {

            String Nom;

            Nom = nom.Text;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JBLMVJ1;Initial Catalog=gestion-des-ventes;Integrated Security=True");

            if (Nom == "")
            {
                MessageBox.Show("Veuillez remplir les champs !!");
            }
            else
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[departement] WHERE dep_name = @dep_name", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@dep_name", Nom);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Suppression effectuée");
                this.actualiser();
            }
        }
    }
}
