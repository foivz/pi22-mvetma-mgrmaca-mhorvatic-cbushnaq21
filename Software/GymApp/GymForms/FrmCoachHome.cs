using GymBussinessLogic;
using GymForms.F08CoachProfilesForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymForms
{
    public partial class FrmCoachHome : Form
    {
        public FrmCoachHome()
        {
            InitializeComponent();
        }

        private void buttonCoachProfile_Click(object sender, EventArgs e)
        {
            new FrmCoachProfile().ShowDialog();
        }

        private void btnCoachLogout_Click(object sender, EventArgs e)
        {
            new MiddleMan().Logout();
            Close();
        }
    }
}
