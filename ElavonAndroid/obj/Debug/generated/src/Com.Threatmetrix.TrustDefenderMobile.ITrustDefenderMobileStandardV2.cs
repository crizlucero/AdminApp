using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Threatmetrix.TrustDefenderMobile {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/interface[@name='TrustDefenderMobileStandardV2']"
	[Register ("com/threatmetrix/TrustDefenderMobile/TrustDefenderMobileStandardV2", "", "Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2Invoker")]
	public partial interface ITrustDefenderMobileStandardV2 : IJavaObject {

		global::Com.Threatmetrix.TrustDefenderMobile.ProfilingResult Result {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/interface[@name='TrustDefenderMobileStandardV2']/method[@name='getResult' and count(parameter)=0]"
			[Register ("getResult", "()Lcom/threatmetrix/TrustDefenderMobile/ProfilingResult;", "GetGetResultHandler:Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2Invoker, ElavonAndroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/interface[@name='TrustDefenderMobileStandardV2']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler:Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2Invoker, ElavonAndroid")]
		void Cancel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/interface[@name='TrustDefenderMobileStandardV2']/method[@name='doPackageScan' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doPackageScan", "(I)Z", "GetDoPackageScan_IHandler:Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2Invoker, ElavonAndroid")]
		bool DoPackageScan (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/interface[@name='TrustDefenderMobileStandardV2']/method[@name='doProfileRequest' and count(parameter)=0]"
		[Register ("doProfileRequest", "()Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;", "GetDoProfileRequestHandler:Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2Invoker, ElavonAndroid")]
		global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode DoProfileRequest ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/interface[@name='TrustDefenderMobileStandardV2']/method[@name='doProfileRequest' and count(parameter)=1 and parameter[1][@type='com.threatmetrix.TrustDefenderMobile.ProfilingOptions']]"
		[Register ("doProfileRequest", "(Lcom/threatmetrix/TrustDefenderMobile/ProfilingOptions;)Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;", "GetDoProfileRequest_Lcom_threatmetrix_TrustDefenderMobile_ProfilingOptions_Handler:Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2Invoker, ElavonAndroid")]
		global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode DoProfileRequest (global::Com.Threatmetrix.TrustDefenderMobile.ProfilingOptions p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/interface[@name='TrustDefenderMobileStandardV2']/method[@name='doProfileRequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("doProfileRequest", "(Ljava/lang/String;)Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;", "GetDoProfileRequest_Ljava_lang_String_Handler:Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2Invoker, ElavonAndroid")]
		global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode DoProfileRequest (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/interface[@name='TrustDefenderMobileStandardV2']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "GetInit_Landroid_content_Context_Handler:Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2Invoker, ElavonAndroid")]
		void Init (global::Android.Content.Context p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/interface[@name='TrustDefenderMobileStandardV2']/method[@name='init' and count(parameter)=1 and parameter[1][@type='com.threatmetrix.TrustDefenderMobile.Config']]"
		[Register ("init", "(Lcom/threatmetrix/TrustDefenderMobile/Config;)V", "GetInit_Lcom_threatmetrix_TrustDefenderMobile_Config_Handler:Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2Invoker, ElavonAndroid")]
		void Init (global::Com.Threatmetrix.TrustDefenderMobile.Config p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/interface[@name='TrustDefenderMobileStandardV2']/method[@name='pauseLocationServices' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("pauseLocationServices", "(Z)V", "GetPauseLocationServices_ZHandler:Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2Invoker, ElavonAndroid")]
		void PauseLocationServices (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/interface[@name='TrustDefenderMobileStandardV2']/method[@name='tidyUp' and count(parameter)=0]"
		[Register ("tidyUp", "()V", "GetTidyUpHandler:Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2Invoker, ElavonAndroid")]
		void TidyUp ();

	}

	[global::Android.Runtime.Register ("com/threatmetrix/TrustDefenderMobile/TrustDefenderMobileStandardV2", DoNotGenerateAcw=true)]
	internal class ITrustDefenderMobileStandardV2Invoker : global::Java.Lang.Object, ITrustDefenderMobileStandardV2 {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/threatmetrix/TrustDefenderMobile/TrustDefenderMobileStandardV2");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITrustDefenderMobileStandardV2Invoker); }
		}

		IntPtr class_ref;

		public static ITrustDefenderMobileStandardV2 GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITrustDefenderMobileStandardV2> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.threatmetrix.TrustDefenderMobile.TrustDefenderMobileStandardV2"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITrustDefenderMobileStandardV2Invoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getResult;
#pragma warning disable 0169
		static Delegate GetGetResultHandler ()
		{
			if (cb_getResult == null)
				cb_getResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResult);
			return cb_getResult;
		}

		static IntPtr n_GetResult (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2 __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Result);
		}
#pragma warning restore 0169

		IntPtr id_getResult;
		public unsafe global::Com.Threatmetrix.TrustDefenderMobile.ProfilingResult Result {
			get {
				if (id_getResult == IntPtr.Zero)
					id_getResult = JNIEnv.GetMethodID (class_ref, "getResult", "()Lcom/threatmetrix/TrustDefenderMobile/ProfilingResult;");
				return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ProfilingResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResult), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2 __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		IntPtr id_cancel;
		public unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel);
		}

		static Delegate cb_doPackageScan_I;
#pragma warning disable 0169
		static Delegate GetDoPackageScan_IHandler ()
		{
			if (cb_doPackageScan_I == null)
				cb_doPackageScan_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_DoPackageScan_I);
			return cb_doPackageScan_I;
		}

		static bool n_DoPackageScan_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2 __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoPackageScan (p0);
		}
#pragma warning restore 0169

		IntPtr id_doPackageScan_I;
		public unsafe bool DoPackageScan (int p0)
		{
			if (id_doPackageScan_I == IntPtr.Zero)
				id_doPackageScan_I = JNIEnv.GetMethodID (class_ref, "doPackageScan", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_doPackageScan_I, __args);
		}

		static Delegate cb_doProfileRequest;
#pragma warning disable 0169
		static Delegate GetDoProfileRequestHandler ()
		{
			if (cb_doProfileRequest == null)
				cb_doProfileRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DoProfileRequest);
			return cb_doProfileRequest;
		}

		static IntPtr n_DoProfileRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2 __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DoProfileRequest ());
		}
