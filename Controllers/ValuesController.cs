using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapi.Models;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IPostRepository repository;

        public ValuesController(IPostRepository repository)
        {
            Debug.WriteLine("messageeeeeeeeeeee");
            this.repository = repository;
        }
        
        
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
//            using (var database = new BloggingContext())
//            {
//                database.Blogs.Add(new Blog {Url = "newDataUrl"});
//                database.SaveChanges();
//                return new[] {"name", database.Blogs.First(x=>x.BlogId==2).Url};
//            }
            //return repository.Posts;
            return new[] {$"{repository.Blogs.First(x=>x.BlogId == 2).Url}", "repository.Blogs.First(x=>x.BlogId == 2).Url"};
            //return new string[] { "value1", "value2" };
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
