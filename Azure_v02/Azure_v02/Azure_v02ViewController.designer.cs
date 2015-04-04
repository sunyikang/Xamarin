// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace Azure_v02
{
	[Register ("Azure_v02ViewController")]
	partial class Azure_v02ViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton AddButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITableView ItemsTable { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton RefreshButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel TitleLable { get; set; }

		[Action ("Add:")]
		partial void Add (MonoTouch.Foundation.NSObject sender);

		[Action ("Refresh:")]
		partial void Refresh (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (AddButton != null) {
				AddButton.Dispose ();
				AddButton = null;
			}

			if (RefreshButton != null) {
				RefreshButton.Dispose ();
				RefreshButton = null;
			}

			if (TitleLable != null) {
				TitleLable.Dispose ();
				TitleLable = null;
			}

			if (ItemsTable != null) {
				ItemsTable.Dispose ();
				ItemsTable = null;
			}
		}
	}
}
