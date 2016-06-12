
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Facebook.Login.Widget;
using Xamarin.Facebook;
using Xamarin.Facebook.Login;

namespace Project
{
	[Activity (Label = "LoginActivity")]			
	public class LoginActivity : Activity
	{
		ICallbackManager callbackManager;
		LoginButton loginButton;
		protected override void OnCreate (Bundle savedInstanceState)
		{
			
			base.OnCreate (savedInstanceState);
			FacebookSdk.SdkInitialize (Application.Context);
			// Create your application here
			SetContentView(Resource.Layout.LoginLayout);


			callbackManager = CallbackManagerFactory.Create ();

			loginButton = FindViewById<LoginButton> (Resource.Id.btnloginbyfacebook);
			/*

			LoginManager.Instance.RegisterCallback (callbackManager, new IFacebookCallback<LoginResult> ()
				{
				}
			);
			loginButton.SetReadPermissions("user_friends");
			loginButton.SetReadPermissions("public_profile");
			loginButton.SetReadPermissions("email");
			loginButton.SetReadPermissions("user_birthday");

*/
		}

		//public IFacebookCallback<LoginResult> nFacebookCallback= new IFacebookCallback<LoginResult>()
		//{
			
		//}




	}
}

