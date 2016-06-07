using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V4.View;
using Android.Support.V4.App;
using System.Collections.Generic;
using Android.Runtime;
using Android.Support.Design.Widget;
using Java.Lang;

namespace Project
{
	
	[Activity (Label = "Project", Icon = "@mipmap/icon")]
	public class MainActivity : AppCompatActivity
	{


		private TabLayout tabLayout;
		private ViewPager viewPager;

		private int[] tabIcons = { 
			Resource.Drawable.SearchWhite,
			Resource.Drawable.BookmarkWhite,
			Resource.Drawable.ChristmasWhite,
			Resource.Drawable.MenuWhite
			
		};
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);


			// Get our button from the layout resource,
			// and attach an event to it
			viewPager=FindViewById<ViewPager>(Resource.Id.viewpager);
			setupViewPager (viewPager);



			tabLayout = FindViewById<TabLayout> (Resource.Id.sliding_tabs);
			tabLayout.SetupWithViewPager (viewPager);
			setupTabIcons ();
		}

		private void setupTabIcons()
		{
			tabLayout.GetTabAt (0).SetIcon(tabIcons[0]);
			tabLayout.GetTabAt (1).SetIcon(tabIcons[1]);
			tabLayout.GetTabAt (2).SetIcon(tabIcons[2]);
			tabLayout.GetTabAt (3).SetIcon(tabIcons[3]);
		}

		private Explore exploreFrg;
		private Featured featuredFrg;
		private More moreFrg;
		private Todo todoFrag;

		private void InditialFragment()
		{
			exploreFrg = new Explore ();
			featuredFrg = new Featured ();
			moreFrg = new More ();
			todoFrag = new Todo ();
		}
		public void setupViewPager(ViewPager viewPager)
		{
			InditialFragment ();
			ViewPagerAdapter adapter = new ViewPagerAdapter (SupportFragmentManager);
			adapter.addFragment (exploreFrg, "Explore");
			adapter.addFragment (featuredFrg, "Featured");
			adapter.addFragment (todoFrag, "To dos");
			adapter.addFragment (moreFrg, "More");
			viewPager.Adapter=adapter;
		}


	}
}


