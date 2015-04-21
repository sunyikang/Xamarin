using System;
using Newtonsoft.Json;

namespace Tasky
{
	public class Message
	{
		
		public string Id { get; set; }

		[JsonProperty(PropertyName = "SenderID")]
		public string SenderID { get; set; }

		[JsonProperty(PropertyName = "ReceiverID")]
		public string ReceiverID { get; set; }

		[JsonProperty(PropertyName = "Content")]
		public string Content { get; set; }

		[JsonProperty(PropertyName = "IsRead")]
		public bool IsRead { get; set; }

		[JsonProperty(PropertyName = "Order")]
		public int Order { get; set; }

		public Message (string senderID, string receiverID, string content, int order)
		{
			this.SenderID = senderID;
			this.ReceiverID = receiverID;
			this.Content = content;
			this.Order = order;
		}
	}
}

