﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebStore.Models
{
    public partial class Cart
    {
        public Cart()
        {
            CartDetail = new HashSet<CartDetail>();
        }

        public int CartId { get; set; }
        public int? CustomerId { get; set; }
        public decimal? TotalPayment { get; set; }
        public int? SelectedProductCount { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<CartDetail> CartDetail { get; set; }
    }
}
