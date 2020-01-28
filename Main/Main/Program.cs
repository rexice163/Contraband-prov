using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ett försök på fråga spelaren på hur många bilar de vill ha och skapa en lista på det

           List<string> numbersCar = new List<string>();

           Console.WriteLine("How many cars do you want?");
           bool numbers;
           string answer = Console.ReadLine();


           while(numbers = answer.All(char.IsDigit))
           {
                int nummer = int.Parse(answer);
                
           }


        }
    }
}
