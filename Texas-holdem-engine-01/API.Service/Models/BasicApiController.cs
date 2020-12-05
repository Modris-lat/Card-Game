using System.Web.Http;
using Engine.Interfaces;

namespace API.Service.Models
{
    public class BasicApiController: ApiController
    {
        protected readonly IGetCards _getCards;
        protected readonly IGetHandValues _getHandValues;
        protected readonly IGetOutputResponse _getResponse;
        public BasicApiController(
            IGetCards getCards, IGetHandValues getHandValues, IGetOutputResponse getResponse)
        {
            _getCards = getCards;
            _getHandValues = getHandValues;
            _getResponse = getResponse;
        }
    }
}