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

namespace GymForms.F01LoginRegister
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }


        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string email = textBoxEmail.Text;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string repeatPassword = textBoxRepeatPassword.Text;
            string phone = textBoxPhone.Text;

            if (password.Equals(repeatPassword))
            {
                BUser buser = new BUser();
                buser.phone = phone;
                buser.email = email;
                buser.username = username;
                buser.user_name = name;
                buser.user_surname = surname;
                buser.passwordium = password;
                buser.registration_date = DateTime.Now;

                bool res = new MiddleMan().Register(buser);
                if (res)
                {
                    MessageBox.Show("Registration success");
                }
                else
                {
                    MessageBox.Show("Registration failure");
                }
            }
            else
            {
                MessageBox.Show("Passwords are not equal!!!!!!");
            }
        }
    }
}
