using Microsoft.WindowsAzure.Mobile.Service;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskyMobileService.DataObjects
{
    public class Message : EntityData
    {
        
        [ForeignKey("SenderID")]
        public virtual User Sender { get; set; }
    }
}
