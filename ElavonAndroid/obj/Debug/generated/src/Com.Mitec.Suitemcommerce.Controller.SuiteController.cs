using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mitec.Suitemcommerce.Controller {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mitec.suitemcommerce.controller']/class[@name='SuiteController']"
	[global::Android.Runtime.Register ("com/mitec/suitemcommerce/controller/SuiteController", DoNotGenerateAcw=true)]
	public partial class SuiteController : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mitec/suitemcommerce/controller/SuiteController", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SuiteController); }
		}

		protected SuiteController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_Lcom_mitec_suitemcommerce_controller_SuiteControllerDelegate_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mitec.suitemcommerce.controller']/class[@name='SuiteController']/constructor[@name='SuiteController' and count(parameter)=3 and parameter[1][@type='com.mitec.suitemcommerce.utilities.Environment'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.mitec.suitemcommerce.controller.SuiteControllerDelegate']]"
		[Register (".ctor", "(Lcom/mitec/suitemcommerce/utilities/Environment;Landroid/content/Context;Lcom/mitec/suitemcommerce/controller/SuiteControllerDelegate;)V", "")]
		public unsafe SuiteController (global::Com.Mitec.Suitemcommerce.Utilities.Environment environment, global::Android.Content.Context context, global::Com.Mitec.Suitemcommerce.Controller.ISuiteControllerDelegate @delegate)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (environment);
				__args [1] = new JValue (context);
				__args [2] = new JValue (@delegate);
				if (((object) this).GetType () != typeof (SuiteController)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/mitec/suitemcommerce/utilities/Environment;Landroid/content/Context;Lcom/mitec/suitemcommerce/controller/SuiteControllerDelegate;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/mitec/suitemcommerce/utilities/Environment;Landroid/content/Context;Lcom/mitec/suitemcommerce/controller/SuiteControllerDelegate;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_Lcom_mitec_suitemcommerce_controller_SuiteControllerDelegate_ == IntPtr.Zero)
					id_ctor_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_Lcom_mitec_suitemcommerce_controller_SuiteControllerDelegate_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mitec/suitemcommerce/utilities/Environment;Landroid/content/Context;Lcom/mitec/suitemcommerce/controller/SuiteControllerDelegate;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_Lcom_mitec_suitemcommerce_controller_SuiteControllerDelegate_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_mitec_suitemcommerce_utilities_Environment_Landroid_content_Context_Lcom_mitec_suitemcommerce_controller_SuiteControllerDelegate_, __args);
			} finally {
			}
		}

		static Delegate cb_authenticate_Lcom_mitec_suitemcommerce_beans_BeanTokenization_Lcom_mitec_suitemcommerce_beans_Bean3DS_;
#pragma warning disable 0169
		static Delegate GetAuthenticate_Lcom_mitec_suitemcommerce_beans_BeanTokenization_Lcom_mitec_suitemcommerce_beans_Bean3DS_Handler ()
		{
			if (cb_authenticate_Lcom_mitec_suitemcommerce_beans_BeanTokenization_Lcom_mitec_suitemcommerce_beans_Bean3DS_ == null)
				cb_authenticate_Lcom_mitec_suitemcommerce_beans_BeanTokenization_Lcom_mitec_suitemcommerce_beans_Bean3DS_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Authenticate_Lcom_mitec_suitemcommerce_beans_BeanTokenization_Lcom_mitec_suitemcommerce_beans_Bean3DS_);
			return cb_authenticate_Lcom_mitec_suitemcommerce_beans_BeanTokenization_Lcom_mitec_suitemcommerce_beans_Bean3DS_;
		}

		static void n_Authenticate_Lcom_mitec_suitemcommerce_beans_BeanTokenization_Lcom_mitec_suitemcommerce_beans_Bean3DS_ (IntPtr jnienv, IntPtr native__this, IntPtr native_beanTokenization, IntPtr native_bean3DS)
		{
			global::Com.Mitec.Suitemcommerce.Controller.SuiteController __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Controller.SuiteController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization beanTokenization = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization> (native_beanTokenization, JniHandleOwnership.DoNotTransfer);
			global::Com.Mitec.Suitemcommerce.Beans.Bean3DS bean3DS = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.Bean3DS> (native_bean3DS, JniHandleOwnership.DoNotTransfer);
			__this.Authenticate (beanTokenization, bean3DS);
		}
