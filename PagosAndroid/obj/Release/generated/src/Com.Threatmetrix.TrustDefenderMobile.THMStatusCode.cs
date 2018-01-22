using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Threatmetrix.TrustDefenderMobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='THMStatusCode']"
	[global::Android.Runtime.Register ("com/threatmetrix/TrustDefenderMobile/THMStatusCode", DoNotGenerateAcw=true)]
	public sealed partial class THMStatusCode : global::Java.Lang.Enum {


		static IntPtr THM_ConfigurationError_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='THMStatusCode']/field[@name='THM_ConfigurationError']"
		[Register ("THM_ConfigurationError")]
		public static global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode THMConfigurationError {
			get {
				if (THM_ConfigurationError_jfieldId == IntPtr.Zero)
					THM_ConfigurationError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THM_ConfigurationError", "Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THM_ConfigurationError_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr THM_Connection_Error_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='THMStatusCode']/field[@name='THM_Connection_Error']"
		[Register ("THM_Connection_Error")]
		public static global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode THMConnectionError {
			get {
				if (THM_Connection_Error_jfieldId == IntPtr.Zero)
					THM_Connection_Error_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THM_Connection_Error", "Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THM_Connection_Error_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr THM_HostNotFound_Error_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='THMStatusCode']/field[@name='THM_HostNotFound_Error']"
		[Register ("THM_HostNotFound_Error")]
		public static global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode THMHostNotFoundError {
			get {
				if (THM_HostNotFound_Error_jfieldId == IntPtr.Zero)
					THM_HostNotFound_Error_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THM_HostNotFound_Error", "Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THM_HostNotFound_Error_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr THM_HostVerification_Error_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='THMStatusCode']/field[@name='THM_HostVerification_Error']"
		[Register ("THM_HostVerification_Error")]
		public static global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode THMHostVerificationError {
			get {
				if (THM_HostVerification_Error_jfieldId == IntPtr.Zero)
					THM_HostVerification_Error_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THM_HostVerification_Error", "Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THM_HostVerification_Error_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr THM_Internal_Error_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='THMStatusCode']/field[@name='THM_Internal_Error']"
		[Register ("THM_Internal_Error")]
		public static global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode THMInternalError {
			get {
				if (THM_Internal_Error_jfieldId == IntPtr.Zero)
					THM_Internal_Error_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THM_Internal_Error", "Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THM_Internal_Error_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr THM_Interrupted_Error_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='THMStatusCode']/field[@name='THM_Interrupted_Error']"
		[Register ("THM_Interrupted_Error")]
		public static global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode THMInterruptedError {
			get {
				if (THM_Interrupted_Error_jfieldId == IntPtr.Zero)
					THM_Interrupted_Error_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THM_Interrupted_Error", "Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THM_Interrupted_Error_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr THM_InvalidOrgID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='THMStatusCode']/field[@name='THM_InvalidOrgID']"
		[Register ("THM_InvalidOrgID")]
		public static global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode THMInvalidOrgID {
			get {
				if (THM_InvalidOrgID_jfieldId == IntPtr.Zero)
					THM_InvalidOrgID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THM_InvalidOrgID", "Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THM_InvalidOrgID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr THM_NetworkTimeout_Error_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='THMStatusCode']/field[@name='THM_NetworkTimeout_Error']"
		[Register ("THM_NetworkTimeout_Error")]
		public static global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode THMNetworkTimeoutError {
			get {
				if (THM_NetworkTimeout_Error_jfieldId == IntPtr.Zero)
					THM_NetworkTimeout_Error_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THM_NetworkTimeout_Error", "Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THM_NetworkTimeout_Error_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr THM_NotYet_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='THMStatusCode']/field[@name='THM_NotYet']"
		[Register ("THM_NotYet")]
		public static global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode THMNotYet {
			get {
				if (THM_NotYet_jfieldId == IntPtr.Zero)
					THM_NotYet_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THM_NotYet", "Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THM_NotYet_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr THM_OK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='THMStatusCode']/field[@name='THM_OK']"
		[Register ("THM_OK")]
		public static global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode ThmOk {
			get {
				if (THM_OK_jfieldId == IntPtr.Zero)
					THM_OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THM_OK", "Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THM_OK_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr THM_PartialProfile_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='THMStatusCode']/field[@name='THM_PartialProfile']"
		[Register ("THM_PartialProfile")]
		public static global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode THMPartialProfile {
			get {
				if (THM_PartialProfile_jfieldId == IntPtr.Zero)
					THM_PartialProfile_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THM_PartialProfile", "Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THM_PartialProfile_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/threatmetrix/TrustDefenderMobile/THMStatusCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (THMStatusCode); }
		}

		internal THMStatusCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDesc;
		public unsafe string Desc {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='THMStatusCode']/method[@name='getDesc' and count(parameter)=0]"
			[Register ("getDesc", "()Ljava/lang/String;", "GetGetDescHandler")]
			get {
				if (id_getDesc == IntPtr.Zero)
					id_getDesc = JNIEnv.GetMethodID (class_ref, "getDesc", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDesc), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='THMStatusCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;", "")]
		public static unsafe global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode __ret = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='THMStatusCode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;", "")]
		public static unsafe global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;");
			try {
				return (global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode));
			} finally {
			}
		}

	}
}
