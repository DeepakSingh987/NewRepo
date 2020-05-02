using System;

namespace Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            int choice;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Select from menu");
            Console.WriteLine("==================================================");
            Console.WriteLine("1.Add two Numbers");
            Console.WriteLine("2.Add many numbers");
            Console.WriteLine("3.Substract two numbers");
            Console.WriteLine("4.Substract many numbers");
            Console.WriteLine("Enter the number of your choice");
            int v = Convert.ToInt32(Console.ReadLine());
            choice = v;
            switch (choice)
            {

                case 1:
                    System.Console.WriteLine("Enter Numbers to be added");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    obj.AddTwoNumbers(number1, number2);
                    break;
                case 2:
                    obj.AddMultipleNumbers();
                    break;
                case 3:
                    System.Console.WriteLine("Enter Numbers to be substracted");
                    int number3 = Convert.ToInt32(Console.ReadLine());
                    int number4 = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine(number3- number4);
                    break;
                case 4:
                    obj.SubstractMultipleNumbers();
                    break;
                case 5:
                    break;
                default:
                    Console.Write("Input correct option\n");
                    break;

            }
        }

        public void AddTwoNumbers(int number1, int number2)
        {
            System.Console.WriteLine(value: number1 + number2);
        }

        public void AddMultipleNumbers()
        {
            System.Console.WriteLine("Enter first two Numbers to be added");
            int i = 1;
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sum = number1 + number2;
            System.Console.WriteLine(sum);
            do
            {
                System.Console.WriteLine("do you still want to add number:if yes enter number to be added" +
                                         "or to end type (N/n)");
                var newInput = Console.ReadLine();
                if (newInput == "N" || newInput == "n")
                {
                    break;
                }
                sum = sum + Convert.ToInt32(newInput);
                System.Console.WriteLine(sum);
            } while (i == 1);
        }

        public void SubstractMultipleNumbers()
        {
            System.Console.WriteLine("Enter first two Numbers to be substracted");
            int i = 1;
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sum = number1 - number2;
            System.Console.WriteLine(sum);
            do
            {
                System.Console.WriteLine("do you still want to add number:if yes enter number to be substracted" +
                                         "or to end type (N/n)");
                var newInput = Console.ReadLine();
                if (newInput == "N" || newInput == "n")
                {
                    break;
                }
                sum = sum - Convert.ToInt32(newInput);
                System.Console.WriteLine(sum);
            } while (i == 1);
        }

    }

}
