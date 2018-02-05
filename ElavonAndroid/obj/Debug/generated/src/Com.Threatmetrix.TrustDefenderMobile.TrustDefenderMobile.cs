using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Threatmetrix.TrustDefenderMobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='TrustDefenderMobile']"
	[global::Android.Runtime.Register ("com/threatmetrix/TrustDefenderMobile/TrustDefenderMobile", DoNotGenerateAcw=true)]
	public partial class TrustDefenderMobile : global::Java.Lang.Object, global::Com.Threatmetrix.TrustDefenderMobile.ITrustDefenderMobileStandardV2 {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='TrustDefenderMobile']/field[@name='version']"
		[Register ("version")]
		public const string Version = (string) "3.0-105";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/threatmetrix/TrustDefenderMobile/TrustDefenderMobile", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TrustDefenderMobile); }
		}

		protected TrustDefenderMobile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='TrustDefenderMobile']/constructor[@name='TrustDefenderMobile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe TrustDefenderMobile (string org_id)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_org_id = JNIEnv.NewString (org_id);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_org_id);
				if (((object) this).GetType () != typeof (TrustDefenderMobile)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_org_id);
			}
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
			global::Com.Threatmetrix.TrustDefenderMobile.TrustDefenderMobile __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.TrustDefenderMobile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Result);
		}
#pragma warning restore 0169

		static IntPtr id_getResult;
		public virtual unsafe global::Com.Threatmetrix.TrustDefenderMobile.ProfilingResult Result {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='TrustDefenderMobile']/method[@name='getResult' and count(parameter)=0]"
			[Register ("getResult", "()Lcom/threatmetrix/TrustDefenderMobile/ProfilingResult;", "GetGetResultHandler")]
			get {
				if (id_getResult == IntPtr.Zero)
					id_getResult = JNIEnv.GetMethodID (class_ref, "getResult", "()Lcom/threatmetrix/TrustDefenderMobile/ProfilingResult;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ProfilingResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResult), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ProfilingResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResult", "()Lcom/threatmetrix/TrustDefenderMobile/ProfilingResult;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Threatmetrix.TrustDefenderMobile.TrustDefenderMobile __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.TrustDefenderMobile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='TrustDefenderMobile']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancel", "()V"));
			} finally {
			}
		}

		static Delegate cb_doPackageScan_I;
#pragma warning disable 0169
		static Delegate GetDoPackageScan_IHandler ()
		{
			if (cb_doPackageScan_I == null)
				cb_doPackageScan_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_DoPackageScan_I);
			return cb_doPackageScan_I;
		}

		static bool n_DoPackageScan_I (IntPtr jnienv, IntPtr native__this, int timeout)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.TrustDefenderMobile __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.TrustDefenderMobile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoPackageScan (timeout);
		}
#pragma warning restore 0169

		static IntPtr id_doPackageScan_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='TrustDefenderMobile']/method[@name='doPackageScan' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doPackageScan", "(I)Z", "GetDoPackageScan_IHandler")]
		public virtual unsafe bool DoPackageScan (int timeout)
		{
			if (id_doPackageScan_I == IntPtr.Zero)
				id_doPackageScan_I = JNIEnv.GetMethodID (class_ref, "doPackageScan", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (timeout);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_doPackageScan_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doPackageScan", "(I)Z"), __args);
			} finally {
			}
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
			global::Com.Threatmetrix.TrustDefenderMobile.TrustDefenderMobile __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.TrustDefenderMobile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DoProfileRequest ());
		}
