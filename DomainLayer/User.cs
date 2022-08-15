using System;
using System.Collections.Generic;

namespace DomainLayer
{
    public class User
    {
        //[Key]
        public long Id { get; set; }

        //[MaxLength(100)]
        public string Name { get; set; }
        //[MaxLength(100)]
        public string Family { get; set; }
        //[Required]
        //[MaxLength(200)]
        public string Email { get; set; }

        public DateTime CreationDate { get; set; }

        //[NotMapped]
        public string FullName => $"{Name} {Family} ";


        public List<UserProduct> Products { get; set; }
        public List<Order> Orders { get; set; }
    }
}