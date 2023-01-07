using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace projet_gestion_des_ventes
{
    public partial class produits : Form
    {
        String local = "";
        private bool sidebarExpand;
        private string id;
        byte[] imageData;

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
        public produits()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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

        private void departement_Click_1(object sender, EventArgs e)
        {
            departements f2 = new departements();
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
            this.Hide();
            FormLog f2 = new FormLog();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();
        }

        private void produit_Click(object sender, EventArgs e)
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

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void menuButton_Click_1(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void produits_Load(object sender, EventArgs e)
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
            // TODO: This line of code loads data into the '_gestion_des_ventesDataSet1.categorie' table. You can move, or remove it, as needed.
            this.categorieTableAdapter.Fill(this._gestion_des_ventesDataSet1.categorie);
            for (int i = 0; i < guna2DataGridView1.Columns.Count; i++)
                if (guna2DataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)guna2DataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JBLMVJ1;Initial Catalog=gestion-des-ventes;Integrated Security=True");
            //SqlConnection con = new SqlConnection("Data Source=MY-LAPTOP\\SQLEXPRESS;Initial Catalog=gestion-ventes;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(" SELECT * From [produit]", con);
            DataTable dtable = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dtable);
            guna2DataGridView1.DataSource = dtable;
        }

        private void categorie_Click(object sender, EventArgs e)
        {
            categories f2 = new categories();
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

        private void produit_Click_1(object sender, EventArgs e)
        {

            produits f2 = new produits();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();
            this.Hide();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //guna2DataGridView1.Columns["prod_img"].DefaultCellStyle.BackColor = Color.Red;

            DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];
            nom.Text = row.Cells[2].Value.ToString();
            idp.SelectedValue = row.Cells[6].Value.ToString();
            description.Text = row.Cells[3].Value.ToString();
           
            prix.Text = row.Cells[5].Value.ToString();
            quant.Text = row.Cells[4].Value.ToString();
            this.id = row.Cells[0].Value.ToString();



           
        }

        private void nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set the initial directory and filter for the OpenFileDialog
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";

            // Show the OpenFileDialog
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Load the image file
                Image image = Image.FromFile(openFileDialog1.FileName);
                local = openFileDialog1.FileName.ToString();

                // Set the PictureBox image to the selected image
                img1.Image = image;
                img1.ImageLocation = local;
            }
        }
        public void actualiser()
        {

            produits f2 = new produits();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();
            this.Hide();

        }

        private void ajouter_Click(object sender, EventArgs e)
        {

            String name;
            String descrip;
            String cate;
            String quantite;
            String price;
            name = nom.Text;
            descrip = description.Text;
            cate = catrr.Text;
            quantite = quant.Text;
            price = prix.Text;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JBLMVJ1;Initial Catalog=gestion-des-ventes;Integrated Security=True");

            if (name == "" )
            {
                MessageBox.Show("Veuillez remplir les champs !!");
            }
            else
            {
                // Get the file path of the image displayed in the PictureBox
                string imagePath = img1.ImageLocation;

                byte[] images = null;
                FileStream Streem = new FileStream(local, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(Streem);
                images = brs.ReadBytes((int)Streem.Length);


                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[produit] values (@prod_img,@prod_name,@prod_desc,@prod_quantity,@prod_price,@cat_id)", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("prod_name", name);
                cmd.Parameters.AddWithValue("prod_desc", descrip);
                cmd.Parameters.AddWithValue("prod_quantity", quantite);
                cmd.Parameters.AddWithValue("prod_price", price);
                cmd.Parameters.AddWithValue("cat_id", idp.SelectedValue);
                
                SqlParameter imageParameter = new SqlParameter("prod_img", SqlDbType.VarBinary);
                imageParameter.Value = images;
                cmd.Parameters.Add(imageParameter);


                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Insersion effectuée");
                this.actualiser();
            }
        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];
            nom.Text = row.Cells[2].Value.ToString();
            id = row.Cells[0].Value.ToString();
            description.Text = row.Cells[3].Value.ToString();
            idp.SelectedValue = row.Cells[6].Value.ToString();
            prix.Text = row.Cells[5].Value.ToString();
            quant.Text = row.Cells[4].Value.ToString();
            imageData = (byte[])row.Cells[1].Value;

            using (MemoryStream ms = new MemoryStream(imageData))
            {
                img1.Image = Image.FromStream(ms);
            }


          
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            String name;
            String descrip;
            String cate;
            String quantite;
            String price;
            name = nom.Text;
            descrip = description.Text;
            cate = catrr.Text;
            quantite = quant.Text;
            price = prix.Text;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JBLMVJ1;Initial Catalog=gestion-des-ventes;Integrated Security=True");

            if (name == "")
            {
                MessageBox.Show("Veuillez remplir les champs !!");
            }
            else
            {
                // Get the file path of the image displayed in the PictureBox
                


                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[produit] WHERE prod_name = @prod_name", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("prod_name", name);





                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Suppression effectuée");
                this.actualiser();
            }
        }

        private void modifier_Click(object sender, EventArgs e)
        {

            String name;
            String descrip;
            String cate;
            String quantite;
            String price;
            name = nom.Text;
            descrip = description.Text;
            //cate = idp.SelectedValue;
            quantite = quant.Text;
            price = prix.Text;
           

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JBLMVJ1;Initial Catalog=gestion-des-ventes;Integrated Security=True");

            if (name == "")
            {
                MessageBox.Show("Veuillez remplir les champs !!");
            }
            else
            {
                
                // Get the file path of the image displayed in the PictureBox
                string imagePath = img1.ImageLocation;

                byte[] images = imageData;
                FileStream Streem = new FileStream(local, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(Streem);
                images = brs.ReadBytes((int)Streem.Length);


                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[produit] SET prod_name = @prod_name, prod_desc = @prod_desc, prod_quantity = @prod_quantity, prod_price = @prod_price, cat_id = @cat_id, prod_img = @prod_img  WHERE prod_id = @prod_id", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@prod_name", name);
                cmd.Parameters.AddWithValue("@prod_desc", descrip);
                cmd.Parameters.AddWithValue("@prod_quantity", quantite);
                cmd.Parameters.AddWithValue("@prod_price", price);
                cmd.Parameters.AddWithValue("cat_id", idp.SelectedValue);
                cmd.Parameters.AddWithValue("prod_id", this.id);
                SqlParameter imageParameter = new SqlParameter("prod_img", SqlDbType.VarBinary);
                imageParameter.Value = images;
                cmd.Parameters.Add(imageParameter);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Modification effectuée");
                this.actualiser();
            }
        }

        private void idp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
