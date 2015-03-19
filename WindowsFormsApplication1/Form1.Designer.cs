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
            this.label1Metro = new MetroFramework.Controls.MetroLabel();
            this.btnSaveMetro = new MetroFramework.Controls.MetroButton();
            this.progbarMetro = new MetroFramework.Controls.MetroProgressBar();
            this.cmbServerMetro = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnScrapeMetro = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.chkCommonMetro = new MetroFramework.Controls.MetroToggle();
            this.chkUserPassMetro = new MetroFramework.Controls.MetroToggle();
            this.btnScrape = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pageNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageNum2)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pageNum1
            // 
            this.pageNum1.Location = new System.Drawing.Point(95, 484);
            this.pageNum1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pageNum1.Name = "pageNum1";
            this.pageNum1.Size = new System.Drawing.Size(119, 26);
            this.pageNum1.TabIndex = 1;
            this.pageNum1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pageNum2
            // 
            this.pageNum2.Location = new System.Drawing.Point(313, 484);
            this.pageNum2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pageNum2.Name = "pageNum2";
            this.pageNum2.Size = new System.Drawing.Size(119, 26);
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
            this.label1.Location = new System.Drawing.Point(2104, 578);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Count ( )";
            // 
            // progbar
            // 
            this.progbar.Location = new System.Drawing.Point(1238, 616);
            this.progbar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.progbar.Name = "progbar";
            this.progbar.Size = new System.Drawing.Size(920, 33);
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
            this.cmbServer.Location = new System.Drawing.Point(1694, 571);
            this.cmbServer.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(121, 28);
            this.cmbServer.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1820, 569);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 33);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveOptions
            // 
            this.btnSaveOptions.Location = new System.Drawing.Point(1908, 571);
            this.btnSaveOptions.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.chkUserPass.Location = new System.Drawing.Point(1238, 678);
            this.chkUserPass.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chkUserPass.Name = "chkUserPass";
            this.chkUserPass.Size = new System.Drawing.Size(156, 24);
            this.chkUserPass.TabIndex = 9;
            this.chkUserPass.Text = "user:user Combo";
            this.chkUserPass.UseVisualStyleBackColor = true;
            // 
            // chkCommon
            // 
            this.chkCommon.AutoSize = true;
            this.chkCommon.Location = new System.Drawing.Point(1238, 709);
            this.chkCommon.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.listUsers.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(1046, 462);
            this.listUsers.TabIndex = 0;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(49, 513);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1087, 880);
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
            this.metroTabPage1.HorizontalScrollbarSize = 9;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1079, 838);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Home";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 11;
            // 
            // label1Metro
            // 
            this.label1Metro.AutoSize = true;
            this.label1Metro.Location = new System.Drawing.Point(770, 484);
            this.label1Metro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1Metro.Name = "label1Metro";
            this.label1Metro.Size = new System.Drawing.Size(60, 19);
            this.label1Metro.TabIndex = 8;
            this.label1Metro.Text = "Count ( )";
            this.label1Metro.Visible = false;
            // 
            // btnSaveMetro
            // 
            this.btnSaveMetro.Location = new System.Drawing.Point(623, 484);
            this.btnSaveMetro.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSaveMetro.Name = "btnSaveMetro";
            this.btnSaveMetro.Size = new System.Drawing.Size(140, 38);
            this.btnSaveMetro.TabIndex = 7;
            this.btnSaveMetro.Text = "Save";
            this.btnSaveMetro.UseSelectable = true;
            this.btnSaveMetro.Visible = false;
            this.btnSaveMetro.Click += new System.EventHandler(this.btnSaveMetro_Click);
            // 
            // progbarMetro
            // 
            this.progbarMetro.Location = new System.Drawing.Point(13, 553);
            this.progbarMetro.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.progbarMetro.Name = "progbarMetro";
            this.progbarMetro.Size = new System.Drawing.Size(1035, 42);
            this.progbarMetro.TabIndex = 6;
            this.progbarMetro.Visible = false;
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
            this.cmbServerMetro.Location = new System.Drawing.Point(904, 484);
            this.cmbServerMetro.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmbServerMetro.Name = "cmbServerMetro";
            this.cmbServerMetro.Size = new System.Drawing.Size(141, 29);
            this.cmbServerMetro.TabIndex = 5;
            this.cmbServerMetro.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(238, 480);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(21, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "to";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 480);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Pages:";
            // 
            // btnScrapeMetro
            // 
            this.btnScrapeMetro.Location = new System.Drawing.Point(450, 484);
            this.btnScrapeMetro.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnScrapeMetro.Name = "btnScrapeMetro";
            this.btnScrapeMetro.Size = new System.Drawing.Size(140, 38);
            this.btnScrapeMetro.TabIndex = 2;
            this.btnScrapeMetro.Text = "Scrape";
            this.btnScrapeMetro.UseSelectable = true;
            this.btnScrapeMetro.Click += new System.EventHandler(this.btnScrapeMetro_Click);
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
            this.metroTabPage2.HorizontalScrollbarSize = 9;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1079, 838);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Save Settings";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 393);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(592, 168);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(4, 100);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(195, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Add commonly used passwords";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(4, 29);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(109, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "user:user Combo";
            // 
            // chkCommonMetro
            // 
            this.chkCommonMetro.AutoSize = true;
            this.chkCommonMetro.Location = new System.Drawing.Point(362, 111);
            this.chkCommonMetro.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chkCommonMetro.Name = "chkCommonMetro";
            this.chkCommonMetro.Size = new System.Drawing.Size(80, 24);
            this.chkCommonMetro.TabIndex = 3;
            this.chkCommonMetro.Text = "Off";
            this.chkCommonMetro.UseSelectable = true;
            // 
            // chkUserPassMetro
            // 
            this.chkUserPassMetro.AutoSize = true;
            this.chkUserPassMetro.Location = new System.Drawing.Point(362, 29);
            this.chkUserPassMetro.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chkUserPassMetro.Name = "chkUserPassMetro";
            this.chkUserPassMetro.Size = new System.Drawing.Size(80, 24);
            this.chkUserPassMetro.TabIndex = 2;
            this.chkUserPassMetro.Text = "Off";
            this.chkUserPassMetro.UseSelectable = true;
            // 
            // btnScrape
            // 
            this.btnScrape.Location = new System.Drawing.Point(1535, 578);
            this.btnScrape.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnScrape.Name = "btnScrape";
            this.btnScrape.Size = new System.Drawing.Size(83, 29);
            this.btnScrape.TabIndex = 2;
            this.btnScrape.Text = "Scrape";
            this.btnScrape.UseVisualStyleBackColor = true;
            this.btnScrape.Click += new System.EventHandler(this.btnScrape_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 136);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 1424);
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
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 133, 20, 20);
            this.Resizable = false;
            this.Text = "YeezyScraper 72 dpi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pageNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageNum2)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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

