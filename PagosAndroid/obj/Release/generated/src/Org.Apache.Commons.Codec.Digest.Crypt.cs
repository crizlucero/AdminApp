using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Digest {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='Crypt']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/digest/Crypt", DoNotGenerateAcw=true)]
	public partial class Crypt : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/digest/Crypt", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Crypt); }
		}

		protected Crypt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='Crypt']/constructor[@name='Crypt' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Crypt ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Crypt)) {
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

		static IntPtr id_crypt_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='Crypt']/method[@name='crypt' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("crypt", "([B)Ljava/lang/String;", "")]
		public static unsafe string InvokeCrypt (byte[] keyBytes)
		{
			if (id_crypt_arrayB == IntPtr.Zero)
				id_crypt_arrayB = JNIEnv.GetStaticMethodID (class_ref, "crypt", "([B)Ljava/lang/String;");
			IntPtr native_keyBytes = JNIEnv.NewArray (keyBytes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_keyBytes);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_crypt_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (keyBytes != null) {
					JNIEnv.CopyArray (native_keyBytes, keyBytes);
					JNIEnv.DeleteLocalRef (native_keyBytes);
				}
			}
		}

		static IntPtr id_crypt_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='Crypt']/method[@name='crypt' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("crypt", "([BLjava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string InvokeCrypt (byte[] keyBytes, string salt)
		{
			if (id_crypt_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_crypt_arrayBLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "crypt", "([BLjava/lang/String;)Ljava/lang/String;");
			IntPtr native_keyBytes = JNIEnv.NewArray (keyBytes);
			IntPtr native_salt = JNIEnv.NewString (salt);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_keyBytes);
				__args [1] = new JValue (native_salt);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_crypt_arrayBLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (keyBytes != null) {
					JNIEnv.CopyArray (native_keyBytes, keyBytes);
					JNIEnv.DeleteLocalRef (native_keyBytes);
				}
				JNIEnv.DeleteLocalRef (native_salt);
			}
		}

		static IntPtr id_crypt_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='Crypt']/method[@name='crypt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("crypt", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string InvokeCrypt (string key)
		{
			if (id_crypt_Ljava_lang_String_ == IntPtr.Zero)
				id_crypt_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "crypt", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_crypt_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static IntPtr id_crypt_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='Crypt']/method[@name='crypt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("crypt", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string InvokeCrypt (string key, string salt)
		{
			if (id_crypt_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_crypt_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "crypt", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_salt = JNIEnv.NewString (salt);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_salt);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_crypt_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_salt);
			}
		}

	}
}
