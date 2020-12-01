using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using API.Service.Models;


namespace API.Service.Controllers
{
    public class DefaultController : BasicApiController
    {
        [HttpPost, Route("api/cardgame/input")]
        public async Task<IHttpActionResult> GameInput(GameInput input)
        {
            if (input == null || string.IsNullOrEmpty(input.Table) || input.Hands.Any() == false)
            {
                return BadRequest();
            }

            return Ok(input);
        }
    }
}