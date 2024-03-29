﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace WebApiWithOData.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        [EnableQuery()]
        public ActionResult<IEnumerable<Student>> Get()
        {
            var resutl = new List<Student>
            {
                new Student{ Name = "Pradeep Raj Thapaliya", Address = "Kathmandu, Nepal" },
                new Student{ Name = "Hari Karki", Address = "Jhapa, Nepal"},
                new Student{ Name = "Binod Marikhu", Address = "Bhaktapur, Nepal"}
            };
            return resutl;
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

    public class Student
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

}
