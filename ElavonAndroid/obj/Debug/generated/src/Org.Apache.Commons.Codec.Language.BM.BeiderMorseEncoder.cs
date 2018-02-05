using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Language.BM {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='BeiderMorseEncoder']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/language/bm/BeiderMorseEncoder", DoNotGenerateAcw=true)]
	public partial class BeiderMorseEncoder : global::Java.Lang.Object, global::Org.Apache.Commons.Codec.IStringEncoder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/language/bm/BeiderMorseEncoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BeiderMorseEncoder); }
		}

		protected BeiderMorseEncoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='BeiderMorseEncoder']/constructor[@name='BeiderMorseEncoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BeiderMorseEncoder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BeiderMorseEncoder)) {
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

		static Delegate cb_isConcat;
#pragma warning disable 0169
		static Delegate GetIsConcatHandler ()
		{
			if (cb_isConcat == null)
				cb_isConcat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConcat);
			return cb_isConcat;
		}

		static bool n_IsConcat (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Commons.Codec.Language.BM.BeiderMorseEncoder __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.BeiderMorseEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Concat;
		}
#pragma warning restore 0169

		static Delegate cb_setConcat_Z;
#pragma warning disable 0169
		static Delegate GetSetConcat_ZHandler ()
		{
			if (cb_setConcat_Z == null)
				cb_setConcat_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetConcat_Z);
			return cb_setConcat_Z;
		}

		static void n_SetConcat_Z (IntPtr jnienv, IntPtr native__this, bool concat)
		{
			global::Org.Apache.Commons.Codec.Language.BM.BeiderMorseEncoder __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.BeiderMorseEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Concat = concat;
		}
#pragma warning restore 0169

		static IntPtr id_isConcat;
		static IntPtr id_setConcat_Z;
		public virtual unsafe bool Concat {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='BeiderMorseEncoder']/method[@name='isConcat' and count(parameter)=0]"
			[Register ("isConcat", "()Z", "GetIsConcatHandler")]
			get {
				if (id_isConcat == IntPtr.Zero)
					id_isConcat = JNIEnv.GetMethodID (class_ref, "isConcat", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConcat);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConcat", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='BeiderMorseEncoder']/method[@name='setConcat' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setConcat", "(Z)V", "GetSetConcat_ZHandler")]
			set {
				if (id_setConcat_Z == IntPtr.Zero)
					id_setConcat_Z = JNIEnv.GetMethodID (class_ref, "setConcat", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConcat_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConcat", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNameType;
#pragma warning disable 0169
		static Delegate GetGetNameTypeHandler ()
		{
			if (cb_getNameType == null)
				cb_getNameType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNameType);
			return cb_getNameType;
		}

		static IntPtr n_GetNameType (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Commons.Codec.Language.BM.BeiderMorseEncoder __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.BeiderMorseEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NameType);
		}
#pragma warning restore 0169

		static Delegate cb_setNameType_Lorg_apache_commons_codec_language_bm_NameType_;
#pragma warning disable 0169
		static Delegate GetSetNameType_Lorg_apache_commons_codec_language_bm_NameType_Handler ()
		{
			if (cb_setNameType_Lorg_apache_commons_codec_language_bm_NameType_ == null)
				cb_setNameType_Lorg_apache_commons_codec_language_bm_NameType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNameType_Lorg_apache_commons_codec_language_bm_NameType_);
			return cb_setNameType_Lorg_apache_commons_codec_language_bm_NameType_;
		}

		static void n_SetNameType_Lorg_apache_commons_codec_language_bm_NameType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nameType)
		{
			global::Org.Apache.Commons.Codec.Language.BM.BeiderMorseEncoder __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.BeiderMorseEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Commons.Codec.Language.BM.NameType nameType = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.NameType> (native_nameType, JniHandleOwnership.DoNotTransfer);
			__this.NameType = nameType;
		}
#pragma warning restore 0169

		static IntPtr id_getNameType;
		static IntPtr id_setNameType_Lorg_apache_commons_codec_language_bm_NameType_;
		public virtual unsafe global::Org.Apache.Commons.Codec.Language.BM.NameType NameType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='BeiderMorseEncoder']/method[@name='getNameType' and count(parameter)=0]"
			[Register ("getNameType", "()Lorg/apache/commons/codec/language/bm/NameType;", "GetGetNameTypeHandler")]
			get {
				if (id_getNameType == IntPtr.Zero)
					id_getNameType = JNIEnv.GetMethodID (class_ref, "getNameType", "()Lorg/apache/commons/codec/language/bm/NameType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.NameType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNameType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.NameType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNameType", "()Lorg/apache/commons/codec/language/bm/NameType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='BeiderMorseEncoder']/method[@name='setNameType' and count(parameter)=1 and parameter[1][@type='org.apache.commons.codec.language.bm.NameType']]"
			[Register ("setNameType", "(Lorg/apache/commons/codec/language/bm/NameType;)V", "GetSetNameType_Lorg_apache_commons_codec_language_bm_NameType_Handler")]
			set {
				if (id_setNameType_Lorg_apache_commons_codec_language_bm_NameType_ == IntPtr.Zero)
					id_setNameType_Lorg_apache_commons_codec_language_bm_NameType_ = JNIEnv.GetMethodID (class_ref, "setNameType", "(Lorg/apache/commons/codec/language/bm/NameType;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNameType_Lorg_apache_commons_codec_language_bm_NameType_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNameType", "(Lorg/apache/commons/codec/language/bm/NameType;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRuleType;
#pragma warning disable 0169
		static Delegate GetGetRuleTypeHandler ()
		{
			if (cb_getRuleType == null)
				cb_getRuleType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRuleType);
			return cb_getRuleType;
		}

		static IntPtr n_GetRuleType (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Commons.Codec.Language.BM.BeiderMorseEncoder __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.BeiderMorseEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RuleType);
		}
#pragma warning restore 0169

		static Delegate cb_setRuleType_Lorg_apache_commons_codec_language_bm_RuleType_;
#pragma warning disable 0169
		static Delegate GetSetRuleType_Lorg_apache_commons_codec_language_bm_RuleType_Handler ()
		{
			if (cb_setRuleType_Lorg_apache_commons_codec_language_bm_RuleType_ == null)
				cb_setRuleType_Lorg_apache_commons_codec_language_bm_RuleType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRuleType_Lorg_apache_commons_codec_language_bm_RuleType_);
			return cb_setRuleType_Lorg_apache_commons_codec_language_bm_RuleType_;
		}

		static void n_SetRuleType_Lorg_apache_commons_codec_language_bm_RuleType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ruleType)
		{
			global::Org.Apache.Commons.Codec.Language.BM.BeiderMorseEncoder __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.BeiderMorseEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Commons.Codec.Language.BM.RuleType ruleType = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.RuleType> (native_ruleType, JniHandleOwnership.DoNotTransfer);
			__this.RuleType = ruleType;
		}
