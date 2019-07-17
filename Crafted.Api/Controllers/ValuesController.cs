using System.Collections.Generic;
using System.Linq;
using Crafted.Data;
using Microsoft.AspNetCore.Mvc;

namespace Crafted.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private CraftedContext Context { get; }

        public ValuesController(CraftedContext context)
        {
            Context = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<MenuItem>> Get()
        {
            var blogs = Context.MenuItems.ToList();
            return blogs;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
