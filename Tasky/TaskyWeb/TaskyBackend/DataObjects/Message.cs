using Microsoft.WindowsAzure.Mobile.Service;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskyBackend.DataObjects
{
    public class Message : EntityData
    {
        public string Content { get; set; }
        public bool IsSent { get; set; }

        [ForeignKey("SenderID")]
        public virtual User Sender {get;set;}
        
        [ForeignKey("ReceiverID")]
        public virtual User Receiver {get;set;}
    }
}
