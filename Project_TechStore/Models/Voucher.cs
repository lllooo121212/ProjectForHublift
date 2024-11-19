using System;
using System.Collections.Generic;

namespace Project_TechStore.Models
{
    public partial class Voucher
    {
        public Voucher()
        {
            OrderDetails = new HashSet<OrderDetail>();
            OrderItems = new HashSet<OrderItem>();
        }

        public int VoucherId { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal? MaxDiscountValue { get; set; }
        public DateTime? ExpiryDate { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
