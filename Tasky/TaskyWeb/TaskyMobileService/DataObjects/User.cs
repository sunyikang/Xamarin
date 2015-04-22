using Microsoft.WindowsAzure.Mobile.Service;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskyMobileService.DataObjects
{
    public class User : EntityData
    {
        public string Name { get; set; }

        public string Password { get; set; }

        public virtual ICollection<Message> SentMsgs { get; set; }

        public virtual ICollection<Message> ReceivedMsgs { get; set; }
    }
}