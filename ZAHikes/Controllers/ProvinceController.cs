using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZAHikes.Data;

namespace ZAHikes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinceController : ControllerBase
    {
        private readonly ZAHikeDBContext dbContext;

        public ProvinceController (ZAHikeDBContext dBContext)
        {
            dbContext = dBContext;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var province = dbContext.Provinces.ToList();

            return Ok(province);
        }
    }
}
