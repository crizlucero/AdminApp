using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='QuotedPrintableCodec']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/net/QuotedPrintableCodec", DoNotGenerateAcw=true)]
	public partial class QuotedPrintableCodec : global::Java.Lang.Object, global::Org.Apache.Commons.Codec.IBinaryDecoder, global::Org.Apache.Commons.Codec.IBinaryEncoder, global::Org.Apache.Commons.Codec.IStringDecoder, global::Org.Apache.Commons.Codec.IStringEncoder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/net/QuotedPrintableCodec", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QuotedPrintableCodec); }
		}

		protected QuotedPrintableCodec (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='QuotedPrintableCodec']/constructor[@name='QuotedPrintableCodec' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QuotedPrintableCodec ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (QuotedPrintableCodec)) {
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

		static IntPtr id_ctor_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='QuotedPrintableCodec']/constructor[@name='QuotedPrintableCodec' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register (".ctor", "(Z)V", "")]
		public unsafe QuotedPrintableCodec (bool strict)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (strict);
				if (((object) this).GetType () != typeof (QuotedPrintableCodec)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Z)V", __args);
					return;
				}

				if (id_ctor_Z == IntPtr.Zero)
					id_ctor_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Z, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='QuotedPrintableCodec']/constructor[@name='QuotedPrintableCodec' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe QuotedPrintableCodec (string charsetName)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_charsetName = JNIEnv.NewString (charsetName);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_charsetName);
				if (((object) this).GetType () != typeof (QuotedPrintableCodec)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='QuotedPrintableCodec']/constructor[@name='QuotedPrintableCodec' and count(parameter)=1 and parameter[1][@type='java.nio.charset.Charset']]"
		[Register (".ctor", "(Ljava/nio/charset/Charset;)V", "")]
		public unsafe QuotedPrintableCodec (global::Java.Nio.Charset.Charset charset)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (charset);
				if (((object) this).GetType () != typeof (QuotedPrintableCodec)) {
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

		static IntPtr id_ctor_Ljava_nio_charset_Charset_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='QuotedPrintableCodec']/constructor[@name='QuotedPrintableCodec' and count(parameter)=2 and parameter[1][@type='java.nio.charset.Charset'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/nio/charset/Charset;Z)V", "")]
		public unsafe QuotedPrintableCodec (global::Java.Nio.Charset.Charset charset, bool strict)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (charset);
				__args [1] = new JValue (strict);
				if (((object) this).GetType () != typeof (QuotedPrintableCodec)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/nio/charset/Charset;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/nio/charset/Charset;Z)V", __args);
					return;
				}

				if (id_ctor_Ljava_nio_charset_Charset_Z == IntPtr.Zero)
					id_ctor_Ljava_nio_charset_Charset_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/charset/Charset;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_charset_Charset_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_nio_charset_Charset_Z, __args);
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
			global::Org.Apache.Commons.Codec.Net.QuotedPrintableCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.QuotedPrintableCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Charset);
		}
#pragma warning restore 0169

		static IntPtr id_getCharset;
		public virtual unsafe global::Java.Nio.Charset.Charset Charset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='QuotedPrintableCodec']/method[@name='getCharset' and count(parameter)=0]"
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
			global::Org.Apache.Commons.Codec.Net.QuotedPrintableCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.QuotedPrintableCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DefaultCharset);
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultCharset;
		public virtual unsafe string DefaultCharset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='QuotedPrintableCodec']/method[@name='getDefaultCharset' and count(parameter)=0]"
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

		static Delegate cb_decode_arrayB;
