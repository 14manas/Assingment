﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CManagement.Model
{
    internal class Payment
    {
        public long PaymentID { get; set; }
        public long CourierID { get; set; }
        public double Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        public Payment()
        {

        }
        public Payment(long paymentID, long courierID, double amount, DateTime paymentDate)
        {
            PaymentID = paymentID;
            CourierID = courierID;
            Amount = amount;
            PaymentDate = paymentDate;
        }
    }
}
