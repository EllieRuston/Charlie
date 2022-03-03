namespace ProjectCharlie
{
    partial class MeetingAim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeetingAim));
            this.Rbtn_Meeting = new System.Windows.Forms.RadioButton();
            this.Rbtn_Sales = new System.Windows.Forms.RadioButton();
            this.Rbtn_Interview = new System.Windows.Forms.RadioButton();
            this.lblAim = new System.Windows.Forms.Label();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Rbtn_Visit = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rbtn_Meeting
            // 
            this.Rbtn_Meeting.AutoSize = true;
            this.Rbtn_Meeting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Rbtn_Meeting.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_Meeting.Location = new System.Drawing.Point(252, 137);
            this.Rbtn_Meeting.Margin = new System.Windows.Forms.Padding(4);
            this.Rbtn_Meeting.Name = "Rbtn_Meeting";
            this.Rbtn_Meeting.Padding = new System.Windows.Forms.Padding(6, 4, 4, 4);
            this.Rbtn_Meeting.Size = new System.Drawing.Size(119, 39);
            this.Rbtn_Meeting.TabIndex = 4;
            this.Rbtn_Meeting.Text = "Meeting";
            this.Rbtn_Meeting.UseVisualStyleBackColor = false;
            this.Rbtn_Meeting.CheckedChanged += new System.EventHandler(this.Rbtn_Meeting_CheckedChanged);
            // 
            // Rbtn_Sales
            // 
            this.Rbtn_Sales.AutoSize = true;
            this.Rbtn_Sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Rbtn_Sales.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_Sales.Location = new System.Drawing.Point(252, 75);
            this.Rbtn_Sales.Margin = new System.Windows.Forms.Padding(4);
            this.Rbtn_Sales.Name = "Rbtn_Sales";
            this.Rbtn_Sales.Padding = new System.Windows.Forms.Padding(6, 4, 4, 4);
            this.Rbtn_Sales.Size = new System.Drawing.Size(215, 39);
            this.Rbtn_Sales.TabIndex = 3;
            this.Rbtn_Sales.Text = "Sales Appointment";
            this.Rbtn_Sales.UseVisualStyleBackColor = false;
            this.Rbtn_Sales.CheckedChanged += new System.EventHandler(this.Rbtn_Sales_CheckedChanged);
            // 
            // Rbtn_Interview
            // 
            this.Rbtn_Interview.AutoSize = true;
            this.Rbtn_Interview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Rbtn_Interview.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_Interview.Location = new System.Drawing.Point(25, 137);
            this.Rbtn_Interview.Margin = new System.Windows.Forms.Padding(4);
            this.Rbtn_Interview.Name = "Rbtn_Interview";
            this.Rbtn_Interview.Padding = new System.Windows.Forms.Padding(6, 4, 4, 4);
            this.Rbtn_Interview.Size = new System.Drawing.Size(201, 39);
            this.Rbtn_Interview.TabIndex = 2;
            this.Rbtn_Interview.Text = "Student Interview";
            this.Rbtn_Interview.UseVisualStyleBackColor = false;
            this.Rbtn_Interview.CheckedChanged += new System.EventHandler(this.Rbtn_Interview_CheckedChanged);
            // 
            // lblAim
            // 
            this.lblAim.AutoSize = true;
            this.lblAim.Font = new System.Drawing.Font("Tw Cen MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblAim.Location = new System.Drawing.Point(6, 12);
            this.lblAim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAim.Name = "lblAim";
            this.lblAim.Padding = new System.Windows.Forms.Padding(5, 5, 2, 5);
            this.lblAim.Size = new System.Drawing.Size(469, 43);
            this.lblAim.TabIndex = 4;
            this.lblAim.Text = "Please specify the nature of the meeting";
            this.lblAim.Click += new System.EventHandler(this.lblAim_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.AutoSize = true;
            this.Btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Btn_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Cancel.Location = new System.Drawing.Point(4, 4);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 44);
            this.Btn_Cancel.TabIndex = 9;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.AutoSize = true;
            this.Btn_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Btn_OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_OK.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_OK.Location = new System.Drawing.Point(87, 4);
            this.Btn_OK.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(76, 44);
            this.Btn_OK.TabIndex = 9;
            this.Btn_OK.Text = "OK";
            this.Btn_OK.UseVisualStyleBackColor = false;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.Btn_Cancel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_OK, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(314, 218);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(167, 52);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // Rbtn_Visit
            // 
            this.Rbtn_Visit.AutoSize = true;
            this.Rbtn_Visit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Rbtn_Visit.Checked = true;
            this.Rbtn_Visit.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_Visit.Location = new System.Drawing.Point(25, 75);
            this.Rbtn_Visit.Margin = new System.Windows.Forms.Padding(4);
            this.Rbtn_Visit.Name = "Rbtn_Visit";
            this.Rbtn_Visit.Padding = new System.Windows.Forms.Padding(6, 4, 4, 4);
            this.Rbtn_Visit.Size = new System.Drawing.Size(122, 39);
            this.Rbtn_Visit.TabIndex = 1;
            this.Rbtn_Visit.Tag = "";
            this.Rbtn_Visit.Text = "Site Visit";
            this.Rbtn_Visit.UseVisualStyleBackColor = false;
            this.Rbtn_Visit.CheckedChanged += new System.EventHandler(this.Rbtn_Visit_CheckedChanged);
            // 
            // MeetingAim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(493, 282);
            this.Controls.Add(this.Rbtn_Sales);
            this.Controls.Add(this.Rbtn_Interview);
            this.Controls.Add(this.Rbtn_Visit);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.Rbtn_Meeting);
            this.Controls.Add(this.lblAim);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MeetingAim";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Meeting Aim";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAim;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.RadioButton Rbtn_Interview;
        public System.Windows.Forms.RadioButton Rbtn_Meeting;
        public System.Windows.Forms.RadioButton Rbtn_Sales;
        public System.Windows.Forms.RadioButton Rbtn_Visit;
        public System.Windows.Forms.Button Btn_Cancel;
        public System.Windows.Forms.Button Btn_OK;
    }
}