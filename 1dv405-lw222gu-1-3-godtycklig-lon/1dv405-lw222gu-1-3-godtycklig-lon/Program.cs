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
            int numberOfSalaries;
            numberOfSalaries = ReadInt("Ange antal löner du vill mata in: ");

            while (true)
            { 
                try
                {
                    numberOfSalaries = int.Parse(Console.ReadLine());

                    if (numberOfSalaries < 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Du måste mata in minst två löner för att kunna göra en beräkning");
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("Tryck på en tangent för att göra en ny beräkning. Esc avslutar programmet.");
                        Console.ResetColor();
                        //Console.ReadKey(true).Key != ConsoleKey.Escape;
                    }   break;
                }
                    
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Du måste ange antalet löner med ett heltal.");
                    Console.ResetColor();
                }
            }

            //int salaries;
            //salaries = ReadInt[];
        }

        private static void ProcessSalaries(int count)
        {

        }

        private static int ReadInt(string prompt)
        {
            int inputSalaries;
            Console.Write(prompt);
            inputSalaries = int.Parse(Console.ReadLine());
            return inputSalaries;     
  
            //int salaries [i];
            //Console.Write(prompt);
            //salaries = int.Parse(Console.ReadLine());
            //return salaries;
        }
    }
}
