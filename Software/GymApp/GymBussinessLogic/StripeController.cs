using GymBussinessLogic.Models;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBussinessLogic
{
    public class StripeController
    {
        public Charge CreateCharge(StripeCharge stripeCharge)
        {
            var options = new ChargeCreateOptions
            {
                Amount = stripeCharge.Amount,
                Currency = stripeCharge.Currency,
                Source = stripeCharge.Source,
                ReceiptEmail = stripeCharge.ReceiptEmail,
            };
            var service = new ChargeService();
            var charge = service.Create(options);
            return charge;
        }
    }
}
