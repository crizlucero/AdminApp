using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Threatmetrix.TrustDefenderMobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='Config']"
	[global::Android.Runtime.Register ("com/threatmetrix/TrustDefenderMobile/Config", DoNotGenerateAcw=true)]
	public partial class Config : global::Com.Threatmetrix.TrustDefenderMobile.BaseConfig {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/threatmetrix/TrustDefenderMobile/Config", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Config); }
		}

		protected Config (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='Config']/constructor[@name='Config' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Config ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Config)) {
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

		static Delegate cb_setApiKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetApiKey_Ljava_lang_String_Handler ()
		{
			if (cb_setApiKey_Ljava_lang_String_ == null)
				cb_setApiKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetApiKey_Ljava_lang_String_);
			return cb_setApiKey_Ljava_lang_String_;
		}

		static IntPtr n_SetApiKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_apiKey)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.Config __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string apiKey = JNIEnv.GetString (native_apiKey, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetApiKey (apiKey));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setApiKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='Config']/method[@name='setApiKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setApiKey", "(Ljava/lang/String;)Lcom/threatmetrix/TrustDefenderMobile/Config;", "GetSetApiKey_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Threatmetrix.TrustDefenderMobile.Config SetApiKey (string apiKey)
		{
			if (id_setApiKey_Ljava_lang_String_ == IntPtr.Zero)
				id_setApiKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setApiKey", "(Ljava/lang/String;)Lcom/threatmetrix/TrustDefenderMobile/Config;");
			IntPtr native_apiKey = JNIEnv.NewString (apiKey);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_apiKey);

				global::Com.Threatmetrix.TrustDefenderMobile.Config __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setApiKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setApiKey", "(Ljava/lang/String;)Lcom/threatmetrix/TrustDefenderMobile/Config;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_apiKey);
			}
		}

		static Delegate cb_setContext_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetSetContext_Landroid_content_Context_Handler ()
		{
			if (cb_setContext_Landroid_content_Context_ == null)
				cb_setContext_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetContext_Landroid_content_Context_);
			return cb_setContext_Landroid_content_Context_;
		}

		static IntPtr n_SetContext_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.Config __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetContext (context));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setContext_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='Config']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("setContext", "(Landroid/content/Context;)Lcom/threatmetrix/TrustDefenderMobile/Config;", "GetSetContext_Landroid_content_Context_Handler")]
		public virtual unsafe global::Com.Threatmetrix.TrustDefenderMobile.Config SetContext (global::Android.Content.Context context)
		{
			if (id_setContext_Landroid_content_Context_ == IntPtr.Zero)
				id_setContext_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "setContext", "(Landroid/content/Context;)Lcom/threatmetrix/TrustDefenderMobile/Config;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);

				global::Com.Threatmetrix.TrustDefenderMobile.Config __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setContext_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContext", "(Landroid/content/Context;)Lcom/threatmetrix/TrustDefenderMobile/Config;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setDisableAppHashing_Z;
#pragma warning disable 0169
		static Delegate GetSetDisableAppHashing_ZHandler ()
		{
			if (cb_setDisableAppHashing_Z == null)
				cb_setDisableAppHashing_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetDisableAppHashing_Z);
			return cb_setDisableAppHashing_Z;
		}

		static IntPtr n_SetDisableAppHashing_Z (IntPtr jnienv, IntPtr native__this, bool disableAppScan)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.Config __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDisableAppHashing (disableAppScan));
		}
#pragma warning restore 0169

		static IntPtr id_setDisableAppHashing_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='Config']/method[@name='setDisableAppHashing' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisableAppHashing", "(Z)Lcom/threatmetrix/TrustDefenderMobile/Config;", "GetSetDisableAppHashing_ZHandler")]
		public virtual unsafe global::Com.Threatmetrix.TrustDefenderMobile.Config SetDisableAppHashing (bool disableAppScan)
		{
			if (id_setDisableAppHashing_Z == IntPtr.Zero)
				id_setDisableAppHashing_Z = JNIEnv.GetMethodID (class_ref, "setDisableAppHashing", "(Z)Lcom/threatmetrix/TrustDefenderMobile/Config;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (disableAppScan);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDisableAppHashing_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisableAppHashing", "(Z)Lcom/threatmetrix/TrustDefenderMobile/Config;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDisableInitPackageScan_Z;
#pragma warning disable 0169
		static Delegate GetSetDisableInitPackageScan_ZHandler ()
		{
			if (cb_setDisableInitPackageScan_Z == null)
				cb_setDisableInitPackageScan_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetDisableInitPackageScan_Z);
			return cb_setDisableInitPackageScan_Z;
		}

		static IntPtr n_SetDisableInitPackageScan_Z (IntPtr jnienv, IntPtr native__this, bool disableInitPackageScan)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.Config __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDisableInitPackageScan (disableInitPackageScan));
		}
