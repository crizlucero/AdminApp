using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mitec.Suitemcommerce.Beans {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']"
	[global::Android.Runtime.Register ("com/mitec/suitemcommerce/beans/BeanPaymentWithToken", DoNotGenerateAcw=true)]
	public partial class BeanPaymentWithToken : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mitec/suitemcommerce/beans/BeanPaymentWithToken", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BeanPaymentWithToken); }
		}

		protected BeanPaymentWithToken (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/constructor[@name='BeanPaymentWithToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe BeanPaymentWithToken (string response)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_response = JNIEnv.NewString (response);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_response);
				if (((object) this).GetType () != typeof (BeanPaymentWithToken)) {
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
				JNIEnv.DeleteLocalRef (native_response);
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string amount = JNIEnv.GetString (native_amount, JniHandleOwnership.DoNotTransfer);
			__this.Amount = amount;
		}
#pragma warning restore 0169

		static IntPtr id_getAmount;
		static IntPtr id_setAmount_Ljava_lang_String_;
		public virtual unsafe string Amount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='getAmount' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='setAmount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getAuth;
#pragma warning disable 0169
		static Delegate GetGetAuthHandler ()
		{
			if (cb_getAuth == null)
				cb_getAuth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuth);
			return cb_getAuth;
		}

		static IntPtr n_GetAuth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Auth);
		}
#pragma warning restore 0169

		static Delegate cb_setAuth_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAuth_Ljava_lang_String_Handler ()
		{
			if (cb_setAuth_Ljava_lang_String_ == null)
				cb_setAuth_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAuth_Ljava_lang_String_);
			return cb_setAuth_Ljava_lang_String_;
		}

		static void n_SetAuth_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_auth)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string auth = JNIEnv.GetString (native_auth, JniHandleOwnership.DoNotTransfer);
			__this.Auth = auth;
		}
#pragma warning restore 0169

		static IntPtr id_getAuth;
		static IntPtr id_setAuth_Ljava_lang_String_;
		public virtual unsafe string Auth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='getAuth' and count(parameter)=0]"
			[Register ("getAuth", "()Ljava/lang/String;", "GetGetAuthHandler")]
			get {
				if (id_getAuth == IntPtr.Zero)
					id_getAuth = JNIEnv.GetMethodID (class_ref, "getAuth", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuth), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuth", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='setAuth' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAuth", "(Ljava/lang/String;)V", "GetSetAuth_Ljava_lang_String_Handler")]
			set {
				if (id_setAuth_Ljava_lang_String_ == IntPtr.Zero)
					id_setAuth_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAuth", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAuth_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAuth", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCcExpmonth;
#pragma warning disable 0169
		static Delegate GetGetCcExpmonthHandler ()
		{
			if (cb_getCcExpmonth == null)
				cb_getCcExpmonth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCcExpmonth);
			return cb_getCcExpmonth;
		}

		static IntPtr n_GetCcExpmonth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CcExpmonth);
		}
#pragma warning restore 0169

		static Delegate cb_setCcExpmonth_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCcExpmonth_Ljava_lang_String_Handler ()
		{
			if (cb_setCcExpmonth_Ljava_lang_String_ == null)
				cb_setCcExpmonth_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCcExpmonth_Ljava_lang_String_);
			return cb_setCcExpmonth_Ljava_lang_String_;
		}

		static void n_SetCcExpmonth_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ccExpmonth)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string ccExpmonth = JNIEnv.GetString (native_ccExpmonth, JniHandleOwnership.DoNotTransfer);
			__this.CcExpmonth = ccExpmonth;
		}
