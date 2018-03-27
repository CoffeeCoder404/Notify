using DataModel;
using System.Collections.Generic;
using System.Linq;
using DM = DomainModel.DTO;

namespace Repository
{
    public class MessageRepo
    {
        public List<DM.Message> GetMessages()
        {
            using (NotifyEntities db = new NotifyEntities())
            {
                return db.tblMessages
                    .Where(m => m.IsActive)
                     .Select((m) => new DM.Message
                     {
                         MessageID = m.tblMessageID,
                         Description = m.Description,
                         CreatedAt = m.CreatedAt,
                         ModifiedAt = m.ModifiedAt,
                     }).ToList();
            }
        }
    }
}
