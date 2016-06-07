
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Project
{
	public class SpecialActivity : Android.Support.V4.App.Fragment
	{
		
		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			// Use this to return your custom view for this Fragment
			// return inflater.Inflate(Resource.Layout.YourFragment, container, false);

			//return base.OnCreateView (inflater, container, savedInstanceState);
			return inflater.Inflate(Resource.Layout.SpecialActivity,container,false);



		}

		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);

			// spinner for city
			Spinner spinner = View.FindViewById<Spinner> (Resource.Id.spinerCity1);

			spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs> (spinner_ItemSelected);
			var adapter = ArrayAdapter.CreateFromResource (
				Application.Context, Resource.Array.planets_array, Resource.Layout.SpinerItem);

			adapter.SetDropDownViewResource (Android.Resource.Layout.SimpleSpinnerDropDownItem);
			spinner.Adapter = adapter;

			// search button

			Button search = View.FindViewById<Button> (Resource.Id.btnsearch1);
			search.Click+= Search_Click;

		}

		void Search_Click (object sender, EventArgs e)
		{
			// your code here
		}

		private void spinner_ItemSelected (object sender, AdapterView.ItemSelectedEventArgs e)
		{
			Spinner spinner = (Spinner)sender;

			string toast = string.Format ("The city is {0}", spinner.GetItemAtPosition (e.Position));
			Toast.MakeText (Application.Context, toast, ToastLength.Long).Show ();
		}


	}
}

