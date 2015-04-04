using System;
using System.Collections.Generic;
using Tasky.BL;

namespace Tasky.BL.Managers
{
	public static class UserLoginManager
	{
		static UserLoginManager ()
		{
			DAL.UserRepository.Init ();
		}

		public static Task GetTask(int id)
		{
			return DAL.TaskRepository.GetTask(id);
		}

		public static IList<Task> GetTasks ()
		{
			return new List<Task>(DAL.TaskRepository.GetTasks());
		}

		public static int SaveTask (Task item)
		{
			return DAL.TaskRepository.SaveTask(item);
		}

		public static int DeleteTask(int id)
		{
			return DAL.TaskRepository.DeleteTask(id);
		}

		public static bool IsValid( string name, string password )
		{
			return DAL.UserRepository.IsValid( name, password );
		}
	}
}

