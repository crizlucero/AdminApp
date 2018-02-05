using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Binary {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodec']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/binary/BaseNCodec", DoNotGenerateAcw=true)]
	public abstract partial class BaseNCodec : global::Java.Lang.Object, global::Org.Apache.Commons.Codec.IBinaryDecoder, global::Org.Apache.Commons.Codec.IBinaryEncoder {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodec']/field[@name='MASK_8BITS']"
		[Register ("MASK_8BITS")]
		protected const int Mask8bits = (int) 255;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodec']/field[@name='MIME_CHUNK_SIZE']"
		[Register ("MIME_CHUNK_SIZE")]
		public const int MimeChunkSize = (int) 76;

		static IntPtr PAD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodec']/field[@name='PAD']"
		[Register ("PAD")]
		protected sbyte Pad {
			get {
				if (PAD_jfieldId == IntPtr.Zero)
					PAD_jfieldId = JNIEnv.GetFieldID (class_ref, "PAD", "B");
				return JNIEnv.GetByteField (((global::Java.Lang.Object) this).Handle, PAD_jfieldId);
			}
			set {
				if (PAD_jfieldId == IntPtr.Zero)
					PAD_jfieldId = JNIEnv.GetFieldID (class_ref, "PAD", "B");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, PAD_jfieldId, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodec']/field[@name='PAD_DEFAULT']"
		[Register ("PAD_DEFAULT")]
		protected const sbyte PadDefault = (sbyte) 61;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodec']/field[@name='PEM_CHUNK_SIZE']"
		[Register ("PEM_CHUNK_SIZE")]
		public const int PemChunkSize = (int) 64;

		static IntPtr lineLength_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodec']/field[@name='lineLength']"
		[Register ("lineLength")]
		protected int LineLength {
			get {
				if (lineLength_jfieldId == IntPtr.Zero)
					lineLength_jfieldId = JNIEnv.GetFieldID (class_ref, "lineLength", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, lineLength_jfieldId);
			}
			set {
				if (lineLength_jfieldId == IntPtr.Zero)
					lineLength_jfieldId = JNIEnv.GetFieldID (class_ref, "lineLength", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lineLength_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodec.Context']"
		[global::Android.Runtime.Register ("org/apache/commons/codec/binary/BaseNCodec$Context", DoNotGenerateAcw=true)]
		public partial class Context : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/apache/commons/codec/binary/BaseNCodec$Context", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Context); }
			}

			protected Context (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/binary/BaseNCodec", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseNCodec); }
		}

		protected BaseNCodec (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IIII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodec']/constructor[@name='BaseNCodec' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(IIII)V", "")]
		protected unsafe BaseNCodec (int unencodedBlockSize, int encodedBlockSize, int lineLength, int chunkSeparatorLength)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (unencodedBlockSize);
				__args [1] = new JValue (encodedBlockSize);
				__args [2] = new JValue (lineLength);
				__args [3] = new JValue (chunkSeparatorLength);
				if (((object) this).GetType () != typeof (BaseNCodec)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(IIII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIII)V", __args);
					return;
				}

				if (id_ctor_IIII == IntPtr.Zero)
					id_ctor_IIII = JNIEnv.GetMethodID (class_ref, "<init>", "(IIII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIII, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_IIIIB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodec']/constructor[@name='BaseNCodec' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte']]"
		[Register (".ctor", "(IIIIB)V", "")]
		protected unsafe BaseNCodec (int unencodedBlockSize, int encodedBlockSize, int lineLength, int chunkSeparatorLength, sbyte pad)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (unencodedBlockSize);
				__args [1] = new JValue (encodedBlockSize);
				__args [2] = new JValue (lineLength);
				__args [3] = new JValue (chunkSeparatorLength);
				__args [4] = new JValue (pad);
				if (((object) this).GetType () != typeof (BaseNCodec)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(IIIIB)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIIIB)V", __args);
					return;
				}

				if (id_ctor_IIIIB == IntPtr.Zero)
					id_ctor_IIIIB = JNIEnv.GetMethodID (class_ref, "<init>", "(IIIIB)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIIIB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIIIB, __args);
			} finally {
			}
		}

		static Delegate cb_getDefaultBufferSize;
#pragma warning disable 0169
		static Delegate GetGetDefaultBufferSizeHandler ()
		{
			if (cb_getDefaultBufferSize == null)
				cb_getDefaultBufferSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDefaultBufferSize);
			return cb_getDefaultBufferSize;
		}

		static int n_GetDefaultBufferSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Commons.Codec.Binary.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Binary.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DefaultBufferSize;
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultBufferSize;
		protected virtual unsafe int DefaultBufferSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodec']/method[@name='getDefaultBufferSize' and count(parameter)=0]"
			[Register ("getDefaultBufferSize", "()I", "GetGetDefaultBufferSizeHandler")]
			get {
				if (id_getDefaultBufferSize == IntPtr.Zero)
					id_getDefaultBufferSize = JNIEnv.GetMethodID (class_ref, "getDefaultBufferSize", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultBufferSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultBufferSize", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_containsAlphabetOrPad_arrayB;
#pragma warning disable 0169
		static Delegate GetContainsAlphabetOrPad_arrayBHandler ()
		{
			if (cb_containsAlphabetOrPad_arrayB == null)
				cb_containsAlphabetOrPad_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ContainsAlphabetOrPad_arrayB);
			return cb_containsAlphabetOrPad_arrayB;
		}

		static bool n_ContainsAlphabetOrPad_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_arrayOctet)
		{
			global::Org.Apache.Commons.Codec.Binary.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Binary.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] arrayOctet = (byte[]) JNIEnv.GetArray (native_arrayOctet, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.ContainsAlphabetOrPad (arrayOctet);
			if (arrayOctet != null)
				JNIEnv.CopyArray (arrayOctet, native_arrayOctet);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_containsAlphabetOrPad_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodec']/method[@name='containsAlphabetOrPad' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("containsAlphabetOrPad", "([B)Z", "GetContainsAlphabetOrPad_arrayBHandler")]
		protected virtual unsafe bool ContainsAlphabetOrPad (byte[] arrayOctet)
		{
			if (id_containsAlphabetOrPad_arrayB == IntPtr.Zero)
				id_containsAlphabetOrPad_arrayB = JNIEnv.GetMethodID (class_ref, "containsAlphabetOrPad", "([B)Z");
			IntPtr native_arrayOctet = JNIEnv.NewArray (arrayOctet);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_arrayOctet);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_containsAlphabetOrPad_arrayB, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "containsAlphabetOrPad", "([B)Z"), __args);
				return __ret;
			} finally {
				if (arrayOctet != null) {
					JNIEnv.CopyArray (native_arrayOctet, arrayOctet);
					JNIEnv.DeleteLocalRef (native_arrayOctet);
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

		static IntPtr n_Decode_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_pArray)
		{
			global::Org.Apache.Commons.Codec.Binary.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Binary.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] pArray = (byte[]) JNIEnv.GetArray (native_pArray, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Decode (pArray));
			if (pArray != null)
				JNIEnv.CopyArray (pArray, native_pArray);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodec']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decode", "([B)[B", "GetDecode_arrayBHandler")]
		public virtual unsafe byte[] Decode (byte[] pArray)
		{
			if (id_decode_arrayB == IntPtr.Zero)
				id_decode_arrayB = JNIEnv.GetMethodID (class_ref, "decode", "([B)[B");
			IntPtr native_pArray = JNIEnv.NewArray (pArray);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_pArray);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decode_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "([B)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (pArray != null) {
					JNIEnv.CopyArray (native_pArray, pArray);
					JNIEnv.DeleteLocalRef (native_pArray);
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
			global::Org.Apache.Commons.Codec.Binary.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Binary.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (obj));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodec']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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

		static IntPtr n_Decode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pArray)
		{
			global::Org.Apache.Commons.Codec.Binary.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Binary.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string pArray = JNIEnv.GetString (native_pArray, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Decode (pArray));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodec']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decode", "(Ljava/lang/String;)[B", "GetDecode_Ljava_lang_String_Handler")]
		public virtual unsafe byte[] Decode (string pArray)
		{
			if (id_decode_Ljava_lang_String_ == IntPtr.Zero)
				id_decode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/lang/String;)[B");
			IntPtr native_pArray = JNIEnv.NewString (pArray);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_pArray);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Ljava/lang/String;)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_pArray);
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

		static IntPtr n_Encode_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_pArray)
		{
			global::Org.Apache.Commons.Codec.Binary.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Binary.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] pArray = (byte[]) JNIEnv.GetArray (native_pArray, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Encode (pArray));
			if (pArray != null)
				JNIEnv.CopyArray (pArray, native_pArray);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodec']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encode", "([B)[B", "GetEncode_arrayBHandler")]
		public virtual unsafe byte[] Encode (byte[] pArray)
		{
			if (id_encode_arrayB == IntPtr.Zero)
				id_encode_arrayB = JNIEnv.GetMethodID (class_ref, "encode", "([B)[B");
			IntPtr native_pArray = JNIEnv.NewArray (pArray);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_pArray);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "([B)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (pArray != null) {
					JNIEnv.CopyArray (native_pArray, pArray);
					JNIEnv.DeleteLocalRef (native_pArray);
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
			global::Org.Apache.Commons.Codec.Binary.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Binary.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Encode (obj));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodec']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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

		static Delegate cb_encodeAsString_arrayB;
