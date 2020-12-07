using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using API.Service.Models;
using Engine.Interfaces;
using Engine.Models;


namespace API.Service.Controllers
{
    public class DefaultController : BasicApiController
    {
        public DefaultController(
            IGetCards getCards, IGetHandValues getHandValues, IGetOutputResponse getResponse):
            base(getCards, getHandValues, getResponse) { }
        [HttpPost, Route("api/cardgame/input")]
        public IHttpActionResult GameInput(GameInput input)
        {
            if (input == null || string.IsNullOrEmpty(input.Table) || input.Hands.Any() == false)
            {
                return BadRequest();
            }

            (List<Card>, List<Hand>) cardLists = _getCards.ConvertInput(input);
            List<Hand> getValues = _getHandValues.Calculate(cardLists.Item1, cardLists.Item2).ToList();
            IEnumerable<Response> getResponse = _getResponse.GetResponse(getValues);
            return Ok(getResponse);
        }
    }
}