using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mitec.Suitemcommerce.Utilities {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='AESEncryption']"
	[global::Android.Runtime.Register ("com/mitec/suitemcommerce/utilities/AESEncryption", DoNotGenerateAcw=true)]
	public partial class AESEncryption : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mitec/suitemcommerce/utilities/AESEncryption", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AESEncryption); }
		}

		protected AESEncryption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='AESEncryption']/constructor[@name='AESEncryption' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AESEncryption ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AESEncryption)) {
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

		static IntPtr id_cifrar_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Lorg_apache_commons_codec_BinaryEncoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='AESEncryption']/method[@name='cifrar' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='org.apache.commons.codec.BinaryEncoder']]"
		[Register ("cifrar", "(Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;Lorg/apache/commons/codec/BinaryEncoder;)Ljava/lang/String;", "")]
		public static unsafe string Cifrar (string cadena, byte[] llave, string mode, string padding, global::Org.Apache.Commons.Codec.IBinaryEncoder encoder)
		{
			if (id_cifrar_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Lorg_apache_commons_codec_BinaryEncoder_ == IntPtr.Zero)
				id_cifrar_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Lorg_apache_commons_codec_BinaryEncoder_ = JNIEnv.GetStaticMethodID (class_ref, "cifrar", "(Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;Lorg/apache/commons/codec/BinaryEncoder;)Ljava/lang/String;");
			IntPtr native_cadena = JNIEnv.NewString (cadena);
			IntPtr native_llave = JNIEnv.NewArray (llave);
			IntPtr native_mode = JNIEnv.NewString (mode);
			IntPtr native_padding = JNIEnv.NewString (padding);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_cadena);
				__args [1] = new JValue (native_llave);
				__args [2] = new JValue (native_mode);
				__args [3] = new JValue (native_padding);
				__args [4] = new JValue (encoder);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_cifrar_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Lorg_apache_commons_codec_BinaryEncoder_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cadena);
				if (llave != null) {
					JNIEnv.CopyArray (native_llave, llave);
					JNIEnv.DeleteLocalRef (native_llave);
				}
				JNIEnv.DeleteLocalRef (native_mode);
				JNIEnv.DeleteLocalRef (native_padding);
			}
		}

		static IntPtr id_decrypt_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='AESEncryption']/method[@name='decrypt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("decrypt", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Decrypt (string encodedInitialData, string key)
		{
			if (id_decrypt_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_decrypt_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decrypt", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_encodedInitialData = JNIEnv.NewString (encodedInitialData);
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_encodedInitialData);
				__args [1] = new JValue (native_key);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_decrypt_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_encodedInitialData);
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static IntPtr id_descifrar_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Lorg_apache_commons_codec_BinaryDecoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='AESEncryption']/method[@name='descifrar' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='org.apache.commons.codec.BinaryDecoder']]"
		[Register ("descifrar", "(Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;Lorg/apache/commons/codec/BinaryDecoder;)Ljava/lang/String;", "")]
		public static unsafe string Descifrar (string encriptado, byte[] llave, string mode, string padding, global::Org.Apache.Commons.Codec.IBinaryDecoder decoder)
		{
			if (id_descifrar_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Lorg_apache_commons_codec_BinaryDecoder_ == IntPtr.Zero)
				id_descifrar_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Lorg_apache_commons_codec_BinaryDecoder_ = JNIEnv.GetStaticMethodID (class_ref, "descifrar", "(Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;Lorg/apache/commons/codec/BinaryDecoder;)Ljava/lang/String;");
			IntPtr native_encriptado = JNIEnv.NewString (encriptado);
			IntPtr native_llave = JNIEnv.NewArray (llave);
			IntPtr native_mode = JNIEnv.NewString (mode);
			IntPtr native_padding = JNIEnv.NewString (padding);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_encriptado);
				__args [1] = new JValue (native_llave);
				__args [2] = new JValue (native_mode);
				__args [3] = new JValue (native_padding);
				__args [4] = new JValue (decoder);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_descifrar_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Lorg_apache_commons_codec_BinaryDecoder_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_encriptado);
				if (llave != null) {
					JNIEnv.CopyArray (native_llave, llave);
					JNIEnv.DeleteLocalRef (native_llave);
				}
				JNIEnv.DeleteLocalRef (native_mode);
				JNIEnv.DeleteLocalRef (native_padding);
			}
		}

		static IntPtr id_encrypt_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='AESEncryption']/method[@name='encrypt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("encrypt", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Encrypt (string plaintext, string key)
		{
			if (id_encrypt_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_encrypt_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encrypt", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_plaintext = JNIEnv.NewString (plaintext);
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_plaintext);
				__args [1] = new JValue (native_key);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encrypt_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_plaintext);
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static IntPtr id_generaKey;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='AESEncryption']/method[@name='generaKey' and count(parameter)=0]"
		[Register ("generaKey", "()Ljava/lang/String;", "")]
		public static unsafe string GeneraKey ()
		{
			if (id_generaKey == IntPtr.Zero)
				id_generaKey = JNIEnv.GetStaticMethodID (class_ref, "generaKey", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_generaKey), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_hexStringToByteArray_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='AESEncryption']/method[@name='hexStringToByteArray' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hexStringToByteArray", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] HexStringToByteArray (string s)
		{
			if (id_hexStringToByteArray_Ljava_lang_String_ == IntPtr.Zero)
				id_hexStringToByteArray_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hexStringToByteArray", "(Ljava/lang/String;)[B");
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_s);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_hexStringToByteArray_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

	}
}
