using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    public class Add : Controller
    {
        // GET api/Add
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/Add/5/5
        [HttpGet("{num1}{num2}")]
        public int Get(int num1, int num2)
        {
            return num1+num2;
        }

        // POST api/Add
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/Add/5
        [HttpPut("{num1}")]
        public void Put(int num1, [FromBody]string value)
        {
        }

        // DELETE api/Add/5
        [HttpDelete("{sum}")]
        public void Delete(int sum)
        {
        }
    }
}
