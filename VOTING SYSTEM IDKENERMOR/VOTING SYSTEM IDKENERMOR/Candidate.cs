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
    public partial class Candidate : UserControl
    {
        public Candidate()
        {
            InitializeComponent();
        }

        private string name;
        private string partylist;
        private Image _icon;

        
       /* [Category("Custom Props")]
        public Image _icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }

        } */

        [Category("Custom Props")]
        public string Names
        {
            get { return name; } 
            set { name = value; lbl1name.Text = value; }
        }

        [Category("Custom Props")]
        public string Partylist
        {
            get { return partylist; } 
            set { partylist = value; lbl2partylist.Text = value; }
        }

        private void uc_MouseEnters(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 219, 242);
        }

        private void uc_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
        }
      
        private void Candidate_Load(object sender, EventArgs e)
        {

        }
    }
}
