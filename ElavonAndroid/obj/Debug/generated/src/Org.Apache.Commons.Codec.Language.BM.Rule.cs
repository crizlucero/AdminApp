using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Language.BM {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Rule']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/language/bm/Rule", DoNotGenerateAcw=true)]
	public partial class Rule : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Rule']/field[@name='ALL']"
		[Register ("ALL")]
		public const string All = (string) "ALL";

		static IntPtr ALL_STRINGS_RMATCHER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Rule']/field[@name='ALL_STRINGS_RMATCHER']"
		[Register ("ALL_STRINGS_RMATCHER")]
		public static global::Org.Apache.Commons.Codec.Language.BM.Rule.IRPattern AllStringsRmatcher {
			get {
				if (ALL_STRINGS_RMATCHER_jfieldId == IntPtr.Zero)
					ALL_STRINGS_RMATCHER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL_STRINGS_RMATCHER", "Lorg/apache/commons/codec/language/bm/Rule$RPattern;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALL_STRINGS_RMATCHER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Rule.IRPattern> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Rule.Phoneme']"
		[global::Android.Runtime.Register ("org/apache/commons/codec/language/bm/Rule$Phoneme", DoNotGenerateAcw=true)]
		public sealed partial class Phoneme : global::Java.Lang.Object, global::Org.Apache.Commons.Codec.Language.BM.Rule.IPhonemeExpr {


			static IntPtr COMPARATOR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Rule.Phoneme']/field[@name='COMPARATOR']"
			[Register ("COMPARATOR")]
			public static global::Java.Util.IComparator Comparator {
				get {
					if (COMPARATOR_jfieldId == IntPtr.Zero)
						COMPARATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPARATOR", "Ljava/util/Comparator;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPARATOR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/apache/commons/codec/language/bm/Rule$Phoneme", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Phoneme); }
			}

			internal Phoneme (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_CharSequence_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Rule.Phoneme']/constructor[@name='Rule.Phoneme' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='org.apache.commons.codec.language.bm.Languages.LanguageSet']]"
			[Register (".ctor", "(Ljava/lang/CharSequence;Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)V", "")]
			public unsafe Phoneme (global::Java.Lang.ICharSequence phonemeText, global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet languages)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_phonemeText = CharSequence.ToLocalJniHandle (phonemeText);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_phonemeText);
					__args [1] = new JValue (languages);
					if (((object) this).GetType () != typeof (Phoneme)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/CharSequence;Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/CharSequence;Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_CharSequence_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ == IntPtr.Zero)
						id_ctor_Ljava_lang_CharSequence_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/CharSequence;Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_CharSequence_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_CharSequence_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_phonemeText);
				}
			}

			[Register (".ctor", "(Ljava/lang/CharSequence;Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)V", "")]
			public unsafe Phoneme (string phonemeText, global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet languages)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_phonemeText = CharSequence.ToLocalJniHandle (phonemeText);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_phonemeText);
					__args [1] = new JValue (languages);
					if (((object) this).GetType () != typeof (Phoneme)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/CharSequence;Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/CharSequence;Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_CharSequence_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ == IntPtr.Zero)
						id_ctor_Ljava_lang_CharSequence_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/CharSequence;Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_CharSequence_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_CharSequence_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_phonemeText);
				}
			}

			static IntPtr id_ctor_Lorg_apache_commons_codec_language_bm_Rule_Phoneme_Lorg_apache_commons_codec_language_bm_Rule_Phoneme_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Rule.Phoneme']/constructor[@name='Rule.Phoneme' and count(parameter)=2 and parameter[1][@type='org.apache.commons.codec.language.bm.Rule.Phoneme'] and parameter[2][@type='org.apache.commons.codec.language.bm.Rule.Phoneme']]"
			[Register (".ctor", "(Lorg/apache/commons/codec/language/bm/Rule$Phoneme;Lorg/apache/commons/codec/language/bm/Rule$Phoneme;)V", "")]
			public unsafe Phoneme (global::Org.Apache.Commons.Codec.Language.BM.Rule.Phoneme phonemeLeft, global::Org.Apache.Commons.Codec.Language.BM.Rule.Phoneme phonemeRight)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (phonemeLeft);
					__args [1] = new JValue (phonemeRight);
					if (((object) this).GetType () != typeof (Phoneme)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/apache/commons/codec/language/bm/Rule$Phoneme;Lorg/apache/commons/codec/language/bm/Rule$Phoneme;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/apache/commons/codec/language/bm/Rule$Phoneme;Lorg/apache/commons/codec/language/bm/Rule$Phoneme;)V", __args);
						return;
					}

					if (id_ctor_Lorg_apache_commons_codec_language_bm_Rule_Phoneme_Lorg_apache_commons_codec_language_bm_Rule_Phoneme_ == IntPtr.Zero)
						id_ctor_Lorg_apache_commons_codec_language_bm_Rule_Phoneme_Lorg_apache_commons_codec_language_bm_Rule_Phoneme_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/commons/codec/language/bm/Rule$Phoneme;Lorg/apache/commons/codec/language/bm/Rule$Phoneme;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_commons_codec_language_bm_Rule_Phoneme_Lorg_apache_commons_codec_language_bm_Rule_Phoneme_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_apache_commons_codec_language_bm_Rule_Phoneme_Lorg_apache_commons_codec_language_bm_Rule_Phoneme_, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_Lorg_apache_commons_codec_language_bm_Rule_Phoneme_Lorg_apache_commons_codec_language_bm_Rule_Phoneme_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Rule.Phoneme']/constructor[@name='Rule.Phoneme' and count(parameter)=3 and parameter[1][@type='org.apache.commons.codec.language.bm.Rule.Phoneme'] and parameter[2][@type='org.apache.commons.codec.language.bm.Rule.Phoneme'] and parameter[3][@type='org.apache.commons.codec.language.bm.Languages.LanguageSet']]"
			[Register (".ctor", "(Lorg/apache/commons/codec/language/bm/Rule$Phoneme;Lorg/apache/commons/codec/language/bm/Rule$Phoneme;Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)V", "")]
			public unsafe Phoneme (global::Org.Apache.Commons.Codec.Language.BM.Rule.Phoneme phonemeLeft, global::Org.Apache.Commons.Codec.Language.BM.Rule.Phoneme phonemeRight, global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet languages)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (phonemeLeft);
					__args [1] = new JValue (phonemeRight);
					__args [2] = new JValue (languages);
					if (((object) this).GetType () != typeof (Phoneme)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/apache/commons/codec/language/bm/Rule$Phoneme;Lorg/apache/commons/codec/language/bm/Rule$Phoneme;Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/apache/commons/codec/language/bm/Rule$Phoneme;Lorg/apache/commons/codec/language/bm/Rule$Phoneme;Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)V", __args);
						return;
					}

					if (id_ctor_Lorg_apache_commons_codec_language_bm_Rule_Phoneme_Lorg_apache_commons_codec_language_bm_Rule_Phoneme_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ == IntPtr.Zero)
						id_ctor_Lorg_apache_commons_codec_language_bm_Rule_Phoneme_Lorg_apache_commons_codec_language_bm_Rule_Phoneme_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/commons/codec/language/bm/Rule$Phoneme;Lorg/apache/commons/codec/language/bm/Rule$Phoneme;Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_commons_codec_language_bm_Rule_Phoneme_Lorg_apache_commons_codec_language_bm_Rule_Phoneme_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_apache_commons_codec_language_bm_Rule_Phoneme_Lorg_apache_commons_codec_language_bm_Rule_Phoneme_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_, __args);
				} finally {
				}
			}

			static IntPtr id_getLanguages;
			public unsafe global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet Languages {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Rule.Phoneme']/method[@name='getLanguages' and count(parameter)=0]"
				[Register ("getLanguages", "()Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;", "GetGetLanguagesHandler")]
				get {
					if (id_getLanguages == IntPtr.Zero)
						id_getLanguages = JNIEnv.GetMethodID (class_ref, "getLanguages", "()Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;");
					try {
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLanguages), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_getPhonemeText;
			public unsafe global::Java.Lang.ICharSequence PhonemeTextFormatted {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Rule.Phoneme']/method[@name='getPhonemeText' and count(parameter)=0]"
				[Register ("getPhonemeText", "()Ljava/lang/CharSequence;", "GetGetPhonemeTextHandler")]
				get {
					if (id_getPhonemeText == IntPtr.Zero)
						id_getPhonemeText = JNIEnv.GetMethodID (class_ref, "getPhonemeText", "()Ljava/lang/CharSequence;");
					try {
						return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPhonemeText), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public string PhonemeText {
				get { return PhonemeTextFormatted == null ? null : PhonemeTextFormatted.ToString (); }
			}

			static IntPtr id_getPhonemes;
			public unsafe global::Java.Lang.IIterable Phonemes {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Rule.Phoneme']/method[@name='getPhonemes' and count(parameter)=0]"
				[Register ("getPhonemes", "()Ljava/lang/Iterable;", "GetGetPhonemesHandler")]
				get {
					if (id_getPhonemes == IntPtr.Zero)
						id_getPhonemes = JNIEnv.GetMethodID (class_ref, "getPhonemes", "()Ljava/lang/Iterable;");
					try {
						return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPhonemes), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_append_Ljava_lang_CharSequence_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Rule.Phoneme']/method[@name='append' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("append", "(Ljava/lang/CharSequence;)Lorg/apache/commons/codec/language/bm/Rule$Phoneme;", "")]
			public unsafe global::Org.Apache.Commons.Codec.Language.BM.Rule.Phoneme Append (global::Java.Lang.ICharSequence str)
			{
				if (id_append_Ljava_lang_CharSequence_ == IntPtr.Zero)
					id_append_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/CharSequence;)Lorg/apache/commons/codec/language/bm/Rule$Phoneme;");
				IntPtr native_str = CharSequence.ToLocalJniHandle (str);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_str);
					global::Org.Apache.Commons.Codec.Language.BM.Rule.Phoneme __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Rule.Phoneme> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_str);
				}
			}

			public global::Org.Apache.Commons.Codec.Language.BM.Rule.Phoneme Append (string str)
			{
				global::Java.Lang.String jls_str = str == null ? null : new global::Java.Lang.String (str);
				global::Org.Apache.Commons.Codec.Language.BM.Rule.Phoneme __result = Append (jls_str);
				var __rsval = __result;
				jls_str?.Dispose ();
				return __rsval;
			}

			static IntPtr id_join_Lorg_apache_commons_codec_language_bm_Rule_Phoneme_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Rule.Phoneme']/method[@name='join' and count(parameter)=1 and parameter[1][@type='org.apache.commons.codec.language.bm.Rule.Phoneme']]"
			[Obsolete (@"deprecated")]
			[Register ("join", "(Lorg/apache/commons/codec/language/bm/Rule$Phoneme;)Lorg/apache/commons/codec/language/bm/Rule$Phoneme;", "")]
			public unsafe global::Org.Apache.Commons.Codec.Language.BM.Rule.Phoneme Join (global::Org.Apache.Commons.Codec.Language.BM.Rule.Phoneme right)
			{
				if (id_join_Lorg_apache_commons_codec_language_bm_Rule_Phoneme_ == IntPtr.Zero)
					id_join_Lorg_apache_commons_codec_language_bm_Rule_Phoneme_ = JNIEnv.GetMethodID (class_ref, "join", "(Lorg/apache/commons/codec/language/bm/Rule$Phoneme;)Lorg/apache/commons/codec/language/bm/Rule$Phoneme;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (right);
					global::Org.Apache.Commons.Codec.Language.BM.Rule.Phoneme __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Rule.Phoneme> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_join_Lorg_apache_commons_codec_language_bm_Rule_Phoneme_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_mergeWithLanguage_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Rule.Phoneme']/method[@name='mergeWithLanguage' and count(parameter)=1 and parameter[1][@type='org.apache.commons.codec.language.bm.Languages.LanguageSet']]"
			[Register ("mergeWithLanguage", "(Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)Lorg/apache/commons/codec/language/bm/Rule$Phoneme;", "")]
			public unsafe global::Org.Apache.Commons.Codec.Language.BM.Rule.Phoneme MergeWithLanguage (global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet lang)
			{
				if (id_mergeWithLanguage_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ == IntPtr.Zero)
					id_mergeWithLanguage_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ = JNIEnv.GetMethodID (class_ref, "mergeWithLanguage", "(Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)Lorg/apache/commons/codec/language/bm/Rule$Phoneme;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (lang);
					global::Org.Apache.Commons.Codec.Language.BM.Rule.Phoneme __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Rule.Phoneme> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_mergeWithLanguage_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/interface[@name='Rule.PhonemeExpr']"
		[Register ("org/apache/commons/codec/language/bm/Rule$PhonemeExpr", "", "Org.Apache.Commons.Codec.Language.BM.Rule/IPhonemeExprInvoker")]
		public partial interface IPhonemeExpr : IJavaObject {

			global::Java.Lang.IIterable Phonemes {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/interface[@name='Rule.PhonemeExpr']/method[@name='getPhonemes' and count(parameter)=0]"
				[Register ("getPhonemes", "()Ljava/lang/Iterable;", "GetGetPhonemesHandler:Org.Apache.Commons.Codec.Language.BM.Rule/IPhonemeExprInvoker, ElavonAndroid")] get;
			}

		}

		[global::Android.Runtime.Register ("org/apache/commons/codec/language/bm/Rule$PhonemeExpr", DoNotGenerateAcw=true)]
		internal class IPhonemeExprInvoker : global::Java.Lang.Object, IPhonemeExpr {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/apache/commons/codec/language/bm/Rule$PhonemeExpr");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IPhonemeExprInvoker); }
			}

			IntPtr class_ref;

			public static IPhonemeExpr GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPhonemeExpr> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.apache.commons.codec.language.bm.Rule.PhonemeExpr"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPhonemeExprInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getPhonemes;
#pragma warning disable 0169
			static Delegate GetGetPhonemesHandler ()
			{
				if (cb_getPhonemes == null)
					cb_getPhonemes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPhonemes);
				return cb_getPhonemes;
			}

			static IntPtr n_GetPhonemes (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Apache.Commons.Codec.Language.BM.Rule.IPhonemeExpr __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Rule.IPhonemeExpr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Phonemes);
			}
#pragma warning restore 0169

			IntPtr id_getPhonemes;
			public unsafe global::Java.Lang.IIterable Phonemes {
				get {
					if (id_getPhonemes == IntPtr.Zero)
						id_getPhonemes = JNIEnv.GetMethodID (class_ref, "getPhonemes", "()Ljava/lang/Iterable;");
					return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPhonemes), JniHandleOwnership.TransferLocalRef);
				}
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/interface[@name='Rule.RPattern']"
		[Register ("org/apache/commons/codec/language/bm/Rule$RPattern", "", "Org.Apache.Commons.Codec.Language.BM.Rule/IRPatternInvoker")]
		public partial interface IRPattern : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/interface[@name='Rule.RPattern']/method[@name='isMatch' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("isMatch", "(Ljava/lang/CharSequence;)Z", "GetIsMatch_Ljava_lang_CharSequence_Handler:Org.Apache.Commons.Codec.Language.BM.Rule/IRPatternInvoker, ElavonAndroid")]
			bool IsMatch (global::Java.Lang.ICharSequence p0);

		}

		[global::Android.Runtime.Register ("org/apache/commons/codec/language/bm/Rule$RPattern", DoNotGenerateAcw=true)]
		internal class IRPatternInvoker : global::Java.Lang.Object, IRPattern {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/apache/commons/codec/language/bm/Rule$RPattern");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRPatternInvoker); }
			}

			IntPtr class_ref;

			public static IRPattern GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRPattern> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.apache.commons.codec.language.bm.Rule.RPattern"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRPatternInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_isMatch_Ljava_lang_CharSequence_;
#pragma warning disable 0169
			static Delegate GetIsMatch_Ljava_lang_CharSequence_Handler ()
			{
				if (cb_isMatch_Ljava_lang_CharSequence_ == null)
					cb_isMatch_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsMatch_Ljava_lang_CharSequence_);
				return cb_isMatch_Ljava_lang_CharSequence_;
			}

			static bool n_IsMatch_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Apache.Commons.Codec.Language.BM.Rule.IRPattern __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Rule.IRPattern> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.IsMatch (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_isMatch_Ljava_lang_CharSequence_;
			public unsafe bool IsMatch (global::Java.Lang.ICharSequence p0)
			{
				if (id_isMatch_Ljava_lang_CharSequence_ == IntPtr.Zero)
					id_isMatch_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "isMatch", "(Ljava/lang/CharSequence;)Z");
				IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMatch_Ljava_lang_CharSequence_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/language/bm/Rule", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Rule); }
		}

		protected Rule (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_apache_commons_codec_language_bm_Rule_PhonemeExpr_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Rule']/constructor[@name='Rule' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='org.apache.commons.codec.language.bm.Rule.PhonemeExpr']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/apache/commons/codec/language/bm/Rule$PhonemeExpr;)V", "")]
		public unsafe Rule (string pattern, string lContext, string rContext, global::Org.Apache.Commons.Codec.Language.BM.Rule.IPhonemeExpr phoneme)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_pattern = JNIEnv.NewString (pattern);
			IntPtr native_lContext = JNIEnv.NewString (lContext);
			IntPtr native_rContext = JNIEnv.NewString (rContext);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_pattern);
				__args [1] = new JValue (native_lContext);
				__args [2] = new JValue (native_rContext);
				__args [3] = new JValue (phoneme);
				if (((object) this).GetType () != typeof (Rule)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/apache/commons/codec/language/bm/Rule$PhonemeExpr;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/apache/commons/codec/language/bm/Rule$PhonemeExpr;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_apache_commons_codec_language_bm_Rule_PhonemeExpr_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_apache_commons_codec_language_bm_Rule_PhonemeExpr_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/apache/commons/codec/language/bm/Rule$PhonemeExpr;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_apache_commons_codec_language_bm_Rule_PhonemeExpr_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_apache_commons_codec_language_bm_Rule_PhonemeExpr_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
				JNIEnv.DeleteLocalRef (native_lContext);
				JNIEnv.DeleteLocalRef (native_rContext);
			}
		}

		static Delegate cb_getLContext;
