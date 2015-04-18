using System;
using System.Collections.Generic;
using System.Linq;
using UIKit;
using MonoTouch.Dialog;
using Foundation;
using Tasky.AL;
using Tasky;
using Microsoft.WindowsAzure.MobileServices;

namespace Tasky.Screens
{
	// Here is a good place to learn View Controller in iOS: https://developer.apple.com/library/ios/featuredarticles/ViewControllerPGforiPhoneOS/Introduction/Introduction.html#//apple_ref/doc/uid/TP40007457
	// Here is a good start for Xamarin shortcuts: http://www.syntaxismyui.com/wp-content/uploads/2014/09/Xamarin-Studio-Keyboard-Shortcuts.pdf
	// Here is a good intruduction for MonoDialog: http://developer.xamarin.com/guides/ios/user_interface/monotouch.dialog/
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
					new StringElement ("Login", delegate { Login(); } ),
					new StringElement ("Register", delegate {
						Register(account.Value,password.Value);
					})
				},
			};
		}


		public void Login ()
		{
			/*
			if (BL.Managers.UserManager.IsValid (account.Value, password.Value)) {
				this.NavigationController.PopViewController (true);
			} else {
				account.Value = "";
				password.Value = "";

				new UIAlertView("Login", "Account or password wrong"
					, null, "ok", null).Show();
			}*/
		}

		public async void Register(string at, string pd){
			User user = new User (at, pd);
			try{
				await MobileServiceHelper.DefaultService.ServiceClient.GetTable<User>().InsertAsync(user);
			}
			catch(MobileServiceInvalidOperationException e){
				Console.WriteLine ("This is the bug"+e.Message);
				throw e;
			}

		}
	}
}