#pragma warning restore 0169

		IntPtr id_doProfileRequest;
		public unsafe global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode DoProfileRequest ()
		{
			if (id_doProfileRequest == IntPtr.Zero)
				id_doProfileRequest = JNIEnv.GetMethodID (class_ref, "doProfileRequest", "()Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;");
			return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doProfileRequest), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_doProfileRequest_Lcom_threatmetrix_TrustDefenderMobile_ProfilingOptions_;
#pragma warning disable 0169
		static Delegate GetDoProfileRequest_Lcom_threatmetrix_TrustDefenderMobile_ProfilingOptions_Handler ()
		{
			if (cb_doProfileRequest_Lcom_threatmetrix_TrustDefenderMobile_ProfilingOptions_ == null)
				cb_doProfileRequest_Lcom_threatmetrix_TrustDefenderMobile_ProfilingOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoProfileRequest_Lcom_threatmetrix_TrustDefenderMobile_ProfilingOptions_);
			return cb_doProfileRequest_Lcom_threatmetrix_TrustDefenderMobile_ProfilingOptions_;
		}

		static IntPtr n_DoProfileRequest_Lcom_threatmetrix_TrustDefenderMobile_ProfilingOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2 __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Threatmetrix.TrustDefenderMobile.ProfilingOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ProfilingOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoProfileRequest (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_doProfileRequest_Lcom_threatmetrix_TrustDefenderMobile_ProfilingOptions_;
		public unsafe global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode DoProfileRequest (global::Com.Threatmetrix.TrustDefenderMobile.ProfilingOptions p0)
		{
			if (id_doProfileRequest_Lcom_threatmetrix_TrustDefenderMobile_ProfilingOptions_ == IntPtr.Zero)
				id_doProfileRequest_Lcom_threatmetrix_TrustDefenderMobile_ProfilingOptions_ = JNIEnv.GetMethodID (class_ref, "doProfileRequest", "(Lcom/threatmetrix/TrustDefenderMobile/ProfilingOptions;)Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode __ret = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doProfileRequest_Lcom_threatmetrix_TrustDefenderMobile_ProfilingOptions_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_doProfileRequest_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDoProfileRequest_Ljava_lang_String_Handler ()
		{
			if (cb_doProfileRequest_Ljava_lang_String_ == null)
				cb_doProfileRequest_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoProfileRequest_Ljava_lang_String_);
			return cb_doProfileRequest_Ljava_lang_String_;
		}

		static IntPtr n_DoProfileRequest_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2 __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoProfileRequest (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_doProfileRequest_Ljava_lang_String_;
		public unsafe global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode DoProfileRequest (string p0)
		{
			if (id_doProfileRequest_Ljava_lang_String_ == IntPtr.Zero)
				id_doProfileRequest_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "doProfileRequest", "(Ljava/lang/String;)Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode __ret = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doProfileRequest_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_init_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Handler ()
		{
			if (cb_init_Landroid_content_Context_ == null)
				cb_init_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_Landroid_content_Context_);
			return cb_init_Landroid_content_Context_;
		}

		static void n_Init_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2 __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0);
		}
#pragma warning restore 0169

		IntPtr id_init_Landroid_content_Context_;
		public unsafe void Init (global::Android.Content.Context p0)
		{
			if (id_init_Landroid_content_Context_ == IntPtr.Zero)
				id_init_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "init", "(Landroid/content/Context;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Landroid_content_Context_, __args);
		}

		static Delegate cb_init_Lcom_threatmetrix_TrustDefenderMobile_Config_;
#pragma warning disable 0169
		static Delegate GetInit_Lcom_threatmetrix_TrustDefenderMobile_Config_Handler ()
		{
			if (cb_init_Lcom_threatmetrix_TrustDefenderMobile_Config_ == null)
				cb_init_Lcom_threatmetrix_TrustDefenderMobile_Config_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_Lcom_threatmetrix_TrustDefenderMobile_Config_);
			return cb_init_Lcom_threatmetrix_TrustDefenderMobile_Config_;
		}

		static void n_Init_Lcom_threatmetrix_TrustDefenderMobile_Config_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2 __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Threatmetrix.TrustDefenderMobile.Config p0 = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0);
		}
