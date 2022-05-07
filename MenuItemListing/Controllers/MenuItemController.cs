using Microsoft.AspNetCore.Mvc;
using MenuItemListing.Models;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MenuItemController : ControllerBase
    {
        private List<MenuItem> _menuItems = new List<MenuItem>
        {
            new MenuItem
            {
                Id = 1,
                Name = "Pizza",
                FreeDelivery = true,
                Price = 200,
                DateOfLaunch = DateTime.Now,
                Active = true
            }, 
            new MenuItem
            {
                Id = 2,
                Name = "Biriyani",
                FreeDelivery = false,
                Price = 300,
                DateOfLaunch = DateTime.Now,
                Active = true
            },
            new MenuItem
            {
                Id = 3,
                Name = "Fried Rice",
                FreeDelivery = false,
                Price = 150,
                DateOfLaunch = DateTime.Now,
                Active = true
            },
            new MenuItem
            {
                Id = 4,
                Name = "Chicken",
                FreeDelivery = true,
                Price = 200,
                DateOfLaunch = DateTime.Now,
                Active = false
            }
        };

        // GET: api/<MenuItemController>
        [HttpGet]
        public IEnumerable<MenuItem> Get()
        {
            return _menuItems;
        }

        // GET api/<MenuItemController>/5
        [HttpGet("{id}")]
        public MenuItem? Get(int id)
        {
            return _menuItems.Find(menuItem => menuItem.Id == id);
        }
       
    }
}
