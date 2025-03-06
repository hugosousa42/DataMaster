namespace DataMaster.Data.Entities
{
    public class Product
    {
        public required int ProductID { get; set; }

        public required string Name { get; set; }
        public required string ProductNumber { get; set; }
        public required string MakeFlag { get; set; }
        public required string FinishedGoodsFlag { get; set; }
        public string? Color { get; set; }

    }
}