#pragma warning restore 0169

		IntPtr id_init_Lcom_threatmetrix_TrustDefenderMobile_Config_;
		public unsafe void Init (global::Com.Threatmetrix.TrustDefenderMobile.Config p0)
		{
			if (id_init_Lcom_threatmetrix_TrustDefenderMobile_Config_ == IntPtr.Zero)
				id_init_Lcom_threatmetrix_TrustDefenderMobile_Config_ = JNIEnv.GetMethodID (class_ref, "init", "(Lcom/threatmetrix/TrustDefenderMobile/Config;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Lcom_threatmetrix_TrustDefenderMobile_Config_, __args);
		}

		static Delegate cb_pauseLocationServices_Z;
#pragma warning disable 0169
		static Delegate GetPauseLocationServices_ZHandler ()
		{
			if (cb_pauseLocationServices_Z == null)
				cb_pauseLocationServices_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_PauseLocationServices_Z);
			return cb_pauseLocationServices_Z;
		}

		static void n_PauseLocationServices_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2 __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseLocationServices (p0);
		}
#pragma warning restore 0169

		IntPtr id_pauseLocationServices_Z;
		public unsafe void PauseLocationServices (bool p0)
		{
			if (id_pauseLocationServices_Z == IntPtr.Zero)
				id_pauseLocationServices_Z = JNIEnv.GetMethodID (class_ref, "pauseLocationServices", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pauseLocationServices_Z, __args);
		}

		static Delegate cb_tidyUp;
#pragma warning disable 0169
		static Delegate GetTidyUpHandler ()
		{
			if (cb_tidyUp == null)
				cb_tidyUp = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TidyUp);
			return cb_tidyUp;
		}

		static void n_TidyUp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2 __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TidyUp ();
		}
#pragma warning restore 0169

		IntPtr id_tidyUp;
		public unsafe void TidyUp ()
		{
			if (id_tidyUp == IntPtr.Zero)
				id_tidyUp = JNIEnv.GetMethodID (class_ref, "tidyUp", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_tidyUp);
		}

	}

}
