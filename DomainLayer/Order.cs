using System;
using System.Collections.Generic;

namespace DomainLayer
{
    public class Order
    {

        public long Id { get; set; }
        public long UserId { get; set; }
        public bool IsPay { get; set; }
        public DateTime FinallyDate { get; set; }
        public int Tag { get; set; }

        public User User { get; set; }

        public List<OrderItem> OrderItems { get; set; }            // to rabete chand lazem nist foreignkey moshakhas konim 

        public OrderAddress OrderAddress { get; set; }      //to rabete1-1 faghat too ye sar foreignkey midim uonam olaviat
    }                                                   // ba uoni hast ke zoodtar sakhte mishe
}