using System.Text.Json;
using System.IO;
using System.Collections.Generic;
public class book
{
    public string title { get; set; }
    public int publication_year { get; set; }
    public string author { get; set; }
    public string isbn { get; set; }
}

public static class Task4
{
    public static book[] books;
    public static void readJson()
    {
        if (books != null)
        {
            return;
        }
        string json = File.ReadAllText(Text.booksJson);
        books = JsonSerializer.Deserialize<book[]>(json);
        
    }

public static int booksAfter1992()
{
    readJson();
    int count = 0;
    foreach (var book in books)
    {
        if (book.publication_year > 1992)
        {
            count++;
        }
    }
    return count;
}

public static int booksBefore2004()
{
    readJson();
    int count = 0;
    foreach (var book in books)
    {
        if (book.publication_year < 2004)
        {
            count++;
        }
    }
    return count;
}

    public static book[] groupByLastName()
    {
        return books.OrderBy(b => b.author.Split(' ').Last()).ToArray();
    }

  public static book[] groupByFirstName()
    {
        return books.OrderBy(b => b.author.Split(' ').First()).ToArray();
    }

    public static string[] isbnByAuthor(string author)
    {
        return books.Where(b => b.author == author).Select(b => b.isbn).ToArray();
    }

      public static book[] booksStartingWithThe()
    {
        return books.Where(b => b.title.StartsWith(Text.The)).ToArray();
    }

    public static book[] booksByAuthorWithTInTheirName()
    {
       return books.Where(b => b.author.Contains(Text.t)).ToArray();
    }

     public static book[] chronologicalOrder(bool ascending)
    {
        return ascending ? books.OrderBy(b => b.publication_year).ToArray() : books.OrderByDescending(b => b.publication_year).ToArray();
    }

     public static book[] alphabeticalOrder(bool ascending)
    {
        return ascending ? books.OrderBy(b => b.title).ToArray() : books.OrderByDescending(b => b.title).ToArray();
    }

}