#pragma warning restore 0169

		static IntPtr id_authenticate_Lcom_mitec_suitemcommerce_beans_BeanTokenization_Lcom_mitec_suitemcommerce_beans_Bean3DS_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.controller']/class[@name='SuiteController']/method[@name='authenticate' and count(parameter)=2 and parameter[1][@type='com.mitec.suitemcommerce.beans.BeanTokenization'] and parameter[2][@type='com.mitec.suitemcommerce.beans.Bean3DS']]"
		[Register ("authenticate", "(Lcom/mitec/suitemcommerce/beans/BeanTokenization;Lcom/mitec/suitemcommerce/beans/Bean3DS;)V", "GetAuthenticate_Lcom_mitec_suitemcommerce_beans_BeanTokenization_Lcom_mitec_suitemcommerce_beans_Bean3DS_Handler")]
		public virtual unsafe void Authenticate (global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization beanTokenization, global::Com.Mitec.Suitemcommerce.Beans.Bean3DS bean3DS)
		{
			if (id_authenticate_Lcom_mitec_suitemcommerce_beans_BeanTokenization_Lcom_mitec_suitemcommerce_beans_Bean3DS_ == IntPtr.Zero)
				id_authenticate_Lcom_mitec_suitemcommerce_beans_BeanTokenization_Lcom_mitec_suitemcommerce_beans_Bean3DS_ = JNIEnv.GetMethodID (class_ref, "authenticate", "(Lcom/mitec/suitemcommerce/beans/BeanTokenization;Lcom/mitec/suitemcommerce/beans/Bean3DS;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (beanTokenization);
				__args [1] = new JValue (bean3DS);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_authenticate_Lcom_mitec_suitemcommerce_beans_BeanTokenization_Lcom_mitec_suitemcommerce_beans_Bean3DS_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "authenticate", "(Lcom/mitec/suitemcommerce/beans/BeanTokenization;Lcom/mitec/suitemcommerce/beans/Bean3DS;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sndPay_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSndPay_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_sndPay_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_sndPay_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SndPay_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_sndPay_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SndPay_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_company, IntPtr native_xmlA, IntPtr native_xmlM)
		{
			global::Com.Mitec.Suitemcommerce.Controller.SuiteController __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Controller.SuiteController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string company = JNIEnv.GetString (native_company, JniHandleOwnership.DoNotTransfer);
			string xmlA = JNIEnv.GetString (native_xmlA, JniHandleOwnership.DoNotTransfer);
			string xmlM = JNIEnv.GetString (native_xmlM, JniHandleOwnership.DoNotTransfer);
			__this.SndPay (company, xmlA, xmlM);
		}
#pragma warning restore 0169

		static IntPtr id_sndPay_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.controller']/class[@name='SuiteController']/method[@name='sndPay' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("sndPay", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSndPay_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SndPay (string company, string xmlA, string xmlM)
		{
			if (id_sndPay_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sndPay_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sndPay", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_company = JNIEnv.NewString (company);
			IntPtr native_xmlA = JNIEnv.NewString (xmlA);
			IntPtr native_xmlM = JNIEnv.NewString (xmlM);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_company);
				__args [1] = new JValue (native_xmlA);
				__args [2] = new JValue (native_xmlM);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sndPay_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sndPay", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_company);
				JNIEnv.DeleteLocalRef (native_xmlA);
				JNIEnv.DeleteLocalRef (native_xmlM);
			}
		}

		static Delegate cb_sndPayWithToken_Lcom_mitec_suitemcommerce_beans_BeanTokenization_Lcom_mitec_suitemcommerce_beans_Bean3DS_;
#pragma warning disable 0169
		static Delegate GetSndPayWithToken_Lcom_mitec_suitemcommerce_beans_BeanTokenization_Lcom_mitec_suitemcommerce_beans_Bean3DS_Handler ()
		{
			if (cb_sndPayWithToken_Lcom_mitec_suitemcommerce_beans_BeanTokenization_Lcom_mitec_suitemcommerce_beans_Bean3DS_ == null)
				cb_sndPayWithToken_Lcom_mitec_suitemcommerce_beans_BeanTokenization_Lcom_mitec_suitemcommerce_beans_Bean3DS_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SndPayWithToken_Lcom_mitec_suitemcommerce_beans_BeanTokenization_Lcom_mitec_suitemcommerce_beans_Bean3DS_);
			return cb_sndPayWithToken_Lcom_mitec_suitemcommerce_beans_BeanTokenization_Lcom_mitec_suitemcommerce_beans_Bean3DS_;
		}

		static void n_SndPayWithToken_Lcom_mitec_suitemcommerce_beans_BeanTokenization_Lcom_mitec_suitemcommerce_beans_Bean3DS_ (IntPtr jnienv, IntPtr native__this, IntPtr native_beanTokenization, IntPtr native_bean3DS)
		{
			global::Com.Mitec.Suitemcommerce.Controller.SuiteController __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Controller.SuiteController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization beanTokenization = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization> (native_beanTokenization, JniHandleOwnership.DoNotTransfer);
			global::Com.Mitec.Suitemcommerce.Beans.Bean3DS bean3DS = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Beans.Bean3DS> (native_bean3DS, JniHandleOwnership.DoNotTransfer);
			__this.SndPayWithToken (beanTokenization, bean3DS);
		}
