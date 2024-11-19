using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebStore.Models
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public DateTime? CommentDate { get; set; }
        public string CommentContent { get; set; }
        public int? OrderId { get; set; }

        public virtual OrderItem Order { get; set; }
    }
}
