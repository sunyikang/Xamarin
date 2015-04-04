using System;
using Tasky.BL.Contracts;
using Tasky.DL.SQLite;

namespace Tasky.BL
{
	public class User : BusinessEntityBase
	{
		public enum UserType : int {
			Teacher = 1,
			Student = 2,
			Null = 3
		}

		public User()
		{
		}

		public User ( string loginName, string password, UserType type )
		{
			this.LoginName = loginName;
			this.LoginPassword = password;
			Type = type;
		}

		public string LoginName { get; set; }
		public string LoginPassword { get; set; }
		public UserType Type { get; set; }
		public string message { get; set; }
	}
}

