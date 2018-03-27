using DomainModel.DTO;
using System.Collections.Generic;

namespace DomainModel
{
    public class UiInteraction
    {
        SyncAPI api;
        public UiInteraction()
        {
            api = new SyncAPI("http://localhost:63103/api/", null);
        }

        public List<Message> GetDetails(string route)
        {
            return api.Get<List<Message>>(route).GetAwaiter().GetResult();
        }
    }
}
