using GymBussinessLogic;
using GymForms.F01LoginRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymForms.F01Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            MiddleMan middleMan = new MiddleMan();
            bool res = middleMan.Login(username, password);
            if (res)
            {
                if (MiddleMan.CurrentBUser.role_id == 3)
                {
                    new FrmUserHome().ShowDialog();
                }else if(MiddleMan.CurrentBUser.role_id == 2)
                {
                    new FrmCoachHome().ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }

        private void buttonForgottenPasswrod_Click(object sender, EventArgs e)
        {
            new FrmPasswordReset().ShowDialog();
        }
    }
}
