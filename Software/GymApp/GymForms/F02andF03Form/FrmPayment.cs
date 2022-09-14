
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




namespace GymForms.F02andF03Form
{
    public partial class FrmPayment : Form
    {
        // Mislav Vetma --------------------------------------------------------------

        private MiddleMan userManipulation;
        private BBill selectedBill;
        private BCard card;
        public FrmPayment(BBill bill)
        {
            card = new BCard();
            userManipulation = new MiddleMan();
            selectedBill = bill;
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            txtName.Text = MiddleMan.CurrentBUser.user_name;
            txtSurname.Text = MiddleMan.CurrentBUser.user_surname;
            txtEmail.Text = MiddleMan.CurrentBUser.email;

            txtName.Enabled = false;
            txtSurname.Enabled = false;
            txtEmail.Enabled = false;
        }

        private void btnReturnPay_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            card.BCardNumber = txtCardNumber.Text;
            card.BValidThru = txtValidThru.Text;
            try
            {
                card.BCCVNumber = int.Parse(txtCCVnumber.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("Format is not valid for CCV number");
                card.BCCVNumber = 0;
                return;
            }

            Stripe.Charge charge = userManipulation.DoPayment(card.BCardNumber, selectedBill.amount, MiddleMan.CurrentBUser.email);

            if(charge == null)
            {
                MessageBox.Show("Payment has failed!");
            }
            else
            {
                MessageBox.Show("Payment has been successful!");
                userManipulation.GeneratePDF(selectedBill);
                
                userManipulation.LogPayment(selectedBill);

                Close();
                
            }
                

            
        }

        private void FrmPayment_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi22-mvetma-mgrmaca-mhorvatic-cbushnaq21/wiki/F1-Help-FrmPayment#f1-help-frmpayment");
            }
        }
    }
}
