

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

    public static void flattenNumbersTest()
    {
        string result = Task2.readjson();
        Console.WriteLine(result == "6410, 2831, 5049, 7554, 8707, 6940, 9517, 7565, 7522, 9242, 7972, 7064, 3441, 9960, 4966, 9368, 1634, 5150, 3709, 6660, 7155, 8056, 7834, 2639, 6601, 8063, 2390, 2544, 7022, 2385, 573, 656, 733, 1620, 3626, 6274, 1935, 6481, 928, 8291, 3196, 3431, 6058, 8010, 5052, 892, 3490, 2369, 951, 1606, 6763, 7260, 6122, 5655, 4223" ? "FlattenNumbersTest passed" : "FlattenNumbersTest failed");
    }

    public static void sumOfNodesTest()
    {
        int result = Task3.resultOfSumOfNodes();
        Console.WriteLine(result == 20903 ? "SumOfNodesTest passed" : "SumOfNodesTest failed");
    }

    public static void deepestLevelTest()
    {
        int result = Task3.resultOfDeepestLevel();
        Console.WriteLine(result == 18 ? "DeepestLevelTest passed" : "DeepestLevelTest failed");
    }

    public static void countNodesTest()
    {
        int result = Task3.resultOfCountNodes();
        Console.WriteLine(result == 40 ? "CountNodesTest passed" : "CountNodesTest failed");
    }


}