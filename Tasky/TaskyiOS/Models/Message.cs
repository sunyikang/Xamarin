using System;
using Newtonsoft.Json;

namespace Tasky
{
	public class Message
	{
		public string Id { get; set; }
		public string SenderID { get; set; }
		public string ReceiverID { get; set; }
		public string Content { get; set; }
		public bool IsRead { get; set; }
		public int Order { get; set; }

		public Message (string SenderID, string ReceiverID, string Content, int Order)
		{
			this.SenderID = SenderID;
			this.ReceiverID = ReceiverID;
			this.Content = Content;
			this.Order = Order;
		}
	}
}

