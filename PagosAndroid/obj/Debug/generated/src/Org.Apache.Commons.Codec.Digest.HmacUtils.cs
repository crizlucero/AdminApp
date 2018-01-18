using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Digest {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/digest/HmacUtils", DoNotGenerateAcw=true)]
	public sealed partial class HmacUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/digest/HmacUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HmacUtils); }
		}

		internal HmacUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/constructor[@name='HmacUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HmacUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (HmacUtils)) {
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

		static IntPtr id_getHmacMd5_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='getHmacMd5' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getHmacMd5", "([B)Ljavax/crypto/Mac;", "")]
		public static unsafe global::Javax.Crypto.Mac GetHmacMd5 (byte[] key)
		{
			if (id_getHmacMd5_arrayB == IntPtr.Zero)
				id_getHmacMd5_arrayB = JNIEnv.GetStaticMethodID (class_ref, "getHmacMd5", "([B)Ljavax/crypto/Mac;");
			IntPtr native_key = JNIEnv.NewArray (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);
				global::Javax.Crypto.Mac __ret = global::Java.Lang.Object.GetObject<global::Javax.Crypto.Mac> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getHmacMd5_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
			}
		}

		static IntPtr id_getHmacSha1_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='getHmacSha1' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getHmacSha1", "([B)Ljavax/crypto/Mac;", "")]
		public static unsafe global::Javax.Crypto.Mac GetHmacSha1 (byte[] key)
		{
			if (id_getHmacSha1_arrayB == IntPtr.Zero)
				id_getHmacSha1_arrayB = JNIEnv.GetStaticMethodID (class_ref, "getHmacSha1", "([B)Ljavax/crypto/Mac;");
			IntPtr native_key = JNIEnv.NewArray (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);
				global::Javax.Crypto.Mac __ret = global::Java.Lang.Object.GetObject<global::Javax.Crypto.Mac> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getHmacSha1_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
			}
		}

		static IntPtr id_getHmacSha256_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='getHmacSha256' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getHmacSha256", "([B)Ljavax/crypto/Mac;", "")]
		public static unsafe global::Javax.Crypto.Mac GetHmacSha256 (byte[] key)
		{
			if (id_getHmacSha256_arrayB == IntPtr.Zero)
				id_getHmacSha256_arrayB = JNIEnv.GetStaticMethodID (class_ref, "getHmacSha256", "([B)Ljavax/crypto/Mac;");
			IntPtr native_key = JNIEnv.NewArray (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);
				global::Javax.Crypto.Mac __ret = global::Java.Lang.Object.GetObject<global::Javax.Crypto.Mac> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getHmacSha256_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
			}
		}

		static IntPtr id_getHmacSha384_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='getHmacSha384' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getHmacSha384", "([B)Ljavax/crypto/Mac;", "")]
		public static unsafe global::Javax.Crypto.Mac GetHmacSha384 (byte[] key)
		{
			if (id_getHmacSha384_arrayB == IntPtr.Zero)
				id_getHmacSha384_arrayB = JNIEnv.GetStaticMethodID (class_ref, "getHmacSha384", "([B)Ljavax/crypto/Mac;");
			IntPtr native_key = JNIEnv.NewArray (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);
				global::Javax.Crypto.Mac __ret = global::Java.Lang.Object.GetObject<global::Javax.Crypto.Mac> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getHmacSha384_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
			}
		}

		static IntPtr id_getHmacSha512_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='getHmacSha512' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getHmacSha512", "([B)Ljavax/crypto/Mac;", "")]
		public static unsafe global::Javax.Crypto.Mac GetHmacSha512 (byte[] key)
		{
			if (id_getHmacSha512_arrayB == IntPtr.Zero)
				id_getHmacSha512_arrayB = JNIEnv.GetStaticMethodID (class_ref, "getHmacSha512", "([B)Ljavax/crypto/Mac;");
			IntPtr native_key = JNIEnv.NewArray (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);
				global::Javax.Crypto.Mac __ret = global::Java.Lang.Object.GetObject<global::Javax.Crypto.Mac> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getHmacSha512_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
			}
		}

		static IntPtr id_getInitializedMac_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='getInitializedMac' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("getInitializedMac", "(Ljava/lang/String;[B)Ljavax/crypto/Mac;", "")]
		public static unsafe global::Javax.Crypto.Mac GetInitializedMac (string algorithm, byte[] key)
		{
			if (id_getInitializedMac_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_getInitializedMac_Ljava_lang_String_arrayB = JNIEnv.GetStaticMethodID (class_ref, "getInitializedMac", "(Ljava/lang/String;[B)Ljavax/crypto/Mac;");
			IntPtr native_algorithm = JNIEnv.NewString (algorithm);
			IntPtr native_key = JNIEnv.NewArray (key);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_algorithm);
				__args [1] = new JValue (native_key);
				global::Javax.Crypto.Mac __ret = global::Java.Lang.Object.GetObject<global::Javax.Crypto.Mac> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInitializedMac_Ljava_lang_String_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_algorithm);
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
			}
		}

		static IntPtr id_getInitializedMac_Lorg_apache_commons_codec_digest_HmacAlgorithms_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='getInitializedMac' and count(parameter)=2 and parameter[1][@type='org.apache.commons.codec.digest.HmacAlgorithms'] and parameter[2][@type='byte[]']]"
		[Register ("getInitializedMac", "(Lorg/apache/commons/codec/digest/HmacAlgorithms;[B)Ljavax/crypto/Mac;", "")]
		public static unsafe global::Javax.Crypto.Mac GetInitializedMac (global::Org.Apache.Commons.Codec.Digest.HmacAlgorithms algorithm, byte[] key)
		{
			if (id_getInitializedMac_Lorg_apache_commons_codec_digest_HmacAlgorithms_arrayB == IntPtr.Zero)
				id_getInitializedMac_Lorg_apache_commons_codec_digest_HmacAlgorithms_arrayB = JNIEnv.GetStaticMethodID (class_ref, "getInitializedMac", "(Lorg/apache/commons/codec/digest/HmacAlgorithms;[B)Ljavax/crypto/Mac;");
			IntPtr native_key = JNIEnv.NewArray (key);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (algorithm);
				__args [1] = new JValue (native_key);
				global::Javax.Crypto.Mac __ret = global::Java.Lang.Object.GetObject<global::Javax.Crypto.Mac> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInitializedMac_Lorg_apache_commons_codec_digest_HmacAlgorithms_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
			}
		}

		static IntPtr id_hmacMd5_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacMd5' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("hmacMd5", "([B[B)[B", "")]
		public static unsafe byte[] HmacMd5 (byte[] key, byte[] valueToDigest)
		{
			if (id_hmacMd5_arrayBarrayB == IntPtr.Zero)
				id_hmacMd5_arrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "hmacMd5", "([B[B)[B");
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_valueToDigest = JNIEnv.NewArray (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacMd5_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				if (valueToDigest != null) {
					JNIEnv.CopyArray (native_valueToDigest, valueToDigest);
					JNIEnv.DeleteLocalRef (native_valueToDigest);
				}
			}
		}

		static IntPtr id_hmacMd5_arrayBLjava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacMd5' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.io.InputStream']]"
		[Register ("hmacMd5", "([BLjava/io/InputStream;)[B", "")]
		public static unsafe byte[] HmacMd5 (byte[] key, global::System.IO.Stream valueToDigest)
		{
			if (id_hmacMd5_arrayBLjava_io_InputStream_ == IntPtr.Zero)
				id_hmacMd5_arrayBLjava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "hmacMd5", "([BLjava/io/InputStream;)[B");
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_valueToDigest = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacMd5_arrayBLjava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				JNIEnv.DeleteLocalRef (native_valueToDigest);
			}
		}

		static IntPtr id_hmacMd5_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacMd5' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("hmacMd5", "(Ljava/lang/String;Ljava/lang/String;)[B", "")]
		public static unsafe byte[] HmacMd5 (string key, string valueToDigest)
		{
			if (id_hmacMd5_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_hmacMd5_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hmacMd5", "(Ljava/lang/String;Ljava/lang/String;)[B");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_valueToDigest = JNIEnv.NewString (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacMd5_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_valueToDigest);
			}
		}

		static IntPtr id_hmacMd5Hex_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacMd5Hex' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("hmacMd5Hex", "([B[B)Ljava/lang/String;", "")]
		public static unsafe string HmacMd5Hex (byte[] key, byte[] valueToDigest)
		{
			if (id_hmacMd5Hex_arrayBarrayB == IntPtr.Zero)
				id_hmacMd5Hex_arrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "hmacMd5Hex", "([B[B)Ljava/lang/String;");
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_valueToDigest = JNIEnv.NewArray (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacMd5Hex_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				if (valueToDigest != null) {
					JNIEnv.CopyArray (native_valueToDigest, valueToDigest);
					JNIEnv.DeleteLocalRef (native_valueToDigest);
				}
			}
		}

		static IntPtr id_hmacMd5Hex_arrayBLjava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacMd5Hex' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.io.InputStream']]"
		[Register ("hmacMd5Hex", "([BLjava/io/InputStream;)Ljava/lang/String;", "")]
		public static unsafe string HmacMd5Hex (byte[] key, global::System.IO.Stream valueToDigest)
		{
			if (id_hmacMd5Hex_arrayBLjava_io_InputStream_ == IntPtr.Zero)
				id_hmacMd5Hex_arrayBLjava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "hmacMd5Hex", "([BLjava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_valueToDigest = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacMd5Hex_arrayBLjava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				JNIEnv.DeleteLocalRef (native_valueToDigest);
			}
		}

		static IntPtr id_hmacMd5Hex_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacMd5Hex' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("hmacMd5Hex", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string HmacMd5Hex (string key, string valueToDigest)
		{
			if (id_hmacMd5Hex_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_hmacMd5Hex_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hmacMd5Hex", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_valueToDigest = JNIEnv.NewString (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacMd5Hex_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_valueToDigest);
			}
		}

		static IntPtr id_hmacSha1_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacSha1' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("hmacSha1", "([B[B)[B", "")]
		public static unsafe byte[] HmacSha1 (byte[] key, byte[] valueToDigest)
		{
			if (id_hmacSha1_arrayBarrayB == IntPtr.Zero)
				id_hmacSha1_arrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "hmacSha1", "([B[B)[B");
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_valueToDigest = JNIEnv.NewArray (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacSha1_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				if (valueToDigest != null) {
					JNIEnv.CopyArray (native_valueToDigest, valueToDigest);
					JNIEnv.DeleteLocalRef (native_valueToDigest);
				}
			}
		}

		static IntPtr id_hmacSha1_arrayBLjava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacSha1' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.io.InputStream']]"
		[Register ("hmacSha1", "([BLjava/io/InputStream;)[B", "")]
		public static unsafe byte[] HmacSha1 (byte[] key, global::System.IO.Stream valueToDigest)
		{
			if (id_hmacSha1_arrayBLjava_io_InputStream_ == IntPtr.Zero)
				id_hmacSha1_arrayBLjava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "hmacSha1", "([BLjava/io/InputStream;)[B");
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_valueToDigest = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacSha1_arrayBLjava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				JNIEnv.DeleteLocalRef (native_valueToDigest);
			}
		}

		static IntPtr id_hmacSha1_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacSha1' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("hmacSha1", "(Ljava/lang/String;Ljava/lang/String;)[B", "")]
		public static unsafe byte[] HmacSha1 (string key, string valueToDigest)
		{
			if (id_hmacSha1_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_hmacSha1_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hmacSha1", "(Ljava/lang/String;Ljava/lang/String;)[B");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_valueToDigest = JNIEnv.NewString (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacSha1_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_valueToDigest);
			}
		}

		static IntPtr id_hmacSha1Hex_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacSha1Hex' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("hmacSha1Hex", "([B[B)Ljava/lang/String;", "")]
		public static unsafe string HmacSha1Hex (byte[] key, byte[] valueToDigest)
		{
			if (id_hmacSha1Hex_arrayBarrayB == IntPtr.Zero)
				id_hmacSha1Hex_arrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "hmacSha1Hex", "([B[B)Ljava/lang/String;");
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_valueToDigest = JNIEnv.NewArray (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacSha1Hex_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				if (valueToDigest != null) {
					JNIEnv.CopyArray (native_valueToDigest, valueToDigest);
					JNIEnv.DeleteLocalRef (native_valueToDigest);
				}
			}
		}

		static IntPtr id_hmacSha1Hex_arrayBLjava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacSha1Hex' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.io.InputStream']]"
		[Register ("hmacSha1Hex", "([BLjava/io/InputStream;)Ljava/lang/String;", "")]
		public static unsafe string HmacSha1Hex (byte[] key, global::System.IO.Stream valueToDigest)
		{
			if (id_hmacSha1Hex_arrayBLjava_io_InputStream_ == IntPtr.Zero)
				id_hmacSha1Hex_arrayBLjava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "hmacSha1Hex", "([BLjava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_valueToDigest = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacSha1Hex_arrayBLjava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				JNIEnv.DeleteLocalRef (native_valueToDigest);
			}
		}

		static IntPtr id_hmacSha1Hex_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacSha1Hex' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("hmacSha1Hex", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string HmacSha1Hex (string key, string valueToDigest)
		{
			if (id_hmacSha1Hex_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_hmacSha1Hex_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hmacSha1Hex", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_valueToDigest = JNIEnv.NewString (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacSha1Hex_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_valueToDigest);
			}
		}

		static IntPtr id_hmacSha256_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacSha256' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("hmacSha256", "([B[B)[B", "")]
		public static unsafe byte[] HmacSha256 (byte[] key, byte[] valueToDigest)
		{
			if (id_hmacSha256_arrayBarrayB == IntPtr.Zero)
				id_hmacSha256_arrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "hmacSha256", "([B[B)[B");
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_valueToDigest = JNIEnv.NewArray (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacSha256_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				if (valueToDigest != null) {
					JNIEnv.CopyArray (native_valueToDigest, valueToDigest);
					JNIEnv.DeleteLocalRef (native_valueToDigest);
				}
			}
		}

		static IntPtr id_hmacSha256_arrayBLjava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacSha256' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.io.InputStream']]"
		[Register ("hmacSha256", "([BLjava/io/InputStream;)[B", "")]
		public static unsafe byte[] HmacSha256 (byte[] key, global::System.IO.Stream valueToDigest)
		{
			if (id_hmacSha256_arrayBLjava_io_InputStream_ == IntPtr.Zero)
				id_hmacSha256_arrayBLjava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "hmacSha256", "([BLjava/io/InputStream;)[B");
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_valueToDigest = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacSha256_arrayBLjava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				JNIEnv.DeleteLocalRef (native_valueToDigest);
			}
		}

		static IntPtr id_hmacSha256_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacSha256' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("hmacSha256", "(Ljava/lang/String;Ljava/lang/String;)[B", "")]
		public static unsafe byte[] HmacSha256 (string key, string valueToDigest)
		{
			if (id_hmacSha256_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_hmacSha256_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hmacSha256", "(Ljava/lang/String;Ljava/lang/String;)[B");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_valueToDigest = JNIEnv.NewString (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacSha256_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_valueToDigest);
			}
		}

		static IntPtr id_hmacSha256Hex_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacSha256Hex' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("hmacSha256Hex", "([B[B)Ljava/lang/String;", "")]
		public static unsafe string HmacSha256Hex (byte[] key, byte[] valueToDigest)
		{
			if (id_hmacSha256Hex_arrayBarrayB == IntPtr.Zero)
				id_hmacSha256Hex_arrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "hmacSha256Hex", "([B[B)Ljava/lang/String;");
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_valueToDigest = JNIEnv.NewArray (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacSha256Hex_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				if (valueToDigest != null) {
					JNIEnv.CopyArray (native_valueToDigest, valueToDigest);
					JNIEnv.DeleteLocalRef (native_valueToDigest);
				}
			}
		}

		static IntPtr id_hmacSha256Hex_arrayBLjava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacSha256Hex' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.io.InputStream']]"
		[Register ("hmacSha256Hex", "([BLjava/io/InputStream;)Ljava/lang/String;", "")]
		public static unsafe string HmacSha256Hex (byte[] key, global::System.IO.Stream valueToDigest)
		{
			if (id_hmacSha256Hex_arrayBLjava_io_InputStream_ == IntPtr.Zero)
				id_hmacSha256Hex_arrayBLjava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "hmacSha256Hex", "([BLjava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_valueToDigest = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacSha256Hex_arrayBLjava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				JNIEnv.DeleteLocalRef (native_valueToDigest);
			}
		}

		static IntPtr id_hmacSha256Hex_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacSha256Hex' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("hmacSha256Hex", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string HmacSha256Hex (string key, string valueToDigest)
		{
			if (id_hmacSha256Hex_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_hmacSha256Hex_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hmacSha256Hex", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_valueToDigest = JNIEnv.NewString (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacSha256Hex_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_valueToDigest);
			}
		}

		static IntPtr id_hmacSha384_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacSha384' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("hmacSha384", "([B[B)[B", "")]
		public static unsafe byte[] HmacSha384 (byte[] key, byte[] valueToDigest)
		{
			if (id_hmacSha384_arrayBarrayB == IntPtr.Zero)
				id_hmacSha384_arrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "hmacSha384", "([B[B)[B");
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_valueToDigest = JNIEnv.NewArray (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacSha384_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				if (valueToDigest != null) {
					JNIEnv.CopyArray (native_valueToDigest, valueToDigest);
					JNIEnv.DeleteLocalRef (native_valueToDigest);
				}
			}
		}

		static IntPtr id_hmacSha384_arrayBLjava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacSha384' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.io.InputStream']]"
		[Register ("hmacSha384", "([BLjava/io/InputStream;)[B", "")]
		public static unsafe byte[] HmacSha384 (byte[] key, global::System.IO.Stream valueToDigest)
		{
			if (id_hmacSha384_arrayBLjava_io_InputStream_ == IntPtr.Zero)
				id_hmacSha384_arrayBLjava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "hmacSha384", "([BLjava/io/InputStream;)[B");
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_valueToDigest = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacSha384_arrayBLjava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				JNIEnv.DeleteLocalRef (native_valueToDigest);
			}
		}

		static IntPtr id_hmacSha384_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacSha384' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("hmacSha384", "(Ljava/lang/String;Ljava/lang/String;)[B", "")]
		public static unsafe byte[] HmacSha384 (string key, string valueToDigest)
		{
			if (id_hmacSha384_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_hmacSha384_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hmacSha384", "(Ljava/lang/String;Ljava/lang/String;)[B");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_valueToDigest = JNIEnv.NewString (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacSha384_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_valueToDigest);
			}
		}

		static IntPtr id_hmacSha384Hex_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacSha384Hex' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("hmacSha384Hex", "([B[B)Ljava/lang/String;", "")]
		public static unsafe string HmacSha384Hex (byte[] key, byte[] valueToDigest)
		{
			if (id_hmacSha384Hex_arrayBarrayB == IntPtr.Zero)
				id_hmacSha384Hex_arrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "hmacSha384Hex", "([B[B)Ljava/lang/String;");
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_valueToDigest = JNIEnv.NewArray (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacSha384Hex_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				if (valueToDigest != null) {
					JNIEnv.CopyArray (native_valueToDigest, valueToDigest);
					JNIEnv.DeleteLocalRef (native_valueToDigest);
				}
			}
		}

		static IntPtr id_hmacSha384Hex_arrayBLjava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacSha384Hex' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.io.InputStream']]"
		[Register ("hmacSha384Hex", "([BLjava/io/InputStream;)Ljava/lang/String;", "")]
		public static unsafe string HmacSha384Hex (byte[] key, global::System.IO.Stream valueToDigest)
		{
			if (id_hmacSha384Hex_arrayBLjava_io_InputStream_ == IntPtr.Zero)
				id_hmacSha384Hex_arrayBLjava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "hmacSha384Hex", "([BLjava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_valueToDigest = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacSha384Hex_arrayBLjava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				JNIEnv.DeleteLocalRef (native_valueToDigest);
			}
		}

		static IntPtr id_hmacSha384Hex_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacSha384Hex' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("hmacSha384Hex", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string HmacSha384Hex (string key, string valueToDigest)
		{
			if (id_hmacSha384Hex_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_hmacSha384Hex_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hmacSha384Hex", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_valueToDigest = JNIEnv.NewString (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacSha384Hex_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_valueToDigest);
			}
		}

		static IntPtr id_hmacSha512_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacSha512' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("hmacSha512", "([B[B)[B", "")]
		public static unsafe byte[] HmacSha512 (byte[] key, byte[] valueToDigest)
		{
			if (id_hmacSha512_arrayBarrayB == IntPtr.Zero)
				id_hmacSha512_arrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "hmacSha512", "([B[B)[B");
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_valueToDigest = JNIEnv.NewArray (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacSha512_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				if (valueToDigest != null) {
					JNIEnv.CopyArray (native_valueToDigest, valueToDigest);
					JNIEnv.DeleteLocalRef (native_valueToDigest);
				}
			}
		}

		static IntPtr id_hmacSha512_arrayBLjava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacSha512' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.io.InputStream']]"
		[Register ("hmacSha512", "([BLjava/io/InputStream;)[B", "")]
		public static unsafe byte[] HmacSha512 (byte[] key, global::System.IO.Stream valueToDigest)
		{
			if (id_hmacSha512_arrayBLjava_io_InputStream_ == IntPtr.Zero)
				id_hmacSha512_arrayBLjava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "hmacSha512", "([BLjava/io/InputStream;)[B");
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_valueToDigest = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacSha512_arrayBLjava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				JNIEnv.DeleteLocalRef (native_valueToDigest);
			}
		}

		static IntPtr id_hmacSha512_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacSha512' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("hmacSha512", "(Ljava/lang/String;Ljava/lang/String;)[B", "")]
		public static unsafe byte[] HmacSha512 (string key, string valueToDigest)
		{
			if (id_hmacSha512_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_hmacSha512_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hmacSha512", "(Ljava/lang/String;Ljava/lang/String;)[B");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_valueToDigest = JNIEnv.NewString (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacSha512_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_valueToDigest);
			}
		}

		static IntPtr id_hmacSha512Hex_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacSha512Hex' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("hmacSha512Hex", "([B[B)Ljava/lang/String;", "")]
		public static unsafe string HmacSha512Hex (byte[] key, byte[] valueToDigest)
		{
			if (id_hmacSha512Hex_arrayBarrayB == IntPtr.Zero)
				id_hmacSha512Hex_arrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "hmacSha512Hex", "([B[B)Ljava/lang/String;");
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_valueToDigest = JNIEnv.NewArray (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacSha512Hex_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				if (valueToDigest != null) {
					JNIEnv.CopyArray (native_valueToDigest, valueToDigest);
					JNIEnv.DeleteLocalRef (native_valueToDigest);
				}
			}
		}

		static IntPtr id_hmacSha512Hex_arrayBLjava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacSha512Hex' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.io.InputStream']]"
		[Register ("hmacSha512Hex", "([BLjava/io/InputStream;)Ljava/lang/String;", "")]
		public static unsafe string HmacSha512Hex (byte[] key, global::System.IO.Stream valueToDigest)
		{
			if (id_hmacSha512Hex_arrayBLjava_io_InputStream_ == IntPtr.Zero)
				id_hmacSha512Hex_arrayBLjava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "hmacSha512Hex", "([BLjava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_valueToDigest = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacSha512Hex_arrayBLjava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				JNIEnv.DeleteLocalRef (native_valueToDigest);
			}
		}

		static IntPtr id_hmacSha512Hex_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='hmacSha512Hex' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("hmacSha512Hex", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string HmacSha512Hex (string key, string valueToDigest)
		{
			if (id_hmacSha512Hex_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_hmacSha512Hex_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hmacSha512Hex", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_valueToDigest = JNIEnv.NewString (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_valueToDigest);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_hmacSha512Hex_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_valueToDigest);
			}
		}

		static IntPtr id_updateHmac_Ljavax_crypto_Mac_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='updateHmac' and count(parameter)=2 and parameter[1][@type='javax.crypto.Mac'] and parameter[2][@type='byte[]']]"
		[Register ("updateHmac", "(Ljavax/crypto/Mac;[B)Ljavax/crypto/Mac;", "")]
		public static unsafe global::Javax.Crypto.Mac UpdateHmac (global::Javax.Crypto.Mac mac, byte[] valueToDigest)
		{
			if (id_updateHmac_Ljavax_crypto_Mac_arrayB == IntPtr.Zero)
				id_updateHmac_Ljavax_crypto_Mac_arrayB = JNIEnv.GetStaticMethodID (class_ref, "updateHmac", "(Ljavax/crypto/Mac;[B)Ljavax/crypto/Mac;");
			IntPtr native_valueToDigest = JNIEnv.NewArray (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mac);
				__args [1] = new JValue (native_valueToDigest);
				global::Javax.Crypto.Mac __ret = global::Java.Lang.Object.GetObject<global::Javax.Crypto.Mac> (JNIEnv.CallStaticObjectMethod  (class_ref, id_updateHmac_Ljavax_crypto_Mac_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (valueToDigest != null) {
					JNIEnv.CopyArray (native_valueToDigest, valueToDigest);
					JNIEnv.DeleteLocalRef (native_valueToDigest);
				}
			}
		}

		static IntPtr id_updateHmac_Ljavax_crypto_Mac_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='updateHmac' and count(parameter)=2 and parameter[1][@type='javax.crypto.Mac'] and parameter[2][@type='java.io.InputStream']]"
		[Register ("updateHmac", "(Ljavax/crypto/Mac;Ljava/io/InputStream;)Ljavax/crypto/Mac;", "")]
		public static unsafe global::Javax.Crypto.Mac UpdateHmac (global::Javax.Crypto.Mac mac, global::System.IO.Stream valueToDigest)
		{
			if (id_updateHmac_Ljavax_crypto_Mac_Ljava_io_InputStream_ == IntPtr.Zero)
				id_updateHmac_Ljavax_crypto_Mac_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "updateHmac", "(Ljavax/crypto/Mac;Ljava/io/InputStream;)Ljavax/crypto/Mac;");
			IntPtr native_valueToDigest = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mac);
				__args [1] = new JValue (native_valueToDigest);
				global::Javax.Crypto.Mac __ret = global::Java.Lang.Object.GetObject<global::Javax.Crypto.Mac> (JNIEnv.CallStaticObjectMethod  (class_ref, id_updateHmac_Ljavax_crypto_Mac_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_valueToDigest);
			}
		}

		static IntPtr id_updateHmac_Ljavax_crypto_Mac_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacUtils']/method[@name='updateHmac' and count(parameter)=2 and parameter[1][@type='javax.crypto.Mac'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateHmac", "(Ljavax/crypto/Mac;Ljava/lang/String;)Ljavax/crypto/Mac;", "")]
		public static unsafe global::Javax.Crypto.Mac UpdateHmac (global::Javax.Crypto.Mac mac, string valueToDigest)
		{
			if (id_updateHmac_Ljavax_crypto_Mac_Ljava_lang_String_ == IntPtr.Zero)
				id_updateHmac_Ljavax_crypto_Mac_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "updateHmac", "(Ljavax/crypto/Mac;Ljava/lang/String;)Ljavax/crypto/Mac;");
			IntPtr native_valueToDigest = JNIEnv.NewString (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mac);
				__args [1] = new JValue (native_valueToDigest);
				global::Javax.Crypto.Mac __ret = global::Java.Lang.Object.GetObject<global::Javax.Crypto.Mac> (JNIEnv.CallStaticObjectMethod  (class_ref, id_updateHmac_Ljavax_crypto_Mac_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_valueToDigest);
			}
		}

	}
}
