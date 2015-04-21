using System;
using Newtonsoft.Json;

namespace Tasky
{
	public class Message
	{
		
		public string Id { get; set; }

		[JsonProperty(PropertyName = "senderid")]
		public string SenderID { get; set; }

		[JsonProperty(PropertyName = "receiverid")]
		public string ReceiverID { get; set; }

		[JsonProperty(PropertyName = "content")]
		public string Content { get; set; }

		[JsonProperty(PropertyName = "isread")]
		public bool IsRead { get; set; }

		[JsonProperty(PropertyName = "order")]
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

