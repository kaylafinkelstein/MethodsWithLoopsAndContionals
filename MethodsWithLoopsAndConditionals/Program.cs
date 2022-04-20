using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintThousand();
            Threes();
            Console.WriteLine(IsEqual(2, 100));
            IsEven(2);
            PositiveOrNegative(-500);
            CanVote(26);
            Console.WriteLine(InRange(6));
            MultiplicationTable();
           



        }

        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)

            {
                Console.WriteLine(i);
            }
        }
        public static void Threes()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }
        }
        public static bool IsEqual(int c, int d)
        {
            var check = (c == d) ? true : false;

            return check;
        }

        public static void IsEven(int f)
        {
            if (f % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }

        public static void PositiveOrNegative(int g)
        {
            if (g < 0)
            {
                Console.WriteLine("Negative");
            }
            if (g > 0)
            {
                Console.WriteLine("Positive");
            }
        }

        public static void CanVote(int v)
        {
            var age = v;
            Console.WriteLine($"How old are you?");
            age = int.Parse(Console.ReadLine());


            if (age <= 17)
            {
                Console.WriteLine("Sorry! You can't vote yet");
            }
            if (age >= 18)
            {
                Console.WriteLine("Congrats! You can contribute to your country!");
            }
        }
        public static bool InRange(int range)
        {
           
           
            

            if (range >= -10 && range <= 10)
            {
                return true; 
            }
            else
            {
                return false;
            }
           
        }

        public static void MultiplicationTable()
        {
            int number, multiplier;
            Console.WriteLine("Enter a number");
            number = Convert.ToInt32(Console.ReadLine());

            for ( multiplier = 1; multiplier <= 12; multiplier++)
            {
                Console.WriteLine("{0} * {1} = {2}",number,multiplier,(number * multiplier));
            }

        }


    }
}
