using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mitec.Suitemcommerce.Utilities {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Profile']"
	[global::Android.Runtime.Register ("com/mitec/suitemcommerce/utilities/Profile", DoNotGenerateAcw=true)]
	public partial class Profile : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/interface[@name='Profile.SessionIDListenerDoPayment']"
		[Register ("com/mitec/suitemcommerce/utilities/Profile$SessionIDListenerDoPayment", "", "Com.Mitec.Suitemcommerce.Utilities.Profile/ISessionIDListenerDoPaymentInvoker")]
		public partial interface ISessionIDListenerDoPayment : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/interface[@name='Profile.SessionIDListenerDoPayment']/method[@name='sessionIDResultDoPayment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("sessionIDResultDoPayment", "(Ljava/lang/String;)V", "GetSessionIDResultDoPayment_Ljava_lang_String_Handler:Com.Mitec.Suitemcommerce.Utilities.Profile/ISessionIDListenerDoPaymentInvoker, PagosAndroid")]
			void SessionIDResultDoPayment (string p0);

		}

		[global::Android.Runtime.Register ("com/mitec/suitemcommerce/utilities/Profile$SessionIDListenerDoPayment", DoNotGenerateAcw=true)]
		internal class ISessionIDListenerDoPaymentInvoker : global::Java.Lang.Object, ISessionIDListenerDoPayment {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mitec/suitemcommerce/utilities/Profile$SessionIDListenerDoPayment");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ISessionIDListenerDoPaymentInvoker); }
			}

			IntPtr class_ref;

			public static ISessionIDListenerDoPayment GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISessionIDListenerDoPayment> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mitec.suitemcommerce.utilities.Profile.SessionIDListenerDoPayment"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISessionIDListenerDoPaymentInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_sessionIDResultDoPayment_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSessionIDResultDoPayment_Ljava_lang_String_Handler ()
			{
				if (cb_sessionIDResultDoPayment_Ljava_lang_String_ == null)
					cb_sessionIDResultDoPayment_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SessionIDResultDoPayment_Ljava_lang_String_);
				return cb_sessionIDResultDoPayment_Ljava_lang_String_;
			}

			static void n_SessionIDResultDoPayment_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mitec.Suitemcommerce.Utilities.Profile.ISessionIDListenerDoPayment __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Profile.ISessionIDListenerDoPayment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SessionIDResultDoPayment (p0);
			}
#pragma warning restore 0169

			IntPtr id_sessionIDResultDoPayment_Ljava_lang_String_;
			public unsafe void SessionIDResultDoPayment (string p0)
			{
				if (id_sessionIDResultDoPayment_Ljava_lang_String_ == IntPtr.Zero)
					id_sessionIDResultDoPayment_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sessionIDResultDoPayment", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sessionIDResultDoPayment_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/interface[@name='Profile.SessionIDListenerPayment']"
		[Register ("com/mitec/suitemcommerce/utilities/Profile$SessionIDListenerPayment", "", "Com.Mitec.Suitemcommerce.Utilities.Profile/ISessionIDListenerPaymentInvoker")]
		public partial interface ISessionIDListenerPayment : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/interface[@name='Profile.SessionIDListenerPayment']/method[@name='sessionIDResultPayment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("sessionIDResultPayment", "(Ljava/lang/String;)V", "GetSessionIDResultPayment_Ljava_lang_String_Handler:Com.Mitec.Suitemcommerce.Utilities.Profile/ISessionIDListenerPaymentInvoker, PagosAndroid")]
			void SessionIDResultPayment (string p0);

		}

		[global::Android.Runtime.Register ("com/mitec/suitemcommerce/utilities/Profile$SessionIDListenerPayment", DoNotGenerateAcw=true)]
		internal class ISessionIDListenerPaymentInvoker : global::Java.Lang.Object, ISessionIDListenerPayment {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mitec/suitemcommerce/utilities/Profile$SessionIDListenerPayment");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ISessionIDListenerPaymentInvoker); }
			}

			IntPtr class_ref;

			public static ISessionIDListenerPayment GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISessionIDListenerPayment> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mitec.suitemcommerce.utilities.Profile.SessionIDListenerPayment"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISessionIDListenerPaymentInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_sessionIDResultPayment_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSessionIDResultPayment_Ljava_lang_String_Handler ()
			{
				if (cb_sessionIDResultPayment_Ljava_lang_String_ == null)
					cb_sessionIDResultPayment_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SessionIDResultPayment_Ljava_lang_String_);
				return cb_sessionIDResultPayment_Ljava_lang_String_;
			}

			static void n_SessionIDResultPayment_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mitec.Suitemcommerce.Utilities.Profile.ISessionIDListenerPayment __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Profile.ISessionIDListenerPayment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SessionIDResultPayment (p0);
			}
