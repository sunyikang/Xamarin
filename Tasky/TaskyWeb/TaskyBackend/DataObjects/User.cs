using Microsoft.WindowsAzure.Mobile.Service;

namespace TaskyBackend.DataObjects
{
    public class User : EntityData
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
