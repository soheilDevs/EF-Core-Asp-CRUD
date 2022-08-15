namespace DomainLayer
{
    public class OrderAddress
    {
        public long Id { get; set; }
        public long OrderId { get; set; }           //foreign key
        //[Required(AllowEmptyStrings = false)]
        //[MaxLength(100)]
        public string City { get; set; }
        //[Required]
        //[MaxLength(1000)]
        public string Address { get; set; }

        public Order Order { get; set; }
    }
}