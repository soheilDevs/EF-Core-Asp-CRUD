using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer
{
    public class UserProduct
    {
        //[Key]
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long SellerId { get; set; }
        public long Price { get; set; }
        //[Required]
        //[MaxLength(50)]
        public string Color { get; set; }

        //dar table vaset bayad yek rabete 1 ba har jadval dashte bashim va dar jadval ha list dashte bashim (1-n beyne harkodam)

        /*[ForeignKey("ProductId")] */      // boodo naboodesh mohem nist chon esma yekie
        public Product Product { get; set; }
        //[ForeignKey("SellerId")]
        public User User { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}