#pragma warning disable 0169
		static Delegate GetGetLContextHandler ()
		{
			if (cb_getLContext == null)
				cb_getLContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLContext);
			return cb_getLContext;
		}

		static IntPtr n_GetLContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Commons.Codec.Language.BM.Rule __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Rule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LContext);
		}
#pragma warning restore 0169

		static IntPtr id_getLContext;
		public virtual unsafe global::Org.Apache.Commons.Codec.Language.BM.Rule.IRPattern LContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Rule']/method[@name='getLContext' and count(parameter)=0]"
			[Register ("getLContext", "()Lorg/apache/commons/codec/language/bm/Rule$RPattern;", "GetGetLContextHandler")]
			get {
				if (id_getLContext == IntPtr.Zero)
					id_getLContext = JNIEnv.GetMethodID (class_ref, "getLContext", "()Lorg/apache/commons/codec/language/bm/Rule$RPattern;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Rule.IRPattern> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLContext), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Rule.IRPattern> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLContext", "()Lorg/apache/commons/codec/language/bm/Rule$RPattern;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPattern;
#pragma warning disable 0169
		static Delegate GetGetPatternHandler ()
		{
			if (cb_getPattern == null)
				cb_getPattern = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPattern);
			return cb_getPattern;
		}

		static IntPtr n_GetPattern (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Commons.Codec.Language.BM.Rule __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Rule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Pattern);
		}
