using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBussinessLogic.Interfaces
{
    public interface IBillController
    {
        bool AddNewBill(string billId, string amount, DateTime dueDate, string userEmail, string billReferenceNumber);
        bool UpdateBill(string billId, string amount, DateTime dueDate, string userEmail, string billReferenceNumber);
        bool DeleteBill(string billId, string amount, DateTime dueDate, string userEmail, string billReferenceNumber);

    }
}