#pragma warning restore 0169

		static IntPtr id_getRuleType;
		static IntPtr id_setRuleType_Lorg_apache_commons_codec_language_bm_RuleType_;
		public virtual unsafe global::Org.Apache.Commons.Codec.Language.BM.RuleType RuleType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='BeiderMorseEncoder']/method[@name='getRuleType' and count(parameter)=0]"
			[Register ("getRuleType", "()Lorg/apache/commons/codec/language/bm/RuleType;", "GetGetRuleTypeHandler")]
			get {
				if (id_getRuleType == IntPtr.Zero)
					id_getRuleType = JNIEnv.GetMethodID (class_ref, "getRuleType", "()Lorg/apache/commons/codec/language/bm/RuleType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.RuleType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRuleType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.RuleType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRuleType", "()Lorg/apache/commons/codec/language/bm/RuleType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='BeiderMorseEncoder']/method[@name='setRuleType' and count(parameter)=1 and parameter[1][@type='org.apache.commons.codec.language.bm.RuleType']]"
			[Register ("setRuleType", "(Lorg/apache/commons/codec/language/bm/RuleType;)V", "GetSetRuleType_Lorg_apache_commons_codec_language_bm_RuleType_Handler")]
			set {
				if (id_setRuleType_Lorg_apache_commons_codec_language_bm_RuleType_ == IntPtr.Zero)
					id_setRuleType_Lorg_apache_commons_codec_language_bm_RuleType_ = JNIEnv.GetMethodID (class_ref, "setRuleType", "(Lorg/apache/commons/codec/language/bm/RuleType;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRuleType_Lorg_apache_commons_codec_language_bm_RuleType_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRuleType", "(Lorg/apache/commons/codec/language/bm/RuleType;)V"), __args);
				} finally {
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

		static IntPtr n_Encode_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			global::Org.Apache.Commons.Codec.Language.BM.BeiderMorseEncoder __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.BeiderMorseEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object source = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_source, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Encode (source));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='BeiderMorseEncoder']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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

		static Delegate cb_encode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_lang_String_Handler ()
		{
			if (cb_encode_Ljava_lang_String_ == null)
				cb_encode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Encode_Ljava_lang_String_);
			return cb_encode_Ljava_lang_String_;
		}

		static IntPtr n_Encode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			global::Org.Apache.Commons.Codec.Language.BM.BeiderMorseEncoder __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.BeiderMorseEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string source = JNIEnv.GetString (native_source, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Encode (source));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='BeiderMorseEncoder']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encode", "(Ljava/lang/String;)Ljava/lang/String;", "GetEncode_Ljava_lang_String_Handler")]
		public virtual unsafe string Encode (string source)
		{
			if (id_encode_Ljava_lang_String_ == IntPtr.Zero)
				id_encode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_source = JNIEnv.NewString (source);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_source);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_source);
			}
		}

		static Delegate cb_setMaxPhonemes_I;
#pragma warning disable 0169
		static Delegate GetSetMaxPhonemes_IHandler ()
		{
			if (cb_setMaxPhonemes_I == null)
				cb_setMaxPhonemes_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxPhonemes_I);
			return cb_setMaxPhonemes_I;
		}

		static void n_SetMaxPhonemes_I (IntPtr jnienv, IntPtr native__this, int maxPhonemes)
		{
			global::Org.Apache.Commons.Codec.Language.BM.BeiderMorseEncoder __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.BeiderMorseEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxPhonemes (maxPhonemes);
		}
#pragma warning restore 0169

		static IntPtr id_setMaxPhonemes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='BeiderMorseEncoder']/method[@name='setMaxPhonemes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxPhonemes", "(I)V", "GetSetMaxPhonemes_IHandler")]
		public virtual unsafe void SetMaxPhonemes (int maxPhonemes)
		{
			if (id_setMaxPhonemes_I == IntPtr.Zero)
				id_setMaxPhonemes_I = JNIEnv.GetMethodID (class_ref, "setMaxPhonemes", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (maxPhonemes);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaxPhonemes_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxPhonemes", "(I)V"), __args);
			} finally {
			}
		}

	}
}
