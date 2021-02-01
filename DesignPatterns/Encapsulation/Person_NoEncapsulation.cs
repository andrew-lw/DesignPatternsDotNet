namespace Encapsulation
{
    public class Person_NoEncapsulation
    {
        public string FirstName { get; set; }

        public Person_NoEncapsulation(string firstName)
        {
            FirstName = firstName;
        }
    }
}