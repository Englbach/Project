
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
using Android.Preferences;

namespace Project
{
	public class More : Android.Support.V4.App.Fragment
	{
		private MainActivity mainActivity;

		List<ViewCollection> collection = new List<ViewCollection> ();
		Intent intent;

		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your fragment here
			loaddata ();
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			// Use this to return your custom view for this Fragment
			// return inflater.Inflate(Resource.Layout.YourFragment, container, false);

			//return base.OnCreateView (inflater, container, savedInstanceState);
			return inflater.Inflate(Resource.Layout.MoreLayout,container,false);

		}

		[Obsolete("deprecated")]
		public override void OnAttach (Android.App.Activity activity)
		{
			mainActivity = (MainActivity)activity;
			base.OnAttach (activity);
		}

		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);


			ListView lst = View.FindViewById<ListView> (Resource.Id.lstMoreSettingsAccount);
			lst.Adapter = new ListAdapter (Application.Context, collection);

			lst.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) =>
			 {
				 NavigationToPage(e.Position);

			 };
		}

		private void NavigationToPage(int position)
		{
			switch (position)
			{
				case 0:
					intent = new Intent(Activity, typeof(ShareTheJoyActivity));
					break;
				case 1:
					intent = new Intent(Activity, typeof(AccountAndPaymentActivity));
					break;
				case 2:
					intent = new Intent(Activity, typeof(HistoryActivity));
					break;
				case 3:
					intent = new Intent(Activity, typeof(HelpActivity));
					break;

			}
			StartActivity(intent);
		}

		private void loaddata()
		{
			collection.Add (new ViewCollection{ title = "SHARE THE JOY", subtitle = "Invite friends and get RM10 off!" });
			collection.Add (new ViewCollection{ title = "ACCOUNT AND PAYMENT", subtitle = "Notifications and more!" });
			collection.Add (new ViewCollection{ title = "ACTIVITY HISTORY", subtitle = "Just for your record!" });
			collection.Add (new ViewCollection{ title = "HELP", subtitle = "FAQs" });

		}


		public class ListAdapter : BaseAdapter<ViewCollection>
		{
			LayoutInflater _inflater;
			public List<ViewCollection> _item{ get; set; }

			public ListAdapter(Context context,List<ViewCollection> item)//, List<TrackModel.Track> tracks
			{
				_inflater=LayoutInflater.FromContext(context);
				_item=item;
			}


			public override ViewCollection this[int index]
			{
				get{ return _item [index]; }
			}

			public override int Count{
				get{ return _item.Count; }
			}

			public override long GetItemId(int position)
			{
				return position;
			}

			public override View GetView (int position, View convertView, ViewGroup parent)
			{
				View view = convertView ?? _inflater.Inflate (Resource.Layout.SettingItems, parent, false);

				var item = _item[position];
				var viewHolder = view.Tag as TrackViewHolder;
				if (viewHolder == null) {
					viewHolder = new TrackViewHolder ();
					viewHolder.Title = view.FindViewById<TextView> (Resource.Id.txtTitleSetting);
					viewHolder.SubTitle = view.FindViewById<TextView> (Resource.Id.subtitleSetting);


					view.Tag = viewHolder;
				} else
					viewHolder = view.Tag as TrackViewHolder;

				viewHolder.Title.Text = item.title;
				viewHolder.SubTitle.Text = item.subtitle;




				return view;
			}


		}
		public class TrackViewHolder:Java.Lang.Object
		{
			public TextView Title{ get; set;}
			public TextView SubTitle{get;set;}

		}


	}
}

