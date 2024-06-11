using _11_MVC_ViewComponents.Models;
using Microsoft.AspNetCore.Mvc;

namespace _11_MVC_ViewComponents.ViewComponents
{
    public class ShoppingCartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var cartItems = new List<CartItem>()
            {
                new CartItem {ProductName = "Ürün 1", Price= 19.99},
                new CartItem {ProductName = "Ürün 2", Price= 21.99},
                new CartItem {ProductName = "Ürün 3", Price= 13.99},
                new CartItem {ProductName = "Ürün 4", Price= 15.99},
                new CartItem {ProductName = "Ürün 5", Price= 16.99},
            };

            var model = new ShoppingCartVM()
            {
                CartItems = cartItems,
                TotalPrice = CalculateTotalPrice(cartItems)
            };

            return View(model);
        }

        private double CalculateTotalPrice(List<CartItem> cartItems)
        {
            double totalPrice = 0;
            foreach (var item in cartItems)
            {
                totalPrice += item.Price;
            }
            return totalPrice;
        }
    }
}
