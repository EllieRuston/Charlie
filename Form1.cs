using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;//connect to database

namespace ProjectCharlie
{
    public partial class Form1 : Form
    {
        public static Form1 Self;

        //coonection link from database
        string connString = @"Data Source = DOOR-STOP\SQLEXPRESS;
        Initial Catalog = VisitorInfo; 
        Integrated Security = True; 
        Connect Timeout = 30; 
        Encrypt=False;
        TrustServerCertificate=False;
        ApplicationIntent=ReadWrite;
        MultiSubnetFailover=False";

        int Vis_ID = 0;
        public Form1()
        {
            InitializeComponent();

            Self = this;
            DateTimePicker.Value = DateTime.Today;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ListBox_Data_Load();  //Call function to load data in ListBox from Visitor table
            Staff_Data_Load();  // Calling function to load data in comboBox from Staff Table
        }
        public void ListBox_Data_Load()
        {
            Clear();
            // Instance of Sql connection
            SqlConnection conn = new SqlConnection(connString);

            // Set the sql command
            string sql_Query = "SELECT  Visitor.Visitor_ID, Visitor.FirstName,  Visitor.Surname, Visitor.Mobile, Visitor.Email, Visitor.Meeting_Date, Visitor.Meeting_Time_H, Visitor.Meeting_Time_M, Staff.Meeting_With, Visitor.Staff_ID, Visitor.Meeting_Aim FROM Visitor, Staff WHERE Visitor.Staff_ID = Staff.Staff_ID ";

            // set instance of sqlComand and set the connection and the query to instance of SqlCommand
            SqlCommand cmd = new SqlCommand(sql_Query, conn);

            // open connetion
            conn.Open();

            // Creating instance of SqlDataReader
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            { // populate data in Listbox from Reader
                LB_VisitOnSite.Items.Add(reader["Visitor_ID"]+ " - "+reader["FirstName"] + "  " + reader["Surname"] + " - " + reader["Mobile"] + " - " + reader["Email"] + " - " + reader["Meeting_Date"] + " - " + reader["Meeting_Time_H"] + " : " + reader["Meeting_Time_M"] + " - " + reader["Meeting_With"] + " - " + reader["Staff_ID"] + " - " + reader["Meeting_Aim"]);
            }
            // close database reader
            reader.Close();

            //close connection
            conn.Close();
        }
        public void Staff_Data_Load()
        {
            // Instance of Sql connection
            SqlConnection conn = new SqlConnection(connString);

            // Set the sql command
            string sql_Query2 = "SELECT Staff_ID, Meeting_With FROM Staff";

            // set instance of sqlComand and set the connection and the query to instance of SqlCommand
            SqlCommand cmd2 = new SqlCommand(sql_Query2, conn);

            // open connetion
            conn.Open();

            // Creating instance of SqlDataReader
            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                // populate data in Listbox from Reader
                CBox_Meeting.Items.Add(reader["Meeting_With"]);
            }
            // close database reader
            reader.Close();
            //close connection
            conn.Close();
        }
        private void Staff_ID_Function(object sender, EventArgs e)
        {
            // instance of SqlConnection
            SqlConnection conn = new SqlConnection(connString);

            //set the sql command (statement)
            string Staff_ID_Fuction = "SELECT Staff_ID FROM Staff WHERE  Meeting_With ='" + CBox_Meeting.SelectedItem.ToString() + "'";

            //Create Instance and set connection and query to instance
            SqlCommand cmd3 = new SqlCommand(Staff_ID_Fuction, conn);

            //Open connectino
            conn.Open();

            // instance of SqlDataReader
            SqlDataReader reader = cmd3.ExecuteReader();
            while (reader.Read())
            {
                // populate data in TB from Reader
                TB_Staff_ID.Text = reader["Staff_ID"].ToString();
            }

            //Close connection
            conn.Close();
        }

