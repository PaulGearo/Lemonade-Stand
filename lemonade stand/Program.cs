using System;

namespace lemonade_stand
{
    class Program
    {
        public static void Main(string[] args)
        {
            int NumberOFstands = GetIntResponce("how may will you open?");

            double empireNetProfit = 0;
            for (int i = 0; i < NumberOFstands; i++)
            {
            LemonadeStand lemonadeStand = new LemonadeStand();
            double netProfit = lemonadeStand.GetLifetimeTotalProfit();
                empireNetProfit += netProfit;
            Console.WriteLine($"Ok, so the total profit {lemonadeStand.Name} " +
                $"Stand will ${netProfit}");
                Console.ReadLine();
                Console.Clear();
            }

            Console.WriteLine("your empire will have a " +
                $"net profit if ${empireNetProfit}.");


            Console.ReadLine();
        }

        public static int GetIntResponce(string question)
        {
            Console.WriteLine(question);
            string responseStr = Console.ReadLine();
            int response;
            while (int.TryParse(responseStr, out response) == false)
            {
                Console.WriteLine("please enter an integer");
                responseStr = Console.ReadLine();
            }    
            return response;
        }

        public static double GetDoubleResponce(string question)
        {
            Console.WriteLine(question);
            string responseStr = Console.ReadLine();
            double response;
            while (double.TryParse(responseStr, out response) == false)
            {
                Console.WriteLine("please enter an number");
                responseStr = Console.ReadLine();
            }
            return response;
        }
        public static string GetStringResponce(string question)
        {
            Console.WriteLine(question);
            string response = Console.ReadLine();
            return response;
        }


    }
}
