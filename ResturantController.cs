using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResturantController : ControllerBase
    {
        List<Resturant> resturants = new List<Resturant>() { new Resturant(001, "Sweet and Fresh", "Tech Square", 10), new Resturant(002, "Moes", "Tech Square", 12), new Resturant(003,"Subway", "Tech Square", 11) };
       

        // GET: api/Resturant
        [HttpGet]
        public List<Resturant> Get()
        {
            return resturants;
        }

        // GET: api/Resturant/5
        [HttpGet("{id}", Name = "Get")]
        public Resturant Get(int id)
        {
            Resturant r = resturants.Find(f => f.id == id);
            return r;
        }

        // POST: api/Resturant
        [HttpPost]
        public List<Resturant> Post([FromBody] Resturant resturant)
        {
            resturants.Add(resturant);
            return resturants;
        }

        // PUT: api/Resturant/5
        [HttpPut("{id}")]
        public List<Resturant> Put(int id, [FromBody] Resturant resturant)
        {
            Resturant restToUpdate = resturants.Find(f => f.id == id);
            int index = resturants.IndexOf(restToUpdate);

            resturants[index].id = resturant.id;
            resturants[index].name = resturant.name;
            resturants[index].address = resturant.address;
            resturants[index].avgprice = resturant.avgprice;

            return resturants;
        }

        // DELETE: api/Resturant/5
        [HttpDelete("{id}")]
        public List<Resturant> Delete(int id)
        {
            Resturant restToDelete = resturants.Find(f => f.id == id);
            resturants.Remove(restToDelete);
            return resturants;
        }
    }
}
