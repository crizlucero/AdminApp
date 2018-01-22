using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mitec.Suitemcommerce.Controller {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mitec.suitemcommerce.controller']/interface[@name='SuiteControllerDelegate']"
	[Register ("com/mitec/suitemcommerce/controller/SuiteControllerDelegate", "", "Com.Mitec.Suitemcommerce.Controller.ISuiteControllerDelegateInvoker")]
	public partial interface ISuiteControllerDelegate : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.controller']/interface[@name='SuiteControllerDelegate']/method[@name='canceledProcessByUser' and count(parameter)=0]"
		[Register ("canceledProcessByUser", "()V", "GetCanceledProcessByUserHandler:Com.Mitec.Suitemcommerce.Controller.ISuiteControllerDelegateInvoker, PagosAndroid")]
		void CanceledProcessByUser ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.controller']/interface[@name='SuiteControllerDelegate']/method[@name='didFinishAuthenticationProcess' and count(parameter)=2 and parameter[1][@type='com.mitec.suitemcommerce.beans.BeanTokenizeResponse'] and parameter[2][@type='com.mitec.suitemcommerce.beans.SuiteError']]"
		[Register ("didFinishAuthenticationProcess", "(Lcom/mitec/suitemcommerce/beans/BeanTokenizeResponse;Lcom/mitec/suitemcommerce/beans/SuiteError;)V", "GetDidFinishAuthenticationProcess_Lcom_mitec_suitemcommerce_beans_BeanTokenizeResponse_Lcom_mitec_suitemcommerce_beans_SuiteError_Handler:Com.Mitec.Suitemcommerce.Controller.ISuiteControllerDelegateInvoker, PagosAndroid")]
		void DidFinishAuthenticationProcess (global::Com.Mitec.Suitemcommerce.Beans.BeanTokenizeResponse p0, global::Com.Mitec.Suitemcommerce.Beans.SuiteError p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.controller']/interface[@name='SuiteControllerDelegate']/method[@name='didFinishPayProcess' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mitec.suitemcommerce.beans.SuiteError']]"
		[Register ("didFinishPayProcess", "(Ljava/lang/String;Lcom/mitec/suitemcommerce/beans/SuiteError;)V", "GetDidFinishPayProcess_Ljava_lang_String_Lcom_mitec_suitemcommerce_beans_SuiteError_Handler:Com.Mitec.Suitemcommerce.Controller.ISuiteControllerDelegateInvoker, PagosAndroid")]
		void DidFinishPayProcess (string p0, global::Com.Mitec.Suitemcommerce.Beans.SuiteError p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.controller']/interface[@name='SuiteControllerDelegate']/method[@name='didFinishTokenizeTransaction' and count(parameter)=2 and parameter[1][@type='com.mitec.suitemcommerce.beans.BeanPaymentWithToken'] and parameter[2][@type='com.mitec.suitemcommerce.beans.SuiteError']]"
		[Register ("didFinishTokenizeTransaction", "(Lcom/mitec/suitemcommerce/beans/BeanPaymentWithToken;Lcom/mitec/suitemcommerce/beans/SuiteError;)V", "GetDidFinishTokenizeTransaction_Lcom_mitec_suitemcommerce_beans_BeanPaymentWithToken_Lcom_mitec_suitemcommerce_beans_SuiteError_Handler:Com.Mitec.Suitemcommerce.Controller.ISuiteControllerDelegateInvoker, PagosAndroid")]
		void DidFinishTokenizeTransaction (global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken p0, global::Com.Mitec.Suitemcommerce.Beans.SuiteError p1);

	}

	[global::Android.Runtime.Register ("com/mitec/suitemcommerce/controller/SuiteControllerDelegate", DoNotGenerateAcw=true)]
	internal class ISuiteControllerDelegateInvoker : global::Java.Lang.Object, ISuiteControllerDelegate {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mitec/suitemcommerce/controller/SuiteControllerDelegate");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISuiteControllerDelegateInvoker); }
		}

		IntPtr class_ref;

		public static ISuiteControllerDelegate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISuiteControllerDelegate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mitec.suitemcommerce.controller.SuiteControllerDelegate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISuiteControllerDelegateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_canceledProcessByUser;
