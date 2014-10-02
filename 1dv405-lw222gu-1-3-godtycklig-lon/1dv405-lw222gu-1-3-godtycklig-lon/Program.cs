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

            do
            {
                numberOfInputSalaries = ReadInt("Ange antal löner du vill mata in: ");

                if (numberOfInputSalaries < 2)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Du måste mata in minst två löner för att kunna göra en beräkning\n");
                    Console.ResetColor();
                }

                else
                {
                    ProcessSalaries(numberOfInputSalaries);
                }

                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tryck på en tangent för att göra en ny beräkning. Escape avslutar programmet.");
                Console.ResetColor();
                
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        private static void ProcessSalaries(int count)
        {                                                                                   
            int[] salaries = new int[count];

            for (int i = 0; i < salaries.Length; i++)
            {
                salaries[i] = ReadInt(string.Format("Ange lön nummer {0}: ", (i + 1)));
            }

       
            //Kopiera och sortera arrayen
            int[] copyOfSalaries = (int[])salaries.Clone();
            Array.Sort(copyOfSalaries);

            Console.WriteLine("----------------------------------------");

            //Beräkna median
            int medianSalary = copyOfSalaries[count / 2];

            if (count % 2 == 1)
            {
                Console.WriteLine("Medianlön: {0,15:c0}", medianSalary);
            }

            else
            {
                medianSalary = (copyOfSalaries[count / 2] + copyOfSalaries[count / 2 - 1]) / 2;
                Console.WriteLine("Medianlön: {0,15:c0}", medianSalary);
            }

            //Beräkna medellön
            double averageSalary;
            averageSalary = copyOfSalaries.Average();
            Console.WriteLine("Medellön: {0,16:c0}", averageSalary);

            //Beräkna lönespridningen
            int wageSpread;
            wageSpread = copyOfSalaries.Max() - copyOfSalaries.Min();
            Console.WriteLine("Lönespridning: {0,11:c0}", wageSpread);

            Console.WriteLine("----------------------------------------");

            for (int i = 0; i < salaries.Length; ++i)
            {
                Console.Write("{0,10}", salaries[i]);

                if (i % 3 == 2)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();


        }

        private static int ReadInt(string prompt)
        {
            int inputSalaries;
            Console.Write(prompt);
            string input = null;

            while (true)
            {
                try
                {
                    input = Console.ReadLine();
                    inputSalaries = int.Parse(input);
                    return inputSalaries;
                }

                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Du måste ange ett heltal. {0} kan inte tolkas som ett heltal.", input);
                    Console.ResetColor();
                    Console.Write("Ange heltalet på nytt: ");
                }
            }

        }
    }
}
