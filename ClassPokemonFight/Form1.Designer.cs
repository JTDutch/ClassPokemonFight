namespace ClassPokemonFight
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MsJthi = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiAddJthi = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiShowJthi = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiFightJthi = new System.Windows.Forms.ToolStripMenuItem();
            this.tbc1Jthi = new System.Windows.Forms.TabControl();
            this.tbAddJthi = new System.Windows.Forms.TabPage();
            this.pcbAdd1Jthi = new System.Windows.Forms.PictureBox();
            this.lblLastAddedJthi = new System.Windows.Forms.Label();
            this.lblLastAddedTxtJthi = new System.Windows.Forms.Label();
            this.lblCountJthi = new System.Windows.Forms.Label();
            this.lblCountTxtJthi = new System.Windows.Forms.Label();
            this.btnAddJthi = new System.Windows.Forms.Button();
            this.lblTypeAddJthi = new System.Windows.Forms.Label();
            this.lblNameAddJthi = new System.Windows.Forms.Label();
            this.cmbTypeJthi = new System.Windows.Forms.ComboBox();
            this.tbAddpkmJthi = new System.Windows.Forms.TextBox();
            this.tbShowJthi = new System.Windows.Forms.TabPage();
            this.cbShowJthi = new System.Windows.Forms.CheckBox();
            this.btnShowJthi = new System.Windows.Forms.Button();
            this.rtbShowJthi = new System.Windows.Forms.RichTextBox();
            this.tbFightJthi = new System.Windows.Forms.TabPage();
            this.lblFightType2Jthi = new System.Windows.Forms.Label();
            this.lblFightName2Jthi = new System.Windows.Forms.Label();
            this.lblFightTypeTxt2Jthi = new System.Windows.Forms.Label();
            this.lblFightNameTxt2Jthi = new System.Windows.Forms.Label();
            this.lblFightType1Jthi = new System.Windows.Forms.Label();
            this.lblFightName1Jthi = new System.Windows.Forms.Label();
            this.lblFightTypeTxt1Jthi = new System.Windows.Forms.Label();
            this.lblFightNameTxt1Jthi = new System.Windows.Forms.Label();
            this.btnFightJthi = new System.Windows.Forms.Button();
            this.cmbFight2Jthi = new System.Windows.Forms.ComboBox();
            this.cmbFight1Jthi = new System.Windows.Forms.ComboBox();
            this.pcbFight2Jthi = new System.Windows.Forms.PictureBox();
            this.pcbFight1Jthi = new System.Windows.Forms.PictureBox();
            this.tmrJthi = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tbc1Jthi.SuspendLayout();
            this.tbAddJthi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAdd1Jthi)).BeginInit();
            this.tbShowJthi.SuspendLayout();
            this.tbFightJthi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFight2Jthi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFight1Jthi)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsJthi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MsJthi
            // 
            this.MsJthi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsiAddJthi,
            this.MsiShowJthi,
            this.MsiFightJthi});
            this.MsJthi.Name = "MsJthi";
            this.MsJthi.Size = new System.Drawing.Size(44, 20);
            this.MsJthi.Text = "View";
            // 
            // MsiAddJthi
            // 
            this.MsiAddJthi.Name = "MsiAddJthi";
            this.MsiAddJthi.Size = new System.Drawing.Size(103, 22);
            this.MsiAddJthi.Text = "Add";
            this.MsiAddJthi.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // MsiShowJthi
            // 
            this.MsiShowJthi.Name = "MsiShowJthi";
            this.MsiShowJthi.Size = new System.Drawing.Size(103, 22);
            this.MsiShowJthi.Text = "Show";
            this.MsiShowJthi.Click += new System.EventHandler(this.MsiShowJthi_Click);
            // 
            // MsiFightJthi
            // 
            this.MsiFightJthi.Name = "MsiFightJthi";
            this.MsiFightJthi.Size = new System.Drawing.Size(103, 22);
            this.MsiFightJthi.Text = "Fight";
            this.MsiFightJthi.Click += new System.EventHandler(this.MsiFightJthi_Click);
            // 
            // tbc1Jthi
            // 
            this.tbc1Jthi.Controls.Add(this.tbAddJthi);
            this.tbc1Jthi.Controls.Add(this.tbShowJthi);
            this.tbc1Jthi.Controls.Add(this.tbFightJthi);
            this.tbc1Jthi.Location = new System.Drawing.Point(0, 27);
            this.tbc1Jthi.Name = "tbc1Jthi";
            this.tbc1Jthi.SelectedIndex = 0;
            this.tbc1Jthi.Size = new System.Drawing.Size(800, 430);
            this.tbc1Jthi.TabIndex = 1;
            // 
            // tbAddJthi
            // 
            this.tbAddJthi.Controls.Add(this.pcbAdd1Jthi);
            this.tbAddJthi.Controls.Add(this.lblLastAddedJthi);
            this.tbAddJthi.Controls.Add(this.lblLastAddedTxtJthi);
            this.tbAddJthi.Controls.Add(this.lblCountJthi);
            this.tbAddJthi.Controls.Add(this.lblCountTxtJthi);
            this.tbAddJthi.Controls.Add(this.btnAddJthi);
            this.tbAddJthi.Controls.Add(this.lblTypeAddJthi);
            this.tbAddJthi.Controls.Add(this.lblNameAddJthi);
            this.tbAddJthi.Controls.Add(this.cmbTypeJthi);
            this.tbAddJthi.Controls.Add(this.tbAddpkmJthi);
            this.tbAddJthi.Location = new System.Drawing.Point(4, 22);
            this.tbAddJthi.Name = "tbAddJthi";
            this.tbAddJthi.Padding = new System.Windows.Forms.Padding(3);
            this.tbAddJthi.Size = new System.Drawing.Size(792, 404);
            this.tbAddJthi.TabIndex = 0;
            this.tbAddJthi.Text = "Add";
            this.tbAddJthi.UseVisualStyleBackColor = true;
            // 
            // pcbAdd1Jthi
            // 
            this.pcbAdd1Jthi.Image = ((System.Drawing.Image)(resources.GetObject("pcbAdd1Jthi.Image")));
            this.pcbAdd1Jthi.Location = new System.Drawing.Point(569, 61);
            this.pcbAdd1Jthi.Name = "pcbAdd1Jthi";
            this.pcbAdd1Jthi.Size = new System.Drawing.Size(196, 204);
            this.pcbAdd1Jthi.TabIndex = 10;
            this.pcbAdd1Jthi.TabStop = false;
            // 
            // lblLastAddedJthi
            // 
            this.lblLastAddedJthi.Location = new System.Drawing.Point(6, 219);
            this.lblLastAddedJthi.Name = "lblLastAddedJthi";
            this.lblLastAddedJthi.Size = new System.Drawing.Size(342, 182);
            this.lblLastAddedJthi.TabIndex = 9;
            this.lblLastAddedJthi.Text = "label1";
            // 
            // lblLastAddedTxtJthi
            // 
            this.lblLastAddedTxtJthi.AutoSize = true;
            this.lblLastAddedTxtJthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastAddedTxtJthi.Location = new System.Drawing.Point(21, 172);
            this.lblLastAddedTxtJthi.Name = "lblLastAddedTxtJthi";
            this.lblLastAddedTxtJthi.Size = new System.Drawing.Size(158, 31);
            this.lblLastAddedTxtJthi.TabIndex = 8;
            this.lblLastAddedTxtJthi.Text = "Last added";
            // 
            // lblCountJthi
            // 
            this.lblCountJthi.AutoSize = true;
            this.lblCountJthi.Location = new System.Drawing.Point(133, 110);
            this.lblCountJthi.Name = "lblCountJthi";
            this.lblCountJthi.Size = new System.Drawing.Size(13, 13);
            this.lblCountJthi.TabIndex = 7;
            this.lblCountJthi.Text = "0";
            // 
            // lblCountTxtJthi
            // 
            this.lblCountTxtJthi.AutoSize = true;
            this.lblCountTxtJthi.Location = new System.Drawing.Point(18, 110);
            this.lblCountTxtJthi.Name = "lblCountTxtJthi";
            this.lblCountTxtJthi.Size = new System.Drawing.Size(88, 13);
            this.lblCountTxtJthi.TabIndex = 6;
            this.lblCountTxtJthi.Text = "Pokemon count: ";
            // 
            // btnAddJthi
            // 
            this.btnAddJthi.Location = new System.Drawing.Point(21, 42);
            this.btnAddJthi.Name = "btnAddJthi";
            this.btnAddJthi.Size = new System.Drawing.Size(99, 41);
            this.btnAddJthi.TabIndex = 5;
            this.btnAddJthi.Text = "Add";
            this.btnAddJthi.UseVisualStyleBackColor = true;
            this.btnAddJthi.Click += new System.EventHandler(this.btnAddJthi_Click);
            // 
            // lblTypeAddJthi
            // 
            this.lblTypeAddJthi.AutoSize = true;
            this.lblTypeAddJthi.Location = new System.Drawing.Point(285, 42);
            this.lblTypeAddJthi.Name = "lblTypeAddJthi";
            this.lblTypeAddJthi.Size = new System.Drawing.Size(31, 13);
            this.lblTypeAddJthi.TabIndex = 4;
            this.lblTypeAddJthi.Text = "Type";
            // 
            // lblNameAddJthi
            // 
            this.lblNameAddJthi.AutoSize = true;
            this.lblNameAddJthi.Location = new System.Drawing.Point(136, 42);
            this.lblNameAddJthi.Name = "lblNameAddJthi";
            this.lblNameAddJthi.Size = new System.Drawing.Size(35, 13);
            this.lblNameAddJthi.TabIndex = 3;
            this.lblNameAddJthi.Text = "Name";
            // 
            // cmbTypeJthi
            // 
            this.cmbTypeJthi.FormattingEnabled = true;
            this.cmbTypeJthi.Items.AddRange(new object[] {
            "Fire",
            "Water",
            "Electric"});
            this.cmbTypeJthi.Location = new System.Drawing.Point(288, 60);
            this.cmbTypeJthi.Name = "cmbTypeJthi";
            this.cmbTypeJthi.Size = new System.Drawing.Size(121, 21);
            this.cmbTypeJthi.TabIndex = 2;
            // 
            // tbAddpkmJthi
            // 
            this.tbAddpkmJthi.Location = new System.Drawing.Point(136, 61);
            this.tbAddpkmJthi.Name = "tbAddpkmJthi";
            this.tbAddpkmJthi.Size = new System.Drawing.Size(100, 20);
            this.tbAddpkmJthi.TabIndex = 0;
            // 
            // tbShowJthi
            // 
            this.tbShowJthi.Controls.Add(this.cbShowJthi);
            this.tbShowJthi.Controls.Add(this.btnShowJthi);
            this.tbShowJthi.Controls.Add(this.rtbShowJthi);
            this.tbShowJthi.Location = new System.Drawing.Point(4, 22);
            this.tbShowJthi.Name = "tbShowJthi";
            this.tbShowJthi.Padding = new System.Windows.Forms.Padding(3);
            this.tbShowJthi.Size = new System.Drawing.Size(792, 404);
            this.tbShowJthi.TabIndex = 1;
            this.tbShowJthi.Text = "Show";
            this.tbShowJthi.UseVisualStyleBackColor = true;
            // 
            // cbShowJthi
            // 
            this.cbShowJthi.AutoSize = true;
            this.cbShowJthi.Location = new System.Drawing.Point(9, 69);
            this.cbShowJthi.Name = "cbShowJthi";
            this.cbShowJthi.Size = new System.Drawing.Size(86, 17);
            this.cbShowJthi.TabIndex = 2;
            this.cbShowJthi.Text = "Show all info";
            this.cbShowJthi.UseVisualStyleBackColor = true;
            this.cbShowJthi.CheckedChanged += new System.EventHandler(this.cbShowJthi_CheckedChanged);
            // 
            // btnShowJthi
            // 
            this.btnShowJthi.Location = new System.Drawing.Point(8, 21);
            this.btnShowJthi.Name = "btnShowJthi";
            this.btnShowJthi.Size = new System.Drawing.Size(75, 23);
            this.btnShowJthi.TabIndex = 1;
            this.btnShowJthi.Text = "Show";
            this.btnShowJthi.UseVisualStyleBackColor = true;
            this.btnShowJthi.Click += new System.EventHandler(this.btnShowJthi_Click);
            // 
            // rtbShowJthi
            // 
            this.rtbShowJthi.Location = new System.Drawing.Point(150, 6);
            this.rtbShowJthi.Name = "rtbShowJthi";
            this.rtbShowJthi.Size = new System.Drawing.Size(642, 398);
            this.rtbShowJthi.TabIndex = 0;
            this.rtbShowJthi.Text = "";
            // 
            // tbFightJthi
            // 
            this.tbFightJthi.Controls.Add(this.lblFightType2Jthi);
            this.tbFightJthi.Controls.Add(this.lblFightName2Jthi);
            this.tbFightJthi.Controls.Add(this.lblFightTypeTxt2Jthi);
            this.tbFightJthi.Controls.Add(this.lblFightNameTxt2Jthi);
            this.tbFightJthi.Controls.Add(this.lblFightType1Jthi);
            this.tbFightJthi.Controls.Add(this.lblFightName1Jthi);
            this.tbFightJthi.Controls.Add(this.lblFightTypeTxt1Jthi);
            this.tbFightJthi.Controls.Add(this.lblFightNameTxt1Jthi);
            this.tbFightJthi.Controls.Add(this.btnFightJthi);
            this.tbFightJthi.Controls.Add(this.cmbFight2Jthi);
            this.tbFightJthi.Controls.Add(this.cmbFight1Jthi);
            this.tbFightJthi.Controls.Add(this.pcbFight2Jthi);
            this.tbFightJthi.Controls.Add(this.pcbFight1Jthi);
            this.tbFightJthi.Location = new System.Drawing.Point(4, 22);
            this.tbFightJthi.Name = "tbFightJthi";
            this.tbFightJthi.Padding = new System.Windows.Forms.Padding(3);
            this.tbFightJthi.Size = new System.Drawing.Size(792, 404);
            this.tbFightJthi.TabIndex = 2;
            this.tbFightJthi.Text = "Fight";
            this.tbFightJthi.UseVisualStyleBackColor = true;
            // 
            // lblFightType2Jthi
            // 
            this.lblFightType2Jthi.AutoSize = true;
            this.lblFightType2Jthi.Location = new System.Drawing.Point(607, 318);
            this.lblFightType2Jthi.Name = "lblFightType2Jthi";
            this.lblFightType2Jthi.Size = new System.Drawing.Size(16, 13);
            this.lblFightType2Jthi.TabIndex = 23;
            this.lblFightType2Jthi.Text = "...";
            // 
            // lblFightName2Jthi
            // 
            this.lblFightName2Jthi.AutoSize = true;
            this.lblFightName2Jthi.Location = new System.Drawing.Point(607, 295);
            this.lblFightName2Jthi.Name = "lblFightName2Jthi";
            this.lblFightName2Jthi.Size = new System.Drawing.Size(16, 13);
            this.lblFightName2Jthi.TabIndex = 22;
            this.lblFightName2Jthi.Text = "...";
            // 
            // lblFightTypeTxt2Jthi
            // 
            this.lblFightTypeTxt2Jthi.AutoSize = true;
            this.lblFightTypeTxt2Jthi.Location = new System.Drawing.Point(563, 318);
            this.lblFightTypeTxt2Jthi.Name = "lblFightTypeTxt2Jthi";
            this.lblFightTypeTxt2Jthi.Size = new System.Drawing.Size(34, 13);
            this.lblFightTypeTxt2Jthi.TabIndex = 21;
            this.lblFightTypeTxt2Jthi.Text = "Type:";
            // 
            // lblFightNameTxt2Jthi
            // 
            this.lblFightNameTxt2Jthi.AutoSize = true;
            this.lblFightNameTxt2Jthi.Location = new System.Drawing.Point(563, 295);
            this.lblFightNameTxt2Jthi.Name = "lblFightNameTxt2Jthi";
            this.lblFightNameTxt2Jthi.Size = new System.Drawing.Size(38, 13);
            this.lblFightNameTxt2Jthi.TabIndex = 20;
            this.lblFightNameTxt2Jthi.Text = "Name:";
            // 
            // lblFightType1Jthi
            // 
            this.lblFightType1Jthi.AutoSize = true;
            this.lblFightType1Jthi.Location = new System.Drawing.Point(78, 318);
            this.lblFightType1Jthi.Name = "lblFightType1Jthi";
            this.lblFightType1Jthi.Size = new System.Drawing.Size(16, 13);
            this.lblFightType1Jthi.TabIndex = 19;
            this.lblFightType1Jthi.Text = "...";
            // 
            // lblFightName1Jthi
            // 
            this.lblFightName1Jthi.AutoSize = true;
            this.lblFightName1Jthi.Location = new System.Drawing.Point(78, 295);
            this.lblFightName1Jthi.Name = "lblFightName1Jthi";
            this.lblFightName1Jthi.Size = new System.Drawing.Size(16, 13);
            this.lblFightName1Jthi.TabIndex = 18;
            this.lblFightName1Jthi.Text = "...";
            // 
            // lblFightTypeTxt1Jthi
            // 
            this.lblFightTypeTxt1Jthi.AutoSize = true;
            this.lblFightTypeTxt1Jthi.Location = new System.Drawing.Point(34, 318);
            this.lblFightTypeTxt1Jthi.Name = "lblFightTypeTxt1Jthi";
            this.lblFightTypeTxt1Jthi.Size = new System.Drawing.Size(34, 13);
            this.lblFightTypeTxt1Jthi.TabIndex = 17;
            this.lblFightTypeTxt1Jthi.Text = "Type:";
            // 
            // lblFightNameTxt1Jthi
            // 
            this.lblFightNameTxt1Jthi.AutoSize = true;
            this.lblFightNameTxt1Jthi.Location = new System.Drawing.Point(34, 295);
            this.lblFightNameTxt1Jthi.Name = "lblFightNameTxt1Jthi";
            this.lblFightNameTxt1Jthi.Size = new System.Drawing.Size(38, 13);
            this.lblFightNameTxt1Jthi.TabIndex = 16;
            this.lblFightNameTxt1Jthi.Text = "Name:";
            // 
            // btnFightJthi
            // 
            this.btnFightJthi.Location = new System.Drawing.Point(17, 348);
            this.btnFightJthi.Name = "btnFightJthi";
            this.btnFightJthi.Size = new System.Drawing.Size(736, 41);
            this.btnFightJthi.TabIndex = 15;
            this.btnFightJthi.Text = "Fight";
            this.btnFightJthi.UseVisualStyleBackColor = true;
            // 
            // cmbFight2Jthi
            // 
            this.cmbFight2Jthi.FormattingEnabled = true;
            this.cmbFight2Jthi.Location = new System.Drawing.Point(557, 37);
            this.cmbFight2Jthi.Name = "cmbFight2Jthi";
            this.cmbFight2Jthi.Size = new System.Drawing.Size(196, 21);
            this.cmbFight2Jthi.TabIndex = 14;
            // 
            // cmbFight1Jthi
            // 
            this.cmbFight1Jthi.FormattingEnabled = true;
            this.cmbFight1Jthi.Location = new System.Drawing.Point(17, 37);
            this.cmbFight1Jthi.Name = "cmbFight1Jthi";
            this.cmbFight1Jthi.Size = new System.Drawing.Size(196, 21);
            this.cmbFight1Jthi.TabIndex = 13;
            // 
            // pcbFight2Jthi
            // 
            this.pcbFight2Jthi.Image = ((System.Drawing.Image)(resources.GetObject("pcbFight2Jthi.Image")));
            this.pcbFight2Jthi.Location = new System.Drawing.Point(557, 74);
            this.pcbFight2Jthi.Name = "pcbFight2Jthi";
            this.pcbFight2Jthi.Size = new System.Drawing.Size(196, 204);
            this.pcbFight2Jthi.TabIndex = 12;
            this.pcbFight2Jthi.TabStop = false;
            // 
            // pcbFight1Jthi
            // 
            this.pcbFight1Jthi.Image = ((System.Drawing.Image)(resources.GetObject("pcbFight1Jthi.Image")));
            this.pcbFight1Jthi.Location = new System.Drawing.Point(17, 74);
            this.pcbFight1Jthi.Name = "pcbFight1Jthi";
            this.pcbFight1Jthi.Size = new System.Drawing.Size(196, 204);
            this.pcbFight1Jthi.TabIndex = 11;
            this.pcbFight1Jthi.TabStop = false;
            // 
            // tmrJthi
            // 
            this.tmrJthi.Tick += new System.EventHandler(this.tmrJthi_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbc1Jthi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbc1Jthi.ResumeLayout(false);
            this.tbAddJthi.ResumeLayout(false);
            this.tbAddJthi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAdd1Jthi)).EndInit();
            this.tbShowJthi.ResumeLayout(false);
            this.tbShowJthi.PerformLayout();
            this.tbFightJthi.ResumeLayout(false);
            this.tbFightJthi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFight2Jthi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFight1Jthi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MsJthi;
        private System.Windows.Forms.ToolStripMenuItem MsiAddJthi;
        private System.Windows.Forms.ToolStripMenuItem MsiShowJthi;
        private System.Windows.Forms.ToolStripMenuItem MsiFightJthi;
        private System.Windows.Forms.TabControl tbc1Jthi;
        private System.Windows.Forms.TabPage tbAddJthi;
        private System.Windows.Forms.TabPage tbShowJthi;
        private System.Windows.Forms.TabPage tbFightJthi;
        private System.Windows.Forms.TextBox tbAddpkmJthi;
        private System.Windows.Forms.Label lblCountJthi;
        private System.Windows.Forms.Label lblCountTxtJthi;
        private System.Windows.Forms.Button btnAddJthi;
        private System.Windows.Forms.Label lblTypeAddJthi;
        private System.Windows.Forms.Label lblNameAddJthi;
        private System.Windows.Forms.ComboBox cmbTypeJthi;
        private System.Windows.Forms.Label lblLastAddedJthi;
        private System.Windows.Forms.Label lblLastAddedTxtJthi;
        private System.Windows.Forms.PictureBox pcbAdd1Jthi;
        private System.Windows.Forms.CheckBox cbShowJthi;
        private System.Windows.Forms.Button btnShowJthi;
        private System.Windows.Forms.RichTextBox rtbShowJthi;
        private System.Windows.Forms.PictureBox pcbFight2Jthi;
        private System.Windows.Forms.PictureBox pcbFight1Jthi;
        private System.Windows.Forms.Label lblFightType2Jthi;
        private System.Windows.Forms.Label lblFightName2Jthi;
        private System.Windows.Forms.Label lblFightTypeTxt2Jthi;
        private System.Windows.Forms.Label lblFightNameTxt2Jthi;
        private System.Windows.Forms.Label lblFightType1Jthi;
        private System.Windows.Forms.Label lblFightName1Jthi;
        private System.Windows.Forms.Label lblFightTypeTxt1Jthi;
        private System.Windows.Forms.Label lblFightNameTxt1Jthi;
        private System.Windows.Forms.Button btnFightJthi;
        private System.Windows.Forms.ComboBox cmbFight2Jthi;
        private System.Windows.Forms.ComboBox cmbFight1Jthi;
        private System.Windows.Forms.Timer tmrJthi;
    }
}

