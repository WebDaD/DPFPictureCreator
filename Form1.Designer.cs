namespace QlockTwoCreator
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
            this.btn_Go = new System.Windows.Forms.Button();
            this.pg_Bar = new System.Windows.Forms.ProgressBar();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Normal = new System.Windows.Forms.Label();
            this.lb_HL = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_Folder = new System.Windows.Forms.Button();
            this.nud_Res_X = new System.Windows.Forms.NumericUpDown();
            this.nud_Res_Y = new System.Windows.Forms.NumericUpDown();
            this.nud_Factor = new System.Windows.Forms.NumericUpDown();
            this.cb_Format = new System.Windows.Forms.ComboBox();
            this.lb_BG = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Font = new System.Windows.Forms.Button();
            this.txt_Font = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Secret = new System.Windows.Forms.MaskedTextBox();
            this.cd_BG = new System.Windows.Forms.ColorDialog();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.cd_HL = new System.Windows.Forms.ColorDialog();
            this.cd_Normal = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dPFHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Res_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Res_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Factor)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Go
            // 
            this.btn_Go.Location = new System.Drawing.Point(94, 448);
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(232, 23);
            this.btn_Go.TabIndex = 0;
            this.btn_Go.Text = "Create";
            this.btn_Go.UseVisualStyleBackColor = true;
            this.btn_Go.Click += new System.EventHandler(this.btn_Go_Click);
            this.btn_Go.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btn_Go_HelpRequested);
            // 
            // pg_Bar
            // 
            this.pg_Bar.BackColor = System.Drawing.SystemColors.Desktop;
            this.pg_Bar.ForeColor = System.Drawing.Color.Lime;
            this.pg_Bar.Location = new System.Drawing.Point(11, 406);
            this.pg_Bar.MarqueeAnimationSpeed = 50;
            this.pg_Bar.Maximum = 1440;
            this.pg_Bar.Name = "pg_Bar";
            this.pg_Bar.Size = new System.Drawing.Size(313, 36);
            this.pg_Bar.Step = 1;
            this.pg_Bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pg_Bar.TabIndex = 1;
            this.pg_Bar.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.pg_Bar_HelpRequested);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(11, 448);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            this.btn_Exit.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btn_Exit_HelpRequested);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Use this To Create Pictures needed for the Clock!";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lb_Normal, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lb_HL, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nud_Res_X, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.nud_Res_Y, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.nud_Factor, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cb_Format, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_BG, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txt_Secret, 1, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(311, 340);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lb_Normal
            // 
            this.lb_Normal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Normal.AutoSize = true;
            this.lb_Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_Normal.Location = new System.Drawing.Point(158, 238);
            this.lb_Normal.Name = "lb_Normal";
            this.lb_Normal.Size = new System.Drawing.Size(150, 34);
            this.lb_Normal.TabIndex = 15;
            this.lb_Normal.Click += new System.EventHandler(this.lb_Normal_Click);
            this.lb_Normal.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.lb_Normal_HelpRequested);
            // 
            // lb_HL
            // 
            this.lb_HL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_HL.AutoSize = true;
            this.lb_HL.BackColor = System.Drawing.Color.White;
            this.lb_HL.Location = new System.Drawing.Point(158, 204);
            this.lb_HL.Name = "lb_HL";
            this.lb_HL.Size = new System.Drawing.Size(150, 34);
            this.lb_HL.TabIndex = 14;
            this.lb_HL.Click += new System.EventHandler(this.lb_HL_Click);
            this.lb_HL.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.lb_HL_HelpRequested);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Path to Save To:";
            this.label7.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.label7_HelpRequested);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Resolution Y:";
            this.label3.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.label3_HelpRequested);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Resolution X:";
            this.label2.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.label2_HelpRequested);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Location = new System.Drawing.Point(40, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Image Format:";
            this.label8.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.label8_HelpRequested);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Normal Color:";
            this.label6.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.label6_HelpRequested);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Highlight Color:";
            this.label5.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.label5_HelpRequested);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "BackGround Color:";
            this.label4.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.label4_HelpRequested);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Max Show Time:";
            this.label9.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.label9_HelpRequested);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txt_path, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Folder, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(158, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(150, 26);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // txt_path
            // 
            this.txt_path.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_path.Location = new System.Drawing.Point(3, 3);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(69, 20);
            this.txt_path.TabIndex = 0;
            this.txt_path.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.txt_path_HelpRequested);
            // 
            // btn_Folder
            // 
            this.btn_Folder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Folder.Location = new System.Drawing.Point(78, 3);
            this.btn_Folder.Name = "btn_Folder";
            this.btn_Folder.Size = new System.Drawing.Size(69, 20);
            this.btn_Folder.TabIndex = 1;
            this.btn_Folder.Text = "...";
            this.btn_Folder.UseVisualStyleBackColor = true;
            this.btn_Folder.Click += new System.EventHandler(this.btn_Folder_Click);
            this.btn_Folder.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btn_Folder_HelpRequested);
            // 
            // nud_Res_X
            // 
            this.nud_Res_X.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nud_Res_X.Location = new System.Drawing.Point(159, 75);
            this.nud_Res_X.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.nud_Res_X.Minimum = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.nud_Res_X.Name = "nud_Res_X";
            this.nud_Res_X.Size = new System.Drawing.Size(147, 20);
            this.nud_Res_X.TabIndex = 9;
            this.nud_Res_X.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.nud_Res_X.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.nud_Res_X_HelpRequested);
            // 
            // nud_Res_Y
            // 
            this.nud_Res_Y.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nud_Res_Y.Location = new System.Drawing.Point(159, 109);
            this.nud_Res_Y.Maximum = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            this.nud_Res_Y.Minimum = new decimal(new int[] {
            234,
            0,
            0,
            0});
            this.nud_Res_Y.Name = "nud_Res_Y";
            this.nud_Res_Y.Size = new System.Drawing.Size(147, 20);
            this.nud_Res_Y.TabIndex = 10;
            this.nud_Res_Y.Value = new decimal(new int[] {
            234,
            0,
            0,
            0});
            this.nud_Res_Y.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.nud_Res_Y_HelpRequested);
            // 
            // nud_Factor
            // 
            this.nud_Factor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nud_Factor.Enabled = false;
            this.nud_Factor.Location = new System.Drawing.Point(159, 143);
            this.nud_Factor.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_Factor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Factor.Name = "nud_Factor";
            this.nud_Factor.Size = new System.Drawing.Size(147, 20);
            this.nud_Factor.TabIndex = 11;
            this.nud_Factor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Factor.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.nud_Factor_HelpRequested);
            // 
            // cb_Format
            // 
            this.cb_Format.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_Format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Format.FormattingEnabled = true;
            this.cb_Format.Location = new System.Drawing.Point(159, 40);
            this.cb_Format.Name = "cb_Format";
            this.cb_Format.Size = new System.Drawing.Size(147, 21);
            this.cb_Format.TabIndex = 12;
            this.cb_Format.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.cb_Format_HelpRequested);
            // 
            // lb_BG
            // 
            this.lb_BG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_BG.AutoSize = true;
            this.lb_BG.BackColor = System.Drawing.Color.Black;
            this.lb_BG.Location = new System.Drawing.Point(158, 170);
            this.lb_BG.Name = "lb_BG";
            this.lb_BG.Size = new System.Drawing.Size(150, 34);
            this.lb_BG.TabIndex = 13;
            this.lb_BG.Click += new System.EventHandler(this.lb_BG_Click);
            this.lb_BG.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.lb_BG_HelpRequested);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(62, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Font:";
            this.label11.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.label11_HelpRequested);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btn_Font, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_Font, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(158, 275);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(150, 28);
            this.tableLayoutPanel3.TabIndex = 17;
            // 
            // btn_Font
            // 
            this.btn_Font.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Font.Location = new System.Drawing.Point(78, 3);
            this.btn_Font.Name = "btn_Font";
            this.btn_Font.Size = new System.Drawing.Size(69, 22);
            this.btn_Font.TabIndex = 1;
            this.btn_Font.Text = "...";
            this.btn_Font.UseVisualStyleBackColor = true;
            this.btn_Font.Click += new System.EventHandler(this.btn_Font_Click);
            this.btn_Font.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btn_Font_HelpRequested);
            // 
            // txt_Font
            // 
            this.txt_Font.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Font.AutoSize = true;
            this.txt_Font.Location = new System.Drawing.Point(24, 7);
            this.txt_Font.Name = "txt_Font";
            this.txt_Font.Size = new System.Drawing.Size(27, 13);
            this.txt_Font.TabIndex = 2;
            this.txt_Font.Text = "Arial";
            this.txt_Font.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.txt_Font_HelpRequested);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 316);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Secret Word:";
            this.label12.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.label12_HelpRequested);
            // 
            // txt_Secret
            // 
            this.txt_Secret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Secret.Location = new System.Drawing.Point(159, 313);
            this.txt_Secret.Mask = "AAAAAAAAAAAAAAAA";
            this.txt_Secret.Name = "txt_Secret";
            this.txt_Secret.Size = new System.Drawing.Size(147, 20);
            this.txt_Secret.TabIndex = 19;
            this.txt_Secret.Text = "DOMINIKSIGMUNDWD";
            this.txt_Secret.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.txt_Secret_HelpRequested);
            // 
            // cd_BG
            // 
            this.cd_BG.AnyColor = true;
            this.cd_BG.FullOpen = true;
            this.cd_BG.ShowHelp = true;
            this.cd_BG.SolidColorOnly = true;
            // 
            // cd_HL
            // 
            this.cd_HL.AnyColor = true;
            this.cd_HL.Color = System.Drawing.Color.White;
            this.cd_HL.FullOpen = true;
            this.cd_HL.ShowHelp = true;
            this.cd_HL.SolidColorOnly = true;
            // 
            // cd_Normal
            // 
            this.cd_Normal.AnyColor = true;
            this.cd_Normal.Color = System.Drawing.Color.Silver;
            this.cd_Normal.FullOpen = true;
            this.cd_Normal.ShowHelp = true;
            this.cd_Normal.SolidColorOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(337, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dPFHelpToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // dPFHelpToolStripMenuItem
            // 
            this.dPFHelpToolStripMenuItem.Name = "dPFHelpToolStripMenuItem";
            this.dPFHelpToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.dPFHelpToolStripMenuItem.Text = "DPF Help";
            this.dPFHelpToolStripMenuItem.Click += new System.EventHandler(this.dPFHelpToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // fontDialog
            // 
            this.fontDialog.FontMustExist = true;
            this.fontDialog.ShowEffects = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 480);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.pg_Bar);
            this.Controls.Add(this.btn_Go);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "DPF Clock Picture Generator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Res_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Res_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Factor)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Go;
        private System.Windows.Forms.ProgressBar pg_Bar;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button btn_Folder;
        private System.Windows.Forms.NumericUpDown nud_Res_X;
        private System.Windows.Forms.NumericUpDown nud_Res_Y;
        private System.Windows.Forms.NumericUpDown nud_Factor;
        private System.Windows.Forms.ComboBox cb_Format;
        private System.Windows.Forms.Label lb_BG;
        private System.Windows.Forms.ColorDialog cd_BG;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Label lb_Normal;
        private System.Windows.Forms.Label lb_HL;
        private System.Windows.Forms.ColorDialog cd_HL;
        private System.Windows.Forms.ColorDialog cd_Normal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_Font;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Label txt_Font;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txt_Secret;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dPFHelpToolStripMenuItem;
    }
}

