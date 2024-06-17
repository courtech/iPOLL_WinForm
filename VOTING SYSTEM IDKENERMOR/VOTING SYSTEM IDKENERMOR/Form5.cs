using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VOTING_SYSTEM_IDKENERMOR
{
    public partial class Form5 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );
        private void PopulateCandidates()
        {
            // Connect to the database using the dbc class
            dbc.Connect();

            // Define the query to retrieve candidates from the Candidates table
            string query = "SELECT * FROM Candidates";

            // Create a new OleDbDataAdapter object using the query and connection from the dbc class
            dbc.bridge = new OleDbDataAdapter(query, dbc.con);

            // Create a new DataSet object to hold the retrieved data
            dbc.ds = new DataSet();

            // Open the connection to the database and fill the DataSet with the retrieved data
            dbc.con.Open();
            dbc.bridge.Fill(dbc.ds, "Candidates");
            dbc.con.Close();

            // Loop through the rows in the DataSet and create a new CandidateControl for each candidate
            foreach (DataRow row in dbc.ds.Tables["Candidates"].Rows)
            {
                int candidateID = Convert.ToInt32(row["candidateID"]);
                string position = row["Position"].ToString();
                string name = row["Name"].ToString();
                string partyList = row["PartyList"].ToString();

                CandidateControl candidateControl = new CandidateControl(position, name, partyList);
                flowLayoutPanel1.Controls.Add(candidateControl);
            }
        }


        public Form5()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //dbconnect.Connect();
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private const int CS_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location= new Point(b.Location.X + 137, b.Location.Y-32);
             imgSlide.SendToBack();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void presBox1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Form6 casted = new Form6();
            casted.Show();
            this.Hide();
        }

        private void officer1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /*   private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
           {

           }

            private void GenerateDynamicControl()
              {
                 flowLayoutPanel1.Controls.Clear();

                  Candidate[] listItems = new Candidate[5];

                  string[] name = new string[5] { "Josh Kakicks", "Angel Siaboc", "Jems Ken", "Jule Keyhano", "Aywa Hans" };
                  string[] partylist = new string[5] { "Hello Partylist", "Hi Partylist", "Hello Partylist", "Hi Partylist", "Hello Partylist" };

                  for (int i = 0; i < listItems.Length; i++)
                  {
                      listItems[i] = new Candidate();

                      listItems[i].Names = name[i];
                      listItems[i].Partylist = partylist[i];

                      flowLayoutPanel1.Controls.Add(listItems[i]);
                      listItems[i].Click += new System.EventHandler(this.UserControl_Click);
                  }
              }

              void UserControl_Click(object sender, EventArgs e)
              {
                  Candidate obj = (Candidate)sender;   
                  lbl1name.Text = obj.Names;
                  lbl2partylist.Text = obj.Partylist;
                  showpanel();

              }.
             

              private void showpanel()
              {
                  panel1.Visible = true;
              }
              private void hidepanel()
              {
                  panel1.Visible = false;
              }

              private void button2_Click(object sender, EventArgs e)
              {
                  hidepanel();
              }

              private void button2_Click_1(object sender, EventArgs e)
              {

              } */

        private void Form5_Load_1(object sender, EventArgs e)
        {
            //dbc.Connect();
            PopulateCandidates();
        }
    }
}
