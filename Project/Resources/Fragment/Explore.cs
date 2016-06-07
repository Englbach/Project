
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
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V7.App;

namespace Project
{
	public class Explore : Android.Support.V4.App.Fragment
	{
		private TabLayout tablayout;
		private ViewPager viewPager;
		private TimeBuget timeBuget;
		private SpecialActivity specialActivity;
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
			return inflater.Inflate(Resource.Layout.ExploreLayout,container,false);


		}

		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);

			viewPager = View.FindViewById<ViewPager> (Resource.Id.viewpagerExplore);
			if (viewPager != null) {
				setupViewPager (viewPager);
			}


			tablayout = View.FindViewById<TabLayout> (Resource.Id.sliding_tabsExplore);
			tablayout.SetupWithViewPager (viewPager);



		}



		[Obsolete ("deprecated")]
		public override void OnAttach (Android.App.Activity activity)
		{
			mainActivity = (MainActivity) activity;
			base.OnAttach (activity);
		}

		private void InditialFragment()
		{
			timeBuget = new TimeBuget ();
			specialActivity = new SpecialActivity ();
		}

		public void setupViewPager(ViewPager viewPager)
		{
			InditialFragment ();
			ViewPagerAdapter adapter = new ViewPagerAdapter (mainActivity.SupportFragmentManager);
			adapter.addFragment (timeBuget, "Time Buget");
			adapter.addFragment (specialActivity, "Special Activity");

			viewPager.Adapter=adapter;
		}

	}
}

