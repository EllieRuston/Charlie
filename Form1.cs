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
            // format DateTimePicker
            DateTimePicker1.Format = DateTimePickerFormat.Custom;
            DateTimePicker1.CustomFormat = "dd/MM/yyyy";
            DateTimePicker1.Value = DateTime.Today;
            }
        private void Form1_Load(object sender, EventArgs e)
            {
                ListBox_Data_Load();  //Call function to load data in ListBox from Visitor table
                Staff_Data_Load();  // Calling function to load data in comboBox from Staff Table
            }
        public void Clear()
            {
                TB_Vis_ID.Clear();
                TB_Staff_ID.Clear();
                TB_VisitorName.Clear();
                TB_Surname.Clear();
                TB_Mobile.Clear();
                TB_Email.Clear();
                DateTimePicker1.Value = DateTime.Today;
                CBox_Meeting.SelectedIndex = 0;
                NUD_Hour.Value = 0;
                NUD_Min.Value = 0;
                Btn_Aim.Text = "Meeting Aim";
                LB_VisitOnSite.Items.Clear();
                
        }
        public void ListBox_Data_Load()
            {
                 Clear();// clear feilds and listbox
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
                        { 
                            // populate data in Listbox from Reader
                            LB_VisitOnSite.Items.Add((reader["Visitor_ID"]+ " - "+reader["FirstName"] + " - " + reader["Surname"] + " - " + reader["Mobile"] + " - " + reader["Email"] + " - " + reader["Meeting_Date"] + " - " + reader["Meeting_Time_H"] + " - " + reader["Meeting_Time_M"] + " - " + reader["Meeting_With"] + " - " + reader["Staff_ID"] + " - " + reader["Meeting_Aim"]));
                        }
                // close database reader
                reader.Close();
                 //close connection
                conn.Close();
             }
       
        public void Staff_Data_Load() // add options to Meeting_with ComboBox
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
       
        private void Btn_Save_Click(object sender, EventArgs e) //ADD method = save/update button
            {
            int num;
            string email = TB_Email.Text;
            Regex regex = new Regex(@"^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-za-za-z]{2,3})+$");
            Match match = regex.Match(email);
            if (TB_VisitorName.Text == "" || TB_Surname.Text == "")
            {
                TB_VisitorName.Focus();
                MessageBox.Show("Name is Mandatory");
            }
           
            else if (TB_Mobile.Text == "")  //Mobile
            {
                TB_Mobile.Focus();
                MessageBox.Show("Mobile Number is Mandatory");
            }
            else if (int.TryParse(TB_Mobile.Text, out num) == false) //Mobile
            {
                MessageBox.Show("Pelase use digits for your phone number");
            }  
            else if (TB_Email.Text == "") // Email
            {
                TB_Email.Focus();
                MessageBox.Show("Email is Mandatory");
            }
            else if (match.Success == false)  // format check
            {
                MessageBox.Show("Please correct email format");
            }
            //Date default set to 'today' above
            else if (NUD_Hour.Text == "0")  //Time
            {
                NUD_Hour.Focus();
                MessageBox.Show("Time is Mandatory");
            }
            else if (CBox_Meeting.Text == "") // Meeting with...
            {
                CBox_Meeting.Focus();
                MessageBox.Show("Choose a person from list");
            }
            else if (Btn_Aim.Text == "Meeting Aim") // purpose of appointment
            {
                Btn_Aim.Focus();
                MessageBox.Show("Please select purpose of meeting");
            }
            else
            {
                // Creating instance of SqlConnection
                SqlConnection conn = new SqlConnection(connString);

                // set the sql command (statement)
                string sql_Query3 = "INSERT INTO Visitor(FirstName, Surname, Mobile, Email, Meeting_Date, Meeting_Time_H, Meeting_Time_M, Staff_ID, Meeting_Aim) VALUES ('" + TB_VisitorName.Text + "','" + TB_Surname.Text + "','" + TB_Mobile.Text + "','" + TB_Email.Text + "','" + DateTimePicker1.Value.ToString("yyyy/MM/dd") + "'," + NUD_Hour.Text + "," + NUD_Min.Text + "," + TB_Staff_ID.Text + ",'" + Btn_Aim.Text + "')";
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
        private void Staff_ID_Function(object sender, EventArgs e)
            {
                // instance of SqlConnection
                SqlConnection conn = new SqlConnection(connString);

                //set the sql command (statement)
                string Staff_ID_Function = "SELECT Staff_ID FROM Staff WHERE  Meeting_With ='" + CBox_Meeting.SelectedItem.ToString() + "'";

                //Create Instance and set connection and query to instance
                SqlCommand cmd3 = new SqlCommand(Staff_ID_Function, conn);

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
        private void LB_VisitOnSite_MouseClick(object sender, MouseEventArgs e)
            {
                var selectedValue = LB_VisitOnSite.SelectedItem;
            /* if (selectedValue != null)
             {
                 MessageBox.Show(selectedValue.ToString());
             }*/
            
            
           
             
                string VisitorData = LB_VisitOnSite.SelectedItem.ToString();
                string[] Field_Data = VisitorData.Split('-');
                Vis_ID = Int16.Parse(Field_Data[0]);
           
           

                // Creating instance of SqlConnection 
                SqlConnection conn = new SqlConnection(connString);

                 // set the sql command ( Statement ) 
                string sql_Query = "SELECT Visitor.Visitor_ID, Visitor.FirstName, Visitor.Surname, Visitor.Mobile, Visitor.Email, Visitor.Meeting_Date, Visitor.Meeting_Time_H, Visitor.Meeting_Time_M, Visitor.Meeting_Aim, Visitor.Staff_ID, Staff.Meeting_With FROM Visitor, Staff WHERE Visitor.Staff_ID = Staff.Staff_ID AND Visitor_ID =" + Vis_ID;

                // Creating instance of SqlCommand  and set the connection and query to instance of SqlCommand
                SqlCommand cmd = new SqlCommand(sql_Query, conn);

                //Open connection
                conn.Open();
                
                 // Creating instance of SqlDataReader 
                SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                        { 
                            //populate data in Feilds from Reader
                            TB_Vis_ID.Text = reader["Visitor_ID"].ToString();
                            TB_VisitorName.Text = reader["FirstName"].ToString();
                            TB_Surname.Text = reader["Surname"].ToString();
                            TB_Mobile.Text = reader["Mobile"].ToString();
                            TB_Email.Text = reader["Email"].ToString();
                            DateTimePicker1.Text = reader["Meeting_Date"].ToString();
                            NUD_Hour.Text = reader["Meeting_Time_H"].ToString();
                            NUD_Min.Text = reader["Meeting_Time_M"].ToString();
                            CBox_Meeting.Text = reader["Meeting_With"].ToString();
                            TB_Staff_ID.Text = reader["Staff_ID"].ToString();
                            Btn_Aim.Text = reader["Meeting_Aim"].ToString();
                        }
            
            //Close Database reader
            reader.Close();

                //Close connection
                conn.Close();

            }
       
       
       private void Btn_Edit_Click(object sender, EventArgs e) //Update method = Edit button
        {
             // Instance of SqlConnection
                SqlConnection conn = new SqlConnection (connString);
            // set sql command (statement)
            string sql_Qery4 = "UPDATE Visitor SET FirstName = '" + TB_VisitorName.Text + "', Surname ='" + TB_Surname.Text + "', Mobile ='" + TB_Mobile.Text + "', Email = '" + TB_Email.Text + "', Meeting_Date ='" + DateTimePicker1.Value.ToString("yyyy/MM/dd") + "', Meeting_Time_H =" + NUD_Hour.Text + ", Meeting_Time_M = " + NUD_Min.Text + ", Meeting_Aim ='" + Btn_Aim.Text + "', Staff_ID=" + TB_Staff_ID.Text + " WHERE Visitor_ID = " + TB_Vis_ID.Text;
            MessageBox.Show(sql_Qery4);
            //create instance of SqlCommand and set connection
            SqlCommand cmd5 =  new SqlCommand (sql_Qery4, conn);
       
            conn.Open ();      // open connection
            cmd5.ExecuteNonQuery ();
            MessageBox.Show("Record Updated");
            
            conn.Close(); // Close Connection

            ListBox_Data_Load(); // call function ro refresh listbox record 
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            // Createing instance of SqlConnection
            SqlConnection conn = new SqlConnection(connString);
            // set the sql command (statement)
            string sql_Qery = "DELETE FROM Visitor WHERE Visitor_ID = " + TB_Vis_ID.Text;
            // creating instance of SqlCommandand set the connection and query to instance of SqlCommand
            SqlCommand cmd5 = new SqlCommand (sql_Qery, conn);
            // Open connection
            conn.Open();
            cmd5.ExecuteNonQuery ();

            MessageBox.Show("Record Deleted"); // confirmation of record removal
            // Close connectino
            conn.Close ();
            ListBox_Data_Load (); // refresh listbox records to show updated records
        }
        private void Btn_Aim_Click(object sender, EventArgs e)  // open meeting aim form
            {
                MeetingAim Aim = new MeetingAim();
                Aim.Show();
            }
       private void Btn_Submit_Click(object sender, EventArgs e)
            {/*
             // Mandatory fields
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
                }*/
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
    }
}
