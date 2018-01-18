using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Language.BM {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Lang']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/language/bm/Lang", DoNotGenerateAcw=true)]
	public partial class Lang : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/language/bm/Lang", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Lang); }
		}

		protected Lang (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_guessLanguage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGuessLanguage_Ljava_lang_String_Handler ()
		{
			if (cb_guessLanguage_Ljava_lang_String_ == null)
				cb_guessLanguage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GuessLanguage_Ljava_lang_String_);
			return cb_guessLanguage_Ljava_lang_String_;
		}

		static IntPtr n_GuessLanguage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			global::Org.Apache.Commons.Codec.Language.BM.Lang __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Lang> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GuessLanguage (text));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_guessLanguage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Lang']/method[@name='guessLanguage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("guessLanguage", "(Ljava/lang/String;)Ljava/lang/String;", "GetGuessLanguage_Ljava_lang_String_Handler")]
		public virtual unsafe string GuessLanguage (string text)
		{
			if (id_guessLanguage_Ljava_lang_String_ == IntPtr.Zero)
				id_guessLanguage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "guessLanguage", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_text);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_guessLanguage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "guessLanguage", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		static Delegate cb_guessLanguages_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGuessLanguages_Ljava_lang_String_Handler ()
		{
			if (cb_guessLanguages_Ljava_lang_String_ == null)
				cb_guessLanguages_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GuessLanguages_Ljava_lang_String_);
			return cb_guessLanguages_Ljava_lang_String_;
		}

		static IntPtr n_GuessLanguages_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_input)
		{
			global::Org.Apache.Commons.Codec.Language.BM.Lang __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Lang> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string input = JNIEnv.GetString (native_input, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GuessLanguages (input));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_guessLanguages_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Lang']/method[@name='guessLanguages' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("guessLanguages", "(Ljava/lang/String;)Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;", "GetGuessLanguages_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet GuessLanguages (string input)
		{
			if (id_guessLanguages_Ljava_lang_String_ == IntPtr.Zero)
				id_guessLanguages_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "guessLanguages", "(Ljava/lang/String;)Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;");
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);

				global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_guessLanguages_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "guessLanguages", "(Ljava/lang/String;)Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_instance_Lorg_apache_commons_codec_language_bm_NameType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Lang']/method[@name='instance' and count(parameter)=1 and parameter[1][@type='org.apache.commons.codec.language.bm.NameType']]"
		[Register ("instance", "(Lorg/apache/commons/codec/language/bm/NameType;)Lorg/apache/commons/codec/language/bm/Lang;", "")]
		public static unsafe global::Org.Apache.Commons.Codec.Language.BM.Lang Instance (global::Org.Apache.Commons.Codec.Language.BM.NameType nameType)
		{
			if (id_instance_Lorg_apache_commons_codec_language_bm_NameType_ == IntPtr.Zero)
				id_instance_Lorg_apache_commons_codec_language_bm_NameType_ = JNIEnv.GetStaticMethodID (class_ref, "instance", "(Lorg/apache/commons/codec/language/bm/NameType;)Lorg/apache/commons/codec/language/bm/Lang;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (nameType);
				global::Org.Apache.Commons.Codec.Language.BM.Lang __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Lang> (JNIEnv.CallStaticObjectMethod  (class_ref, id_instance_Lorg_apache_commons_codec_language_bm_NameType_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_loadFromResource_Ljava_lang_String_Lorg_apache_commons_codec_language_bm_Languages_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Lang']/method[@name='loadFromResource' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.apache.commons.codec.language.bm.Languages']]"
		[Register ("loadFromResource", "(Ljava/lang/String;Lorg/apache/commons/codec/language/bm/Languages;)Lorg/apache/commons/codec/language/bm/Lang;", "")]
		public static unsafe global::Org.Apache.Commons.Codec.Language.BM.Lang LoadFromResource (string languageRulesResourceName, global::Org.Apache.Commons.Codec.Language.BM.Languages languages)
		{
			if (id_loadFromResource_Ljava_lang_String_Lorg_apache_commons_codec_language_bm_Languages_ == IntPtr.Zero)
				id_loadFromResource_Ljava_lang_String_Lorg_apache_commons_codec_language_bm_Languages_ = JNIEnv.GetStaticMethodID (class_ref, "loadFromResource", "(Ljava/lang/String;Lorg/apache/commons/codec/language/bm/Languages;)Lorg/apache/commons/codec/language/bm/Lang;");
			IntPtr native_languageRulesResourceName = JNIEnv.NewString (languageRulesResourceName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_languageRulesResourceName);
				__args [1] = new JValue (languages);
				global::Org.Apache.Commons.Codec.Language.BM.Lang __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Lang> (JNIEnv.CallStaticObjectMethod  (class_ref, id_loadFromResource_Ljava_lang_String_Lorg_apache_commons_codec_language_bm_Languages_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_languageRulesResourceName);
			}
		}

	}
}
