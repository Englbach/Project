
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
	public class TimeBuget : Android.Support.V4.App.Fragment
	{
		private MainActivity mainActivity;
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
			return inflater.Inflate(Resource.Layout.TimeBugetLayout,container,false);
		}

		[Obsolete ("deprecated")]
		public override void OnAttach (Android.App.Activity activity)
		{
			mainActivity = (MainActivity) activity;
			base.OnAttach (activity);
		}

		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);


			//Seach button
			Button btnSearch = View.FindViewById<Button> (Resource.Id.btnsearch);
			btnSearch.Click+= BtnSearch_Click;


			// This is Start Date Time

			Button start_time = View.FindViewById<Button> (Resource.Id.DateTimeStart);
			start_time.Text = "Start \n" + DateTime.Now.ToString ();
			// Set current time
			start_time.Click+= (object sender, EventArgs e) => 
			{
				DatePickerVM frag = DatePickerVM.NewInstance(delegate(DateTime time)
					{
						start_time.Text="Start \n" +  time.ToLongDateString();
					});
				frag.Show(mainActivity.FragmentManager,DatePickerVM.TAG);
			
			};

			// THis is End Date Time
			Button end_time=View.FindViewById<Button>(Resource.Id.DateTimeEnd);

			// Set next time
			end_time.Click+= (object sender, EventArgs e) => 
			{
				DatePickerVM frag = DatePickerVM.NewInstance(delegate(DateTime time)
					{
						end_time.Text="End \n" + time.ToLongDateString();
					});
				frag.Show(mainActivity.FragmentManager,DatePickerVM.TAG);
			};

			// THis is the city category
			Spinner spinner = View.FindViewById<Spinner> (Resource.Id.spinerCity);

			spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs> (spinner_ItemSelected);

			var adapter = ArrayAdapter.CreateFromResource (
				Application.Context, Resource.Array.planets_array, Resource.Layout.SpinerItem);

			adapter.SetDropDownViewResource (Android.Resource.Layout.SimpleSpinnerDropDownItem);
			spinner.Adapter = adapter;
		}

		private void spinner_ItemSelected (object sender, AdapterView.ItemSelectedEventArgs e)
		{
			Spinner spinner = (Spinner)sender;

			string toast = string.Format ("The city is {0}", spinner.GetItemAtPosition (e.Position));
			Toast.MakeText (Application.Context, toast, ToastLength.Long).Show ();
		}

		void BtnSearch_Click (object sender, EventArgs e)
		{
			Intent intent = new Intent (this.Activity, typeof(ResultsActivity));


			StartActivity(intent);
		}

	
	}
}

