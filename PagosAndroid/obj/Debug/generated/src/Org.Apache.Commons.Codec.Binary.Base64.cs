using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Binary {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/binary/Base64", DoNotGenerateAcw=true)]
	public partial class Base64 : global::Org.Apache.Commons.Codec.Binary.BaseNCodec {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/binary/Base64", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Base64); }
		}

		protected Base64 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64']/constructor[@name='Base64' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Base64 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Base64)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64']/constructor[@name='Base64' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register (".ctor", "(Z)V", "")]
		public unsafe Base64 (bool urlSafe)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (urlSafe);
				if (((object) this).GetType () != typeof (Base64)) {
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

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64']/constructor[@name='Base64' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe Base64 (int lineLength)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (lineLength);
				if (((object) this).GetType () != typeof (Base64)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_IarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64']/constructor[@name='Base64' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(I[B)V", "")]
		public unsafe Base64 (int lineLength, byte[] lineSeparator)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_lineSeparator = JNIEnv.NewArray (lineSeparator);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (lineLength);
				__args [1] = new JValue (native_lineSeparator);
				if (((object) this).GetType () != typeof (Base64)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I[B)V", __args);
					return;
				}

				if (id_ctor_IarrayB == IntPtr.Zero)
					id_ctor_IarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(I[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IarrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IarrayB, __args);
			} finally {
				if (lineSeparator != null) {
					JNIEnv.CopyArray (native_lineSeparator, lineSeparator);
					JNIEnv.DeleteLocalRef (native_lineSeparator);
				}
			}
		}

		static IntPtr id_ctor_IarrayBZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64']/constructor[@name='Base64' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(I[BZ)V", "")]
		public unsafe Base64 (int lineLength, byte[] lineSeparator, bool urlSafe)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_lineSeparator = JNIEnv.NewArray (lineSeparator);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (lineLength);
				__args [1] = new JValue (native_lineSeparator);
				__args [2] = new JValue (urlSafe);
				if (((object) this).GetType () != typeof (Base64)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I[BZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I[BZ)V", __args);
					return;
				}

				if (id_ctor_IarrayBZ == IntPtr.Zero)
					id_ctor_IarrayBZ = JNIEnv.GetMethodID (class_ref, "<init>", "(I[BZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IarrayBZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IarrayBZ, __args);
			} finally {
				if (lineSeparator != null) {
					JNIEnv.CopyArray (native_lineSeparator, lineSeparator);
					JNIEnv.DeleteLocalRef (native_lineSeparator);
				}
			}
		}

		static Delegate cb_isUrlSafe;
#pragma warning disable 0169
		static Delegate GetIsUrlSafeHandler ()
		{
			if (cb_isUrlSafe == null)
				cb_isUrlSafe = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUrlSafe);
			return cb_isUrlSafe;
		}

		static bool n_IsUrlSafe (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Commons.Codec.Binary.Base64 __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Binary.Base64> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUrlSafe;
		}
