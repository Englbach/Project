
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
using FFImageLoading.Views;

namespace Project
{
	[Activity(Label = "AccountAndPaymentActivity")]
	public class AccountAndPaymentActivity : Activity
	{
		List<ViewCollection> viewCollection = new List<ViewCollection>();
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.AccountAndPaymentLayout);

			Toolbar mToolbar = FindViewById<Toolbar>(Resource.Id.accountToolbar);
			mToolbar.Title="Account And Payment";
			SetActionBar(mToolbar);

			loaddata();
			ListView lst = FindViewById<ListView>(Resource.Id.lstAccountAndPayment);

			lst.Adapter = new ListviewPayment(this, viewCollection);

			ActionBar.SetDisplayHomeAsUpEnabled(true);
			// Create your application here
		}


		private void loaddata()
		{
			viewCollection.Add(new ViewCollection {title="Name",subtitle="Jone Lee" });
			viewCollection.Add(new ViewCollection { title = "Email", subtitle = "Jonelee@yahoo.com" });
			viewCollection.Add(new ViewCollection { title = "Home", subtitle = "Australia" });
			viewCollection.Add(new ViewCollection { title = "Work", subtitle = "Sydney" });


			viewCollection.Add(new ViewCollection { title = "", subtitle = "Daily Featured Deals" });
			viewCollection.Add(new ViewCollection { title = "", subtitle = "Reminder before event starts" });

			viewCollection.Add(new ViewCollection { title = "Credit/ Debit Card", subtitle = "Jone Lee" });
		}


		private class ListviewPayment : BaseAdapter<ViewCollection>
		{
			LayoutInflater _inflater;
			public List<ViewCollection> _item { get; set; }
			public ListviewPayment(Context context, List<ViewCollection> item)
			{
				_inflater = LayoutInflater.FromContext(context);
				_item = item;

			}

			public override ViewCollection this[int position]
			{
				get
				{
					return _item[position];
				}
			}

			public override int Count
			{
				get
				{
					return _item.Count;
				}
			}

			public override int GetItemViewType(int position)
			{
				return base.GetItemViewType(position);
			}

			public override long GetItemId(int position)
			{
				return position;
			}

			public override View GetView(int position, View convertView, ViewGroup parent)
			{
				View view = convertView ?? _inflater.Inflate(Resource.Layout.ListviewPaymentItem, parent, false);

				var item = _item[position];
				var viewHolder = view.Tag as PaymentItemViewHolder;
				if (viewHolder == null)
				{
					viewHolder = new PaymentItemViewHolder();
					viewHolder.Title = view.FindViewById<TextView>(Resource.Id.txtPayment);
					viewHolder.SubTitle = view.FindViewById<TextView>(Resource.Id.txtsubPayment);
					viewHolder.switchButton = view.FindViewById<Switch>(Resource.Id.switchPayment);
				}

				viewHolder.Title.Text = item.title;
				viewHolder.SubTitle.Text = item.subtitle;
				if (_item[position].subtitle =="Daily Featured Deals" || _item[position].subtitle == "Reminder before event starts")
				{
					viewHolder.Title.Visibility = ViewStates.Invisible;
					viewHolder.SubTitle.Visibility = ViewStates.Visible;
					viewHolder.switchButton.Visibility = ViewStates.Visible;
				}
				else
				{
					viewHolder.switchButton.Visibility = ViewStates.Invisible;
					viewHolder.Title.Visibility = ViewStates.Visible;
					viewHolder.SubTitle.Visibility = ViewStates.Visible;
				}
					

				return view;
			}

			public class PaymentItemViewHolder : Java.Lang.Object
			{
				public TextView Title { get; set; }
				public TextView SubTitle { get; set; }
				public ImageViewAsync Image { get; set; }
				public ImageView ImgIcon { get; set; }
				public Switch switchButton { get; set; }

			}
		}
	}
}

