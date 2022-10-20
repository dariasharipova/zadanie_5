class NumberManpulator
{
    static double three()
    {
        double sinthree = Math.Sin(3)+Math.Sqrt(3);
        return sinthree;
    }
    static double five()
    {
        double costfive = (Math.Cos(5)+Math.Sqrt(5));
        return costfive;
    }

    static void Main(string[] args)
    {
        double x = NumberManpulator.three()/NumberManpulator.five() * NumberManpulator.three()/(Math.Cos(7)+Math.Sqrt(7)) * (Math.Sin(5)+Math.Sqrt(5))/NumberManpulator.five();
        Console.WriteLine(Math.Round(x,3));

    }
}


//double x = (Math.Sin(3)+Math.Sqrt(3))/(Math.Cos(5)+Math.Sqrt(5)) * (Math.Sin(3)+Math.Sqrt(3))/(Math.Cos(7)+Math.Sqrt(7)) * (Math.Sin(5)+Math.Sqrt(5))/(Math.Cos(5)+Math.Sqrt(5));
