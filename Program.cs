/*
 * Author: Logan King
 * Course: Comp-003A
 * Purpouse: The purpouse of this code is to show that we learned how to generate console code in VS.
 */


namespace COMP003A.ASSIGNMENT2
{ internal class Program
    {
        static void Main(string[]args)
        {
            //console cosmetic stuff
            Console.Title = "COMP-003A - Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            //strings
            Console.WriteLine("***************************************************************");
            Console.WriteLine("INFORMATION");
            Console.WriteLine("PRESS ENTER TO CONTINUTE");
            Console.WriteLine("***************************************************************");

            string firstName = Console.ReadLine();
            Console.WriteLine("PLEASE ENTER FIRST NAME");
            firstName = Console.ReadLine();
           

            string middleName = Console.ReadLine();
            Console.WriteLine("PLEASE ENTER MIDDLE NAME");
            middleName = Console.ReadLine();
        

            string lastName = Console.ReadLine();
            Console.WriteLine("PLEASE ENTER LAST NAME");
            lastName = Console.ReadLine();
         

            string inputAge = Console.ReadLine();
            Console.WriteLine("PLEASE ENTER YOUR AGE");
            inputAge = Console.ReadLine();
            int yearBorn = 2023 - Convert.ToInt32(inputAge);
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");

            //Math
            Console.WriteLine("***************************************************************");
            Console.WriteLine("MATH");
            Console.WriteLine("***************************************************************");

            string number1;
            Console.WriteLine("PLEASE ENTER YOUR FIRST NUMBER");
            number1 = Console.ReadLine();

            string number2;
            Console.WriteLine("PLEASE ENTER YOUR SECOND NUMBER");
            number2 = Console.ReadLine();

            int intiger1 = Convert.ToInt32(number1);
            int intiger2 = Convert.ToInt32(number2);

            Console.WriteLine($"{intiger1} + {intiger2} = {intiger1 + intiger2}");

            Console.WriteLine($"{intiger1} - {intiger2} = {intiger1 - intiger2}");

            Console.WriteLine($"{intiger1} * {intiger2} = {intiger1 * intiger2}");

            Console.WriteLine($"{intiger1} / {intiger2} = {intiger1 / intiger2}");

            Console.WriteLine($"{intiger1} % {intiger2} = {intiger1 % intiger2}");

            Console.WriteLine("***************************************************************");
            Console.WriteLine("CIRCLE AREA & CIRCUMFERENCE CALCULATOR");
            Console.WriteLine("***************************************************************");





        }
    }
}