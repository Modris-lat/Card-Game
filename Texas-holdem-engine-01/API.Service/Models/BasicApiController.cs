using System.Web.Http;
using Engine.Interfaces;

namespace API.Service.Models
{
    public class BasicApiController: ApiController
    {
        protected readonly IGetCards _getCards;
        public BasicApiController(IGetCards getCards)
        {
            _getCards = getCards;
        }
    }
}