#pragma warning restore 0169

		static IntPtr id_getCcExpmonth;
		static IntPtr id_setCcExpmonth_Ljava_lang_String_;
		public virtual unsafe string CcExpmonth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='getCcExpmonth' and count(parameter)=0]"
			[Register ("getCcExpmonth", "()Ljava/lang/String;", "GetGetCcExpmonthHandler")]
			get {
				if (id_getCcExpmonth == IntPtr.Zero)
					id_getCcExpmonth = JNIEnv.GetMethodID (class_ref, "getCcExpmonth", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCcExpmonth), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCcExpmonth", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='setCcExpmonth' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCcExpmonth", "(Ljava/lang/String;)V", "GetSetCcExpmonth_Ljava_lang_String_Handler")]
			set {
				if (id_setCcExpmonth_Ljava_lang_String_ == IntPtr.Zero)
					id_setCcExpmonth_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCcExpmonth", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCcExpmonth_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCcExpmonth", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCcExpyear;
#pragma warning disable 0169
		static Delegate GetGetCcExpyearHandler ()
		{
			if (cb_getCcExpyear == null)
				cb_getCcExpyear = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCcExpyear);
			return cb_getCcExpyear;
		}

		static IntPtr n_GetCcExpyear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CcExpyear);
		}
#pragma warning restore 0169

		static Delegate cb_setCcExpyear_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCcExpyear_Ljava_lang_String_Handler ()
		{
			if (cb_setCcExpyear_Ljava_lang_String_ == null)
				cb_setCcExpyear_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCcExpyear_Ljava_lang_String_);
			return cb_setCcExpyear_Ljava_lang_String_;
		}

		static void n_SetCcExpyear_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ccExpyear)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string ccExpyear = JNIEnv.GetString (native_ccExpyear, JniHandleOwnership.DoNotTransfer);
			__this.CcExpyear = ccExpyear;
		}
#pragma warning restore 0169

		static IntPtr id_getCcExpyear;
		static IntPtr id_setCcExpyear_Ljava_lang_String_;
		public virtual unsafe string CcExpyear {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='getCcExpyear' and count(parameter)=0]"
			[Register ("getCcExpyear", "()Ljava/lang/String;", "GetGetCcExpyearHandler")]
			get {
				if (id_getCcExpyear == IntPtr.Zero)
					id_getCcExpyear = JNIEnv.GetMethodID (class_ref, "getCcExpyear", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCcExpyear), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCcExpyear", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='setCcExpyear' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCcExpyear", "(Ljava/lang/String;)V", "GetSetCcExpyear_Ljava_lang_String_Handler")]
			set {
				if (id_setCcExpyear_Ljava_lang_String_ == IntPtr.Zero)
					id_setCcExpyear_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCcExpyear", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCcExpyear_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCcExpyear", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCcName;
#pragma warning disable 0169
		static Delegate GetGetCcNameHandler ()
		{
			if (cb_getCcName == null)
				cb_getCcName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCcName);
			return cb_getCcName;
		}

		static IntPtr n_GetCcName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CcName);
		}
#pragma warning restore 0169

		static Delegate cb_setCcName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCcName_Ljava_lang_String_Handler ()
		{
			if (cb_setCcName_Ljava_lang_String_ == null)
				cb_setCcName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCcName_Ljava_lang_String_);
			return cb_setCcName_Ljava_lang_String_;
		}

		static void n_SetCcName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ccName)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string ccName = JNIEnv.GetString (native_ccName, JniHandleOwnership.DoNotTransfer);
			__this.CcName = ccName;
		}
#pragma warning restore 0169

		static IntPtr id_getCcName;
		static IntPtr id_setCcName_Ljava_lang_String_;
		public virtual unsafe string CcName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='getCcName' and count(parameter)=0]"
			[Register ("getCcName", "()Ljava/lang/String;", "GetGetCcNameHandler")]
			get {
				if (id_getCcName == IntPtr.Zero)
					id_getCcName = JNIEnv.GetMethodID (class_ref, "getCcName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCcName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCcName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='setCcName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCcName", "(Ljava/lang/String;)V", "GetSetCcName_Ljava_lang_String_Handler")]
			set {
				if (id_setCcName_Ljava_lang_String_ == IntPtr.Zero)
					id_setCcName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCcName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCcName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCcName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCcNumber;
#pragma warning disable 0169
		static Delegate GetGetCcNumberHandler ()
		{
			if (cb_getCcNumber == null)
				cb_getCcNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCcNumber);
			return cb_getCcNumber;
		}

		static IntPtr n_GetCcNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CcNumber);
		}