#pragma warning restore 0169

		static IntPtr id_getPattern;
		public virtual unsafe string Pattern {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Rule']/method[@name='getPattern' and count(parameter)=0]"
			[Register ("getPattern", "()Ljava/lang/String;", "GetGetPatternHandler")]
			get {
				if (id_getPattern == IntPtr.Zero)
					id_getPattern = JNIEnv.GetMethodID (class_ref, "getPattern", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPattern), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPattern", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRContext;
#pragma warning disable 0169
		static Delegate GetGetRContextHandler ()
		{
			if (cb_getRContext == null)
				cb_getRContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRContext);
			return cb_getRContext;
		}

		static IntPtr n_GetRContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Commons.Codec.Language.BM.Rule __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Rule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RContext);
		}
#pragma warning restore 0169

		static IntPtr id_getRContext;
		public virtual unsafe global::Org.Apache.Commons.Codec.Language.BM.Rule.IRPattern RContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Rule']/method[@name='getRContext' and count(parameter)=0]"
			[Register ("getRContext", "()Lorg/apache/commons/codec/language/bm/Rule$RPattern;", "GetGetRContextHandler")]
			get {
				if (id_getRContext == IntPtr.Zero)
					id_getRContext = JNIEnv.GetMethodID (class_ref, "getRContext", "()Lorg/apache/commons/codec/language/bm/Rule$RPattern;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Rule.IRPattern> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRContext), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Rule.IRPattern> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRContext", "()Lorg/apache/commons/codec/language/bm/Rule$RPattern;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance_Lorg_apache_commons_codec_language_bm_NameType_Lorg_apache_commons_codec_language_bm_RuleType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Rule']/method[@name='getInstance' and count(parameter)=3 and parameter[1][@type='org.apache.commons.codec.language.bm.NameType'] and parameter[2][@type='org.apache.commons.codec.language.bm.RuleType'] and parameter[3][@type='java.lang.String']]"
		[Register ("getInstance", "(Lorg/apache/commons/codec/language/bm/NameType;Lorg/apache/commons/codec/language/bm/RuleType;Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Org.Apache.Commons.Codec.Language.BM.Rule> GetInstance (global::Org.Apache.Commons.Codec.Language.BM.NameType nameType, global::Org.Apache.Commons.Codec.Language.BM.RuleType rt, string lang)
		{
			if (id_getInstance_Lorg_apache_commons_codec_language_bm_NameType_Lorg_apache_commons_codec_language_bm_RuleType_Ljava_lang_String_ == IntPtr.Zero)
				id_getInstance_Lorg_apache_commons_codec_language_bm_NameType_Lorg_apache_commons_codec_language_bm_RuleType_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Lorg/apache/commons/codec/language/bm/NameType;Lorg/apache/commons/codec/language/bm/RuleType;Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_lang = JNIEnv.NewString (lang);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (nameType);
				__args [1] = new JValue (rt);
				__args [2] = new JValue (native_lang);
				global::System.Collections.Generic.IList<global::Org.Apache.Commons.Codec.Language.BM.Rule> __ret = global::Android.Runtime.JavaList<global::Org.Apache.Commons.Codec.Language.BM.Rule>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Lorg_apache_commons_codec_language_bm_NameType_Lorg_apache_commons_codec_language_bm_RuleType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_lang);
			}
		}

		static IntPtr id_getInstance_Lorg_apache_commons_codec_language_bm_NameType_Lorg_apache_commons_codec_language_bm_RuleType_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Rule']/method[@name='getInstance' and count(parameter)=3 and parameter[1][@type='org.apache.commons.codec.language.bm.NameType'] and parameter[2][@type='org.apache.commons.codec.language.bm.RuleType'] and parameter[3][@type='org.apache.commons.codec.language.bm.Languages.LanguageSet']]"
		[Register ("getInstance", "(Lorg/apache/commons/codec/language/bm/NameType;Lorg/apache/commons/codec/language/bm/RuleType;Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Org.Apache.Commons.Codec.Language.BM.Rule> GetInstance (global::Org.Apache.Commons.Codec.Language.BM.NameType nameType, global::Org.Apache.Commons.Codec.Language.BM.RuleType rt, global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet langs)
		{
			if (id_getInstance_Lorg_apache_commons_codec_language_bm_NameType_Lorg_apache_commons_codec_language_bm_RuleType_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ == IntPtr.Zero)
				id_getInstance_Lorg_apache_commons_codec_language_bm_NameType_Lorg_apache_commons_codec_language_bm_RuleType_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Lorg/apache/commons/codec/language/bm/NameType;Lorg/apache/commons/codec/language/bm/RuleType;Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (nameType);
				__args [1] = new JValue (rt);
				__args [2] = new JValue (langs);
				global::System.Collections.Generic.IList<global::Org.Apache.Commons.Codec.Language.BM.Rule> __ret = global::Android.Runtime.JavaList<global::Org.Apache.Commons.Codec.Language.BM.Rule>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Lorg_apache_commons_codec_language_bm_NameType_Lorg_apache_commons_codec_language_bm_RuleType_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getInstanceMap_Lorg_apache_commons_codec_language_bm_NameType_Lorg_apache_commons_codec_language_bm_RuleType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Rule']/method[@name='getInstanceMap' and count(parameter)=3 and parameter[1][@type='org.apache.commons.codec.language.bm.NameType'] and parameter[2][@type='org.apache.commons.codec.language.bm.RuleType'] and parameter[3][@type='java.lang.String']]"
		[Register ("getInstanceMap", "(Lorg/apache/commons/codec/language/bm/NameType;Lorg/apache/commons/codec/language/bm/RuleType;Ljava/lang/String;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<global::Org.Apache.Commons.Codec.Language.BM.Rule>> GetInstanceMap (global::Org.Apache.Commons.Codec.Language.BM.NameType nameType, global::Org.Apache.Commons.Codec.Language.BM.RuleType rt, string lang)
		{
			if (id_getInstanceMap_Lorg_apache_commons_codec_language_bm_NameType_Lorg_apache_commons_codec_language_bm_RuleType_Ljava_lang_String_ == IntPtr.Zero)
				id_getInstanceMap_Lorg_apache_commons_codec_language_bm_NameType_Lorg_apache_commons_codec_language_bm_RuleType_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getInstanceMap", "(Lorg/apache/commons/codec/language/bm/NameType;Lorg/apache/commons/codec/language/bm/RuleType;Ljava/lang/String;)Ljava/util/Map;");
			IntPtr native_lang = JNIEnv.NewString (lang);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (nameType);
				__args [1] = new JValue (rt);
				__args [2] = new JValue (native_lang);
				global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<global::Org.Apache.Commons.Codec.Language.BM.Rule>> __ret = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<global::Org.Apache.Commons.Codec.Language.BM.Rule>>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstanceMap_Lorg_apache_commons_codec_language_bm_NameType_Lorg_apache_commons_codec_language_bm_RuleType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_lang);
			}
		}

		static IntPtr id_getInstanceMap_Lorg_apache_commons_codec_language_bm_NameType_Lorg_apache_commons_codec_language_bm_RuleType_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Rule']/method[@name='getInstanceMap' and count(parameter)=3 and parameter[1][@type='org.apache.commons.codec.language.bm.NameType'] and parameter[2][@type='org.apache.commons.codec.language.bm.RuleType'] and parameter[3][@type='org.apache.commons.codec.language.bm.Languages.LanguageSet']]"
		[Register ("getInstanceMap", "(Lorg/apache/commons/codec/language/bm/NameType;Lorg/apache/commons/codec/language/bm/RuleType;Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<global::Org.Apache.Commons.Codec.Language.BM.Rule>> GetInstanceMap (global::Org.Apache.Commons.Codec.Language.BM.NameType nameType, global::Org.Apache.Commons.Codec.Language.BM.RuleType rt, global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet langs)
		{
			if (id_getInstanceMap_Lorg_apache_commons_codec_language_bm_NameType_Lorg_apache_commons_codec_language_bm_RuleType_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ == IntPtr.Zero)
				id_getInstanceMap_Lorg_apache_commons_codec_language_bm_NameType_Lorg_apache_commons_codec_language_bm_RuleType_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ = JNIEnv.GetStaticMethodID (class_ref, "getInstanceMap", "(Lorg/apache/commons/codec/language/bm/NameType;Lorg/apache/commons/codec/language/bm/RuleType;Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)Ljava/util/Map;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (nameType);
				__args [1] = new JValue (rt);
				__args [2] = new JValue (langs);
				global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<global::Org.Apache.Commons.Codec.Language.BM.Rule>> __ret = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<global::Org.Apache.Commons.Codec.Language.BM.Rule>>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstanceMap_Lorg_apache_commons_codec_language_bm_NameType_Lorg_apache_commons_codec_language_bm_RuleType_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getPhoneme;
#pragma warning disable 0169
		static Delegate GetGetPhonemeHandler ()
		{
			if (cb_getPhoneme == null)
				cb_getPhoneme = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPhoneme);
			return cb_getPhoneme;
		}

		static IntPtr n_GetPhoneme (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Commons.Codec.Language.BM.Rule __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Rule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetPhoneme ());
		}
#pragma warning restore 0169

		static IntPtr id_getPhoneme;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Rule']/method[@name='getPhoneme' and count(parameter)=0]"
		[Register ("getPhoneme", "()Lorg/apache/commons/codec/language/bm/Rule$PhonemeExpr;", "GetGetPhonemeHandler")]
		public virtual unsafe global::Org.Apache.Commons.Codec.Language.BM.Rule.IPhonemeExpr GetPhoneme ()
		{
			if (id_getPhoneme == IntPtr.Zero)
				id_getPhoneme = JNIEnv.GetMethodID (class_ref, "getPhoneme", "()Lorg/apache/commons/codec/language/bm/Rule$PhonemeExpr;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Rule.IPhonemeExpr> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPhoneme), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Rule.IPhonemeExpr> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPhoneme", "()Lorg/apache/commons/codec/language/bm/Rule$PhonemeExpr;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_patternAndContextMatches_Ljava_lang_CharSequence_I;
#pragma warning disable 0169
		static Delegate GetPatternAndContextMatches_Ljava_lang_CharSequence_IHandler ()
		{
			if (cb_patternAndContextMatches_Ljava_lang_CharSequence_I == null)
				cb_patternAndContextMatches_Ljava_lang_CharSequence_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool>) n_PatternAndContextMatches_Ljava_lang_CharSequence_I);
			return cb_patternAndContextMatches_Ljava_lang_CharSequence_I;
		}

		static bool n_PatternAndContextMatches_Ljava_lang_CharSequence_I (IntPtr jnienv, IntPtr native__this, IntPtr native_input, int i)
		{
			global::Org.Apache.Commons.Codec.Language.BM.Rule __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Rule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence input = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_input, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.PatternAndContextMatches (input, i);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_patternAndContextMatches_Ljava_lang_CharSequence_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Rule']/method[@name='patternAndContextMatches' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int']]"
		[Register ("patternAndContextMatches", "(Ljava/lang/CharSequence;I)Z", "GetPatternAndContextMatches_Ljava_lang_CharSequence_IHandler")]
		public virtual unsafe bool PatternAndContextMatches (global::Java.Lang.ICharSequence input, int i)
		{
			if (id_patternAndContextMatches_Ljava_lang_CharSequence_I == IntPtr.Zero)
				id_patternAndContextMatches_Ljava_lang_CharSequence_I = JNIEnv.GetMethodID (class_ref, "patternAndContextMatches", "(Ljava/lang/CharSequence;I)Z");
			IntPtr native_input = CharSequence.ToLocalJniHandle (input);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_input);
				__args [1] = new JValue (i);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_patternAndContextMatches_Ljava_lang_CharSequence_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "patternAndContextMatches", "(Ljava/lang/CharSequence;I)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		public bool PatternAndContextMatches (string input, int i)
		{
			global::Java.Lang.String jls_input = input == null ? null : new global::Java.Lang.String (input);
			bool __result = PatternAndContextMatches (jls_input, i);
			var __rsval = __result;
			jls_input?.Dispose ();
			return __rsval;
		}

	}
	public static partial class RuleIRPatternExtensions {

		public static bool IsMatch (this Org.Apache.Commons.Codec.Language.BM.Rule.IRPattern self, string p0)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			bool __result = self.IsMatch (jls_p0);
			var __rsval = __result;
			jls_p0?.Dispose ();
			return __rsval;
		}
	}

}
