using System.Windows.Forms;

namespace projet_gestion_des_ventes
{
    partial class produits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(produits));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dep_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.MenuCon = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.menuButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.sidebar = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.profil = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.departement = new Guna.UI2.WinForms.Guna2Button();
            this.commande = new Guna.UI2.WinForms.Guna2Button();
            this.produit = new Guna.UI2.WinForms.Guna2Button();
            this.categorie = new Guna.UI2.WinForms.Guna2Button();
            this.popo = new Guna.UI2.WinForms.Guna2Button();
            this.facture = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this._gestion_des_ventesDataSet = new gestion_ventes._gestion_des_ventesDataSet();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.prodidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodimgDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.prodnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proddescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.guna2ContainerControl2 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.idp = new System.Windows.Forms.ComboBox();
            this.categorieBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gestiondesventesDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._gestion_des_ventesDataSet1 = new gestion_ventes._gestion_des_ventesDataSet1();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.catrr = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.prix = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.quant = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ajouter = new Guna.UI2.WinForms.Guna2Button();
            this.supprimer = new Guna.UI2.WinForms.Guna2Button();
            this.modifier = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.description = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.gestiondesventesDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categorieTableAdapter = new gestion_ventes._gestion_des_ventesDataSet1TableAdapters.categorieTableAdapter();
            this.categorieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fKproduitcategorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitTableAdapter = new gestion_ventes._gestion_des_ventesDataSet1TableAdapters.produitTableAdapter();
            this.gestiondesventesDataSet1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.MenuCon.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.profil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gestion_des_ventesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            this.guna2ContainerControl1.SuspendLayout();
            this.guna2ContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestiondesventesDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gestion_des_ventesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestiondesventesDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKproduitcategorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestiondesventesDataSet1BindingSource2)).BeginInit();
            this.SuspendLayout();
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
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Enabled = true;
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick_1);
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
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click_1);
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
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
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
            this.commande.Click += new System.EventHandler(this.commande_Click);
            // 
            // produit
            // 
            this.produit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.produit.BorderRadius = 27;
            this.produit.Checked = true;
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
            this.produit.Click += new System.EventHandler(this.produit_Click_1);
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
            // facture
            // 
            this.facture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.facture.BorderRadius = 27;
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
            this.facture.Click += new System.EventHandler(this.facture_Click_1);
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
            // _gestion_des_ventesDataSet
            // 
            this._gestion_des_ventesDataSet.DataSetName = "_gestion_des_ventesDataSet";
            this._gestion_des_ventesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 35;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodidDataGridViewTextBoxColumn,
            this.prodimgDataGridViewImageColumn,
            this.prodnameDataGridViewTextBoxColumn,
            this.proddescDataGridViewTextBoxColumn,
            this.prodquantityDataGridViewTextBoxColumn,
            this.prodpriceDataGridViewTextBoxColumn,
            this.catidDataGridViewTextBoxColumn});
            this.guna2DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2DataGridView1.DataSource = this.produitBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(389, 85);
            this.guna2DataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 60;
            this.guna2DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridView1.RowTemplate.Height = 29;
            this.guna2DataGridView1.Size = new System.Drawing.Size(854, 303);
            this.guna2DataGridView1.TabIndex = 50;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.SystemColors.Window;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 35;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick_1);
            this.guna2DataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentDoubleClick);
            // 
            // prodidDataGridViewTextBoxColumn
            // 
            this.prodidDataGridViewTextBoxColumn.DataPropertyName = "prod_id";
            this.prodidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.prodidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodidDataGridViewTextBoxColumn.Name = "prodidDataGridViewTextBoxColumn";
            this.prodidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodimgDataGridViewImageColumn
            // 
            this.prodimgDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.prodimgDataGridViewImageColumn.DataPropertyName = "prod_img";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.NullValue = "System.Drawing.Bitmap";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            this.prodimgDataGridViewImageColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.prodimgDataGridViewImageColumn.HeaderText = "Image";
            this.prodimgDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.prodimgDataGridViewImageColumn.MinimumWidth = 6;
            this.prodimgDataGridViewImageColumn.Name = "prodimgDataGridViewImageColumn";
            this.prodimgDataGridViewImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.prodimgDataGridViewImageColumn.Width = 85;
            // 
            // prodnameDataGridViewTextBoxColumn
            // 
            this.prodnameDataGridViewTextBoxColumn.DataPropertyName = "prod_name";
            this.prodnameDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.prodnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodnameDataGridViewTextBoxColumn.Name = "prodnameDataGridViewTextBoxColumn";
            // 
            // proddescDataGridViewTextBoxColumn
            // 
            this.proddescDataGridViewTextBoxColumn.DataPropertyName = "prod_desc";
            this.proddescDataGridViewTextBoxColumn.HeaderText = "Description";
            this.proddescDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.proddescDataGridViewTextBoxColumn.Name = "proddescDataGridViewTextBoxColumn";
            // 
            // prodquantityDataGridViewTextBoxColumn
            // 
            this.prodquantityDataGridViewTextBoxColumn.DataPropertyName = "prod_quantity";
            this.prodquantityDataGridViewTextBoxColumn.HeaderText = "Quantité";
            this.prodquantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodquantityDataGridViewTextBoxColumn.Name = "prodquantityDataGridViewTextBoxColumn";
            // 
            // prodpriceDataGridViewTextBoxColumn
            // 
            this.prodpriceDataGridViewTextBoxColumn.DataPropertyName = "prod_price";
            this.prodpriceDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prodpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodpriceDataGridViewTextBoxColumn.Name = "prodpriceDataGridViewTextBoxColumn";
            // 
            // catidDataGridViewTextBoxColumn
            // 
            this.catidDataGridViewTextBoxColumn.DataPropertyName = "cat_id";
            this.catidDataGridViewTextBoxColumn.HeaderText = "Catégorie";
            this.catidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.catidDataGridViewTextBoxColumn.Name = "catidDataGridViewTextBoxColumn";
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataMember = "produit";
            this.produitBindingSource.DataSource = this._gestion_des_ventesDataSet;
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2ContainerControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.guna2ContainerControl1.BorderRadius = 15;
            this.guna2ContainerControl1.BorderThickness = 1;
            this.guna2ContainerControl1.Controls.Add(this.guna2ContainerControl2);
            this.guna2ContainerControl1.Controls.Add(this.idp);
            this.guna2ContainerControl1.Controls.Add(this.guna2HtmlLabel7);
            this.guna2ContainerControl1.Controls.Add(this.catrr);
            this.guna2ContainerControl1.Controls.Add(this.guna2HtmlLabel6);
            this.guna2ContainerControl1.Controls.Add(this.prix);
            this.guna2ContainerControl1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2ContainerControl1.Controls.Add(this.quant);
            this.guna2ContainerControl1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2ContainerControl1.Controls.Add(this.ajouter);
            this.guna2ContainerControl1.Controls.Add(this.supprimer);
            this.guna2ContainerControl1.Controls.Add(this.modifier);
            this.guna2ContainerControl1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2ContainerControl1.Controls.Add(this.description);
            this.guna2ContainerControl1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2ContainerControl1.Controls.Add(this.nom);
            this.guna2ContainerControl1.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.guna2ContainerControl1.Location = new System.Drawing.Point(453, 425);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(729, 380);
            this.guna2ContainerControl1.TabIndex = 51;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // guna2ContainerControl2
            // 
            this.guna2ContainerControl2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.guna2ContainerControl2.BorderRadius = 15;
            this.guna2ContainerControl2.Controls.Add(this.img1);
            this.guna2ContainerControl2.Controls.Add(this.guna2Button1);
            this.guna2ContainerControl2.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.guna2ContainerControl2.Location = new System.Drawing.Point(34, 210);
            this.guna2ContainerControl2.Name = "guna2ContainerControl2";
            this.guna2ContainerControl2.Size = new System.Drawing.Size(140, 152);
            this.guna2ContainerControl2.TabIndex = 59;
            this.guna2ContainerControl2.Text = "guna2ContainerControl2";
            // 
            // img1
            // 
            this.img1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.img1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img1.Location = new System.Drawing.Point(12, 14);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(118, 74);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img1.TabIndex = 49;
            this.img1.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.Checked = true;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.guna2Button1.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(10, 109);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(120, 36);
            this.guna2Button1.TabIndex = 59;
            this.guna2Button1.Text = "Import ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // idp
            // 
            this.idp.DataSource = this.categorieBindingSource2;
            this.idp.DisplayMember = "cat_name";
            this.idp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idp.FormattingEnabled = true;
            this.idp.Location = new System.Drawing.Point(535, 124);
            this.idp.Name = "idp";
            this.idp.Size = new System.Drawing.Size(153, 24);
            this.idp.TabIndex = 58;
            this.idp.ValueMember = "cat_id";
            this.idp.SelectedIndexChanged += new System.EventHandler(this.idp_SelectedIndexChanged);
            // 
            // categorieBindingSource2
            // 
            this.categorieBindingSource2.DataMember = "categorie";
            this.categorieBindingSource2.DataSource = this.gestiondesventesDataSet1BindingSource1;
            // 
            // gestiondesventesDataSet1BindingSource1
            // 
            this.gestiondesventesDataSet1BindingSource1.DataSource = this._gestion_des_ventesDataSet1;
            this.gestiondesventesDataSet1BindingSource1.Position = 0;
            // 
            // _gestion_des_ventesDataSet1
            // 
            this._gestion_des_ventesDataSet1.DataSetName = "_gestion_des_ventesDataSet1";
            this._gestion_des_ventesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(510, 84);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(108, 34);
            this.guna2HtmlLabel7.TabIndex = 57;
            this.guna2HtmlLabel7.Text = "Catégorie :";
            // 
            // catrr
            // 
            this.catrr.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.catrr.BorderRadius = 9;
            this.catrr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.catrr.DefaultText = "";
            this.catrr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.catrr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.catrr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.catrr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.catrr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.catrr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.catrr.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.catrr.Location = new System.Drawing.Point(510, 117);
            this.catrr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.catrr.Name = "catrr";
            this.catrr.PasswordChar = '\0';
            this.catrr.PlaceholderText = "";
            this.catrr.SelectedText = "";
            this.catrr.Size = new System.Drawing.Size(198, 36);
            this.catrr.TabIndex = 56;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(272, 177);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(45, 34);
            this.guna2HtmlLabel6.TabIndex = 55;
            this.guna2HtmlLabel6.Text = "Prix :";
            // 
            // prix
            // 
            this.prix.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.prix.BorderRadius = 9;
            this.prix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prix.DefaultText = "";
            this.prix.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prix.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prix.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prix.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prix.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prix.Location = new System.Drawing.Point(270, 210);
            this.prix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prix.Name = "prix";
            this.prix.PasswordChar = '\0';
            this.prix.PlaceholderText = "";
            this.prix.SelectedText = "";
            this.prix.Size = new System.Drawing.Size(198, 36);
            this.prix.TabIndex = 54;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(512, 177);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(96, 34);
            this.guna2HtmlLabel4.TabIndex = 53;
            this.guna2HtmlLabel4.Text = "Quantité :";
            // 
            // quant
            // 
            this.quant.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.quant.BorderRadius = 9;
            this.quant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quant.DefaultText = "";
            this.quant.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quant.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quant.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quant.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quant.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quant.Location = new System.Drawing.Point(510, 210);
            this.quant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quant.Name = "quant";
            this.quant.PasswordChar = '\0';
            this.quant.PlaceholderText = "";
            this.quant.SelectedText = "";
            this.quant.Size = new System.Drawing.Size(198, 36);
            this.quant.TabIndex = 52;
            this.quant.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(280, 14);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(173, 34);
            this.guna2HtmlLabel5.TabIndex = 51;
            this.guna2HtmlLabel5.Text = "AJOUTER PRODUIT";
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ajouter.BorderRadius = 15;
            this.ajouter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ajouter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ajouter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ajouter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ajouter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.ajouter.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.ForeColor = System.Drawing.Color.White;
            this.ajouter.Location = new System.Drawing.Point(564, 317);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(141, 45);
            this.ajouter.TabIndex = 46;
            this.ajouter.Text = "Ajouter";
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // supprimer
            // 
            this.supprimer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.supprimer.BorderRadius = 15;
            this.supprimer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.supprimer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.supprimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.supprimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.supprimer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.supprimer.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.ForeColor = System.Drawing.Color.White;
            this.supprimer.Location = new System.Drawing.Point(417, 317);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(141, 45);
            this.supprimer.TabIndex = 47;
            this.supprimer.Text = "Supprimer";
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.modifier.BorderRadius = 15;
            this.modifier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modifier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modifier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modifier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modifier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.modifier.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.ForeColor = System.Drawing.Color.White;
            this.modifier.Location = new System.Drawing.Point(270, 317);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(141, 45);
            this.modifier.TabIndex = 48;
            this.modifier.Text = "Modifier";
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(36, 84);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(120, 34);
            this.guna2HtmlLabel3.TabIndex = 3;
            this.guna2HtmlLabel3.Text = "Déscription :";
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.description.BorderRadius = 9;
            this.description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.description.DefaultText = "";
            this.description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.description.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.description.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.description.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.description.Location = new System.Drawing.Point(34, 117);
            this.description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.description.Name = "description";
            this.description.PasswordChar = '\0';
            this.description.PlaceholderText = "";
            this.description.SelectedText = "";
            this.description.Size = new System.Drawing.Size(198, 86);
            this.description.TabIndex = 2;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(272, 84);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(57, 34);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "Nom :";
            // 
            // nom
            // 
            this.nom.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.nom.BorderRadius = 9;
            this.nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nom.DefaultText = "";
            this.nom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nom.Location = new System.Drawing.Point(270, 117);
            this.nom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nom.Name = "nom";
            this.nom.PasswordChar = '\0';
            this.nom.PlaceholderText = "";
            this.nom.SelectedText = "";
            this.nom.Size = new System.Drawing.Size(198, 36);
            this.nom.TabIndex = 0;
            this.nom.TextChanged += new System.EventHandler(this.nom_TextChanged);
            // 
            // gestiondesventesDataSet1BindingSource
            // 
            this.gestiondesventesDataSet1BindingSource.DataSource = this._gestion_des_ventesDataSet1;
            this.gestiondesventesDataSet1BindingSource.Position = 0;
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataMember = "categorie";
            this.categorieBindingSource.DataSource = this.gestiondesventesDataSet1BindingSource1;
            // 
            // categorieTableAdapter
            // 
            this.categorieTableAdapter.ClearBeforeFill = true;
            // 
            // categorieBindingSource1
            // 
            this.categorieBindingSource1.DataMember = "categorie";
            this.categorieBindingSource1.DataSource = this.gestiondesventesDataSet1BindingSource1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // fKproduitcategorieBindingSource
            // 
            this.fKproduitcategorieBindingSource.DataMember = "FK_produit_categorie";
            this.fKproduitcategorieBindingSource.DataSource = this.categorieBindingSource;
            // 
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // gestiondesventesDataSet1BindingSource2
            // 
            this.gestiondesventesDataSet1BindingSource2.DataSource = this._gestion_des_ventesDataSet1;
            this.gestiondesventesDataSet1BindingSource2.Position = 0;
            // 
            // produits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1255, 867);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "produits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "produits";
            this.Load += new System.EventHandler(this.produits_Load);
            this.MenuCon.ResumeLayout(false);
            this.MenuCon.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.profil.ResumeLayout(false);
            this.profil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gestion_des_ventesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            this.guna2ContainerControl1.ResumeLayout(false);
            this.guna2ContainerControl1.PerformLayout();
            this.guna2ContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestiondesventesDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gestion_des_ventesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestiondesventesDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKproduitcategorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestiondesventesDataSet1BindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private gestion_ventes._gestion_des_ventesDataSet _gestion_des_ventesDataSet;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private BindingSource produitBindingSource;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2Button ajouter;
        private Guna.UI2.WinForms.Guna2Button supprimer;
        private Guna.UI2.WinForms.Guna2Button modifier;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox description;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox nom;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox prix;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox quant;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2TextBox catrr;
        private BindingSource gestiondesventesDataSet1BindingSource1;
        private gestion_ventes._gestion_des_ventesDataSet1 _gestion_des_ventesDataSet1;
        private BindingSource gestiondesventesDataSet1BindingSource;
        private BindingSource categorieBindingSource;
        private gestion_ventes._gestion_des_ventesDataSet1TableAdapters.categorieTableAdapter categorieTableAdapter;
        private ComboBox idp;
        private BindingSource categorieBindingSource1;
        private OpenFileDialog openFileDialog1;
        private BindingSource fKproduitcategorieBindingSource;
        private gestion_ventes._gestion_des_ventesDataSet1TableAdapters.produitTableAdapter produitTableAdapter;
        private BindingSource categorieBindingSource2;
        private BindingSource gestiondesventesDataSet1BindingSource2;
        private DataGridViewTextBoxColumn prodidDataGridViewTextBoxColumn;
        private DataGridViewImageColumn prodimgDataGridViewImageColumn;
        private DataGridViewTextBoxColumn prodnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn proddescDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prodquantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prodpriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn catidDataGridViewTextBoxColumn;
        private PictureBox img1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl2;
    }
}