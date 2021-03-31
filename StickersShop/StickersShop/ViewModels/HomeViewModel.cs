using StickersShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StickersShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Sticker> favSticker { get; set; }
    }
}
