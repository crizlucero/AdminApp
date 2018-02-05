using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mitec.Suitemcommerce.Beans {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenization']"
	[global::Android.Runtime.Register ("com/mitec/suitemcommerce/beans/BeanTokenization", DoNotGenerateAcw=true)]
	public partial class BeanTokenization : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mitec/suitemcommerce/beans/BeanTokenization", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BeanTokenization); }
		}

		protected BeanTokenization (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenization']/constructor[@name='BeanTokenization' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BeanTokenization ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BeanTokenization)) {
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

		static Delegate cb_getAmount;
#pragma warning disable 0169
		static Delegate GetGetAmountHandler ()
		{
			if (cb_getAmount == null)
				cb_getAmount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAmount);
			return cb_getAmount;
		}

		static IntPtr n_GetAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Amount);
		}
#pragma warning restore 0169

		static Delegate cb_setAmount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAmount_Ljava_lang_String_Handler ()
		{
			if (cb_setAmount_Ljava_lang_String_ == null)
				cb_setAmount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAmount_Ljava_lang_String_);
			return cb_setAmount_Ljava_lang_String_;
		}

		static void n_SetAmount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_amount)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string amount = JNIEnv.GetString (native_amount, JniHandleOwnership.DoNotTransfer);
			__this.Amount = amount;
		}
#pragma warning restore 0169

		static IntPtr id_getAmount;
		static IntPtr id_setAmount_Ljava_lang_String_;
		public virtual unsafe string Amount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenization']/method[@name='getAmount' and count(parameter)=0]"
			[Register ("getAmount", "()Ljava/lang/String;", "GetGetAmountHandler")]
			get {
				if (id_getAmount == IntPtr.Zero)
					id_getAmount = JNIEnv.GetMethodID (class_ref, "getAmount", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAmount), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAmount", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenization']/method[@name='setAmount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAmount", "(Ljava/lang/String;)V", "GetSetAmount_Ljava_lang_String_Handler")]
			set {
				if (id_setAmount_Ljava_lang_String_ == IntPtr.Zero)
					id_setAmount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAmount", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAmount_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAmount", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBranch;
#pragma warning disable 0169
		static Delegate GetGetBranchHandler ()
		{
			if (cb_getBranch == null)
				cb_getBranch = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBranch);
			return cb_getBranch;
		}

		static IntPtr n_GetBranch (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Branch);
		}
#pragma warning restore 0169

		static Delegate cb_setBranch_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBranch_Ljava_lang_String_Handler ()
		{
			if (cb_setBranch_Ljava_lang_String_ == null)
				cb_setBranch_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBranch_Ljava_lang_String_);
			return cb_setBranch_Ljava_lang_String_;
		}

		static void n_SetBranch_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_branch)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string branch = JNIEnv.GetString (native_branch, JniHandleOwnership.DoNotTransfer);
			__this.Branch = branch;
		}
#pragma warning restore 0169

		static IntPtr id_getBranch;
		static IntPtr id_setBranch_Ljava_lang_String_;
		public virtual unsafe string Branch {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenization']/method[@name='getBranch' and count(parameter)=0]"
			[Register ("getBranch", "()Ljava/lang/String;", "GetGetBranchHandler")]
			get {
				if (id_getBranch == IntPtr.Zero)
					id_getBranch = JNIEnv.GetMethodID (class_ref, "getBranch", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBranch), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBranch", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenization']/method[@name='setBranch' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBranch", "(Ljava/lang/String;)V", "GetSetBranch_Ljava_lang_String_Handler")]
			set {
				if (id_setBranch_Ljava_lang_String_ == IntPtr.Zero)
					id_setBranch_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBranch", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBranch_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBranch", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCompany;
#pragma warning disable 0169
		static Delegate GetGetCompanyHandler ()
		{
			if (cb_getCompany == null)
				cb_getCompany = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCompany);
			return cb_getCompany;
		}

		static IntPtr n_GetCompany (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Company);
		}
#pragma warning restore 0169

		static Delegate cb_setCompany_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCompany_Ljava_lang_String_Handler ()
		{
			if (cb_setCompany_Ljava_lang_String_ == null)
				cb_setCompany_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCompany_Ljava_lang_String_);
			return cb_setCompany_Ljava_lang_String_;
		}

		static void n_SetCompany_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_company)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string company = JNIEnv.GetString (native_company, JniHandleOwnership.DoNotTransfer);
			__this.Company = company;
		}