#pragma warning restore 0169

		static IntPtr id_setDisableInitPackageScan_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='Config']/method[@name='setDisableInitPackageScan' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisableInitPackageScan", "(Z)Lcom/threatmetrix/TrustDefenderMobile/Config;", "GetSetDisableInitPackageScan_ZHandler")]
		public virtual unsafe global::Com.Threatmetrix.TrustDefenderMobile.Config SetDisableInitPackageScan (bool disableInitPackageScan)
		{
			if (id_setDisableInitPackageScan_Z == IntPtr.Zero)
				id_setDisableInitPackageScan_Z = JNIEnv.GetMethodID (class_ref, "setDisableInitPackageScan", "(Z)Lcom/threatmetrix/TrustDefenderMobile/Config;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (disableInitPackageScan);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDisableInitPackageScan_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisableInitPackageScan", "(Z)Lcom/threatmetrix/TrustDefenderMobile/Config;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDisableProfilePackageScan_Z;
#pragma warning disable 0169
		static Delegate GetSetDisableProfilePackageScan_ZHandler ()
		{
			if (cb_setDisableProfilePackageScan_Z == null)
				cb_setDisableProfilePackageScan_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetDisableProfilePackageScan_Z);
			return cb_setDisableProfilePackageScan_Z;
		}

		static IntPtr n_SetDisableProfilePackageScan_Z (IntPtr jnienv, IntPtr native__this, bool disablePackageScan)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.Config __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDisableProfilePackageScan (disablePackageScan));
		}
#pragma warning restore 0169

		static IntPtr id_setDisableProfilePackageScan_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='Config']/method[@name='setDisableProfilePackageScan' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisableProfilePackageScan", "(Z)Lcom/threatmetrix/TrustDefenderMobile/Config;", "GetSetDisableProfilePackageScan_ZHandler")]
		public virtual unsafe global::Com.Threatmetrix.TrustDefenderMobile.Config SetDisableProfilePackageScan (bool disablePackageScan)
		{
			if (id_setDisableProfilePackageScan_Z == IntPtr.Zero)
				id_setDisableProfilePackageScan_Z = JNIEnv.GetMethodID (class_ref, "setDisableProfilePackageScan", "(Z)Lcom/threatmetrix/TrustDefenderMobile/Config;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (disablePackageScan);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDisableProfilePackageScan_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisableProfilePackageScan", "(Z)Lcom/threatmetrix/TrustDefenderMobile/Config;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDisableWebView_Z;
#pragma warning disable 0169
		static Delegate GetSetDisableWebView_ZHandler ()
		{
			if (cb_setDisableWebView_Z == null)
				cb_setDisableWebView_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetDisableWebView_Z);
			return cb_setDisableWebView_Z;
		}

		static IntPtr n_SetDisableWebView_Z (IntPtr jnienv, IntPtr native__this, bool disableWebView)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.Config __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDisableWebView (disableWebView));
		}
