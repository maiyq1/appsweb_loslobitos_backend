using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Infraestructure;
using Infraestructure.Context;
using Infraestructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeniusController : ControllerBase
    {
        private IReservationInfraestructure _reservationInfraestructure;
        private IReservationDomain _reservationDomain;

        public GeniusController(IReservationInfraestructure reservationInfraestructure, IReservationDomain reservationDomain)
        {
            _reservationInfraestructure = reservationInfraestructure;
            _reservationDomain = reservationDomain;
        }
        // GET: api/Genius
        [HttpGet]
        public List<Reservation> Get()
        {
            return _reservationInfraestructure.GetAll();
        }

        // GET: api/Genius/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST (CREATE): api/Genius
        [HttpPost]
        public void Post([FromBody] string value)
        {
            _reservationDomain.Create(value);
        }

        // PUT: api/Genius/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            _reservationDomain.Update(id, value);
        }

        // DELETE: api/Genius/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _reservationDomain.Delete(id);
        }
    }
}
