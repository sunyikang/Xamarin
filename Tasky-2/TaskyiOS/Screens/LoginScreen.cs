using System;
using System.Collections.Generic;
using System.Linq;
using UIKit;
using MonoTouch.Dialog;
using Foundation;
using Tasky.AL;
using Tasky.BL;

namespace Tasky.Screens
{
	public class LoginScreen : DialogViewController 
	{
		EntryElement account = new EntryElement ("Login", "enter", "s");
		EntryElement password = new EntryElement ("Password", "enter", "s", true);

		public LoginScreen() : base (UITableViewStyle.Plain, null)
		{
			Initialize ();
		}

		protected void Initialize()
		{
			Root = new RootElement ("Login") 
			{
				new Section () 
				{
					account,
					password,
					new StringElement ("Login", delegate { Login(); } )
				},
			};
		}


		public void Login ()
		{
			if (BL.Managers.UserManager.IsValid (account.Value, password.Value)) {
				this.NavigationController.PopViewController (true);
			} else {
				account.Value = "";
				password.Value = "";

				new UIAlertView("Login", "Account or password wrong"
					, null, "ok", null).Show();
			}
		}
	}
}

