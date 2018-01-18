using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mitec.Suitemcommerce.Beans {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithTokenRequest']"
	[global::Android.Runtime.Register ("com/mitec/suitemcommerce/beans/BeanPaymentWithTokenRequest", DoNotGenerateAcw=true)]
	public partial class BeanPaymentWithTokenRequest : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mitec/suitemcommerce/beans/BeanPaymentWithTokenRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BeanPaymentWithTokenRequest); }
		}

		protected BeanPaymentWithTokenRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithTokenRequest']/constructor[@name='BeanPaymentWithTokenRequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe BeanPaymentWithTokenRequest (string response)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_response = JNIEnv.NewString (response);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_response);
				if (((object) this).GetType () != typeof (BeanPaymentWithTokenRequest)) {
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string cdError = JNIEnv.GetString (native_cdError, JniHandleOwnership.DoNotTransfer);
			__this.CdError = cdError;
		}
#pragma warning restore 0169

		static IntPtr id_getCdError;
		static IntPtr id_setCdError_Ljava_lang_String_;
		public virtual unsafe string CdError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithTokenRequest']/method[@name='getCdError' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithTokenRequest']/method[@name='setCdError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string nbError = JNIEnv.GetString (native_nbError, JniHandleOwnership.DoNotTransfer);
			__this.NbError = nbError;
		}
#pragma warning restore 0169

		static IntPtr id_getNbError;
		static IntPtr id_setNbError_Ljava_lang_String_;
		public virtual unsafe string NbError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithTokenRequest']/method[@name='getNbError' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithTokenRequest']/method[@name='setNbError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getNbResponse;
#pragma warning disable 0169
		static Delegate GetGetNbResponseHandler ()
		{
			if (cb_getNbResponse == null)
				cb_getNbResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNbResponse);
			return cb_getNbResponse;
		}

		static IntPtr n_GetNbResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NbResponse);
		}
#pragma warning restore 0169

		static Delegate cb_setNbResponse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNbResponse_Ljava_lang_String_Handler ()
		{
			if (cb_setNbResponse_Ljava_lang_String_ == null)
				cb_setNbResponse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNbResponse_Ljava_lang_String_);
			return cb_setNbResponse_Ljava_lang_String_;
		}

		static void n_SetNbResponse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nbResponse)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string nbResponse = JNIEnv.GetString (native_nbResponse, JniHandleOwnership.DoNotTransfer);
			__this.NbResponse = nbResponse;
		}
#pragma warning restore 0169

		static IntPtr id_getNbResponse;
		static IntPtr id_setNbResponse_Ljava_lang_String_;
		public virtual unsafe string NbResponse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithTokenRequest']/method[@name='getNbResponse' and count(parameter)=0]"
			[Register ("getNbResponse", "()Ljava/lang/String;", "GetGetNbResponseHandler")]
			get {
				if (id_getNbResponse == IntPtr.Zero)
					id_getNbResponse = JNIEnv.GetMethodID (class_ref, "getNbResponse", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNbResponse), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNbResponse", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithTokenRequest']/method[@name='setNbResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNbResponse", "(Ljava/lang/String;)V", "GetSetNbResponse_Ljava_lang_String_Handler")]
			set {
				if (id_setNbResponse_Ljava_lang_String_ == IntPtr.Zero)
					id_setNbResponse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNbResponse", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNbResponse_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNbResponse", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string response = JNIEnv.GetString (native_response, JniHandleOwnership.DoNotTransfer);
			__this.Response = response;
		}
#pragma warning restore 0169

		static IntPtr id_getResponse;
		static IntPtr id_setResponse_Ljava_lang_String_;
		public virtual unsafe string Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithTokenRequest']/method[@name='getResponse' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanPaymentWithTokenRequest']/method[@name='setResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

	}
}