#pragma warning disable 0169
		static Delegate GetEncodeAsString_arrayBHandler ()
		{
			if (cb_encodeAsString_arrayB == null)
				cb_encodeAsString_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_EncodeAsString_arrayB);
			return cb_encodeAsString_arrayB;
		}

		static IntPtr n_EncodeAsString_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_pArray)
		{
			global::Org.Apache.Commons.Codec.Binary.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Binary.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] pArray = (byte[]) JNIEnv.GetArray (native_pArray, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewString (__this.EncodeAsString (pArray));
			if (pArray != null)
				JNIEnv.CopyArray (pArray, native_pArray);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encodeAsString_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodec']/method[@name='encodeAsString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeAsString", "([B)Ljava/lang/String;", "GetEncodeAsString_arrayBHandler")]
		public virtual unsafe string EncodeAsString (byte[] pArray)
		{
			if (id_encodeAsString_arrayB == IntPtr.Zero)
				id_encodeAsString_arrayB = JNIEnv.GetMethodID (class_ref, "encodeAsString", "([B)Ljava/lang/String;");
			IntPtr native_pArray = JNIEnv.NewArray (pArray);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_pArray);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodeAsString_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeAsString", "([B)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (pArray != null) {
					JNIEnv.CopyArray (native_pArray, pArray);
					JNIEnv.DeleteLocalRef (native_pArray);
				}
			}
		}

		static Delegate cb_encodeToString_arrayB;
#pragma warning disable 0169
		static Delegate GetEncodeToString_arrayBHandler ()
		{
			if (cb_encodeToString_arrayB == null)
				cb_encodeToString_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_EncodeToString_arrayB);
			return cb_encodeToString_arrayB;
		}

		static IntPtr n_EncodeToString_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_pArray)
		{
			global::Org.Apache.Commons.Codec.Binary.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Binary.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] pArray = (byte[]) JNIEnv.GetArray (native_pArray, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewString (__this.EncodeToString (pArray));
			if (pArray != null)
				JNIEnv.CopyArray (pArray, native_pArray);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encodeToString_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodec']/method[@name='encodeToString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeToString", "([B)Ljava/lang/String;", "GetEncodeToString_arrayBHandler")]
		public virtual unsafe string EncodeToString (byte[] pArray)
		{
			if (id_encodeToString_arrayB == IntPtr.Zero)
				id_encodeToString_arrayB = JNIEnv.GetMethodID (class_ref, "encodeToString", "([B)Ljava/lang/String;");
			IntPtr native_pArray = JNIEnv.NewArray (pArray);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_pArray);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodeToString_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeToString", "([B)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (pArray != null) {
					JNIEnv.CopyArray (native_pArray, pArray);
					JNIEnv.DeleteLocalRef (native_pArray);
				}
			}
		}

		static Delegate cb_getEncodedLength_arrayB;
#pragma warning disable 0169
		static Delegate GetGetEncodedLength_arrayBHandler ()
		{
			if (cb_getEncodedLength_arrayB == null)
				cb_getEncodedLength_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_GetEncodedLength_arrayB);
			return cb_getEncodedLength_arrayB;
		}

		static long n_GetEncodedLength_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_pArray)
		{
			global::Org.Apache.Commons.Codec.Binary.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Binary.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] pArray = (byte[]) JNIEnv.GetArray (native_pArray, JniHandleOwnership.DoNotTransfer, typeof (byte));
			long __ret = __this.GetEncodedLength (pArray);
			if (pArray != null)
				JNIEnv.CopyArray (pArray, native_pArray);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getEncodedLength_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodec']/method[@name='getEncodedLength' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getEncodedLength", "([B)J", "GetGetEncodedLength_arrayBHandler")]
		public virtual unsafe long GetEncodedLength (byte[] pArray)
		{
			if (id_getEncodedLength_arrayB == IntPtr.Zero)
				id_getEncodedLength_arrayB = JNIEnv.GetMethodID (class_ref, "getEncodedLength", "([B)J");
			IntPtr native_pArray = JNIEnv.NewArray (pArray);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_pArray);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getEncodedLength_arrayB, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEncodedLength", "([B)J"), __args);
				return __ret;
			} finally {
				if (pArray != null) {
					JNIEnv.CopyArray (native_pArray, pArray);
					JNIEnv.DeleteLocalRef (native_pArray);
				}
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

		static bool n_IsInAlphabet_B (IntPtr jnienv, IntPtr native__this, sbyte p0)
		{
			global::Org.Apache.Commons.Codec.Binary.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Binary.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInAlphabet (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodec']/method[@name='isInAlphabet' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("isInAlphabet", "(B)Z", "GetIsInAlphabet_BHandler")]
		protected abstract bool IsInAlphabet (sbyte p0);

		static Delegate cb_isInAlphabet_arrayBZ;
#pragma warning disable 0169
		static Delegate GetIsInAlphabet_arrayBZHandler ()
		{
			if (cb_isInAlphabet_arrayBZ == null)
				cb_isInAlphabet_arrayBZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, bool>) n_IsInAlphabet_arrayBZ);
			return cb_isInAlphabet_arrayBZ;
		}

		static bool n_IsInAlphabet_arrayBZ (IntPtr jnienv, IntPtr native__this, IntPtr native_arrayOctet, bool allowWSPad)
		{
			global::Org.Apache.Commons.Codec.Binary.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Binary.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] arrayOctet = (byte[]) JNIEnv.GetArray (native_arrayOctet, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.IsInAlphabet (arrayOctet, allowWSPad);
			if (arrayOctet != null)
				JNIEnv.CopyArray (arrayOctet, native_arrayOctet);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isInAlphabet_arrayBZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodec']/method[@name='isInAlphabet' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='boolean']]"
		[Register ("isInAlphabet", "([BZ)Z", "GetIsInAlphabet_arrayBZHandler")]
		public virtual unsafe bool IsInAlphabet (byte[] arrayOctet, bool allowWSPad)
		{
			if (id_isInAlphabet_arrayBZ == IntPtr.Zero)
				id_isInAlphabet_arrayBZ = JNIEnv.GetMethodID (class_ref, "isInAlphabet", "([BZ)Z");
			IntPtr native_arrayOctet = JNIEnv.NewArray (arrayOctet);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_arrayOctet);
				__args [1] = new JValue (allowWSPad);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInAlphabet_arrayBZ, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInAlphabet", "([BZ)Z"), __args);
				return __ret;
			} finally {
				if (arrayOctet != null) {
					JNIEnv.CopyArray (native_arrayOctet, arrayOctet);
					JNIEnv.DeleteLocalRef (native_arrayOctet);
				}
			}
		}

		static Delegate cb_isInAlphabet_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsInAlphabet_Ljava_lang_String_Handler ()
		{
			if (cb_isInAlphabet_Ljava_lang_String_ == null)
				cb_isInAlphabet_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsInAlphabet_Ljava_lang_String_);
			return cb_isInAlphabet_Ljava_lang_String_;
		}

		static bool n_IsInAlphabet_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_basen)
		{
			global::Org.Apache.Commons.Codec.Binary.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Binary.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string basen = JNIEnv.GetString (native_basen, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsInAlphabet (basen);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isInAlphabet_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodec']/method[@name='isInAlphabet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isInAlphabet", "(Ljava/lang/String;)Z", "GetIsInAlphabet_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsInAlphabet (string basen)
		{
			if (id_isInAlphabet_Ljava_lang_String_ == IntPtr.Zero)
				id_isInAlphabet_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isInAlphabet", "(Ljava/lang/String;)Z");
			IntPtr native_basen = JNIEnv.NewString (basen);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_basen);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInAlphabet_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInAlphabet", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_basen);
			}
		}

		static IntPtr id_isWhiteSpace_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodec']/method[@name='isWhiteSpace' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("isWhiteSpace", "(B)Z", "")]
		protected static unsafe bool IsWhiteSpace (sbyte byteToCheck)
		{
			if (id_isWhiteSpace_B == IntPtr.Zero)
				id_isWhiteSpace_B = JNIEnv.GetStaticMethodID (class_ref, "isWhiteSpace", "(B)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (byteToCheck);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isWhiteSpace_B, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/apache/commons/codec/binary/BaseNCodec", DoNotGenerateAcw=true)]
	internal partial class BaseNCodecInvoker : BaseNCodec {

		public BaseNCodecInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseNCodecInvoker); }
		}

		static IntPtr id_isInAlphabet_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodec']/method[@name='isInAlphabet' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("isInAlphabet", "(B)Z", "GetIsInAlphabet_BHandler")]
		protected override unsafe bool IsInAlphabet (sbyte p0)
		{
			if (id_isInAlphabet_B == IntPtr.Zero)
				id_isInAlphabet_B = JNIEnv.GetMethodID (class_ref, "isInAlphabet", "(B)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInAlphabet_B, __args);
			} finally {
			}
		}

	}

}
