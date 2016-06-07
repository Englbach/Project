
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
	public class GoingFragment : Android.Support.V4.App.Fragment
	{
		List<ViewCollection> collection = new List<ViewCollection> ();
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
			return inflater.Inflate(Resource.Layout.GoingLayout,container,false);

		}

		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);
			loaddata ();
			ListView lst = View.FindViewById<ListView> (Resource.Id.lstGoing);
			lst.Adapter = new ListViewAdapter.ListAdapter (Activity, collection);
		}
		private void loaddata()
		{
			collection.Add (new ViewCollection{ title = "TG TV: Chris and Matt preview tonight's episode", datetime="5 Jun 2016", subtitle="Video: McLarens, celebrities and the big SUV test in Africa\n\n", image="https://i.guim.co.uk/img/media/442938481d95468ec372ee4a3bef698b35583b75/0_31_4992_2995/master/4992.jpg?w=620&q=55&auto=format&usm=12&fit=max&s=081a876c2629f41c93f811c562cdcb6f" });
			collection.Add (new ViewCollection{ title = "TG TV: Chris and Matt preview tonight's episode", datetime="5 Jun 2016",subtitle="Video: McLarens, celebrities and the big SUV test in Africa\n\n", image="https://i.guim.co.uk/img/media/442938481d95468ec372ee4a3bef698b35583b75/0_31_4992_2995/master/4992.jpg?w=620&q=55&auto=format&usm=12&fit=max&s=081a876c2629f41c93f811c562cdcb6f" });
			collection.Add (new ViewCollection{ title = "TG TV: Chris and Matt preview tonight's episode", datetime="5 Jun 2016",subtitle="Video: McLarens, celebrities and the big SUV test in Africa\n\n", image="https://i.guim.co.uk/img/media/442938481d95468ec372ee4a3bef698b35583b75/0_31_4992_2995/master/4992.jpg?w=620&q=55&auto=format&usm=12&fit=max&s=081a876c2629f41c93f811c562cdcb6f" });
			collection.Add (new ViewCollection{ title = "TG TV: Chris and Matt preview tonight's episode",datetime="5 Jun 2016", subtitle="Video: McLarens, celebrities and the big SUV test in Africa\n\n", image="https://i.guim.co.uk/img/media/442938481d95468ec372ee4a3bef698b35583b75/0_31_4992_2995/master/4992.jpg?w=620&q=55&auto=format&usm=12&fit=max&s=081a876c2629f41c93f811c562cdcb6f" });
			collection.Add (new ViewCollection{ title = "TG TV: Chris and Matt preview tonight's episode",datetime="5 Jun 2016", subtitle="Video: McLarens, celebrities and the big SUV test in Africa\n\n", image="https://i.guim.co.uk/img/media/442938481d95468ec372ee4a3bef698b35583b75/0_31_4992_2995/master/4992.jpg?w=620&q=55&auto=format&usm=12&fit=max&s=081a876c2629f41c93f811c562cdcb6f" });
			collection.Add (new ViewCollection{ title = "TG TV: Chris and Matt preview tonight's episode",datetime="5 Jun 2016", subtitle="Video: McLarens, celebrities and the big SUV test in Africa\n\n", image="https://i.guim.co.uk/img/media/442938481d95468ec372ee4a3bef698b35583b75/0_31_4992_2995/master/4992.jpg?w=620&q=55&auto=format&usm=12&fit=max&s=081a876c2629f41c93f811c562cdcb6f" });
			collection.Add (new ViewCollection{ title = "TG TV: Chris and Matt preview tonight's episode",datetime="5 Jun 2016", subtitle="Video: McLarens, celebrities and the big SUV test in Africa\n\n", image="https://i.guim.co.uk/img/media/442938481d95468ec372ee4a3bef698b35583b75/0_31_4992_2995/master/4992.jpg?w=620&q=55&auto=format&usm=12&fit=max&s=081a876c2629f41c93f811c562cdcb6f" });



		}
	}
}

