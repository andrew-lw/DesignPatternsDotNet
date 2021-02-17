using System;
using System.Linq;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            BowlFactory factory = new BowlFactory();
            var bigBowl = factory.GetMeABowl("Big Ol Brand");
            var smallBowl = factory.GetMeABowl("small flakes");
            Console.WriteLine("bigBowl type : " + bigBowl.GetType());
            Console.WriteLine("smallBowl type : " + smallBowl.GetType());
            Console.WriteLine("bigBowl interface : " + bigBowl.GetType().GetInterfaces().First());
            Console.WriteLine("smallBowl interface : " + smallBowl.GetType().GetInterfaces().First());

            Console.WriteLine(bigBowl.AddToBowl(15));
            Console.WriteLine(smallBowl.AddToBowl(15));
            Console.ReadLine();
        }

    }

    interface IBowl
    {
        int MaxVolume { get; set; }
        string Brand { get; set; }
        int CurrVolume { get; set; }
        string AddToBowl(int input);

    }


    class SmallBowl : IBowl
    {
        public int MaxVolume { get; set; }
        public int CurrVolume { get; set; }
        public string Brand { get; set; }

        public SmallBowl(string brand)
        {
            MaxVolume = 10;
            Brand = brand;
        }

        public string AddToBowl(int input)
        {
            if (input + CurrVolume > MaxVolume)
            {
                CurrVolume = MaxVolume;
                return "you spilled";
            }
            else
            {
                if (input + CurrVolume == MaxVolume)
                {
                    CurrVolume += input;
                    return "filled to the brim";
                }
                else
                {
                    CurrVolume += input;
                    return $"remaining capacity is {MaxVolume - CurrVolume}";
                }
            }            
        }
    }


    class ReallyBigBowl : IBowl
    {
        private bool _spoonInBowl;

        public int MaxVolume { get; set; }
        public int CurrVolume { get; set; }
        public string Brand { get; set; }
        public string SpoonAttachment { get; set; }
        public bool SpoonInBowl { get
            {
                return _spoonInBowl;
            }
            set
            {
                Console.WriteLine(ToggleSpoonState());
            }
        }

        public ReallyBigBowl(string brand)
        {
            MaxVolume = 100;
            Brand = brand;
            SpoonAttachment = "I have a spoon attachment";
            SpoonInBowl = false;
        }

        public string AddToBowl(int input)
        {
            if (SpoonInBowl == true) CurrVolume += 5;
            if (input + CurrVolume > MaxVolume)
            {
                CurrVolume = MaxVolume;
                return "you spilled";
            }
            else
            {
                if (input + CurrVolume == MaxVolume)
                {
                    CurrVolume += input;
                    return "filled to the brim";
                }
                else
                {
                    CurrVolume += input;
                    return $"remaining capacity is {MaxVolume - CurrVolume}";
                }
            }
        }

        private string ToggleSpoonState()
        {
            if (_spoonInBowl)
            {
                _spoonInBowl = false;
                return AddToBowl(-5);
            }
            else
            {
                _spoonInBowl = true;
                return AddToBowl(5);
            }
        }
    }

    class BowlFactory
    {
        public IBowl GetMeABowl(string brand)
        {
            if (brand[0].ToString().ToLower() == brand[0].ToString())
            {
                return new SmallBowl(brand);
            }
            else return new ReallyBigBowl(brand);
        }
    }

}
