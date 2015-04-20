using Microsoft.WindowsAzure.Mobile.Service;

namespace TaskyMobileService.DataObjects
{
    public class User : EntityData
    {
        public string Name { get; set; }

        public string Password { get; set; }
    }
}