using System;

class Calculator3
{
    public static void Main(string[] args)
    {
        int fnum;
        int snum;
        int ans = 0;
        char oper;
        bool isContinue = true;

        while (isContinue)
        {
            Console.Write("Enter first number: ");
            fnum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            snum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Choose an Operation (+, -, *, /): ");
            oper = Console.ReadKey().KeyChar; // Read a single character and store it
            Console.WriteLine(); // Move to the next line after reading the operation

            // Perform the calculation based on the operator
            if (oper == '+')
            {
                ans = fnum + snum;
                Console.WriteLine("Result: " + ans);
            }
            else if (oper == '-')
            {
                ans = fnum - snum;
                Console.WriteLine("Result: " + ans);
            }
            else if (oper == '*')
            {
                ans = fnum * snum;
                Console.WriteLine("Result: " + ans);
            }
            else if (oper == '/')
            {
                if (snum != 0) // Only check if snum is zero for division
                {
                    ans = fnum / snum;
                    Console.WriteLine("Result: " + ans);
                }
                else
                {
                    Console.WriteLine("Error: Division by 0 is not allowed.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please use +, -, *, or /.");
                continue; // Skip to the next iteration to prompt again
            }

            // Ask if the user wants to perform another calculation
            Console.Write("Do you want to perform another calculation? (yes/no): ");
            string continuation = Console.ReadLine();

            if (continuation.Equals("yes"))
            {
                isContinue = true; // Continue the loop
            }
            else if (continuation.Equals("no"))
            {
                isContinue = false; // Exit the loop
            }
            else
            {
                Console.WriteLine("Invalid Input. Please enter 'yes' or 'no'.");
                isContinue = true; // Continue asking until valid input is received
            }
        }

        Console.WriteLine("Thank you for using the calculator!");
    }
}
