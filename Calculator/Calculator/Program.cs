namespace Calculator;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("Enter first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Choose an operation (+, -, *, /):");
        string operation = Console.ReadLine();

        if (operation == "+")
        {
            int result = Add(num1, num2);
            Console.WriteLine($"Result: {num1} + {num2} = {result}");
        }
        else if (operation == "-")
        {
            int result = Subtract(num1, num2);
            Console.WriteLine($"Result: {num1} - {num2} = {result}");
        }
        else if (operation == "*")
        {
            int result = Multiply(num1, num2);
            Console.WriteLine($"Result: {num1} * {num2} = {result}");
        }
        else if (operation == "/")
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero!");
            }
            else
            {
                double result = Divide(num1, num2);
                Console.WriteLine($"Result: {num1} / {num2} = {result}");
            }
        }
        else
        {
            Console.WriteLine("Invalid operation! Use +, -, *, or /");
        }
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static double Divide(int a, int b)
    {
        return (double)a / b;  
    }
}