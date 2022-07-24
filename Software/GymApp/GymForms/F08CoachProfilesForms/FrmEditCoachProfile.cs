using GymBussinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymForms.F08CoachProfilesForms
{
    public partial class FrmEditCoachProfile : Form
    {
        BUser user;
        public FrmEditCoachProfile()
        {
            user = MiddleMan.GetCurrentUser();
            InitializeComponent();
            
        }
        
        private void FrmEditCoachProfile_Load(object sender, EventArgs e)
        {
            EditFillCoachData();
        }

        private void EditFillCoachData()
        {
            txtEditCoachName.Text = user.user_name;
            txtEditCoachSurname.Text = user.user_surname;
            txtEditCoachEducation.Text = user.education;
            txtEditCOachNumber.Text = user.phone;
            txtEditCoachEmail.Text = user.email;
            if (user.profile_pic != null && user.profile_pic.Length > 0)
                pictureBoxProfilePic.Load(user.profile_pic);
            richTextBoxDescription.Text = user.description;
            textBoxLinkProfilePic.Text = user.profile_pic;
        }

        private void btnCancleChanges_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            MiddleMan userManipulation = new MiddleMan();

            MiddleMan.CurrentBUser.user_name = txtEditCoachName.Text;
            MiddleMan.CurrentBUser.user_surname = txtEditCoachSurname.Text;
            MiddleMan.CurrentBUser.education = txtEditCoachEducation.Text;
            MiddleMan.CurrentBUser.phone = txtEditCOachNumber.Text;
            MiddleMan.CurrentBUser.email = txtEditCoachEmail.Text;
            MiddleMan.CurrentBUser.profile_pic = textBoxLinkProfilePic.Text;
            MiddleMan.CurrentBUser.description = richTextBoxDescription.Text;

            userManipulation.SaveEditedData();
            Close();
        
        }

        private void textBoxLinkProfilePic_TextChanged(object sender, EventArgs e)
        {
            pictureBoxProfilePic.Load(textBoxLinkProfilePic.Text);
           
            pictureBoxProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