#pragma warning restore 0169

		static Delegate cb_setCcNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCcNumber_Ljava_lang_String_Handler ()
		{
			if (cb_setCcNumber_Ljava_lang_String_ == null)
				cb_setCcNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCcNumber_Ljava_lang_String_);
			return cb_setCcNumber_Ljava_lang_String_;
		}

		static void n_SetCcNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ccNumber)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string ccNumber = JNIEnv.GetString (native_ccNumber, JniHandleOwnership.DoNotTransfer);
			__this.CcNumber = ccNumber;
		}
#pragma warning restore 0169

		static IntPtr id_getCcNumber;
		static IntPtr id_setCcNumber_Ljava_lang_String_;
		public virtual unsafe string CcNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='getCcNumber' and count(parameter)=0]"
			[Register ("getCcNumber", "()Ljava/lang/String;", "GetGetCcNumberHandler")]
			get {
				if (id_getCcNumber == IntPtr.Zero)
					id_getCcNumber = JNIEnv.GetMethodID (class_ref, "getCcNumber", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCcNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCcNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='setCcNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCcNumber", "(Ljava/lang/String;)V", "GetSetCcNumber_Ljava_lang_String_Handler")]
			set {
				if (id_setCcNumber_Ljava_lang_String_ == IntPtr.Zero)
					id_setCcNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCcNumber", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCcNumber_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCcNumber", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCcType;
#pragma warning disable 0169
		static Delegate GetGetCcTypeHandler ()
		{
			if (cb_getCcType == null)
				cb_getCcType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCcType);
			return cb_getCcType;
		}

		static IntPtr n_GetCcType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CcType);
		}
#pragma warning restore 0169

		static Delegate cb_setCcType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCcType_Ljava_lang_String_Handler ()
		{
			if (cb_setCcType_Ljava_lang_String_ == null)
				cb_setCcType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCcType_Ljava_lang_String_);
			return cb_setCcType_Ljava_lang_String_;
		}

		static void n_SetCcType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ccType)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string ccType = JNIEnv.GetString (native_ccType, JniHandleOwnership.DoNotTransfer);
			__this.CcType = ccType;
		}
#pragma warning restore 0169

		static IntPtr id_getCcType;
		static IntPtr id_setCcType_Ljava_lang_String_;
		public virtual unsafe string CcType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='getCcType' and count(parameter)=0]"
			[Register ("getCcType", "()Ljava/lang/String;", "GetGetCcTypeHandler")]
			get {
				if (id_getCcType == IntPtr.Zero)
					id_getCcType = JNIEnv.GetMethodID (class_ref, "getCcType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCcType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCcType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='setCcType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCcType", "(Ljava/lang/String;)V", "GetSetCcType_Ljava_lang_String_Handler")]
			set {
				if (id_setCcType_Ljava_lang_String_ == IntPtr.Zero)
					id_setCcType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCcType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCcType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCcType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCdError;
#pragma warning disable 0169
		static Delegate GetGetCdErrorHandler ()
		{
			if (cb_getCdError == null)
				cb_getCdError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCdError);
			return cb_getCdError;
		}

		static IntPtr n_GetCdError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CdError);
		}
#pragma warning restore 0169

		static Delegate cb_setCdError_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCdError_Ljava_lang_String_Handler ()
		{
			if (cb_setCdError_Ljava_lang_String_ == null)
				cb_setCdError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCdError_Ljava_lang_String_);
			return cb_setCdError_Ljava_lang_String_;
		}

		static void n_SetCdError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cdError)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string cdError = JNIEnv.GetString (native_cdError, JniHandleOwnership.DoNotTransfer);
			__this.CdError = cdError;
		}
#pragma warning restore 0169

		static IntPtr id_getCdError;
		static IntPtr id_setCdError_Ljava_lang_String_;
		public virtual unsafe string CdError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='getCdError' and count(parameter)=0]"
			[Register ("getCdError", "()Ljava/lang/String;", "GetGetCdErrorHandler")]
			get {
				if (id_getCdError == IntPtr.Zero)
					id_getCdError = JNIEnv.GetMethodID (class_ref, "getCdError", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCdError), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCdError", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='setCdError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCdError", "(Ljava/lang/String;)V", "GetSetCdError_Ljava_lang_String_Handler")]
			set {
				if (id_setCdError_Ljava_lang_String_ == IntPtr.Zero)
					id_setCdError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCdError", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCdError_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCdError", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCdResponse;
#pragma warning disable 0169
		static Delegate GetGetCdResponseHandler ()
		{
			if (cb_getCdResponse == null)
				cb_getCdResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCdResponse);
			return cb_getCdResponse;
		}

		static IntPtr n_GetCdResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CdResponse);
		}
