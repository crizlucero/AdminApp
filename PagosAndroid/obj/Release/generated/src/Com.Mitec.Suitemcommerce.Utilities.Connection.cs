using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mitec.Suitemcommerce.Utilities {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Connection']"
	[global::Android.Runtime.Register ("com/mitec/suitemcommerce/utilities/Connection", DoNotGenerateAcw=true)]
	public partial class Connection : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mitec/suitemcommerce/utilities/Connection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Connection); }
		}

		protected Connection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Connection']/constructor[@name='Connection' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Connection ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Connection)) {
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

		static Delegate cb_isServiceAvailable;
#pragma warning disable 0169
		static Delegate GetIsServiceAvailableHandler ()
		{
			if (cb_isServiceAvailable == null)
				cb_isServiceAvailable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsServiceAvailable);
			return cb_isServiceAvailable;
		}

		static bool n_IsServiceAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mitec.Suitemcommerce.Utilities.Connection __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Connection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsServiceAvailable;
		}
#pragma warning restore 0169

		static IntPtr id_isServiceAvailable;
		public virtual unsafe bool IsServiceAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Connection']/method[@name='isServiceAvailable' and count(parameter)=0]"
			[Register ("isServiceAvailable", "()Z", "GetIsServiceAvailableHandler")]
			get {
				if (id_isServiceAvailable == IntPtr.Zero)
					id_isServiceAvailable = JNIEnv.GetMethodID (class_ref, "isServiceAvailable", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isServiceAvailable);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isServiceAvailable", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_LeePost_Ljava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetLeePost_Ljava_lang_String_Ljava_lang_String_IHandler ()
		{
			if (cb_LeePost_Ljava_lang_String_Ljava_lang_String_I == null)
				cb_LeePost_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr>) n_LeePost_Ljava_lang_String_Ljava_lang_String_I);
			return cb_LeePost_Ljava_lang_String_Ljava_lang_String_I;
		}

		static IntPtr n_LeePost_Ljava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_aplicacion, IntPtr native_parametros, int time)
		{
			global::Com.Mitec.Suitemcommerce.Utilities.Connection __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Connection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string aplicacion = JNIEnv.GetString (native_aplicacion, JniHandleOwnership.DoNotTransfer);
			string parametros = JNIEnv.GetString (native_parametros, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.LeePost (aplicacion, parametros, time));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_LeePost_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Connection']/method[@name='LeePost' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("LeePost", "(Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;", "GetLeePost_Ljava_lang_String_Ljava_lang_String_IHandler")]
		public virtual unsafe string LeePost (string aplicacion, string parametros, int time)
		{
			if (id_LeePost_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_LeePost_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "LeePost", "(Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;");
			IntPtr native_aplicacion = JNIEnv.NewString (aplicacion);
			IntPtr native_parametros = JNIEnv.NewString (parametros);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_aplicacion);
				__args [1] = new JValue (native_parametros);
				__args [2] = new JValue (time);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_LeePost_Ljava_lang_String_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "LeePost", "(Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_aplicacion);
				JNIEnv.DeleteLocalRef (native_parametros);
			}
		}

		static Delegate cb_redDisponible_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRedDisponible_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_redDisponible_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_redDisponible_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_RedDisponible_Landroid_content_Context_Ljava_lang_String_);
			return cb_redDisponible_Landroid_content_Context_Ljava_lang_String_;
		}

		static bool n_RedDisponible_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_url)
		{
			global::Com.Mitec.Suitemcommerce.Utilities.Connection __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Connection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RedDisponible (context, url);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_redDisponible_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Connection']/method[@name='redDisponible' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("redDisponible", "(Landroid/content/Context;Ljava/lang/String;)Z", "GetRedDisponible_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe bool RedDisponible (global::Android.Content.Context context, string url)
		{
			if (id_redDisponible_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_redDisponible_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "redDisponible", "(Landroid/content/Context;Ljava/lang/String;)Z");
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_url);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_redDisponible_Landroid_content_Context_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "redDisponible", "(Landroid/content/Context;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

	}
}
