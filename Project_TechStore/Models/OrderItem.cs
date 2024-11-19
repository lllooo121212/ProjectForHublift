using System;
using System.Collections.Generic;

namespace Project_TechStore.Models
{
    public partial class OrderItem
    {
        public OrderItem()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public string MessageForSeller { get; set; }
        public string ShippingAddress { get; set; }
        public int? VoucherId { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? ShippingFee { get; set; }
        public decimal? GrandTotal { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Voucher Voucher { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
