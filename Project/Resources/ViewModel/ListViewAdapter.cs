using System;
using Android.Widget;
using Android.Views;
using System.Collections.Generic;
using Android.Content;
using FFImageLoading.Views;
using FFImageLoading;


namespace Project
{
	public class ListViewAdapter
	{
		public class ListAdapter:BaseAdapter<ViewCollection>
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
				View view = convertView ?? _inflater.Inflate (Resource.Layout.ListViewItems, parent, false);

				var item = _item[position];
				var viewHolder = view.Tag as TrackViewHolder;
				if (viewHolder == null) {
					viewHolder = new TrackViewHolder ();
					viewHolder.Title = view.FindViewById<TextView> (Resource.Id.txtTitle);
					viewHolder.SubTitle = view.FindViewById<TextView> (Resource.Id.subtitle);
					viewHolder.Image = view.FindViewById<ImageViewAsync> (Resource.Id.imageBackground);
					//viewHolder.ImgIcon = view.FindViewById<ImageView> (Resource.Id.imgIconPlay);
					viewHolder.datetime = view.FindViewById<TextView> (Resource.Id.datetime);
					view.Tag = viewHolder;
				} else
					viewHolder = view.Tag as TrackViewHolder;

				viewHolder.Title.Text = item.title;
				viewHolder.SubTitle.Text = item.subtitle;
				ImageService.Instance.LoadUrl (item.image).Retry (5, 200).Into (viewHolder.Image);
				viewHolder.datetime.Text = item.datetime;


				return view;
			}


		}
		public class TrackViewHolder:Java.Lang.Object
		{
			public TextView Title{ get; set;}
			public TextView SubTitle{get;set;}
			public ImageViewAsync Image{ get; set;}
			public ImageView ImgIcon{get;set;}
			public TextView datetime{get;set;}
		}

	}
}

