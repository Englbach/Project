﻿
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
using System.Threading.Tasks;
using Android.Util;

namespace Project
{
	[Activity (Theme = "@style/MyTheme.Splash",MainLauncher = true, NoHistory = true)]			
	public class SplashScreen : Activity
	{
		static readonly string TAG = "X:" + typeof(SplashScreen).Name;

		public override void OnCreate (Bundle savedInstanceState, PersistableBundle persistentState)
		{
			base.OnCreate (savedInstanceState,persistentState);

			// Create your application here
		}

		protected override void OnResume()
		{
			base.OnResume();

			Task startupWork = new Task(() => {
				Log.Debug(TAG, "Performing some startup work that takes a bit of time.");
				Task.Delay(10000);  // Simulate a bit of startup work.
				Log.Debug(TAG, "Working in the background - important stuff.");
			});

			startupWork.ContinueWith(t => {
				Log.Debug(TAG, "Work is finished - start Activity1.");
				StartActivity(new Intent(Application.Context, typeof(MainActivity)));
			}, TaskScheduler.FromCurrentSynchronizationContext());

			startupWork.Start();
		}
	}
}

