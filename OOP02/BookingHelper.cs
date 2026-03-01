using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal class BookingHelper
    {
        private static int _bookingCounter = 0;
        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            // حساب السعر الأصلي
            double Total = numberOfTickets * pricePerTicket;
            // التحقق من شرط الـ 5 تذاكر أو أكثر
            if (numberOfTickets >= 5)
            {
                Total -= (Total * 0.10);
            }
            return Total;
        }
        public static string GenerateBookingReference()
        {
            _bookingCounter++;
            return $"BK-{_bookingCounter}";
        }



    }
}
