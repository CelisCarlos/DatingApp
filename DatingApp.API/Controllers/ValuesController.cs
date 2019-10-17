using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public ValuesController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var allValues = _dataContext.Values.ToList();
            return Ok(allValues); /* 200 Response */
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var myValue = _dataContext.Values.FirstOrDefault(x => x.Id == id);
            return Ok(myValue); /* 204 Reponse IF myValue is null */
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}