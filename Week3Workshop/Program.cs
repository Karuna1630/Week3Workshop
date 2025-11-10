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


            // Task 4: If else and Switch 
            Console.WriteLine("Enter a number (1-7) for day of the week: ");
            int dayNumber = int.Parse(Console.ReadLine());

            //Using switch statement
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day number");
                    break;




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
