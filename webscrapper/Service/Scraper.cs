using HtmlAgilityPack;
using webscrapper.Model;

namespace webscrapper.Service
{
    public static class Scraper
    {
        public static async Task<Product> GetProduct(string uri)
        {
            var product = new Product() { Url = uri};

            var web = new HtmlWeb();
            HtmlDocument html = await web.LoadFromWebAsync(product.Url);
            HtmlNode htmlString = html.DocumentNode;

            var discountPriceTag = html.GetElementbyId("pdp-price-current-integer");
            string discountPriceValue = discountPriceTag.InnerText;

            var fullPriceTag = html.GetElementbyId("pdp-price-discount").SelectNodes("//span");
            // string fullPriceValue = fullPriceTag.InnerText;

            var discountTag = html.GetElementbyId("pdp-price-discount");
            string discountValue = discountTag.InnerText;

            product.DiscountPrice = discountPriceValue;
            product.Discount = discountValue;

            return product;
        }
    }
}
