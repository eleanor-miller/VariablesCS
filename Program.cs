using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Practice Creating Variables
            int numberOfCupsOfCoffee = 0;

            string fullName = "Eleanor Miller";

            // If trying to list current time change "Today" "Now"
            DateTime today = DateTime.Today;

            Console.WriteLine(numberOfCupsOfCoffee + " " + fullName + " " + today);

            // Practice Getting Input From the User
            Console.Write("What is your name? ");

            string userName = Console.ReadLine();
            Console.WriteLine("Hello, " + userName + "!");

            // Practice Getting Different Types of Input From the User
            Console.Write("Enter a number: ");
            string firstNumberAsString = Console.ReadLine();
            Console.Write("Enter another number: ");
            string secondNumberAsString = Console.ReadLine();

            // Converting String Input Into Numbers
            double firstOperand = double.Parse(firstNumberAsString);
            double secondOperand = double.Parse(secondNumberAsString);

            // Doing Math
            double sum = firstOperand + secondOperand;
            double difference = firstOperand - secondOperand;
            double product = firstOperand * secondOperand;
            double quotient = firstOperand / secondOperand;
            double remainder = firstOperand % secondOperand;

            Console.WriteLine("If you add " + firstOperand + " and " + secondOperand + " you get " + sum + "!");
            Console.WriteLine("If you subtract " + firstOperand + " and " + secondOperand + " you get " + difference + "!");
            Console.WriteLine("If you multiply " + firstOperand + " and " + secondOperand + " you get " + product + "!");
            Console.WriteLine("If you divide " + firstOperand + " and " + secondOperand + " you get " + quotient + "!");
            Console.WriteLine("If you modulus " + firstOperand + " and " + secondOperand + " you get " + remainder + "!");

            // Adventure Mode: Using Logic
            Console.Write("What is your name? ");
            string userSecondName = Console.ReadLine();
            Console.WriteLine("Hello, " + userSecondName + "!");
            if (userSecondName == "Alice")
            {
                Console.WriteLine("Curiouser and curiouser!");
            }

            // Adventure Mode: Using DateTime already done in Explorer Mode
            
            // Epic Mode
        }
    }
}
