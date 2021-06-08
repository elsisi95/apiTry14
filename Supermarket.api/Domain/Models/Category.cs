using System.Collections.Generic;

namespace Supermarket.api.Domain.Models{

    public class Category
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public IList<Product> Products {get; set;} = new List<Product>();
        //will be used by entity framework core
    }
}