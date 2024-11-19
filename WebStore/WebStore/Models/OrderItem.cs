using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebStore.Models
{
    public partial class OrderItem
    {
        public OrderItem()
        {
            Comment = new HashSet<Comment>();
        }

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public string MessageForSeller { get; set; }
        public string ShippingAddress { get; set; }
        public int? VoucherId { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? ShippingFee { get; set; }
        public decimal? GrandTotal { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Voucher Voucher { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
    }
}
