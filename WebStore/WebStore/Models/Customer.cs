﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebStore.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Cart = new HashSet<Cart>();
            OrderItem = new HashSet<OrderItem>();
        }

        public int CustomerId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string FullName { get; set; }
        public string PasswordHash { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