#pragma warning restore 0169

		static IntPtr id_getCompany;
		static IntPtr id_setCompany_Ljava_lang_String_;
		public virtual unsafe string Company {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenization']/method[@name='getCompany' and count(parameter)=0]"
			[Register ("getCompany", "()Ljava/lang/String;", "GetGetCompanyHandler")]
			get {
				if (id_getCompany == IntPtr.Zero)
					id_getCompany = JNIEnv.GetMethodID (class_ref, "getCompany", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCompany), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCompany", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenization']/method[@name='setCompany' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCompany", "(Ljava/lang/String;)V", "GetSetCompany_Ljava_lang_String_Handler")]
			set {
				if (id_setCompany_Ljava_lang_String_ == IntPtr.Zero)
					id_setCompany_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCompany", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCompany_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCompany", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCountry;
#pragma warning disable 0169
		static Delegate GetGetCountryHandler ()
		{
			if (cb_getCountry == null)
				cb_getCountry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCountry);
			return cb_getCountry;
		}

		static IntPtr n_GetCountry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Country);
		}
#pragma warning restore 0169

		static Delegate cb_setCountry_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCountry_Ljava_lang_String_Handler ()
		{
			if (cb_setCountry_Ljava_lang_String_ == null)
				cb_setCountry_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCountry_Ljava_lang_String_);
			return cb_setCountry_Ljava_lang_String_;
		}

		static void n_SetCountry_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_country)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string country = JNIEnv.GetString (native_country, JniHandleOwnership.DoNotTransfer);
			__this.Country = country;
		}
#pragma warning restore 0169

		static IntPtr id_getCountry;
		static IntPtr id_setCountry_Ljava_lang_String_;
		public virtual unsafe string Country {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenization']/method[@name='getCountry' and count(parameter)=0]"
			[Register ("getCountry", "()Ljava/lang/String;", "GetGetCountryHandler")]
			get {
				if (id_getCountry == IntPtr.Zero)
					id_getCountry = JNIEnv.GetMethodID (class_ref, "getCountry", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCountry), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCountry", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenization']/method[@name='setCountry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCountry", "(Ljava/lang/String;)V", "GetSetCountry_Ljava_lang_String_Handler")]
			set {
				if (id_setCountry_Ljava_lang_String_ == IntPtr.Zero)
					id_setCountry_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCountry", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCountry_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCountry", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCurrency;
#pragma warning disable 0169
		static Delegate GetGetCurrencyHandler ()
		{
			if (cb_getCurrency == null)
				cb_getCurrency = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrency);
			return cb_getCurrency;
		}

		static IntPtr n_GetCurrency (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Currency);
		}
#pragma warning restore 0169

		static Delegate cb_setCurrency_Lcom_mitec_suitemcommerce_utilities_Currency_;
#pragma warning disable 0169
		static Delegate GetSetCurrency_Lcom_mitec_suitemcommerce_utilities_Currency_Handler ()
		{
			if (cb_setCurrency_Lcom_mitec_suitemcommerce_utilities_Currency_ == null)
				cb_setCurrency_Lcom_mitec_suitemcommerce_utilities_Currency_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCurrency_Lcom_mitec_suitemcommerce_utilities_Currency_);
			return cb_setCurrency_Lcom_mitec_suitemcommerce_utilities_Currency_;
		}

		static void n_SetCurrency_Lcom_mitec_suitemcommerce_utilities_Currency_ (IntPtr jnienv, IntPtr native__this, IntPtr native_currency)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mitec.Suitemcommerce.Utilities.Currency currency = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Currency> (native_currency, JniHandleOwnership.DoNotTransfer);
			__this.Currency = currency;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrency;
		static IntPtr id_setCurrency_Lcom_mitec_suitemcommerce_utilities_Currency_;
		public virtual unsafe global::Com.Mitec.Suitemcommerce.Utilities.Currency Currency {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenization']/method[@name='getCurrency' and count(parameter)=0]"
			[Register ("getCurrency", "()Lcom/mitec/suitemcommerce/utilities/Currency;", "GetGetCurrencyHandler")]
			get {
				if (id_getCurrency == IntPtr.Zero)
					id_getCurrency = JNIEnv.GetMethodID (class_ref, "getCurrency", "()Lcom/mitec/suitemcommerce/utilities/Currency;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Currency> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrency), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Currency> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrency", "()Lcom/mitec/suitemcommerce/utilities/Currency;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenization']/method[@name='setCurrency' and count(parameter)=1 and parameter[1][@type='com.mitec.suitemcommerce.utilities.Currency']]"
			[Register ("setCurrency", "(Lcom/mitec/suitemcommerce/utilities/Currency;)V", "GetSetCurrency_Lcom_mitec_suitemcommerce_utilities_Currency_Handler")]
			set {
				if (id_setCurrency_Lcom_mitec_suitemcommerce_utilities_Currency_ == IntPtr.Zero)
					id_setCurrency_Lcom_mitec_suitemcommerce_utilities_Currency_ = JNIEnv.GetMethodID (class_ref, "setCurrency", "(Lcom/mitec/suitemcommerce/utilities/Currency;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCurrency_Lcom_mitec_suitemcommerce_utilities_Currency_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurrency", "(Lcom/mitec/suitemcommerce/utilities/Currency;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMerchant;
#pragma warning disable 0169
		static Delegate GetGetMerchantHandler ()
		{
			if (cb_getMerchant == null)
				cb_getMerchant = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMerchant);
			return cb_getMerchant;
		}

		static IntPtr n_GetMerchant (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Merchant);
		}
#pragma warning restore 0169

		static Delegate cb_setMerchant_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMerchant_Ljava_lang_String_Handler ()
		{
			if (cb_setMerchant_Ljava_lang_String_ == null)
				cb_setMerchant_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMerchant_Ljava_lang_String_);
			return cb_setMerchant_Ljava_lang_String_;
		}

		static void n_SetMerchant_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_merchant)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string merchant = JNIEnv.GetString (native_merchant, JniHandleOwnership.DoNotTransfer);
			__this.Merchant = merchant;
		}
