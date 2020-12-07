using System.Collections.Generic;
using System.Linq;
using Engine.Interfaces;
using Engine.Models;

namespace Engine.Services
{
    public class GetOutputResponse: IGetOutputResponse
    {
        public IEnumerable<Response> GetResponse(IEnumerable<Hand> hands)
        {
            var responseList = new List<Response> { };
            var ordered = hands.OrderBy(hand => hand.HandStrength);
            var groups = ordered.GroupBy(hand => hand.HandStrength);
            foreach (var group in groups)
            {
                var handList = group.ToList();
                foreach (var hand in handList)
                {
                    responseList.Add(new Response(hand));
                }
            }

            return responseList;
        }
    }
}
