using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Digest {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='Md5Crypt']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/digest/Md5Crypt", DoNotGenerateAcw=true)]
	public partial class Md5Crypt : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/digest/Md5Crypt", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Md5Crypt); }
		}

		protected Md5Crypt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='Md5Crypt']/constructor[@name='Md5Crypt' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Md5Crypt ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Md5Crypt)) {
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

		static IntPtr id_apr1Crypt_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='Md5Crypt']/method[@name='apr1Crypt' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("apr1Crypt", "([B)Ljava/lang/String;", "")]
		public static unsafe string Apr1Crypt (byte[] keyBytes)
		{
			if (id_apr1Crypt_arrayB == IntPtr.Zero)
				id_apr1Crypt_arrayB = JNIEnv.GetStaticMethodID (class_ref, "apr1Crypt", "([B)Ljava/lang/String;");
			IntPtr native_keyBytes = JNIEnv.NewArray (keyBytes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_keyBytes);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_apr1Crypt_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (keyBytes != null) {
					JNIEnv.CopyArray (native_keyBytes, keyBytes);
					JNIEnv.DeleteLocalRef (native_keyBytes);
				}
			}
		}

		static IntPtr id_apr1Crypt_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='Md5Crypt']/method[@name='apr1Crypt' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("apr1Crypt", "([BLjava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Apr1Crypt (byte[] keyBytes, string salt)
		{
			if (id_apr1Crypt_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_apr1Crypt_arrayBLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "apr1Crypt", "([BLjava/lang/String;)Ljava/lang/String;");
			IntPtr native_keyBytes = JNIEnv.NewArray (keyBytes);
			IntPtr native_salt = JNIEnv.NewString (salt);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_keyBytes);
				__args [1] = new JValue (native_salt);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_apr1Crypt_arrayBLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (keyBytes != null) {
					JNIEnv.CopyArray (native_keyBytes, keyBytes);
					JNIEnv.DeleteLocalRef (native_keyBytes);
				}
				JNIEnv.DeleteLocalRef (native_salt);
			}
		}

		static IntPtr id_apr1Crypt_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='Md5Crypt']/method[@name='apr1Crypt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("apr1Crypt", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Apr1Crypt (string keyBytes)
		{
			if (id_apr1Crypt_Ljava_lang_String_ == IntPtr.Zero)
				id_apr1Crypt_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "apr1Crypt", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_keyBytes = JNIEnv.NewString (keyBytes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_keyBytes);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_apr1Crypt_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_keyBytes);
			}
		}

		static IntPtr id_apr1Crypt_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='Md5Crypt']/method[@name='apr1Crypt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("apr1Crypt", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Apr1Crypt (string keyBytes, string salt)
		{
			if (id_apr1Crypt_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_apr1Crypt_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "apr1Crypt", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_keyBytes = JNIEnv.NewString (keyBytes);
			IntPtr native_salt = JNIEnv.NewString (salt);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_keyBytes);
				__args [1] = new JValue (native_salt);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_apr1Crypt_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_keyBytes);
				JNIEnv.DeleteLocalRef (native_salt);
			}
		}

		static IntPtr id_md5Crypt_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='Md5Crypt']/method[@name='md5Crypt' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("md5Crypt", "([B)Ljava/lang/String;", "")]
		public static unsafe string InvokeMd5Crypt (byte[] keyBytes)
		{
			if (id_md5Crypt_arrayB == IntPtr.Zero)
				id_md5Crypt_arrayB = JNIEnv.GetStaticMethodID (class_ref, "md5Crypt", "([B)Ljava/lang/String;");
			IntPtr native_keyBytes = JNIEnv.NewArray (keyBytes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_keyBytes);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_md5Crypt_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (keyBytes != null) {
					JNIEnv.CopyArray (native_keyBytes, keyBytes);
					JNIEnv.DeleteLocalRef (native_keyBytes);
				}
			}
		}

		static IntPtr id_md5Crypt_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='Md5Crypt']/method[@name='md5Crypt' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("md5Crypt", "([BLjava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string InvokeMd5Crypt (byte[] keyBytes, string salt)
		{
			if (id_md5Crypt_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_md5Crypt_arrayBLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "md5Crypt", "([BLjava/lang/String;)Ljava/lang/String;");
			IntPtr native_keyBytes = JNIEnv.NewArray (keyBytes);
			IntPtr native_salt = JNIEnv.NewString (salt);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_keyBytes);
				__args [1] = new JValue (native_salt);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_md5Crypt_arrayBLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (keyBytes != null) {
					JNIEnv.CopyArray (native_keyBytes, keyBytes);
					JNIEnv.DeleteLocalRef (native_keyBytes);
				}
				JNIEnv.DeleteLocalRef (native_salt);
			}
		}

		static IntPtr id_md5Crypt_arrayBLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='Md5Crypt']/method[@name='md5Crypt' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("md5Crypt", "([BLjava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string InvokeMd5Crypt (byte[] keyBytes, string salt, string prefix)
		{
			if (id_md5Crypt_arrayBLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_md5Crypt_arrayBLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "md5Crypt", "([BLjava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_keyBytes = JNIEnv.NewArray (keyBytes);
			IntPtr native_salt = JNIEnv.NewString (salt);
			IntPtr native_prefix = JNIEnv.NewString (prefix);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_keyBytes);
				__args [1] = new JValue (native_salt);
				__args [2] = new JValue (native_prefix);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_md5Crypt_arrayBLjava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (keyBytes != null) {
					JNIEnv.CopyArray (native_keyBytes, keyBytes);
					JNIEnv.DeleteLocalRef (native_keyBytes);
				}
				JNIEnv.DeleteLocalRef (native_salt);
				JNIEnv.DeleteLocalRef (native_prefix);
			}
		}

	}
}
