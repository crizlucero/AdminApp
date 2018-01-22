using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mitec.Suitemcommerce.Utilities {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='TripleDESEncryption']"
	[global::Android.Runtime.Register ("com/mitec/suitemcommerce/utilities/TripleDESEncryption", DoNotGenerateAcw=true)]
	public partial class TripleDESEncryption : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mitec/suitemcommerce/utilities/TripleDESEncryption", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TripleDESEncryption); }
		}

		protected TripleDESEncryption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='TripleDESEncryption']/constructor[@name='TripleDESEncryption' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TripleDESEncryption ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TripleDESEncryption)) {
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

		static IntPtr id_StringToHexString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='TripleDESEncryption']/method[@name='StringToHexString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("StringToHexString", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string StringToHexString (string s)
		{
			if (id_StringToHexString_Ljava_lang_String_ == IntPtr.Zero)
				id_StringToHexString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "StringToHexString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_s);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_StringToHexString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		static IntPtr id_decrypt_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='TripleDESEncryption']/method[@name='decrypt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("decrypt", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Decrypt (string codeText, string key)
		{
			if (id_decrypt_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_decrypt_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decrypt", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_codeText = JNIEnv.NewString (codeText);
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_codeText);
				__args [1] = new JValue (native_key);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_decrypt_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_codeText);
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static IntPtr id_decryptPgs_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='TripleDESEncryption']/method[@name='decryptPgs' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("decryptPgs", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string DecryptPgs (string cipherTextB64, string llave)
		{
			if (id_decryptPgs_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_decryptPgs_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decryptPgs", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_cipherTextB64 = JNIEnv.NewString (cipherTextB64);
			IntPtr native_llave = JNIEnv.NewString (llave);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_cipherTextB64);
				__args [1] = new JValue (native_llave);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_decryptPgs_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cipherTextB64);
				JNIEnv.DeleteLocalRef (native_llave);
			}
		}

		static IntPtr id_encrypt_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='TripleDESEncryption']/method[@name='encrypt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("encrypt", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Encrypt (string clearText, string key)
		{
			if (id_encrypt_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_encrypt_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encrypt", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_clearText = JNIEnv.NewString (clearText);
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_clearText);
				__args [1] = new JValue (native_key);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encrypt_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_clearText);
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static IntPtr id_encryptPgs_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='TripleDESEncryption']/method[@name='encryptPgs' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("encryptPgs", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string EncryptPgs (string clearText, string llave)
		{
			if (id_encryptPgs_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_encryptPgs_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encryptPgs", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_clearText = JNIEnv.NewString (clearText);
			IntPtr native_llave = JNIEnv.NewString (llave);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_clearText);
				__args [1] = new JValue (native_llave);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encryptPgs_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_clearText);
				JNIEnv.DeleteLocalRef (native_llave);
			}
		}

		static IntPtr id_hexStringToString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='TripleDESEncryption']/method[@name='hexStringToString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hexStringToString", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string HexStringToString (string s)
		{
			if (id_hexStringToString_Ljava_lang_String_ == IntPtr.Zero)
				id_hexStringToString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hexStringToString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_s);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_hexStringToString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='TripleDESEncryption']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (string[] args)
		{
			if (id_main_arrayLjava_lang_String_ == IntPtr.Zero)
				id_main_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "main", "([Ljava/lang/String;)V");
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_main_arrayLjava_lang_String_, __args);
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

	}
}
