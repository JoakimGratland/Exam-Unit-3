
public static class Task1
{

public class Square
{
    public static int squareNumber(int number)
    {
        return number * number;
    }
}

public class Converter
{
     public static double inchesToMm(double inches)
        {
            return inches * 25.4;
        }
}

public class findSquareRoot 
{
    public static double squareRootOfNumber(double x)
    {
        if (x < 2)
        {
            return x;
        }

        double y = x;
        double z = (y + x / y) / 2;

        while (y - z >= 0.00001)
        {
            y = z;
            z = (y + x / y) / 2;
        }
        return z;
        
    }
}

public class cubeOfANumber
{
    public static int cubeOfNumber(int number)
    {
        return number * number * number;
    }
}

public class areaOfACircle
{
    public static double areaOfCircle(double radius)
    {
        return 3.14 * radius * radius;
    }
}

public class greetingsWithNames
{
    public static string greetWithName(string name)
    {
        return $"{Text.Hello}, {name}";
    }
}

}

