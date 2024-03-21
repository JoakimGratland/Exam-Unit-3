

public static class Test
{
    public static void squareNumberTest()
    {
        int result = Task1.Square.squareNumber(5);
        Console.WriteLine(result == 25 ? "SquareTest passed" : "SquareTest failed");
    }

    public static void inchesToMmTest()
    {
        double result = Task1.Converter.inchesToMm(5);
        Console.WriteLine(result == 127 ? "InchesToMmTest passed" : "InchesToMmTest failed");
    }

    public static void squareRootOfNumberTest()
    {
        double result = Task1.findSquareRoot.squareRootOfNumber(25);
        Console.WriteLine(result == 5 ? "SquareRootOfNumberTest passed" : "SquareRootOfNumberTest failed");
    }

    public static void cubeOfNumberTest()
    {
        int result = Task1.cubeOfANumber.cubeOfNumber(5);
        Console.WriteLine(result == 125 ? "CubeOfNumberTest passed" : "CubeOfNumberTest failed");
    }

    public static void areaOfCircleTest()
    {
        double result = Task1.areaOfACircle.areaOfCircle(5);
        Console.WriteLine(result == 78.5 ? "AreaOfCircleTest passed" : "AreaOfCircleTest failed");
    }

    public static void greetingsWithNamesTest()
    {
        string result = Task1.greetingsWithNames.greetWithName("John");
        Console.WriteLine(result == "Hello, John" ? "GreetingsWithNamesTest passed" : "GreetingsWithNamesTest failed");
    }


}