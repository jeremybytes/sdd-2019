using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using person_api.Models;

namespace person_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        IPeopleProvider provider;

        public PeopleController(IPeopleProvider provider)
        {
            this.provider = provider;
        }

        // GET api/people
        [HttpGet]
        public ActionResult<IEnumerable<Person>> Get()
        {
            return provider.GetPeople();
        }

        // GET api/people/5
        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            return provider.GetPeople().FirstOrDefault(p => p.Id == id);
        }
    }
}
