using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Language {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='RefinedSoundex']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/language/RefinedSoundex", DoNotGenerateAcw=true)]
	public partial class RefinedSoundex : global::Java.Lang.Object, global::Org.Apache.Commons.Codec.IStringEncoder {


		static IntPtr US_ENGLISH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='RefinedSoundex']/field[@name='US_ENGLISH']"
		[Register ("US_ENGLISH")]
		public static global::Org.Apache.Commons.Codec.Language.RefinedSoundex UsEnglish {
			get {
				if (US_ENGLISH_jfieldId == IntPtr.Zero)
					US_ENGLISH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "US_ENGLISH", "Lorg/apache/commons/codec/language/RefinedSoundex;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, US_ENGLISH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.RefinedSoundex> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='RefinedSoundex']/field[@name='US_ENGLISH_MAPPING_STRING']"
		[Register ("US_ENGLISH_MAPPING_STRING")]
		public const string UsEnglishMappingString = (string) "01360240043788015936020505";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/language/RefinedSoundex", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RefinedSoundex); }
		}

		protected RefinedSoundex (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='RefinedSoundex']/constructor[@name='RefinedSoundex' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RefinedSoundex ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (RefinedSoundex)) {
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

		static IntPtr id_ctor_arrayC;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='RefinedSoundex']/constructor[@name='RefinedSoundex' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register (".ctor", "([C)V", "")]
		public unsafe RefinedSoundex (char[] mapping)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_mapping = JNIEnv.NewArray (mapping);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_mapping);
				if (((object) this).GetType () != typeof (RefinedSoundex)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([C)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([C)V", __args);
					return;
				}

				if (id_ctor_arrayC == IntPtr.Zero)
					id_ctor_arrayC = JNIEnv.GetMethodID (class_ref, "<init>", "([C)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayC, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayC, __args);
			} finally {
				if (mapping != null) {
					JNIEnv.CopyArray (native_mapping, mapping);
					JNIEnv.DeleteLocalRef (native_mapping);
				}
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='RefinedSoundex']/constructor[@name='RefinedSoundex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe RefinedSoundex (string mapping)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_mapping = JNIEnv.NewString (mapping);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_mapping);
				if (((object) this).GetType () != typeof (RefinedSoundex)) {
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
				JNIEnv.DeleteLocalRef (native_mapping);
			}
		}

		static Delegate cb_difference_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDifference_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_difference_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_difference_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Difference_Ljava_lang_String_Ljava_lang_String_);
			return cb_difference_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_Difference_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s1, IntPtr native_s2)
		{
			global::Org.Apache.Commons.Codec.Language.RefinedSoundex __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.RefinedSoundex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string s1 = JNIEnv.GetString (native_s1, JniHandleOwnership.DoNotTransfer);
			string s2 = JNIEnv.GetString (native_s2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Difference (s1, s2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_difference_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='RefinedSoundex']/method[@name='difference' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("difference", "(Ljava/lang/String;Ljava/lang/String;)I", "GetDifference_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int Difference (string s1, string s2)
		{
			if (id_difference_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_difference_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "difference", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_s1 = JNIEnv.NewString (s1);
			IntPtr native_s2 = JNIEnv.NewString (s2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_s1);
				__args [1] = new JValue (native_s2);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_difference_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "difference", "(Ljava/lang/String;Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_s1);
				JNIEnv.DeleteLocalRef (native_s2);
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
			global::Org.Apache.Commons.Codec.Language.RefinedSoundex __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.RefinedSoundex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Encode (obj));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='RefinedSoundex']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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
			global::Org.Apache.Commons.Codec.Language.RefinedSoundex __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.RefinedSoundex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Encode (str));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='RefinedSoundex']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_soundex_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSoundex_Ljava_lang_String_Handler ()
		{
			if (cb_soundex_Ljava_lang_String_ == null)
				cb_soundex_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Soundex_Ljava_lang_String_);
			return cb_soundex_Ljava_lang_String_;
		}

		static IntPtr n_Soundex_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str)
		{
			global::Org.Apache.Commons.Codec.Language.RefinedSoundex __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.RefinedSoundex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Soundex (str));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_soundex_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='RefinedSoundex']/method[@name='soundex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("soundex", "(Ljava/lang/String;)Ljava/lang/String;", "GetSoundex_Ljava_lang_String_Handler")]
		public virtual unsafe string Soundex (string str)
		{
			if (id_soundex_Ljava_lang_String_ == IntPtr.Zero)
				id_soundex_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "soundex", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_soundex_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "soundex", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

	}
}
