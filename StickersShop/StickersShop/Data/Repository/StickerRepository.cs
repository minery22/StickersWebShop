using Microsoft.EntityFrameworkCore;
using StickersShop.Data.Interfaces;
using StickersShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StickersShop.Data.Repository
{
    public class StickerRepository : IallStickers
    {

        private readonly AppDBcontent DBcontent;

        public StickerRepository(AppDBcontent appDBcontent)
        {
            this.DBcontent = appDBcontent;
        }

        public IEnumerable<Sticker> Stickers => DBcontent.Sticker.Include(c => c.Category);

        public IEnumerable<Sticker> GetFavStickers => DBcontent.Sticker.Where(p => p.isFavourite).Include(c => c.Category);
        public Sticker getObjectSticker(int Stickerid) => DBcontent.Sticker.FirstOrDefault(p => p.id == Stickerid);
    }
}
