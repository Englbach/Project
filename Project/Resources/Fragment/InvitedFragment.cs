
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
	public class InvitedFragment : Android.Support.V4.App.Fragment
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
			return inflater.Inflate(Resource.Layout.InvitedLayout,container,false);

		}

		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);
			loaddata ();
			ListView lst = View.FindViewById<ListView> (Resource.Id.lstInvited);
			lst.Adapter = new ListViewAdapter.ListAdapter (Activity, collection);
		}
		private void loaddata()
		{
			collection.Add (new ViewCollection{ title = "TG TV: Chris and Matt preview tonight's episode", datetime="5 Jun 2016", subtitle="Video: McLarens, celebrities and the big SUV test in Africa\n\n", image="https://cdn0.vox-cdn.com/thumbor/0hfuYv6EIif1znsVbdJ4I_RiVH8=/0x109:3661x2550/1310x873/cdn0.vox-cdn.com/uploads/chorus_image/image/49782471/usa-today-9327152.0.jpg" });
			collection.Add (new ViewCollection{ title = "TG TV: Chris and Matt preview tonight's episode", datetime="5 Jun 2016",subtitle="Video: McLarens, celebrities and the big SUV test in Africa\n\n", image="https://cdn0.vox-cdn.com/thumbor/0hfuYv6EIif1znsVbdJ4I_RiVH8=/0x109:3661x2550/1310x873/cdn0.vox-cdn.com/uploads/chorus_image/image/49782471/usa-today-9327152.0.jpg" });
			collection.Add (new ViewCollection{ title = "TG TV: Chris and Matt preview tonight's episode", datetime="5 Jun 2016",subtitle="Video: McLarens, celebrities and the big SUV test in Africa\n\n", image="https://cdn0.vox-cdn.com/thumbor/0hfuYv6EIif1znsVbdJ4I_RiVH8=/0x109:3661x2550/1310x873/cdn0.vox-cdn.com/uploads/chorus_image/image/49782471/usa-today-9327152.0.jpg" });
			collection.Add (new ViewCollection{ title = "TG TV: Chris and Matt preview tonight's episode",datetime="5 Jun 2016", subtitle="Video: McLarens, celebrities and the big SUV test in Africa\n\n", image="https://cdn0.vox-cdn.com/thumbor/0hfuYv6EIif1znsVbdJ4I_RiVH8=/0x109:3661x2550/1310x873/cdn0.vox-cdn.com/uploads/chorus_image/image/49782471/usa-today-9327152.0.jpg" });
			collection.Add (new ViewCollection{ title = "TG TV: Chris and Matt preview tonight's episode",datetime="5 Jun 2016", subtitle="Video: McLarens, celebrities and the big SUV test in Africa\n\n", image="https://cdn0.vox-cdn.com/thumbor/0hfuYv6EIif1znsVbdJ4I_RiVH8=/0x109:3661x2550/1310x873/cdn0.vox-cdn.com/uploads/chorus_image/image/49782471/usa-today-9327152.0.jpg" });
			collection.Add (new ViewCollection{ title = "TG TV: Chris and Matt preview tonight's episode",datetime="5 Jun 2016", subtitle="Video: McLarens, celebrities and the big SUV test in Africa\n\n", image="https://cdn0.vox-cdn.com/thumbor/0hfuYv6EIif1znsVbdJ4I_RiVH8=/0x109:3661x2550/1310x873/cdn0.vox-cdn.com/uploads/chorus_image/image/49782471/usa-today-9327152.0.jpg" });
			collection.Add (new ViewCollection{ title = "TG TV: Chris and Matt preview tonight's episode",datetime="5 Jun 2016", subtitle="Video: McLarens, celebrities and the big SUV test in Africa\n\n", image="https://cdn0.vox-cdn.com/thumbor/0hfuYv6EIif1znsVbdJ4I_RiVH8=/0x109:3661x2550/1310x873/cdn0.vox-cdn.com/uploads/chorus_image/image/49782471/usa-today-9327152.0.jpg" });



		}
	}
}

