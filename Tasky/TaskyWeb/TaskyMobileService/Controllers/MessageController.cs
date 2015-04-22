using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using TaskyMobileService.DataObjects;
using TaskyMobileService.Models;
using TaskyMobileService.DTO;

namespace TaskyMobileService.Controllers
{
    public class MessageController : TableController<Message>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            TaskyMobileContext context = new TaskyMobileContext();
            DomainManager = new EntityDomainManager<Message>(context, Request, Services);
        }

        // GET tables/Message
        public IQueryable<MessageDTO> GetAllMessage()
        {
            return Query().Select(x => new MessageDTO() { 
                SenderID = x.Sender.Id,
                //ReceiverID = x.Receiver.Id,
                Content = x.Content,
                IsRead = x.IsRead,
                Order = x.Order
            }); 
        }

        // GET tables/Message/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<MessageDTO> GetMessage(string id)
        {
            var result = Lookup(id).Queryable.Select(x => new MessageDTO() {
                SenderID = x.Sender.Id,
                //ReceiverID = x.Receiver.Id,
                Content = x.Content,
                IsRead = x.IsRead,
                Order = x.Order
            });
            return SingleResult<MessageDTO>.Create(result);
        }

        // PATCH tables/Message/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Message> PatchMessage(string id, Delta<Message> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Message
        public async Task<IHttpActionResult> PostMessage(Message item)
        {
            Message current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Message/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteMessage(string id)
        {
             return DeleteAsync(id);
        }

    }
}