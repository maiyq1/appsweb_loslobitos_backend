using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Infraestructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeniusController : ControllerBase
    {
        private IReservationDomain _reservationDomain;

        public GeniusController(IReservationDomain reservationDomain)
        {
            _reservationDomain = reservationDomain;
        }
        // GET: api/Genius
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _reservationDomain.GetAll();
            //return new string[] { "value1", "value2" };
        }

        // GET: api/Genius/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Genius
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Genius/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Genius/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}