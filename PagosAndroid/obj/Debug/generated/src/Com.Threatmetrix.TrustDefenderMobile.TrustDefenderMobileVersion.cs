using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Threatmetrix.TrustDefenderMobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='TrustDefenderMobileVersion']"
	[global::Android.Runtime.Register ("com/threatmetrix/TrustDefenderMobile/TrustDefenderMobileVersion", DoNotGenerateAcw=true)]
	public sealed partial class TrustDefenderMobileVersion : global::Java.Lang.Object {


		static IntPtr numeric_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='TrustDefenderMobileVersion']/field[@name='numeric']"
		[Register ("numeric")]
		public static global::Java.Lang.Integer Numeric {
			get {
				if (numeric_jfieldId == IntPtr.Zero)
					numeric_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "numeric", "Ljava/lang/Integer;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, numeric_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='TrustDefenderMobileVersion']/field[@name='string']"
		[Register ("string")]
		public const string String = (string) "3.0-105";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/threatmetrix/TrustDefenderMobile/TrustDefenderMobileVersion", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TrustDefenderMobileVersion); }
		}

		internal TrustDefenderMobileVersion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='TrustDefenderMobileVersion']/constructor[@name='TrustDefenderMobileVersion' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TrustDefenderMobileVersion ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TrustDefenderMobileVersion)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}
}
