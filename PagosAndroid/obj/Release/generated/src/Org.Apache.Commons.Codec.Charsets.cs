using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec']/class[@name='Charsets']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/Charsets", DoNotGenerateAcw=true)]
	public partial class Charsets : global::Java.Lang.Object {


		static IntPtr ISO_8859_1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec']/class[@name='Charsets']/field[@name='ISO_8859_1']"
		[Register ("ISO_8859_1")]
		public static global::Java.Nio.Charset.Charset Iso88591 {
			get {
				if (ISO_8859_1_jfieldId == IntPtr.Zero)
					ISO_8859_1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO_8859_1", "Ljava/nio/charset/Charset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO_8859_1_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr US_ASCII_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec']/class[@name='Charsets']/field[@name='US_ASCII']"
		[Register ("US_ASCII")]
		public static global::Java.Nio.Charset.Charset UsAscii {
			get {
				if (US_ASCII_jfieldId == IntPtr.Zero)
					US_ASCII_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "US_ASCII", "Ljava/nio/charset/Charset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, US_ASCII_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UTF_16_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec']/class[@name='Charsets']/field[@name='UTF_16']"
		[Register ("UTF_16")]
		public static global::Java.Nio.Charset.Charset Utf16 {
			get {
				if (UTF_16_jfieldId == IntPtr.Zero)
					UTF_16_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UTF_16", "Ljava/nio/charset/Charset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UTF_16_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UTF_16BE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec']/class[@name='Charsets']/field[@name='UTF_16BE']"
		[Register ("UTF_16BE")]
		public static global::Java.Nio.Charset.Charset Utf16be {
			get {
				if (UTF_16BE_jfieldId == IntPtr.Zero)
					UTF_16BE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UTF_16BE", "Ljava/nio/charset/Charset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UTF_16BE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UTF_16LE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec']/class[@name='Charsets']/field[@name='UTF_16LE']"
		[Register ("UTF_16LE")]
		public static global::Java.Nio.Charset.Charset Utf16le {
			get {
				if (UTF_16LE_jfieldId == IntPtr.Zero)
					UTF_16LE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UTF_16LE", "Ljava/nio/charset/Charset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UTF_16LE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UTF_8_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec']/class[@name='Charsets']/field[@name='UTF_8']"
		[Register ("UTF_8")]
		public static global::Java.Nio.Charset.Charset Utf8 {
			get {
				if (UTF_8_jfieldId == IntPtr.Zero)
					UTF_8_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UTF_8", "Ljava/nio/charset/Charset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UTF_8_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/Charsets", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Charsets); }
		}

		protected Charsets (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec']/class[@name='Charsets']/constructor[@name='Charsets' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Charsets ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Charsets)) {
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

		static IntPtr id_toCharset_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec']/class[@name='Charsets']/method[@name='toCharset' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toCharset", "(Ljava/lang/String;)Ljava/nio/charset/Charset;", "")]
		public static unsafe global::Java.Nio.Charset.Charset ToCharset (string charset)
		{
			if (id_toCharset_Ljava_lang_String_ == IntPtr.Zero)
				id_toCharset_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toCharset", "(Ljava/lang/String;)Ljava/nio/charset/Charset;");
			IntPtr native_charset = JNIEnv.NewString (charset);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_charset);
				global::Java.Nio.Charset.Charset __ret = global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toCharset_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_charset);
			}
		}

		static IntPtr id_toCharset_Ljava_nio_charset_Charset_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec']/class[@name='Charsets']/method[@name='toCharset' and count(parameter)=1 and parameter[1][@type='java.nio.charset.Charset']]"
		[Register ("toCharset", "(Ljava/nio/charset/Charset;)Ljava/nio/charset/Charset;", "")]
		public static unsafe global::Java.Nio.Charset.Charset ToCharset (global::Java.Nio.Charset.Charset charset)
		{
			if (id_toCharset_Ljava_nio_charset_Charset_ == IntPtr.Zero)
				id_toCharset_Ljava_nio_charset_Charset_ = JNIEnv.GetStaticMethodID (class_ref, "toCharset", "(Ljava/nio/charset/Charset;)Ljava/nio/charset/Charset;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (charset);
				global::Java.Nio.Charset.Charset __ret = global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toCharset_Ljava_nio_charset_Charset_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
