using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Binary {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Hex']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/binary/Hex", DoNotGenerateAcw=true)]
	public partial class Hex : global::Java.Lang.Object, global::Org.Apache.Commons.Codec.IBinaryDecoder, global::Org.Apache.Commons.Codec.IBinaryEncoder {


		static IntPtr DEFAULT_CHARSET_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Hex']/field[@name='DEFAULT_CHARSET']"
		[Register ("DEFAULT_CHARSET")]
		public static global::Java.Nio.Charset.Charset DefaultCharset {
			get {
				if (DEFAULT_CHARSET_jfieldId == IntPtr.Zero)
					DEFAULT_CHARSET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_CHARSET", "Ljava/nio/charset/Charset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_CHARSET_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Hex']/field[@name='DEFAULT_CHARSET_NAME']"
		[Register ("DEFAULT_CHARSET_NAME")]
		public const string DefaultCharsetName = (string) "UTF-8";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/binary/Hex", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Hex); }
		}

		protected Hex (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Hex']/constructor[@name='Hex' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Hex ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Hex)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Hex']/constructor[@name='Hex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe Hex (string charsetName)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_charsetName = JNIEnv.NewString (charsetName);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_charsetName);
				if (((object) this).GetType () != typeof (Hex)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Hex']/constructor[@name='Hex' and count(parameter)=1 and parameter[1][@type='java.nio.charset.Charset']]"
		[Register (".ctor", "(Ljava/nio/charset/Charset;)V", "")]
		public unsafe Hex (global::Java.Nio.Charset.Charset charset)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (charset);
				if (((object) this).GetType () != typeof (Hex)) {
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
			global::Org.Apache.Commons.Codec.Binary.Hex __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Binary.Hex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Charset);
		}
#pragma warning restore 0169

		static IntPtr id_getCharset;
		public virtual unsafe global::Java.Nio.Charset.Charset Charset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Hex']/method[@name='getCharset' and count(parameter)=0]"
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

		static Delegate cb_getCharsetName;
#pragma warning disable 0169
		static Delegate GetGetCharsetNameHandler ()
		{
			if (cb_getCharsetName == null)
				cb_getCharsetName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCharsetName);
			return cb_getCharsetName;
		}

		static IntPtr n_GetCharsetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Commons.Codec.Binary.Hex __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Binary.Hex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CharsetName);
		}
#pragma warning restore 0169

		static IntPtr id_getCharsetName;
		public virtual unsafe string CharsetName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Hex']/method[@name='getCharsetName' and count(parameter)=0]"
			[Register ("getCharsetName", "()Ljava/lang/String;", "GetGetCharsetNameHandler")]
			get {
				if (id_getCharsetName == IntPtr.Zero)
					id_getCharsetName = JNIEnv.GetMethodID (class_ref, "getCharsetName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCharsetName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCharsetName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr n_Decode_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_array)
		{
			global::Org.Apache.Commons.Codec.Binary.Hex __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Binary.Hex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] array = (byte[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Decode (array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Hex']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decode", "([B)[B", "GetDecode_arrayBHandler")]
		public virtual unsafe byte[] Decode (byte[] array)
		{
			if (id_decode_arrayB == IntPtr.Zero)
				id_decode_arrayB = JNIEnv.GetMethodID (class_ref, "decode", "([B)[B");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decode_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "([B)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
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

		static IntPtr n_Decode_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native__object)
		{
			global::Org.Apache.Commons.Codec.Binary.Hex __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Binary.Hex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object @object = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native__object, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (@object));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Hex']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("decode", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetDecode_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object Decode (global::Java.Lang.Object @object)
		{
			if (id_decode_Ljava_lang_Object_ == IntPtr.Zero)
				id_decode_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/lang/Object;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@object);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decode_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_decodeHex_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Hex']/method[@name='decodeHex' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("decodeHex", "([C)[B", "")]
		public static unsafe byte[] DecodeHex (char[] data)
		{
			if (id_decodeHex_arrayC == IntPtr.Zero)
				id_decodeHex_arrayC = JNIEnv.GetStaticMethodID (class_ref, "decodeHex", "([C)[B");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeHex_arrayC, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
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

		static IntPtr n_Encode_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_array)
		{
			global::Org.Apache.Commons.Codec.Binary.Hex __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Binary.Hex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] array = (byte[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Encode (array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Hex']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encode", "([B)[B", "GetEncode_arrayBHandler")]
		public virtual unsafe byte[] Encode (byte[] array)
		{
			if (id_encode_arrayB == IntPtr.Zero)
				id_encode_arrayB = JNIEnv.GetMethodID (class_ref, "encode", "([B)[B");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "([B)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
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

		static IntPtr n_Encode_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native__object)
		{
			global::Org.Apache.Commons.Codec.Binary.Hex __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Binary.Hex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object @object = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native__object, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Encode (@object));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Hex']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("encode", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetEncode_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object Encode (global::Java.Lang.Object @object)
		{
			if (id_encode_Ljava_lang_Object_ == IntPtr.Zero)
				id_encode_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/Object;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@object);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_encodeHex_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Hex']/method[@name='encodeHex' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeHex", "([B)[C", "")]
		public static unsafe char[] EncodeHex (byte[] data)
		{
			if (id_encodeHex_arrayB == IntPtr.Zero)
				id_encodeHex_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encodeHex", "([B)[C");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeHex_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static IntPtr id_encodeHex_arrayBZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Hex']/method[@name='encodeHex' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='boolean']]"
		[Register ("encodeHex", "([BZ)[C", "")]
		public static unsafe char[] EncodeHex (byte[] data, bool toLowerCase)
		{
			if (id_encodeHex_arrayBZ == IntPtr.Zero)
				id_encodeHex_arrayBZ = JNIEnv.GetStaticMethodID (class_ref, "encodeHex", "([BZ)[C");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_data);
				__args [1] = new JValue (toLowerCase);
				char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeHex_arrayBZ, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static IntPtr id_encodeHex_arrayBarrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Hex']/method[@name='encodeHex' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='char[]']]"
		[Register ("encodeHex", "([B[C)[C", "")]
		protected static unsafe char[] EncodeHex (byte[] data, char[] toDigits)
		{
			if (id_encodeHex_arrayBarrayC == IntPtr.Zero)
				id_encodeHex_arrayBarrayC = JNIEnv.GetStaticMethodID (class_ref, "encodeHex", "([B[C)[C");
			IntPtr native_data = JNIEnv.NewArray (data);
			IntPtr native_toDigits = JNIEnv.NewArray (toDigits);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_data);
				__args [1] = new JValue (native_toDigits);
				char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeHex_arrayBarrayC, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				if (toDigits != null) {
					JNIEnv.CopyArray (native_toDigits, toDigits);
					JNIEnv.DeleteLocalRef (native_toDigits);
				}
			}
		}

		static IntPtr id_encodeHexString_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Hex']/method[@name='encodeHexString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeHexString", "([B)Ljava/lang/String;", "")]
		public static unsafe string EncodeHexString (byte[] data)
		{
			if (id_encodeHexString_arrayB == IntPtr.Zero)
				id_encodeHexString_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encodeHexString", "([B)Ljava/lang/String;");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeHexString_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static IntPtr id_toDigit_CI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Hex']/method[@name='toDigit' and count(parameter)=2 and parameter[1][@type='char'] and parameter[2][@type='int']]"
		[Register ("toDigit", "(CI)I", "")]
		protected static unsafe int ToDigit (char ch, int index)
		{
			if (id_toDigit_CI == IntPtr.Zero)
				id_toDigit_CI = JNIEnv.GetStaticMethodID (class_ref, "toDigit", "(CI)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (ch);
				__args [1] = new JValue (index);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_toDigit_CI, __args);
			} finally {
			}
		}

	}
}
