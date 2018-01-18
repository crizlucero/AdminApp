using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mitec.Suitemcommerce.Beans {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentResponse']"
	[global::Android.Runtime.Register ("com/mitec/suitemcommerce/beans/BeanPaymentResponse", DoNotGenerateAcw=true)]
	public partial class BeanPaymentResponse : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mitec/suitemcommerce/beans/BeanPaymentResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BeanPaymentResponse); }
		}

		protected BeanPaymentResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentResponse']/constructor[@name='BeanPaymentResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe BeanPaymentResponse (string response)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_response = JNIEnv.NewString (response);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_response);
				if (((object) this).GetType () != typeof (BeanPaymentResponse)) {
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string amount = JNIEnv.GetString (native_amount, JniHandleOwnership.DoNotTransfer);
			__this.Amount = amount;
		}
#pragma warning restore 0169

		static IntPtr id_getAmount;
		static IntPtr id_setAmount_Ljava_lang_String_;
		public virtual unsafe string Amount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentResponse']/method[@name='getAmount' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentResponse']/method[@name='setAmount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string auth = JNIEnv.GetString (native_auth, JniHandleOwnership.DoNotTransfer);
			__this.Auth = auth;
		}
#pragma warning restore 0169

		static IntPtr id_getAuth;
		static IntPtr id_setAuth_Ljava_lang_String_;
		public virtual unsafe string Auth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentResponse']/method[@name='getAuth' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentResponse']/method[@name='setAuth' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string ccName = JNIEnv.GetString (native_ccName, JniHandleOwnership.DoNotTransfer);
			__this.CcName = ccName;
		}
#pragma warning restore 0169

		static IntPtr id_getCcName;
		static IntPtr id_setCcName_Ljava_lang_String_;
		public virtual unsafe string CcName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentResponse']/method[@name='getCcName' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentResponse']/method[@name='setCcName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getCcNum;
#pragma warning disable 0169
		static Delegate GetGetCcNumHandler ()
		{
			if (cb_getCcNum == null)
				cb_getCcNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCcNum);
			return cb_getCcNum;
		}

		static IntPtr n_GetCcNum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CcNum);
		}
#pragma warning restore 0169

		static Delegate cb_setCcNum_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCcNum_Ljava_lang_String_Handler ()
		{
			if (cb_setCcNum_Ljava_lang_String_ == null)
				cb_setCcNum_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCcNum_Ljava_lang_String_);
			return cb_setCcNum_Ljava_lang_String_;
		}

		static void n_SetCcNum_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ccNum)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string ccNum = JNIEnv.GetString (native_ccNum, JniHandleOwnership.DoNotTransfer);
			__this.CcNum = ccNum;
		}
#pragma warning restore 0169

		static IntPtr id_getCcNum;
		static IntPtr id_setCcNum_Ljava_lang_String_;
		public virtual unsafe string CcNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentResponse']/method[@name='getCcNum' and count(parameter)=0]"
			[Register ("getCcNum", "()Ljava/lang/String;", "GetGetCcNumHandler")]
			get {
				if (id_getCcNum == IntPtr.Zero)
					id_getCcNum = JNIEnv.GetMethodID (class_ref, "getCcNum", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCcNum), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCcNum", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentResponse']/method[@name='setCcNum' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCcNum", "(Ljava/lang/String;)V", "GetSetCcNum_Ljava_lang_String_Handler")]
			set {
				if (id_setCcNum_Ljava_lang_String_ == IntPtr.Zero)
					id_setCcNum_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCcNum", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCcNum_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCcNum", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getError;
#pragma warning disable 0169
		static Delegate GetGetErrorHandler ()
		{
			if (cb_getError == null)
				cb_getError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetError);
			return cb_getError;
		}

		static IntPtr n_GetError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Error);
		}
#pragma warning restore 0169

		static Delegate cb_setError_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetError_Ljava_lang_String_Handler ()
		{
			if (cb_setError_Ljava_lang_String_ == null)
				cb_setError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetError_Ljava_lang_String_);
			return cb_setError_Ljava_lang_String_;
		}

		static void n_SetError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_error)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string error = JNIEnv.GetString (native_error, JniHandleOwnership.DoNotTransfer);
			__this.Error = error;
		}
#pragma warning restore 0169

		static IntPtr id_getError;
		static IntPtr id_setError_Ljava_lang_String_;
		public virtual unsafe string Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentResponse']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()Ljava/lang/String;", "GetGetErrorHandler")]
			get {
				if (id_getError == IntPtr.Zero)
					id_getError = JNIEnv.GetMethodID (class_ref, "getError", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getError), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getError", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentResponse']/method[@name='setError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setError", "(Ljava/lang/String;)V", "GetSetError_Ljava_lang_String_Handler")]
			set {
				if (id_setError_Ljava_lang_String_ == IntPtr.Zero)
					id_setError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setError", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setError_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setError", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string reference = JNIEnv.GetString (native_reference, JniHandleOwnership.DoNotTransfer);
			__this.Reference = reference;
		}
#pragma warning restore 0169

		static IntPtr id_getReference;
		static IntPtr id_setReference_Ljava_lang_String_;
		public virtual unsafe string Reference {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentResponse']/method[@name='getReference' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentResponse']/method[@name='setReference' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string response = JNIEnv.GetString (native_response, JniHandleOwnership.DoNotTransfer);
			__this.Response = response;
		}
#pragma warning restore 0169

		static IntPtr id_getResponse;
		static IntPtr id_setResponse_Ljava_lang_String_;
		public virtual unsafe string Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentResponse']/method[@name='getResponse' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentResponse']/method[@name='setResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static IntPtr id_getSerialVersionUID;
		public static unsafe long SerialVersionUID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentResponse']/method[@name='getSerialVersionUID' and count(parameter)=0]"
			[Register ("getSerialVersionUID", "()J", "GetGetSerialVersionUIDHandler")]
			get {
				if (id_getSerialVersionUID == IntPtr.Zero)
					id_getSerialVersionUID = JNIEnv.GetStaticMethodID (class_ref, "getSerialVersionUID", "()J");
				try {
					return JNIEnv.CallStaticLongMethod  (class_ref, id_getSerialVersionUID);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		static Delegate cb_setType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetType_Ljava_lang_String_Handler ()
		{
			if (cb_setType_Ljava_lang_String_ == null)
				cb_setType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetType_Ljava_lang_String_);
			return cb_setType_Ljava_lang_String_;
		}

		static void n_SetType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string type = JNIEnv.GetString (native_type, JniHandleOwnership.DoNotTransfer);
			__this.Type = type;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		static IntPtr id_setType_Ljava_lang_String_;
		public virtual unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentResponse']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentResponse']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setType", "(Ljava/lang/String;)V", "GetSetType_Ljava_lang_String_Handler")]
			set {
				if (id_setType_Ljava_lang_String_ == IntPtr.Zero)
					id_setType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
