using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mitec.Suitemcommerce.Utilities {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Rc4']"
	[global::Android.Runtime.Register ("com/mitec/suitemcommerce/utilities/Rc4", DoNotGenerateAcw=true)]
	public partial class Rc4 : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mitec/suitemcommerce/utilities/Rc4", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Rc4); }
		}

		protected Rc4 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Rc4']/constructor[@name='Rc4' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Rc4 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Rc4)) {
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

		static Delegate cb_encriptaDato_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEncriptaDato_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_encriptaDato_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_encriptaDato_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_EncriptaDato_Ljava_lang_String_Ljava_lang_String_);
			return cb_encriptaDato_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_EncriptaDato_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cadena, IntPtr native_semilla)
		{
			global::Com.Mitec.Suitemcommerce.Utilities.Rc4 __this = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Rc4> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string cadena = JNIEnv.GetString (native_cadena, JniHandleOwnership.DoNotTransfer);
			string semilla = JNIEnv.GetString (native_semilla, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.EncriptaDato (cadena, semilla));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encriptaDato_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Rc4']/method[@name='encriptaDato' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("encriptaDato", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetEncriptaDato_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string EncriptaDato (string cadena, string semilla)
		{
			if (id_encriptaDato_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_encriptaDato_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "encriptaDato", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_cadena = JNIEnv.NewString (cadena);
			IntPtr native_semilla = JNIEnv.NewString (semilla);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_cadena);
				__args [1] = new JValue (native_semilla);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encriptaDato_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encriptaDato", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cadena);
				JNIEnv.DeleteLocalRef (native_semilla);
			}
		}

	}
}
