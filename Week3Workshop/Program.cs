namespace Week3Workshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operators operators = new Operators();
            NullOperations NullOperators = new NullOperations();
            Console.WriteLine("Addition: " + operators.Add(5, 3));
            Console.WriteLine("Subtraction: " + operators.Subtract(5, 3));
            Console.WriteLine("Multiplication: " + operators.Multiply(5, 3));
            Console.WriteLine("Division: " + operators.Divide(6, 3));
            Console.WriteLine("Find Odd or Even (5): " + operators.FindOddEven(5));

            //calling the method to perform null checks
            NullOperators.PerformNullChecks();



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
