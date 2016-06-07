
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
	public class InterestedFragment : Android.Support.V4.App.Fragment
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
			return inflater.Inflate(Resource.Layout.InterestedLayout,container,false);
		}

		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);

			loaddata ();
			ListView lst = View.FindViewById<ListView> (Resource.Id.lstInterested);
			lst.Adapter = new ListViewAdapter.ListAdapter (Activity,collection ); 

		}

		private void loaddata()
		{
			collection.Add (new ViewCollection{ title = "TG TV: Chris and Matt preview tonight's episode", datetime="5 Jun 2016", subtitle="Video: McLarens, celebrities and the big SUV test in Africa\n\n", image="http://www.topgear.com/sites/default/files/styles/16x9_1280w/public/images/news-article/2016/06/3646ae401f78d5fab319ea9abdc4ef0f/tgtv232.jpg?itok=Wcz1u6Ov" });
			collection.Add (new ViewCollection{ title = "TG TV: Chris and Matt preview tonight's episode", datetime="5 Jun 2016",subtitle="Video: McLarens, celebrities and the big SUV test in Africa\n\n", image="http://www.topgear.com/sites/default/files/styles/16x9_1280w/public/images/news-article/2016/06/3646ae401f78d5fab319ea9abdc4ef0f/tgtv232.jpg?itok=Wcz1u6Ov" });
			collection.Add (new ViewCollection{ title = "TG TV: Chris and Matt preview tonight's episode", datetime="5 Jun 2016",subtitle="Video: McLarens, celebrities and the big SUV test in Africa\n\n", image="http://www.topgear.com/sites/default/files/styles/16x9_1280w/public/images/news-article/2016/06/3646ae401f78d5fab319ea9abdc4ef0f/tgtv232.jpg?itok=Wcz1u6Ov" });
			collection.Add (new ViewCollection{ title = "TG TV: Chris and Matt preview tonight's episode",datetime="5 Jun 2016", subtitle="Video: McLarens, celebrities and the big SUV test in Africa\n\n", image="http://www.topgear.com/sites/default/files/styles/16x9_1280w/public/images/news-article/2016/06/3646ae401f78d5fab319ea9abdc4ef0f/tgtv232.jpg?itok=Wcz1u6Ov" });
			collection.Add (new ViewCollection{ title = "TG TV: Chris and Matt preview tonight's episode",datetime="5 Jun 2016", subtitle="Video: McLarens, celebrities and the big SUV test in Africa\n\n", image="http://www.topgear.com/sites/default/files/styles/16x9_1280w/public/images/news-article/2016/06/3646ae401f78d5fab319ea9abdc4ef0f/tgtv232.jpg?itok=Wcz1u6Ov" });
			collection.Add (new ViewCollection{ title = "TG TV: Chris and Matt preview tonight's episode",datetime="5 Jun 2016", subtitle="Video: McLarens, celebrities and the big SUV test in Africa\n\n", image="http://www.topgear.com/sites/default/files/styles/16x9_1280w/public/images/news-article/2016/06/3646ae401f78d5fab319ea9abdc4ef0f/tgtv232.jpg?itok=Wcz1u6Ov" });
			collection.Add (new ViewCollection{ title = "TG TV: Chris and Matt preview tonight's episode",datetime="5 Jun 2016", subtitle="Video: McLarens, celebrities and the big SUV test in Africa\n\n", image="http://www.topgear.com/sites/default/files/styles/16x9_1280w/public/images/news-article/2016/06/3646ae401f78d5fab319ea9abdc4ef0f/tgtv232.jpg?itok=Wcz1u6Ov" });



		}
	}
}

