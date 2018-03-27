using Repository;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class MessageController : ApiController
    {
        MessageRepo _repo;
        public MessageController()
        {
            _repo = new MessageRepo();
        }
        public HttpResponseMessage GetMessages()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.GetMessages());
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