#pragma warning restore 0169

			IntPtr id_sessionIDResultPayment_Ljava_lang_String_;
			public unsafe void SessionIDResultPayment (string p0)
			{
				if (id_sessionIDResultPayment_Ljava_lang_String_ == IntPtr.Zero)
					id_sessionIDResultPayment_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sessionIDResultPayment", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sessionIDResultPayment_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/interface[@name='Profile.SessionIDListenerToken']"
		[Register ("com/mitec/suitemcommerce/utilities/Profile$SessionIDListenerToken", "", "Com.Mitec.Suitemcommerce.Utilities.Profile/ISessionIDListenerTokenInvoker")]
		public partial interface ISessionIDListenerToken : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/interface[@name='Profile.SessionIDListenerToken']/method[@name='sessionIDResult' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("sessionIDResult", "(Ljava/lang/String;)V", "GetSessionIDResult_Ljava_lang_String_Handler:Com.Mitec.Suitemcommerce.Utilities.Profile/ISessionIDListenerTokenInvoker, PagosAndroid")]
			void SessionIDResult (string p0);

		}

		[global::Android.Runtime.Register ("com/mitec/suitemcommerce/utilities/Profile$SessionIDListenerToken", DoNotGenerateAcw=true)]
		internal class ISessionIDListenerTokenInvoker : global::Java.Lang.Object, ISessionIDListenerToken {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mitec/suitemcommerce/utilities/Profile$SessionIDListenerToken");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ISessionIDListenerTokenInvoker); }
			}

			IntPtr class_ref;

			public static ISessionIDListenerToken GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISessionIDListenerToken> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mitec.suitemcommerce.utilities.Profile.SessionIDListenerToken"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISessionIDListenerTokenInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_sessionIDResult_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSessionIDResult_Ljava_lang_String_Handler ()
			{
				if (cb_sessionIDResult_Ljava_lang_String_ == null)
					cb_sessionIDResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SessionIDResult_Ljava_lang_String_);
				return cb_sessionIDResult_Ljava_lang_String_;
			}

			static void n_SessionIDResult_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mitec.Suitemcommerce.Utilities.Profile.ISessionIDListenerToken __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Profile.ISessionIDListenerToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SessionIDResult (p0);
			}
#pragma warning restore 0169

			IntPtr id_sessionIDResult_Ljava_lang_String_;
			public unsafe void SessionIDResult (string p0)
			{
				if (id_sessionIDResult_Ljava_lang_String_ == IntPtr.Zero)
					id_sessionIDResult_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sessionIDResult", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sessionIDResult_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mitec/suitemcommerce/utilities/Profile", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Profile); }
		}

		protected Profile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Profile']/constructor[@name='Profile' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Profile ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Profile)) {
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

		static Delegate cb_doProfileDoPayment_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerDoPayment_;
