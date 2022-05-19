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
            this.Lbl_Visitor_Name = new System.Windows.Forms.Label();
            this.TB_Surname = new System.Windows.Forms.TextBox();
            this.Box_Visitor = new System.Windows.Forms.GroupBox();
            this.TB_Vis_ID = new System.Windows.Forms.TextBox();
            this.lbl_VIsitor_ID = new System.Windows.Forms.Label();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.TB_Mobile = new System.Windows.Forms.TextBox();
            this.Lbl_Mobile = new System.Windows.Forms.Label();
            this.Lbl_Surname = new System.Windows.Forms.Label();
            this.Box_Meeting = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Staff_ID = new System.Windows.Forms.TextBox();
            this.NUD_Min = new System.Windows.Forms.NumericUpDown();
            this.NUD_Hour = new System.Windows.Forms.NumericUpDown();
            this.Lbl_hhmm = new System.Windows.Forms.Label();
            this.CBox_Meeting = new System.Windows.Forms.ComboBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Lbl_MeetAim = new System.Windows.Forms.Label();
            this.lblMeetWith = new System.Windows.Forms.Label();
            this.Lbl_Time = new System.Windows.Forms.Label();
            this.Btn_Aim = new System.Windows.Forms.Button();
            this.Lbl_Date = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LB_VisitOnSite = new System.Windows.Forms.ListBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Box_Visitor.SuspendLayout();
            this.Box_Meeting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Hour)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_VisitorName
            // 
            this.TB_VisitorName.AcceptsReturn = true;
            this.TB_VisitorName.Location = new System.Drawing.Point(7, 93);
            this.TB_VisitorName.Margin = new System.Windows.Forms.Padding(4);
            this.TB_VisitorName.Name = "TB_VisitorName";
            this.TB_VisitorName.Size = new System.Drawing.Size(180, 33);
            this.TB_VisitorName.TabIndex = 1;
            // 
            // Lbl_Visitor_Name
            // 
            this.Lbl_Visitor_Name.AutoSize = true;
            this.Lbl_Visitor_Name.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Visitor_Name.Location = new System.Drawing.Point(7, 69);
            this.Lbl_Visitor_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Visitor_Name.Name = "Lbl_Visitor_Name";
            this.Lbl_Visitor_Name.Size = new System.Drawing.Size(57, 23);
            this.Lbl_Visitor_Name.TabIndex = 2;
            this.Lbl_Visitor_Name.Text = "Name";
            // 
            // TB_Surname
            // 
            this.TB_Surname.Location = new System.Drawing.Point(7, 169);
            this.TB_Surname.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Surname.Multiline = true;
            this.TB_Surname.Name = "TB_Surname";
            this.TB_Surname.Size = new System.Drawing.Size(180, 33);
            this.TB_Surname.TabIndex = 3;
            // 
            // Box_Visitor
            // 
            this.Box_Visitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Box_Visitor.Controls.Add(this.lbl_VIsitor_ID);
            this.Box_Visitor.Controls.Add(this.TB_Vis_ID);
            this.Box_Visitor.Controls.Add(this.Lbl_Email);
            this.Box_Visitor.Controls.Add(this.TB_Email);
            this.Box_Visitor.Controls.Add(this.TB_Mobile);
            this.Box_Visitor.Controls.Add(this.Lbl_Mobile);
            this.Box_Visitor.Controls.Add(this.Lbl_Surname);
            this.Box_Visitor.Controls.Add(this.Lbl_Visitor_Name);
            this.Box_Visitor.Controls.Add(this.TB_VisitorName);
            this.Box_Visitor.Controls.Add(this.TB_Surname);
            this.Box_Visitor.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Visitor.Location = new System.Drawing.Point(12, 12);
            this.Box_Visitor.Name = "Box_Visitor";
            this.Box_Visitor.Size = new System.Drawing.Size(203, 363);
            this.Box_Visitor.TabIndex = 5;
            this.Box_Visitor.TabStop = false;
            this.Box_Visitor.Text = "Visitor Details";
            // 
            // TB_Vis_ID
            // 
            this.TB_Vis_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_Vis_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Vis_ID.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Vis_ID.Location = new System.Drawing.Point(88, 30);
            this.TB_Vis_ID.Name = "TB_Vis_ID";
            this.TB_Vis_ID.ReadOnly = true;
            this.TB_Vis_ID.Size = new System.Drawing.Size(82, 26);
            this.TB_Vis_ID.TabIndex = 19;
            // 
            // lbl_VIsitor_ID
            // 
            this.lbl_VIsitor_ID.AutoSize = true;
            this.lbl_VIsitor_ID.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VIsitor_ID.Location = new System.Drawing.Point(7, 32);
            this.lbl_VIsitor_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_VIsitor_ID.Name = "lbl_VIsitor_ID";
            this.lbl_VIsitor_ID.Size = new System.Drawing.Size(91, 23);
            this.lbl_VIsitor_ID.TabIndex = 9;
            this.lbl_VIsitor_ID.Text = "Visitor ID :";
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Email.Location = new System.Drawing.Point(7, 291);
            this.Lbl_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(51, 23);
            this.Lbl_Email.TabIndex = 8;
            this.Lbl_Email.Text = "Email";
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(7, 318);
            this.TB_Email.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Email.Multiline = true;
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(180, 33);
            this.TB_Email.TabIndex = 7;
            // 
            // TB_Mobile
            // 
            this.TB_Mobile.Location = new System.Drawing.Point(7, 242);
            this.TB_Mobile.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Mobile.Multiline = true;
            this.TB_Mobile.Name = "TB_Mobile";
            this.TB_Mobile.Size = new System.Drawing.Size(180, 33);
            this.TB_Mobile.TabIndex = 6;
            // 
            // Lbl_Mobile
            // 
            this.Lbl_Mobile.AutoSize = true;
            this.Lbl_Mobile.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mobile.Location = new System.Drawing.Point(7, 215);
            this.Lbl_Mobile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Mobile.Name = "Lbl_Mobile";
            this.Lbl_Mobile.Size = new System.Drawing.Size(64, 23);
            this.Lbl_Mobile.TabIndex = 5;
            this.Lbl_Mobile.Text = "Mobile";
            // 
            // Lbl_Surname
            // 
            this.Lbl_Surname.AutoSize = true;
            this.Lbl_Surname.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Surname.Location = new System.Drawing.Point(7, 142);
            this.Lbl_Surname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Surname.Name = "Lbl_Surname";
            this.Lbl_Surname.Size = new System.Drawing.Size(79, 23);
            this.Lbl_Surname.TabIndex = 4;
            this.Lbl_Surname.Text = "Surname";
            // 
            // Box_Meeting
            // 
            this.Box_Meeting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Box_Meeting.Controls.Add(this.label1);
            this.Box_Meeting.Controls.Add(this.TB_Staff_ID);
            this.Box_Meeting.Controls.Add(this.NUD_Min);
            this.Box_Meeting.Controls.Add(this.NUD_Hour);
            this.Box_Meeting.Controls.Add(this.Lbl_hhmm);
            this.Box_Meeting.Controls.Add(this.CBox_Meeting);
            this.Box_Meeting.Controls.Add(this.DateTimePicker);
            this.Box_Meeting.Controls.Add(this.Lbl_MeetAim);
            this.Box_Meeting.Controls.Add(this.lblMeetWith);
            this.Box_Meeting.Controls.Add(this.Lbl_Time);
            this.Box_Meeting.Controls.Add(this.Btn_Aim);
            this.Box_Meeting.Controls.Add(this.Lbl_Date);
            this.Box_Meeting.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Meeting.Location = new System.Drawing.Point(245, 12);
            this.Box_Meeting.Name = "Box_Meeting";
            this.Box_Meeting.Size = new System.Drawing.Size(249, 363);
            this.Box_Meeting.TabIndex = 6;
            this.Box_Meeting.TabStop = false;
            this.Box_Meeting.Text = "Meeting Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Staff ID :";
            // 
            // TB_Staff_ID
            // 
            this.TB_Staff_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_Staff_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Staff_ID.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Staff_ID.Location = new System.Drawing.Point(105, 242);
            this.TB_Staff_ID.Name = "TB_Staff_ID";
            this.TB_Staff_ID.ReadOnly = true;
            this.TB_Staff_ID.Size = new System.Drawing.Size(109, 26);
            this.TB_Staff_ID.TabIndex = 17;
            // 
            // NUD_Min
            // 
            this.NUD_Min.Location = new System.Drawing.Point(135, 127);
            this.NUD_Min.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NUD_Min.Name = "NUD_Min";
            this.NUD_Min.Size = new System.Drawing.Size(91, 33);
            this.NUD_Min.TabIndex = 16;
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
            this.NUD_Hour.Size = new System.Drawing.Size(88, 33);
            this.NUD_Hour.TabIndex = 15;
            // 
            // Lbl_hhmm
            // 
            this.Lbl_hhmm.AutoSize = true;
            this.Lbl_hhmm.Font = new System.Drawing.Font("Tw Cen MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_hhmm.Location = new System.Drawing.Point(109, 114);
            this.Lbl_hhmm.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_hhmm.Name = "Lbl_hhmm";
            this.Lbl_hhmm.Size = new System.Drawing.Size(29, 47);
            this.Lbl_hhmm.TabIndex = 14;
            this.Lbl_hhmm.Text = ":";
            // 
            // CBox_Meeting
            // 
            this.CBox_Meeting.FormattingEnabled = true;
            this.CBox_Meeting.Location = new System.Drawing.Point(21, 193);
            this.CBox_Meeting.Name = "CBox_Meeting";
            this.CBox_Meeting.Size = new System.Drawing.Size(205, 35);
            this.CBox_Meeting.TabIndex = 10;
            this.CBox_Meeting.SelectedValueChanged += new System.EventHandler(this.Staff_ID_Function);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.AllowDrop = true;
            this.DateTimePicker.CustomFormat = "";
            this.DateTimePicker.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker.Location = new System.Drawing.Point(21, 61);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(205, 33);
            this.DateTimePicker.TabIndex = 6;
            this.DateTimePicker.Value = new System.DateTime(2022, 3, 3, 11, 30, 37, 0);
            // 
            // Lbl_MeetAim
            // 
            this.Lbl_MeetAim.AutoSize = true;
            this.Lbl_MeetAim.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MeetAim.Location = new System.Drawing.Point(26, 287);
            this.Lbl_MeetAim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_MeetAim.Name = "Lbl_MeetAim";
            this.Lbl_MeetAim.Size = new System.Drawing.Size(109, 23);
            this.Lbl_MeetAim.TabIndex = 7;
            this.Lbl_MeetAim.Text = "Meeting Aim";
            // 
            // lblMeetWith
            // 
            this.lblMeetWith.AutoSize = true;
            this.lblMeetWith.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetWith.Location = new System.Drawing.Point(19, 169);
            this.lblMeetWith.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeetWith.Name = "lblMeetWith";
            this.lblMeetWith.Size = new System.Drawing.Size(122, 23);
            this.lblMeetWith.TabIndex = 6;
            this.lblMeetWith.Text = "Meeting With:";
            // 
            // Lbl_Time
            // 
            this.Lbl_Time.AutoSize = true;
            this.Lbl_Time.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Time.Location = new System.Drawing.Point(17, 103);
            this.Lbl_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Time.Name = "Lbl_Time";
            this.Lbl_Time.Size = new System.Drawing.Size(46, 23);
            this.Lbl_Time.TabIndex = 5;
            this.Lbl_Time.Text = "Time";
            // 
            // Btn_Aim
            // 
            this.Btn_Aim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Btn_Aim.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Aim.Location = new System.Drawing.Point(21, 316);
            this.Btn_Aim.Name = "Btn_Aim";
            this.Btn_Aim.Size = new System.Drawing.Size(205, 38);
            this.Btn_Aim.TabIndex = 4;
            this.Btn_Aim.Text = "Meeting Aim";
            this.Btn_Aim.UseVisualStyleBackColor = false;
            this.Btn_Aim.Click += new System.EventHandler(this.Btn_Aim_Click);
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.AutoSize = true;
            this.Lbl_Date.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Date.Location = new System.Drawing.Point(18, 36);
            this.Lbl_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(48, 23);
            this.Lbl_Date.TabIndex = 2;
            this.Lbl_Date.Text = "Date";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.LB_VisitOnSite);
            this.groupBox2.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(514, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.groupBox2.Size = new System.Drawing.Size(660, 363);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visitors on-site";
            // 
            // LB_VisitOnSite
            // 
            this.LB_VisitOnSite.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LB_VisitOnSite.Cursor = System.Windows.Forms.Cursors.Default;
            this.LB_VisitOnSite.Font = new System.Drawing.Font("Tw Cen MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_VisitOnSite.FormattingEnabled = true;
            this.LB_VisitOnSite.HorizontalScrollbar = true;
            this.LB_VisitOnSite.ItemHeight = 20;
            this.LB_VisitOnSite.Location = new System.Drawing.Point(9, 26);
            this.LB_VisitOnSite.Name = "LB_VisitOnSite";
            this.LB_VisitOnSite.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LB_VisitOnSite.Size = new System.Drawing.Size(642, 324);
            this.LB_VisitOnSite.TabIndex = 0;
            this.LB_VisitOnSite.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LB_VisitOnSite_MouseClick);
            this.LB_VisitOnSite.SelectedIndexChanged += new System.EventHandler(this.Form1_Load);
            this.LB_VisitOnSite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LB_VisitorOnSite_KeyUp);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.Olive;
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Location = new System.Drawing.Point(12, 381);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_Submit.Size = new System.Drawing.Size(482, 39);
            this.btn_Submit.TabIndex = 11;
            this.btn_Submit.Text = "Sign In";
            this.btn_Submit.UseVisualStyleBackColor = false;
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackColor = System.Drawing.Color.OrangeRed;
            this.Btn_Save.ForeColor = System.Drawing.Color.White;
            this.Btn_Save.Location = new System.Drawing.Point(654, 381);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Btn_Save.Size = new System.Drawing.Size(133, 39);
            this.Btn_Save.TabIndex = 12;
            this.Btn_Save.Text = "Save/Update";
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.BackColor = System.Drawing.Color.RoyalBlue;
            this.Btn_Edit.ForeColor = System.Drawing.Color.White;
            this.Btn_Edit.Location = new System.Drawing.Point(853, 381);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Btn_Edit.Size = new System.Drawing.Size(133, 39);
            this.Btn_Edit.TabIndex = 13;
            this.Btn_Edit.Text = "Edit";
            this.Btn_Edit.UseVisualStyleBackColor = false;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.Fuchsia;
            this.Btn_Delete.ForeColor = System.Drawing.Color.White;
            this.Btn_Delete.Location = new System.Drawing.Point(1041, 381);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Btn_Delete.Size = new System.Drawing.Size(133, 39);
            this.Btn_Delete.TabIndex = 14;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1201, 424);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Box_Meeting);
            this.Controls.Add(this.Box_Visitor);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visitor Registration ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LB_VisitorOnSite_KeyUp);
            this.Box_Visitor.ResumeLayout(false);
            this.Box_Visitor.PerformLayout();
            this.Box_Meeting.ResumeLayout(false);
            this.Box_Meeting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Hour)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TB_VisitorName;
        private System.Windows.Forms.Label Lbl_Visitor_Name;
        private System.Windows.Forms.TextBox TB_Surname;
        private System.Windows.Forms.GroupBox Box_Visitor;
        private System.Windows.Forms.GroupBox Box_Meeting;
        private System.Windows.Forms.Label Lbl_Date;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Lbl_Time;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.TextBox TB_Mobile;
        private System.Windows.Forms.Label Lbl_Mobile;
        private System.Windows.Forms.Label Lbl_Surname;
        private System.Windows.Forms.Label Lbl_MeetAim;
        private System.Windows.Forms.Label lblMeetWith;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.ComboBox CBox_Meeting;
        private System.Windows.Forms.Label Lbl_hhmm;
        public System.Windows.Forms.Button Btn_Aim;
        private System.Windows.Forms.NumericUpDown NUD_Hour;
        private System.Windows.Forms.NumericUpDown NUD_Min;
        public System.Windows.Forms.ListBox LB_VisitOnSite;
        private System.Windows.Forms.TextBox TB_Staff_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.TextBox TB_Vis_ID;
        private System.Windows.Forms.Label lbl_VIsitor_ID;
    }
}

