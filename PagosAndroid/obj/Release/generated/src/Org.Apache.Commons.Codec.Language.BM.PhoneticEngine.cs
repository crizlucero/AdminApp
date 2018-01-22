using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Language.BM {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='PhoneticEngine']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/language/bm/PhoneticEngine", DoNotGenerateAcw=true)]
	public partial class PhoneticEngine : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='PhoneticEngine.PhonemeBuilder']"
		[global::Android.Runtime.Register ("org/apache/commons/codec/language/bm/PhoneticEngine$PhonemeBuilder", DoNotGenerateAcw=true)]
		public sealed partial class PhonemeBuilder : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/apache/commons/codec/language/bm/PhoneticEngine$PhonemeBuilder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PhonemeBuilder); }
			}

			internal PhonemeBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getPhonemes;
			public unsafe global::System.Collections.Generic.ICollection<global::Org.Apache.Commons.Codec.Language.BM.Rule.Phoneme> Phonemes {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='PhoneticEngine.PhonemeBuilder']/method[@name='getPhonemes' and count(parameter)=0]"
				[Register ("getPhonemes", "()Ljava/util/Set;", "GetGetPhonemesHandler")]
				get {
					if (id_getPhonemes == IntPtr.Zero)
						id_getPhonemes = JNIEnv.GetMethodID (class_ref, "getPhonemes", "()Ljava/util/Set;");
					try {
						return global::Android.Runtime.JavaSet<global::Org.Apache.Commons.Codec.Language.BM.Rule.Phoneme>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPhonemes), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_append_Ljava_lang_CharSequence_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='PhoneticEngine.PhonemeBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("append", "(Ljava/lang/CharSequence;)V", "")]
			public unsafe void Append (global::Java.Lang.ICharSequence str)
			{
				if (id_append_Ljava_lang_CharSequence_ == IntPtr.Zero)
					id_append_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/CharSequence;)V");
				IntPtr native_str = CharSequence.ToLocalJniHandle (str);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_str);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_CharSequence_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_str);
				}
			}

			public void Append (string str)
			{
				global::Java.Lang.String jls_str = str == null ? null : new global::Java.Lang.String (str);
				Append (jls_str);
				jls_str?.Dispose ();
			}

			static IntPtr id_apply_Lorg_apache_commons_codec_language_bm_Rule_PhonemeExpr_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='PhoneticEngine.PhonemeBuilder']/method[@name='apply' and count(parameter)=2 and parameter[1][@type='org.apache.commons.codec.language.bm.Rule.PhonemeExpr'] and parameter[2][@type='int']]"
			[Register ("apply", "(Lorg/apache/commons/codec/language/bm/Rule$PhonemeExpr;I)V", "")]
			public unsafe void Apply (global::Org.Apache.Commons.Codec.Language.BM.Rule.IPhonemeExpr phonemeExpr, int maxPhonemes)
			{
				if (id_apply_Lorg_apache_commons_codec_language_bm_Rule_PhonemeExpr_I == IntPtr.Zero)
					id_apply_Lorg_apache_commons_codec_language_bm_Rule_PhonemeExpr_I = JNIEnv.GetMethodID (class_ref, "apply", "(Lorg/apache/commons/codec/language/bm/Rule$PhonemeExpr;I)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (phonemeExpr);
					__args [1] = new JValue (maxPhonemes);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_apply_Lorg_apache_commons_codec_language_bm_Rule_PhonemeExpr_I, __args);
				} finally {
				}
			}

			static IntPtr id_empty_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='PhoneticEngine.PhonemeBuilder']/method[@name='empty' and count(parameter)=1 and parameter[1][@type='org.apache.commons.codec.language.bm.Languages.LanguageSet']]"
			[Register ("empty", "(Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)Ljava/lang/Object;", "")]
			public static unsafe global::Java.Lang.Object Empty (global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet languages)
			{
				if (id_empty_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ == IntPtr.Zero)
					id_empty_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ = JNIEnv.GetStaticMethodID (class_ref, "empty", "(Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)Ljava/lang/Object;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (languages);
					global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_empty_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_makeString;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='PhoneticEngine.PhonemeBuilder']/method[@name='makeString' and count(parameter)=0]"
			[Register ("makeString", "()Ljava/lang/String;", "")]
			public unsafe string MakeString ()
			{
				if (id_makeString == IntPtr.Zero)
					id_makeString = JNIEnv.GetMethodID (class_ref, "makeString", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeString), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/language/bm/PhoneticEngine", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PhoneticEngine); }
		}

		protected PhoneticEngine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_apache_commons_codec_language_bm_NameType_Lorg_apache_commons_codec_language_bm_RuleType_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='PhoneticEngine']/constructor[@name='PhoneticEngine' and count(parameter)=3 and parameter[1][@type='org.apache.commons.codec.language.bm.NameType'] and parameter[2][@type='org.apache.commons.codec.language.bm.RuleType'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Lorg/apache/commons/codec/language/bm/NameType;Lorg/apache/commons/codec/language/bm/RuleType;Z)V", "")]
		public unsafe PhoneticEngine (global::Org.Apache.Commons.Codec.Language.BM.NameType nameType, global::Org.Apache.Commons.Codec.Language.BM.RuleType ruleType, bool concat)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (nameType);
				__args [1] = new JValue (ruleType);
				__args [2] = new JValue (concat);
				if (((object) this).GetType () != typeof (PhoneticEngine)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/apache/commons/codec/language/bm/NameType;Lorg/apache/commons/codec/language/bm/RuleType;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/apache/commons/codec/language/bm/NameType;Lorg/apache/commons/codec/language/bm/RuleType;Z)V", __args);
					return;
				}

				if (id_ctor_Lorg_apache_commons_codec_language_bm_NameType_Lorg_apache_commons_codec_language_bm_RuleType_Z == IntPtr.Zero)
					id_ctor_Lorg_apache_commons_codec_language_bm_NameType_Lorg_apache_commons_codec_language_bm_RuleType_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/commons/codec/language/bm/NameType;Lorg/apache/commons/codec/language/bm/RuleType;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_commons_codec_language_bm_NameType_Lorg_apache_commons_codec_language_bm_RuleType_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_apache_commons_codec_language_bm_NameType_Lorg_apache_commons_codec_language_bm_RuleType_Z, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_apache_commons_codec_language_bm_NameType_Lorg_apache_commons_codec_language_bm_RuleType_ZI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='PhoneticEngine']/constructor[@name='PhoneticEngine' and count(parameter)=4 and parameter[1][@type='org.apache.commons.codec.language.bm.NameType'] and parameter[2][@type='org.apache.commons.codec.language.bm.RuleType'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Lorg/apache/commons/codec/language/bm/NameType;Lorg/apache/commons/codec/language/bm/RuleType;ZI)V", "")]
		public unsafe PhoneticEngine (global::Org.Apache.Commons.Codec.Language.BM.NameType nameType, global::Org.Apache.Commons.Codec.Language.BM.RuleType ruleType, bool concat, int maxPhonemes)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (nameType);
				__args [1] = new JValue (ruleType);
				__args [2] = new JValue (concat);
				__args [3] = new JValue (maxPhonemes);
				if (((object) this).GetType () != typeof (PhoneticEngine)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/apache/commons/codec/language/bm/NameType;Lorg/apache/commons/codec/language/bm/RuleType;ZI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/apache/commons/codec/language/bm/NameType;Lorg/apache/commons/codec/language/bm/RuleType;ZI)V", __args);
					return;
				}

				if (id_ctor_Lorg_apache_commons_codec_language_bm_NameType_Lorg_apache_commons_codec_language_bm_RuleType_ZI == IntPtr.Zero)
					id_ctor_Lorg_apache_commons_codec_language_bm_NameType_Lorg_apache_commons_codec_language_bm_RuleType_ZI = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/commons/codec/language/bm/NameType;Lorg/apache/commons/codec/language/bm/RuleType;ZI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_commons_codec_language_bm_NameType_Lorg_apache_commons_codec_language_bm_RuleType_ZI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_apache_commons_codec_language_bm_NameType_Lorg_apache_commons_codec_language_bm_RuleType_ZI, __args);
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
			global::Org.Apache.Commons.Codec.Language.BM.PhoneticEngine __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.PhoneticEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConcat;
		}
