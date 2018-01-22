using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='BCodec']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/net/BCodec", DoNotGenerateAcw=true)]
	public partial class BCodec : global::Org.Apache.Commons.Codec.Net.RFC1522Codec, global::Org.Apache.Commons.Codec.IStringDecoder, global::Org.Apache.Commons.Codec.IStringEncoder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/net/BCodec", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCodec); }
		}

		protected BCodec (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='BCodec']/constructor[@name='BCodec' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCodec ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCodec)) {
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

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='BCodec']/constructor[@name='BCodec' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe BCodec (string charsetName)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_charsetName = JNIEnv.NewString (charsetName);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_charsetName);
				if (((object) this).GetType () != typeof (BCodec)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_charsetName);
			}
		}

		static IntPtr id_ctor_Ljava_nio_charset_Charset_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='BCodec']/constructor[@name='BCodec' and count(parameter)=1 and parameter[1][@type='java.nio.charset.Charset']]"
		[Register (".ctor", "(Ljava/nio/charset/Charset;)V", "")]
		public unsafe BCodec (global::Java.Nio.Charset.Charset charset)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (charset);
				if (((object) this).GetType () != typeof (BCodec)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/nio/charset/Charset;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/nio/charset/Charset;)V", __args);
					return;
				}

				if (id_ctor_Ljava_nio_charset_Charset_ == IntPtr.Zero)
					id_ctor_Ljava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/charset/Charset;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_charset_Charset_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_nio_charset_Charset_, __args);
			} finally {
			}
		}

		static Delegate cb_getCharset;
#pragma warning disable 0169
		static Delegate GetGetCharsetHandler ()
		{
			if (cb_getCharset == null)
				cb_getCharset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCharset);
			return cb_getCharset;
		}

		static IntPtr n_GetCharset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Commons.Codec.Net.BCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.BCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Charset);
		}
#pragma warning restore 0169

		static IntPtr id_getCharset;
		public virtual unsafe global::Java.Nio.Charset.Charset Charset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='BCodec']/method[@name='getCharset' and count(parameter)=0]"
			[Register ("getCharset", "()Ljava/nio/charset/Charset;", "GetGetCharsetHandler")]
			get {
				if (id_getCharset == IntPtr.Zero)
					id_getCharset = JNIEnv.GetMethodID (class_ref, "getCharset", "()Ljava/nio/charset/Charset;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCharset), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCharset", "()Ljava/nio/charset/Charset;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDefaultCharset;
#pragma warning disable 0169
		static Delegate GetGetDefaultCharsetHandler ()
		{
			if (cb_getDefaultCharset == null)
				cb_getDefaultCharset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultCharset);
			return cb_getDefaultCharset;
		}

		static IntPtr n_GetDefaultCharset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Commons.Codec.Net.BCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.BCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DefaultCharset);
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultCharset;
		public virtual unsafe string DefaultCharset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='BCodec']/method[@name='getDefaultCharset' and count(parameter)=0]"
			[Register ("getDefaultCharset", "()Ljava/lang/String;", "GetGetDefaultCharsetHandler")]
			get {
				if (id_getDefaultCharset == IntPtr.Zero)
					id_getDefaultCharset = JNIEnv.GetMethodID (class_ref, "getDefaultCharset", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultCharset), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultCharset", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

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
			global::Org.Apache.Commons.Codec.Net.BCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.BCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Encoding);
		}
