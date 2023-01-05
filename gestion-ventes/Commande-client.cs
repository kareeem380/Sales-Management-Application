using projet_gestion_des_ventes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace gestion_ventes
{
    public partial class Commande_client : Form
    {

        public DataTable tableCommClient = new DataTable();
        public string id;
        public DataColumn column1 = new DataColumn("comd_status", typeof(String));
        public DataColumn column2 = new DataColumn("comd_date", typeof(SqlDateTime));

        
        
        public Commande_client()
        {
            InitializeComponent();
           


        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Commande_client_Load(object sender, EventArgs e)
        {
            
          //  MessageBox.Show(id);

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(id);
        }
    }
}