#pragma warning restore 0169

		static IntPtr id_isConcat;
		public virtual unsafe bool IsConcat {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='PhoneticEngine']/method[@name='isConcat' and count(parameter)=0]"
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
		}

		static Delegate cb_getLang;
#pragma warning disable 0169
		static Delegate GetGetLangHandler ()
		{
			if (cb_getLang == null)
				cb_getLang = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLang);
			return cb_getLang;
		}

		static IntPtr n_GetLang (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Commons.Codec.Language.BM.PhoneticEngine __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.PhoneticEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Lang);
		}
#pragma warning restore 0169

		static IntPtr id_getLang;
		public virtual unsafe global::Org.Apache.Commons.Codec.Language.BM.Lang Lang {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='PhoneticEngine']/method[@name='getLang' and count(parameter)=0]"
			[Register ("getLang", "()Lorg/apache/commons/codec/language/bm/Lang;", "GetGetLangHandler")]
			get {
				if (id_getLang == IntPtr.Zero)
					id_getLang = JNIEnv.GetMethodID (class_ref, "getLang", "()Lorg/apache/commons/codec/language/bm/Lang;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Lang> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLang), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Lang> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLang", "()Lorg/apache/commons/codec/language/bm/Lang;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxPhonemes;
#pragma warning disable 0169
		static Delegate GetGetMaxPhonemesHandler ()
		{
			if (cb_getMaxPhonemes == null)
				cb_getMaxPhonemes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxPhonemes);
			return cb_getMaxPhonemes;
		}

		static int n_GetMaxPhonemes (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Commons.Codec.Language.BM.PhoneticEngine __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.PhoneticEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxPhonemes;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxPhonemes;
		public virtual unsafe int MaxPhonemes {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='PhoneticEngine']/method[@name='getMaxPhonemes' and count(parameter)=0]"
			[Register ("getMaxPhonemes", "()I", "GetGetMaxPhonemesHandler")]
			get {
				if (id_getMaxPhonemes == IntPtr.Zero)
					id_getMaxPhonemes = JNIEnv.GetMethodID (class_ref, "getMaxPhonemes", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxPhonemes);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxPhonemes", "()I"));
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
			global::Org.Apache.Commons.Codec.Language.BM.PhoneticEngine __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.PhoneticEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NameType);
		}
#pragma warning restore 0169

		static IntPtr id_getNameType;
		public virtual unsafe global::Org.Apache.Commons.Codec.Language.BM.NameType NameType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='PhoneticEngine']/method[@name='getNameType' and count(parameter)=0]"
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
			global::Org.Apache.Commons.Codec.Language.BM.PhoneticEngine __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.PhoneticEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RuleType);
		}
