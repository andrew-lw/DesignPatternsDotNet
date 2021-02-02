using System;
using System.Globalization;
using System.Threading;

namespace Inheritance
{
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual string SendEmail(string message)
        {
            string output = "";
            if (!string.IsNullOrEmpty(Email)) output += $"sending message to : {Email}";
            else output += $"no email on file for {Name}";
            return output;
        }

        public string PrintProperCaseName()
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            Name = cultureInfo.TextInfo.ToTitleCase(Name);
            return Name;
        }

        public Person(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException($"Name is required to create a {this.GetType()} type object");
            else Name = name;
        }
    }
}