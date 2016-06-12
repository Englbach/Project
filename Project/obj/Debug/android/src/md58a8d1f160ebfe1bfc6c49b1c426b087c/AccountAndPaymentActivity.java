package md58a8d1f160ebfe1bfc6c49b1c426b087c;


public class AccountAndPaymentActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Project.AccountAndPaymentActivity, Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AccountAndPaymentActivity.class, __md_methods);
	}


	public AccountAndPaymentActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AccountAndPaymentActivity.class)
			mono.android.TypeManager.Activate ("Project.AccountAndPaymentActivity, Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
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
