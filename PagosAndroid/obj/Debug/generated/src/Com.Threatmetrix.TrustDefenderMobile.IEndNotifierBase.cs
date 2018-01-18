using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Threatmetrix.TrustDefenderMobile {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/interface[@name='EndNotifierBase']"
	[Register ("com/threatmetrix/TrustDefenderMobile/EndNotifierBase", "", "Com.Threatmetrix.TrustDefenderMobile.IEndNotifierBaseInvoker")]
	public partial interface IEndNotifierBase : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/threatmetrix/TrustDefenderMobile/EndNotifierBase", DoNotGenerateAcw=true)]
	internal class IEndNotifierBaseInvoker : global::Java.Lang.Object, IEndNotifierBase {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/threatmetrix/TrustDefenderMobile/EndNotifierBase");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IEndNotifierBaseInvoker); }
		}

		IntPtr class_ref;

		public static IEndNotifierBase GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEndNotifierBase> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.threatmetrix.TrustDefenderMobile.EndNotifierBase"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEndNotifierBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
