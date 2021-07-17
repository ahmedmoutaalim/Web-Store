﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Store.Models
{

    public class Products
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
       
        public string Image { get; set; }

        [Display(Name = "Product Color")]
        public string productColor { get; set; }

        [Display(Name = "Available")]
        [Required]
        public bool IsAvailable { get; set; }

        [Display(Name = "Product Type")]
        [Required]
        public int ProductTypeId { get; set; }

        [ForeignKey("ProductTypeId")]
        public ProductTypes productTypes { get; set; }

        [Display(Name="Special Tag")]
        [Required]
        public int SpecialTagId{ get; set; }

        [ForeignKey("SpecialTagId")]
        public SpecialTag SpecialTag { get; set; }

    }
}
