
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
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Graphics.Drawables;

namespace Project
{
	[Activity (Label = "ResultsActivity")]			
	public class ResultsActivity : Activity
	{
		private Toolbar toolbar;

		List<ViewCollection> collection = new List<ViewCollection> ();
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.ResultsLayout);
			toolbar = FindViewById<Toolbar> (Resource.Id.sliding_results);
			SetActionBar (toolbar);
			toolbar.Title = "results";
			toolbar.SetTitleTextColor (Android.Graphics.Color.White);

			loaddata ();

			GridView grid = FindViewById<GridView> (Resource.Id.gridview);
			grid.Adapter = new GridViewAdapter.ListAdapter (this, collection);


			// Create your application here
		}

		private void loaddata()
		{
			collection.Add (new ViewCollection{ title = "Sport(50)", color= Android.Graphics.Color.Red });
			collection.Add (new ViewCollection{ title = "Sport(50)", color= Android.Graphics.Color.Aquamarine });
			collection.Add (new ViewCollection{ title = "Sport(50)", color= Android.Graphics.Color.Azure });
			collection.Add (new ViewCollection{ title = "Sport(50)", color= Android.Graphics.Color.Beige });
			collection.Add (new ViewCollection{ title = "Sport(50)", color= Android.Graphics.Color.Black });
			collection.Add (new ViewCollection{ title = "Sport(50)", color= Android.Graphics.Color.Blue });
			collection.Add (new ViewCollection{ title = "Sport(50)", color= Android.Graphics.Color.CadetBlue});
			collection.Add (new ViewCollection{ title = "Sport(50)", color= Android.Graphics.Color.Chocolate });
			collection.Add (new ViewCollection{ title = "Sport(50)", color= Android.Graphics.Color.CornflowerBlue });
			collection.Add (new ViewCollection{ title = "Sport(50)", color= Android.Graphics.Color.DarkBlue });
		}
	}
}

