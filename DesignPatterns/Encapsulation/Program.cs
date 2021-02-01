using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var person1 = new Person_NoEncapsulation("aNdReW");
                var person2 = new Person_Encapsulation("aNdReW");
                //outputs aNdReW
                Console.WriteLine(person1.FirstName);
                //outputs Andrew
                Console.WriteLine(person2.FirstName);
                //throws exception as expected
                var person3 = new Person_Encapsulation("");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
