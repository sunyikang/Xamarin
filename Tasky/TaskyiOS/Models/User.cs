using System;
using Newtonsoft.Json;

namespace Tasky
{
	public class User 
	{
		public string Id { get; set;}

		[JsonProperty(PropertyName = "name")]
		public string Name { get; set;}

		[JsonProperty(PropertyName = "password")]
		public string Password { get; set;}

		public User (string name, string password)
		{
			this.Name = name;
			this.Password = password;
		}
	}
}