#pragma warning restore 0169

		static IntPtr id_getMerchant;
		static IntPtr id_setMerchant_Ljava_lang_String_;
		public virtual unsafe string Merchant {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenization']/method[@name='getMerchant' and count(parameter)=0]"
			[Register ("getMerchant", "()Ljava/lang/String;", "GetGetMerchantHandler")]
			get {
				if (id_getMerchant == IntPtr.Zero)
					id_getMerchant = JNIEnv.GetMethodID (class_ref, "getMerchant", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMerchant), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMerchant", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenization']/method[@name='setMerchant' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMerchant", "(Ljava/lang/String;)V", "GetSetMerchant_Ljava_lang_String_Handler")]
			set {
				if (id_setMerchant_Ljava_lang_String_ == IntPtr.Zero)
					id_setMerchant_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMerchant", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMerchant_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMerchant", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getOperationType;
#pragma warning disable 0169
		static Delegate GetGetOperationTypeHandler ()
		{
			if (cb_getOperationType == null)
				cb_getOperationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOperationType);
			return cb_getOperationType;
		}

		static IntPtr n_GetOperationType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OperationType);
		}
#pragma warning restore 0169

		static Delegate cb_setOperationType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOperationType_Ljava_lang_String_Handler ()
		{
			if (cb_setOperationType_Ljava_lang_String_ == null)
				cb_setOperationType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOperationType_Ljava_lang_String_);
			return cb_setOperationType_Ljava_lang_String_;
		}

		static void n_SetOperationType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_operationType)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string operationType = JNIEnv.GetString (native_operationType, JniHandleOwnership.DoNotTransfer);
			__this.OperationType = operationType;
		}
#pragma warning restore 0169

		static IntPtr id_getOperationType;
		static IntPtr id_setOperationType_Ljava_lang_String_;
		public virtual unsafe string OperationType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenization']/method[@name='getOperationType' and count(parameter)=0]"
			[Register ("getOperationType", "()Ljava/lang/String;", "GetGetOperationTypeHandler")]
			get {
				if (id_getOperationType == IntPtr.Zero)
					id_getOperationType = JNIEnv.GetMethodID (class_ref, "getOperationType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOperationType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOperationType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenization']/method[@name='setOperationType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setOperationType", "(Ljava/lang/String;)V", "GetSetOperationType_Ljava_lang_String_Handler")]
			set {
				if (id_setOperationType_Ljava_lang_String_ == IntPtr.Zero)
					id_setOperationType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOperationType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOperationType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOperationType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPassword;
#pragma warning disable 0169
		static Delegate GetGetPasswordHandler ()
		{
			if (cb_getPassword == null)
				cb_getPassword = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPassword);
			return cb_getPassword;
		}

		static IntPtr n_GetPassword (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Password);
		}
#pragma warning restore 0169

		static Delegate cb_setPassword_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPassword_Ljava_lang_String_Handler ()
		{
			if (cb_setPassword_Ljava_lang_String_ == null)
				cb_setPassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPassword_Ljava_lang_String_);
			return cb_setPassword_Ljava_lang_String_;
		}

		static void n_SetPassword_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pws)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string pws = JNIEnv.GetString (native_pws, JniHandleOwnership.DoNotTransfer);
			__this.Password = pws;
		}
