namespace Supermarket.api.Domain.Models
{
    public class Product
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public short QuantityInPackage {get; set;}
        public EUnitOfMeasurement UnitOfMeasurement {get; set;}
        //tells us how many units of product we have in one pack?

        public int CategoryId {get; set;}
        public Category Category {get; set;}
    }

}