#pragma warning disable 0169
		static Delegate GetCanceledProcessByUserHandler ()
		{
			if (cb_canceledProcessByUser == null)
				cb_canceledProcessByUser = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CanceledProcessByUser);
			return cb_canceledProcessByUser;
		}

		static void n_CanceledProcessByUser (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Controller.ISuiteControllerDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Controller.ISuiteControllerDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CanceledProcessByUser ();
		}
#pragma warning restore 0169

		IntPtr id_canceledProcessByUser;
		public unsafe void CanceledProcessByUser ()
		{
			if (id_canceledProcessByUser == IntPtr.Zero)
				id_canceledProcessByUser = JNIEnv.GetMethodID (class_ref, "canceledProcessByUser", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_canceledProcessByUser);
		}

		static Delegate cb_didFinishAuthenticationProcess_Lcom_mitec_suitemcommerce_beans_BeanTokenizeResponse_Lcom_mitec_suitemcommerce_beans_SuiteError_;
#pragma warning disable 0169
		static Delegate GetDidFinishAuthenticationProcess_Lcom_mitec_suitemcommerce_beans_BeanTokenizeResponse_Lcom_mitec_suitemcommerce_beans_SuiteError_Handler ()
		{
			if (cb_didFinishAuthenticationProcess_Lcom_mitec_suitemcommerce_beans_BeanTokenizeResponse_Lcom_mitec_suitemcommerce_beans_SuiteError_ == null)
				cb_didFinishAuthenticationProcess_Lcom_mitec_suitemcommerce_beans_BeanTokenizeResponse_Lcom_mitec_suitemcommerce_beans_SuiteError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DidFinishAuthenticationProcess_Lcom_mitec_suitemcommerce_beans_BeanTokenizeResponse_Lcom_mitec_suitemcommerce_beans_SuiteError_);
			return cb_didFinishAuthenticationProcess_Lcom_mitec_suitemcommerce_beans_BeanTokenizeResponse_Lcom_mitec_suitemcommerce_beans_SuiteError_;
		}

		static void n_DidFinishAuthenticationProcess_Lcom_mitec_suitemcommerce_beans_BeanTokenizeResponse_Lcom_mitec_suitemcommerce_beans_SuiteError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mitec.Suitemcommerce.Controller.ISuiteControllerDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Controller.ISuiteControllerDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenizeResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenizeResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mitec.Suitemcommerce.Beans.SuiteError p1 = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.SuiteError> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DidFinishAuthenticationProcess (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_didFinishAuthenticationProcess_Lcom_mitec_suitemcommerce_beans_BeanTokenizeResponse_Lcom_mitec_suitemcommerce_beans_SuiteError_;
		public unsafe void DidFinishAuthenticationProcess (global::Com.Mitec.Suitemcommerce.Beans.BeanTokenizeResponse p0, global::Com.Mitec.Suitemcommerce.Beans.SuiteError p1)
		{
			if (id_didFinishAuthenticationProcess_Lcom_mitec_suitemcommerce_beans_BeanTokenizeResponse_Lcom_mitec_suitemcommerce_beans_SuiteError_ == IntPtr.Zero)
				id_didFinishAuthenticationProcess_Lcom_mitec_suitemcommerce_beans_BeanTokenizeResponse_Lcom_mitec_suitemcommerce_beans_SuiteError_ = JNIEnv.GetMethodID (class_ref, "didFinishAuthenticationProcess", "(Lcom/mitec/suitemcommerce/beans/BeanTokenizeResponse;Lcom/mitec/suitemcommerce/beans/SuiteError;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didFinishAuthenticationProcess_Lcom_mitec_suitemcommerce_beans_BeanTokenizeResponse_Lcom_mitec_suitemcommerce_beans_SuiteError_, __args);
		}

		static Delegate cb_didFinishPayProcess_Ljava_lang_String_Lcom_mitec_suitemcommerce_beans_SuiteError_;
#pragma warning disable 0169
		static Delegate GetDidFinishPayProcess_Ljava_lang_String_Lcom_mitec_suitemcommerce_beans_SuiteError_Handler ()
		{
			if (cb_didFinishPayProcess_Ljava_lang_String_Lcom_mitec_suitemcommerce_beans_SuiteError_ == null)
				cb_didFinishPayProcess_Ljava_lang_String_Lcom_mitec_suitemcommerce_beans_SuiteError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DidFinishPayProcess_Ljava_lang_String_Lcom_mitec_suitemcommerce_beans_SuiteError_);
			return cb_didFinishPayProcess_Ljava_lang_String_Lcom_mitec_suitemcommerce_beans_SuiteError_;
		}

		static void n_DidFinishPayProcess_Ljava_lang_String_Lcom_mitec_suitemcommerce_beans_SuiteError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mitec.Suitemcommerce.Controller.ISuiteControllerDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Controller.ISuiteControllerDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mitec.Suitemcommerce.Beans.SuiteError p1 = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.SuiteError> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DidFinishPayProcess (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_didFinishPayProcess_Ljava_lang_String_Lcom_mitec_suitemcommerce_beans_SuiteError_;
		public unsafe void DidFinishPayProcess (string p0, global::Com.Mitec.Suitemcommerce.Beans.SuiteError p1)
		{
			if (id_didFinishPayProcess_Ljava_lang_String_Lcom_mitec_suitemcommerce_beans_SuiteError_ == IntPtr.Zero)
				id_didFinishPayProcess_Ljava_lang_String_Lcom_mitec_suitemcommerce_beans_SuiteError_ = JNIEnv.GetMethodID (class_ref, "didFinishPayProcess", "(Ljava/lang/String;Lcom/mitec/suitemcommerce/beans/SuiteError;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didFinishPayProcess_Ljava_lang_String_Lcom_mitec_suitemcommerce_beans_SuiteError_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_didFinishTokenizeTransaction_Lcom_mitec_suitemcommerce_beans_BeanPaymentWithToken_Lcom_mitec_suitemcommerce_beans_SuiteError_;
#pragma warning disable 0169
		static Delegate GetDidFinishTokenizeTransaction_Lcom_mitec_suitemcommerce_beans_BeanPaymentWithToken_Lcom_mitec_suitemcommerce_beans_SuiteError_Handler ()
		{
			if (cb_didFinishTokenizeTransaction_Lcom_mitec_suitemcommerce_beans_BeanPaymentWithToken_Lcom_mitec_suitemcommerce_beans_SuiteError_ == null)
				cb_didFinishTokenizeTransaction_Lcom_mitec_suitemcommerce_beans_BeanPaymentWithToken_Lcom_mitec_suitemcommerce_beans_SuiteError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DidFinishTokenizeTransaction_Lcom_mitec_suitemcommerce_beans_BeanPaymentWithToken_Lcom_mitec_suitemcommerce_beans_SuiteError_);
			return cb_didFinishTokenizeTransaction_Lcom_mitec_suitemcommerce_beans_BeanPaymentWithToken_Lcom_mitec_suitemcommerce_beans_SuiteError_;
		}

		static void n_DidFinishTokenizeTransaction_Lcom_mitec_suitemcommerce_beans_BeanPaymentWithToken_Lcom_mitec_suitemcommerce_beans_SuiteError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mitec.Suitemcommerce.Controller.ISuiteControllerDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Controller.ISuiteControllerDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken p0 = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mitec.Suitemcommerce.Beans.SuiteError p1 = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.SuiteError> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DidFinishTokenizeTransaction (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_didFinishTokenizeTransaction_Lcom_mitec_suitemcommerce_beans_BeanPaymentWithToken_Lcom_mitec_suitemcommerce_beans_SuiteError_;
		public unsafe void DidFinishTokenizeTransaction (global::Com.Mitec.Suitemcommerce.Beans.BeanPaymentWithToken p0, global::Com.Mitec.Suitemcommerce.Beans.SuiteError p1)
		{
			if (id_didFinishTokenizeTransaction_Lcom_mitec_suitemcommerce_beans_BeanPaymentWithToken_Lcom_mitec_suitemcommerce_beans_SuiteError_ == IntPtr.Zero)
				id_didFinishTokenizeTransaction_Lcom_mitec_suitemcommerce_beans_BeanPaymentWithToken_Lcom_mitec_suitemcommerce_beans_SuiteError_ = JNIEnv.GetMethodID (class_ref, "didFinishTokenizeTransaction", "(Lcom/mitec/suitemcommerce/beans/BeanPaymentWithToken;Lcom/mitec/suitemcommerce/beans/SuiteError;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didFinishTokenizeTransaction_Lcom_mitec_suitemcommerce_beans_BeanPaymentWithToken_Lcom_mitec_suitemcommerce_beans_SuiteError_, __args);
		}

	}

}
