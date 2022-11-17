using System.Text.Json;
using System.Net;
using ConsoleTables;
using BooksAPI.Models;
using System.Text.Json.Serialization;

namespace BooksAPI
{
    public class Program
    {
        static void Main(string[] args)
        {

        
            // set up path to the JSON file(s)
            var root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            var filePath = root + $"{Path.DirectorySeparatorChar}Data{Path.DirectorySeparatorChar}AssassinsApprentice.json";
            var dataPath = root + $"{Path.DirectorySeparatorChar}Data";



            // create options JSONSerializer must follow
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var library = new List<Book>();


            var jsonString = string.Empty;
            var jsonString2 = string.Empty;


            List<string> fileNames = new List<string>();

            fileNames.Add(root + $"{Path.DirectorySeparatorChar}Data{Path.DirectorySeparatorChar}AssassinsApprentice.json");
            fileNames.Add(root + $"{Path.DirectorySeparatorChar}Data{Path.DirectorySeparatorChar}TheEyeOfTheWorld.json");
            fileNames.Add(root + $"{Path.DirectorySeparatorChar}Data{Path.DirectorySeparatorChar}TheLastWish.json");
            fileNames.Add(root + $"{Path.DirectorySeparatorChar}Data{Path.DirectorySeparatorChar}TheWayOfKings.json");
            fileNames.Add(root + $"{Path.DirectorySeparatorChar}Data{Path.DirectorySeparatorChar}WhereTheRedFernGrows.json");



            foreach (var file in fileNames)
            {


                using (StreamReader sr = new StreamReader(file))
                {
                    jsonString = sr.ReadToEnd();

                }


                // deserialize (read) JSON and create object(s) based on its information
                var book = JsonSerializer.Deserialize<Book>(jsonString, options);
                Console.WriteLine(book);
            }



            VolumeInfo v = new VolumeInfo("tile",new List<string> { "me"},"The greatest book");
            Items i = new Items("1","123", v);
            Book newBook = new Book(new Items[] { i });




            Console.WriteLine(newBook);







            var newbook2 = JsonSerializer.Serialize<Book>(newBook);

            string newFile = dataPath + "\\newBook.json";
            using (StreamWriter sw = new StreamWriter(newFile))
            {        
                    sw.WriteLine(newbook2);
            
            }

       
            
            
        }

    }
}