﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
    public class ProductTypes
    {
       
        public int Id { get; set; }
        [Required]
        [Display(Name ="Product name")]
        public string ProductType { get; set; }
    }
}
