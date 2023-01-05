using Guna.UI2.WinForms;
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
using Xamarin.Forms;
using Point = System.Drawing.Point;

namespace projet_gestion_des_ventes
{
    public partial class commandes : Form
    {
        public string id;
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
        public commandes()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void commandes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_gestion_des_ventesDataSet1.commande' table. You can move, or remove it, as needed.
            this.commandeTableAdapter.Fill(this._gestion_des_ventesDataSet1.commande);
            // TODO: This line of code loads data into the '_gestion_des_ventesDataSet1.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this._gestion_des_ventesDataSet1.client);
            status.Items.Add("En cours");
            status.Items.Add("Livrée");
            status.Items.Add("Arrivée");
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }

        private void menuButton_Click(object sender, EventArgs e)
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
            
        }

        private void popo_Click(object sender, EventArgs e)
        {
           
        }

        private void facture_Click(object sender, EventArgs e)
        {
            categories f2 = new categories();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();

            this.Hide();
        }

        private void departement_Click_1(object sender, EventArgs e)
        {
            departements f2 = new departements();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();

            this.Hide();
        }

        private void commande_Click(object sender, EventArgs e)
        {

        }

        
        private void categorie_Click_1(object sender, EventArgs e)
        {
            categories f2 = new categories();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();

            this.Hide();
        }

        private void popo_Click_1(object sender, EventArgs e)
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

        private void button7_Click_1(object sender, EventArgs e)
        {
            FormLog f2 = new FormLog();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();

            this.Hide();
        }

        private void menuButton_Click_1(object sender, EventArgs e)
        {
            sidebarTimer.Start();
            
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
                    guna2DataGridView1.Location = new Point(this.guna2DataGridView1.Location.X, 384);
                    guna2DataGridView1.Location = new Point(this.guna2DataGridView1.Location.Y, 89);
                    guna2ContainerControl1.Location = new Point(this.guna2ContainerControl1.Location.X, 384);
                    guna2ContainerControl1.Location = new Point(this.guna2ContainerControl1.Location.Y, 425);

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
                guna2DataGridView1.Location = new Point(this.guna2DataGridView1.Location.X, 517);
                guna2DataGridView1.Location = new Point(this.guna2DataGridView1.Location.Y, 89);
                guna2ContainerControl1.Location = new Point(this.guna2ContainerControl1.Location.X, 517);
                guna2ContainerControl1.Location = new Point(this.guna2ContainerControl1.Location.Y, 425);

                if ((sidebar.Width == sidebar.MaximumSize.Width) && (MenuCon.Width == MenuCon.MaximumSize.Width) && (popo.Width == popo.MaximumSize.Width) && (profil.Width == produit.MaximumSize.Width) && (commande.Width == commande.MaximumSize.Width) && (categorie.Width == categorie.MaximumSize.Width) && (departement.Width == departement.MaximumSize.Width) && (produit.Width == produit.MaximumSize.Width) && (facture.Width == facture.MaximumSize.Width))
                {
                    
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

            // Set the combobox's properties
            //status.DropDownStyle = ComboBoxStyle.DropDownList;
            //status.Location = new Point(20, 20);
            //status.Size = new Size(100, 21);

            // Add items to the combobox
            status.Items.Add("Item 1");
            status.Items.Add("Item 2");
            status.Items.Add("Item 3");

            // Add the combobox to the form
            this.Controls.Add(status);

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            status.DropDownStyle = ComboBoxStyle.DropDownList;
            //status.Location = new Point(20, 20);
            //status.Size = new Size(100, 21);

            // Add items to the combobox
            status.Items.Add("Item 1");
            status.Items.Add("Item 2");
            status.Items.Add("Item 3");

            // Add the combobox to the form
            this.Controls.Add(status);

        }
        public void actualiser()
        {

            commandes f2 = new commandes();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();
            this.Hide();

        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            
            
           
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JBLMVJ1;Initial Catalog=gestion-des-ventes;Integrated Security=True");

            

            
            

                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[commande] values (@comd_date,@comd_status,@client_id)", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@client_id", client.SelectedValue);
                cmd.Parameters.AddWithValue("@comd_status", status.Text);
                cmd.Parameters.AddWithValue("@comd_date", datec.Value);
            cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Insersion effectuée");
                this.actualiser();
            
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];
            datec.Text = row.Cells[1].Value.ToString();
            status.Text = row.Cells[2].Value.ToString();
            client.Text = row.Cells[3].Value.ToString();
            this.id = row.Cells[0].Value.ToString();
        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];
            datec.Text = row.Cells[1].Value.ToString();
            status.Text = row.Cells[2].Value.ToString();
            client.SelectedValue = row.Cells[3].Value.ToString();

            this.id = row.Cells[0].Value.ToString();
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JBLMVJ1;Initial Catalog=gestion-des-ventes;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[commande] WHERE comd_id = @comd_id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@comd_id", this.id);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("suppression effectuée");

            this.actualiser();
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JBLMVJ1;Initial Catalog=gestion-des-ventes;Integrated Security=True");

            if (status.Text == "" || client.Text == "")
            {
                MessageBox.Show("Veuillez remplir les champs !!");
            }
            else
            {

                
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[commande] SET client_id = @client_id, comd_status = @comd_status, comd_date = @comd_date WHERE comd_id = @comd_id", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@client_id", client.SelectedValue);
                cmd.Parameters.AddWithValue("@comd_status", status.Text);
                cmd.Parameters.AddWithValue("@comd_date", datec.Value);
                cmd.Parameters.AddWithValue("@comd_id", this.id);

            }
        }
    }
}
