using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatron
{
    class Program
    {
        static void greetUser()
        {
            Console.Clear();
            Console.WriteLine("Velkommen til Calculatron");
            Console.WriteLine("Tast 1 for addition");
            Console.WriteLine("Tast 2 for subtraktion");
            Console.WriteLine("Tast 3 for multiplikation");
            Console.WriteLine("Tast 4 for division");
            Console.WriteLine("Tast 0 for at afslutte");
        }

        static int getInt(string prompt)
        {
            int returnValue = 0;

            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    returnValue = int.Parse(Console.ReadLine());
                    return returnValue;
                }
                catch
                {
                    Console.WriteLine("Du skal indtaste et tal, prøv igen");
                }
            }

        }

        static int add(int x, int y)
        {
            return x + y;
        }

        static int subtract(int x, int y)
        {
            return x - y;
        }

        static int multiply(int x, int y)
        {
            return x * y;
        }

        static int[] divide(int a, int b)
        {
            int[] results = new int[2];

            results[0] = a / b;
            results[1] = a % b;
            return results;
        }

        static void Calculatron()
        {
            int firstOperand = 0;
            int secondOperand = 0;
            int result = 0;
            int[] results = new int[2];
            int userChoice = 5;
            int wait = 0;

            while (userChoice != 0)
            {
                greetUser();
                userChoice = getInt("> ");
                switch (userChoice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Addition");
                        firstOperand = getInt("Indtast første operand : ");
                        secondOperand = getInt("Indtast anden operand : ");
                        result = add(firstOperand, secondOperand);
                        Console.WriteLine("{0} + {1} = {2}",
                            firstOperand, secondOperand, result);
                        wait = Console.Read();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Subtraktion");
                        firstOperand = getInt("Indtast første operand : ");
                        secondOperand = getInt("Indtast anden operand : ");
                        result = subtract(firstOperand, secondOperand);
                        Console.WriteLine("{0} - {1} = {2}",
                            firstOperand, secondOperand, result);
                        wait = Console.Read();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Multiplikation");
                        firstOperand = getInt("Indtast første operand : ");
                        secondOperand = getInt("Indtast anden operand : ");
                        result = multiply(firstOperand, secondOperand);
                        Console.WriteLine("{0} * {1} = {2}",
                            firstOperand, secondOperand, result);
                        wait = Console.Read();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Division");
                        firstOperand = getInt("Indtast første operand : ");
                        secondOperand = getInt("Indtast anden operand : ");
                        results = divide(firstOperand, secondOperand);
                        Console.WriteLine("{0} / {1} = {2}, med rest {3}",
                            firstOperand, secondOperand, results[0], results[1]);
                        wait = Console.Read();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Du skal indtaste et tal mellem 0 og 4");
                        wait = Console.Read();
                        break;
                }
            }

        }

        static void Main(string[] args)
        {
            Calculatron();
        }
    }
}
