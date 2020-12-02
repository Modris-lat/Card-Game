using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using API.Service.Models;
using Engine.Interfaces;
using Engine.Models;


namespace API.Service.Controllers
{
    public class DefaultController : BasicApiController
    {
        public DefaultController(IGetCards getCards): base(getCards) { }
        [HttpPost, Route("api/cardgame/input")]
        public IHttpActionResult GameInput(GameInput input)
        {
            if (input == null || string.IsNullOrEmpty(input.Table) || input.Hands.Any() == false)
            {
                return BadRequest();
            }

            var result = _getCards.ConvertInput(input);
            return Ok(result.Item2);
        }
    }
}