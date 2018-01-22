using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mitec.Suitemcommerce.Utilities {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='RootUtil']"
	[global::Android.Runtime.Register ("com/mitec/suitemcommerce/utilities/RootUtil", DoNotGenerateAcw=true)]
	public partial class RootUtil : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mitec/suitemcommerce/utilities/RootUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RootUtil); }
		}

		protected RootUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='RootUtil']/constructor[@name='RootUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RootUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (RootUtil)) {
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

		static IntPtr id_isDeviceRooted;
		public static unsafe bool IsDeviceRooted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='RootUtil']/method[@name='isDeviceRooted' and count(parameter)=0]"
			[Register ("isDeviceRooted", "()Z", "GetIsDeviceRootedHandler")]
			get {
				if (id_isDeviceRooted == IntPtr.Zero)
					id_isDeviceRooted = JNIEnv.GetStaticMethodID (class_ref, "isDeviceRooted", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isDeviceRooted);
				} finally {
				}
			}
		}

	}
}
