using System;

namespace Inheritance
{
    public class Employee : Person
    {
        public int BadgeNumber { get; set; }
        public string Supervisor { get; set; }
        public int PayCheckAmount { get; set; }

        public Employee(string name) : base(name)
        {
            PayCheckAmount = 100;
        }

        public string GivePayCheck()
        {
            return $"Printing paycheck for {Name} in the amount of {PayCheckAmount}";
        }

        public override string SendEmail(string message)
        {
            return "sending internal email with no help from the base class.";
        }
    }
}