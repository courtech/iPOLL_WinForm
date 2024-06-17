using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VOTING_SYSTEM_IDKENERMOR
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 28;
            if(panel2.Width >= panel1.Width)
            {
                timer1.Stop();
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();
            }
        }
    }
}
