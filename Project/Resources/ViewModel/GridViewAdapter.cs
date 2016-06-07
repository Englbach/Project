using System;
using Android.Views;
using System.Collections.Generic;
using Android.Widget;
using Android.Content;

namespace Project
{
	public class GridViewAdapter
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
				View view = convertView ?? _inflater.Inflate (Resource.Layout.GridViewItems, parent, false);

				var item = _item[position];
				var viewHolder = view.Tag as TrackViewHolder;
				if (viewHolder == null) {
					viewHolder = new TrackViewHolder ();
					viewHolder.Title = view.FindViewById<TextView> (Resource.Id.textViewContactName);
					viewHolder.BackgroundThumb = view.FindViewById<LinearLayout> (Resource.Id.linearlayoutContactName);

					viewHolder.ImgIcon = view.FindViewById<ImageView> (Resource.Id.imageViewContactIcon);

					view.Tag = viewHolder;
				} else
					viewHolder = view.Tag as TrackViewHolder;

				viewHolder.Title.Text = item.title;
				viewHolder.ImgIcon.SetImageResource (Resource.Drawable.BookmarkWhite);
				viewHolder.BackgroundThumb.SetBackgroundColor (item.color);


				return view;
			}


		}
		public class TrackViewHolder:Java.Lang.Object
		{
			public TextView Title{ get; set;}

			public ImageView ImgIcon{get;set;}

			public LinearLayout BackgroundThumb{ get; set; }
		}

	}
}

