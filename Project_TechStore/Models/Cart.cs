using System;
using System.Collections.Generic;

namespace Project_TechStore.Models
{
    public partial class Cart
    {
        public Cart()
        {
            CartDetails = new HashSet<CartDetail>();
        }

        public int CartId { get; set; }
        public int? CustomerId { get; set; }
        public decimal? TotalPayment { get; set; }
        public int? SelectedProductCount { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<CartDetail> CartDetails { get; set; }
    }
}
