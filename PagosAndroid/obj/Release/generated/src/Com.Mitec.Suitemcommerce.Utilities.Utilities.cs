using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mitec.Suitemcommerce.Utilities {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Utilities']"
	[global::Android.Runtime.Register ("com/mitec/suitemcommerce/utilities/Utilities", DoNotGenerateAcw=true)]
	public partial class Utilities : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mitec/suitemcommerce/utilities/Utilities", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Utilities); }
		}

		protected Utilities (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Utilities']/constructor[@name='Utilities' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe Utilities (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				if (((object) this).GetType () != typeof (Utilities)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_getFechaActual_ISO8601;
		public static unsafe string FechaActual_ISO8601 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Utilities']/method[@name='getFechaActual_ISO8601' and count(parameter)=0]"
			[Register ("getFechaActual_ISO8601", "()Ljava/lang/String;", "GetGetFechaActual_ISO8601Handler")]
			get {
				if (id_getFechaActual_ISO8601 == IntPtr.Zero)
					id_getFechaActual_ISO8601 = JNIEnv.GetStaticMethodID (class_ref, "getFechaActual_ISO8601", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFechaActual_ISO8601), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_authenticateValidation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetAuthenticateValidation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_Handler ()
		{
			if (cb_authenticateValidation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_ == null)
				cb_authenticateValidation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AuthenticateValidation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_);
			return cb_authenticateValidation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_;
		}

		static IntPtr n_AuthenticateValidation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_branch, IntPtr native_country, IntPtr native_user, IntPtr native_password, IntPtr native_merchant, IntPtr native_currency, IntPtr native_authKey, IntPtr native_company, IntPtr native_environment, IntPtr native_context)
		{
			global::Com.Mitec.Suitemcommerce.Utilities.Utilities __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Utilities> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string branch = JNIEnv.GetString (native_branch, JniHandleOwnership.DoNotTransfer);
			string country = JNIEnv.GetString (native_country, JniHandleOwnership.DoNotTransfer);
			string user = JNIEnv.GetString (native_user, JniHandleOwnership.DoNotTransfer);
			string password = JNIEnv.GetString (native_password, JniHandleOwnership.DoNotTransfer);
			string merchant = JNIEnv.GetString (native_merchant, JniHandleOwnership.DoNotTransfer);
			global::Com.Mitec.Suitemcommerce.Utilities.Currency currency = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Currency> (native_currency, JniHandleOwnership.DoNotTransfer);
			string authKey = JNIEnv.GetString (native_authKey, JniHandleOwnership.DoNotTransfer);
			string company = JNIEnv.GetString (native_company, JniHandleOwnership.DoNotTransfer);
			global::Com.Mitec.Suitemcommerce.Utilities.Environment environment = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Environment> (native_environment, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AuthenticateValidation (branch, country, user, password, merchant, currency, authKey, company, environment, context));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_authenticateValidation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Utilities']/method[@name='authenticateValidation' and count(parameter)=10 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.mitec.suitemcommerce.utilities.Currency'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='com.mitec.suitemcommerce.utilities.Environment'] and parameter[10][@type='android.content.Context']]"
		[Register ("authenticateValidation", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/mitec/suitemcommerce/utilities/Currency;Ljava/lang/String;Ljava/lang/String;Lcom/mitec/suitemcommerce/utilities/Environment;Landroid/content/Context;)Lcom/mitec/suitemcommerce/beans/SuiteError;", "GetAuthenticateValidation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_Handler")]
		public virtual unsafe global::Com.Mitec.Suitemcommerce.Beans.SuiteError AuthenticateValidation (string branch, string country, string user, string password, string merchant, global::Com.Mitec.Suitemcommerce.Utilities.Currency currency, string authKey, string company, global::Com.Mitec.Suitemcommerce.Utilities.Environment environment, global::Android.Content.Context context)
		{
			if (id_authenticateValidation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_ == IntPtr.Zero)
				id_authenticateValidation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "authenticateValidation", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/mitec/suitemcommerce/utilities/Currency;Ljava/lang/String;Ljava/lang/String;Lcom/mitec/suitemcommerce/utilities/Environment;Landroid/content/Context;)Lcom/mitec/suitemcommerce/beans/SuiteError;");
			IntPtr native_branch = JNIEnv.NewString (branch);
			IntPtr native_country = JNIEnv.NewString (country);
			IntPtr native_user = JNIEnv.NewString (user);
			IntPtr native_password = JNIEnv.NewString (password);
			IntPtr native_merchant = JNIEnv.NewString (merchant);
			IntPtr native_authKey = JNIEnv.NewString (authKey);
			IntPtr native_company = JNIEnv.NewString (company);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (native_branch);
				__args [1] = new JValue (native_country);
				__args [2] = new JValue (native_user);
				__args [3] = new JValue (native_password);
				__args [4] = new JValue (native_merchant);
				__args [5] = new JValue (currency);
				__args [6] = new JValue (native_authKey);
				__args [7] = new JValue (native_company);
				__args [8] = new JValue (environment);
				__args [9] = new JValue (context);

				global::Com.Mitec.Suitemcommerce.Beans.SuiteError __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.SuiteError> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_authenticateValidation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.SuiteError> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "authenticateValidation", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/mitec/suitemcommerce/utilities/Currency;Ljava/lang/String;Ljava/lang/String;Lcom/mitec/suitemcommerce/utilities/Environment;Landroid/content/Context;)Lcom/mitec/suitemcommerce/beans/SuiteError;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_branch);
				JNIEnv.DeleteLocalRef (native_country);
				JNIEnv.DeleteLocalRef (native_user);
				JNIEnv.DeleteLocalRef (native_password);
				JNIEnv.DeleteLocalRef (native_merchant);
				JNIEnv.DeleteLocalRef (native_authKey);
				JNIEnv.DeleteLocalRef (native_company);
			}
		}

		static Delegate cb_cardAuthenticateValidation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCardAuthenticateValidation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_cardAuthenticateValidation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_cardAuthenticateValidation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CardAuthenticateValidation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_cardAuthenticateValidation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_CardAuthenticateValidation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ccName, IntPtr native_ccNumber, IntPtr native_ccExpMonth, IntPtr native_ccExpYear, IntPtr native_cvv)
		{
			global::Com.Mitec.Suitemcommerce.Utilities.Utilities __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Utilities> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string ccName = JNIEnv.GetString (native_ccName, JniHandleOwnership.DoNotTransfer);
			string ccNumber = JNIEnv.GetString (native_ccNumber, JniHandleOwnership.DoNotTransfer);
			string ccExpMonth = JNIEnv.GetString (native_ccExpMonth, JniHandleOwnership.DoNotTransfer);
			string ccExpYear = JNIEnv.GetString (native_ccExpYear, JniHandleOwnership.DoNotTransfer);
			string cvv = JNIEnv.GetString (native_cvv, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.CardAuthenticateValidation (ccName, ccNumber, ccExpMonth, ccExpYear, cvv));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_cardAuthenticateValidation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Utilities']/method[@name='cardAuthenticateValidation' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("cardAuthenticateValidation", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetCardAuthenticateValidation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string CardAuthenticateValidation (string ccName, string ccNumber, string ccExpMonth, string ccExpYear, string cvv)
		{
			if (id_cardAuthenticateValidation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_cardAuthenticateValidation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "cardAuthenticateValidation", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_ccName = JNIEnv.NewString (ccName);
			IntPtr native_ccNumber = JNIEnv.NewString (ccNumber);
			IntPtr native_ccExpMonth = JNIEnv.NewString (ccExpMonth);
			IntPtr native_ccExpYear = JNIEnv.NewString (ccExpYear);
			IntPtr native_cvv = JNIEnv.NewString (cvv);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_ccName);
				__args [1] = new JValue (native_ccNumber);
				__args [2] = new JValue (native_ccExpMonth);
				__args [3] = new JValue (native_ccExpYear);
				__args [4] = new JValue (native_cvv);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cardAuthenticateValidation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cardAuthenticateValidation", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_ccName);
				JNIEnv.DeleteLocalRef (native_ccNumber);
				JNIEnv.DeleteLocalRef (native_ccExpMonth);
				JNIEnv.DeleteLocalRef (native_ccExpYear);
				JNIEnv.DeleteLocalRef (native_cvv);
			}
		}

		static IntPtr id_fromCalendar_Ljava_util_Calendar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Utilities']/method[@name='fromCalendar' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Register ("fromCalendar", "(Ljava/util/Calendar;)Ljava/lang/String;", "")]
		public static unsafe string FromCalendar (global::Java.Util.Calendar calendar)
		{
			if (id_fromCalendar_Ljava_util_Calendar_ == IntPtr.Zero)
				id_fromCalendar_Ljava_util_Calendar_ = JNIEnv.GetStaticMethodID (class_ref, "fromCalendar", "(Ljava/util/Calendar;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (calendar);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromCalendar_Ljava_util_Calendar_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_generaReferenciaAtomatica_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Utilities']/method[@name='generaReferenciaAtomatica' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("generaReferenciaAtomatica", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GeneraReferenciaAtomatica (string branch)
		{
			if (id_generaReferenciaAtomatica_Ljava_lang_String_ == IntPtr.Zero)
				id_generaReferenciaAtomatica_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "generaReferenciaAtomatica", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_branch = JNIEnv.NewString (branch);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_branch);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_generaReferenciaAtomatica_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_branch);
			}
		}

		static Delegate cb_getDataXML_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDataXML_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getDataXML_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getDataXML_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDataXML_Ljava_lang_String_Ljava_lang_String_);
			return cb_getDataXML_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetDataXML_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_Tag, IntPtr native_XML)
		{
			global::Com.Mitec.Suitemcommerce.Utilities.Utilities __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Utilities> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string Tag = JNIEnv.GetString (native_Tag, JniHandleOwnership.DoNotTransfer);
			string XML = JNIEnv.GetString (native_XML, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetDataXML (Tag, XML));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDataXML_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Utilities']/method[@name='getDataXML' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getDataXML", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetDataXML_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string GetDataXML (string Tag, string XML)
		{
			if (id_getDataXML_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getDataXML_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getDataXML", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_Tag = JNIEnv.NewString (Tag);
			IntPtr native_XML = JNIEnv.NewString (XML);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_Tag);
				__args [1] = new JValue (native_XML);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDataXML_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataXML", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_Tag);
				JNIEnv.DeleteLocalRef (native_XML);
			}
		}

		static Delegate cb_paymentVaildate_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_PaymentType_Lcom_mitec_suitemcommerce_utilities_Currency_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetPaymentVaildate_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_PaymentType_Lcom_mitec_suitemcommerce_utilities_Currency_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_Handler ()
		{
			if (cb_paymentVaildate_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_PaymentType_Lcom_mitec_suitemcommerce_utilities_Currency_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_ == null)
				cb_paymentVaildate_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_PaymentType_Lcom_mitec_suitemcommerce_utilities_Currency_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PaymentVaildate_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_PaymentType_Lcom_mitec_suitemcommerce_utilities_Currency_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_);
			return cb_paymentVaildate_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_PaymentType_Lcom_mitec_suitemcommerce_utilities_Currency_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_;
		}

		static IntPtr n_PaymentVaildate_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_PaymentType_Lcom_mitec_suitemcommerce_utilities_Currency_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_amount, IntPtr native_reference, IntPtr native_paymentType, IntPtr native_currency, IntPtr native_company, IntPtr native_seed, IntPtr native_xmlM, IntPtr native_environment, IntPtr native_context)
		{
			global::Com.Mitec.Suitemcommerce.Utilities.Utilities __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Utilities> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string amount = JNIEnv.GetString (native_amount, JniHandleOwnership.DoNotTransfer);
			string reference = JNIEnv.GetString (native_reference, JniHandleOwnership.DoNotTransfer);
			global::Com.Mitec.Suitemcommerce.Utilities.PaymentType paymentType = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.PaymentType> (native_paymentType, JniHandleOwnership.DoNotTransfer);
			global::Com.Mitec.Suitemcommerce.Utilities.Currency currency = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Currency> (native_currency, JniHandleOwnership.DoNotTransfer);
			string company = JNIEnv.GetString (native_company, JniHandleOwnership.DoNotTransfer);
			string seed = JNIEnv.GetString (native_seed, JniHandleOwnership.DoNotTransfer);
			string xmlM = JNIEnv.GetString (native_xmlM, JniHandleOwnership.DoNotTransfer);
			global::Com.Mitec.Suitemcommerce.Utilities.Environment environment = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Environment> (native_environment, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PaymentVaildate (amount, reference, paymentType, currency, company, seed, xmlM, environment, context));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_paymentVaildate_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_PaymentType_Lcom_mitec_suitemcommerce_utilities_Currency_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Utilities']/method[@name='paymentVaildate' and count(parameter)=9 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.mitec.suitemcommerce.utilities.PaymentType'] and parameter[4][@type='com.mitec.suitemcommerce.utilities.Currency'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='com.mitec.suitemcommerce.utilities.Environment'] and parameter[9][@type='android.content.Context']]"
		[Register ("paymentVaildate", "(Ljava/lang/String;Ljava/lang/String;Lcom/mitec/suitemcommerce/utilities/PaymentType;Lcom/mitec/suitemcommerce/utilities/Currency;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/mitec/suitemcommerce/utilities/Environment;Landroid/content/Context;)Lcom/mitec/suitemcommerce/beans/SuiteError;", "GetPaymentVaildate_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_PaymentType_Lcom_mitec_suitemcommerce_utilities_Currency_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_Handler")]
		public virtual unsafe global::Com.Mitec.Suitemcommerce.Beans.SuiteError PaymentVaildate (string amount, string reference, global::Com.Mitec.Suitemcommerce.Utilities.PaymentType paymentType, global::Com.Mitec.Suitemcommerce.Utilities.Currency currency, string company, string seed, string xmlM, global::Com.Mitec.Suitemcommerce.Utilities.Environment environment, global::Android.Content.Context context)
		{
			if (id_paymentVaildate_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_PaymentType_Lcom_mitec_suitemcommerce_utilities_Currency_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_ == IntPtr.Zero)
				id_paymentVaildate_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_PaymentType_Lcom_mitec_suitemcommerce_utilities_Currency_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "paymentVaildate", "(Ljava/lang/String;Ljava/lang/String;Lcom/mitec/suitemcommerce/utilities/PaymentType;Lcom/mitec/suitemcommerce/utilities/Currency;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/mitec/suitemcommerce/utilities/Environment;Landroid/content/Context;)Lcom/mitec/suitemcommerce/beans/SuiteError;");
			IntPtr native_amount = JNIEnv.NewString (amount);
			IntPtr native_reference = JNIEnv.NewString (reference);
			IntPtr native_company = JNIEnv.NewString (company);
			IntPtr native_seed = JNIEnv.NewString (seed);
			IntPtr native_xmlM = JNIEnv.NewString (xmlM);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (native_amount);
				__args [1] = new JValue (native_reference);
				__args [2] = new JValue (paymentType);
				__args [3] = new JValue (currency);
				__args [4] = new JValue (native_company);
				__args [5] = new JValue (native_seed);
				__args [6] = new JValue (native_xmlM);
				__args [7] = new JValue (environment);
				__args [8] = new JValue (context);

				global::Com.Mitec.Suitemcommerce.Beans.SuiteError __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.SuiteError> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_paymentVaildate_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_PaymentType_Lcom_mitec_suitemcommerce_utilities_Currency_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.SuiteError> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "paymentVaildate", "(Ljava/lang/String;Ljava/lang/String;Lcom/mitec/suitemcommerce/utilities/PaymentType;Lcom/mitec/suitemcommerce/utilities/Currency;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/mitec/suitemcommerce/utilities/Environment;Landroid/content/Context;)Lcom/mitec/suitemcommerce/beans/SuiteError;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_amount);
				JNIEnv.DeleteLocalRef (native_reference);
				JNIEnv.DeleteLocalRef (native_company);
				JNIEnv.DeleteLocalRef (native_seed);
				JNIEnv.DeleteLocalRef (native_xmlM);
			}
		}

		static Delegate cb_paymentVaildate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_;
