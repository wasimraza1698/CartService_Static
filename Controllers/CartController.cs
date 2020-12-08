using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CartService.Models;
using CartService.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CartService.Controllers
{
    [ApiController]
    [Route("[Controller]/[Action]")]
    public class CartController : ControllerBase
    {
        private readonly IRepository _cartRepo;

        public CartController(IRepository cartRepo)
        {
            _cartRepo = cartRepo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return new OkObjectResult(_cartRepo.GetAll());
            }
            catch
            {
                return NoContent();
            }
        }

        [HttpPost]
        public IActionResult Add(CartItem item)
        {
            try
            {
                return Ok(_cartRepo.AddItem(item));
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IActionResult Remove(int id)
        {
            try
            {
                if(_cartRepo.RemoveItem(id))
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}