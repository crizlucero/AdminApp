using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Threatmetrix.TrustDefenderMobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='BaseConfig']"
	[global::Android.Runtime.Register ("com/threatmetrix/TrustDefenderMobile/BaseConfig", DoNotGenerateAcw=true)]
	public partial class BaseConfig : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='BaseConfig']/field[@name='THM_OPTION_ALL']"
		[Register ("THM_OPTION_ALL")]
		public const int ThmOptionAll = (int) 31998;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/threatmetrix/TrustDefenderMobile/BaseConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseConfig); }
		}

		protected BaseConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