#pragma warning restore 0169

		static Delegate cb_setCdResponse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCdResponse_Ljava_lang_String_Handler ()
		{
			if (cb_setCdResponse_Ljava_lang_String_ == null)
				cb_setCdResponse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCdResponse_Ljava_lang_String_);
			return cb_setCdResponse_Ljava_lang_String_;
		}

		static void n_SetCdResponse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cdResponse)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string cdResponse = JNIEnv.GetString (native_cdResponse, JniHandleOwnership.DoNotTransfer);
			__this.CdResponse = cdResponse;
		}
#pragma warning restore 0169

		static IntPtr id_getCdResponse;
		static IntPtr id_setCdResponse_Ljava_lang_String_;
		public virtual unsafe string CdResponse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='getCdResponse' and count(parameter)=0]"
			[Register ("getCdResponse", "()Ljava/lang/String;", "GetGetCdResponseHandler")]
			get {
				if (id_getCdResponse == IntPtr.Zero)
					id_getCdResponse = JNIEnv.GetMethodID (class_ref, "getCdResponse", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCdResponse), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCdResponse", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='setCdResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCdResponse", "(Ljava/lang/String;)V", "GetSetCdResponse_Ljava_lang_String_Handler")]
			set {
				if (id_setCdResponse_Ljava_lang_String_ == IntPtr.Zero)
					id_setCdResponse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCdResponse", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCdResponse_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCdResponse", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string company = JNIEnv.GetString (native_company, JniHandleOwnership.DoNotTransfer);
			__this.Company = company;
		}
#pragma warning restore 0169

		static IntPtr id_getCompany;
		static IntPtr id_setCompany_Ljava_lang_String_;
		public virtual unsafe string Company {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='getCompany' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='setCompany' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getFolio;
#pragma warning disable 0169
		static Delegate GetGetFolioHandler ()
		{
			if (cb_getFolio == null)
				cb_getFolio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFolio);
			return cb_getFolio;
		}

		static IntPtr n_GetFolio (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Folio);
		}
#pragma warning restore 0169

		static Delegate cb_setFolio_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFolio_Ljava_lang_String_Handler ()
		{
			if (cb_setFolio_Ljava_lang_String_ == null)
				cb_setFolio_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFolio_Ljava_lang_String_);
			return cb_setFolio_Ljava_lang_String_;
		}

		static void n_SetFolio_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_folio)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string folio = JNIEnv.GetString (native_folio, JniHandleOwnership.DoNotTransfer);
			__this.Folio = folio;
		}
#pragma warning restore 0169

		static IntPtr id_getFolio;
		static IntPtr id_setFolio_Ljava_lang_String_;
		public virtual unsafe string Folio {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='getFolio' and count(parameter)=0]"
			[Register ("getFolio", "()Ljava/lang/String;", "GetGetFolioHandler")]
			get {
				if (id_getFolio == IntPtr.Zero)
					id_getFolio = JNIEnv.GetMethodID (class_ref, "getFolio", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFolio), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFolio", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='setFolio' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFolio", "(Ljava/lang/String;)V", "GetSetFolio_Ljava_lang_String_Handler")]
			set {
				if (id_setFolio_Ljava_lang_String_ == IntPtr.Zero)
					id_setFolio_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFolio", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFolio_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFolio", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string merchant = JNIEnv.GetString (native_merchant, JniHandleOwnership.DoNotTransfer);
			__this.Merchant = merchant;
		}
