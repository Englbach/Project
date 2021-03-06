﻿using System;
using Android.App;
using Android.OS;
using Android.Util;
using Android.Content;
using Android.Widget;

namespace Project
{
	public class DatePickerVM :  DialogFragment, DatePickerDialog.IOnDateSetListener
	{
		// TAG can be any string of your choice.
		public static readonly string TAG = "X:" + typeof (DatePickerVM).Name.ToUpper();

		// Initialize this value to prevent NullReferenceExceptions.
		Action<DateTime> _dateSelectedHandler = delegate { };

		public static DatePickerVM NewInstance(Action<DateTime> onDateSelected)
		{
			DatePickerVM frag = new DatePickerVM();
			frag._dateSelectedHandler = onDateSelected;
			return frag;
		}

		public override Dialog OnCreateDialog(Bundle savedInstanceState)
		{
			DateTime currently = DateTime.Now;
			DatePickerDialog dialog = new DatePickerDialog(Activity, 
				this, 
				currently.Year, 
				currently.Month,
				currently.Day);
			return dialog;
		}

		public void OnDateSet(DatePicker view, int year, int monthOfYear, int dayOfMonth)
		{
			// Note: monthOfYear is a value between 0 and 11, not 1 and 12!
			DateTime selectedDate = new DateTime(year, monthOfYear + 1, dayOfMonth);
			Log.Debug(TAG, selectedDate.ToLongDateString());
			_dateSelectedHandler(selectedDate);
		}
	}
}

