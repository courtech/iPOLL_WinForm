using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Helpers.GraphicsHelper;
using System.Xml.Linq;

namespace VOTING_SYSTEM_IDKENERMOR
{
    public partial class CandidateControl : UserControl
    {
        public CandidateControl(string pp, string n, string pl)
        {
            InitializeComponent();
            name.Text = n;
            partylist.Text = pl;
            //picturebox
        }

        private void CandidateControl_Load(object sender, EventArgs e)
        {

        }
    }
}
