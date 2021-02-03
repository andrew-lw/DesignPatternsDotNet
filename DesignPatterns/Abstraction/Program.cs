using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var mouse = new Mouse();
                mouse.Move(-2, 5);
                mouse.Move(3, 16);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
