using System;
using System.Collections.Generic;
using Tasky.BL;

namespace Tasky.BL.Managers
{
	public static class UserManager
	{
		static UserManager ()
		{
			DAL.UserRepository.Init ();
		}

		public static bool IsValid( string name, string password )
		{
			return DAL.UserRepository.IsValid( name, password );
		}
	}
}

