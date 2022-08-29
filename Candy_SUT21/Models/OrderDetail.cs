using System.ComponentModel.DataAnnotations;

namespace Candy_SUT21.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public int CandyID { get; set; }
        public Candy Candy { get; set; }

        public int Amount { get; set; }
        public decimal Price { get; set; }
    }
}