#pragma warning disable 0169
		static Delegate GetDecode_arrayBHandler ()
		{
			if (cb_decode_arrayB == null)
				cb_decode_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_arrayB);
			return cb_decode_arrayB;
		}

		static IntPtr n_Decode_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_bytes)
		{
			global::Org.Apache.Commons.Codec.Net.QuotedPrintableCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.QuotedPrintableCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] bytes = (byte[]) JNIEnv.GetArray (native_bytes, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Decode (bytes));
			if (bytes != null)
				JNIEnv.CopyArray (bytes, native_bytes);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='QuotedPrintableCodec']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decode", "([B)[B", "GetDecode_arrayBHandler")]
		public virtual unsafe byte[] Decode (byte[] bytes)
		{
			if (id_decode_arrayB == IntPtr.Zero)
				id_decode_arrayB = JNIEnv.GetMethodID (class_ref, "decode", "([B)[B");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_bytes);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decode_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "([B)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
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

		static IntPtr n_Decode_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			global::Org.Apache.Commons.Codec.Net.QuotedPrintableCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.QuotedPrintableCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (obj));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='QuotedPrintableCodec']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("decode", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetDecode_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object Decode (global::Java.Lang.Object obj)
		{
			if (id_decode_Ljava_lang_Object_ == IntPtr.Zero)
				id_decode_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/lang/Object;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);

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

		static IntPtr n_Decode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str)
		{
			global::Org.Apache.Commons.Codec.Net.QuotedPrintableCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.QuotedPrintableCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Decode (str));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='QuotedPrintableCodec']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decode", "(Ljava/lang/String;)Ljava/lang/String;", "GetDecode_Ljava_lang_String_Handler")]
		public virtual unsafe string Decode (string str)
		{
			if (id_decode_Ljava_lang_String_ == IntPtr.Zero)
				id_decode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static Delegate cb_decode_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDecode_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_decode_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_decode_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_Ljava_lang_String_Ljava_lang_String_);
			return cb_decode_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Decode_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str, IntPtr native_charset)
		{
			global::Org.Apache.Commons.Codec.Net.QuotedPrintableCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.QuotedPrintableCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			string charset = JNIEnv.GetString (native_charset, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Decode (str, charset));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='QuotedPrintableCodec']/method[@name='decode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("decode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetDecode_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string Decode (string str, string charset)
		{
			if (id_decode_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_decode_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_charset = JNIEnv.NewString (charset);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_charset);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decode_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_charset);
			}
		}

		static Delegate cb_decode_Ljava_lang_String_Ljava_nio_charset_Charset_;
