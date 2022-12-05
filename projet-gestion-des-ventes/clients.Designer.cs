namespace projet_gestion_des_ventes
{
    partial class clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clients));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.departement = new Guna.UI2.WinForms.Guna2Button();
            this.commande = new Guna.UI2.WinForms.Guna2Button();
            this.produit = new Guna.UI2.WinForms.Guna2Button();
            this.categorie = new Guna.UI2.WinForms.Guna2Button();
            this.client = new Guna.UI2.WinForms.Guna2Button();
            this.facture = new Guna.UI2.WinForms.Guna2Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.profil = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.sidebar = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.MenuCon = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.menuButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.profil.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.MenuCon.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BorderRadius = 15;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(918, 11);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(325, 45);
            this.guna2DateTimePicker1.TabIndex = 40;
            this.guna2DateTimePicker1.Value = new System.DateTime(2022, 11, 27, 20, 55, 41, 231);
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
            this.departement.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departement.ForeColor = System.Drawing.Color.White;
            this.departement.Image = global::projet_gestion_des_ventes.Properties.Resources.dep;
            this.departement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.departement.ImageOffset = new System.Drawing.Point(1, 0);
            this.departement.ImageSize = new System.Drawing.Size(40, 40);
            this.departement.Location = new System.Drawing.Point(25, 164);
            this.departement.MaximumSize = new System.Drawing.Size(325, 77);
            this.departement.MinimumSize = new System.Drawing.Size(59, 77);
            this.departement.Name = "departement";
            this.departement.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.departement.Size = new System.Drawing.Size(325, 77);
            this.departement.TabIndex = 11;
            this.departement.Text = "         Département";
            this.departement.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.departement.Click += new System.EventHandler(this.departement_Click);
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
            this.commande.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.commande.ForeColor = System.Drawing.Color.White;
            this.commande.Image = global::projet_gestion_des_ventes.Properties.Resources.cmd;
            this.commande.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.commande.ImageOffset = new System.Drawing.Point(1, 0);
            this.commande.ImageSize = new System.Drawing.Size(35, 35);
            this.commande.Location = new System.Drawing.Point(25, 248);
            this.commande.MaximumSize = new System.Drawing.Size(325, 77);
            this.commande.MinimumSize = new System.Drawing.Size(59, 77);
            this.commande.Name = "commande";
            this.commande.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.commande.Size = new System.Drawing.Size(325, 77);
            this.commande.TabIndex = 10;
            this.commande.Text = "         Commande";
            this.commande.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.produit.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.produit.ForeColor = System.Drawing.Color.White;
            this.produit.Image = global::projet_gestion_des_ventes.Properties.Resources.product;
            this.produit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.produit.ImageOffset = new System.Drawing.Point(1, 0);
            this.produit.ImageSize = new System.Drawing.Size(40, 40);
            this.produit.Location = new System.Drawing.Point(25, 332);
            this.produit.MaximumSize = new System.Drawing.Size(325, 77);
            this.produit.MinimumSize = new System.Drawing.Size(59, 77);
            this.produit.Name = "produit";
            this.produit.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.produit.Size = new System.Drawing.Size(325, 77);
            this.produit.TabIndex = 9;
            this.produit.Text = "         Produit";
            this.produit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.categorie.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categorie.ForeColor = System.Drawing.Color.White;
            this.categorie.Image = global::projet_gestion_des_ventes.Properties.Resources.cat;
            this.categorie.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.categorie.ImageOffset = new System.Drawing.Point(1, 0);
            this.categorie.ImageSize = new System.Drawing.Size(40, 40);
            this.categorie.Location = new System.Drawing.Point(25, 416);
            this.categorie.MaximumSize = new System.Drawing.Size(325, 77);
            this.categorie.MinimumSize = new System.Drawing.Size(59, 77);
            this.categorie.Name = "categorie";
            this.categorie.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.categorie.Size = new System.Drawing.Size(325, 77);
            this.categorie.TabIndex = 8;
            this.categorie.Text = "          Catégorie";
            this.categorie.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // client
            // 
            this.client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.client.BorderRadius = 27;
            this.client.Checked = true;
            this.client.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.client.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.client.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.client.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.client.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.client.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.client.ForeColor = System.Drawing.Color.White;
            this.client.Image = ((System.Drawing.Image)(resources.GetObject("client.Image")));
            this.client.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.client.ImageOffset = new System.Drawing.Point(1, 0);
            this.client.ImageSize = new System.Drawing.Size(40, 40);
            this.client.Location = new System.Drawing.Point(25, 500);
            this.client.MaximumSize = new System.Drawing.Size(325, 77);
            this.client.MinimumSize = new System.Drawing.Size(59, 77);
            this.client.Name = "client";
            this.client.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.client.Size = new System.Drawing.Size(325, 77);
            this.client.TabIndex = 6;
            this.client.Text = "         Client";
            this.client.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.client.Click += new System.EventHandler(this.client_Click);
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
            this.facture.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.facture.ForeColor = System.Drawing.Color.White;
            this.facture.Image = ((System.Drawing.Image)(resources.GetObject("facture.Image")));
            this.facture.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.facture.ImageOffset = new System.Drawing.Point(2, 0);
            this.facture.ImageSize = new System.Drawing.Size(35, 35);
            this.facture.Location = new System.Drawing.Point(25, 584);
            this.facture.MaximumSize = new System.Drawing.Size(325, 77);
            this.facture.MinimumSize = new System.Drawing.Size(59, 77);
            this.facture.Name = "facture";
            this.facture.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.facture.Size = new System.Drawing.Size(325, 77);
            this.facture.TabIndex = 7;
            this.facture.Text = "         Facturation";
            this.facture.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.facture.Click += new System.EventHandler(this.facture_Click_1);
            // 
            // button7
            // 
            this.button7.AllowDrop = true;
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(207)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(245, 5);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(71, 69);
            this.button7.TabIndex = 37;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click_2);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(207)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox4.Location = new System.Drawing.Point(14, 808);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(101, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "Version 1.2.1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(207)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(96, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 29);
            this.textBox1.TabIndex = 47;
            this.textBox1.Text = "ID : 157488";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(544, 832);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "© Copyright 2022 Techno, Inc, All Rights Reserved";
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
            this.profil.Location = new System.Drawing.Point(25, 723);
            this.profil.MaximumSize = new System.Drawing.Size(325, 79);
            this.profil.MinimumSize = new System.Drawing.Size(59, 79);
            this.profil.Name = "profil";
            this.profil.Size = new System.Drawing.Size(325, 79);
            this.profil.TabIndex = 27;
            this.profil.Text = "guna2ContainerControl1";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(207)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox8.ForeColor = System.Drawing.Color.White;
            this.textBox8.Location = new System.Drawing.Point(96, 43);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(126, 29);
            this.textBox8.TabIndex = 48;
            this.textBox8.Text = "Nom : Karim";
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
            this.sidebar.Controls.Add(this.client);
            this.sidebar.Controls.Add(this.facture);
            this.sidebar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.sidebar.Location = new System.Drawing.Point(11, 12);
            this.sidebar.MaximumSize = new System.Drawing.Size(361, 843);
            this.sidebar.MinimumSize = new System.Drawing.Size(113, 843);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(361, 843);
            this.sidebar.TabIndex = 41;
            this.sidebar.Text = "guna2ContainerControl1";
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
            this.MenuCon.Location = new System.Drawing.Point(11, 39);
            this.MenuCon.MaximumSize = new System.Drawing.Size(335, 79);
            this.MenuCon.MinimumSize = new System.Drawing.Size(87, 79);
            this.MenuCon.Name = "MenuCon";
            this.MenuCon.Size = new System.Drawing.Size(335, 79);
            this.MenuCon.TabIndex = 49;
            this.MenuCon.Text = "guna2ContainerControl1";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Window;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(155, 8);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(97, 60);
            this.guna2HtmlLabel1.TabIndex = 24;
            this.guna2HtmlLabel1.Text = "Menu";
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.menuButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.menuButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.menuButton.ImageRotate = 0F;
            this.menuButton.Location = new System.Drawing.Point(6, 8);
            this.menuButton.Name = "menuButton";
            this.menuButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.menuButton.Size = new System.Drawing.Size(80, 60);
            this.menuButton.TabIndex = 23;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Enabled = true;
            this.sidebarTimer.Interval = 10;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1255, 867);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "git";
            this.Load += new System.EventHandler(this.produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.profil.ResumeLayout(false);
            this.profil.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.MenuCon.ResumeLayout(false);
            this.MenuCon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2Button departement;
        private Guna.UI2.WinForms.Guna2Button commande;
        private Guna.UI2.WinForms.Guna2Button produit;
        private Guna.UI2.WinForms.Guna2Button categorie;
        private Guna.UI2.WinForms.Guna2Button client;
        private Guna.UI2.WinForms.Guna2Button facture;
        private Button button7;
        private PictureBox pictureBox2;
        private TextBox textBox4;
        private TextBox textBox1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ContainerControl profil;
        private TextBox textBox8;
        private Guna.UI2.WinForms.Guna2ContainerControl sidebar;
        private Guna.UI2.WinForms.Guna2ContainerControl MenuCon;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ImageButton menuButton;
        private System.Windows.Forms.Timer sidebarTimer;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Timer timer1;
    }
}