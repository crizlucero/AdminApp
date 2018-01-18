using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Language {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='AbstractCaverphone']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/language/AbstractCaverphone", DoNotGenerateAcw=true)]
	public abstract partial class AbstractCaverphone : global::Java.Lang.Object, global::Org.Apache.Commons.Codec.IStringEncoder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/language/AbstractCaverphone", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractCaverphone); }
		}

		protected AbstractCaverphone (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='AbstractCaverphone']/constructor[@name='AbstractCaverphone' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AbstractCaverphone ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AbstractCaverphone)) {
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

		static Delegate cb_encode_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_lang_Object_Handler ()
		{
			if (cb_encode_Ljava_lang_Object_ == null)
				cb_encode_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Encode_Ljava_lang_Object_);
			return cb_encode_Ljava_lang_Object_;
		}

		static IntPtr n_Encode_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			global::Org.Apache.Commons.Codec.Language.AbstractCaverphone __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.AbstractCaverphone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object source = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_source, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Encode (source));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='AbstractCaverphone']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("encode", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetEncode_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object Encode (global::Java.Lang.Object source)
		{
			if (id_encode_Ljava_lang_Object_ == IntPtr.Zero)
				id_encode_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/Object;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isEncodeEqual_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsEncodeEqual_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_isEncodeEqual_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_isEncodeEqual_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_IsEncodeEqual_Ljava_lang_String_Ljava_lang_String_);
			return cb_isEncodeEqual_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_IsEncodeEqual_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str1, IntPtr native_str2)
		{
			global::Org.Apache.Commons.Codec.Language.AbstractCaverphone __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.AbstractCaverphone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string str1 = JNIEnv.GetString (native_str1, JniHandleOwnership.DoNotTransfer);
			string str2 = JNIEnv.GetString (native_str2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsEncodeEqual (str1, str2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isEncodeEqual_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='AbstractCaverphone']/method[@name='isEncodeEqual' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("isEncodeEqual", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetIsEncodeEqual_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsEncodeEqual (string str1, string str2)
		{
			if (id_isEncodeEqual_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_isEncodeEqual_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isEncodeEqual", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_str1 = JNIEnv.NewString (str1);
			IntPtr native_str2 = JNIEnv.NewString (str2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str1);
				__args [1] = new JValue (native_str2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEncodeEqual_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEncodeEqual", "(Ljava/lang/String;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str1);
				JNIEnv.DeleteLocalRef (native_str2);
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

		static IntPtr n_Encode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Commons.Codec.Language.AbstractCaverphone __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.AbstractCaverphone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Encode (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec']/interface[@name='StringEncoder']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encode", "(Ljava/lang/String;)Ljava/lang/String;", "GetEncode_Ljava_lang_String_Handler")]
		public abstract string Encode (string p0);

	}

	[global::Android.Runtime.Register ("org/apache/commons/codec/language/AbstractCaverphone", DoNotGenerateAcw=true)]
	internal partial class AbstractCaverphoneInvoker : AbstractCaverphone {

		public AbstractCaverphoneInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractCaverphoneInvoker); }
		}

		static IntPtr id_encode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec']/interface[@name='StringEncoder']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encode", "(Ljava/lang/String;)Ljava/lang/String;", "GetEncode_Ljava_lang_String_Handler")]
		public override unsafe string Encode (string p0)
		{
			if (id_encode_Ljava_lang_String_ == IntPtr.Zero)
				id_encode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
