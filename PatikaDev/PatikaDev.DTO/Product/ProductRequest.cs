namespace PatikaDev.DTO.Basket
{
    public class ProductRequest
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public string Image { get; set; }

        public string Barcode { get; set; }

        public int ProductCategoryId { get; set; }
    }

}
