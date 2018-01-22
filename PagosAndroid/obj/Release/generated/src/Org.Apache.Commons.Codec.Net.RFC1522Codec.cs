using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='RFC1522Codec']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/net/RFC1522Codec", DoNotGenerateAcw=true)]
	public abstract partial class RFC1522Codec : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='RFC1522Codec']/field[@name='POSTFIX']"
		[Register ("POSTFIX")]
		protected const string Postfix = (string) "?=";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='RFC1522Codec']/field[@name='PREFIX']"
		[Register ("PREFIX")]
		protected const string Prefix = (string) "=?";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='RFC1522Codec']/field[@name='SEP']"
		[Register ("SEP")]
		protected const char Sep = (char) (char)63;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/net/RFC1522Codec", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RFC1522Codec); }
		}

		protected RFC1522Codec (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getEncoding;
#pragma warning disable 0169
		static Delegate GetGetEncodingHandler ()
		{
			if (cb_getEncoding == null)
				cb_getEncoding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEncoding);
			return cb_getEncoding;
		}

		static IntPtr n_GetEncoding (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Commons.Codec.Net.RFC1522Codec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.RFC1522Codec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Encoding);
		}
#pragma warning restore 0169

		protected abstract string Encoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='RFC1522Codec']/method[@name='getEncoding' and count(parameter)=0]"
			[Register ("getEncoding", "()Ljava/lang/String;", "GetGetEncodingHandler")] get;
		}

		static Delegate cb_decodeText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDecodeText_Ljava_lang_String_Handler ()
		{
			if (cb_decodeText_Ljava_lang_String_ == null)
				cb_decodeText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DecodeText_Ljava_lang_String_);
			return cb_decodeText_Ljava_lang_String_;
		}

		static IntPtr n_DecodeText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			global::Org.Apache.Commons.Codec.Net.RFC1522Codec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.RFC1522Codec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.DecodeText (text));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decodeText_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='RFC1522Codec']/method[@name='decodeText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeText", "(Ljava/lang/String;)Ljava/lang/String;", "GetDecodeText_Ljava_lang_String_Handler")]
		protected virtual unsafe string DecodeText (string text)
		{
			if (id_decodeText_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "decodeText", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_text);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decodeText_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeText", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		static Delegate cb_doDecoding_arrayB;
#pragma warning disable 0169
		static Delegate GetDoDecoding_arrayBHandler ()
		{
			if (cb_doDecoding_arrayB == null)
				cb_doDecoding_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoDecoding_arrayB);
			return cb_doDecoding_arrayB;
		}

		static IntPtr n_DoDecoding_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Commons.Codec.Net.RFC1522Codec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.RFC1522Codec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.DoDecoding (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='RFC1522Codec']/method[@name='doDecoding' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("doDecoding", "([B)[B", "GetDoDecoding_arrayBHandler")]
		protected abstract byte[] DoDecoding (byte[] p0);

		static Delegate cb_doEncoding_arrayB;
#pragma warning disable 0169
		static Delegate GetDoEncoding_arrayBHandler ()
		{
			if (cb_doEncoding_arrayB == null)
				cb_doEncoding_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoEncoding_arrayB);
			return cb_doEncoding_arrayB;
		}

		static IntPtr n_DoEncoding_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Commons.Codec.Net.RFC1522Codec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.RFC1522Codec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.DoEncoding (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='RFC1522Codec']/method[@name='doEncoding' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("doEncoding", "([B)[B", "GetDoEncoding_arrayBHandler")]
		protected abstract byte[] DoEncoding (byte[] p0);

		static Delegate cb_encodeText_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEncodeText_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_encodeText_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_encodeText_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_EncodeText_Ljava_lang_String_Ljava_lang_String_);
			return cb_encodeText_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_EncodeText_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text, IntPtr native_charsetName)
		{
			global::Org.Apache.Commons.Codec.Net.RFC1522Codec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.RFC1522Codec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			string charsetName = JNIEnv.GetString (native_charsetName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.EncodeText (text, charsetName));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encodeText_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='RFC1522Codec']/method[@name='encodeText' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("encodeText", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetEncodeText_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe string EncodeText (string text, string charsetName)
		{
			if (id_encodeText_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_encodeText_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "encodeText", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_text = JNIEnv.NewString (text);
			IntPtr native_charsetName = JNIEnv.NewString (charsetName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_text);
				__args [1] = new JValue (native_charsetName);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodeText_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeText", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				JNIEnv.DeleteLocalRef (native_charsetName);
			}
		}

		static Delegate cb_encodeText_Ljava_lang_String_Ljava_nio_charset_Charset_;
#pragma warning disable 0169
		static Delegate GetEncodeText_Ljava_lang_String_Ljava_nio_charset_Charset_Handler ()
		{
			if (cb_encodeText_Ljava_lang_String_Ljava_nio_charset_Charset_ == null)
				cb_encodeText_Ljava_lang_String_Ljava_nio_charset_Charset_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_EncodeText_Ljava_lang_String_Ljava_nio_charset_Charset_);
			return cb_encodeText_Ljava_lang_String_Ljava_nio_charset_Charset_;
		}

		static IntPtr n_EncodeText_Ljava_lang_String_Ljava_nio_charset_Charset_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text, IntPtr native_charset)
		{
			global::Org.Apache.Commons.Codec.Net.RFC1522Codec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.RFC1522Codec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.Charset.Charset charset = global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (native_charset, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.EncodeText (text, charset));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encodeText_Ljava_lang_String_Ljava_nio_charset_Charset_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='RFC1522Codec']/method[@name='encodeText' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.nio.charset.Charset']]"
		[Register ("encodeText", "(Ljava/lang/String;Ljava/nio/charset/Charset;)Ljava/lang/String;", "GetEncodeText_Ljava_lang_String_Ljava_nio_charset_Charset_Handler")]
		protected virtual unsafe string EncodeText (string text, global::Java.Nio.Charset.Charset charset)
		{
			if (id_encodeText_Ljava_lang_String_Ljava_nio_charset_Charset_ == IntPtr.Zero)
				id_encodeText_Ljava_lang_String_Ljava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "encodeText", "(Ljava/lang/String;Ljava/nio/charset/Charset;)Ljava/lang/String;");
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_text);
				__args [1] = new JValue (charset);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodeText_Ljava_lang_String_Ljava_nio_charset_Charset_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeText", "(Ljava/lang/String;Ljava/nio/charset/Charset;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

	}

	[global::Android.Runtime.Register ("org/apache/commons/codec/net/RFC1522Codec", DoNotGenerateAcw=true)]
	internal partial class RFC1522CodecInvoker : RFC1522Codec {

		public RFC1522CodecInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (RFC1522CodecInvoker); }
		}

		static IntPtr id_getEncoding;
		protected override unsafe string Encoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='RFC1522Codec']/method[@name='getEncoding' and count(parameter)=0]"
			[Register ("getEncoding", "()Ljava/lang/String;", "GetGetEncodingHandler")]
			get {
				if (id_getEncoding == IntPtr.Zero)
					id_getEncoding = JNIEnv.GetMethodID (class_ref, "getEncoding", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEncoding), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_doDecoding_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='RFC1522Codec']/method[@name='doDecoding' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("doDecoding", "([B)[B", "GetDoDecoding_arrayBHandler")]
		protected override unsafe byte[] DoDecoding (byte[] p0)
		{
			if (id_doDecoding_arrayB == IntPtr.Zero)
				id_doDecoding_arrayB = JNIEnv.GetMethodID (class_ref, "doDecoding", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doDecoding_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_doEncoding_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='RFC1522Codec']/method[@name='doEncoding' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("doEncoding", "([B)[B", "GetDoEncoding_arrayBHandler")]
		protected override unsafe byte[] DoEncoding (byte[] p0)
		{
			if (id_doEncoding_arrayB == IntPtr.Zero)
				id_doEncoding_arrayB = JNIEnv.GetMethodID (class_ref, "doEncoding", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doEncoding_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}

}