#pragma warning restore 0169

		static IntPtr id_getRuleType;
		public virtual unsafe global::Org.Apache.Commons.Codec.Language.BM.RuleType RuleType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='PhoneticEngine']/method[@name='getRuleType' and count(parameter)=0]"
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
		}

		static Delegate cb_encode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_lang_String_Handler ()
		{
			if (cb_encode_Ljava_lang_String_ == null)
				cb_encode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Encode_Ljava_lang_String_);
			return cb_encode_Ljava_lang_String_;
		}

		static IntPtr n_Encode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_input)
		{
			global::Org.Apache.Commons.Codec.Language.BM.PhoneticEngine __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.PhoneticEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string input = JNIEnv.GetString (native_input, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Encode (input));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='PhoneticEngine']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encode", "(Ljava/lang/String;)Ljava/lang/String;", "GetEncode_Ljava_lang_String_Handler")]
		public virtual unsafe string Encode (string input)
		{
			if (id_encode_Ljava_lang_String_ == IntPtr.Zero)
				id_encode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static Delegate cb_encode_Ljava_lang_String_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_lang_String_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_Handler ()
		{
			if (cb_encode_Ljava_lang_String_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ == null)
				cb_encode_Ljava_lang_String_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Encode_Ljava_lang_String_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_);
			return cb_encode_Ljava_lang_String_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_;
		}

		static IntPtr n_Encode_Ljava_lang_String_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_input, IntPtr native_languageSet)
		{
			global::Org.Apache.Commons.Codec.Language.BM.PhoneticEngine __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.PhoneticEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string input = JNIEnv.GetString (native_input, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet languageSet = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet> (native_languageSet, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Encode (input, languageSet));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_String_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='PhoneticEngine']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.apache.commons.codec.language.bm.Languages.LanguageSet']]"
		[Register ("encode", "(Ljava/lang/String;Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)Ljava/lang/String;", "GetEncode_Ljava_lang_String_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_Handler")]
		public virtual unsafe string Encode (string input, global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet languageSet)
		{
			if (id_encode_Ljava_lang_String_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ == IntPtr.Zero)
				id_encode_Ljava_lang_String_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/String;Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)Ljava/lang/String;");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_input);
				__args [1] = new JValue (languageSet);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_lang_String_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/lang/String;Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

	}
}