        // open meeting aim form
        private void Btn_Aim_Click(object sender, EventArgs e)
        {
            MeetingAim Aim = new MeetingAim();
            Aim.Show();
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {// Mandatory fields
            int num;
            string email = TB_Email.Text;
            Regex regex = new Regex(@"^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-za-za-z]{2,3})+$");
            Match match = regex.Match(email);
            if (TB_VisitorName.Text == "" || TB_Surname.Text == "")
            {
                TB_VisitorName.Focus();
                MessageBox.Show("Name is Mandatory");
            }
            //Mobile
            else if (TB_Mobile.Text == "")
            {
                TB_Mobile.Focus();
                MessageBox.Show("Mobile Number is Mandatory");
            }
            else if (int.TryParse(TB_Mobile.Text, out num) == false)
            {
                MessageBox.Show("Pelase use digits for your phone number");
            }
            // Email
            else if (TB_Email.Text == "")
            {
                TB_Email.Focus();
                MessageBox.Show("Email is Mandatory");
            }
            // format check
            else if (match.Success == false)
            {
                MessageBox.Show("Please correct email format");
            }
            //Date default set to 'today' above
            //Time
            else if (NUD_Hour.Text == "0")
            {
                NUD_Hour.Focus();
                MessageBox.Show("Time is Mandatory");
            }
            // Meeting with...
            else if (CBox_Meeting.Text == "")
            {
                CBox_Meeting.Focus();
                MessageBox.Show("Choose a person from list");
            }
            // purpose of appointment
            else if (Btn_Aim.Text == "Meeting Aim")
            {
                Btn_Aim.Focus();
                MessageBox.Show("Please select purpose of meeting");
            }

            else
            {
                LB_VisitOnSite.Items.Add("Meeting of: " + TB_VisitorName.Text + " " + TB_Surname.Text);
                LB_VisitOnSite.Items.Add("Meeting at: " + NUD_Hour.Text + ":" + NUD_Min.Text);
                LB_VisitOnSite.Items.Add("Meeting With: " + CBox_Meeting.Text);
                LB_VisitOnSite.Items.Add("Meeting Aim: " + Btn_Aim.Text);
                LB_VisitOnSite.Items.Add("-----------------------------------");

                // clear form after submit = success
                Clear();
            }
        }

        public void Clear()
        {
            TB_VisitorName.Clear();
            TB_Surname.Clear();
            TB_Mobile.Clear();
            TB_Email.Clear();
            DateTimePicker.Value = DateTime.Today;
            CBox_Meeting.SelectedIndex = -1;
            NUD_Hour.Value = 0;
            NUD_Min.Value = 0;
            Btn_Aim.Text = "Meeting Aim";
        }

        //Using Delete Button - removed
        /*
        public void Btn_Remove_Click(object sender, EventArgs e)
        {
            var selectedItems = new object[LB_VisitOnSite.SelectedItems.Count];
            LB_VisitOnSite.SelectedItems.CopyTo(selectedItems, 0);

            foreach (var item in selectedItems)
                 {
                         LB_VisitOnSite.Items.Remove(item);
                  }
            }*/



        //Backspace to delete user
        public void LB_VisitOnSite_KeyPress(object sender, KeyPressEventArgs e)
        {
            var selectedItems = new object[LB_VisitOnSite.SelectedItems.Count];
            LB_VisitOnSite.SelectedItems.CopyTo(selectedItems, 0);

            if (e.KeyChar == (char)Keys.Back)
            {
                foreach (var item in selectedItems)
                {
                    LB_VisitOnSite.Items.Remove(item);
                }

            }
        }
        // remove using delete key
        private void LB_VisitorOnSite_KeyUp(object sender, KeyEventArgs e)
        {
            var selectedItems = new object[LB_VisitOnSite.SelectedItems.Count];
            LB_VisitOnSite.SelectedItems.CopyTo(selectedItems, 0);
            if (e.KeyCode == Keys.Delete)
            {
                foreach (var item in selectedItems)
                {
                    LB_VisitOnSite.Items.Remove(item);
                }
            }
        }

        private void LB_VisitOnSite_MouseClick(object sender, MouseEventArgs e)
        {
            var selectedValue = LB_VisitOnSite.SelectedItem;
            if (selectedValue != null)
            {
                MessageBox.Show(selectedValue.ToString());
            }
            string VisitorData = LB_VisitOnSite.SelectedItem.ToString();
            string[] Field_Data = VisitorData.Split('-');
            Vis_ID = Int16.Parse(Field_Data[0]);

            // Creating instance of SqlConnection 
            SqlConnection conn = new SqlConnection(connString);

            // set the sql command ( Statement ) 
            string sql_Query = "SELECT Visitor.Visitor_ID, Visitor.Name, Visitor.Surname, Visitor.Mobile, Visitor.Email, Visitor.Meeting_Date, Visitor.Meeting_Time_H, Visitor.Meeting_Time_M, Visitor.Meeting_Aim, Visitor.Staff_ID FROM Visitor, Staff WHERE Visitor.Staff_ID = Staff.Staff_ID AND Visitor_ID =" + Vis_ID;

            // Creating instance of SqlCommand  and set the connection and query to instance of SqlCommand
            SqlCommand cmd = new SqlCommand(sql_Query, conn);

            //Open connection
            conn.Open();

            // Creating instance of SqlDataReader 
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //populate data in TextBox from Reader
                TB_VisitorName.Text = reader["Name"].ToString();
                TB_Surname.Text = reader["Surname"].ToString();
                TB_Mobile.Text = reader["Mobile"].ToString();
                TB_Email.Text = reader["Email"].ToString();
                DateTimePicker.Text = reader["Meeting_Date"].ToString();
                NUD_Hour.Text = reader["Meeting_Time_H"].ToString();
                NUD_Min.Text = reader["Meeting_Time_M"].ToString();
                CBox_Meeting.Text = reader["Meeting_With"].ToString();
                Btn_Aim.Text = reader["Meeting_Aim"].ToString();
            }

            //Close Database reader
            reader.Close();

            //Close connection
            conn.Close();

        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            // Creating instance of SqlConnection
            SqlConnection conn = new SqlConnection(connString);
            // set the sql command (statement)
            string sql_Query3 = "INSERT INTO Visitor (Name, Surname, Mobile, Email, Meeting_Date, Meeting_Time_H, Meeting_Time_M, Staff_ID) VALUES (' " + TB_VisitorName.Text + " ',' " + TB_Surname.Text + " ', ' " + TB_Mobile.Text + " ',' " + TB_Email.Text + " ',' " + DateTimePicker.MinDate + " ',' " + NUD_Hour.Text + " ',' " + NUD_Min.Text + " ',' " + CBox_Meeting.Text + " ',' " + TB_Staff_ID.Text + " ', " + Btn_Aim.Text + ")";
            //Creating instance of SqlCommand and set the connect and query
            SqlCommand cmd4 = new SqlCommand(sql_Query3, conn);

            //open
            conn.Open();
            cmd4.ExecuteNonQuery();

            MessageBox.Show("Record Saved"); // confirmation message

            //close
            conn.Close();

            ListBox_Data_Load(); // call function to update display

        }
    }
}
