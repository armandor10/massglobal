using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployedController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<Object> Get()
        {
            var employes = new Employed().getEmployes();
            return employes;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Object> Get(int id)
        {
            var employes = new Employed().getEmployed(id);
            return employes;
        }
    }
}
