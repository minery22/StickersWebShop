using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StickersShop.Data.Models
{
    public class Sticker
    {
        public int id { set; get; }

        public string name { set; get; }

        public int price { set; get; }

        public string shortDesc { set; get; }

        public string img { set; get; }

        public bool isFavourite { set; get; }

        public int available { set; get; }
    
        public int categoryID { set; get; }
        
        public virtual Category Category { set; get; }

    }
}
