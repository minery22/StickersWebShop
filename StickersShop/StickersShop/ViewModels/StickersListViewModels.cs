using StickersShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StickersShop.ViewModels
{
    public class StickersListViewModels
    {
        public IEnumerable<Sticker> Allstickers { get; set; }
        public IEnumerable<Category> StickerCategory { get; set; }
    }
}