#pragma warning restore 0169

		static IntPtr id_setDisableWebView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='Config']/method[@name='setDisableWebView' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisableWebView", "(Z)Lcom/threatmetrix/TrustDefenderMobile/Config;", "GetSetDisableWebView_ZHandler")]
		public virtual unsafe global::Com.Threatmetrix.TrustDefenderMobile.Config SetDisableWebView (bool disableWebView)
		{
			if (id_setDisableWebView_Z == IntPtr.Zero)
				id_setDisableWebView_Z = JNIEnv.GetMethodID (class_ref, "setDisableWebView", "(Z)Lcom/threatmetrix/TrustDefenderMobile/Config;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (disableWebView);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDisableWebView_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisableWebView", "(Z)Lcom/threatmetrix/TrustDefenderMobile/Config;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setFPServer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFPServer_Ljava_lang_String_Handler ()
		{
			if (cb_setFPServer_Ljava_lang_String_ == null)
				cb_setFPServer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFPServer_Ljava_lang_String_);
			return cb_setFPServer_Ljava_lang_String_;
		}

		static IntPtr n_SetFPServer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fp_server)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.Config __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string fp_server = JNIEnv.GetString (native_fp_server, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFPServer (fp_server));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setFPServer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='Config']/method[@name='setFPServer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setFPServer", "(Ljava/lang/String;)Lcom/threatmetrix/TrustDefenderMobile/Config;", "GetSetFPServer_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Threatmetrix.TrustDefenderMobile.Config SetFPServer (string fp_server)
		{
			if (id_setFPServer_Ljava_lang_String_ == IntPtr.Zero)
				id_setFPServer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFPServer", "(Ljava/lang/String;)Lcom/threatmetrix/TrustDefenderMobile/Config;");
			IntPtr native_fp_server = JNIEnv.NewString (fp_server);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_fp_server);

				global::Com.Threatmetrix.TrustDefenderMobile.Config __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setFPServer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFPServer", "(Ljava/lang/String;)Lcom/threatmetrix/TrustDefenderMobile/Config;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fp_server);
			}
		}

		static Delegate cb_setHighPowerUpdateTime_J;
#pragma warning disable 0169
		static Delegate GetSetHighPowerUpdateTime_JHandler ()
		{
			if (cb_setHighPowerUpdateTime_J == null)
				cb_setHighPowerUpdateTime_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetHighPowerUpdateTime_J);
			return cb_setHighPowerUpdateTime_J;
		}

		static IntPtr n_SetHighPowerUpdateTime_J (IntPtr jnienv, IntPtr native__this, long highPowerUpdateTime)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.Config __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetHighPowerUpdateTime (highPowerUpdateTime));
		}
#pragma warning restore 0169

		static IntPtr id_setHighPowerUpdateTime_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='Config']/method[@name='setHighPowerUpdateTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setHighPowerUpdateTime", "(J)Lcom/threatmetrix/TrustDefenderMobile/Config;", "GetSetHighPowerUpdateTime_JHandler")]
		public virtual unsafe global::Com.Threatmetrix.TrustDefenderMobile.Config SetHighPowerUpdateTime (long highPowerUpdateTime)
		{
			if (id_setHighPowerUpdateTime_J == IntPtr.Zero)
				id_setHighPowerUpdateTime_J = JNIEnv.GetMethodID (class_ref, "setHighPowerUpdateTime", "(J)Lcom/threatmetrix/TrustDefenderMobile/Config;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (highPowerUpdateTime);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setHighPowerUpdateTime_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHighPowerUpdateTime", "(J)Lcom/threatmetrix/TrustDefenderMobile/Config;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setInitPackageScanTimeLimit_I;
#pragma warning disable 0169
		static Delegate GetSetInitPackageScanTimeLimit_IHandler ()
		{
			if (cb_setInitPackageScanTimeLimit_I == null)
				cb_setInitPackageScanTimeLimit_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetInitPackageScanTimeLimit_I);
			return cb_setInitPackageScanTimeLimit_I;
		}

		static IntPtr n_SetInitPackageScanTimeLimit_I (IntPtr jnienv, IntPtr native__this, int initPackageScanTimeLimit)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.Config __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetInitPackageScanTimeLimit (initPackageScanTimeLimit));
		}