#pragma warning restore 0169

		static IntPtr id_sndPayWithToken_Lcom_mitec_suitemcommerce_beans_BeanTokenization_Lcom_mitec_suitemcommerce_beans_Bean3DS_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.controller']/class[@name='SuiteController']/method[@name='sndPayWithToken' and count(parameter)=2 and parameter[1][@type='com.mitec.suitemcommerce.beans.BeanTokenization'] and parameter[2][@type='com.mitec.suitemcommerce.beans.Bean3DS']]"
		[Register ("sndPayWithToken", "(Lcom/mitec/suitemcommerce/beans/BeanTokenization;Lcom/mitec/suitemcommerce/beans/Bean3DS;)V", "GetSndPayWithToken_Lcom_mitec_suitemcommerce_beans_BeanTokenization_Lcom_mitec_suitemcommerce_beans_Bean3DS_Handler")]
		public virtual unsafe void SndPayWithToken (global::Com.Mitec.Suitemcommerce.Beans.BeanTokenization beanTokenization, global::Com.Mitec.Suitemcommerce.Beans.Bean3DS bean3DS)
		{
			if (id_sndPayWithToken_Lcom_mitec_suitemcommerce_beans_BeanTokenization_Lcom_mitec_suitemcommerce_beans_Bean3DS_ == IntPtr.Zero)
				id_sndPayWithToken_Lcom_mitec_suitemcommerce_beans_BeanTokenization_Lcom_mitec_suitemcommerce_beans_Bean3DS_ = JNIEnv.GetMethodID (class_ref, "sndPayWithToken", "(Lcom/mitec/suitemcommerce/beans/BeanTokenization;Lcom/mitec/suitemcommerce/beans/Bean3DS;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (beanTokenization);
				__args [1] = new JValue (bean3DS);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sndPayWithToken_Lcom_mitec_suitemcommerce_beans_BeanTokenization_Lcom_mitec_suitemcommerce_beans_Bean3DS_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sndPayWithToken", "(Lcom/mitec/suitemcommerce/beans/BeanTokenization;Lcom/mitec/suitemcommerce/beans/Bean3DS;)V"), __args);
			} finally {
			}
		}

	}
}
