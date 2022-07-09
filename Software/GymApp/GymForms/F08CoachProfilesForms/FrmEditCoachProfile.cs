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
            user = UserManipulation.GetCurrentUser();
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
        }

        private void btnCancleChanges_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            UserManipulation userManipulation = new UserManipulation();

            UserManipulation.CurrentBUser.user_name = txtEditCoachName.Text;
            UserManipulation.CurrentBUser.user_surname = txtEditCoachSurname.Text;
            UserManipulation.CurrentBUser.education = txtEditCoachEducation.Text;
            UserManipulation.CurrentBUser.phone = txtEditCOachNumber.Text;
            UserManipulation.CurrentBUser.email = txtEditCoachEmail.Text;

            userManipulation.SaveEditedData();                    
        
        }
    }
}
