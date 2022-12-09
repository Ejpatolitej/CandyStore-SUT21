using Candy_SUT21.Models;

namespace Candy_SUT21.ViewModels
{
    public class ShoppingCartViewModel
    {
        public Order Order { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public decimal ShoppingCartTotal { get; set; }
    }
}
