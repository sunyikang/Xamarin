using System;
using UIKit;
using Tasky.BL;
using MonoTouch.Dialog;

namespace Tasky
{
	// Note: this class is not used, since it has been realized in LoginScreen.
	// Meanwhile, I didn't found a good way to use it in LoginScreen.
	public class LoginDialog
	{
		public LoginDialog ()
		{
		}

		[Localize]
		[Entry("Account")]
		public string Account { get; set; }

		[Localize]
		[Entry("Password")]
		public string Password { get; set; }

		[Localize]
		[Section ("")]
		[OnTap ("Login")]
		[Alignment (UITextAlignment.Center)]
		public string Login;
	}
}

