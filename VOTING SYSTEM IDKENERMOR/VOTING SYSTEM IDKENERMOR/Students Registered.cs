using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace VOTING_SYSTEM_IDKENERMOR
{
    public partial class Students_Registered : Form
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
        public Students_Registered()
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

        private void Students_Registered_Load(object sender, EventArgs e)
        {
            dbc.Connect();
            string query = "SELECT Anime.animeid, Anime.title, Anime.type, Anime.status, Anime.premiere, Anime.genre, Anime.rating, Anime.episodes, Completed.score, Completed.review\r\nFROM Anime, Completed\r\nWHERE Anime.animeid = Completed.animeid AND Completed.username = @username;\r\n";
            OleDbCommand cmd = new OleDbCommand(query, dbc.con);
            dbc.bridge = new OleDbDataAdapter(cmd);
            dbc.ds = new DataSet();
            dbc.con.Open();
            dbc.bridge.Fill(dbc.ds, "Completed");
            dataGridView1.DataSource = dbc.ds.Tables["students"];
            dataGridView1.Columns["LRN"].Visible = false;
            dbc.con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }
    }
    
}
