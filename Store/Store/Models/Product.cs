using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Store.Models
{

    public class Product
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Image { get; set; }

        public string productColor { get; set; }
       
        public bool IsAvailable { get; set; }

        public int ProductTypeId { get; set; }

        [ForeignKey("ProductTypeId")]
        public ProductTypes productTypes { get; set; }


        public int SpecialTagId{ get; set; }

        [ForeignKey("SpecialTagId")]
        public SpecialTag SpecialTag { get; set; }

    }
}