#pragma warning restore 0169

		static IntPtr id_doProfileRequest;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='TrustDefenderMobile']/method[@name='doProfileRequest' and count(parameter)=0]"
		[Register ("doProfileRequest", "()Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;", "GetDoProfileRequestHandler")]
		public virtual unsafe global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode DoProfileRequest ()
		{
			if (id_doProfileRequest == IntPtr.Zero)
				id_doProfileRequest = JNIEnv.GetMethodID (class_ref, "doProfileRequest", "()Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doProfileRequest), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doProfileRequest", "()Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_doProfileRequest_Lcom_threatmetrix_TrustDefenderMobile_ProfilingOptions_;
#pragma warning disable 0169
		static Delegate GetDoProfileRequest_Lcom_threatmetrix_TrustDefenderMobile_ProfilingOptions_Handler ()
		{
			if (cb_doProfileRequest_Lcom_threatmetrix_TrustDefenderMobile_ProfilingOptions_ == null)
				cb_doProfileRequest_Lcom_threatmetrix_TrustDefenderMobile_ProfilingOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoProfileRequest_Lcom_threatmetrix_TrustDefenderMobile_ProfilingOptions_);
			return cb_doProfileRequest_Lcom_threatmetrix_TrustDefenderMobile_ProfilingOptions_;
		}

		static IntPtr n_DoProfileRequest_Lcom_threatmetrix_TrustDefenderMobile_ProfilingOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.TrustDefenderMobile __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.TrustDefenderMobile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Threatmetrix.TrustDefenderMobile.ProfilingOptions options = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ProfilingOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoProfileRequest (options));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_doProfileRequest_Lcom_threatmetrix_TrustDefenderMobile_ProfilingOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='TrustDefenderMobile']/method[@name='doProfileRequest' and count(parameter)=1 and parameter[1][@type='com.threatmetrix.TrustDefenderMobile.ProfilingOptions']]"
		[Register ("doProfileRequest", "(Lcom/threatmetrix/TrustDefenderMobile/ProfilingOptions;)Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;", "GetDoProfileRequest_Lcom_threatmetrix_TrustDefenderMobile_ProfilingOptions_Handler")]
		public virtual unsafe global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode DoProfileRequest (global::Com.Threatmetrix.TrustDefenderMobile.ProfilingOptions options)
		{
			if (id_doProfileRequest_Lcom_threatmetrix_TrustDefenderMobile_ProfilingOptions_ == IntPtr.Zero)
				id_doProfileRequest_Lcom_threatmetrix_TrustDefenderMobile_ProfilingOptions_ = JNIEnv.GetMethodID (class_ref, "doProfileRequest", "(Lcom/threatmetrix/TrustDefenderMobile/ProfilingOptions;)Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (options);

				global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doProfileRequest_Lcom_threatmetrix_TrustDefenderMobile_ProfilingOptions_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doProfileRequest", "(Lcom/threatmetrix/TrustDefenderMobile/ProfilingOptions;)Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_doProfileRequest_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDoProfileRequest_Ljava_lang_String_Handler ()
		{
			if (cb_doProfileRequest_Ljava_lang_String_ == null)
				cb_doProfileRequest_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoProfileRequest_Ljava_lang_String_);
			return cb_doProfileRequest_Ljava_lang_String_;
		}

		static IntPtr n_DoProfileRequest_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sessionID)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.TrustDefenderMobile __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.TrustDefenderMobile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sessionID = JNIEnv.GetString (native_sessionID, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoProfileRequest (sessionID));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_doProfileRequest_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='TrustDefenderMobile']/method[@name='doProfileRequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("doProfileRequest", "(Ljava/lang/String;)Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;", "GetDoProfileRequest_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode DoProfileRequest (string sessionID)
		{
			if (id_doProfileRequest_Ljava_lang_String_ == IntPtr.Zero)
				id_doProfileRequest_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "doProfileRequest", "(Ljava/lang/String;)Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;");
			IntPtr native_sessionID = JNIEnv.NewString (sessionID);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_sessionID);

				global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doProfileRequest_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doProfileRequest", "(Ljava/lang/String;)Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_sessionID);
			}
		}

		static Delegate cb_init_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Handler ()
		{
			if (cb_init_Landroid_content_Context_ == null)
				cb_init_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_Landroid_content_Context_);
			return cb_init_Landroid_content_Context_;
		}

		static void n_Init_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.TrustDefenderMobile __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.TrustDefenderMobile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.Init (context);
		}
