public class MyClass
{
    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new System.DivideByZeroException("Cannot divide by zero.");
        }

        return a / b;
    }

    public static int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new System.DivideByZeroException("Cannot divide by zero.");
        }

        return a / b;
    }

    // <summary>
    // Divide two decimal numbers. Throws DivideByZeroException if b is zero.
    // </summary>
    public static decimal Divide(decimal a, decimal b)
    {
        if (b == 0)
        {
            throw new System.DivideByZeroException("Cannot divide by zero.");
        }

        return a / b;
    }

    // Add methods for different numeric types
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static decimal Add(decimal a, decimal b)
    {
        return a + b;
    }
}
