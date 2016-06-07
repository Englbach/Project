using Android.Widget;
using System.Collections.Generic;
using Android.Views;
using Android.Content;

namespace Project
{
	public class CustomSpinnerAdapter 
	{
		/*
		private Context context;
		private List<string> data;
		Android.Views.LayoutInflater inflater;

		public CustomSpinnerAdapter(Context _context,List<string> _data):base(context,Resource.Layout.CustomeSpinnerRow,_data)
		{
			context = _context;
			data = _data;

			inflater = context.GetSystemService (Context.LayoutInflaterService);
		}


		public override View GetDropDownView(int position, View convertView,ViewGroup parent)
		{
			return GetDropDownView (position, convertView, parent);
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			return GetDropDownView (position, convertView, parent);
		}
		 
		public View GetCustomView(int position,View convertView,ViewGroup parent)
		{
			View row = inflater.Inflate (Resource.Layout.CustomeSpinnerRow, parent, false);
			TextView txtCategory = View.FindViewById<TextView> (Resource.Id.txtCategory);
			txtCategory.Text = data [position].ToString ();
			return row;
		}
*/

	}
}

