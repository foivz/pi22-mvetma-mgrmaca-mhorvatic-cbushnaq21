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
        public FrmmembershipFee()
        {
            InitializeComponent();
        }

        private void FrmmembershipFee_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void FillUnpaidBills()
        {
            throw new NotImplementedException();
        }

        private void FillPaidBills()
        {
            throw new NotImplementedException();
        }

        private void btnReturnMembershipFee_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPaySelectedBill_Click(object sender, EventArgs e)
        {
            FrmPayment frm = new FrmPayment();
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
