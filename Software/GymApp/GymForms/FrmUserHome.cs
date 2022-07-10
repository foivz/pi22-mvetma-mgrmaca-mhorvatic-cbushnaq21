using GymBussinessLogic;
using GymForms.F02andF03Form;
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
    public partial class FrmUserHome : Form
    {
        public FrmUserHome()
        {
            InitializeComponent();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            new MiddleMan().Logout();
            Close();
        }

        private void buttonMembershipFee_Click(object sender, EventArgs e)
        {
            new FrmMembershipFee().ShowDialog();
        }
    }
}
