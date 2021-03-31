using StickersShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StickersShop.Data.Interfaces
{
    public interface IallStickers
    {
        IEnumerable<Sticker> Stickers { get; }  //возвращает все обьекты Hqd
        IEnumerable<Sticker> GetFavStickers { get; }
        Sticker getObjectSticker(int Stickerid);  //возвращает id определенной HQD
    }
}