#pragma warning restore 0169

		static IntPtr id_setInitPackageScanTimeLimit_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='Config']/method[@name='setInitPackageScanTimeLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setInitPackageScanTimeLimit", "(I)Lcom/threatmetrix/TrustDefenderMobile/Config;", "GetSetInitPackageScanTimeLimit_IHandler")]
		public virtual unsafe global::Com.Threatmetrix.TrustDefenderMobile.Config SetInitPackageScanTimeLimit (int initPackageScanTimeLimit)
		{
			if (id_setInitPackageScanTimeLimit_I == IntPtr.Zero)
				id_setInitPackageScanTimeLimit_I = JNIEnv.GetMethodID (class_ref, "setInitPackageScanTimeLimit", "(I)Lcom/threatmetrix/TrustDefenderMobile/Config;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (initPackageScanTimeLimit);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setInitPackageScanTimeLimit_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInitPackageScanTimeLimit", "(I)Lcom/threatmetrix/TrustDefenderMobile/Config;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setLocationAccuracy_I;
#pragma warning disable 0169
		static Delegate GetSetLocationAccuracy_IHandler ()
		{
			if (cb_setLocationAccuracy_I == null)
				cb_setLocationAccuracy_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetLocationAccuracy_I);
			return cb_setLocationAccuracy_I;
		}

		static IntPtr n_SetLocationAccuracy_I (IntPtr jnienv, IntPtr native__this, int accuracy)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.Config __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetLocationAccuracy (accuracy));
		}
#pragma warning restore 0169

		static IntPtr id_setLocationAccuracy_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='Config']/method[@name='setLocationAccuracy' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLocationAccuracy", "(I)Lcom/threatmetrix/TrustDefenderMobile/Config;", "GetSetLocationAccuracy_IHandler")]
		public virtual unsafe global::Com.Threatmetrix.TrustDefenderMobile.Config SetLocationAccuracy (int accuracy)
		{
			if (id_setLocationAccuracy_I == IntPtr.Zero)
				id_setLocationAccuracy_I = JNIEnv.GetMethodID (class_ref, "setLocationAccuracy", "(I)Lcom/threatmetrix/TrustDefenderMobile/Config;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (accuracy);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setLocationAccuracy_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocationAccuracy", "(I)Lcom/threatmetrix/TrustDefenderMobile/Config;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setLowPowerUpdateTime_J;
#pragma warning disable 0169
		static Delegate GetSetLowPowerUpdateTime_JHandler ()
		{
			if (cb_setLowPowerUpdateTime_J == null)
				cb_setLowPowerUpdateTime_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetLowPowerUpdateTime_J);
			return cb_setLowPowerUpdateTime_J;
		}

		static IntPtr n_SetLowPowerUpdateTime_J (IntPtr jnienv, IntPtr native__this, long lowPowerUpdateTime)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.Config __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetLowPowerUpdateTime (lowPowerUpdateTime));
		}
#pragma warning restore 0169

		static IntPtr id_setLowPowerUpdateTime_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='Config']/method[@name='setLowPowerUpdateTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setLowPowerUpdateTime", "(J)Lcom/threatmetrix/TrustDefenderMobile/Config;", "GetSetLowPowerUpdateTime_JHandler")]
		public virtual unsafe global::Com.Threatmetrix.TrustDefenderMobile.Config SetLowPowerUpdateTime (long lowPowerUpdateTime)
		{
			if (id_setLowPowerUpdateTime_J == IntPtr.Zero)
				id_setLowPowerUpdateTime_J = JNIEnv.GetMethodID (class_ref, "setLowPowerUpdateTime", "(J)Lcom/threatmetrix/TrustDefenderMobile/Config;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (lowPowerUpdateTime);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setLowPowerUpdateTime_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLowPowerUpdateTime", "(J)Lcom/threatmetrix/TrustDefenderMobile/Config;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setOptions_I;
#pragma warning disable 0169
		static Delegate GetSetOptions_IHandler ()
		{
			if (cb_setOptions_I == null)
				cb_setOptions_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetOptions_I);
			return cb_setOptions_I;
		}

		static IntPtr n_SetOptions_I (IntPtr jnienv, IntPtr native__this, int options)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.Config __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetOptions (options));
		}
