using System.IO;
using System.Text.Json;
using System.Collections.Generic;


public class Task2
{

            public static string comma = ", ";
            public static void readjson()
            {
            string json = File.ReadAllText("arrays.json");
            List<object> data = JsonSerializer.Deserialize<List<object>>(json);
            List<int> numbers = new List<int>();
            flattenNumbers(data, numbers);
            string numbersString = string.Join(comma, numbers);
            Console.WriteLine($"{numbersString}");
            

            }

            public static void flattenNumbers(List<object> data, List<int> numbers)
            {
                foreach (var item in data)
                {
                  if (item is JsonElement element)
                    {
                    if (element.ValueKind == JsonValueKind.Array)
                    {
                    flattenNumbers(element.EnumerateArray().Select(x => (object)x).ToList(), numbers);
                    }
                    else if (element.ValueKind == JsonValueKind.Number && element.TryGetInt32(out int number))
                    {
                    numbers.Add(number);
                    }
                  
                    }
                
                }
            
            }
        
    
}

 
    

      