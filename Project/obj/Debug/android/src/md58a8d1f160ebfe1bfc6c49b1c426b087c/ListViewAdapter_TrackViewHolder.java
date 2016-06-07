package md58a8d1f160ebfe1bfc6c49b1c426b087c;


public class ListViewAdapter_TrackViewHolder
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Project.ListViewAdapter+TrackViewHolder, Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ListViewAdapter_TrackViewHolder.class, __md_methods);
	}


	public ListViewAdapter_TrackViewHolder () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ListViewAdapter_TrackViewHolder.class)
			mono.android.TypeManager.Activate ("Project.ListViewAdapter+TrackViewHolder, Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
