internal class Calculator228
{
    public static double num1 = 0, num2 = 0;
    private static void Main(string[] args)
    {
        RequestFirstNumber();
    }
    static void RequestFirstNumber()
    {
        Console.Write("Enter first number: ");
        if (double.TryParse(Console.ReadLine(), out num1))
            RequestSecondNumber();
        else
            RequestFirstNumber();
    }
    static void RequestSecondNumber()
    {
        Console.Write("Enter second number: ");
        string? input = Console.ReadLine();

        if (double.TryParse(input, out num2))
            if (num2 == 0)
            {
                Console.WriteLine("You can't devide by zero");
                RequestSecondNumber();
            }
            else
                RequestOperator();
        else RequestFirstNumber();
    }

    static void RequestOperator()
    {
        Console.Write("Enter operator: ");
        string? input = Console.ReadLine();

        if (input == "+")
            Console.WriteLine(num1 + num2);
        else if (input == "-")
            Console.WriteLine(num1 - num2);
        else if (input == "*")
            Console.WriteLine(num1 * num2);
        else if (input == "/")
            Console.WriteLine(num1 / num2);
        else
            RequestOperator();
    }
}