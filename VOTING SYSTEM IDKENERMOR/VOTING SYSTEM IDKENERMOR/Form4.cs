using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace VOTING_SYSTEM_IDKENERMOR
{
    public partial class Form4 : Form
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
        public Form4()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
    
    OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_users.accdb");
    OleDbCommand cmd = new OleDbCommand();
    OleDbDataAdapter da = new OleDbDataAdapter();
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

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tb_users WHERE LRN = @lrn AND PASSWORD = @pass";
            cmd = new OleDbCommand(login, con);
            cmd.Parameters.AddWithValue("@lrn", lrn.Text);
            cmd.Parameters.AddWithValue("@pass", pass.Text);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                Form5 f5 = new Form5();
                f5.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid LRN or Password, Please Try Again", "Sign In Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lrn.Text = "";
                pass.Text = "";
                lrn.Focus();
            }
            
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin open = new Admin();
            open.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pass.PasswordChar = '\0';
            }
            else
            {
                pass.PasswordChar = '*';
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