#pragma warning disable 0169
		static Delegate GetPaymentVaildate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_Handler ()
		{
			if (cb_paymentVaildate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_ == null)
				cb_paymentVaildate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PaymentVaildate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_);
			return cb_paymentVaildate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_;
		}

		static IntPtr n_PaymentVaildate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_company, IntPtr native_xmlA, IntPtr native_xmlM, IntPtr native_environment)
		{
			global::Com.Mitec.Suitemcommerce.Utilities.Utilities __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Utilities> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string company = JNIEnv.GetString (native_company, JniHandleOwnership.DoNotTransfer);
			string xmlA = JNIEnv.GetString (native_xmlA, JniHandleOwnership.DoNotTransfer);
			string xmlM = JNIEnv.GetString (native_xmlM, JniHandleOwnership.DoNotTransfer);
			global::Com.Mitec.Suitemcommerce.Utilities.Environment environment = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Environment> (native_environment, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PaymentVaildate (company, xmlA, xmlM, environment));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_paymentVaildate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Utilities']/method[@name='paymentVaildate' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.mitec.suitemcommerce.utilities.Environment']]"
		[Register ("paymentVaildate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/mitec/suitemcommerce/utilities/Environment;)Lcom/mitec/suitemcommerce/beans/SuiteError;", "GetPaymentVaildate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_Handler")]
		public virtual unsafe global::Com.Mitec.Suitemcommerce.Beans.SuiteError PaymentVaildate (string company, string xmlA, string xmlM, global::Com.Mitec.Suitemcommerce.Utilities.Environment environment)
		{
			if (id_paymentVaildate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_ == IntPtr.Zero)
				id_paymentVaildate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_ = JNIEnv.GetMethodID (class_ref, "paymentVaildate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/mitec/suitemcommerce/utilities/Environment;)Lcom/mitec/suitemcommerce/beans/SuiteError;");
			IntPtr native_company = JNIEnv.NewString (company);
			IntPtr native_xmlA = JNIEnv.NewString (xmlA);
			IntPtr native_xmlM = JNIEnv.NewString (xmlM);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_company);
				__args [1] = new JValue (native_xmlA);
				__args [2] = new JValue (native_xmlM);
				__args [3] = new JValue (environment);

				global::Com.Mitec.Suitemcommerce.Beans.SuiteError __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.SuiteError> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_paymentVaildate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Environment_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.SuiteError> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "paymentVaildate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/mitec/suitemcommerce/utilities/Environment;)Lcom/mitec/suitemcommerce/beans/SuiteError;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_company);
				JNIEnv.DeleteLocalRef (native_xmlA);
				JNIEnv.DeleteLocalRef (native_xmlM);
			}
		}

		static Delegate cb_paymentWithTokenValidate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetPaymentWithTokenValidate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_Handler ()
		{
			if (cb_paymentWithTokenValidate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_ == null)
				cb_paymentWithTokenValidate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PaymentWithTokenValidate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_);
			return cb_paymentWithTokenValidate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_;
		}

		static IntPtr n_PaymentWithTokenValidate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_company, IntPtr native_branch, IntPtr native_country, IntPtr native_user, IntPtr native_password, IntPtr native_merchant, IntPtr native_reference, IntPtr native_operationType, IntPtr native_token, IntPtr native_amount, IntPtr native_currency, IntPtr native_environment, IntPtr native_context)
		{
			global::Com.Mitec.Suitemcommerce.Utilities.Utilities __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Utilities> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string company = JNIEnv.GetString (native_company, JniHandleOwnership.DoNotTransfer);
			string branch = JNIEnv.GetString (native_branch, JniHandleOwnership.DoNotTransfer);
			string country = JNIEnv.GetString (native_country, JniHandleOwnership.DoNotTransfer);
			string user = JNIEnv.GetString (native_user, JniHandleOwnership.DoNotTransfer);
			string password = JNIEnv.GetString (native_password, JniHandleOwnership.DoNotTransfer);
			string merchant = JNIEnv.GetString (native_merchant, JniHandleOwnership.DoNotTransfer);
			string reference = JNIEnv.GetString (native_reference, JniHandleOwnership.DoNotTransfer);
			string operationType = JNIEnv.GetString (native_operationType, JniHandleOwnership.DoNotTransfer);
			string token = JNIEnv.GetString (native_token, JniHandleOwnership.DoNotTransfer);
			string amount = JNIEnv.GetString (native_amount, JniHandleOwnership.DoNotTransfer);
			global::Com.Mitec.Suitemcommerce.Utilities.Currency currency = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Currency> (native_currency, JniHandleOwnership.DoNotTransfer);
			global::Com.Mitec.Suitemcommerce.Utilities.Environment environment = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Environment> (native_environment, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PaymentWithTokenValidate (company, branch, country, user, password, merchant, reference, operationType, token, amount, currency, environment, context));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_paymentWithTokenValidate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Utilities']/method[@name='paymentWithTokenValidate' and count(parameter)=13 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='java.lang.String'] and parameter[10][@type='java.lang.String'] and parameter[11][@type='com.mitec.suitemcommerce.utilities.Currency'] and parameter[12][@type='com.mitec.suitemcommerce.utilities.Environment'] and parameter[13][@type='android.content.Context']]"
		[Register ("paymentWithTokenValidate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/mitec/suitemcommerce/utilities/Currency;Lcom/mitec/suitemcommerce/utilities/Environment;Landroid/content/Context;)Lcom/mitec/suitemcommerce/beans/SuiteError;", "GetPaymentWithTokenValidate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_Handler")]
		public virtual unsafe global::Com.Mitec.Suitemcommerce.Beans.SuiteError PaymentWithTokenValidate (string company, string branch, string country, string user, string password, string merchant, string reference, string operationType, string token, string amount, global::Com.Mitec.Suitemcommerce.Utilities.Currency currency, global::Com.Mitec.Suitemcommerce.Utilities.Environment environment, global::Android.Content.Context context)
		{
			if (id_paymentWithTokenValidate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_ == IntPtr.Zero)
				id_paymentWithTokenValidate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "paymentWithTokenValidate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/mitec/suitemcommerce/utilities/Currency;Lcom/mitec/suitemcommerce/utilities/Environment;Landroid/content/Context;)Lcom/mitec/suitemcommerce/beans/SuiteError;");
			IntPtr native_company = JNIEnv.NewString (company);
			IntPtr native_branch = JNIEnv.NewString (branch);
			IntPtr native_country = JNIEnv.NewString (country);
			IntPtr native_user = JNIEnv.NewString (user);
			IntPtr native_password = JNIEnv.NewString (password);
			IntPtr native_merchant = JNIEnv.NewString (merchant);
			IntPtr native_reference = JNIEnv.NewString (reference);
			IntPtr native_operationType = JNIEnv.NewString (operationType);
			IntPtr native_token = JNIEnv.NewString (token);
			IntPtr native_amount = JNIEnv.NewString (amount);
			try {
				JValue* __args = stackalloc JValue [13];
				__args [0] = new JValue (native_company);
				__args [1] = new JValue (native_branch);
				__args [2] = new JValue (native_country);
				__args [3] = new JValue (native_user);
				__args [4] = new JValue (native_password);
				__args [5] = new JValue (native_merchant);
				__args [6] = new JValue (native_reference);
				__args [7] = new JValue (native_operationType);
				__args [8] = new JValue (native_token);
				__args [9] = new JValue (native_amount);
				__args [10] = new JValue (currency);
				__args [11] = new JValue (environment);
				__args [12] = new JValue (context);

				global::Com.Mitec.Suitemcommerce.Beans.SuiteError __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.SuiteError> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_paymentWithTokenValidate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.SuiteError> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "paymentWithTokenValidate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/mitec/suitemcommerce/utilities/Currency;Lcom/mitec/suitemcommerce/utilities/Environment;Landroid/content/Context;)Lcom/mitec/suitemcommerce/beans/SuiteError;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_company);
				JNIEnv.DeleteLocalRef (native_branch);
				JNIEnv.DeleteLocalRef (native_country);
				JNIEnv.DeleteLocalRef (native_user);
				JNIEnv.DeleteLocalRef (native_password);
				JNIEnv.DeleteLocalRef (native_merchant);
				JNIEnv.DeleteLocalRef (native_reference);
				JNIEnv.DeleteLocalRef (native_operationType);
				JNIEnv.DeleteLocalRef (native_token);
				JNIEnv.DeleteLocalRef (native_amount);
			}
		}

		static IntPtr id_println_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Utilities']/method[@name='println' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("println", "(Ljava/lang/String;)V", "")]
		public static unsafe void Println (string msg)
		{
			if (id_println_Ljava_lang_String_ == IntPtr.Zero)
				id_println_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "println", "(Ljava/lang/String;)V");
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_msg);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_println_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static IntPtr id_stringToHex_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Utilities']/method[@name='stringToHex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("stringToHex", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string StringToHex (string arg)
		{
			if (id_stringToHex_Ljava_lang_String_ == IntPtr.Zero)
				id_stringToHex_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "stringToHex", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_arg = JNIEnv.NewString (arg);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_arg);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_stringToHex_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_arg);
			}
		}

		static Delegate cb_tokenizeValidate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetTokenizeValidate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_Handler ()
		{
			if (cb_tokenizeValidate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ == null)
				cb_tokenizeValidate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_TokenizeValidate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_);
			return cb_tokenizeValidate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_;
		}

		static IntPtr n_TokenizeValidate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_company, IntPtr native_branch, IntPtr native_user, IntPtr native_password, IntPtr native_context)
		{
			global::Com.Mitec.Suitemcommerce.Utilities.Utilities __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Utilities> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string company = JNIEnv.GetString (native_company, JniHandleOwnership.DoNotTransfer);
			string branch = JNIEnv.GetString (native_branch, JniHandleOwnership.DoNotTransfer);
			string user = JNIEnv.GetString (native_user, JniHandleOwnership.DoNotTransfer);
			string password = JNIEnv.GetString (native_password, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TokenizeValidate (company, branch, user, password, context));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_tokenizeValidate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Utilities']/method[@name='tokenizeValidate' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='android.content.Context']]"
		[Register ("tokenizeValidate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)Lcom/mitec/suitemcommerce/beans/SuiteError;", "GetTokenizeValidate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_Handler")]
		public virtual unsafe global::Com.Mitec.Suitemcommerce.Beans.SuiteError TokenizeValidate (string company, string branch, string user, string password, global::Android.Content.Context context)
		{
			if (id_tokenizeValidate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_tokenizeValidate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "tokenizeValidate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)Lcom/mitec/suitemcommerce/beans/SuiteError;");
			IntPtr native_company = JNIEnv.NewString (company);
			IntPtr native_branch = JNIEnv.NewString (branch);
			IntPtr native_user = JNIEnv.NewString (user);
			IntPtr native_password = JNIEnv.NewString (password);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_company);
				__args [1] = new JValue (native_branch);
				__args [2] = new JValue (native_user);
				__args [3] = new JValue (native_password);
				__args [4] = new JValue (context);

				global::Com.Mitec.Suitemcommerce.Beans.SuiteError __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.SuiteError> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_tokenizeValidate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.SuiteError> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "tokenizeValidate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)Lcom/mitec/suitemcommerce/beans/SuiteError;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_company);
				JNIEnv.DeleteLocalRef (native_branch);
				JNIEnv.DeleteLocalRef (native_user);
				JNIEnv.DeleteLocalRef (native_password);
			}
		}

	}
}