#pragma warning restore 0169

		static IntPtr id_getMerchant;
		static IntPtr id_setMerchant_Ljava_lang_String_;
		public virtual unsafe string Merchant {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='getMerchant' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='setMerchant' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getNbError;
#pragma warning disable 0169
		static Delegate GetGetNbErrorHandler ()
		{
			if (cb_getNbError == null)
				cb_getNbError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNbError);
			return cb_getNbError;
		}

		static IntPtr n_GetNbError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NbError);
		}
#pragma warning restore 0169

		static Delegate cb_setNbError_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNbError_Ljava_lang_String_Handler ()
		{
			if (cb_setNbError_Ljava_lang_String_ == null)
				cb_setNbError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNbError_Ljava_lang_String_);
			return cb_setNbError_Ljava_lang_String_;
		}

		static void n_SetNbError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nbError)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string nbError = JNIEnv.GetString (native_nbError, JniHandleOwnership.DoNotTransfer);
			__this.NbError = nbError;
		}
#pragma warning restore 0169

		static IntPtr id_getNbError;
		static IntPtr id_setNbError_Ljava_lang_String_;
		public virtual unsafe string NbError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='getNbError' and count(parameter)=0]"
			[Register ("getNbError", "()Ljava/lang/String;", "GetGetNbErrorHandler")]
			get {
				if (id_getNbError == IntPtr.Zero)
					id_getNbError = JNIEnv.GetMethodID (class_ref, "getNbError", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNbError), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNbError", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='setNbError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNbError", "(Ljava/lang/String;)V", "GetSetNbError_Ljava_lang_String_Handler")]
			set {
				if (id_setNbError_Ljava_lang_String_ == IntPtr.Zero)
					id_setNbError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNbError", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNbError_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNbError", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string reference = JNIEnv.GetString (native_reference, JniHandleOwnership.DoNotTransfer);
			__this.Reference = reference;
		}
#pragma warning restore 0169

		static IntPtr id_getReference;
		static IntPtr id_setReference_Ljava_lang_String_;
		public virtual unsafe string Reference {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='getReference' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='setReference' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getResponse;
#pragma warning disable 0169
		static Delegate GetGetResponseHandler ()
		{
			if (cb_getResponse == null)
				cb_getResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponse);
			return cb_getResponse;
		}

		static IntPtr n_GetResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Response);
		}
#pragma warning restore 0169

		static Delegate cb_setResponse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResponse_Ljava_lang_String_Handler ()
		{
			if (cb_setResponse_Ljava_lang_String_ == null)
				cb_setResponse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResponse_Ljava_lang_String_);
			return cb_setResponse_Ljava_lang_String_;
		}

		static void n_SetResponse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_response)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string response = JNIEnv.GetString (native_response, JniHandleOwnership.DoNotTransfer);
			__this.Response = response;
		}
#pragma warning restore 0169

		static IntPtr id_getResponse;
		static IntPtr id_setResponse_Ljava_lang_String_;
		public virtual unsafe string Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='getResponse' and count(parameter)=0]"
			[Register ("getResponse", "()Ljava/lang/String;", "GetGetResponseHandler")]
			get {
				if (id_getResponse == IntPtr.Zero)
					id_getResponse = JNIEnv.GetMethodID (class_ref, "getResponse", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponse), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponse", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='setResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setResponse", "(Ljava/lang/String;)V", "GetSetResponse_Ljava_lang_String_Handler")]
			set {
				if (id_setResponse_Ljava_lang_String_ == IntPtr.Zero)
					id_setResponse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setResponse", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResponse_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResponse", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getStreet;
#pragma warning disable 0169
		static Delegate GetGetStreetHandler ()
		{
			if (cb_getStreet == null)
				cb_getStreet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStreet);
			return cb_getStreet;
		}

		static IntPtr n_GetStreet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Street);
		}
#pragma warning restore 0169

		static Delegate cb_setStreet_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStreet_Ljava_lang_String_Handler ()
		{
			if (cb_setStreet_Ljava_lang_String_ == null)
				cb_setStreet_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStreet_Ljava_lang_String_);
			return cb_setStreet_Ljava_lang_String_;
		}

		static void n_SetStreet_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_street)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string street = JNIEnv.GetString (native_street, JniHandleOwnership.DoNotTransfer);
			__this.Street = street;
		}
