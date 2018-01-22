using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Threatmetrix.TrustDefenderMobile {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/interface[@name='EndNotifier']"
	[Register ("com/threatmetrix/TrustDefenderMobile/EndNotifier", "", "Com.Threatmetrix.TrustDefenderMobile.IEndNotifierInvoker")]
	public partial interface IEndNotifier : global::Com.Threatmetrix.TrustDefenderMobile.IEndNotifierBase {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/interface[@name='EndNotifier']/method[@name='complete' and count(parameter)=1 and parameter[1][@type='com.threatmetrix.TrustDefenderMobile.ProfilingResult']]"
		[Register ("complete", "(Lcom/threatmetrix/TrustDefenderMobile/ProfilingResult;)V", "GetComplete_Lcom_threatmetrix_TrustDefenderMobile_ProfilingResult_Handler:Com.Threatmetrix.TrustDefenderMobile.IEndNotifierInvoker, PagosAndroid")]
		void Complete (global::Com.Threatmetrix.TrustDefenderMobile.ProfilingResult p0);

	}

	[global::Android.Runtime.Register ("com/threatmetrix/TrustDefenderMobile/EndNotifier", DoNotGenerateAcw=true)]
	internal class IEndNotifierInvoker : global::Java.Lang.Object, IEndNotifier {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/threatmetrix/TrustDefenderMobile/EndNotifier");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IEndNotifierInvoker); }
		}

		IntPtr class_ref;

		public static IEndNotifier GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEndNotifier> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.threatmetrix.TrustDefenderMobile.EndNotifier"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEndNotifierInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_complete_Lcom_threatmetrix_TrustDefenderMobile_ProfilingResult_;
#pragma warning disable 0169
		static Delegate GetComplete_Lcom_threatmetrix_TrustDefenderMobile_ProfilingResult_Handler ()
		{
			if (cb_complete_Lcom_threatmetrix_TrustDefenderMobile_ProfilingResult_ == null)
				cb_complete_Lcom_threatmetrix_TrustDefenderMobile_ProfilingResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Complete_Lcom_threatmetrix_TrustDefenderMobile_ProfilingResult_);
			return cb_complete_Lcom_threatmetrix_TrustDefenderMobile_ProfilingResult_;
		}

		static void n_Complete_Lcom_threatmetrix_TrustDefenderMobile_ProfilingResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.IEndNotifier __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.IEndNotifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Threatmetrix.TrustDefenderMobile.ProfilingResult p0 = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ProfilingResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Complete (p0);
		}
#pragma warning restore 0169

		IntPtr id_complete_Lcom_threatmetrix_TrustDefenderMobile_ProfilingResult_;
		public unsafe void Complete (global::Com.Threatmetrix.TrustDefenderMobile.ProfilingResult p0)
		{
			if (id_complete_Lcom_threatmetrix_TrustDefenderMobile_ProfilingResult_ == IntPtr.Zero)
				id_complete_Lcom_threatmetrix_TrustDefenderMobile_ProfilingResult_ = JNIEnv.GetMethodID (class_ref, "complete", "(Lcom/threatmetrix/TrustDefenderMobile/ProfilingResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_complete_Lcom_threatmetrix_TrustDefenderMobile_ProfilingResult_, __args);
		}

	}

}
