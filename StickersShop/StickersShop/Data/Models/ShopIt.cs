using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StickersShop.Data.Models
{
    public class ShopIt
    {
        public int id { get; set; }
        public Sticker sticker { get; set; }
        public int price { get; set; }
        public string shopItemId { get; set; }
    }
}