#pragma warning restore 0169

		static IntPtr id_isUrlSafe;
		public virtual unsafe bool IsUrlSafe {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64']/method[@name='isUrlSafe' and count(parameter)=0]"
			[Register ("isUrlSafe", "()Z", "GetIsUrlSafeHandler")]
			get {
				if (id_isUrlSafe == IntPtr.Zero)
					id_isUrlSafe = JNIEnv.GetMethodID (class_ref, "isUrlSafe", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUrlSafe);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUrlSafe", "()Z"));
				} finally {
				}
			}
		}

		static IntPtr id_decodeBase64_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64']/method[@name='decodeBase64' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decodeBase64", "([B)[B", "")]
		public static unsafe byte[] DecodeBase64 (byte[] base64Data)
		{
			if (id_decodeBase64_arrayB == IntPtr.Zero)
				id_decodeBase64_arrayB = JNIEnv.GetStaticMethodID (class_ref, "decodeBase64", "([B)[B");
			IntPtr native_base64Data = JNIEnv.NewArray (base64Data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_base64Data);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeBase64_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (base64Data != null) {
					JNIEnv.CopyArray (native_base64Data, base64Data);
					JNIEnv.DeleteLocalRef (native_base64Data);
				}
			}
		}

		static IntPtr id_decodeBase64_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64']/method[@name='decodeBase64' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeBase64", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] DecodeBase64 (string base64String)
		{
			if (id_decodeBase64_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeBase64_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeBase64", "(Ljava/lang/String;)[B");
			IntPtr native_base64String = JNIEnv.NewString (base64String);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_base64String);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeBase64_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_base64String);
			}
		}

		static IntPtr id_decodeInteger_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64']/method[@name='decodeInteger' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decodeInteger", "([B)Ljava/math/BigInteger;", "")]
		public static unsafe global::Java.Math.BigInteger DecodeInteger (byte[] pArray)
		{
			if (id_decodeInteger_arrayB == IntPtr.Zero)
				id_decodeInteger_arrayB = JNIEnv.GetStaticMethodID (class_ref, "decodeInteger", "([B)Ljava/math/BigInteger;");
			IntPtr native_pArray = JNIEnv.NewArray (pArray);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_pArray);
				global::Java.Math.BigInteger __ret = global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeInteger_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (pArray != null) {
					JNIEnv.CopyArray (native_pArray, pArray);
					JNIEnv.DeleteLocalRef (native_pArray);
				}
			}
		}

		static IntPtr id_encodeBase64_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64']/method[@name='encodeBase64' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeBase64", "([B)[B", "")]
		public static unsafe byte[] EncodeBase64 (byte[] binaryData)
		{
			if (id_encodeBase64_arrayB == IntPtr.Zero)
				id_encodeBase64_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encodeBase64", "([B)[B");
			IntPtr native_binaryData = JNIEnv.NewArray (binaryData);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_binaryData);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBase64_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (binaryData != null) {
					JNIEnv.CopyArray (native_binaryData, binaryData);
					JNIEnv.DeleteLocalRef (native_binaryData);
				}
			}
		}

		static IntPtr id_encodeBase64_arrayBZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64']/method[@name='encodeBase64' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='boolean']]"
		[Register ("encodeBase64", "([BZ)[B", "")]
		public static unsafe byte[] EncodeBase64 (byte[] binaryData, bool isChunked)
		{
			if (id_encodeBase64_arrayBZ == IntPtr.Zero)
				id_encodeBase64_arrayBZ = JNIEnv.GetStaticMethodID (class_ref, "encodeBase64", "([BZ)[B");
			IntPtr native_binaryData = JNIEnv.NewArray (binaryData);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_binaryData);
				__args [1] = new JValue (isChunked);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBase64_arrayBZ, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (binaryData != null) {
					JNIEnv.CopyArray (native_binaryData, binaryData);
					JNIEnv.DeleteLocalRef (native_binaryData);
				}
			}
		}

		static IntPtr id_encodeBase64_arrayBZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64']/method[@name='encodeBase64' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("encodeBase64", "([BZZ)[B", "")]
		public static unsafe byte[] EncodeBase64 (byte[] binaryData, bool isChunked, bool urlSafe)
		{
			if (id_encodeBase64_arrayBZZ == IntPtr.Zero)
				id_encodeBase64_arrayBZZ = JNIEnv.GetStaticMethodID (class_ref, "encodeBase64", "([BZZ)[B");
			IntPtr native_binaryData = JNIEnv.NewArray (binaryData);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_binaryData);
				__args [1] = new JValue (isChunked);
				__args [2] = new JValue (urlSafe);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBase64_arrayBZZ, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (binaryData != null) {
					JNIEnv.CopyArray (native_binaryData, binaryData);
					JNIEnv.DeleteLocalRef (native_binaryData);
				}
			}
		}

		static IntPtr id_encodeBase64_arrayBZZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64']/method[@name='encodeBase64' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
		[Register ("encodeBase64", "([BZZI)[B", "")]
		public static unsafe byte[] EncodeBase64 (byte[] binaryData, bool isChunked, bool urlSafe, int maxResultSize)
		{
			if (id_encodeBase64_arrayBZZI == IntPtr.Zero)
				id_encodeBase64_arrayBZZI = JNIEnv.GetStaticMethodID (class_ref, "encodeBase64", "([BZZI)[B");
			IntPtr native_binaryData = JNIEnv.NewArray (binaryData);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_binaryData);
				__args [1] = new JValue (isChunked);
				__args [2] = new JValue (urlSafe);
				__args [3] = new JValue (maxResultSize);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBase64_arrayBZZI, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (binaryData != null) {
					JNIEnv.CopyArray (native_binaryData, binaryData);
					JNIEnv.DeleteLocalRef (native_binaryData);
				}
			}
		}

		static IntPtr id_encodeBase64Chunked_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64']/method[@name='encodeBase64Chunked' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeBase64Chunked", "([B)[B", "")]
		public static unsafe byte[] EncodeBase64Chunked (byte[] binaryData)
		{
			if (id_encodeBase64Chunked_arrayB == IntPtr.Zero)
				id_encodeBase64Chunked_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encodeBase64Chunked", "([B)[B");
			IntPtr native_binaryData = JNIEnv.NewArray (binaryData);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_binaryData);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBase64Chunked_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (binaryData != null) {
					JNIEnv.CopyArray (native_binaryData, binaryData);
					JNIEnv.DeleteLocalRef (native_binaryData);
				}
			}
		}

		static IntPtr id_encodeBase64String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64']/method[@name='encodeBase64String' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeBase64String", "([B)Ljava/lang/String;", "")]
		public static unsafe string EncodeBase64String (byte[] binaryData)
		{
			if (id_encodeBase64String_arrayB == IntPtr.Zero)
				id_encodeBase64String_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encodeBase64String", "([B)Ljava/lang/String;");
			IntPtr native_binaryData = JNIEnv.NewArray (binaryData);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_binaryData);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBase64String_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (binaryData != null) {
					JNIEnv.CopyArray (native_binaryData, binaryData);
					JNIEnv.DeleteLocalRef (native_binaryData);
				}
			}
		}

		static IntPtr id_encodeBase64URLSafe_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64']/method[@name='encodeBase64URLSafe' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeBase64URLSafe", "([B)[B", "")]
		public static unsafe byte[] EncodeBase64URLSafe (byte[] binaryData)
		{
			if (id_encodeBase64URLSafe_arrayB == IntPtr.Zero)
				id_encodeBase64URLSafe_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encodeBase64URLSafe", "([B)[B");
			IntPtr native_binaryData = JNIEnv.NewArray (binaryData);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_binaryData);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBase64URLSafe_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (binaryData != null) {
					JNIEnv.CopyArray (native_binaryData, binaryData);
					JNIEnv.DeleteLocalRef (native_binaryData);
				}
			}
		}

		static IntPtr id_encodeBase64URLSafeString_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64']/method[@name='encodeBase64URLSafeString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeBase64URLSafeString", "([B)Ljava/lang/String;", "")]
		public static unsafe string EncodeBase64URLSafeString (byte[] binaryData)
		{
			if (id_encodeBase64URLSafeString_arrayB == IntPtr.Zero)
				id_encodeBase64URLSafeString_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encodeBase64URLSafeString", "([B)Ljava/lang/String;");
			IntPtr native_binaryData = JNIEnv.NewArray (binaryData);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_binaryData);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBase64URLSafeString_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (binaryData != null) {
					JNIEnv.CopyArray (native_binaryData, binaryData);
					JNIEnv.DeleteLocalRef (native_binaryData);
				}
			}
		}

		static IntPtr id_encodeInteger_Ljava_math_BigInteger_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64']/method[@name='encodeInteger' and count(parameter)=1 and parameter[1][@type='java.math.BigInteger']]"
		[Register ("encodeInteger", "(Ljava/math/BigInteger;)[B", "")]
		public static unsafe byte[] EncodeInteger (global::Java.Math.BigInteger bigInt)
		{
			if (id_encodeInteger_Ljava_math_BigInteger_ == IntPtr.Zero)
				id_encodeInteger_Ljava_math_BigInteger_ = JNIEnv.GetStaticMethodID (class_ref, "encodeInteger", "(Ljava/math/BigInteger;)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (bigInt);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeInteger_Ljava_math_BigInteger_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isArrayByteBase64_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64']/method[@name='isArrayByteBase64' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Obsolete (@"deprecated")]
		[Register ("isArrayByteBase64", "([B)Z", "")]
		public static unsafe bool IsArrayByteBase64 (byte[] arrayOctet)
		{
			if (id_isArrayByteBase64_arrayB == IntPtr.Zero)
				id_isArrayByteBase64_arrayB = JNIEnv.GetStaticMethodID (class_ref, "isArrayByteBase64", "([B)Z");
			IntPtr native_arrayOctet = JNIEnv.NewArray (arrayOctet);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_arrayOctet);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isArrayByteBase64_arrayB, __args);
				return __ret;
			} finally {
				if (arrayOctet != null) {
					JNIEnv.CopyArray (native_arrayOctet, arrayOctet);
					JNIEnv.DeleteLocalRef (native_arrayOctet);
				}
			}
		}

		static IntPtr id_isBase64_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64']/method[@name='isBase64' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("isBase64", "(B)Z", "")]
		public static unsafe bool IsBase64 (sbyte octet)
		{
			if (id_isBase64_B == IntPtr.Zero)
				id_isBase64_B = JNIEnv.GetStaticMethodID (class_ref, "isBase64", "(B)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (octet);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isBase64_B, __args);
			} finally {
			}
		}

		static IntPtr id_isBase64_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64']/method[@name='isBase64' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("isBase64", "([B)Z", "")]
		public static unsafe bool IsBase64 (byte[] arrayOctet)
		{
			if (id_isBase64_arrayB == IntPtr.Zero)
				id_isBase64_arrayB = JNIEnv.GetStaticMethodID (class_ref, "isBase64", "([B)Z");
			IntPtr native_arrayOctet = JNIEnv.NewArray (arrayOctet);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_arrayOctet);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isBase64_arrayB, __args);
				return __ret;
			} finally {
				if (arrayOctet != null) {
					JNIEnv.CopyArray (native_arrayOctet, arrayOctet);
					JNIEnv.DeleteLocalRef (native_arrayOctet);
				}
			}
		}

		static IntPtr id_isBase64_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64']/method[@name='isBase64' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isBase64", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsBase64 (string base64)
		{
			if (id_isBase64_Ljava_lang_String_ == IntPtr.Zero)
				id_isBase64_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isBase64", "(Ljava/lang/String;)Z");
			IntPtr native_base64 = JNIEnv.NewString (base64);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_base64);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isBase64_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_base64);
			}
		}

		static Delegate cb_isInAlphabet_B;
#pragma warning disable 0169
		static Delegate GetIsInAlphabet_BHandler ()
		{
			if (cb_isInAlphabet_B == null)
				cb_isInAlphabet_B = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte, bool>) n_IsInAlphabet_B);
			return cb_isInAlphabet_B;
		}

		static bool n_IsInAlphabet_B (IntPtr jnienv, IntPtr native__this, sbyte octet)
		{
			global::Org.Apache.Commons.Codec.Binary.Base64 __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Binary.Base64> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInAlphabet (octet);
		}
#pragma warning restore 0169

		static IntPtr id_isInAlphabet_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64']/method[@name='isInAlphabet' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("isInAlphabet", "(B)Z", "GetIsInAlphabet_BHandler")]
		protected override unsafe bool IsInAlphabet (sbyte octet)
		{
			if (id_isInAlphabet_B == IntPtr.Zero)
				id_isInAlphabet_B = JNIEnv.GetMethodID (class_ref, "isInAlphabet", "(B)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (octet);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInAlphabet_B, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInAlphabet", "(B)Z"), __args);
			} finally {
			}
		}

	}
}
