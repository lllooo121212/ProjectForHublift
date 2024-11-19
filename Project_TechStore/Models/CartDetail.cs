using System;
using System.Collections.Generic;

namespace Project_TechStore.Models
{
    public partial class CartDetail
    {
        public int CartDetailId { get; set; }
        public int? ProductId { get; set; }
        public int? CartId { get; set; }
        public string ProductType { get; set; }
        public decimal UnitPrice { get; set; }
        public int? Quantity { get; set; }
        public decimal? TotalAmount { get; set; }
        public string Status { get; set; }

        public virtual Cart Cart { get; set; }
        public virtual Product Product { get; set; }
    }
}
