using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Binary {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='StringUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/binary/StringUtils", DoNotGenerateAcw=true)]
	public partial class StringUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/binary/StringUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StringUtils); }
		}

		protected StringUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='StringUtils']/constructor[@name='StringUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StringUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (StringUtils)) {
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

		static IntPtr id_equals_Ljava_lang_CharSequence_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='StringUtils']/method[@name='equals' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register ("equals", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool Equals (global::Java.Lang.ICharSequence cs1, global::Java.Lang.ICharSequence cs2)
		{
			if (id_equals_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_equals_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "equals", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z");
			IntPtr native_cs1 = CharSequence.ToLocalJniHandle (cs1);
			IntPtr native_cs2 = CharSequence.ToLocalJniHandle (cs2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_cs1);
				__args [1] = new JValue (native_cs2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_equals_Ljava_lang_CharSequence_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs1);
				JNIEnv.DeleteLocalRef (native_cs2);
			}
		}

		public static bool Equals (string cs1, string cs2)
		{
			global::Java.Lang.String jls_cs1 = cs1 == null ? null : new global::Java.Lang.String (cs1);
			global::Java.Lang.String jls_cs2 = cs2 == null ? null : new global::Java.Lang.String (cs2);
			bool __result = Equals (jls_cs1, jls_cs2);
			var __rsval = __result;
			jls_cs1?.Dispose ();
			jls_cs2?.Dispose ();
			return __rsval;
		}

		static IntPtr id_getBytesIso8859_1_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='StringUtils']/method[@name='getBytesIso8859_1' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBytesIso8859_1", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] GetBytesIso8859_1 (string @string)
		{
			if (id_getBytesIso8859_1_Ljava_lang_String_ == IntPtr.Zero)
				id_getBytesIso8859_1_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBytesIso8859_1", "(Ljava/lang/String;)[B");
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__string);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBytesIso8859_1_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		static IntPtr id_getBytesUnchecked_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='StringUtils']/method[@name='getBytesUnchecked' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getBytesUnchecked", "(Ljava/lang/String;Ljava/lang/String;)[B", "")]
		public static unsafe byte[] GetBytesUnchecked (string @string, string charsetName)
		{
			if (id_getBytesUnchecked_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getBytesUnchecked_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBytesUnchecked", "(Ljava/lang/String;Ljava/lang/String;)[B");
			IntPtr native__string = JNIEnv.NewString (@string);
			IntPtr native_charsetName = JNIEnv.NewString (charsetName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native__string);
				__args [1] = new JValue (native_charsetName);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBytesUnchecked_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
				JNIEnv.DeleteLocalRef (native_charsetName);
			}
		}

		static IntPtr id_getBytesUsAscii_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='StringUtils']/method[@name='getBytesUsAscii' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBytesUsAscii", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] GetBytesUsAscii (string @string)
		{
			if (id_getBytesUsAscii_Ljava_lang_String_ == IntPtr.Zero)
				id_getBytesUsAscii_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBytesUsAscii", "(Ljava/lang/String;)[B");
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__string);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBytesUsAscii_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		static IntPtr id_getBytesUtf16_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='StringUtils']/method[@name='getBytesUtf16' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBytesUtf16", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] GetBytesUtf16 (string @string)
		{
			if (id_getBytesUtf16_Ljava_lang_String_ == IntPtr.Zero)
				id_getBytesUtf16_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBytesUtf16", "(Ljava/lang/String;)[B");
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__string);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBytesUtf16_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		static IntPtr id_getBytesUtf16Be_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='StringUtils']/method[@name='getBytesUtf16Be' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBytesUtf16Be", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] GetBytesUtf16Be (string @string)
		{
			if (id_getBytesUtf16Be_Ljava_lang_String_ == IntPtr.Zero)
				id_getBytesUtf16Be_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBytesUtf16Be", "(Ljava/lang/String;)[B");
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__string);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBytesUtf16Be_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		static IntPtr id_getBytesUtf16Le_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='StringUtils']/method[@name='getBytesUtf16Le' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBytesUtf16Le", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] GetBytesUtf16Le (string @string)
		{
			if (id_getBytesUtf16Le_Ljava_lang_String_ == IntPtr.Zero)
				id_getBytesUtf16Le_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBytesUtf16Le", "(Ljava/lang/String;)[B");
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__string);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBytesUtf16Le_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		static IntPtr id_getBytesUtf8_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='StringUtils']/method[@name='getBytesUtf8' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBytesUtf8", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] GetBytesUtf8 (string @string)
		{
			if (id_getBytesUtf8_Ljava_lang_String_ == IntPtr.Zero)
				id_getBytesUtf8_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBytesUtf8", "(Ljava/lang/String;)[B");
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__string);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBytesUtf8_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		static IntPtr id_newString_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='StringUtils']/method[@name='newString' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("newString", "([BLjava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string NewString (byte[] bytes, string charsetName)
		{
			if (id_newString_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_newString_arrayBLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "newString", "([BLjava/lang/String;)Ljava/lang/String;");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			IntPtr native_charsetName = JNIEnv.NewString (charsetName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_bytes);
				__args [1] = new JValue (native_charsetName);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_newString_arrayBLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
				JNIEnv.DeleteLocalRef (native_charsetName);
			}
		}

		static IntPtr id_newStringIso8859_1_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='StringUtils']/method[@name='newStringIso8859_1' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("newStringIso8859_1", "([B)Ljava/lang/String;", "")]
		public static unsafe string NewStringIso8859_1 (byte[] bytes)
		{
			if (id_newStringIso8859_1_arrayB == IntPtr.Zero)
				id_newStringIso8859_1_arrayB = JNIEnv.GetStaticMethodID (class_ref, "newStringIso8859_1", "([B)Ljava/lang/String;");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_bytes);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_newStringIso8859_1_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static IntPtr id_newStringUsAscii_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='StringUtils']/method[@name='newStringUsAscii' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("newStringUsAscii", "([B)Ljava/lang/String;", "")]
		public static unsafe string NewStringUsAscii (byte[] bytes)
		{
			if (id_newStringUsAscii_arrayB == IntPtr.Zero)
				id_newStringUsAscii_arrayB = JNIEnv.GetStaticMethodID (class_ref, "newStringUsAscii", "([B)Ljava/lang/String;");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_bytes);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_newStringUsAscii_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static IntPtr id_newStringUtf16_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='StringUtils']/method[@name='newStringUtf16' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("newStringUtf16", "([B)Ljava/lang/String;", "")]
		public static unsafe string NewStringUtf16 (byte[] bytes)
		{
			if (id_newStringUtf16_arrayB == IntPtr.Zero)
				id_newStringUtf16_arrayB = JNIEnv.GetStaticMethodID (class_ref, "newStringUtf16", "([B)Ljava/lang/String;");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_bytes);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_newStringUtf16_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static IntPtr id_newStringUtf16Be_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='StringUtils']/method[@name='newStringUtf16Be' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("newStringUtf16Be", "([B)Ljava/lang/String;", "")]
		public static unsafe string NewStringUtf16Be (byte[] bytes)
		{
			if (id_newStringUtf16Be_arrayB == IntPtr.Zero)
				id_newStringUtf16Be_arrayB = JNIEnv.GetStaticMethodID (class_ref, "newStringUtf16Be", "([B)Ljava/lang/String;");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_bytes);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_newStringUtf16Be_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static IntPtr id_newStringUtf16Le_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='StringUtils']/method[@name='newStringUtf16Le' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("newStringUtf16Le", "([B)Ljava/lang/String;", "")]
		public static unsafe string NewStringUtf16Le (byte[] bytes)
		{
			if (id_newStringUtf16Le_arrayB == IntPtr.Zero)
				id_newStringUtf16Le_arrayB = JNIEnv.GetStaticMethodID (class_ref, "newStringUtf16Le", "([B)Ljava/lang/String;");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_bytes);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_newStringUtf16Le_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static IntPtr id_newStringUtf8_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='StringUtils']/method[@name='newStringUtf8' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("newStringUtf8", "([B)Ljava/lang/String;", "")]
		public static unsafe string NewStringUtf8 (byte[] bytes)
		{
			if (id_newStringUtf8_arrayB == IntPtr.Zero)
				id_newStringUtf8_arrayB = JNIEnv.GetStaticMethodID (class_ref, "newStringUtf8", "([B)Ljava/lang/String;");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_bytes);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_newStringUtf8_arrayB, __args), JniHandleOwnership.TransferLocalRef);
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
