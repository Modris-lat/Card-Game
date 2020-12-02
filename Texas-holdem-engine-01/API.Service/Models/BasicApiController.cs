using System.Web.Http;
using Engine.Interfaces;

namespace API.Service.Models
{
    public class BasicApiController: ApiController
    {
        protected readonly IGetCards _getCards;
        protected readonly IGetHandValues _getHandValues;
        public BasicApiController(IGetCards getCards, IGetHandValues getHandValues)
        {
            _getCards = getCards;
            _getHandValues = getHandValues;
        }
    }
}