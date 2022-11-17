using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAPI.Models
{
    public class VolumeInfo
    {

        public string Title { get; set; }
        public List<string> Authors { get; set; }
        public string Description { get; set; }

        public VolumeInfo(string title, List<string> authors, string description)
        {
            this.Title = title;
            this.Authors = authors;
            this.Description = description;
        }


    }
}
