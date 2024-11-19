using System;
using System.Collections.Generic;

namespace Project_TechStore.Models
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int? ProductId { get; set; }
        public int? OrderId { get; set; }
        public string ProductType { get; set; }
        public decimal UnitPrice { get; set; }
        public int? Quantity { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? VoucherId { get; set; }

        public virtual OrderItem Order { get; set; }
        public virtual Product Product { get; set; }
        public virtual Voucher Voucher { get; set; }
    }
}
