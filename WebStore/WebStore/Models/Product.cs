using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebStore.Models
{
    public partial class Product
    {
        public Product()
        {
            CartDetail = new HashSet<CartDetail>();
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public bool? IsFavorite { get; set; }
        public decimal Price { get; set; }
        public int? VoucherListId { get; set; }
        public decimal? Rating { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
        public string ImageList { get; set; }
        public int? CommentListId { get; set; }
        public int? CategoryId { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<CartDetail> CartDetail { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
