using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CartService.Models;

namespace CartService.Repositories
{
    public interface IRepository
    {
        public CartItem AddItem(CartItem item);
        public List<CartItem> GetAll();
        public bool RemoveItem(int id);
    }
}
