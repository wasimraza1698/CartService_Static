using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CartService.Models;

namespace CartService.Repositories
{
    public class CartItemRepo : IRepository
    {
        private static List<CartItem> cart = new List<CartItem>()
        {
            new CartItem(){CartItemID = 1,UserID = 2,MenuItemID=1},
            new CartItem(){CartItemID = 2,UserID = 2,MenuItemID=2},
            new CartItem(){CartItemID = 3,UserID = 2,MenuItemID=3},
            new CartItem(){CartItemID = 4,UserID = 3,MenuItemID=2}
        };

        public CartItem AddItem(CartItem item)
        {
            int index = cart.Count - 1;
            item.CartItemID = cart[index].CartItemID + 1;
            cart.Add(item);
            return item;
        }

        public List<CartItem> GetAll()
        {
            return cart;
        }

        public bool RemoveItem(int id)
        {
            CartItem item = cart.Find(i => i.CartItemID == id);
            return cart.Remove(item);
        }
    }
}
