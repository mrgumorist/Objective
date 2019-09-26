using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Objective.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ObjectiveController : ControllerBase
    {
        private readonly ObjectiveContext db;
        public ObjectiveController(ObjectiveContext _db)
        {
            db = _db;
        }
        // GET api/values
        [HttpGet]
        public object GetSpendings()
        {
            return db.Tasks.Include(x => x.Category).Select(x => new
            {
                Name = x.Name,
                IsComplited = x.IsCompleted,
                timeOfRealizing = x.timeOfRealizing,
                ID = x.Id,
                Description = x.Description,
                Category = x.Category.Name
            }).ToList();
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
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