#pragma warning restore 0169

		static IntPtr id_setOptions_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='Config']/method[@name='setOptions' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setOptions", "(I)Lcom/threatmetrix/TrustDefenderMobile/Config;", "GetSetOptions_IHandler")]
		public virtual unsafe global::Com.Threatmetrix.TrustDefenderMobile.Config SetOptions (int options)
		{
			if (id_setOptions_I == IntPtr.Zero)
				id_setOptions_I = JNIEnv.GetMethodID (class_ref, "setOptions", "(I)Lcom/threatmetrix/TrustDefenderMobile/Config;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (options);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setOptions_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOptions", "(I)Lcom/threatmetrix/TrustDefenderMobile/Config;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPackageScanTimeLimit_I;
#pragma warning disable 0169
		static Delegate GetSetPackageScanTimeLimit_IHandler ()
		{
			if (cb_setPackageScanTimeLimit_I == null)
				cb_setPackageScanTimeLimit_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetPackageScanTimeLimit_I);
			return cb_setPackageScanTimeLimit_I;
		}

		static IntPtr n_SetPackageScanTimeLimit_I (IntPtr jnienv, IntPtr native__this, int packageScanTimeLimit)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.Config __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetPackageScanTimeLimit (packageScanTimeLimit));
		}
#pragma warning restore 0169

		static IntPtr id_setPackageScanTimeLimit_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='Config']/method[@name='setPackageScanTimeLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPackageScanTimeLimit", "(I)Lcom/threatmetrix/TrustDefenderMobile/Config;", "GetSetPackageScanTimeLimit_IHandler")]
		public virtual unsafe global::Com.Threatmetrix.TrustDefenderMobile.Config SetPackageScanTimeLimit (int packageScanTimeLimit)
		{
			if (id_setPackageScanTimeLimit_I == IntPtr.Zero)
				id_setPackageScanTimeLimit_I = JNIEnv.GetMethodID (class_ref, "setPackageScanTimeLimit", "(I)Lcom/threatmetrix/TrustDefenderMobile/Config;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (packageScanTimeLimit);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPackageScanTimeLimit_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPackageScanTimeLimit", "(I)Lcom/threatmetrix/TrustDefenderMobile/Config;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRegisterForLocationServices_Z;
#pragma warning disable 0169
		static Delegate GetSetRegisterForLocationServices_ZHandler ()
		{
			if (cb_setRegisterForLocationServices_Z == null)
				cb_setRegisterForLocationServices_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetRegisterForLocationServices_Z);
			return cb_setRegisterForLocationServices_Z;
		}

		static IntPtr n_SetRegisterForLocationServices_Z (IntPtr jnienv, IntPtr native__this, bool registerForLocationServices)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.Config __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetRegisterForLocationServices (registerForLocationServices));
		}
#pragma warning restore 0169

		static IntPtr id_setRegisterForLocationServices_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='Config']/method[@name='setRegisterForLocationServices' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setRegisterForLocationServices", "(Z)Lcom/threatmetrix/TrustDefenderMobile/Config;", "GetSetRegisterForLocationServices_ZHandler")]
		public virtual unsafe global::Com.Threatmetrix.TrustDefenderMobile.Config SetRegisterForLocationServices (bool registerForLocationServices)
		{
			if (id_setRegisterForLocationServices_Z == IntPtr.Zero)
				id_setRegisterForLocationServices_Z = JNIEnv.GetMethodID (class_ref, "setRegisterForLocationServices", "(Z)Lcom/threatmetrix/TrustDefenderMobile/Config;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (registerForLocationServices);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setRegisterForLocationServices_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRegisterForLocationServices", "(Z)Lcom/threatmetrix/TrustDefenderMobile/Config;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetTimeout_IHandler ()
		{
			if (cb_setTimeout_I == null)
				cb_setTimeout_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetTimeout_I);
			return cb_setTimeout_I;
		}

		static IntPtr n_SetTimeout_I (IntPtr jnienv, IntPtr native__this, int timeout)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.Config __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTimeout (timeout));
		}
#pragma warning restore 0169

		static IntPtr id_setTimeout_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='Config']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTimeout", "(I)Lcom/threatmetrix/TrustDefenderMobile/Config;", "GetSetTimeout_IHandler")]
		public virtual unsafe global::Com.Threatmetrix.TrustDefenderMobile.Config SetTimeout (int timeout)
		{
			if (id_setTimeout_I == IntPtr.Zero)
				id_setTimeout_I = JNIEnv.GetMethodID (class_ref, "setTimeout", "(I)Lcom/threatmetrix/TrustDefenderMobile/Config;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (timeout);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTimeout_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.Config> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeout", "(I)Lcom/threatmetrix/TrustDefenderMobile/Config;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
