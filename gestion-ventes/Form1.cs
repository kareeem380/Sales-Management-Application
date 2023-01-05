using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Guna.UI2.WinForms;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Web;
using System;
using System.Drawing;

namespace projet_gestion_des_ventes
{
    public partial class FormLog : Form
    {
        public FormLog()
        {


            InitializeComponent();

        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormLog_Load(object sender, EventArgs e)
        {

        }

        private void panelLog_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
           
        }

        private void textPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

  

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            

            
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JBLMVJ1;Initial Catalog=gestion-des-ventes;Integrated Security=True");
            //SqlConnection con = new SqlConnection("Data Source=MY-LAPTOP\\SQLEXPRESS;Initial Catalog=gestion-ventes;Integrated Security=True");
            String uemail, upwd;

           uemail= txtEmail.Text;
           upwd = textPwd.Text;

           if(uemail==""||upwd== "")
           {
               MessageBox.Show("3mer lemail w lmot de passe");
           }
           else {
               con.Open();
               SqlCommand cmd = new SqlCommand(" SELECT * From [user] WHERE email='" + txtEmail.Text + "'AND pwd='" + textPwd.Text+ "'", con);
               DataTable dtable = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dtable);



               if (dtable.Rows.Count > 0)
               {
                   uemail = txtEmail.Text;
                   upwd=textPwd.Text;

                    this.Hide();
                    spinners sp = new spinners();
                    sp.Show();
                    sp.AllowDrop = true;

                    sp.BringToFront();

                }

                else
                {
                    MessageBox.Show("Sir bhalk rak makhedamch m3ana");
                   txtEmail.Clear();
                    textPwd.Clear();
                    txtEmail.Focus();
                }
            }
            con.Close();    
        }

        private void guna2HtmlToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}