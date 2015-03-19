namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pageNum1 = new System.Windows.Forms.NumericUpDown();
            this.pageNum2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.progbar = new System.Windows.Forms.ProgressBar();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveOptions = new System.Windows.Forms.Button();
            this.chkUserPass = new System.Windows.Forms.CheckBox();
            this.chkCommon = new System.Windows.Forms.CheckBox();
            this.listUsers = new System.Windows.Forms.ListBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnScrapeMetro = new MetroFramework.Controls.MetroButton();
            this.btnScrape = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmbServerMetro = new MetroFramework.Controls.MetroComboBox();
            this.progbarMetro = new MetroFramework.Controls.MetroProgressBar();
            this.btnSaveMetro = new MetroFramework.Controls.MetroButton();
            this.label1Metro = new MetroFramework.Controls.MetroLabel();
            this.chkUserPassMetro = new MetroFramework.Controls.MetroToggle();
            this.chkCommonMetro = new MetroFramework.Controls.MetroToggle();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pageNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageNum2)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pageNum1
            // 
            this.pageNum1.Location = new System.Drawing.Point(56, 473);
            this.pageNum1.Name = "pageNum1";
            this.pageNum1.Size = new System.Drawing.Size(118, 26);
            this.pageNum1.TabIndex = 1;
            this.pageNum1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pageNum2
            // 
            this.pageNum2.Location = new System.Drawing.Point(207, 473);
            this.pageNum2.Name = "pageNum2";
            this.pageNum2.Size = new System.Drawing.Size(118, 26);
            this.pageNum2.TabIndex = 1;
            this.pageNum2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1961, 569);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Count ( )";
            // 
            // progbar
            // 
            this.progbar.Location = new System.Drawing.Point(1094, 606);
            this.progbar.Name = "progbar";
            this.progbar.Size = new System.Drawing.Size(920, 34);
            this.progbar.TabIndex = 5;
            this.progbar.Visible = false;
            // 
            // cmbServer
            // 
            this.cmbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Items.AddRange(new object[] {
            "NA",
            "EUNE",
            "EUW",
            "BR",
            "LAN",
            "LAS",
            "OCE",
            "RU",
            "TR",
            "BR",
            "KR"});
            this.cmbServer.Location = new System.Drawing.Point(1549, 563);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(121, 28);
            this.cmbServer.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1676, 560);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 33);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveOptions
            // 
            this.btnSaveOptions.Location = new System.Drawing.Point(1764, 563);
            this.btnSaveOptions.Name = "btnSaveOptions";
            this.btnSaveOptions.Size = new System.Drawing.Size(191, 33);
            this.btnSaveOptions.TabIndex = 8;
            this.btnSaveOptions.Text = "Show Save Options";
            this.btnSaveOptions.UseVisualStyleBackColor = true;
            this.btnSaveOptions.Click += new System.EventHandler(this.btnSaveOptions_Click);
            // 
            // chkUserPass
            // 
            this.chkUserPass.AutoSize = true;
            this.chkUserPass.Location = new System.Drawing.Point(1094, 669);
            this.chkUserPass.Name = "chkUserPass";
            this.chkUserPass.Size = new System.Drawing.Size(156, 24);
            this.chkUserPass.TabIndex = 9;
            this.chkUserPass.Text = "user:user Combo";
            this.chkUserPass.UseVisualStyleBackColor = true;
            // 
            // chkCommon
            // 
            this.chkCommon.AutoSize = true;
            this.chkCommon.Location = new System.Drawing.Point(1094, 699);
            this.chkCommon.Name = "chkCommon";
            this.chkCommon.Size = new System.Drawing.Size(258, 24);
            this.chkCommon.TabIndex = 9;
            this.chkCommon.Text = "Add commonly used passwords";
            this.chkCommon.UseVisualStyleBackColor = true;
            // 
            // listUsers
            // 
            this.listUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.listUsers.FormattingEnabled = true;
            this.listUsers.ItemHeight = 20;
            this.listUsers.Location = new System.Drawing.Point(0, 0);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(585, 462);
            this.listUsers.TabIndex = 0;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 238);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(600, 613);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.label1Metro);
            this.metroTabPage1.Controls.Add(this.btnSaveMetro);
            this.metroTabPage1.Controls.Add(this.progbarMetro);
            this.metroTabPage1.Controls.Add(this.cmbServerMetro);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.btnScrapeMetro);
            this.metroTabPage1.Controls.Add(this.listUsers);
            this.metroTabPage1.Controls.Add(this.pageNum1);
            this.metroTabPage1.Controls.Add(this.pageNum2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(592, 571);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Home";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.pictureBox2);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.chkCommonMetro);
            this.metroTabPage2.Controls.Add(this.chkUserPassMetro);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(592, 571);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Save Settings";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // btnScrapeMetro
            // 
            this.btnScrapeMetro.Location = new System.Drawing.Point(436, 512);
            this.btnScrapeMetro.Name = "btnScrapeMetro";
            this.btnScrapeMetro.Size = new System.Drawing.Size(141, 26);
            this.btnScrapeMetro.TabIndex = 2;
            this.btnScrapeMetro.Text = "Scrape";
            this.btnScrapeMetro.UseSelectable = true;
            this.btnScrapeMetro.Click += new System.EventHandler(this.btnScrapeMetro_Click);
            // 
            // btnScrape
            // 
            this.btnScrape.Location = new System.Drawing.Point(1392, 569);
            this.btnScrape.Name = "btnScrape";
            this.btnScrape.Size = new System.Drawing.Size(82, 29);
            this.btnScrape.TabIndex = 2;
            this.btnScrape.Text = "Scrape";
            this.btnScrape.UseVisualStyleBackColor = true;
            this.btnScrape.Click += new System.EventHandler(this.btnScrape_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 480);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Pages:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(180, 480);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(21, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "to";
            // 
            // cmbServerMetro
            // 
            this.cmbServerMetro.FormattingEnabled = true;
            this.cmbServerMetro.ItemHeight = 23;
            this.cmbServerMetro.Items.AddRange(new object[] {
            "NA",
            "EUNE",
            "EUW",
            "BR",
            "LAN",
            "LAS",
            "OCE",
            "RU",
            "TR",
            "BR",
            "KR"});
            this.cmbServerMetro.Location = new System.Drawing.Point(436, 473);
            this.cmbServerMetro.Name = "cmbServerMetro";
            this.cmbServerMetro.Size = new System.Drawing.Size(141, 29);
            this.cmbServerMetro.TabIndex = 5;
            this.cmbServerMetro.UseSelectable = true;
            // 
            // progbarMetro
            // 
            this.progbarMetro.Location = new System.Drawing.Point(4, 512);
            this.progbarMetro.Name = "progbarMetro";
            this.progbarMetro.Size = new System.Drawing.Size(426, 26);
            this.progbarMetro.TabIndex = 6;
            this.progbarMetro.Visible = false;
            // 
            // btnSaveMetro
            // 
            this.btnSaveMetro.Location = new System.Drawing.Point(436, 544);
            this.btnSaveMetro.Name = "btnSaveMetro";
            this.btnSaveMetro.Size = new System.Drawing.Size(141, 26);
            this.btnSaveMetro.TabIndex = 7;
            this.btnSaveMetro.Text = "Save";
            this.btnSaveMetro.UseSelectable = true;
            this.btnSaveMetro.Visible = false;
            this.btnSaveMetro.Click += new System.EventHandler(this.btnSaveMetro_Click);
            // 
            // label1Metro
            // 
            this.label1Metro.AutoSize = true;
            this.label1Metro.Location = new System.Drawing.Point(324, 551);
            this.label1Metro.Name = "label1Metro";
            this.label1Metro.Size = new System.Drawing.Size(60, 19);
            this.label1Metro.TabIndex = 8;
            this.label1Metro.Text = "Count ( )";
            this.label1Metro.Visible = false;
            // 
            // chkUserPassMetro
            // 
            this.chkUserPassMetro.AutoSize = true;
            this.chkUserPassMetro.Location = new System.Drawing.Point(205, 4);
            this.chkUserPassMetro.Name = "chkUserPassMetro";
            this.chkUserPassMetro.Size = new System.Drawing.Size(80, 24);
            this.chkUserPassMetro.TabIndex = 2;
            this.chkUserPassMetro.Text = "Off";
            this.chkUserPassMetro.UseSelectable = true;
            // 
            // chkCommonMetro
            // 
            this.chkCommonMetro.AutoSize = true;
            this.chkCommonMetro.Location = new System.Drawing.Point(205, 34);
            this.chkCommonMetro.Name = "chkCommonMetro";
            this.chkCommonMetro.Size = new System.Drawing.Size(80, 24);
            this.chkCommonMetro.TabIndex = 3;
            this.chkCommonMetro.Text = "Off";
            this.chkCommonMetro.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(4, 9);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(109, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "user:user Combo";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(4, 39);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(195, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Add commonly used passwords";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 393);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(592, 168);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 860);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.btnScrape);
            this.Controls.Add(this.chkCommon);
            this.Controls.Add(this.chkUserPass);
            this.Controls.Add(this.btnSaveOptions);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbServer);
            this.Controls.Add(this.progbar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "YeezyScraper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pageNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageNum2)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown pageNum1;
        private System.Windows.Forms.NumericUpDown pageNum2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progbar;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveOptions;
        private System.Windows.Forms.CheckBox chkUserPass;
        private System.Windows.Forms.CheckBox chkCommon;
        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton btnScrapeMetro;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Button btnScrape;
        private MetroFramework.Controls.MetroComboBox cmbServerMetro;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroProgressBar progbarMetro;
        private MetroFramework.Controls.MetroButton btnSaveMetro;
        private MetroFramework.Controls.MetroLabel label1Metro;
        private MetroFramework.Controls.MetroToggle chkUserPassMetro;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroToggle chkCommonMetro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

