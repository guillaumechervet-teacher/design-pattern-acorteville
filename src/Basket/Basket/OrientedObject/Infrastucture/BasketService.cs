using System.Collections.Generic;
using Basket.Domain;

namespace Basket.OrientedObject.Infrastucture
{
    public class BasketService
    {
        public class BasketService
        {
            public Basket2 GetBasket(IList<BasketLineArticle> basketLineArticles)
            {
                var list = new List<BasketLine>();
                var adb = new ArticleDatabaseJson();
                foreach (var article in basketLineArticles)
                {
                    var articleData = adb.(article.Id);
                    list.Add(new BasketLine(new Article(adb.price, adb.category), article.Number));

                }

                return new Basket2(list);
            }
        }
    }
}