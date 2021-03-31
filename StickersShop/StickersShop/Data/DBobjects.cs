using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using StickersShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StickersShop.Data
{
    public class DBobjects
    {
        public static void Initial(AppDBcontent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));
            if (!content.Sticker.Any())
            {
                content.Sticker.AddRange(
                    new Sticker
                    {
                        name = "Капитан Америка",
                        price = 100,
                        shortDesc = "",
                        img = "/img/captain.png",
                        isFavourite = true,
                        available = 1,
                        Category = Categories["Marvel"]
                    },
                     new Sticker
                     {
                         name = "Танос",
                         price = 110,
                         shortDesc = "",
                         img = "/img/tanos.png",
                         isFavourite = true,
                         available = 1,
                         Category = Categories["Marvel"]
                     },
                      new Sticker
                      {
                          name = "Железный человек",
                          price = 102,
                          shortDesc = "",
                          img = "/img/im.png",
                          isFavourite = true,
                          available = 1,
                          Category = Categories["Marvel"]
                      },
                     new Sticker
                     {
                         name = "Бэтмен",
                         price = 150,
                         shortDesc = "",
                         img = "/img/b.png",
                         isFavourite = false,
                         available = 1,
                         Category = Categories["DC"]
                     },
                      new Sticker
                      {    
                          name = "Диана",
                          price = 90,
                          shortDesc = "",
                          img = "/img/diana.png",
                          isFavourite = false,
                          available = 1,
                          Category = Categories["DC"]
                      },
                    new Sticker
                    {
                        name = "Супермен",
                        price = 130,
                        shortDesc = "",
                        img = "/img/cl.png",
                        isFavourite = false,
                        available = 1,
                        Category = Categories["DC"]
                    }
                    );
            }
            content.SaveChanges();
        }
     
           
        public static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Marvel" , desc = "Наклейки киновслеленной Marvel"},
                        new Category { categoryName = "DC", desc = "Наклейки киновслеленной DC"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)   //каждый раз создаем переменную el , перебираем список list
                    {
                        category.Add(el.categoryName, el);
                    }
                }
                return category;
            }
        }
    }
}
