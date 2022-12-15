using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Darts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPoints = 301;
            int successfullAtempts = 0;
            int unsuccessfullAttepmts = 0;
            string name = Console.ReadLine();


            string input = "";
            while (totalPoints > 0 || input == "Retire")
            {
                input = Console.ReadLine();

                if (input == "Retire")
                {
                    Console.WriteLine($"{name} retired after {unsuccessfullAttepmts} unsuccessful shots.");
                    break;
                }

                int points = int.Parse(Console.ReadLine());

                if (input == "Single") points = points;
                else if (input == "Double") points *= 2;
                else if (input == "Triple") points *= 3;

                if (points > totalPoints)
                {
                    unsuccessfullAttepmts++;
                    continue;
                }

                totalPoints -= points;
                successfullAtempts++;


            }
            if (totalPoints == 0)
            {
                Console.WriteLine($"{name} won the leg with {successfullAtempts} shots.");

            }


        }
    }
}
