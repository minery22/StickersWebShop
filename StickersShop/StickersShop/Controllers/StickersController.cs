using Microsoft.AspNetCore.Mvc;
using StickersShop.Data.Interfaces;
using StickersShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StickersShop.Controllers
{
    public class StickersController : Controller
    {
        private readonly IallStickers _allSticker;    //*переменные на интерфейсы
        private readonly IStickerCategory _allCategory; //*

        public StickersController(IallStickers IallSticker, IStickerCategory IallCategoty)   //записываем данные в переменные _allHqds _allCategory через конструктор
        {
            _allSticker = IallSticker;
            _allCategory = IallCategoty;
        }

        public ViewResult List()       //ViewResult возвращает целую html страницу
        {
            ViewBag.Title = "Страница Наклеек";
            StickersListViewModels obj = new StickersListViewModels();
            obj.Allstickers = _allSticker.Stickers;
            obj.StickerCategory = _allCategory.Allcategories;
            return View(obj);
        }
    }
}
