namespace Basket.Domain
{
    public class Article
    {
        private readonly int _price;
        private readonly string _category;

        public Article(int price, string category)
        {
            _price = price;
            _category = category;
        }

        public int Calculate()
        {
            return 0;
        }
    }
}