using System;
using Newtonsoft.Json;

namespace Tasky
{
	public class Message
	{
		public string Id { get; set;}

		public Message ()
		{
		}

		public virtual User Sender { get; set; }
	}
}

