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
            BUser user = MiddleMan.GetCurrentUser();
            txtCoachName.Text = user.user_name;
            txtCoachSurname.Text = user.user_surname;
            txtCoachEducation.Text = user.education;
            txtCoachNumber.Text = user.phone;
            txtCoachEmail.Text = user.email;
            if(user.profile_pic != null && user.profile_pic.Length > 0)
                pictureProfile.Load(user.profile_pic);
            pictureProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            richTextBoxDescription.Text = user.description;

            txtCoachName.Enabled = false;
            txtCoachSurname.Enabled = false;
            txtCoachEducation.Enabled = false;
            txtCoachNumber.Enabled = false;
            txtCoachEmail.Enabled = false;
            richTextBoxDescription.Enabled = false;
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            FrmEditCoachProfile frm  = new FrmEditCoachProfile();
            frm.ShowDialog();

            FillCoachData();
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
