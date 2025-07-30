namespace MethShop.Models
{
    public class Item
    {
        

        public int id { get; set; }

        public string name { get; set; }

        public int price { get; set; }

        public string description { get; set; }

        public string fulltext { get; set; }

        public string image { get; set; }

        public int categoryID { get; set; }

        public Category category { get; set; }

        public Item()
        {
        }

        public Item(string name, int price, string description,
            string fulltext, string image, int categoryID)
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.fulltext = fulltext;
            this.image = image;
            this.categoryID = categoryID;
        }
    }
}
