using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        static List<string> depts = new List<string>() { "ops", "hr", "admin" };
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        [HttpGet]
        public List<string> Get()
        {
            return depts;
        }
        [HttpPost]
        public string Add(string name)
        {
            depts.Add(name);
            return name;
        }
        [HttpPut]
        public string Update(string oldname,string newname) {
            int ind = depts.IndexOf(oldname);
            if(ind >= 0)
            {
                depts[ind] = newname;
                return newname;
            }
            return null;
        }

        [HttpDelete]
        public ActionResult<string> Delete(string name)
        {
            if (depts.Contains(name))
            {
                return Ok(name);
            }
            else
            {
                return BadRequest("Deot not present");
            }
        }
    }
}
