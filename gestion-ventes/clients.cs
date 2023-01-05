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
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Tulpep.NotificationWindow;
using Xamarin.Forms;

namespace projet_gestion_des_ventes
{
    public partial class clients : Form
    {
        public DataTable tableCommClient = new DataTable();
        public int id;
        public DataColumn status = new DataColumn("comd_status", typeof(String));
        public DataColumn datec = new DataColumn("comd_date", typeof(SqlDateTime));
     
       
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
        public DataTable tableClients = new DataTable();
        public DataColumn column = new DataColumn("clinet_name", typeof(String));
        public DataColumn column1 = new DataColumn("client_birthday", typeof(SqlDateTime));
        public DataColumn column2 = new DataColumn("client_num", typeof(String));


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
            // TODO: This line of code loads data into the '_gestion_des_ventesDataSet3.commande' table. You can move, or remove it, as needed.
            this.commandeTableAdapter2.Fill(this._gestion_des_ventesDataSet3.commande);
            // TODO: This line of code loads data into the '_gestion_des_ventesDataSet.commande' table. You can move, or remove it, as needed.
            this.commandeTableAdapter1.Fill(this._gestion_des_ventesDataSet.commande);
            // TODO: This line of code loads data into the '_gestion_des_ventesDataSet1.commande' table. You can move, or remove it, as needed.
            this.commandeTableAdapter.Fill(this._gestion_des_ventesDataSet1.commande);
            // TODO: This line of code loads data into the '_gestion_des_ventesDataSet1.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter2.Fill(this._gestion_des_ventesDataSet1.client);
            // TODO: This line of code loads data into the '_gestion_des_ventesDataSet2.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter1.Fill(this._gestion_des_ventesDataSet2.client);
            // TODO: This line of code loads data into the '_gestion_des_ventesDataSet.client' table. You can move, or remove it, as needed.
            this.tableCommClient.Columns.Add(status);
            this.tableCommClient.Columns.Add(datec);
            this.column1.ColumnName = "status";
            this.column2.ColumnName = "date";



        }
        public void actualiser(){

            clients f2 = new clients();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();
            this.Hide();

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

        private void button7_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            FormLog f2 = new FormLog();
            f2.AllowDrop = true;
            f2.Show();
            f2.BringToFront();
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

        private void commande_Click(object sender, EventArgs e)
        {
            commandes f2 = new commandes();
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
                client.Width = -10;
                profil.Width = -10;
                facture.Width = -10;
                if ((sidebar.Width == sidebar.MinimumSize.Width) && (MenuCon.Width == MenuCon.MinimumSize.Width) && (client.Width == client.MinimumSize.Width) && (profil.Width == profil.MinimumSize.Width) && (client.Width == client.MinimumSize.Width))
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }

            }
            else
            {
                guna2DataGridView2.Visible = false;
                details.Enabled = false ;
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

        private void ajouter_Click(object sender, EventArgs e)
        {
            String Nom;
            String Num;
            Nom = nom.Text;
            Num = num.Text;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JBLMVJ1;Initial Catalog=gestion-des-ventes;Integrated Security=True");

            if (Nom == "" || Num == "")
            {
                MessageBox.Show("Veuillez remplir les champs !!");
            }
            else
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[client] values (@clinet_name,@client_birthday,@client_num)", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("clinet_name", nom.Text);
                cmd.Parameters.AddWithValue("client_birthday", date.Value);
                cmd.Parameters.AddWithValue("client_num", num.Text);
               
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Insersion effectuée");
                this.actualiser();
            }
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            String Nom;
            String Num;
            Nom = nom.Text;
            Num = num.Text;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JBLMVJ1;Initial Catalog=gestion-des-ventes;Integrated Security=True");

            if (Nom == "" || Num == "")
            {
                MessageBox.Show("Veuillez remplir les champs !!");
            }
            else
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[client] SET clinet_name = @clinet_name, client_birthday = @client_birthday, client_num = @client_num WHERE client_id = @client_id",con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@clinet_name", nom.Text);
                cmd.Parameters.AddWithValue("@client_birthday", date.Value);
                cmd.Parameters.AddWithValue("@client_num", num.Text);
                cmd.Parameters.AddWithValue("@client_id", this.id);
                cmd.ExecuteNonQuery();
                con.Close();
                PopupNotifier popup = new PopupNotifier();
                popup.Image = global::gestion_ventes.Properties.Resources.categories;
                popup.TitleText = "Le client "+ nom.Text+" est MAJ";
                popup.ContentText = "Modification Effectuée";
                popup.Popup();
                this.actualiser();

            }



        }

        private void clientBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            String Nom;
            String Num;
            Nom = nom.Text;
            Num = num.Text;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JBLMVJ1;Initial Catalog=gestion-des-ventes;Integrated Security=True");

            if (Nom == "" || Num == "")
            {
                MessageBox.Show("Veuillez remplir les champs !!");
            }
            else
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[client] WHERE clinet_name = @clinet_name", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@clinet_name", nom.Text);
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
            num.Text = row.Cells[3].Value.ToString();
            this.id = int.Parse(row.Cells[0].Value.ToString());
            details.Enabled = true;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int ind = guna2DataGridView1.CurrentRow.Index;
            //nom.Text = tableClients.Rows[ind]["clinet_name"].ToString();
            //num.Text = tableClients.Rows[ind]["client_num"].ToString();
        }

        
        private void details_Click_1(object sender, EventArgs e)
        {
         

            if (sidebarExpand == true)
            {
                sidebarTimer.Start();

                guna2DataGridView2.Visible = true;



                SqlConnection con = new SqlConnection("Data Source=DESKTOP-JBLMVJ1;Initial Catalog=gestion-des-ventes;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT [comd_date],[comd_status] FROM [gestion-des-ventes].[dbo].[commande] where client_id=@client_id", con);
                cmd.Parameters.AddWithValue("@client_id", this.id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tableClients = new DataTable();
                da.Fill(tableClients);
                guna2DataGridView2.DataSource = tableClients;
            }
            else
            {

                guna2DataGridView2.Visible = true;



                SqlConnection con = new SqlConnection("Data Source=DESKTOP-JBLMVJ1;Initial Catalog=gestion-des-ventes;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT [comd_date],[comd_status] FROM [gestion-des-ventes].[dbo].[commande] where client_id=@client_id", con);
                cmd.Parameters.AddWithValue("@client_id", this.id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tableClients = new DataTable();
                da.Fill(tableClients);
                guna2DataGridView2.DataSource = tableClients;
            }
         
            
        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
