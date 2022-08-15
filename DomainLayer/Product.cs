using System.Collections.Generic;

namespace DomainLayer
{
    public class Product
    {
        //[Key]
        public long Id { get; set; }
        //[Required]
        //[MaxLength(100)]
        public string ProductName { get; set; }
        //[Required]
        public string ImageName { get; set; }
        //[Required]
        public string Description { get; set; }

        //public List<string> Tags { get; set; }


        //baraye ijade rabete m-n bayad yek jadvale vaset dashte bashim

        public List<UserProduct> UserProducts { get; set; }
    }
}