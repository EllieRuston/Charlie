using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjectCharlie
{
    public partial class MeetingAim : Form
    {
        string mAim;
        public MeetingAim()
        {
            InitializeComponent();
        }

        public void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void lblAim_Click(object sender, EventArgs e)
        {

        }

        public void Btn_Cancel_Click(object sender, EventArgs e)
        {
       
           this.Close();
        }

        public void Rbtn_Interview_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        public void Rbtn_Sales_CheckedChanged(object sender, EventArgs e)
        {
      
       
        }

        public void Btn_OK_Click(object sender, EventArgs e)
        {
            

            if (Rbtn_Interview.Checked)
            {
              Form1.Self.btn_Aim.Text = Rbtn_Interview.Text;
              
            }

            else if (Rbtn_Meeting.Checked)
            {
                Form1.Self.btn_Aim.Text = Rbtn_Meeting.Text;
            }

            else if (Rbtn_Sales.Checked)
            {
                Form1.Self.btn_Aim.Text = Rbtn_Sales.Text;
            }

            else if (Rbtn_Visit.Checked)
            {
                Form1.Self.btn_Aim.Text = Rbtn_Visit.Text;
            }
            
            this.Close();
        }

        public void Rbtn_Visit_CheckedChanged(object sender, EventArgs e)
        {
            mAim = "Site Visit";
         

        }

        public void Rbtn_Meeting_CheckedChanged(object sender, EventArgs e)
        {
            mAim = "Meeting";
           
        }
    }
}
