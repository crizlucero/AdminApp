using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Language {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='MatchRatingApproachEncoder']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/language/MatchRatingApproachEncoder", DoNotGenerateAcw=true)]
	public partial class MatchRatingApproachEncoder : global::Java.Lang.Object, global::Org.Apache.Commons.Codec.IStringEncoder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/language/MatchRatingApproachEncoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MatchRatingApproachEncoder); }
		}

		protected MatchRatingApproachEncoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='MatchRatingApproachEncoder']/constructor[@name='MatchRatingApproachEncoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MatchRatingApproachEncoder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MatchRatingApproachEncoder)) {
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

		static IntPtr id_encode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='MatchRatingApproachEncoder']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("encode", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object Encode (global::Java.Lang.Object pObject)
		{
			if (id_encode_Ljava_lang_Object_ == IntPtr.Zero)
				id_encode_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/Object;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (pObject);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_encode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='MatchRatingApproachEncoder']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encode", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string Encode (string name)
		{
			if (id_encode_Ljava_lang_String_ == IntPtr.Zero)
				id_encode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_isEncodeEquals_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsEncodeEquals_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_isEncodeEquals_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_isEncodeEquals_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_IsEncodeEquals_Ljava_lang_String_Ljava_lang_String_);
			return cb_isEncodeEquals_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_IsEncodeEquals_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name1, IntPtr native_name2)
		{
			global::Org.Apache.Commons.Codec.Language.MatchRatingApproachEncoder __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.MatchRatingApproachEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name1 = JNIEnv.GetString (native_name1, JniHandleOwnership.DoNotTransfer);
			string name2 = JNIEnv.GetString (native_name2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsEncodeEquals (name1, name2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isEncodeEquals_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='MatchRatingApproachEncoder']/method[@name='isEncodeEquals' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("isEncodeEquals", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetIsEncodeEquals_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsEncodeEquals (string name1, string name2)
		{
			if (id_isEncodeEquals_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_isEncodeEquals_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isEncodeEquals", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_name1 = JNIEnv.NewString (name1);
			IntPtr native_name2 = JNIEnv.NewString (name2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_name1);
				__args [1] = new JValue (native_name2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEncodeEquals_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEncodeEquals", "(Ljava/lang/String;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name1);
				JNIEnv.DeleteLocalRef (native_name2);
			}
		}

	}
}
