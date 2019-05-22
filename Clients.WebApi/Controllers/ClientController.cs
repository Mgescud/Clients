using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Clients.Core;
using Clients.Core.Model;

namespace Clients.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ClientService _service;
        // GET api/values
        [HttpGet("{id}")]
        public ActionResult<Client> Get(Guid id)
        {

            return _service.ListById(id);
        }

        [HttpGet]
        public ActionResult<List<Client>> GetAll()
        {

            return _service.ListAll();
        }
       
        // GET api/values/5
  

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Client value)
        {
            _service.Add(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Client value)
        {
            _service.Update(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id, [FromBody] Client value)
        {
            _service.Delete(value);
        }
    }
}
