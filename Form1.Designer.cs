namespace ProjectCharlie
{
     partial  class Form1
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
            this.TB_VisitorName = new System.Windows.Forms.TextBox();
            this.Visitor_Name = new System.Windows.Forms.Label();
            this.TB_Surname = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.Box_Visitor = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.TB_Mobile = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.Box_Meeting = new System.Windows.Forms.GroupBox();
            this.Lbl_hhmm = new System.Windows.Forms.Label();
            this.CBox_Meeting = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblMeetAim = new System.Windows.Forms.Label();
            this.lblMeetWith = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btn_Aim = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LB_VisitOnSite = new System.Windows.Forms.ListBox();
            this.NUD_Hour = new System.Windows.Forms.NumericUpDown();
            this.NUD_Min = new System.Windows.Forms.NumericUpDown();
            this.Btn_Remove = new System.Windows.Forms.Button();
            this.Box_Visitor.SuspendLayout();
            this.Box_Meeting.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Min)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_VisitorName
            // 
            this.TB_VisitorName.AcceptsReturn = true;
            this.TB_VisitorName.Location = new System.Drawing.Point(7, 63);
            this.TB_VisitorName.Margin = new System.Windows.Forms.Padding(4);
            this.TB_VisitorName.Name = "TB_VisitorName";
            this.TB_VisitorName.Size = new System.Drawing.Size(180, 33);
            this.TB_VisitorName.TabIndex = 1;
            this.TB_VisitorName.TextChanged += new System.EventHandler(this.TB_VisitorName_TextChanged);
            // 
            // Visitor_Name
            // 
            this.Visitor_Name.AutoSize = true;
            this.Visitor_Name.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visitor_Name.Location = new System.Drawing.Point(10, 38);
            this.Visitor_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Visitor_Name.Name = "Visitor_Name";
            this.Visitor_Name.Size = new System.Drawing.Size(57, 23);
            this.Visitor_Name.TabIndex = 2;
            this.Visitor_Name.Text = "Name";
            this.Visitor_Name.Click += new System.EventHandler(this.label2_Click);
            // 
            // TB_Surname
            // 
            this.TB_Surname.Location = new System.Drawing.Point(7, 129);
            this.TB_Surname.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Surname.Multiline = true;
            this.TB_Surname.Name = "TB_Surname";
            this.TB_Surname.Size = new System.Drawing.Size(180, 33);
            this.TB_Surname.TabIndex = 3;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.Olive;
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Location = new System.Drawing.Point(12, 354);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_Submit.Size = new System.Drawing.Size(435, 39);
            this.btn_Submit.TabIndex = 4;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // Box_Visitor
            // 
            this.Box_Visitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Box_Visitor.Controls.Add(this.lblEmail);
            this.Box_Visitor.Controls.Add(this.TB_Email);
            this.Box_Visitor.Controls.Add(this.TB_Mobile);
            this.Box_Visitor.Controls.Add(this.lblMobile);
            this.Box_Visitor.Controls.Add(this.lblSurname);
            this.Box_Visitor.Controls.Add(this.Visitor_Name);
            this.Box_Visitor.Controls.Add(this.TB_VisitorName);
            this.Box_Visitor.Controls.Add(this.TB_Surname);
            this.Box_Visitor.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Visitor.Location = new System.Drawing.Point(12, 12);
            this.Box_Visitor.Name = "Box_Visitor";
            this.Box_Visitor.Size = new System.Drawing.Size(203, 319);
            this.Box_Visitor.TabIndex = 5;
            this.Box_Visitor.TabStop = false;
            this.Box_Visitor.Text = "Visitor Login";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(10, 244);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 23);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(7, 269);
            this.TB_Email.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Email.Multiline = true;
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(180, 33);
            this.TB_Email.TabIndex = 7;
            // 
            // TB_Mobile
            // 
            this.TB_Mobile.Location = new System.Drawing.Point(7, 197);
            this.TB_Mobile.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Mobile.Multiline = true;
            this.TB_Mobile.Name = "TB_Mobile";
            this.TB_Mobile.Size = new System.Drawing.Size(180, 33);
            this.TB_Mobile.TabIndex = 6;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(10, 174);
            this.lblMobile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(64, 23);
            this.lblMobile.TabIndex = 5;
            this.lblMobile.Text = "Mobile";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(10, 105);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(79, 23);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Surname";
            // 
            // Box_Meeting
            // 
            this.Box_Meeting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Box_Meeting.Controls.Add(this.NUD_Min);
            this.Box_Meeting.Controls.Add(this.NUD_Hour);
            this.Box_Meeting.Controls.Add(this.Lbl_hhmm);
            this.Box_Meeting.Controls.Add(this.CBox_Meeting);
            this.Box_Meeting.Controls.Add(this.dateTimePicker1);
            this.Box_Meeting.Controls.Add(this.lblMeetAim);
            this.Box_Meeting.Controls.Add(this.lblMeetWith);
            this.Box_Meeting.Controls.Add(this.lblTime);
            this.Box_Meeting.Controls.Add(this.btn_Aim);
            this.Box_Meeting.Controls.Add(this.lblDate);
            this.Box_Meeting.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Meeting.Location = new System.Drawing.Point(245, 12);
            this.Box_Meeting.Name = "Box_Meeting";
            this.Box_Meeting.Size = new System.Drawing.Size(202, 319);
            this.Box_Meeting.TabIndex = 6;
            this.Box_Meeting.TabStop = false;
            this.Box_Meeting.Text = "Meeting Details";
            this.Box_Meeting.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Lbl_hhmm
            // 
            this.Lbl_hhmm.AutoSize = true;
            this.Lbl_hhmm.Font = new System.Drawing.Font("Tw Cen MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_hhmm.Location = new System.Drawing.Point(81, 113);
            this.Lbl_hhmm.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_hhmm.Name = "Lbl_hhmm";
            this.Lbl_hhmm.Size = new System.Drawing.Size(29, 47);
            this.Lbl_hhmm.TabIndex = 14;
            this.Lbl_hhmm.Text = ":";
            // 
            // CBox_Meeting
            // 
            this.CBox_Meeting.FormattingEnabled = true;
            this.CBox_Meeting.Items.AddRange(new object[] {
            "Des Troy",
            "Buf Ering",
            "Reb Oot",
            "Tess Coles",
            "Beta Bot",
            "Bru Java"});
            this.CBox_Meeting.Location = new System.Drawing.Point(21, 193);
            this.CBox_Meeting.Name = "CBox_Meeting";
            this.CBox_Meeting.Size = new System.Drawing.Size(161, 35);
            this.CBox_Meeting.TabIndex = 10;
            this.CBox_Meeting.SelectedIndexChanged += new System.EventHandler(this.CBox_Meeting_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 33);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2022, 3, 3, 11, 30, 37, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblMeetAim
            // 
            this.lblMeetAim.AutoSize = true;
            this.lblMeetAim.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetAim.Location = new System.Drawing.Point(26, 244);
            this.lblMeetAim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeetAim.Name = "lblMeetAim";
            this.lblMeetAim.Size = new System.Drawing.Size(109, 23);
            this.lblMeetAim.TabIndex = 7;
            this.lblMeetAim.Text = "Meeting Aim";
            // 
            // lblMeetWith
            // 
            this.lblMeetWith.AutoSize = true;
            this.lblMeetWith.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetWith.Location = new System.Drawing.Point(24, 168);
            this.lblMeetWith.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeetWith.Name = "lblMeetWith";
            this.lblMeetWith.Size = new System.Drawing.Size(122, 23);
            this.lblMeetWith.TabIndex = 6;
            this.lblMeetWith.Text = "Meeting With:";
            this.lblMeetWith.Click += new System.EventHandler(this.lblMeetWith_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(24, 103);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(46, 23);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time";
            this.lblTime.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btn_Aim
            // 
            this.btn_Aim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Aim.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aim.Location = new System.Drawing.Point(21, 267);
            this.btn_Aim.Name = "btn_Aim";
            this.btn_Aim.Size = new System.Drawing.Size(161, 38);
            this.btn_Aim.TabIndex = 4;
            this.btn_Aim.Text = "Meeting Aim";
            this.btn_Aim.UseVisualStyleBackColor = false;
            this.btn_Aim.Click += new System.EventHandler(this.btn_Aim_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(24, 36);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 23);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.LB_VisitOnSite);
            this.groupBox2.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(467, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.groupBox2.Size = new System.Drawing.Size(411, 328);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visitor on-site";
            // 
            // LB_VisitOnSite
            // 
            this.LB_VisitOnSite.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LB_VisitOnSite.Font = new System.Drawing.Font("Tw Cen MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_VisitOnSite.FormattingEnabled = true;
            this.LB_VisitOnSite.ItemHeight = 20;
            this.LB_VisitOnSite.Location = new System.Drawing.Point(9, 31);
            this.LB_VisitOnSite.Name = "LB_VisitOnSite";
            this.LB_VisitOnSite.Size = new System.Drawing.Size(393, 284);
            this.LB_VisitOnSite.TabIndex = 0;
            this.LB_VisitOnSite.SelectedIndexChanged += new System.EventHandler(this.LB_VisitOnSite_SelectedIndexChanged);
            // 
            // NUD_Hour
            // 
            this.NUD_Hour.Location = new System.Drawing.Point(21, 127);
            this.NUD_Hour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.NUD_Hour.Name = "NUD_Hour";
            this.NUD_Hour.Size = new System.Drawing.Size(58, 33);
            this.NUD_Hour.TabIndex = 15;
            this.NUD_Hour.ValueChanged += new System.EventHandler(this.NUD_Hour_ValueChanged);
            // 
            // NUD_Min
            // 
            this.NUD_Min.Location = new System.Drawing.Point(101, 127);
            this.NUD_Min.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NUD_Min.Name = "NUD_Min";
            this.NUD_Min.Size = new System.Drawing.Size(58, 33);
            this.NUD_Min.TabIndex = 16;
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Btn_Remove.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Remove.ForeColor = System.Drawing.Color.White;
            this.Btn_Remove.Location = new System.Drawing.Point(678, 351);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(191, 39);
            this.Btn_Remove.TabIndex = 1;
            this.Btn_Remove.Text = "Remove Visitor";
            this.Btn_Remove.UseVisualStyleBackColor = false;
            this.Btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(890, 405);
            this.Controls.Add(this.Btn_Remove);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Box_Meeting);
            this.Controls.Add(this.Box_Visitor);
            this.Controls.Add(this.btn_Submit);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visitor Information";
            this.Box_Visitor.ResumeLayout(false);
            this.Box_Visitor.PerformLayout();
            this.Box_Meeting.ResumeLayout(false);
            this.Box_Meeting.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Min)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TB_VisitorName;
        private System.Windows.Forms.Label Visitor_Name;
        private System.Windows.Forms.TextBox TB_Surname;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.GroupBox Box_Visitor;
        private System.Windows.Forms.GroupBox Box_Meeting;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.TextBox TB_Mobile;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblMeetAim;
        private System.Windows.Forms.Label lblMeetWith;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox LB_VisitOnSite;
        private System.Windows.Forms.ComboBox CBox_Meeting;
        private System.Windows.Forms.Label Lbl_hhmm;
        public System.Windows.Forms.Button btn_Aim;
        private System.Windows.Forms.NumericUpDown NUD_Hour;
        private System.Windows.Forms.NumericUpDown NUD_Min;
        public System.Windows.Forms.Button Btn_Remove;
    }
}

