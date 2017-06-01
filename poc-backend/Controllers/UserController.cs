using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using poc_backend.Models;


namespace poc_backend.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly Contexto _context;

        
        public UserController(Contexto contexto)
        {
            _context=contexto;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _context.Users;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public User Get(long id)
        {
            return _context.Users.Find(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]User item)
        {        

            _context.Users.Add(item);
            _context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]User value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
