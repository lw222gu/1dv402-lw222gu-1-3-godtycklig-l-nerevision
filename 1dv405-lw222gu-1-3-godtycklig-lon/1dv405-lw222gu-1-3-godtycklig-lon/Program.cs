using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv405_lw222gu_1_3_godtycklig_lon
{
    class Program
    {
        private static void Main(string[] args)
        {
            int numberOfInputSalaries;

            numberOfInputSalaries = ReadInt("Ange antal löner du vill mata in: ");

            if (numberOfInputSalaries < 2)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Du måste mata in minst två löner för att kunna göra en beräkning\n");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tryck på en tangent för att göra en ny beräkning. Esc avslutar programmet.");
                Console.ResetColor();
                //Console.ReadKey(true).Key != ConsoleKey.Escape;
            } 
            else 
            {
                ProcessSalaries(numberOfInputSalaries);
            }

            //int salary;
            //salary = ReadInt("Ange lön nummer {}: ");

        }

        private static void ProcessSalaries(int count)
        {
            int[] salaries = new int[count];

            for (int i = 0; i < salaries.Length; ++i)
            {
                //Console.WriteLine("Ange lön nummer{0}: ", (i+1));
               salaries[i] = ReadInt("Ange lön nummer{0}: ", (i+1));
            }
        }

        private static int ReadInt(string prompt)
        {
            int inputSalaries;
            Console.Write(prompt);

            while (true)
            {
                try
                {
                    inputSalaries = int.Parse(Console.ReadLine());
                    return inputSalaries;
                }

                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Du måste ange antalet löner med ett heltal.");
                    Console.ResetColor();
                    Console.Write("Ange antal löner på nytt: ");
                }
            }

            //int salary;
            //Console.Write(prompt);
            //salary = int.Parse(Console.ReadLine());
            //return salary;

        }
    }
}
