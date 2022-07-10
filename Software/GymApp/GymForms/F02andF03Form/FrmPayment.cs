﻿
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
            userManipulation = new MiddleMan();
            selectedBill = bill;
            InitializeComponent();
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
                card.BCCVNumber = int.Parse(txtCCVnumber.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Format is not valid for CCV number");
                card.BCCVNumber = 0;
            }

            if(userManipulation.CheckCard(card) == false)
            {
                MessageBox.Show("Error, card data is not correct!");
            }
            else
            {
                MessageBox.Show("Payment has been successful!");
                userManipulation.GeneratePDF(selectedBill);
                userManipulation.SendEmail();
                userManipulation.LogPayment(selectedBill);
                
            }
                

            
        }
    }
}