#pragma warning restore 0169

		static IntPtr id_getEncoding;
		protected override unsafe string Encoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='BCodec']/method[@name='getEncoding' and count(parameter)=0]"
			[Register ("getEncoding", "()Ljava/lang/String;", "GetGetEncodingHandler")]
			get {
				if (id_getEncoding == IntPtr.Zero)
					id_getEncoding = JNIEnv.GetMethodID (class_ref, "getEncoding", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEncoding), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEncoding", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_decode_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDecode_Ljava_lang_Object_Handler ()
		{
			if (cb_decode_Ljava_lang_Object_ == null)
				cb_decode_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_Ljava_lang_Object_);
			return cb_decode_Ljava_lang_Object_;
		}

		static IntPtr n_Decode_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Org.Apache.Commons.Codec.Net.BCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.BCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (value));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='BCodec']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("decode", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetDecode_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object Decode (global::Java.Lang.Object value)
		{
			if (id_decode_Ljava_lang_Object_ == IntPtr.Zero)
				id_decode_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/lang/Object;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decode_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_decode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDecode_Ljava_lang_String_Handler ()
		{
			if (cb_decode_Ljava_lang_String_ == null)
				cb_decode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_Ljava_lang_String_);
			return cb_decode_Ljava_lang_String_;
		}

		static IntPtr n_Decode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Org.Apache.Commons.Codec.Net.BCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.BCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Decode (value));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='BCodec']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decode", "(Ljava/lang/String;)Ljava/lang/String;", "GetDecode_Ljava_lang_String_Handler")]
		public virtual unsafe string Decode (string value)
		{
			if (id_decode_Ljava_lang_String_ == IntPtr.Zero)
				id_decode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
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

		static IntPtr n_DoDecoding_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_bytes)
		{
			global::Org.Apache.Commons.Codec.Net.BCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.BCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] bytes = (byte[]) JNIEnv.GetArray (native_bytes, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.DoDecoding (bytes));
			if (bytes != null)
				JNIEnv.CopyArray (bytes, native_bytes);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_doDecoding_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='BCodec']/method[@name='doDecoding' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("doDecoding", "([B)[B", "GetDoDecoding_arrayBHandler")]
		protected override unsafe byte[] DoDecoding (byte[] bytes)
		{
			if (id_doDecoding_arrayB == IntPtr.Zero)
				id_doDecoding_arrayB = JNIEnv.GetMethodID (class_ref, "doDecoding", "([B)[B");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_bytes);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doDecoding_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doDecoding", "([B)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static Delegate cb_doEncoding_arrayB;
#pragma warning disable 0169
		static Delegate GetDoEncoding_arrayBHandler ()
		{
			if (cb_doEncoding_arrayB == null)
				cb_doEncoding_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoEncoding_arrayB);
			return cb_doEncoding_arrayB;
		}

		static IntPtr n_DoEncoding_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_bytes)
		{
			global::Org.Apache.Commons.Codec.Net.BCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.BCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] bytes = (byte[]) JNIEnv.GetArray (native_bytes, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.DoEncoding (bytes));
			if (bytes != null)
				JNIEnv.CopyArray (bytes, native_bytes);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_doEncoding_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='BCodec']/method[@name='doEncoding' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("doEncoding", "([B)[B", "GetDoEncoding_arrayBHandler")]
		protected override unsafe byte[] DoEncoding (byte[] bytes)
		{
			if (id_doEncoding_arrayB == IntPtr.Zero)
				id_doEncoding_arrayB = JNIEnv.GetMethodID (class_ref, "doEncoding", "([B)[B");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_bytes);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doEncoding_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doEncoding", "([B)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static Delegate cb_encode_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_lang_Object_Handler ()
		{
			if (cb_encode_Ljava_lang_Object_ == null)
				cb_encode_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Encode_Ljava_lang_Object_);
			return cb_encode_Ljava_lang_Object_;
		}

		static IntPtr n_Encode_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Org.Apache.Commons.Codec.Net.BCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.BCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Encode (value));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='BCodec']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("encode", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetEncode_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object Encode (global::Java.Lang.Object value)
		{
			if (id_encode_Ljava_lang_Object_ == IntPtr.Zero)
				id_encode_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/Object;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_encode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_lang_String_Handler ()
		{
			if (cb_encode_Ljava_lang_String_ == null)
				cb_encode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Encode_Ljava_lang_String_);
			return cb_encode_Ljava_lang_String_;
		}

		static IntPtr n_Encode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Org.Apache.Commons.Codec.Net.BCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.BCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Encode (value));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='BCodec']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encode", "(Ljava/lang/String;)Ljava/lang/String;", "GetEncode_Ljava_lang_String_Handler")]
		public virtual unsafe string Encode (string value)
		{
			if (id_encode_Ljava_lang_String_ == IntPtr.Zero)
				id_encode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_encode_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_encode_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_encode_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Encode_Ljava_lang_String_Ljava_lang_String_);
			return cb_encode_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Encode_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value, IntPtr native_charset)
		{
			global::Org.Apache.Commons.Codec.Net.BCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.BCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			string charset = JNIEnv.GetString (native_charset, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Encode (value, charset));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='BCodec']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("encode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetEncode_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string Encode (string value, string charset)
		{
			if (id_encode_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_encode_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_value = JNIEnv.NewString (value);
			IntPtr native_charset = JNIEnv.NewString (charset);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_value);
				__args [1] = new JValue (native_charset);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
				JNIEnv.DeleteLocalRef (native_charset);
			}
		}

		static Delegate cb_encode_Ljava_lang_String_Ljava_nio_charset_Charset_;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_lang_String_Ljava_nio_charset_Charset_Handler ()
		{
			if (cb_encode_Ljava_lang_String_Ljava_nio_charset_Charset_ == null)
				cb_encode_Ljava_lang_String_Ljava_nio_charset_Charset_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Encode_Ljava_lang_String_Ljava_nio_charset_Charset_);
			return cb_encode_Ljava_lang_String_Ljava_nio_charset_Charset_;
		}

		static IntPtr n_Encode_Ljava_lang_String_Ljava_nio_charset_Charset_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value, IntPtr native_charset)
		{
			global::Org.Apache.Commons.Codec.Net.BCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.BCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.Charset.Charset charset = global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (native_charset, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Encode (value, charset));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_String_Ljava_nio_charset_Charset_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='BCodec']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.nio.charset.Charset']]"
		[Register ("encode", "(Ljava/lang/String;Ljava/nio/charset/Charset;)Ljava/lang/String;", "GetEncode_Ljava_lang_String_Ljava_nio_charset_Charset_Handler")]
		public virtual unsafe string Encode (string value, global::Java.Nio.Charset.Charset charset)
		{
			if (id_encode_Ljava_lang_String_Ljava_nio_charset_Charset_ == IntPtr.Zero)
				id_encode_Ljava_lang_String_Ljava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/String;Ljava/nio/charset/Charset;)Ljava/lang/String;");
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_value);
				__args [1] = new JValue (charset);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_lang_String_Ljava_nio_charset_Charset_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/lang/String;Ljava/nio/charset/Charset;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
