using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mitec.Suitemcommerce.Xml {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mitec.suitemcommerce.xml']/class[@name='XmlGenerator']"
	[global::Android.Runtime.Register ("com/mitec/suitemcommerce/xml/XmlGenerator", DoNotGenerateAcw=true)]
	public partial class XmlGenerator : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mitec/suitemcommerce/xml/XmlGenerator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (XmlGenerator); }
		}

		protected XmlGenerator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mitec.suitemcommerce.xml']/class[@name='XmlGenerator']/constructor[@name='XmlGenerator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe XmlGenerator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (XmlGenerator)) {
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

		static Delegate cb_generatePaymentWithToken_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGeneratePaymentWithToken_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_generatePaymentWithToken_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_generatePaymentWithToken_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GeneratePaymentWithToken_Ljava_lang_String_Ljava_lang_String_);
			return cb_generatePaymentWithToken_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GeneratePaymentWithToken_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data0, IntPtr native_datas)
		{
			global::Com.Mitec.Suitemcommerce.Xml.XmlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Xml.XmlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string data0 = JNIEnv.GetString (native_data0, JniHandleOwnership.DoNotTransfer);
			string datas = JNIEnv.GetString (native_datas, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GeneratePaymentWithToken (data0, datas));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_generatePaymentWithToken_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.xml']/class[@name='XmlGenerator']/method[@name='generatePaymentWithToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("generatePaymentWithToken", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGeneratePaymentWithToken_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string GeneratePaymentWithToken (string data0, string datas)
		{
			if (id_generatePaymentWithToken_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_generatePaymentWithToken_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "generatePaymentWithToken", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_data0 = JNIEnv.NewString (data0);
			IntPtr native_datas = JNIEnv.NewString (datas);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_data0);
				__args [1] = new JValue (native_datas);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generatePaymentWithToken_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "generatePaymentWithToken", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data0);
				JNIEnv.DeleteLocalRef (native_datas);
			}
		}

		static Delegate cb_generatePublicKey;
#pragma warning disable 0169
		static Delegate GetGeneratePublicKeyHandler ()
		{
			if (cb_generatePublicKey == null)
				cb_generatePublicKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GeneratePublicKey);
			return cb_generatePublicKey;
		}

		static IntPtr n_GeneratePublicKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Xml.XmlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Xml.XmlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GeneratePublicKey ());
		}
#pragma warning restore 0169

		static IntPtr id_generatePublicKey;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.xml']/class[@name='XmlGenerator']/method[@name='generatePublicKey' and count(parameter)=0]"
		[Register ("generatePublicKey", "()Ljava/lang/String;", "GetGeneratePublicKeyHandler")]
		public virtual unsafe string GeneratePublicKey ()
		{
			if (id_generatePublicKey == IntPtr.Zero)
				id_generatePublicKey = JNIEnv.GetMethodID (class_ref, "generatePublicKey", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generatePublicKey), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "generatePublicKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_generateToken_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGenerateToken_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_generateToken_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_generateToken_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GenerateToken_Ljava_lang_String_Ljava_lang_String_);
			return cb_generateToken_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GenerateToken_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data0, IntPtr native_datas)
		{
			global::Com.Mitec.Suitemcommerce.Xml.XmlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Xml.XmlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string data0 = JNIEnv.GetString (native_data0, JniHandleOwnership.DoNotTransfer);
			string datas = JNIEnv.GetString (native_datas, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GenerateToken (data0, datas));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_generateToken_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.xml']/class[@name='XmlGenerator']/method[@name='generateToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("generateToken", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGenerateToken_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string GenerateToken (string data0, string datas)
		{
			if (id_generateToken_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_generateToken_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "generateToken", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_data0 = JNIEnv.NewString (data0);
			IntPtr native_datas = JNIEnv.NewString (datas);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_data0);
				__args [1] = new JValue (native_datas);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generateToken_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "generateToken", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data0);
				JNIEnv.DeleteLocalRef (native_datas);
			}
		}

		static Delegate cb_generateXMLA_Lcom_mitec_suitemcommerce_utilities_PaymentType_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_;
