using GymBussinessLogic;
using System;
using System.Windows.Forms;


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
            BUser user = UserManipulation.GetCurrentUser();
            txtCoachName.Text = user.user_name;
            txtCoachSurname.Text = user.user_surname;
            txtCoachEducation.Text = user.education;
            txtCoachNumber.Text = user.phone;
            txtCoachEmail.Text = user.email;

            txtCoachName.Enabled = false;
            txtCoachSurname.Enabled = false;
            txtCoachEducation.Enabled = false;
            txtCoachNumber.Enabled = false;
            txtCoachEmail.Enabled = false;
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            FrmEditCoachProfile frm  = new FrmEditCoachProfile();
            frm.ShowDialog();

            FillCoachData();
            
        }
    }
}
