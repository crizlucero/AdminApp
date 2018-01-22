using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mitec.Suitemcommerce.Utilities {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='RSAHelper']"
	[global::Android.Runtime.Register ("com/mitec/suitemcommerce/utilities/RSAHelper", DoNotGenerateAcw=true)]
	public partial class RSAHelper : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mitec/suitemcommerce/utilities/RSAHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RSAHelper); }
		}

		protected RSAHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='RSAHelper']/constructor[@name='RSAHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RSAHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (RSAHelper)) {
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

		static IntPtr id_cifrar_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='RSAHelper']/method[@name='cifrar' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("cifrar", "([B[B)[B", "")]
		public static unsafe byte[] Cifrar (byte[] clearText, byte[] publicKey)
		{
			if (id_cifrar_arrayBarrayB == IntPtr.Zero)
				id_cifrar_arrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "cifrar", "([B[B)[B");
			IntPtr native_clearText = JNIEnv.NewArray (clearText);
			IntPtr native_publicKey = JNIEnv.NewArray (publicKey);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_clearText);
				__args [1] = new JValue (native_publicKey);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_cifrar_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (clearText != null) {
					JNIEnv.CopyArray (native_clearText, clearText);
					JNIEnv.DeleteLocalRef (native_clearText);
				}
				if (publicKey != null) {
					JNIEnv.CopyArray (native_publicKey, publicKey);
					JNIEnv.DeleteLocalRef (native_publicKey);
				}
			}
		}

		static IntPtr id_cifrar_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='RSAHelper']/method[@name='cifrar' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("cifrar", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Cifrar (string clearText, string publicKey)
		{
			if (id_cifrar_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_cifrar_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "cifrar", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_clearText = JNIEnv.NewString (clearText);
			IntPtr native_publicKey = JNIEnv.NewString (publicKey);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_clearText);
				__args [1] = new JValue (native_publicKey);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_cifrar_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_clearText);
				JNIEnv.DeleteLocalRef (native_publicKey);
			}
		}

	}
}
