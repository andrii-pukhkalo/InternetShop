namespace InternetShop.DAL.Entities
{
    public class Product
    {
        public int              Id          { get; set; }
        public string           Name        { get; set; }

        public ProductDetails   Details     { get; set; }

        public int?             CategiryId  { get; set; }
        public Category         Category    { get; set; }
    }
}
