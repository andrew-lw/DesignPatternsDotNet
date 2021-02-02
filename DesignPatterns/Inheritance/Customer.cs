using System;

namespace Inheritance
{
    public class Customer : Person
    {
        public int CustomerId { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime FirstPurchaseDate { get; set; }

        public Customer(string name) : base(name)
        {
            FirstPurchaseDate = DateTime.Now.AddDays(-15);
        }

        public string PrintPurchaseReceipt()
        {
            return $"Printing receipt for purchase made on {FirstPurchaseDate}";
        }

        public override string SendEmail(string message)
        {
            string output = "";
            output += base.SendEmail(message);
            output += "sending customer email. adding additional functionality to the existing base class method";
            return output;
        }
    }
}