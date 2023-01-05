using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace projet_gestion_des_ventes
{
    public partial class categories : Form
    {

        public string id;
        ComboBox comboBox = new ComboBox();
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
        public categories()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void categories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_gestion_des_ventesDataSet1.categorie' table. You can move, or remove it, as needed.
            this.categorieTableAdapter1.Fill(this._gestion_des_ventesDataSet1.categorie);
            // TODO: This line of code loads data into the '_gestion_des_ventesDataSet1.departement' table. You can move, or remove it, as needed.
            this.departementTableAdapter.Fill(this._gestion_des_ventesDataSet1.departement);
            // TODO: This line of code loads data into the '_gestion_des_ventesDataSet.produit' table. You can move, or remove it, as needed.
            this.produitTableAdapter.Fill(this._gestion_des_ventesDataSet.produit);
            // TODO: This line of code loads data into the '_gestion_des_ventesDataSet.categorie' table. You can move, or remove it, as needed.
            this.categorieTableAdapter.Fill(this._gestion_des_ventesDataSet.categorie);
            

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

        private void departement_Click(object sender, EventArgs e)
        {
            departements f2 = new departements();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();
            this.Hide();
        }

        private void commande_Click(object sender, EventArgs e)
        {
            commandes f2 = new commandes();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];
            nom.Text = row.Cells[1].Value.ToString();
            idp.SelectedValue = row.Cells[2].Value.ToString();
            this.id = row.Cells[0].Value.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void profil_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void sidebar_Click(object sender, EventArgs e)
        {

        }

        private void MenuCon_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void categorie_Click(object sender, EventArgs e)
        {
            categories f2 = new categories();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();
            this.Hide();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void actualiser()
        {

            categories f2 = new categories();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();
            this.Hide();

        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            String Nom;
            String Idd;
            Nom = nom.Text;
            Idd = idp.Text;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JBLMVJ1;Initial Catalog=gestion-des-ventes;Integrated Security=True");

            if (Nom == "" || Idd == "")
            {
                MessageBox.Show("Veuillez remplir les champs !!");
            }
            else
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[categorie] values (@cat_name,@dep_id)", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("cat_name", nom.Text);
                cmd.Parameters.AddWithValue("dep_id", idp.SelectedValue);
                
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Insersion effectuée");
                this.actualiser();
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            String Nom;
            String Idd;
            Nom = nom.Text;
            Idd = idp.Text;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JBLMVJ1;Initial Catalog=gestion-des-ventes;Integrated Security=True");

            if (Nom == "" || Idd == "")
            {
                MessageBox.Show("Veuillez remplir les champs !!");
            }
            else
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[categorie] WHERE cat_name = @cat_name", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@cat_name", nom.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("suppression effectuée");

                this.actualiser();
            }
        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];
            nom.Text = row.Cells[1].Value.ToString();
            idp.SelectedValue = row.Cells[2].Value.ToString();
            this.id = row.Cells[0].Value.ToString();
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            String Nom;
            String Idd;
            Nom = nom.Text;
            Idd = idp.Text;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JBLMVJ1;Initial Catalog=gestion-des-ventes;Integrated Security=True");

            if (Nom == "" || Idd == "")
            {
                MessageBox.Show("Veuillez remplir les champs !!");
            }
            else
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[categorie] SET cat_name = @cat_name, dep_id = @dep_id  WHERE cat_id = @cat_id", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("cat_name", nom.Text);
                cmd.Parameters.AddWithValue("dep_id", idp.SelectedValue);
                cmd.Parameters.AddWithValue("@cat_id", this.id);
                cmd.ExecuteNonQuery();
                con.Close();

                PopupNotifier popup = new PopupNotifier();
                popup.Image = global::gestion_ventes.Properties.Resources.categories;
                popup.TitleText = "La catégorie " + nom.Text + " est MAJ";
                popup.ContentText = "Modification Effectuée";
                popup.Popup();
                
               
                popup.ShowCloseButton = false;
                popup.ShowOptionsButton = true;
                popup.ShowGrip = false;
                popup.HeaderColor= ColorTranslator.FromHtml("#1062bd");
                popup.ImagePadding = new Padding(10);
                popup.TitlePadding = new Padding(10);
                popup.ContentPadding = new Padding(0);
                popup.BodyColor = ColorTranslator.FromHtml("#1062bd");
                Font font = new Font("Poppins", 9, FontStyle.Bold);
                popup.TitleFont = font;
                this.actualiser();





            }
        }

        private void popupNotifier1_Click(object sender, EventArgs e)
        {

        }
    }
}
