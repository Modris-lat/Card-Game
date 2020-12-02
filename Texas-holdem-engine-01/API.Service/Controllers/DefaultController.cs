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
        public DefaultController(IGetCards getCards, IGetHandValues getHandValues): base(getCards, getHandValues) { }
        [HttpPost, Route("api/cardgame/input")]
        public IHttpActionResult GameInput(GameInput input)
        {
            if (input == null || string.IsNullOrEmpty(input.Table) || input.Hands.Any() == false)
            {
                return BadRequest();
            }

            var cardLists = _getCards.ConvertInput(input);
            var getValues = _getHandValues.Calculate(cardLists.Item1, cardLists.Item2).ToList();
            return Ok(getValues);
        }
    }
}