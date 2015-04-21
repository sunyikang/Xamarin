using Microsoft.WindowsAzure.Mobile.Service;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskyMobileService.DataObjects
{
    public class Message : EntityData
    {
        [ForeignKey("SenderID")]
        public virtual User SenderID { get; set; }
        [ForeignKey("ReceiverID")]
        public virtual User ReceiverID { get; set; }

        public string Content { get; set; }
        public bool IsRead { get; set; }
        public int Order { get; set; }
    }
}
