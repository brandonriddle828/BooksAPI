using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAPI.Models
{
    public class Items
    {
        public string Id { get; set; }
        public string Selflink { get; set; }
        public VolumeInfo VolumeInfo { get; set; }


        
        
        public Items(string id, string selflink, VolumeInfo volumeInfo)
        {
            this.Id = id;
            this.Selflink = selflink;
            this.VolumeInfo = volumeInfo;
        }
        
    }
}
