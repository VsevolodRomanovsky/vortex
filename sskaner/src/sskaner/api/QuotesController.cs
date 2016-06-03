using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using sskaner.models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace sskaner.api
{
    [Route("api/[controller]")]
    public class QuotesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Quote> Get()
        {
            return new List<Quote> {
                new Quote {Id = 1, Content="happiness is not bla bla ...", Author="John"},
                new Quote {Id = 2, Content="the best way bla bla ...", Author="Dave"},
                new Quote {Id = 3, Content="If you want bla bla ...", Author="Nick"},
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
