using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Digest {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacAlgorithms']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/digest/HmacAlgorithms", DoNotGenerateAcw=true)]
	public sealed partial class HmacAlgorithms : global::Java.Lang.Enum {


		static IntPtr HMAC_MD5_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacAlgorithms']/field[@name='HMAC_MD5']"
		[Register ("HMAC_MD5")]
		public static global::Org.Apache.Commons.Codec.Digest.HmacAlgorithms HmacMd5 {
			get {
				if (HMAC_MD5_jfieldId == IntPtr.Zero)
					HMAC_MD5_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HMAC_MD5", "Lorg/apache/commons/codec/digest/HmacAlgorithms;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HMAC_MD5_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Digest.HmacAlgorithms> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HMAC_SHA_1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacAlgorithms']/field[@name='HMAC_SHA_1']"
		[Register ("HMAC_SHA_1")]
		public static global::Org.Apache.Commons.Codec.Digest.HmacAlgorithms HmacSha1 {
			get {
				if (HMAC_SHA_1_jfieldId == IntPtr.Zero)
					HMAC_SHA_1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HMAC_SHA_1", "Lorg/apache/commons/codec/digest/HmacAlgorithms;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HMAC_SHA_1_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Digest.HmacAlgorithms> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HMAC_SHA_256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacAlgorithms']/field[@name='HMAC_SHA_256']"
		[Register ("HMAC_SHA_256")]
		public static global::Org.Apache.Commons.Codec.Digest.HmacAlgorithms HmacSha256 {
			get {
				if (HMAC_SHA_256_jfieldId == IntPtr.Zero)
					HMAC_SHA_256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HMAC_SHA_256", "Lorg/apache/commons/codec/digest/HmacAlgorithms;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HMAC_SHA_256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Digest.HmacAlgorithms> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HMAC_SHA_384_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacAlgorithms']/field[@name='HMAC_SHA_384']"
		[Register ("HMAC_SHA_384")]
		public static global::Org.Apache.Commons.Codec.Digest.HmacAlgorithms HmacSha384 {
			get {
				if (HMAC_SHA_384_jfieldId == IntPtr.Zero)
					HMAC_SHA_384_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HMAC_SHA_384", "Lorg/apache/commons/codec/digest/HmacAlgorithms;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HMAC_SHA_384_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Digest.HmacAlgorithms> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HMAC_SHA_512_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacAlgorithms']/field[@name='HMAC_SHA_512']"
		[Register ("HMAC_SHA_512")]
		public static global::Org.Apache.Commons.Codec.Digest.HmacAlgorithms HmacSha512 {
			get {
				if (HMAC_SHA_512_jfieldId == IntPtr.Zero)
					HMAC_SHA_512_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HMAC_SHA_512", "Lorg/apache/commons/codec/digest/HmacAlgorithms;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HMAC_SHA_512_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Digest.HmacAlgorithms> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/digest/HmacAlgorithms", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HmacAlgorithms); }
		}

		internal HmacAlgorithms (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacAlgorithms']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/apache/commons/codec/digest/HmacAlgorithms;", "")]
		public static unsafe global::Org.Apache.Commons.Codec.Digest.HmacAlgorithms ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/apache/commons/codec/digest/HmacAlgorithms;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Org.Apache.Commons.Codec.Digest.HmacAlgorithms __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Digest.HmacAlgorithms> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='HmacAlgorithms']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/apache/commons/codec/digest/HmacAlgorithms;", "")]
		public static unsafe global::Org.Apache.Commons.Codec.Digest.HmacAlgorithms[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/apache/commons/codec/digest/HmacAlgorithms;");
			try {
				return (global::Org.Apache.Commons.Codec.Digest.HmacAlgorithms[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Apache.Commons.Codec.Digest.HmacAlgorithms));
			} finally {
			}
		}

	}
}
