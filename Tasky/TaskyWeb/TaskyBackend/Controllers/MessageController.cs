﻿using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using TaskyBackend.DataObjects;
using TaskyBackend.Models;

namespace TaskyBackend.Controllers
{
    public class MessageController : TableController<Message>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<Message>(context, Request, Services);
        }

        // GET tables/Message
        public IQueryable<MessageDTO> GetAllMessage()
        {
            return Query().Select(x => new MessageDTO() 
            {
                SenderID = x.Sender.Id,
                ReceiverID = x.Receiver.Id,
                Content = x.Content,
                IsSent = x.IsSent
            }); 
        }

        // GET tables/Message/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<MessageDTO> GetMessage(string id)
        {
            var result = Lookup(id).Queryable.Select(x => new MessageDTO() {
                SenderID = x.Sender.Id,
                ReceiverID = x.Receiver.Id,
                Content = x.Content,
                IsSent = x.IsSent
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