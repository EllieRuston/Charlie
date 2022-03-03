namespace ProjectCharlie
{
    partial class Xperiment
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Cbox_Streach = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_ShowPic = new System.Windows.Forms.Button();
            this.Btn_ClearPic = new System.Windows.Forms.Button();
            this.Btn_SetBG = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(654, 307);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Cbox_Streach, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(660, 348);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Cbox_Streach
            // 
            this.Cbox_Streach.AutoSize = true;
            this.Cbox_Streach.Location = new System.Drawing.Point(3, 316);
            this.Cbox_Streach.Name = "Cbox_Streach";
            this.Cbox_Streach.Size = new System.Drawing.Size(63, 17);
            this.Cbox_Streach.TabIndex = 1;
            this.Cbox_Streach.Text = "Streach";
            this.Cbox_Streach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cbox_Streach.UseVisualStyleBackColor = true;
            this.Cbox_Streach.CheckedChanged += new System.EventHandler(this.Cbox_Streach_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Btn_SetBG);
            this.flowLayoutPanel1.Controls.Add(this.Btn_ShowPic);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Close);
            this.flowLayoutPanel1.Controls.Add(this.Btn_ClearPic);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(102, 316);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(555, 29);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Btn_ShowPic
            // 
            this.Btn_ShowPic.AutoSize = true;
            this.Btn_ShowPic.Location = new System.Drawing.Point(309, 3);
            this.Btn_ShowPic.Name = "Btn_ShowPic";
            this.Btn_ShowPic.Size = new System.Drawing.Size(94, 23);
            this.Btn_ShowPic.TabIndex = 0;
            this.Btn_ShowPic.Text = "Show a picture";
            this.Btn_ShowPic.UseVisualStyleBackColor = true;
            this.Btn_ShowPic.Click += new System.EventHandler(this.Btn_ShowPic_Click);
            // 
            // Btn_ClearPic
            // 
            this.Btn_ClearPic.AutoSize = true;
            this.Btn_ClearPic.Location = new System.Drawing.Point(136, 3);
            this.Btn_ClearPic.Name = "Btn_ClearPic";
            this.Btn_ClearPic.Size = new System.Drawing.Size(96, 23);
            this.Btn_ClearPic.TabIndex = 1;
            this.Btn_ClearPic.Text = "Clear the picture";
            this.Btn_ClearPic.UseVisualStyleBackColor = true;
            this.Btn_ClearPic.Click += new System.EventHandler(this.Btn_ClearPic_Click);
            // 
            // Btn_SetBG
            // 
            this.Btn_SetBG.AutoSize = true;
            this.Btn_SetBG.Location = new System.Drawing.Point(409, 3);
            this.Btn_SetBG.Name = "Btn_SetBG";
            this.Btn_SetBG.Size = new System.Drawing.Size(143, 23);
            this.Btn_SetBG.TabIndex = 2;
            this.Btn_SetBG.Text = "Set the background colour";
            this.Btn_SetBG.UseVisualStyleBackColor = true;
            this.Btn_SetBG.Click += new System.EventHandler(this.Btn_SetBG_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.AutoSize = true;
            this.Btn_Close.Location = new System.Drawing.Point(238, 3);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(65, 23);
            this.Btn_Close.TabIndex = 3;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Selet a picture file";
            // 
            // Xperiment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 348);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Xperiment";
            this.Text = "Xperiment";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox Cbox_Streach;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Button Btn_ClearPic;
        private System.Windows.Forms.Button Btn_SetBG;
        private System.Windows.Forms.Button Btn_ShowPic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}