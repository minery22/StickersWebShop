using StickersShop.Data.Interfaces;
using StickersShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StickersShop.Data.Repository
{
    public class CategoryRepository : IStickerCategory        //реализация интерфейса Категории
    {
        private readonly AppDBcontent DBContent;    //обьект , для получения данных из БД

        public CategoryRepository(AppDBcontent appDBcontent)   // конструктор устанавливает значения в переменную(объект) AppDBcontent
        {
            this.DBContent = appDBcontent;
        }

        public IEnumerable<Category> Allcategories => DBContent.Category;         //функция берет данные из объекта appDBcontent - именно Категории
    }
}
