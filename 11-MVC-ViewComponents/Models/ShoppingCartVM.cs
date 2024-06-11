namespace _11_MVC_ViewComponents.Models
{
    public class ShoppingCartVM
    {
        public List<CartItem> CartItems { get; set; } // Sepet öğelerini içeren liste
        public double TotalPrice { get; set; } // Toplam fiyat.
    }
}
