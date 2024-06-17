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
    public partial class Form2 : Form
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
        private OleDbConnection connnection = new OleDbConnection();

        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                label1.Text = "Connection Succesful";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +ex);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LRN_Click(object sender, EventArgs e)
        {

        }
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source = db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
   
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            try
            {
                Form4 nextForm = new Form4();
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "" && textBox7.Text == "" && textBox8.Text == "")
                {
                    MessageBox.Show("Fields are Empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (textBox6.Text == textBox5.Text)
                {
                    string register = "INSERT INTO tb_users (LRN,[Password]) VALUES ('" + Convert.ToInt32(textBox1.Text) + "', '" + textBox6.Text + "')";
                    con.Open();
                    cmd = new OleDbCommand(register, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    cmd = new OleDbCommand("insert into students ([LRN], [YearLevel], [LastName], [FirstName], [MiddleName], [Password]) values(@lrn,@year,@ln,@fn,@mn,@pass);", con);
                    cmd.Parameters.AddWithValue("@lrn", Convert.ToInt32(textBox1.Text));
                    cmd.Parameters.AddWithValue("@year", textBox2.Text);
                    cmd.Parameters.AddWithValue("@ln", textBox4.Text);
                    cmd.Parameters.AddWithValue("@fn", textBox8.Text);
                    cmd.Parameters.AddWithValue("@mn", textBox7.Text);
                    cmd.Parameters.AddWithValue("@pass", textBox6.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data Saved");
                    con.Dispose();
                    textBox1.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";

                    MessageBox.Show("Your Account has been succesfully Created", "Registration Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Password does not match", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox6.Text = "";
                    textBox5.Text = "";
                    textBox6.Focus();
                }
                // Show the next form and hide the current form
                nextForm.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Account Already Exist");
            }

            /*try
            {
                cmd = new OleDbCommand("insert into students ([LRN], [YearLevel], [LastName], [FirstName], [MiddleName], [Password]) values(@lrn,@year,@ln,@fn,@mn,@pass);",con);
                cmd.Parameters.AddWithValue("@lrn", Convert.ToInt32(textBox1.Text));
                cmd.Parameters.AddWithValue("@year", textBox2.Text);
                cmd.Parameters.AddWithValue("@ln", textBox4.Text);
                cmd.Parameters.AddWithValue("@fn", textBox8.Text);
                cmd.Parameters.AddWithValue("@mn", textBox7.Text);
                cmd.Parameters.AddWithValue("@pass", textBox6.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Saved");
                con.Dispose();
            }
            catch (Exception E)
            {
                MessageBox.Show("LRN unavailable" + E);
            } */
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox6.PasswordChar = '\0';
                textBox5.PasswordChar = '\0';
            }
            else
            {
                textBox6.PasswordChar = '*';
                textBox5.PasswordChar = '*';
            }
        }
    }
}
