using Microsoft.WindowsAzure.MobileServices;

namespace Tasky
{
	public class MobileServiceHelper
	{
		static MobileServiceHelper instance = new MobileServiceHelper();

		const string applicationURL = "https://taskybackend.azure-mobile.net/";
		const string applicationKey = "cFkLIXnUwMmaBXijvAcrYxCzJlmkZW54";

		private readonly MobileServiceClient _client;

		private MobileServiceHelper()
		{
			// Initialize the Portable Class Libraries so the correct version of
			// Microsoft.WindowsAzure.Mobile.Ext is loaded
			CurrentPlatform.Init();

			// Initialize the Mobile Service client with your URL and key
			_client = new MobileServiceClient(applicationURL, applicationKey);
		}

		public MobileServiceClient ServiceClient { get { return _client; } }
		public static MobileServiceHelper DefaultService
		{
			get
			{
				return instance;
			}
		}
	}
}