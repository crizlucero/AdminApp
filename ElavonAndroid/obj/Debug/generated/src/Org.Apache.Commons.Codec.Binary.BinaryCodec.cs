using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Binary {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BinaryCodec']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/binary/BinaryCodec", DoNotGenerateAcw=true)]
	public partial class BinaryCodec : global::Java.Lang.Object, global::Org.Apache.Commons.Codec.IBinaryDecoder, global::Org.Apache.Commons.Codec.IBinaryEncoder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/binary/BinaryCodec", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BinaryCodec); }
		}

		protected BinaryCodec (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BinaryCodec']/constructor[@name='BinaryCodec' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BinaryCodec ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BinaryCodec)) {
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

		static Delegate cb_decode_arrayB;
#pragma warning disable 0169
		static Delegate GetDecode_arrayBHandler ()
		{
			if (cb_decode_arrayB == null)
				cb_decode_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_arrayB);
			return cb_decode_arrayB;
		}

		static IntPtr n_Decode_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_ascii)
		{
			global::Org.Apache.Commons.Codec.Binary.BinaryCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Binary.BinaryCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] ascii = (byte[]) JNIEnv.GetArray (native_ascii, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Decode (ascii));
			if (ascii != null)
				JNIEnv.CopyArray (ascii, native_ascii);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BinaryCodec']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decode", "([B)[B", "GetDecode_arrayBHandler")]
		public virtual unsafe byte[] Decode (byte[] ascii)
		{
			if (id_decode_arrayB == IntPtr.Zero)
				id_decode_arrayB = JNIEnv.GetMethodID (class_ref, "decode", "([B)[B");
			IntPtr native_ascii = JNIEnv.NewArray (ascii);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_ascii);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decode_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "([B)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (ascii != null) {
					JNIEnv.CopyArray (native_ascii, ascii);
					JNIEnv.DeleteLocalRef (native_ascii);
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

		static IntPtr n_Decode_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ascii)
		{
			global::Org.Apache.Commons.Codec.Binary.BinaryCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Binary.BinaryCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object ascii = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_ascii, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (ascii));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BinaryCodec']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("decode", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetDecode_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object Decode (global::Java.Lang.Object ascii)
		{
			if (id_decode_Ljava_lang_Object_ == IntPtr.Zero)
				id_decode_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/lang/Object;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ascii);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decode_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
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

		static IntPtr n_Encode_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_raw)
		{
			global::Org.Apache.Commons.Codec.Binary.BinaryCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Binary.BinaryCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] raw = (byte[]) JNIEnv.GetArray (native_raw, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Encode (raw));
			if (raw != null)
				JNIEnv.CopyArray (raw, native_raw);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BinaryCodec']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encode", "([B)[B", "GetEncode_arrayBHandler")]
		public virtual unsafe byte[] Encode (byte[] raw)
		{
			if (id_encode_arrayB == IntPtr.Zero)
				id_encode_arrayB = JNIEnv.GetMethodID (class_ref, "encode", "([B)[B");
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_raw);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "([B)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
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

		static IntPtr n_Encode_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_raw)
		{
			global::Org.Apache.Commons.Codec.Binary.BinaryCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Binary.BinaryCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object raw = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_raw, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Encode (raw));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BinaryCodec']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("encode", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetEncode_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object Encode (global::Java.Lang.Object raw)
		{
			if (id_encode_Ljava_lang_Object_ == IntPtr.Zero)
				id_encode_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/Object;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (raw);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromAscii_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BinaryCodec']/method[@name='fromAscii' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("fromAscii", "([B)[B", "")]
		public static unsafe byte[] FromAscii (byte[] ascii)
		{
			if (id_fromAscii_arrayB == IntPtr.Zero)
				id_fromAscii_arrayB = JNIEnv.GetStaticMethodID (class_ref, "fromAscii", "([B)[B");
			IntPtr native_ascii = JNIEnv.NewArray (ascii);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_ascii);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromAscii_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (ascii != null) {
					JNIEnv.CopyArray (native_ascii, ascii);
					JNIEnv.DeleteLocalRef (native_ascii);
				}
			}
		}

		static IntPtr id_fromAscii_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BinaryCodec']/method[@name='fromAscii' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("fromAscii", "([C)[B", "")]
		public static unsafe byte[] FromAscii (char[] ascii)
		{
			if (id_fromAscii_arrayC == IntPtr.Zero)
				id_fromAscii_arrayC = JNIEnv.GetStaticMethodID (class_ref, "fromAscii", "([C)[B");
			IntPtr native_ascii = JNIEnv.NewArray (ascii);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_ascii);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromAscii_arrayC, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (ascii != null) {
					JNIEnv.CopyArray (native_ascii, ascii);
					JNIEnv.DeleteLocalRef (native_ascii);
				}
			}
		}

		static IntPtr id_toAsciiBytes_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BinaryCodec']/method[@name='toAsciiBytes' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("toAsciiBytes", "([B)[B", "")]
		public static unsafe byte[] ToAsciiBytes (byte[] raw)
		{
			if (id_toAsciiBytes_arrayB == IntPtr.Zero)
				id_toAsciiBytes_arrayB = JNIEnv.GetStaticMethodID (class_ref, "toAsciiBytes", "([B)[B");
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_raw);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toAsciiBytes_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
			}
		}

		static IntPtr id_toAsciiChars_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BinaryCodec']/method[@name='toAsciiChars' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("toAsciiChars", "([B)[C", "")]
		public static unsafe char[] ToAsciiChars (byte[] raw)
		{
			if (id_toAsciiChars_arrayB == IntPtr.Zero)
				id_toAsciiChars_arrayB = JNIEnv.GetStaticMethodID (class_ref, "toAsciiChars", "([B)[C");
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_raw);
				char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toAsciiChars_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
			}
		}

		static IntPtr id_toAsciiString_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BinaryCodec']/method[@name='toAsciiString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("toAsciiString", "([B)Ljava/lang/String;", "")]
		public static unsafe string ToAsciiString (byte[] raw)
		{
			if (id_toAsciiString_arrayB == IntPtr.Zero)
				id_toAsciiString_arrayB = JNIEnv.GetStaticMethodID (class_ref, "toAsciiString", "([B)Ljava/lang/String;");
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_raw);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toAsciiString_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
			}
		}

		static Delegate cb_toByteArray_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetToByteArray_Ljava_lang_String_Handler ()
		{
			if (cb_toByteArray_Ljava_lang_String_ == null)
				cb_toByteArray_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToByteArray_Ljava_lang_String_);
			return cb_toByteArray_Ljava_lang_String_;
		}

		static IntPtr n_ToByteArray_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ascii)
		{
			global::Org.Apache.Commons.Codec.Binary.BinaryCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Binary.BinaryCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string ascii = JNIEnv.GetString (native_ascii, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.ToByteArray (ascii));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_toByteArray_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BinaryCodec']/method[@name='toByteArray' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toByteArray", "(Ljava/lang/String;)[B", "GetToByteArray_Ljava_lang_String_Handler")]
		public virtual unsafe byte[] ToByteArray (string ascii)
		{
			if (id_toByteArray_Ljava_lang_String_ == IntPtr.Zero)
				id_toByteArray_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "toByteArray", "(Ljava/lang/String;)[B");
			IntPtr native_ascii = JNIEnv.NewString (ascii);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_ascii);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toByteArray_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toByteArray", "(Ljava/lang/String;)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_ascii);
			}
		}

	}
}
