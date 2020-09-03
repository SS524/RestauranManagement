using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantManagement.Models;

namespace RestaurantManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodItemController : ControllerBase
    {
        
        private readonly RestaurantContext _context;
        public FoodItemController(RestaurantContext context)
        {
            _context = context;
        }
        // GET: api/FoodItem
        [HttpGet]
        public IEnumerable<FoodItem> Get()
        {
            return _context.FoodItems.ToList();
        }

        // GET: api/FoodItem/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/FoodItem
        [HttpPost]
        public string Post([FromBody] FoodItem value)
        {
            _context.FoodItems.Add(value);
            _context.SaveChanges();
            return "Succes";
        }

        // PUT: api/FoodItem/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] FoodItem value)
        {
            FoodItem obj = _context.FoodItems.Find(id);
            obj.FoodName = value.FoodName;
            obj.FoodType = value.FoodType;
            obj.FoodPrice = value.FoodPrice;
            obj.IsAvailable = value.IsAvailable;
            obj.HomeDelivery = value.HomeDelivery;
            _context.SaveChanges();
            return "Successfully Updated";
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            FoodItem obj = _context.FoodItems.Find(id);
            _context.FoodItems.Remove(obj);
            _context.SaveChanges();
            return "Succesfully Deleted";
        }
    }
}
