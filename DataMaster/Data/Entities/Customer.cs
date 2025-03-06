namespace DataMaster.Data.Entities
{
    public class Customer
    {
        public required int CustomerID{ get; set; }
        public int? PersonID{ get; set; }
        public int? StoreID{ get; set; }

        public int? TerritoryID { get; set; }

        public required string AccountNumber { get; set; }

        public required Guid Rowguid{ get; set; }

        public required DateTime ModifiedDate{ get; set; }
    }
}