#pragma warning restore 0169

		static IntPtr id_getPassword;
		static IntPtr id_setPassword_Ljava_lang_String_;
		public virtual unsafe string Password {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenization']/method[@name='getPassword' and count(parameter)=0]"
			[Register ("getPassword", "()Ljava/lang/String;", "GetGetPasswordHandler")]
			get {
				if (id_getPassword == IntPtr.Zero)
					id_getPassword = JNIEnv.GetMethodID (class_ref, "getPassword", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPassword), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPassword", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenization']/method[@name='setPassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPassword", "(Ljava/lang/String;)V", "GetSetPassword_Ljava_lang_String_Handler")]
			set {
				if (id_setPassword_Ljava_lang_String_ == IntPtr.Zero)
					id_setPassword_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPassword", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPassword_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPassword", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getReference;
#pragma warning disable 0169
		static Delegate GetGetReferenceHandler ()
		{
			if (cb_getReference == null)
				cb_getReference = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReference);
			return cb_getReference;
		}

		static IntPtr n_GetReference (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Reference);
		}
#pragma warning restore 0169

		static Delegate cb_setReference_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetReference_Ljava_lang_String_Handler ()
		{
			if (cb_setReference_Ljava_lang_String_ == null)
				cb_setReference_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetReference_Ljava_lang_String_);
			return cb_setReference_Ljava_lang_String_;
		}

		static void n_SetReference_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_reference)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string reference = JNIEnv.GetString (native_reference, JniHandleOwnership.DoNotTransfer);
			__this.Reference = reference;
		}
#pragma warning restore 0169

		static IntPtr id_getReference;
		static IntPtr id_setReference_Ljava_lang_String_;
		public virtual unsafe string Reference {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenization']/method[@name='getReference' and count(parameter)=0]"
			[Register ("getReference", "()Ljava/lang/String;", "GetGetReferenceHandler")]
			get {
				if (id_getReference == IntPtr.Zero)
					id_getReference = JNIEnv.GetMethodID (class_ref, "getReference", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReference), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReference", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenization']/method[@name='setReference' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setReference", "(Ljava/lang/String;)V", "GetSetReference_Ljava_lang_String_Handler")]
			set {
				if (id_setReference_Ljava_lang_String_ == IntPtr.Zero)
					id_setReference_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setReference", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setReference_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReference", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getToken;
#pragma warning disable 0169
		static Delegate GetGetTokenHandler ()
		{
			if (cb_getToken == null)
				cb_getToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetToken);
			return cb_getToken;
		}

		static IntPtr n_GetToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Token);
		}
#pragma warning restore 0169

		static Delegate cb_setToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetToken_Ljava_lang_String_Handler ()
		{
			if (cb_setToken_Ljava_lang_String_ == null)
				cb_setToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetToken_Ljava_lang_String_);
			return cb_setToken_Ljava_lang_String_;
		}

		static void n_SetToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_token)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string token = JNIEnv.GetString (native_token, JniHandleOwnership.DoNotTransfer);
			__this.Token = token;
		}
#pragma warning restore 0169

		static IntPtr id_getToken;
		static IntPtr id_setToken_Ljava_lang_String_;
		public virtual unsafe string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenization']/method[@name='getToken' and count(parameter)=0]"
			[Register ("getToken", "()Ljava/lang/String;", "GetGetTokenHandler")]
			get {
				if (id_getToken == IntPtr.Zero)
					id_getToken = JNIEnv.GetMethodID (class_ref, "getToken", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getToken), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenization']/method[@name='setToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setToken", "(Ljava/lang/String;)V", "GetSetToken_Ljava_lang_String_Handler")]
			set {
				if (id_setToken_Ljava_lang_String_ == IntPtr.Zero)
					id_setToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setToken", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setToken_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setToken", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUser;
#pragma warning disable 0169
		static Delegate GetGetUserHandler ()
		{
			if (cb_getUser == null)
				cb_getUser = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUser);
			return cb_getUser;
		}

		static IntPtr n_GetUser (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.User);
		}
#pragma warning restore 0169

		static Delegate cb_setUser_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUser_Ljava_lang_String_Handler ()
		{
			if (cb_setUser_Ljava_lang_String_ == null)
				cb_setUser_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUser_Ljava_lang_String_);
			return cb_setUser_Ljava_lang_String_;
		}

		static void n_SetUser_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_user)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string user = JNIEnv.GetString (native_user, JniHandleOwnership.DoNotTransfer);
			__this.User = user;
		}
#pragma warning restore 0169

		static IntPtr id_getUser;
		static IntPtr id_setUser_Ljava_lang_String_;
		public virtual unsafe string User {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenization']/method[@name='getUser' and count(parameter)=0]"
			[Register ("getUser", "()Ljava/lang/String;", "GetGetUserHandler")]
			get {
				if (id_getUser == IntPtr.Zero)
					id_getUser = JNIEnv.GetMethodID (class_ref, "getUser", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUser), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUser", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenization']/method[@name='setUser' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUser", "(Ljava/lang/String;)V", "GetSetUser_Ljava_lang_String_Handler")]
			set {
				if (id_setUser_Ljava_lang_String_ == IntPtr.Zero)
					id_setUser_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUser", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUser_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUser", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
