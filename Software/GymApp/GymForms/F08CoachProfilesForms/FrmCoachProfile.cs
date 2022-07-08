using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymBussinessLogic;

namespace GymForms.F08CoachProfilesForms
{
    public partial class FrmCoachProfile : Form
    {
        public FrmCoachProfile()
        {
            InitializeComponent();
        }

        private void FrmCoachProfile_Load(object sender, EventArgs e)
        {
            FillCoachData();
        }

        private void FillCoachData()
        {
           //txtCoachName.Text = UserManipulation.GetCurrentUser().
        }
    }
}