#pragma warning restore 0169

		static IntPtr id_init_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='TrustDefenderMobile']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "GetInit_Landroid_content_Context_Handler")]
		public virtual unsafe void Init (global::Android.Content.Context context)
		{
			if (id_init_Landroid_content_Context_ == IntPtr.Zero)
				id_init_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "init", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_init_Lcom_threatmetrix_TrustDefenderMobile_Config_;
#pragma warning disable 0169
		static Delegate GetInit_Lcom_threatmetrix_TrustDefenderMobile_Config_Handler ()
		{
			if (cb_init_Lcom_threatmetrix_TrustDefenderMobile_Config_ == null)
				cb_init_Lcom_threatmetrix_TrustDefenderMobile_Config_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_Lcom_threatmetrix_TrustDefenderMobile_Config_);
			return cb_init_Lcom_threatmetrix_TrustDefenderMobile_Config_;
		}

		static void n_Init_Lcom_threatmetrix_TrustDefenderMobile_Config_ (IntPtr jnienv, IntPtr native__this, IntPtr native_config)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.TrustDefenderMobile __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.TrustDefenderMobile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Threatmetrix.TrustDefenderMobile.Config config = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (native_config, JniHandleOwnership.DoNotTransfer);
			__this.Init (config);
		}
#pragma warning restore 0169

		static IntPtr id_init_Lcom_threatmetrix_TrustDefenderMobile_Config_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='TrustDefenderMobile']/method[@name='init' and count(parameter)=1 and parameter[1][@type='com.threatmetrix.TrustDefenderMobile.Config']]"
		[Register ("init", "(Lcom/threatmetrix/TrustDefenderMobile/Config;)V", "GetInit_Lcom_threatmetrix_TrustDefenderMobile_Config_Handler")]
		public virtual unsafe void Init (global::Com.Threatmetrix.TrustDefenderMobile.Config config)
		{
			if (id_init_Lcom_threatmetrix_TrustDefenderMobile_Config_ == IntPtr.Zero)
				id_init_Lcom_threatmetrix_TrustDefenderMobile_Config_ = JNIEnv.GetMethodID (class_ref, "init", "(Lcom/threatmetrix/TrustDefenderMobile/Config;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (config);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Lcom_threatmetrix_TrustDefenderMobile_Config_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Lcom/threatmetrix/TrustDefenderMobile/Config;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_pauseLocationServices_Z;
#pragma warning disable 0169
		static Delegate GetPauseLocationServices_ZHandler ()
		{
			if (cb_pauseLocationServices_Z == null)
				cb_pauseLocationServices_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_PauseLocationServices_Z);
			return cb_pauseLocationServices_Z;
		}

		static void n_PauseLocationServices_Z (IntPtr jnienv, IntPtr native__this, bool pause)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.TrustDefenderMobile __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.TrustDefenderMobile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseLocationServices (pause);
		}
#pragma warning restore 0169

		static IntPtr id_pauseLocationServices_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='TrustDefenderMobile']/method[@name='pauseLocationServices' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("pauseLocationServices", "(Z)V", "GetPauseLocationServices_ZHandler")]
		public virtual unsafe void PauseLocationServices (bool pause)
		{
			if (id_pauseLocationServices_Z == IntPtr.Zero)
				id_pauseLocationServices_Z = JNIEnv.GetMethodID (class_ref, "pauseLocationServices", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (pause);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pauseLocationServices_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pauseLocationServices", "(Z)V"), __args);
			} finally {
			}
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
			global::Com.Threatmetrix.TrustDefenderMobile.TrustDefenderMobile __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.TrustDefenderMobile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TidyUp ();
		}
#pragma warning restore 0169

		static IntPtr id_tidyUp;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='TrustDefenderMobile']/method[@name='tidyUp' and count(parameter)=0]"
		[Register ("tidyUp", "()V", "GetTidyUpHandler")]
		public virtual unsafe void TidyUp ()
		{
			if (id_tidyUp == IntPtr.Zero)
				id_tidyUp = JNIEnv.GetMethodID (class_ref, "tidyUp", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_tidyUp);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "tidyUp", "()V"));
			} finally {
			}
		}

	}
}
