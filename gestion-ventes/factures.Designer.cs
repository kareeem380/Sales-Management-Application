using System.Windows.Forms;

namespace projet_gestion_des_ventes
{
    partial class factures
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(factures));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.departement = new Guna.UI2.WinForms.Guna2Button();
            this.commande = new Guna.UI2.WinForms.Guna2Button();
            this.produit = new Guna.UI2.WinForms.Guna2Button();
            this.categorie = new Guna.UI2.WinForms.Guna2Button();
            this.facture = new Guna.UI2.WinForms.Guna2Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.dep_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popo = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.MenuCon = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.sidebar = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.profil = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.commandedetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._gestion_des_ventesDataSet1 = new gestion_ventes._gestion_des_ventesDataSet1();
            this.commande_detailsTableAdapter = new gestion_ventes._gestion_des_ventesDataSet1TableAdapters.commande_detailsTableAdapter();
            this._gestion_des_ventesDataSet5 = new gestion_ventes._gestion_des_ventesDataSet5();
            this.commandedetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.commande_detailsTableAdapter1 = new gestion_ventes._gestion_des_ventesDataSet5TableAdapters.commande_detailsTableAdapter();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.prod = new System.Windows.Forms.ComboBox();
            this.commandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestiondesventesDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.factureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factureTableAdapter = new gestion_ventes._gestion_des_ventesDataSet5TableAdapters.factureTableAdapter();
            this.commandedetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.commandedetailsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.factureBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._gestion_des_ventesDataSet6 = new gestion_ventes._gestion_des_ventesDataSet6();
            this.commandedetailsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.commande_detailsTableAdapter2 = new gestion_ventes._gestion_des_ventesDataSet6TableAdapters.commande_detailsTableAdapter();
            this.commandedetailsBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this._gestion_des_ventesDataSet7 = new gestion_ventes._gestion_des_ventesDataSet7();
            this.commandedetailsBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.commande_detailsTableAdapter3 = new gestion_ventes._gestion_des_ventesDataSet7TableAdapters.commande_detailsTableAdapter();
            this.commandeTableAdapter = new gestion_ventes._gestion_des_ventesDataSet5TableAdapters.commandeTableAdapter();
            this.guna2DataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this._gestion_des_ventesDataSet8 = new gestion_ventes._gestion_des_ventesDataSet8();
            this.commandedetailsBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.commande_detailsTableAdapter4 = new gestion_ventes._gestion_des_ventesDataSet8TableAdapters.commande_detailsTableAdapter();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.MenuCon.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.profil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commandedetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gestion_des_ventesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gestion_des_ventesDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandedetailsBindingSource1)).BeginInit();
            this.guna2ContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestiondesventesDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandedetailsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandedetailsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factureBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gestion_des_ventesDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandedetailsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandedetailsBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gestion_des_ventesDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandedetailsBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gestion_des_ventesDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandedetailsBindingSource7)).BeginInit();
            this.SuspendLayout();
            // 
            // departement
            // 
            this.departement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.departement.BorderRadius = 27;
            this.departement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.departement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.departement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.departement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.departement.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.departement.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold);
            this.departement.ForeColor = System.Drawing.Color.White;
            this.departement.Image = global::gestion_ventes.Properties.Resources.dep;
            this.departement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.departement.ImageOffset = new System.Drawing.Point(1, 0);
            this.departement.ImageSize = new System.Drawing.Size(40, 40);
            this.departement.Location = new System.Drawing.Point(25, 131);
            this.departement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.departement.MaximumSize = new System.Drawing.Size(325, 62);
            this.departement.MinimumSize = new System.Drawing.Size(59, 62);
            this.departement.Name = "departement";
            this.departement.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.departement.Size = new System.Drawing.Size(325, 62);
            this.departement.TabIndex = 11;
            this.departement.Text = "         Département";
            this.departement.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.departement.Click += new System.EventHandler(this.departement_Click_1);
            // 
            // commande
            // 
            this.commande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.commande.BorderRadius = 27;
            this.commande.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.commande.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.commande.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.commande.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.commande.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.commande.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold);
            this.commande.ForeColor = System.Drawing.Color.White;
            this.commande.Image = global::gestion_ventes.Properties.Resources.cmd;
            this.commande.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.commande.ImageOffset = new System.Drawing.Point(1, 0);
            this.commande.ImageSize = new System.Drawing.Size(35, 35);
            this.commande.Location = new System.Drawing.Point(25, 198);
            this.commande.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.commande.MaximumSize = new System.Drawing.Size(325, 62);
            this.commande.MinimumSize = new System.Drawing.Size(59, 62);
            this.commande.Name = "commande";
            this.commande.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.commande.Size = new System.Drawing.Size(325, 62);
            this.commande.TabIndex = 10;
            this.commande.Text = "         Commande";
            this.commande.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.commande.Click += new System.EventHandler(this.commande_Click_1);
            // 
            // produit
            // 
            this.produit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.produit.BorderRadius = 27;
            this.produit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.produit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.produit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.produit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.produit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.produit.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold);
            this.produit.ForeColor = System.Drawing.Color.White;
            this.produit.Image = global::gestion_ventes.Properties.Resources.product;
            this.produit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.produit.ImageOffset = new System.Drawing.Point(1, 0);
            this.produit.ImageSize = new System.Drawing.Size(40, 40);
            this.produit.Location = new System.Drawing.Point(25, 266);
            this.produit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.produit.MaximumSize = new System.Drawing.Size(325, 62);
            this.produit.MinimumSize = new System.Drawing.Size(59, 62);
            this.produit.Name = "produit";
            this.produit.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.produit.Size = new System.Drawing.Size(325, 62);
            this.produit.TabIndex = 9;
            this.produit.Text = "         Produit";
            this.produit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.produit.Click += new System.EventHandler(this.produit_Click);
            // 
            // categorie
            // 
            this.categorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.categorie.BorderRadius = 27;
            this.categorie.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.categorie.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.categorie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.categorie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.categorie.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.categorie.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold);
            this.categorie.ForeColor = System.Drawing.Color.White;
            this.categorie.Image = global::gestion_ventes.Properties.Resources.categories;
            this.categorie.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.categorie.ImageOffset = new System.Drawing.Point(1, 0);
            this.categorie.ImageSize = new System.Drawing.Size(40, 40);
            this.categorie.Location = new System.Drawing.Point(25, 333);
            this.categorie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categorie.MaximumSize = new System.Drawing.Size(325, 62);
            this.categorie.MinimumSize = new System.Drawing.Size(59, 62);
            this.categorie.Name = "categorie";
            this.categorie.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.categorie.Size = new System.Drawing.Size(325, 62);
            this.categorie.TabIndex = 8;
            this.categorie.Text = "          Catégorie";
            this.categorie.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.categorie.Click += new System.EventHandler(this.categorie_Click);
            // 
            // facture
            // 
            this.facture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.facture.BorderRadius = 27;
            this.facture.Checked = true;
            this.facture.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.facture.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.facture.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.facture.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.facture.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.facture.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold);
            this.facture.ForeColor = System.Drawing.Color.White;
            this.facture.Image = ((System.Drawing.Image)(resources.GetObject("facture.Image")));
            this.facture.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.facture.ImageOffset = new System.Drawing.Point(2, 0);
            this.facture.ImageSize = new System.Drawing.Size(35, 35);
            this.facture.Location = new System.Drawing.Point(25, 467);
            this.facture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.facture.MaximumSize = new System.Drawing.Size(325, 62);
            this.facture.MinimumSize = new System.Drawing.Size(59, 62);
            this.facture.Name = "facture";
            this.facture.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.facture.Size = new System.Drawing.Size(325, 62);
            this.facture.TabIndex = 7;
            this.facture.Text = "         Facturation";
            this.facture.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.facture.Click += new System.EventHandler(this.facture_Click);
            // 
            // button7
            // 
            this.button7.AllowDrop = true;
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(207)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(244, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(71, 55);
            this.button7.TabIndex = 37;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click_3);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(207)))));
            this.pictureBox2.Location = new System.Drawing.Point(3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.menuButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.menuButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.menuButton.ImageRotate = 0F;
            this.menuButton.Location = new System.Drawing.Point(6, 6);
            this.menuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuButton.Name = "menuButton";
            this.menuButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.menuButton.Size = new System.Drawing.Size(80, 48);
            this.menuButton.TabIndex = 23;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // dep_id
            // 
            this.dep_id.HeaderText = "ID Département";
            this.dep_id.MinimumWidth = 6;
            this.dep_id.Name = "dep_id";
            this.dep_id.Width = 125;
            // 
            // cat_name
            // 
            this.cat_name.HeaderText = "Nom Categorie";
            this.cat_name.MinimumWidth = 6;
            this.cat_name.Name = "cat_name";
            this.cat_name.Width = 125;
            // 
            // cat_id
            // 
            this.cat_id.HeaderText = "ID Categorie";
            this.cat_id.MinimumWidth = 6;
            this.cat_id.Name = "cat_id";
            this.cat_id.Width = 125;
            // 
            // popo
            // 
            this.popo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.popo.BorderRadius = 27;
            this.popo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.popo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.popo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.popo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.popo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.popo.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold);
            this.popo.ForeColor = System.Drawing.Color.White;
            this.popo.Image = ((System.Drawing.Image)(resources.GetObject("popo.Image")));
            this.popo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.popo.ImageOffset = new System.Drawing.Point(1, 0);
            this.popo.ImageSize = new System.Drawing.Size(40, 40);
            this.popo.Location = new System.Drawing.Point(25, 400);
            this.popo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.popo.MaximumSize = new System.Drawing.Size(325, 62);
            this.popo.MinimumSize = new System.Drawing.Size(59, 62);
            this.popo.Name = "popo";
            this.popo.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.popo.Size = new System.Drawing.Size(325, 62);
            this.popo.TabIndex = 6;
            this.popo.Text = "         Client";
            this.popo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.popo.Click += new System.EventHandler(this.popo_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Enabled = true;
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Window;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(155, 6);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(97, 60);
            this.guna2HtmlLabel1.TabIndex = 24;
            this.guna2HtmlLabel1.Text = "Menu";
            // 
            // MenuCon
            // 
            this.MenuCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.MenuCon.BorderColor = System.Drawing.Color.White;
            this.MenuCon.BorderRadius = 15;
            this.MenuCon.BorderThickness = 1;
            this.MenuCon.Controls.Add(this.guna2HtmlLabel1);
            this.MenuCon.Controls.Add(this.menuButton);
            this.MenuCon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.MenuCon.Location = new System.Drawing.Point(11, 31);
            this.MenuCon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuCon.MaximumSize = new System.Drawing.Size(335, 63);
            this.MenuCon.MinimumSize = new System.Drawing.Size(87, 63);
            this.MenuCon.Name = "MenuCon";
            this.MenuCon.Size = new System.Drawing.Size(335, 63);
            this.MenuCon.TabIndex = 49;
            this.MenuCon.Text = "guna2ContainerControl1";
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sidebar.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sidebar.BorderRadius = 15;
            this.sidebar.Controls.Add(this.MenuCon);
            this.sidebar.Controls.Add(this.profil);
            this.sidebar.Controls.Add(this.textBox4);
            this.sidebar.Controls.Add(this.departement);
            this.sidebar.Controls.Add(this.commande);
            this.sidebar.Controls.Add(this.produit);
            this.sidebar.Controls.Add(this.categorie);
            this.sidebar.Controls.Add(this.popo);
            this.sidebar.Controls.Add(this.facture);
            this.sidebar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.sidebar.Location = new System.Drawing.Point(11, 11);
            this.sidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidebar.MaximumSize = new System.Drawing.Size(361, 867);
            this.sidebar.MinimumSize = new System.Drawing.Size(113, 674);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(361, 846);
            this.sidebar.TabIndex = 44;
            this.sidebar.Text = "guna2ContainerControl1";
            // 
            // profil
            // 
            this.profil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.profil.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(207)))));
            this.profil.BorderRadius = 15;
            this.profil.BorderThickness = 1;
            this.profil.Controls.Add(this.button7);
            this.profil.Controls.Add(this.pictureBox2);
            this.profil.Controls.Add(this.textBox1);
            this.profil.Controls.Add(this.textBox8);
            this.profil.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(207)))));
            this.profil.Location = new System.Drawing.Point(25, 731);
            this.profil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profil.MaximumSize = new System.Drawing.Size(325, 63);
            this.profil.MinimumSize = new System.Drawing.Size(59, 63);
            this.profil.Name = "profil";
            this.profil.Size = new System.Drawing.Size(321, 63);
            this.profil.TabIndex = 27;
            this.profil.Text = "guna2ContainerControl1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(207)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(96, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 29);
            this.textBox1.TabIndex = 47;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(207)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBox8.ForeColor = System.Drawing.Color.White;
            this.textBox8.Location = new System.Drawing.Point(96, 34);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(142, 29);
            this.textBox8.TabIndex = 48;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Poppins", 7.8F);
            this.textBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox4.Location = new System.Drawing.Point(5, 812);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(101, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "    Version 1.2.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.Location = new System.Drawing.Point(554, 837);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "© Copyright 2022 Techno, Inc, All Rights Reserved";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BorderRadius = 15;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold);
            this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(918, 10);
            this.guna2DateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(325, 36);
            this.guna2DateTimePicker1.TabIndex = 43;
            this.guna2DateTimePicker1.Value = new System.DateTime(2022, 11, 27, 20, 55, 41, 231);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.G2402080114300C350C1C0D2412390C1404.G243B3E2E39012726;
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // commandedetailsBindingSource
            // 
            this.commandedetailsBindingSource.DataMember = "commande_details";
            this.commandedetailsBindingSource.DataSource = this._gestion_des_ventesDataSet1;
            // 
            // _gestion_des_ventesDataSet1
            // 
            this._gestion_des_ventesDataSet1.DataSetName = "_gestion_des_ventesDataSet1";
            this._gestion_des_ventesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commande_detailsTableAdapter
            // 
            this.commande_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // _gestion_des_ventesDataSet5
            // 
            this._gestion_des_ventesDataSet5.DataSetName = "_gestion_des_ventesDataSet5";
            this._gestion_des_ventesDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commandedetailsBindingSource1
            // 
            this.commandedetailsBindingSource1.DataMember = "commande_details";
            this.commandedetailsBindingSource1.DataSource = this._gestion_des_ventesDataSet5;
            // 
            // commande_detailsTableAdapter1
            // 
            this.commande_detailsTableAdapter1.ClearBeforeFill = true;
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2ContainerControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.guna2ContainerControl1.BorderRadius = 15;
            this.guna2ContainerControl1.BorderThickness = 1;
            this.guna2ContainerControl1.Controls.Add(this.guna2Button1);
            this.guna2ContainerControl1.Controls.Add(this.prod);
            this.guna2ContainerControl1.Controls.Add(this.guna2HtmlLabel7);
            this.guna2ContainerControl1.Controls.Add(this.guna2TextBox2);
            this.guna2ContainerControl1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2ContainerControl1.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.guna2ContainerControl1.Location = new System.Drawing.Point(513, 119);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(597, 236);
            this.guna2ContainerControl1.TabIndex = 53;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // prod
            // 
            this.prod.DataSource = this.commandeBindingSource;
            this.prod.DisplayMember = "comd_id";
            this.prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prod.FormattingEnabled = true;
            this.prod.Location = new System.Drawing.Point(237, 116);
            this.prod.Name = "prod";
            this.prod.Size = new System.Drawing.Size(153, 24);
            this.prod.TabIndex = 60;
            this.prod.ValueMember = "prod_id";
            this.prod.SelectedIndexChanged += new System.EventHandler(this.prod_SelectedIndexChanged);
            // 
            // commandeBindingSource
            // 
            this.commandeBindingSource.DataMember = "commande";
            this.commandeBindingSource.DataSource = this.gestiondesventesDataSet5BindingSource;
            // 
            // gestiondesventesDataSet5BindingSource
            // 
            this.gestiondesventesDataSet5BindingSource.DataSource = this._gestion_des_ventesDataSet5;
            this.gestiondesventesDataSet5BindingSource.Position = 0;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(224, 69);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(140, 34);
            this.guna2HtmlLabel7.TabIndex = 59;
            this.guna2HtmlLabel7.Text = "ID Commande";
            this.guna2HtmlLabel7.Click += new System.EventHandler(this.guna2HtmlLabel7_Click);
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.guna2TextBox2.BorderRadius = 9;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(224, 110);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(196, 36);
            this.guna2TextBox2.TabIndex = 58;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(224, 14);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(180, 36);
            this.guna2HtmlLabel5.TabIndex = 51;
            this.guna2HtmlLabel5.Text = "IMPRIMER FACTURE";
            // 
            // factureBindingSource
            // 
            this.factureBindingSource.DataMember = "facture";
            this.factureBindingSource.DataSource = this._gestion_des_ventesDataSet5;
            // 
            // factureTableAdapter
            // 
            this.factureTableAdapter.ClearBeforeFill = true;
            // 
            // commandedetailsBindingSource2
            // 
            this.commandedetailsBindingSource2.DataMember = "commande_details";
            this.commandedetailsBindingSource2.DataSource = this._gestion_des_ventesDataSet5;
            // 
            // commandedetailsBindingSource3
            // 
            this.commandedetailsBindingSource3.DataMember = "commande_details";
            this.commandedetailsBindingSource3.DataSource = this._gestion_des_ventesDataSet5;
            // 
            // factureBindingSource1
            // 
            this.factureBindingSource1.DataMember = "facture";
            this.factureBindingSource1.DataSource = this.gestiondesventesDataSet5BindingSource;
            // 
            // _gestion_des_ventesDataSet6
            // 
            this._gestion_des_ventesDataSet6.DataSetName = "_gestion_des_ventesDataSet6";
            this._gestion_des_ventesDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commandedetailsBindingSource4
            // 
            this.commandedetailsBindingSource4.DataMember = "commande_details";
            this.commandedetailsBindingSource4.DataSource = this._gestion_des_ventesDataSet6;
            // 
            // commande_detailsTableAdapter2
            // 
            this.commande_detailsTableAdapter2.ClearBeforeFill = true;
            // 
            // commandedetailsBindingSource5
            // 
            this.commandedetailsBindingSource5.DataMember = "commande_details";
            this.commandedetailsBindingSource5.DataSource = this._gestion_des_ventesDataSet6;
            // 
            // _gestion_des_ventesDataSet7
            // 
            this._gestion_des_ventesDataSet7.DataSetName = "_gestion_des_ventesDataSet7";
            this._gestion_des_ventesDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commandedetailsBindingSource6
            // 
            this.commandedetailsBindingSource6.DataMember = "commande_details";
            this.commandedetailsBindingSource6.DataSource = this._gestion_des_ventesDataSet7;
            // 
            // commande_detailsTableAdapter3
            // 
            this.commande_detailsTableAdapter3.ClearBeforeFill = true;
            // 
            // commandeTableAdapter
            // 
            this.commandeTableAdapter.ClearBeforeFill = true;
            // 
            // guna2DataGridView2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView2.ColumnHeadersHeight = 30;
            this.guna2DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.Location = new System.Drawing.Point(451, 411);
            this.guna2DataGridView2.Name = "guna2DataGridView2";
            this.guna2DataGridView2.RowHeadersVisible = false;
            this.guna2DataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.guna2DataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView2.RowTemplate.Height = 24;
            this.guna2DataGridView2.Size = new System.Drawing.Size(733, 244);
            this.guna2DataGridView2.TabIndex = 63;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 30;
            this.guna2DataGridView2.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView2_CellContentClick);
            // 
            // _gestion_des_ventesDataSet8
            // 
            this._gestion_des_ventesDataSet8.DataSetName = "_gestion_des_ventesDataSet8";
            this._gestion_des_ventesDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commandedetailsBindingSource7
            // 
            this.commandedetailsBindingSource7.DataMember = "commande_details";
            this.commandedetailsBindingSource7.DataSource = this._gestion_des_ventesDataSet8;
            // 
            // commande_detailsTableAdapter4
            // 
            this.commande_detailsTableAdapter4.ClearBeforeFill = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load_1);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.guna2Button1.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(249, 175);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(141, 45);
            this.guna2Button1.TabIndex = 64;
            this.guna2Button1.Text = "Imprimer";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_2);
            // 
            // factures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1255, 867);
            this.Controls.Add(this.guna2DataGridView2);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "factures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "factures";
            this.Load += new System.EventHandler(this.factures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.MenuCon.ResumeLayout(false);
            this.MenuCon.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.profil.ResumeLayout(false);
            this.profil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commandedetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gestion_des_ventesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gestion_des_ventesDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandedetailsBindingSource1)).EndInit();
            this.guna2ContainerControl1.ResumeLayout(false);
            this.guna2ContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestiondesventesDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandedetailsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandedetailsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factureBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gestion_des_ventesDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandedetailsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandedetailsBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gestion_des_ventesDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandedetailsBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gestion_des_ventesDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandedetailsBindingSource7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button departement;
        private Guna.UI2.WinForms.Guna2Button commande;
        private Guna.UI2.WinForms.Guna2Button produit;
        private Guna.UI2.WinForms.Guna2Button categorie;
        private Guna.UI2.WinForms.Guna2Button facture;
        private Button button7;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2ImageButton menuButton;
        private DataGridViewTextBoxColumn dep_id;
        private DataGridViewTextBoxColumn cat_name;
        private DataGridViewTextBoxColumn cat_id;
        private Guna.UI2.WinForms.Guna2Button popo;
        private Timer timer1;
        private Timer sidebarTimer;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ContainerControl MenuCon;
        private Guna.UI2.WinForms.Guna2ContainerControl sidebar;
        private Guna.UI2.WinForms.Guna2ContainerControl profil;
        private TextBox textBox1;
        private TextBox textBox8;
        private TextBox textBox4;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private gestion_ventes._gestion_des_ventesDataSet1 _gestion_des_ventesDataSet1;
        private BindingSource commandedetailsBindingSource;
        private gestion_ventes._gestion_des_ventesDataSet1TableAdapters.commande_detailsTableAdapter commande_detailsTableAdapter;
        private gestion_ventes._gestion_des_ventesDataSet5 _gestion_des_ventesDataSet5;
        private BindingSource commandedetailsBindingSource1;
        private gestion_ventes._gestion_des_ventesDataSet5TableAdapters.commande_detailsTableAdapter commande_detailsTableAdapter1;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private ComboBox prod;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private BindingSource factureBindingSource;
        private gestion_ventes._gestion_des_ventesDataSet5TableAdapters.factureTableAdapter factureTableAdapter;
        private BindingSource commandedetailsBindingSource2;
        private BindingSource factureBindingSource1;
        private BindingSource gestiondesventesDataSet5BindingSource;
        private BindingSource commandedetailsBindingSource3;
        private gestion_ventes._gestion_des_ventesDataSet6 _gestion_des_ventesDataSet6;
        private BindingSource commandedetailsBindingSource4;
        private gestion_ventes._gestion_des_ventesDataSet6TableAdapters.commande_detailsTableAdapter commande_detailsTableAdapter2;
        private BindingSource commandedetailsBindingSource5;
        private gestion_ventes._gestion_des_ventesDataSet7 _gestion_des_ventesDataSet7;
        private BindingSource commandedetailsBindingSource6;
        private gestion_ventes._gestion_des_ventesDataSet7TableAdapters.commande_detailsTableAdapter commande_detailsTableAdapter3;
        private BindingSource commandeBindingSource;
        private gestion_ventes._gestion_des_ventesDataSet5TableAdapters.commandeTableAdapter commandeTableAdapter;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView2;
        private gestion_ventes._gestion_des_ventesDataSet8 _gestion_des_ventesDataSet8;
        private BindingSource commandedetailsBindingSource7;
        private gestion_ventes._gestion_des_ventesDataSet8TableAdapters.commande_detailsTableAdapter commande_detailsTableAdapter4;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}