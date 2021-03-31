using Microsoft.AspNetCore.Mvc;
using StickersShop.Data.Interfaces;
using StickersShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StickersShop.Controllers
{
    public class HomeController : Controller
    {
        private IallStickers _stickerRep;

        public HomeController(IallStickers iallstickers)
        {
            _stickerRep = iallstickers;
        }
        public ViewResult Index()
        {
            var homeSticker = new HomeViewModel
            {
                favSticker = _stickerRep.GetFavStickers
            };
            return View(homeSticker);
        }
    }
}
