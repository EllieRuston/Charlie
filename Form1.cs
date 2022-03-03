using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ProjectCharlie
{
    public partial class Form1 : Form 

    {
        public static Form1 Self;
        //MeetingAim Aim = new MeetingAim();
        public Form1()
        {
            InitializeComponent();
            Self = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        // open meeting aim form
        private void btn_Aim_Click(object sender, EventArgs e)
        {
           MeetingAim Aim = new MeetingAim();
           Aim.Show();
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LB_VisitOnSite_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblMeetWith_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Time_Min_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CBox_Meeting_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {   int num;
            string email = TB_Email.Text;
            Regex regex = new Regex(@"^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-za-za-z]{2,3})+$");
            Match match = regex.Match(email);
            string meetingBtn = btn_Aim.Text;
            if (TB_VisitorName.Text == "" || TB_Surname.Text == "")
            {
                TB_VisitorName.Focus();
                MessageBox.Show("Name is Manditory");
            }

            //Mobile
            else if (TB_Mobile.Text == "")
            {
                TB_Mobile.Focus();
                MessageBox.Show("Mobile Number is Manditory");
            }
            else if (int.TryParse(TB_Mobile.Text, out num) == false)
            {
                MessageBox.Show("Pelase use digits for your phone number");
            }

            // Email
            else if (TB_Email.Text == "")
            {
                TB_Email.Focus();
                MessageBox.Show("Email is Manditory");
            }
            // format check
            else if (match.Success == false)
            {
                MessageBox.Show("Please correct email format");
            }

            //Date - not needed in listbox
            else if (dateTimePicker1 == null)
            {
                dateTimePicker1.Focus();
                MessageBox.Show("Please select Date");
            }

            //Time
            else if (NUD_Hour.Text == "" || NUD_Min.Text == "")
            {
                NUD_Min.Focus();
                MessageBox.Show("Time is Manditory");
            }

            // Meeting with...
            else if (CBox_Meeting.Text == "")
            {
                CBox_Meeting.Focus();
                MessageBox.Show("Choose a person from list");
            }

            // purpose of appointment
            else if (btn_Aim.Text =="Meeting Aim")
            {
                CBox_Meeting.Focus();
                MessageBox.Show("Please select purpose of meeting");
            }

            else
            {
                LB_VisitOnSite.Items.Add("Name: " + TB_VisitorName.Text + " " + TB_Surname.Text);
                LB_VisitOnSite.Items.Add("Meeting Time: " + NUD_Hour.Text + ":" + NUD_Min.Text);
                LB_VisitOnSite.Items.Add("Meeting with: " + CBox_Meeting.Text);
                LB_VisitOnSite.Items.Add("Purpose of visit: " + btn_Aim.Text);
                LB_VisitOnSite.Items.Add("________________________________");
            }
          
            // clear form after submit = success
           TB_VisitorName.Clear();
           TB_Surname.Clear();
           TB_Mobile.Clear();
           TB_Email.Clear();
            CBox_Meeting.SelectedIndex = -1;
            NUD_Hour.Value = 0;
            NUD_Min.Value = 0;
            btn_Aim.Text = "Meeting Aim";


         }
    private void TB_VisitorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void NUD_Min_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void NUD_Hour_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NUD_Hour_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            var selectedItems = new object[LB_VisitOnSite.SelectedItems.Count];
            LB_VisitOnSite.SelectedItems.CopyTo(selectedItems, 0);

            foreach (var item in selectedItems)
            {
            LB_VisitOnSite.Items.Remove(item);
            }
            
        }
    }
}