#pragma warning disable 0169
		static Delegate GetGenerateXMLA_Lcom_mitec_suitemcommerce_utilities_PaymentType_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_Handler ()
		{
			if (cb_generateXMLA_Lcom_mitec_suitemcommerce_utilities_PaymentType_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_ == null)
				cb_generateXMLA_Lcom_mitec_suitemcommerce_utilities_PaymentType_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GenerateXMLA_Lcom_mitec_suitemcommerce_utilities_PaymentType_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_);
			return cb_generateXMLA_Lcom_mitec_suitemcommerce_utilities_PaymentType_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_;
		}

		static IntPtr n_GenerateXMLA_Lcom_mitec_suitemcommerce_utilities_PaymentType_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paymentType, IntPtr native_amount, IntPtr native_reference, IntPtr native_currency)
		{
			global::Com.Mitec.Suitemcommerce.Xml.XmlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Xml.XmlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mitec.Suitemcommerce.Utilities.PaymentType paymentType = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.PaymentType> (native_paymentType, JniHandleOwnership.DoNotTransfer);
			string amount = JNIEnv.GetString (native_amount, JniHandleOwnership.DoNotTransfer);
			string reference = JNIEnv.GetString (native_reference, JniHandleOwnership.DoNotTransfer);
			global::Com.Mitec.Suitemcommerce.Utilities.Currency currency = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Currency> (native_currency, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GenerateXMLA (paymentType, amount, reference, currency));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_generateXMLA_Lcom_mitec_suitemcommerce_utilities_PaymentType_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.xml']/class[@name='XmlGenerator']/method[@name='generateXMLA' and count(parameter)=4 and parameter[1][@type='com.mitec.suitemcommerce.utilities.PaymentType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.mitec.suitemcommerce.utilities.Currency']]"
		[Register ("generateXMLA", "(Lcom/mitec/suitemcommerce/utilities/PaymentType;Ljava/lang/String;Ljava/lang/String;Lcom/mitec/suitemcommerce/utilities/Currency;)Ljava/lang/String;", "GetGenerateXMLA_Lcom_mitec_suitemcommerce_utilities_PaymentType_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_Handler")]
		public virtual unsafe string GenerateXMLA (global::Com.Mitec.Suitemcommerce.Utilities.PaymentType paymentType, string amount, string reference, global::Com.Mitec.Suitemcommerce.Utilities.Currency currency)
		{
			if (id_generateXMLA_Lcom_mitec_suitemcommerce_utilities_PaymentType_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_ == IntPtr.Zero)
				id_generateXMLA_Lcom_mitec_suitemcommerce_utilities_PaymentType_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_ = JNIEnv.GetMethodID (class_ref, "generateXMLA", "(Lcom/mitec/suitemcommerce/utilities/PaymentType;Ljava/lang/String;Ljava/lang/String;Lcom/mitec/suitemcommerce/utilities/Currency;)Ljava/lang/String;");
			IntPtr native_amount = JNIEnv.NewString (amount);
			IntPtr native_reference = JNIEnv.NewString (reference);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (paymentType);
				__args [1] = new JValue (native_amount);
				__args [2] = new JValue (native_reference);
				__args [3] = new JValue (currency);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generateXMLA_Lcom_mitec_suitemcommerce_utilities_PaymentType_Ljava_lang_String_Ljava_lang_String_Lcom_mitec_suitemcommerce_utilities_Currency_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "generateXMLA", "(Lcom/mitec/suitemcommerce/utilities/PaymentType;Ljava/lang/String;Ljava/lang/String;Lcom/mitec/suitemcommerce/utilities/Currency;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_amount);
				JNIEnv.DeleteLocalRef (native_reference);
			}
		}

		static Delegate cb_generateXMLPaymentWithToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGenerateXMLPaymentWithToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_generateXMLPaymentWithToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_generateXMLPaymentWithToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GenerateXMLPaymentWithToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_generateXMLPaymentWithToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GenerateXMLPaymentWithToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_company, IntPtr native_branch, IntPtr native_country, IntPtr native_user, IntPtr native_pws, IntPtr native_merchant, IntPtr native_reference, IntPtr native_operationType, IntPtr native_token, IntPtr native_amount, IntPtr native_currency, IntPtr native_device, IntPtr native_session)
		{
			global::Com.Mitec.Suitemcommerce.Xml.XmlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Xml.XmlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string company = JNIEnv.GetString (native_company, JniHandleOwnership.DoNotTransfer);
			string branch = JNIEnv.GetString (native_branch, JniHandleOwnership.DoNotTransfer);
			string country = JNIEnv.GetString (native_country, JniHandleOwnership.DoNotTransfer);
			string user = JNIEnv.GetString (native_user, JniHandleOwnership.DoNotTransfer);
			string pws = JNIEnv.GetString (native_pws, JniHandleOwnership.DoNotTransfer);
			string merchant = JNIEnv.GetString (native_merchant, JniHandleOwnership.DoNotTransfer);
			string reference = JNIEnv.GetString (native_reference, JniHandleOwnership.DoNotTransfer);
			string operationType = JNIEnv.GetString (native_operationType, JniHandleOwnership.DoNotTransfer);
			string token = JNIEnv.GetString (native_token, JniHandleOwnership.DoNotTransfer);
			string amount = JNIEnv.GetString (native_amount, JniHandleOwnership.DoNotTransfer);
			string currency = JNIEnv.GetString (native_currency, JniHandleOwnership.DoNotTransfer);
			string device = JNIEnv.GetString (native_device, JniHandleOwnership.DoNotTransfer);
			string session = JNIEnv.GetString (native_session, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GenerateXMLPaymentWithToken (company, branch, country, user, pws, merchant, reference, operationType, token, amount, currency, device, session));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_generateXMLPaymentWithToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.xml']/class[@name='XmlGenerator']/method[@name='generateXMLPaymentWithToken' and count(parameter)=13 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='java.lang.String'] and parameter[10][@type='java.lang.String'] and parameter[11][@type='java.lang.String'] and parameter[12][@type='java.lang.String'] and parameter[13][@type='java.lang.String']]"
		[Register ("generateXMLPaymentWithToken", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGenerateXMLPaymentWithToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string GenerateXMLPaymentWithToken (string company, string branch, string country, string user, string pws, string merchant, string reference, string operationType, string token, string amount, string currency, string device, string session)
		{
			if (id_generateXMLPaymentWithToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_generateXMLPaymentWithToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "generateXMLPaymentWithToken", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_company = JNIEnv.NewString (company);
			IntPtr native_branch = JNIEnv.NewString (branch);
			IntPtr native_country = JNIEnv.NewString (country);
			IntPtr native_user = JNIEnv.NewString (user);
			IntPtr native_pws = JNIEnv.NewString (pws);
			IntPtr native_merchant = JNIEnv.NewString (merchant);
			IntPtr native_reference = JNIEnv.NewString (reference);
			IntPtr native_operationType = JNIEnv.NewString (operationType);
			IntPtr native_token = JNIEnv.NewString (token);
			IntPtr native_amount = JNIEnv.NewString (amount);
			IntPtr native_currency = JNIEnv.NewString (currency);
			IntPtr native_device = JNIEnv.NewString (device);
			IntPtr native_session = JNIEnv.NewString (session);
			try {
				JValue* __args = stackalloc JValue [13];
				__args [0] = new JValue (native_company);
				__args [1] = new JValue (native_branch);
				__args [2] = new JValue (native_country);
				__args [3] = new JValue (native_user);
				__args [4] = new JValue (native_pws);
				__args [5] = new JValue (native_merchant);
				__args [6] = new JValue (native_reference);
				__args [7] = new JValue (native_operationType);
				__args [8] = new JValue (native_token);
				__args [9] = new JValue (native_amount);
				__args [10] = new JValue (native_currency);
				__args [11] = new JValue (native_device);
				__args [12] = new JValue (native_session);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generateXMLPaymentWithToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "generateXMLPaymentWithToken", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_company);
				JNIEnv.DeleteLocalRef (native_branch);
				JNIEnv.DeleteLocalRef (native_country);
				JNIEnv.DeleteLocalRef (native_user);
				JNIEnv.DeleteLocalRef (native_pws);
				JNIEnv.DeleteLocalRef (native_merchant);
				JNIEnv.DeleteLocalRef (native_reference);
				JNIEnv.DeleteLocalRef (native_operationType);
				JNIEnv.DeleteLocalRef (native_token);
				JNIEnv.DeleteLocalRef (native_amount);
				JNIEnv.DeleteLocalRef (native_currency);
				JNIEnv.DeleteLocalRef (native_device);
				JNIEnv.DeleteLocalRef (native_session);
			}
		}

		static Delegate cb_generateXMLToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGenerateXMLToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_generateXMLToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_generateXMLToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GenerateXMLToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_generateXMLToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GenerateXMLToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_company, IntPtr native_branch, IntPtr native_user, IntPtr native_pws, IntPtr native_card, IntPtr native_reference, IntPtr native_device, IntPtr native_session)
		{
			global::Com.Mitec.Suitemcommerce.Xml.XmlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Xml.XmlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string company = JNIEnv.GetString (native_company, JniHandleOwnership.DoNotTransfer);
			string branch = JNIEnv.GetString (native_branch, JniHandleOwnership.DoNotTransfer);
			string user = JNIEnv.GetString (native_user, JniHandleOwnership.DoNotTransfer);
			string pws = JNIEnv.GetString (native_pws, JniHandleOwnership.DoNotTransfer);
			string card = JNIEnv.GetString (native_card, JniHandleOwnership.DoNotTransfer);
			string reference = JNIEnv.GetString (native_reference, JniHandleOwnership.DoNotTransfer);
			string device = JNIEnv.GetString (native_device, JniHandleOwnership.DoNotTransfer);
			string session = JNIEnv.GetString (native_session, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GenerateXMLToken (company, branch, user, pws, card, reference, device, session));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_generateXMLToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.xml']/class[@name='XmlGenerator']/method[@name='generateXMLToken' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String']]"
		[Register ("generateXMLToken", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGenerateXMLToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string GenerateXMLToken (string company, string branch, string user, string pws, string card, string reference, string device, string session)
		{
			if (id_generateXMLToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_generateXMLToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "generateXMLToken", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_company = JNIEnv.NewString (company);
			IntPtr native_branch = JNIEnv.NewString (branch);
			IntPtr native_user = JNIEnv.NewString (user);
			IntPtr native_pws = JNIEnv.NewString (pws);
			IntPtr native_card = JNIEnv.NewString (card);
			IntPtr native_reference = JNIEnv.NewString (reference);
			IntPtr native_device = JNIEnv.NewString (device);
			IntPtr native_session = JNIEnv.NewString (session);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_company);
				__args [1] = new JValue (native_branch);
				__args [2] = new JValue (native_user);
				__args [3] = new JValue (native_pws);
				__args [4] = new JValue (native_card);
				__args [5] = new JValue (native_reference);
				__args [6] = new JValue (native_device);
				__args [7] = new JValue (native_session);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generateXMLToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "generateXMLToken", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_company);
				JNIEnv.DeleteLocalRef (native_branch);
				JNIEnv.DeleteLocalRef (native_user);
				JNIEnv.DeleteLocalRef (native_pws);
				JNIEnv.DeleteLocalRef (native_card);
				JNIEnv.DeleteLocalRef (native_reference);
				JNIEnv.DeleteLocalRef (native_device);
				JNIEnv.DeleteLocalRef (native_session);
			}
		}

	}
}
