using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using scyllaela.Business;

namespace scyllaela.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScyllaController : ControllerBase
    {
        IStudBusiness _stud;
        public ScyllaController(IStudBusiness bs)
        {
            _stud=bs;
        }
        [HttpGet]
        public async Task<IActionResult> GetData()
        {
            // call method using await
            var res = await _stud.GetData();
            return Ok(res);
        }
    }
}
     