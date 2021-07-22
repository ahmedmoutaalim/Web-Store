using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Orders
    {
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Order N")]
        public string OrderN { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Phone N")]
        public string PhoneN{ get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Adress { get; set; }

        public DateTime OrderDate { get; set; }

        public List<OrdersDetail> ordersDetails { get; set; }


    }
}
