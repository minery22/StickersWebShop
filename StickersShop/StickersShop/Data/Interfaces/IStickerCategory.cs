using StickersShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StickersShop.Data.Interfaces
{
    public interface IStickerCategory
    {
        IEnumerable<Category> Allcategories { get; }
    }
}
