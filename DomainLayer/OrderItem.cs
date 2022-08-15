namespace DomainLayer
{
    public class OrderItem
    {
        //[Key]
        public long Id { get; set; }
        public long OrderId { get; set; }
        public long UserProductId { get; set; }
        public long Price { get; set; }
        public long Count { get; set; }
        //[Required]
        //[MaxLength(20)]
        public string Color { get; set; }

        //public long OrderId { get; set; }             /*/*inja khodesj tashkhis mide foreignkey kodoome*/*/
        //public Order Order { get; set; }

        /*  [ForeignKey("OrderId")]  */           /*/*inja ma khodemoon  tain mikonim */
        public Order Order { get; set; }

        public UserProduct UserProduct { get; set; }
    }
}