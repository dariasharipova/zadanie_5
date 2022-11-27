class NumberManpulator
{
    static double calc(double a,double b)
    {
        return (Math.Sin(a)+Math.Sqrt(a))/(Math.Cos(b)+Math.Sqrt(b));

    }
    static void Main(string[] args)
    {
        double x = NumberManpulator.calc(3,5)*NumberManpulator.calc(3,7)*NumberManpulator.calc(5,5);
        Console.WriteLine(Math.Round(x,3));

    }
}