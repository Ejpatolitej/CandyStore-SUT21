using System.ComponentModel.DataAnnotations;

namespace Candy_SUT21.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int ShoppingCartItemID { get; set; }
        public string ShoppingCartID { get; set; }
        public Candy Candy { get; set; }
        public int Amount { get; set; }
    }
}
