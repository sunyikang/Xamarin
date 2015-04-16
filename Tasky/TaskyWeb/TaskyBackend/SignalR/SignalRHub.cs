using Microsoft.AspNet.SignalR;
using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskyBackend.SignalR
{
    public class SignalRHub : Hub
    {
        public ApiServices Services { get; set; }
        public string Send(string message) 
        {
            return "Hello from SignalR SignalHub";
        }
    }
}
