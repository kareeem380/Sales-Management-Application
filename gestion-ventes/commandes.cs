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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
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
            // TODO: This line of code loads data into the '_gestion_des_ventesDataSet1.produit' table. You can move, or remove it, as needed.
            this.produitTableAdapter.Fill(this._gestion_des_ventesDataSet1.produit);
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
                    guna2DataGridView1.Location = new Point(this.guna2DataGridView1.Location.X, 396);
                    guna2DataGridView1.Location = new Point(this.guna2DataGridView1.Location.Y, 97);
                    guna2ContainerControl1.Location = new Point(this.guna2ContainerControl1.Location.X, 354);
                    guna2ContainerControl1.Location = new Point(this.guna2ContainerControl1.Location.Y, 425);

              

                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }

            }
            else
            {
                
                AddProd.Enabled = false;
                
                sidebar.Width += 10;
                profil.Width += 10;
                MenuCon.Width += 10;
                popo.Width += 10;
                produit.Width += 10;
                commande.Width += 10;
                categorie.Width += 10;
                departement.Width += 10;
                facture.Width += 10;
                guna2DataGridView1.Location = new Point(this.guna2DataGridView1.Location.X, 509);
                guna2DataGridView1.Location = new Point(this.guna2DataGridView1.Location.Y, 97);
                guna2ContainerControl1.Location = new Point(this.guna2ContainerControl1.Location.X, 467);
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
            SqlCommand cmd1 = new SqlCommand("INSERT INTO [dbo].[commande_details] values (@comd_id,@prod_id,@prod_quantity,@prod_price)", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd1.Parameters.AddWithValue("@comd_id", this.id);
            cmd1.Parameters.AddWithValue("@prod_id", prod.SelectedValue);
                cmd1.Parameters.AddWithValue("@prod_quantity", quantite.Text);
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
            prod.Enabled = true;
            AddProd.Enabled = true;
            quantite.Enabled = true;
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
            
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProd_Click(object sender, EventArgs e)
        {
            int r;
            
            string connectionstring = "Data Source=DESKTOP-JBLMVJ1;Initial Catalog=gestion-des-ventes;Integrated Security=True";

                    using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT [prod_price] FROM [gestion-des-ventes].[dbo].[produit] where prod_id=@prod_id", conn);
                cmd2.Parameters.AddWithValue("@prod_id", prod.SelectedValue);
                object result = cmd2.ExecuteScalar();
                r= (int)result;
                conn.Close();
            }



            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JBLMVJ1;Initial Catalog=gestion-des-ventes;Integrated Security=True");




            con.Open();
            float total = r * (int.Parse(quantite.Text));
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[commande_details] values (@comd_id,@prod_id,@prod_quantity,@prod_price,@ttp)", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@comd_id", this.id);
            cmd.Parameters.AddWithValue("@prod_id", prod.SelectedValue);
            cmd.Parameters.AddWithValue("@prod_quantity", quantite.Text);
            cmd.Parameters.AddWithValue("@prod_price", r);
            cmd.Parameters.AddWithValue("@ttp", total);
            cmd.ExecuteNonQuery();
            con.Close();

            // Enable IDENTITY_INSERT
            //cmd.CommandText = "SET IDENTITY_INSERT dbo.commande_details ON";
            //cmd.ExecuteNonQuery();
            
            // Insert row
            
            

            

            // Disable IDENTITY_INSERT
            //cmd.CommandText = "SET IDENTITY_INSERT dbo.commande_details OFF";
            //cmd.ExecuteNonQuery();
            
      
            MessageBox.Show("Produit ajouté à la commande");



            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JBLMVJ1;Initial Catalog=gestion-des-ventes;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE [dbo].[commande] SET client_id = @client_id, comd_status = @comd_status, comd_date = @comd_date WHERE comd_id = @comd_id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@client_id", client.SelectedValue);
            cmd.Parameters.AddWithValue("@comd_status", status.Text);
            cmd.Parameters.AddWithValue("@comd_date", datec.Value);
            cmd.Parameters.AddWithValue("@comd_id", this.id);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Insersion effectuée");
            this.actualiser();








        }
    }
}
