using System;
using System.Globalization;
using System.Threading;

namespace Encapsulation
{
    public class Person_Encapsulation
    {
        public string FirstName {
            get { return _firstName; }
            set { SetFirstName(value); }
        }

        private string _firstName;

        private void SetFirstName(string input)
        {
            //this logic is executed everytime the FirstName value is set

            //example of validation 
            if (string.IsNullOrWhiteSpace(input)) throw new ArgumentException("input for FirstName can not be null or empty");

            //proper case
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            _firstName = textInfo.ToTitleCase(input);

        }

        public Person_Encapsulation(string firstName)
        {
            FirstName = firstName;
        }
    }
}