#pragma warning disable 0169
		static Delegate GetDoProfileDoPayment_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerDoPayment_Handler ()
		{
			if (cb_doProfileDoPayment_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerDoPayment_ == null)
				cb_doProfileDoPayment_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerDoPayment_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DoProfileDoPayment_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerDoPayment_);
			return cb_doProfileDoPayment_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerDoPayment_;
		}

		static IntPtr n_DoProfileDoPayment_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerDoPayment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_listener)
		{
			global::Com.Mitec.Suitemcommerce.Utilities.Profile __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Profile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			global::Com.Mitec.Suitemcommerce.Utilities.Profile.ISessionIDListenerDoPayment listener = (global::Com.Mitec.Suitemcommerce.Utilities.Profile.ISessionIDListenerDoPayment)global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Profile.ISessionIDListenerDoPayment> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.DoProfileDoPayment (context, listener));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_doProfileDoPayment_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerDoPayment_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Profile']/method[@name='doProfileDoPayment' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mitec.suitemcommerce.utilities.Profile.SessionIDListenerDoPayment']]"
		[Register ("doProfileDoPayment", "(Landroid/content/Context;Lcom/mitec/suitemcommerce/utilities/Profile$SessionIDListenerDoPayment;)Ljava/lang/String;", "GetDoProfileDoPayment_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerDoPayment_Handler")]
		public virtual unsafe string DoProfileDoPayment (global::Android.Content.Context context, global::Com.Mitec.Suitemcommerce.Utilities.Profile.ISessionIDListenerDoPayment listener)
		{
			if (id_doProfileDoPayment_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerDoPayment_ == IntPtr.Zero)
				id_doProfileDoPayment_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerDoPayment_ = JNIEnv.GetMethodID (class_ref, "doProfileDoPayment", "(Landroid/content/Context;Lcom/mitec/suitemcommerce/utilities/Profile$SessionIDListenerDoPayment;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (listener);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doProfileDoPayment_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerDoPayment_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doProfileDoPayment", "(Landroid/content/Context;Lcom/mitec/suitemcommerce/utilities/Profile$SessionIDListenerDoPayment;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_doProfilePayment_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerPayment_;
#pragma warning disable 0169
		static Delegate GetDoProfilePayment_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerPayment_Handler ()
		{
			if (cb_doProfilePayment_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerPayment_ == null)
				cb_doProfilePayment_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerPayment_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DoProfilePayment_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerPayment_);
			return cb_doProfilePayment_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerPayment_;
		}

		static IntPtr n_DoProfilePayment_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerPayment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_listener)
		{
			global::Com.Mitec.Suitemcommerce.Utilities.Profile __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Profile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			global::Com.Mitec.Suitemcommerce.Utilities.Profile.ISessionIDListenerPayment listener = (global::Com.Mitec.Suitemcommerce.Utilities.Profile.ISessionIDListenerPayment)global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Profile.ISessionIDListenerPayment> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.DoProfilePayment (context, listener));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_doProfilePayment_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerPayment_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Profile']/method[@name='doProfilePayment' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mitec.suitemcommerce.utilities.Profile.SessionIDListenerPayment']]"
		[Register ("doProfilePayment", "(Landroid/content/Context;Lcom/mitec/suitemcommerce/utilities/Profile$SessionIDListenerPayment;)Ljava/lang/String;", "GetDoProfilePayment_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerPayment_Handler")]
		public virtual unsafe string DoProfilePayment (global::Android.Content.Context context, global::Com.Mitec.Suitemcommerce.Utilities.Profile.ISessionIDListenerPayment listener)
		{
			if (id_doProfilePayment_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerPayment_ == IntPtr.Zero)
				id_doProfilePayment_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerPayment_ = JNIEnv.GetMethodID (class_ref, "doProfilePayment", "(Landroid/content/Context;Lcom/mitec/suitemcommerce/utilities/Profile$SessionIDListenerPayment;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (listener);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doProfilePayment_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerPayment_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doProfilePayment", "(Landroid/content/Context;Lcom/mitec/suitemcommerce/utilities/Profile$SessionIDListenerPayment;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_doProfileToken_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerToken_;
#pragma warning disable 0169
		static Delegate GetDoProfileToken_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerToken_Handler ()
		{
			if (cb_doProfileToken_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerToken_ == null)
				cb_doProfileToken_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerToken_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DoProfileToken_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerToken_);
			return cb_doProfileToken_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerToken_;
		}

		static IntPtr n_DoProfileToken_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_listener)
		{
			global::Com.Mitec.Suitemcommerce.Utilities.Profile __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Profile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			global::Com.Mitec.Suitemcommerce.Utilities.Profile.ISessionIDListenerToken listener = (global::Com.Mitec.Suitemcommerce.Utilities.Profile.ISessionIDListenerToken)global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Profile.ISessionIDListenerToken> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.DoProfileToken (context, listener));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_doProfileToken_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Profile']/method[@name='doProfileToken' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mitec.suitemcommerce.utilities.Profile.SessionIDListenerToken']]"
		[Register ("doProfileToken", "(Landroid/content/Context;Lcom/mitec/suitemcommerce/utilities/Profile$SessionIDListenerToken;)Ljava/lang/String;", "GetDoProfileToken_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerToken_Handler")]
		public virtual unsafe string DoProfileToken (global::Android.Content.Context context, global::Com.Mitec.Suitemcommerce.Utilities.Profile.ISessionIDListenerToken listener)
		{
			if (id_doProfileToken_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerToken_ == IntPtr.Zero)
				id_doProfileToken_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerToken_ = JNIEnv.GetMethodID (class_ref, "doProfileToken", "(Landroid/content/Context;Lcom/mitec/suitemcommerce/utilities/Profile$SessionIDListenerToken;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (listener);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doProfileToken_Landroid_content_Context_Lcom_mitec_suitemcommerce_utilities_Profile_SessionIDListenerToken_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doProfileToken", "(Landroid/content/Context;Lcom/mitec/suitemcommerce/utilities/Profile$SessionIDListenerToken;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