#pragma warning disable 0169
		static Delegate GetDecode_Ljava_lang_String_Ljava_nio_charset_Charset_Handler ()
		{
			if (cb_decode_Ljava_lang_String_Ljava_nio_charset_Charset_ == null)
				cb_decode_Ljava_lang_String_Ljava_nio_charset_Charset_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_Ljava_lang_String_Ljava_nio_charset_Charset_);
			return cb_decode_Ljava_lang_String_Ljava_nio_charset_Charset_;
		}

		static IntPtr n_Decode_Ljava_lang_String_Ljava_nio_charset_Charset_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str, IntPtr native_charset)
		{
			global::Org.Apache.Commons.Codec.Net.QuotedPrintableCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.QuotedPrintableCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.Charset.Charset charset = global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (native_charset, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Decode (str, charset));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Ljava_lang_String_Ljava_nio_charset_Charset_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='QuotedPrintableCodec']/method[@name='decode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.nio.charset.Charset']]"
		[Register ("decode", "(Ljava/lang/String;Ljava/nio/charset/Charset;)Ljava/lang/String;", "GetDecode_Ljava_lang_String_Ljava_nio_charset_Charset_Handler")]
		public virtual unsafe string Decode (string str, global::Java.Nio.Charset.Charset charset)
		{
			if (id_decode_Ljava_lang_String_Ljava_nio_charset_Charset_ == IntPtr.Zero)
				id_decode_Ljava_lang_String_Ljava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/lang/String;Ljava/nio/charset/Charset;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (charset);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decode_Ljava_lang_String_Ljava_nio_charset_Charset_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Ljava/lang/String;Ljava/nio/charset/Charset;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_decodeQuotedPrintable_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='QuotedPrintableCodec']/method[@name='decodeQuotedPrintable' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decodeQuotedPrintable", "([B)[B", "")]
		public static unsafe byte[] DecodeQuotedPrintable (byte[] bytes)
		{
			if (id_decodeQuotedPrintable_arrayB == IntPtr.Zero)
				id_decodeQuotedPrintable_arrayB = JNIEnv.GetStaticMethodID (class_ref, "decodeQuotedPrintable", "([B)[B");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_bytes);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeQuotedPrintable_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static Delegate cb_encode_arrayB;
#pragma warning disable 0169
		static Delegate GetEncode_arrayBHandler ()
		{
			if (cb_encode_arrayB == null)
				cb_encode_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Encode_arrayB);
			return cb_encode_arrayB;
		}

		static IntPtr n_Encode_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_bytes)
		{
			global::Org.Apache.Commons.Codec.Net.QuotedPrintableCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.QuotedPrintableCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] bytes = (byte[]) JNIEnv.GetArray (native_bytes, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Encode (bytes));
			if (bytes != null)
				JNIEnv.CopyArray (bytes, native_bytes);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='QuotedPrintableCodec']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encode", "([B)[B", "GetEncode_arrayBHandler")]
		public virtual unsafe byte[] Encode (byte[] bytes)
		{
			if (id_encode_arrayB == IntPtr.Zero)
				id_encode_arrayB = JNIEnv.GetMethodID (class_ref, "encode", "([B)[B");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_bytes);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "([B)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
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

		static IntPtr n_Encode_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			global::Org.Apache.Commons.Codec.Net.QuotedPrintableCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.QuotedPrintableCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Encode (obj));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='QuotedPrintableCodec']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("encode", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetEncode_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object Encode (global::Java.Lang.Object obj)
		{
			if (id_encode_Ljava_lang_Object_ == IntPtr.Zero)
				id_encode_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/Object;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);

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

		static IntPtr n_Encode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str)
		{
			global::Org.Apache.Commons.Codec.Net.QuotedPrintableCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.QuotedPrintableCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Encode (str));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='QuotedPrintableCodec']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encode", "(Ljava/lang/String;)Ljava/lang/String;", "GetEncode_Ljava_lang_String_Handler")]
		public virtual unsafe string Encode (string str)
		{
			if (id_encode_Ljava_lang_String_ == IntPtr.Zero)
				id_encode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
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

		static IntPtr n_Encode_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str, IntPtr native_charset)
		{
			global::Org.Apache.Commons.Codec.Net.QuotedPrintableCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.QuotedPrintableCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			string charset = JNIEnv.GetString (native_charset, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Encode (str, charset));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='QuotedPrintableCodec']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("encode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetEncode_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string Encode (string str, string charset)
		{
			if (id_encode_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_encode_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_charset = JNIEnv.NewString (charset);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_charset);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
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

		static IntPtr n_Encode_Ljava_lang_String_Ljava_nio_charset_Charset_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str, IntPtr native_charset)
		{
			global::Org.Apache.Commons.Codec.Net.QuotedPrintableCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Net.QuotedPrintableCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.Charset.Charset charset = global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (native_charset, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Encode (str, charset));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_String_Ljava_nio_charset_Charset_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='QuotedPrintableCodec']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.nio.charset.Charset']]"
		[Register ("encode", "(Ljava/lang/String;Ljava/nio/charset/Charset;)Ljava/lang/String;", "GetEncode_Ljava_lang_String_Ljava_nio_charset_Charset_Handler")]
		public virtual unsafe string Encode (string str, global::Java.Nio.Charset.Charset charset)
		{
			if (id_encode_Ljava_lang_String_Ljava_nio_charset_Charset_ == IntPtr.Zero)
				id_encode_Ljava_lang_String_Ljava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/String;Ljava/nio/charset/Charset;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (charset);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_lang_String_Ljava_nio_charset_Charset_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/lang/String;Ljava/nio/charset/Charset;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_encodeQuotedPrintable_Ljava_util_BitSet_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='QuotedPrintableCodec']/method[@name='encodeQuotedPrintable' and count(parameter)=2 and parameter[1][@type='java.util.BitSet'] and parameter[2][@type='byte[]']]"
		[Register ("encodeQuotedPrintable", "(Ljava/util/BitSet;[B)[B", "")]
		public static unsafe byte[] EncodeQuotedPrintable (global::Java.Util.BitSet printable, byte[] bytes)
		{
			if (id_encodeQuotedPrintable_Ljava_util_BitSet_arrayB == IntPtr.Zero)
				id_encodeQuotedPrintable_Ljava_util_BitSet_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encodeQuotedPrintable", "(Ljava/util/BitSet;[B)[B");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (printable);
				__args [1] = new JValue (native_bytes);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeQuotedPrintable_Ljava_util_BitSet_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static IntPtr id_encodeQuotedPrintable_Ljava_util_BitSet_arrayBZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.net']/class[@name='QuotedPrintableCodec']/method[@name='encodeQuotedPrintable' and count(parameter)=3 and parameter[1][@type='java.util.BitSet'] and parameter[2][@type='byte[]'] and parameter[3][@type='boolean']]"
		[Register ("encodeQuotedPrintable", "(Ljava/util/BitSet;[BZ)[B", "")]
		public static unsafe byte[] EncodeQuotedPrintable (global::Java.Util.BitSet printable, byte[] bytes, bool strict)
		{
			if (id_encodeQuotedPrintable_Ljava_util_BitSet_arrayBZ == IntPtr.Zero)
				id_encodeQuotedPrintable_Ljava_util_BitSet_arrayBZ = JNIEnv.GetStaticMethodID (class_ref, "encodeQuotedPrintable", "(Ljava/util/BitSet;[BZ)[B");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (printable);
				__args [1] = new JValue (native_bytes);
				__args [2] = new JValue (strict);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeQuotedPrintable_Ljava_util_BitSet_arrayBZ, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

	}
}
