using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mitec.Suitemcommerce.Beans {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenizeResponse']"
	[global::Android.Runtime.Register ("com/mitec/suitemcommerce/beans/BeanTokenizeResponse", DoNotGenerateAcw=true)]
	public partial class BeanTokenizeResponse : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mitec/suitemcommerce/beans/BeanTokenizeResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BeanTokenizeResponse); }
		}

		protected BeanTokenizeResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenizeResponse']/constructor[@name='BeanTokenizeResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe BeanTokenizeResponse (string response)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_response = JNIEnv.NewString (response);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_response);
				if (((object) this).GetType () != typeof (BeanTokenizeResponse)) {
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenizeResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenizeResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenizeResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenizeResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string cdResponse = JNIEnv.GetString (native_cdResponse, JniHandleOwnership.DoNotTransfer);
			__this.CdResponse = cdResponse;
		}
#pragma warning restore 0169

		static IntPtr id_getCdResponse;
		static IntPtr id_setCdResponse_Ljava_lang_String_;
		public virtual unsafe string CdResponse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenizeResponse']/method[@name='getCdResponse' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenizeResponse']/method[@name='setCdResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenizeResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenizeResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenizeResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenizeResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string nbResponse = JNIEnv.GetString (native_nbResponse, JniHandleOwnership.DoNotTransfer);
			__this.NbResponse = nbResponse;
		}
#pragma warning restore 0169

		static IntPtr id_getNbResponse;
		static IntPtr id_setNbResponse_Ljava_lang_String_;
		public virtual unsafe string NbResponse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenizeResponse']/method[@name='getNbResponse' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenizeResponse']/method[@name='setNbResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenizeResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenizeResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenizeResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenizeResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string token = JNIEnv.GetString (native_token, JniHandleOwnership.DoNotTransfer);
			__this.Token = token;
		}
#pragma warning restore 0169

		static IntPtr id_getToken;
		static IntPtr id_setToken_Ljava_lang_String_;
		public virtual unsafe string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenizeResponse']/method[@name='getToken' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenizeResponse']/method[@name='setToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getTokenReference;
#pragma warning disable 0169
		static Delegate GetGetTokenReferenceHandler ()
		{
			if (cb_getTokenReference == null)
				cb_getTokenReference = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTokenReference);
			return cb_getTokenReference;
		}

		static IntPtr n_GetTokenReference (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenizeResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenizeResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TokenReference);
		}
#pragma warning restore 0169

		static Delegate cb_setTokenReference_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTokenReference_Ljava_lang_String_Handler ()
		{
			if (cb_setTokenReference_Ljava_lang_String_ == null)
				cb_setTokenReference_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTokenReference_Ljava_lang_String_);
			return cb_setTokenReference_Ljava_lang_String_;
		}

		static void n_SetTokenReference_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tokenReference)
		{
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenizeResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenizeResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string tokenReference = JNIEnv.GetString (native_tokenReference, JniHandleOwnership.DoNotTransfer);
			__this.TokenReference = tokenReference;
		}
#pragma warning restore 0169

		static IntPtr id_getTokenReference;
		static IntPtr id_setTokenReference_Ljava_lang_String_;
		public virtual unsafe string TokenReference {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenizeResponse']/method[@name='getTokenReference' and count(parameter)=0]"
			[Register ("getTokenReference", "()Ljava/lang/String;", "GetGetTokenReferenceHandler")]
			get {
				if (id_getTokenReference == IntPtr.Zero)
					id_getTokenReference = JNIEnv.GetMethodID (class_ref, "getTokenReference", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTokenReference), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTokenReference", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.beans']/class[@name='BeanTokenizeResponse']/method[@name='setTokenReference' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTokenReference", "(Ljava/lang/String;)V", "GetSetTokenReference_Ljava_lang_String_Handler")]
			set {
				if (id_setTokenReference_Ljava_lang_String_ == IntPtr.Zero)
					id_setTokenReference_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTokenReference", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTokenReference_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTokenReference", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
