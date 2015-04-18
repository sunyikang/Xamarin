using System;

namespace Tasky
{
	public class User 
	{
		//public int Id { get; set;}
		public string Name { get; set;}
		public string Password { get; set;}

		public int id { get; set;}

		public User (string name, string password)
		{
			this.Name = name;
			this.Password = password;
			//this.id = id;
		}
	}
}

