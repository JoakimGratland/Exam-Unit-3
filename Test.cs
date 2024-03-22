

public static class Test
{
    public static void squareNumberTest()
    {
        int result = Task1.Square.squareNumber(5);
        Console.WriteLine(result == 25 ? $"{Text.squareNumberTest}{Text.passed}" :  $"{Text.squareNumberTest}{Text.failed}");
    }

    public static void inchesToMmTest()
    {
        double result = Task1.Converter.inchesToMm(5);
        Console.WriteLine(result == 127 ? $"{Text.inchesToMmTest}{Text.passed}" : $"{Text.inchesToMmTest}{Text.failed}");
    }

    public static void squareRootOfNumberTest()
    {
        double result = Task1.findSquareRoot.squareRootOfNumber(25);
        Console.WriteLine(result == 5 ? $"{Text.squareRootOfNumberTest}{Text.passed}" : $"{Text.squareRootOfNumberTest}{Text.failed}");
    }

    public static void cubeOfNumberTest()
    {
        int result = Task1.cubeOfANumber.cubeOfNumber(5);
        Console.WriteLine(result == 125 ? $"{Text.cubeOfNumberTest}{Text.passed}" : $"{Text.cubeOfNumberTest}{Text.failed}");
    }

    public static void areaOfCircleTest()
    {
        double result = Task1.areaOfACircle.areaOfCircle(5);
        Console.WriteLine(result == 78.5 ? $"{Text.areaOfCircleTest}{Text.passed}" : $"{Text.areaOfCircleTest}{Text.failed}");
    }

    public static void greetingsWithNamesTest()
    {
        string result = Task1.greetingsWithNames.greetWithName("John");
        Console.WriteLine(result == "Hello, John" ?  $"{Text.greetWithNameTest}{Text.passed}" : $"{Text.greetWithNameTest}{Text.failed}");
    }

    public static void flattenNumbersTest()
    {
        string result = Task2.readjson();
        Console.WriteLine(result == $"{Text.flattenNumbersTestResults}" ? $"{Text.flattenNumbers}{Text.passed}" : $"{Text.flattenNumbers}{Text.failed}");
    }

    public static void sumOfNodesTest()
    {
        int result = Task3.resultOfSumOfNodes();
        Console.WriteLine(result == 20903 ?  $"{Text.sumOfNodesTest}{Text.passed}" : $"{Text.sumOfNodesTest}{Text.failed}");
    }

    public static void deepestLevelTest()
    {
        int result = Task3.resultOfDeepestLevel();
        Console.WriteLine(result == 18 ? $"{Text.deepestLevelTest}{Text.passed}" : $"{Text.deepestLevelTest}{Text.failed}");
    }

    public static void countNodesTest()
    {
        int result = Task3.resultOfCountNodes();
        Console.WriteLine(result == 40 ? $"{Text.countNodes}{Text.passed}" : $"{Text.countNodes}{Text.failed}");
    }

     public static void booksAfter1992Test()
    {
        
        int result = Task4.booksAfter1992();
        Console.WriteLine(result == 95 ? $"{Text.booksAfter1992}{Text.passed}" : $"{Text.booksAfter1992}{Text.failed}");
    }
    public static void booksBefore2004Test()
    {
        int result = Task4.booksBefore2004();
        Console.WriteLine(result == 44 ? $"{Text.booksBefore2004}{Text.passed}" : $"{Text.booksBefore2004}{Text.failed}");
    }
    public static void groupByLastNameTest()
    {
        book[] result = Task4.groupByLastName();
        Console.WriteLine(result.SequenceEqual(Task4.books.OrderBy(b => b.author.Split(' ').Last())) ? $"{Text.groupByLastNameTest}{Text.passed}" : $"{Text.groupByLastNameTest}{Text.failed}");
    }
   

  public static void groupByFirstNameTest()
   {
    book[] result = Task4.groupByFirstName();
    Console.WriteLine(result.SequenceEqual(Task4.books.OrderBy(b => b.author.Split(' ').First())) ? $"{Text.groupByFirstNameTest}{Text.passed}" : $"{Text.groupByFirstNameTest}{Text.failed}");
   }

     public static void isbnByAuthorTest()
    {
        string author = "Terry Pratchett";
        var result = Task4.isbnByAuthor(author);

        if (result.Length > 0)
        {
            Console.WriteLine($"{Text.isbnByAuthorTestPassed}'{author}'");
        }
        else
        {
            Console.WriteLine($"{Text.isbnByAuthorTestFailed} '{author}'");
        }
    }

     public static void booksStartingWithTheTest()
    {
        book[] result = Task4.booksStartingWithThe();
        Console.WriteLine(result.All(b => b.title.StartsWith(Text.The)) ? $"{Text.booksStartingWithThe}{Text.passed}" : $"{Text.booksStartingWithThe}{Text.failed}");
    }

    public static void booksByAuthorWithTInTheirNameTest()
    {
        book[] result = Task4.booksByAuthorWithTInTheirName();
        Console.WriteLine(result.All(b => b.author.Contains(Text.t)) ? $"{Text.booksByAuthorWithTInTheirName}{Text.passed}" : $"{Text.booksByAuthorWithTInTheirName}{Text.failed}");
    }

     public static void chronologicalOrderTest()
    {
        book[] result = Task4.chronologicalOrder(true);
        Console.WriteLine(result.SequenceEqual(Task4.books.OrderBy(b => b.publication_year)) ? $"{Text.chronologicalOrder}{Text.passed}" : $"{Text.chronologicalOrder}{Text.failed}");
    }

    public static void alphabeticalOrderTest()
    {
        book[] result = Task4.alphabeticalOrder(true);
        Console.WriteLine(result.SequenceEqual(Task4.books.OrderBy(b => b.title)) ? $"{Text.alphabeticalOrder}{Text.passed}" : $"{Text.alphabeticalOrder}{Text.failed}");
    }



}