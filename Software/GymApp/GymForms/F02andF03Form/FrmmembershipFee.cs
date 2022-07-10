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
    public partial class FrmmembershipFee : Form
    {
        public MiddleMan userManipulation;
        public FrmmembershipFee()
        {
            userManipulation = new MiddleMan();  
            InitializeComponent();
        }

        private void FrmmembershipFee_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void FillUnpaidBills()
        {
            dgvUnpaidBills.DataSource = userManipulation.UnpaidBills();
        }

        private void FillPaidBills()
        {
            dgvPaidBills.DataSource = userManipulation.PaidBills();
        }

        private void btnReturnMembershipFee_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPaySelectedBill_Click(object sender, EventArgs e)
        {   
            BBill selectedBill = dgvUnpaidBills.CurrentRow.DataBoundItem as BBill;
            FrmPayment frm = new FrmPayment(selectedBill);
            frm.ShowDialog();

            RefreshGUI();
        }

        private void RefreshGUI()
        {
            FillUnpaidBills();
            FillPaidBills();
        }
    }
}