#pragma warning restore 0169

		static IntPtr id_getStreet;
		static IntPtr id_setStreet_Ljava_lang_String_;
		public virtual unsafe string Street {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='getStreet' and count(parameter)=0]"
			[Register ("getStreet", "()Ljava/lang/String;", "GetGetStreetHandler")]
			get {
				if (id_getStreet == IntPtr.Zero)
					id_getStreet = JNIEnv.GetMethodID (class_ref, "getStreet", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStreet), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStreet", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='setStreet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStreet", "(Ljava/lang/String;)V", "GetSetStreet_Ljava_lang_String_Handler")]
			set {
				if (id_setStreet_Ljava_lang_String_ == IntPtr.Zero)
					id_setStreet_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStreet", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStreet_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStreet", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTpOperation;
#pragma warning disable 0169
		static Delegate GetGetTpOperationHandler ()
		{
			if (cb_getTpOperation == null)
				cb_getTpOperation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTpOperation);
			return cb_getTpOperation;
		}

		static IntPtr n_GetTpOperation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TpOperation);
		}
#pragma warning restore 0169

		static Delegate cb_setTpOperation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTpOperation_Ljava_lang_String_Handler ()
		{
			if (cb_setTpOperation_Ljava_lang_String_ == null)
				cb_setTpOperation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTpOperation_Ljava_lang_String_);
			return cb_setTpOperation_Ljava_lang_String_;
		}

		static void n_SetTpOperation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tpOperation)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string tpOperation = JNIEnv.GetString (native_tpOperation, JniHandleOwnership.DoNotTransfer);
			__this.TpOperation = tpOperation;
		}
#pragma warning restore 0169

		static IntPtr id_getTpOperation;
		static IntPtr id_setTpOperation_Ljava_lang_String_;
		public virtual unsafe string TpOperation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='getTpOperation' and count(parameter)=0]"
			[Register ("getTpOperation", "()Ljava/lang/String;", "GetGetTpOperationHandler")]
			get {
				if (id_getTpOperation == IntPtr.Zero)
					id_getTpOperation = JNIEnv.GetMethodID (class_ref, "getTpOperation", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTpOperation), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTpOperation", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='setTpOperation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTpOperation", "(Ljava/lang/String;)V", "GetSetTpOperation_Ljava_lang_String_Handler")]
			set {
				if (id_setTpOperation_Ljava_lang_String_ == IntPtr.Zero)
					id_setTpOperation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTpOperation", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTpOperation_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTpOperation", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getVoucher;
#pragma warning disable 0169
		static Delegate GetGetVoucherHandler ()
		{
			if (cb_getVoucher == null)
				cb_getVoucher = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVoucher);
			return cb_getVoucher;
		}

		static IntPtr n_GetVoucher (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Voucher);
		}
#pragma warning restore 0169

		static Delegate cb_setVoucher_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVoucher_Ljava_lang_String_Handler ()
		{
			if (cb_setVoucher_Ljava_lang_String_ == null)
				cb_setVoucher_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVoucher_Ljava_lang_String_);
			return cb_setVoucher_Ljava_lang_String_;
		}

		static void n_SetVoucher_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_voucher)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string voucher = JNIEnv.GetString (native_voucher, JniHandleOwnership.DoNotTransfer);
			__this.Voucher = voucher;
		}
#pragma warning restore 0169

		static IntPtr id_getVoucher;
		static IntPtr id_setVoucher_Ljava_lang_String_;
		public virtual unsafe string Voucher {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='getVoucher' and count(parameter)=0]"
			[Register ("getVoucher", "()Ljava/lang/String;", "GetGetVoucherHandler")]
			get {
				if (id_getVoucher == IntPtr.Zero)
					id_getVoucher = JNIEnv.GetMethodID (class_ref, "getVoucher", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVoucher), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVoucher", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithToken']/method[@name='setVoucher' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setVoucher", "(Ljava/lang/String;)V", "GetSetVoucher_Ljava_lang_String_Handler")]
			set {
				if (id_setVoucher_Ljava_lang_String_ == IntPtr.Zero)
					id_setVoucher_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setVoucher", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVoucher_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVoucher", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
