
using Newtonsoft.Json;
using System.Text.Json;
using System.Net;
using BooksAPI.Models;
using System.Text.Json.Serialization;


namespace BooksApiNewton
{
    public class Program
    {
        static void Main(string[] args)
        {
            // set up path to the JSON file(s)
            var root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            var filePath = root + $"{Path.DirectorySeparatorChar}Data{Path.DirectorySeparatorChar}AssassinsApprentice.json";
            var dataPath = root + $"{Path.DirectorySeparatorChar}Data";




            VolumeInfo v = new VolumeInfo("This is a new title", new List<string> { "me" }, "The WORST book");
            Items i = new Items("4534", "1456456345633", v);
            Book newBook = new Book(new Items[] { i });


            string json = JsonConvert.SerializeObject(newBook);

            /*
            string newFile = dataPath + "\\newBook.json";
            using (StreamWriter sw = new StreamWriter(newFile))
            {
                sw.WriteLine(json);

            }

            */

            var jsonString = string.Empty;
            using (StreamReader sr = new StreamReader(filePath))
            {
                jsonString = sr.ReadToEnd();

            }


            Book assassin = JsonConvert.DeserializeObject<Book>(jsonString);

           string title = assassin.Items[0].VolumeInfo.Title;

            Console.WriteLine(title);
        }
    }
}

