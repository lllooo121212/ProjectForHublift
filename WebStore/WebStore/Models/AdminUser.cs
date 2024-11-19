using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebStore.Models
{
    public partial class AdminUser
    {
        public int AdminId { get; set; }
        public string AdName { get; set; }
        public string RoleUser { get; set; }
        public string PasswordUser { get; set; }
    }
}
