
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymForms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Stripe.StripeConfiguration.ApiKey = "sk_test_51LhfVrLyEGDUxpAsTOUZ43jR2d5VnJXQeqiDgIQfB0iudJ17UMMoNGOyudQoBPH9htf9BNPJbGigPShCzyW2OIKR00XSDk0p7i";
            Application.Run(new FrmHomePage());
        }
    }
}
