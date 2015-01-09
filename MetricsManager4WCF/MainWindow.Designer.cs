namespace MetricsManager4WCF
{
    partial class MainWindow
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_config = new System.Windows.Forms.TabPage();
            this.btn_clear = new System.Windows.Forms.Button();
            this.pic_tm = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ck_notify = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_canary = new System.Windows.Forms.TextBox();
            this.rch_error = new System.Windows.Forms.RichTextBox();
            this.lbl_tm_count = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rch_body = new System.Windows.Forms.RichTextBox();
            this.rch_header = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_wcf_url = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_wm = new System.Windows.Forms.Button();
            this.btn_rm = new System.Windows.Forms.Button();
            this.btn_lm = new System.Windows.Forms.Button();
            this.btn_createlog = new System.Windows.Forms.Button();
            this.btn_fm = new System.Windows.Forms.Button();
            this.btn_tm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_test_connect = new System.Windows.Forms.Button();
            this.btn_create_db = new System.Windows.Forms.Button();
            this.btn_validate_db = new System.Windows.Forms.Button();
            this.ck_trusted = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_database = new System.Windows.Forms.TextBox();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.txt_dbserver = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_process = new System.Windows.Forms.TabPage();
            this.tab_report = new System.Windows.Forms.TabPage();
            this.tab_history = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tab_config.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tm)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tab_config);
            this.tabControl1.Controls.Add(this.tab_process);
            this.tabControl1.Controls.Add(this.tab_report);
            this.tabControl1.Controls.Add(this.tab_history);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(827, 613);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_config
            // 
            this.tab_config.Controls.Add(this.btn_clear);
            this.tab_config.Controls.Add(this.pic_tm);
            this.tab_config.Controls.Add(this.groupBox2);
            this.tab_config.Controls.Add(this.btn_wm);
            this.tab_config.Controls.Add(this.btn_rm);
            this.tab_config.Controls.Add(this.btn_lm);
            this.tab_config.Controls.Add(this.btn_createlog);
            this.tab_config.Controls.Add(this.btn_fm);
            this.tab_config.Controls.Add(this.btn_tm);
            this.tab_config.Controls.Add(this.groupBox1);
            this.tab_config.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_config.Location = new System.Drawing.Point(4, 25);
            this.tab_config.Margin = new System.Windows.Forms.Padding(4);
            this.tab_config.Name = "tab_config";
            this.tab_config.Padding = new System.Windows.Forms.Padding(4);
            this.tab_config.Size = new System.Drawing.Size(819, 584);
            this.tab_config.TabIndex = 0;
            this.tab_config.Text = "General";
            this.tab_config.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(121, 311);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 17;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // pic_tm
            // 
            this.pic_tm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_tm.Location = new System.Drawing.Point(121, 340);
            this.pic_tm.Name = "pic_tm";
            this.pic_tm.Size = new System.Drawing.Size(270, 236);
            this.pic_tm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_tm.TabIndex = 16;
            this.pic_tm.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ck_notify);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_canary);
            this.groupBox2.Controls.Add(this.rch_error);
            this.groupBox2.Controls.Add(this.lbl_tm_count);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.rch_body);
            this.groupBox2.Controls.Add(this.rch_header);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_wcf_url);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(398, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(413, 567);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Service URL";
            // 
            // ck_notify
            // 
            this.ck_notify.AutoSize = true;
            this.ck_notify.Checked = true;
            this.ck_notify.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ck_notify.Location = new System.Drawing.Point(149, 97);
            this.ck_notify.Name = "ck_notify";
            this.ck_notify.Size = new System.Drawing.Size(65, 17);
            this.ck_notify.TabIndex = 34;
            this.ck_notify.Text = "Enabled";
            this.ck_notify.UseVisualStyleBackColor = true;
            this.ck_notify.CheckedChanged += new System.EventHandler(this.ck_notify_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 95);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "Notification Service ";
            // 
            // txt_canary
            // 
            this.txt_canary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_canary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_canary.Location = new System.Drawing.Point(8, 116);
            this.txt_canary.Margin = new System.Windows.Forms.Padding(4);
            this.txt_canary.Name = "txt_canary";
            this.txt_canary.Size = new System.Drawing.Size(397, 23);
            this.txt_canary.TabIndex = 32;
            this.txt_canary.Text = "http://mmcloud.mmisecure.com:8001/";
            // 
            // rch_error
            // 
            this.rch_error.Location = new System.Drawing.Point(7, 347);
            this.rch_error.Name = "rch_error";
            this.rch_error.Size = new System.Drawing.Size(396, 195);
            this.rch_error.TabIndex = 31;
            this.rch_error.Text = "";
            // 
            // lbl_tm_count
            // 
            this.lbl_tm_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_tm_count.AutoSize = true;
            this.lbl_tm_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tm_count.ForeColor = System.Drawing.Color.Red;
            this.lbl_tm_count.Location = new System.Drawing.Point(64, 545);
            this.lbl_tm_count.Name = "lbl_tm_count";
            this.lbl_tm_count.Size = new System.Drawing.Size(18, 20);
            this.lbl_tm_count.TabIndex = 30;
            this.lbl_tm_count.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 545);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Count :  ";
            // 
            // rch_body
            // 
            this.rch_body.Location = new System.Drawing.Point(215, 145);
            this.rch_body.Name = "rch_body";
            this.rch_body.Size = new System.Drawing.Size(190, 196);
            this.rch_body.TabIndex = 17;
            this.rch_body.Text = "";
            // 
            // rch_header
            // 
            this.rch_header.Location = new System.Drawing.Point(9, 145);
            this.rch_header.Name = "rch_header";
            this.rch_header.Size = new System.Drawing.Size(200, 196);
            this.rch_header.TabIndex = 16;
            this.rch_header.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(83, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(324, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "IP address is local IP, please use public IP for internet";
            // 
            // txt_wcf_url
            // 
            this.txt_wcf_url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_wcf_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_wcf_url.Location = new System.Drawing.Point(8, 48);
            this.txt_wcf_url.Margin = new System.Windows.Forms.Padding(4);
            this.txt_wcf_url.Name = "txt_wcf_url";
            this.txt_wcf_url.Size = new System.Drawing.Size(397, 23);
            this.txt_wcf_url.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 27);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "MMService  ";
            // 
            // btn_wm
            // 
            this.btn_wm.Location = new System.Drawing.Point(11, 530);
            this.btn_wm.Name = "btn_wm";
            this.btn_wm.Size = new System.Drawing.Size(104, 28);
            this.btn_wm.TabIndex = 6;
            this.btn_wm.Text = "Log WM";
            this.btn_wm.UseVisualStyleBackColor = true;
            this.btn_wm.Click += new System.EventHandler(this.btn_wm_Click);
            // 
            // btn_rm
            // 
            this.btn_rm.Location = new System.Drawing.Point(11, 498);
            this.btn_rm.Name = "btn_rm";
            this.btn_rm.Size = new System.Drawing.Size(104, 28);
            this.btn_rm.TabIndex = 5;
            this.btn_rm.Text = "Log RM";
            this.btn_rm.UseVisualStyleBackColor = true;
            this.btn_rm.Click += new System.EventHandler(this.btn_rm_Click);
            // 
            // btn_lm
            // 
            this.btn_lm.Location = new System.Drawing.Point(11, 466);
            this.btn_lm.Name = "btn_lm";
            this.btn_lm.Size = new System.Drawing.Size(104, 28);
            this.btn_lm.TabIndex = 4;
            this.btn_lm.Text = "Log LM";
            this.btn_lm.UseVisualStyleBackColor = true;
            this.btn_lm.Click += new System.EventHandler(this.btn_lm_Click);
            // 
            // btn_createlog
            // 
            this.btn_createlog.Location = new System.Drawing.Point(11, 354);
            this.btn_createlog.Name = "btn_createlog";
            this.btn_createlog.Size = new System.Drawing.Size(104, 28);
            this.btn_createlog.TabIndex = 3;
            this.btn_createlog.Text = "Create LogDB";
            this.btn_createlog.UseVisualStyleBackColor = true;
            this.btn_createlog.Click += new System.EventHandler(this.btn_createlog_Click);
            // 
            // btn_fm
            // 
            this.btn_fm.Location = new System.Drawing.Point(11, 434);
            this.btn_fm.Name = "btn_fm";
            this.btn_fm.Size = new System.Drawing.Size(104, 28);
            this.btn_fm.TabIndex = 2;
            this.btn_fm.Text = "Log FM";
            this.btn_fm.UseVisualStyleBackColor = true;
            this.btn_fm.Click += new System.EventHandler(this.btn_fm_Click);
            // 
            // btn_tm
            // 
            this.btn_tm.Location = new System.Drawing.Point(11, 402);
            this.btn_tm.Name = "btn_tm";
            this.btn_tm.Size = new System.Drawing.Size(104, 28);
            this.btn_tm.TabIndex = 1;
            this.btn_tm.Text = "Log TM";
            this.btn_tm.UseVisualStyleBackColor = true;
            this.btn_tm.Click += new System.EventHandler(this.btn_tm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_test_connect);
            this.groupBox1.Controls.Add(this.btn_create_db);
            this.groupBox1.Controls.Add(this.btn_validate_db);
            this.groupBox1.Controls.Add(this.ck_trusted);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_database);
            this.groupBox1.Controls.Add(this.txt_userid);
            this.groupBox1.Controls.Add(this.txt_dbserver);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(379, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Settings";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(90, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(277, 35);
            this.label7.TabIndex = 14;
            this.label7.Text = "Please don\'t use SQL \"Trusted Connection\" for IIS. Please  specify  SQL User ID a" +
    "nd  Password for IIS.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Notes :  ";
            // 
            // btn_test_connect
            // 
            this.btn_test_connect.Location = new System.Drawing.Point(15, 234);
            this.btn_test_connect.Name = "btn_test_connect";
            this.btn_test_connect.Size = new System.Drawing.Size(116, 23);
            this.btn_test_connect.TabIndex = 12;
            this.btn_test_connect.Text = "Test Connect";
            this.btn_test_connect.UseVisualStyleBackColor = true;
            this.btn_test_connect.Click += new System.EventHandler(this.btn_test_connect_Click);
            // 
            // btn_create_db
            // 
            this.btn_create_db.Location = new System.Drawing.Point(251, 234);
            this.btn_create_db.Name = "btn_create_db";
            this.btn_create_db.Size = new System.Drawing.Size(116, 23);
            this.btn_create_db.TabIndex = 11;
            this.btn_create_db.Text = "Create DB";
            this.btn_create_db.UseVisualStyleBackColor = true;
            this.btn_create_db.Click += new System.EventHandler(this.btn_create_db_Click);
            // 
            // btn_validate_db
            // 
            this.btn_validate_db.Location = new System.Drawing.Point(133, 234);
            this.btn_validate_db.Name = "btn_validate_db";
            this.btn_validate_db.Size = new System.Drawing.Size(116, 23);
            this.btn_validate_db.TabIndex = 10;
            this.btn_validate_db.Text = "Validate DB";
            this.btn_validate_db.UseVisualStyleBackColor = true;
            this.btn_validate_db.Click += new System.EventHandler(this.btn_validate_db_Click);
            // 
            // ck_trusted
            // 
            this.ck_trusted.AutoSize = true;
            this.ck_trusted.Checked = true;
            this.ck_trusted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ck_trusted.Location = new System.Drawing.Point(93, 155);
            this.ck_trusted.Name = "ck_trusted";
            this.ck_trusted.Size = new System.Drawing.Size(119, 17);
            this.ck_trusted.TabIndex = 9;
            this.ck_trusted.Text = "Trusted Connection";
            this.ck_trusted.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Integration : ";
            // 
            // txt_database
            // 
            this.txt_database.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_database.Location = new System.Drawing.Point(93, 56);
            this.txt_database.Margin = new System.Windows.Forms.Padding(4);
            this.txt_database.Name = "txt_database";
            this.txt_database.ReadOnly = true;
            this.txt_database.Size = new System.Drawing.Size(274, 23);
            this.txt_database.TabIndex = 7;
            this.txt_database.Text = "MetricsManagerDB";
            // 
            // txt_userid
            // 
            this.txt_userid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userid.Location = new System.Drawing.Point(93, 87);
            this.txt_userid.Margin = new System.Windows.Forms.Padding(4);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(274, 23);
            this.txt_userid.TabIndex = 5;
            // 
            // txt_dbserver
            // 
            this.txt_dbserver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dbserver.Location = new System.Drawing.Point(93, 25);
            this.txt_dbserver.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dbserver.Name = "txt_dbserver";
            this.txt_dbserver.Size = new System.Drawing.Size(274, 23);
            this.txt_dbserver.TabIndex = 1;
            this.txt_dbserver.Text = "LOCALHOST\\SQLEXPRESS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Database : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "User ID : ";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(93, 118);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(274, 23);
            this.txt_password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server : ";
            // 
            // tab_process
            // 
            this.tab_process.Location = new System.Drawing.Point(4, 25);
            this.tab_process.Margin = new System.Windows.Forms.Padding(4);
            this.tab_process.Name = "tab_process";
            this.tab_process.Padding = new System.Windows.Forms.Padding(4);
            this.tab_process.Size = new System.Drawing.Size(819, 584);
            this.tab_process.TabIndex = 1;
            this.tab_process.Text = "Processor";
            this.tab_process.UseVisualStyleBackColor = true;
            // 
            // tab_report
            // 
            this.tab_report.Location = new System.Drawing.Point(4, 25);
            this.tab_report.Margin = new System.Windows.Forms.Padding(4);
            this.tab_report.Name = "tab_report";
            this.tab_report.Size = new System.Drawing.Size(819, 584);
            this.tab_report.TabIndex = 2;
            this.tab_report.Text = "Report";
            this.tab_report.UseVisualStyleBackColor = true;
            // 
            // tab_history
            // 
            this.tab_history.Location = new System.Drawing.Point(4, 25);
            this.tab_history.Margin = new System.Windows.Forms.Padding(4);
            this.tab_history.Name = "tab_history";
            this.tab_history.Size = new System.Drawing.Size(819, 584);
            this.tab_history.TabIndex = 3;
            this.tab_history.Text = "History";
            this.tab_history.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(826, 613);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "MetricsManager WCF - Version 4.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_config.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_tm)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_config;
        private System.Windows.Forms.TabPage tab_process;
        private System.Windows.Forms.TabPage tab_report;
        private System.Windows.Forms.TabPage tab_history;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_dbserver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_database;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_userid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ck_trusted;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_create_db;
        private System.Windows.Forms.Button btn_validate_db;
        private System.Windows.Forms.Button btn_test_connect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_tm;
        private System.Windows.Forms.Button btn_fm;
        private System.Windows.Forms.Button btn_createlog;
        private System.Windows.Forms.Button btn_lm;
        private System.Windows.Forms.Button btn_rm;
        private System.Windows.Forms.Button btn_wm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_wcf_url;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rch_header;
        private System.Windows.Forms.RichTextBox rch_body;
        private System.Windows.Forms.PictureBox pic_tm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_tm_count;
        private System.Windows.Forms.RichTextBox rch_error;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_canary;
        private System.Windows.Forms.CheckBox ck_notify;
        private System.Windows.Forms.Button btn_clear;
    }
}

