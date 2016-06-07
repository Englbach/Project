﻿
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
using Android.Support.V4.View;
using Android.Support.Design.Widget;

namespace Project
{
	public class Todo : Android.Support.V4.App.Fragment
	{
		private ViewPager viewPager;
		private TabLayout tablayout;

		private MainActivity mainActivity;
		private GoingFragment goingFrag;
		private InterestedFragment interestedFrag;
		private InvitedFragment invitedFrag;

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
			return inflater.Inflate(Resource.Layout.TodoLayout,container,false);
		}

		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);
			viewPager = View.FindViewById<ViewPager> (Resource.Id.viewpagerTodo);
			if (viewPager != null) {
				setupViewPager (viewPager);
			}


			tablayout = View.FindViewById<TabLayout> (Resource.Id.sliding_tabsTodo);
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
			goingFrag = new GoingFragment();
			interestedFrag = new InterestedFragment();
			invitedFrag = new InvitedFragment ();
		}

		public void setupViewPager(ViewPager viewPager)
		{
			InditialFragment ();
			ViewPagerAdapter adapter = new ViewPagerAdapter (mainActivity.SupportFragmentManager);
			adapter.addFragment (goingFrag, "Going");
			adapter.addFragment (interestedFrag, "Interested");
			adapter.addFragment (invitedFrag, "Invited");

			viewPager.Adapter=adapter;
		}
	}
}

