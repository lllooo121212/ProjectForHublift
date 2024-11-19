using System;
using System.Collections.Generic;

namespace Project_TechStore.Models
{
    public partial class Product
    {
        public Product()
        {
            CartDetails = new HashSet<CartDetail>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; } = null;
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
        public virtual ICollection<CartDetail> CartDetails { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
