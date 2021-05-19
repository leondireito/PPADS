using RecommendAPI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace RecommendAPI.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {

    }
}