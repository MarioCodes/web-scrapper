namespace webscrapper.Model
{
    public class Product
    {
        public bool IsAvailable { get; set; }
        public string Url { get; set; }
        public string DiscountPrice { get; set; }
        public string FullPrice { get; set; }
        public string Discount { get; set; }
    }
}
