using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAPI.Models
{
    public class Book
    {

        public Items[] Items { get; set;}


            public Book(Items[] items)
            {
                this.Items = items;
            }

        
        public Book()
        {
            Items = new Items[1];
        }


        public override string ToString()
        {
            string bookName = "";
            bookName += $"ID: {Items[0].Id}\n\n";
            bookName += $"SelfLink: {Items[0].Selflink}\n\n";
            bookName += $"Title: {Items[0].VolumeInfo.Title}\n\n";
            bookName += $"Authors: {String.Join(", ", Items[0].VolumeInfo.Authors)}\n\n";
            bookName += $"Description: {Items[0].VolumeInfo.Description}\n\n";
 

            return bookName;
        }



    }
}
