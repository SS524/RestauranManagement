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
    public class FoodSellController : ControllerBase
    {
        private readonly RestaurantContext _context;
        public FoodSellController(RestaurantContext context)
        {
            _context = context;
        }
        // GET: api/FoodSell
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/FoodSell/5
        //[HttpGet("{id}", Name = "Get")]
        [HttpGet("{id}")]
        public IEnumerable<FoodSell> Get(int id)
        {
            IEnumerable<FoodSell> sells = _context.FoodSells.ToList();
            sells = from s in sells where s.FoodItemId == id select s;
            return sells;
        }

        // POST: api/FoodSell
        [HttpPost]
        public string Post([FromBody] FoodSell value)
        {
            _context.FoodSells.Add(value);
            _context.SaveChanges();
            return "Successfully Sell Details Added";

        }

        // PUT: api/FoodSell/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
