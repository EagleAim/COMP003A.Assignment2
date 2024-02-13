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

            
            Console.WriteLine("PLEASE ENTER FIRST NAME");
            string firstName = Console.ReadLine();
            firstName = Console.ReadLine();
           

            
            Console.WriteLine("PLEASE ENTER MIDDLE NAME");
            string middleName = Console.ReadLine();
            middleName = Console.ReadLine();
        

            
            Console.WriteLine("PLEASE ENTER LAST NAME");
            string lastName = Console.ReadLine();
            lastName = Console.ReadLine();
         

            Console.WriteLine("PLEASE ENTER YOUR AGE");
            string inputAge = Console.ReadLine();
            int yearBorn = 2023 - Convert.ToInt32(inputAge);
            inputAge = Console.ReadLine();
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");

            //Math
            Console.WriteLine("***************************************************************");
            Console.WriteLine("MATH");
            Console.WriteLine("***************************************************************");

            Console.WriteLine("PLEASE ENTER YOUR FIRST NUMBER");
            string number1;
            number1 = Console.ReadLine();

            Console.WriteLine("PLEASE ENTER YOUR SECOND NUMBER");
            string number2;
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
            Console.WriteLine("PLEASE ENTER A RADIUS NUMBER");
            string Radius;
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;

            Console.WriteLine(area);
            Console.WriteLine(circumference);
        }
    }
}