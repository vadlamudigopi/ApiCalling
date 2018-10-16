using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Models;
using WebApplication24.Connec;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication24.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Admin>> Getadmi(int adminId)
        {
            Conn mysql = new Conn();
            return mysql.ml_admins();
        }
        [HttpGet("getemotion")]
        public ActionResult<IEnumerable<Emotion>> Getemo()
        {
            Conn mysql = new Conn();
            return mysql.ml_emotions();
        }
        [HttpGet("getschool")]
        public ActionResult<IEnumerable<School>> Getsch()
        {
            Conn mysql = new Conn();
            return mysql.ml_schools();
        }
        [HttpGet("getuser")]
        public ActionResult<IEnumerable<User>> Getuser()
        {
            Conn mysql = new Conn();
            return mysql.ml_users();
        }
        [HttpGet("getsection")]
        public ActionResult<IEnumerable<Section>> Getsec()
        {
            Conn mysql = new Conn();
            return mysql.ml_sections();
        }
        [HttpGet("getvideo")]
        public ActionResult<IEnumerable<Video>> Getvideo()
        {
            Conn mysql = new Conn();
            return mysql.ml_videos();
        }
        [HttpGet("getclass")]
        public ActionResult<IEnumerable<Class>> Getclass()
        {
            Conn mysql = new Conn();
            return mysql.ml_classes();
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
            Conn mysql = new Conn();
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
