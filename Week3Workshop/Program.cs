namespace Week3Workshop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Operators operators = new Operators();
            //NullOperations NullOperators = new NullOperations();

            ////calling arithmetic operation methods
            //Console.WriteLine("Addition: " + operators.Add(5, 3));
            //Console.WriteLine("Subtraction: " + operators.Subtract(5, 3));
            //Console.WriteLine("Multiplication: " + operators.Multiply(5, 3));
            //Console.WriteLine("Division: " + operators.Divide(6, 3));
            //Console.WriteLine("Find Odd or Even (5): " + operators.FindOddEven(5));

            ////calling the method to perform null checks
            //NullOperators.PerformNullChecks();


            //// task3: If else and Switch
            //Console.WriteLine("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());

            //if (age < 13)
            //{
            //    Console.WriteLine("Child");
            //}
            //else if (age >= 13 && age <= 19)
            //{
            //    Console.WriteLine("Teenager");
            //}
            //else
            //{
            //    Console.WriteLine("Adult");
            //}


            //// Task 4: If else and Switch 
            //Console.WriteLine("Enter a number (1-7) for day of the week: ");
            //int dayNumber = int.Parse(Console.ReadLine());

            ////Using switch statement
            //switch (dayNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Sunday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Saturday");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid day number");
            //        break;
            //}

            ////Task 5 : Loops
            ////Ask user to input a number N for sum calculation
            //Console.WriteLine("Enter a Number N: ");
            //int N = int.Parse(Console.ReadLine());

            ////Calculating the sum of numbers from 1 to N using a for loop
            //int sum = 0;
            //for (int i = 1; i <= N; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine("The sum of numbers from 1 to " + N + " is: " + sum);

            //// Printing numbers from 1 to 20 using while loop
            //Console.WriteLine("\nPrinting numbers from 1 to 20:");
            //int number = 1;
            //while (number <= 20)
            //{
            //    // Stop when number is 15
            //    if (number == 15)
            //    {
            //        break;
            //    }

            //    // Skip multiples of 4
            //    if (number % 4 == 0)
            //    {
            //        number++;
            //        continue;
            //    }

            //    Console.WriteLine(number);
            //    number++;
            //}


            //// Finding the sum of all elements in an array using a foreach loop.
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int totalSum = 0;

            //foreach (int num in numbers)
            //{
            //    totalSum += num;
            //}
            //Console.WriteLine("The sum of all elements in the array is: " + totalSum);


            ////Task 6 : Try Catch Finally

            //try
            //{
            //    Console.WriteLine("Please Enter a Number.");
            //    int input = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("You entered: " + input);

            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid number format.");
            //}
            //finally
            //{
            //    Console.WriteLine("Program Executed");
            //}

            //Task 7: Password Validation with Exception
            try
            {
                Console.WriteLine("Enter a password: ");
                string password = Console.ReadLine();

                if (password.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters.");
                }

                Console.WriteLine("Password satisfied the requirement");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        //public class Operators
        //{
        //   public int Add(int a, int b)
        //    {
        //        return a + b;
        //    }

        //    public int Subtract(int a, int b)
        //    {
        //        return a - b;
        //    }
        //    public int Multiply(int a, int b)
        //    {
        //        return a * b;
        //    }
        //    public int Divide(int a, int b)
        //    {
        //        return a / b;
        //    }
        //}
    }
}
