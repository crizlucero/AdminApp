using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Threatmetrix.TrustDefenderMobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='ProfilingOptions']"
	[global::Android.Runtime.Register ("com/threatmetrix/TrustDefenderMobile/ProfilingOptions", DoNotGenerateAcw=true)]
	public partial class ProfilingOptions : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/threatmetrix/TrustDefenderMobile/ProfilingOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProfilingOptions); }
		}

		protected ProfilingOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='ProfilingOptions']/constructor[@name='ProfilingOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ProfilingOptions ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ProfilingOptions)) {
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

		static Delegate cb_setCustomAttributes_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetCustomAttributes_Ljava_util_List_Handler ()
		{
			if (cb_setCustomAttributes_Ljava_util_List_ == null)
				cb_setCustomAttributes_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCustomAttributes_Ljava_util_List_);
			return cb_setCustomAttributes_Ljava_util_List_;
		}

		static IntPtr n_SetCustomAttributes_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_customAttributes)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.ProfilingOptions __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ProfilingOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var customAttributes = global::Android.Runtime.JavaList<string>.FromJniHandle (native_customAttributes, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCustomAttributes (customAttributes));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setCustomAttributes_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='ProfilingOptions']/method[@name='setCustomAttributes' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("setCustomAttributes", "(Ljava/util/List;)Lcom/threatmetrix/TrustDefenderMobile/ProfilingOptions;", "GetSetCustomAttributes_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Threatmetrix.TrustDefenderMobile.ProfilingOptions SetCustomAttributes (global::System.Collections.Generic.IList<string> customAttributes)
		{
			if (id_setCustomAttributes_Ljava_util_List_ == IntPtr.Zero)
				id_setCustomAttributes_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setCustomAttributes", "(Ljava/util/List;)Lcom/threatmetrix/TrustDefenderMobile/ProfilingOptions;");
			IntPtr native_customAttributes = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (customAttributes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_customAttributes);

				global::Com.Threatmetrix.TrustDefenderMobile.ProfilingOptions __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ProfilingOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCustomAttributes_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ProfilingOptions> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomAttributes", "(Ljava/util/List;)Lcom/threatmetrix/TrustDefenderMobile/ProfilingOptions;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_customAttributes);
			}
		}

		static Delegate cb_setLocation_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetSetLocation_Landroid_location_Location_Handler ()
		{
			if (cb_setLocation_Landroid_location_Location_ == null)
				cb_setLocation_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLocation_Landroid_location_Location_);
			return cb_setLocation_Landroid_location_Location_;
		}

		static IntPtr n_SetLocation_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_location)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.ProfilingOptions __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ProfilingOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location location = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_location, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetLocation (location));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setLocation_Landroid_location_Location_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='ProfilingOptions']/method[@name='setLocation' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register ("setLocation", "(Landroid/location/Location;)Lcom/threatmetrix/TrustDefenderMobile/ProfilingOptions;", "GetSetLocation_Landroid_location_Location_Handler")]
		public virtual unsafe global::Com.Threatmetrix.TrustDefenderMobile.ProfilingOptions SetLocation (global::Android.Locations.Location location)
		{
			if (id_setLocation_Landroid_location_Location_ == IntPtr.Zero)
				id_setLocation_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "setLocation", "(Landroid/location/Location;)Lcom/threatmetrix/TrustDefenderMobile/ProfilingOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (location);

				global::Com.Threatmetrix.TrustDefenderMobile.ProfilingOptions __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ProfilingOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setLocation_Landroid_location_Location_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ProfilingOptions> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocation", "(Landroid/location/Location;)Lcom/threatmetrix/TrustDefenderMobile/ProfilingOptions;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setSessionID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSessionID_Ljava_lang_String_Handler ()
		{
			if (cb_setSessionID_Ljava_lang_String_ == null)
				cb_setSessionID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetSessionID_Ljava_lang_String_);
			return cb_setSessionID_Ljava_lang_String_;
		}

		static IntPtr n_SetSessionID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sessionID)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.ProfilingOptions __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ProfilingOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sessionID = JNIEnv.GetString (native_sessionID, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSessionID (sessionID));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setSessionID_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='ProfilingOptions']/method[@name='setSessionID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSessionID", "(Ljava/lang/String;)Lcom/threatmetrix/TrustDefenderMobile/ProfilingOptions;", "GetSetSessionID_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Threatmetrix.TrustDefenderMobile.ProfilingOptions SetSessionID (string sessionID)
		{
			if (id_setSessionID_Ljava_lang_String_ == IntPtr.Zero)
				id_setSessionID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSessionID", "(Ljava/lang/String;)Lcom/threatmetrix/TrustDefenderMobile/ProfilingOptions;");
			IntPtr native_sessionID = JNIEnv.NewString (sessionID);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_sessionID);

				global::Com.Threatmetrix.TrustDefenderMobile.ProfilingOptions __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ProfilingOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setSessionID_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ProfilingOptions> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSessionID", "(Ljava/lang/String;)Lcom/threatmetrix/TrustDefenderMobile/ProfilingOptions;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_sessionID);
			}
		}

	}
}
