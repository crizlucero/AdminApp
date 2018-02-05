using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Language.BM {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/language/bm/Languages", DoNotGenerateAcw=true)]
	public partial class Languages : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages']/field[@name='ANY']"
		[Register ("ANY")]
		public const string Any = (string) "any";

		static IntPtr ANY_LANGUAGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages']/field[@name='ANY_LANGUAGE']"
		[Register ("ANY_LANGUAGE")]
		public static global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet AnyLanguage {
			get {
				if (ANY_LANGUAGE_jfieldId == IntPtr.Zero)
					ANY_LANGUAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ANY_LANGUAGE", "Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ANY_LANGUAGE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NO_LANGUAGES_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages']/field[@name='NO_LANGUAGES']"
		[Register ("NO_LANGUAGES")]
		public static global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet NoLanguages {
			get {
				if (NO_LANGUAGES_jfieldId == IntPtr.Zero)
					NO_LANGUAGES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_LANGUAGES", "Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_LANGUAGES_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages.LanguageSet']"
		[global::Android.Runtime.Register ("org/apache/commons/codec/language/bm/Languages$LanguageSet", DoNotGenerateAcw=true)]
		public abstract partial class LanguageSet : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/apache/commons/codec/language/bm/Languages$LanguageSet", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LanguageSet); }
			}

			protected LanguageSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages.LanguageSet']/constructor[@name='Languages.LanguageSet' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe LanguageSet ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (LanguageSet)) {
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

			static Delegate cb_getAny;
#pragma warning disable 0169
			static Delegate GetGetAnyHandler ()
			{
				if (cb_getAny == null)
					cb_getAny = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAny);
				return cb_getAny;
			}

			static IntPtr n_GetAny (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Any);
			}
#pragma warning restore 0169

			public abstract string Any {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages.LanguageSet']/method[@name='getAny' and count(parameter)=0]"
				[Register ("getAny", "()Ljava/lang/String;", "GetGetAnyHandler")] get;
			}

			static Delegate cb_isEmpty;
#pragma warning disable 0169
			static Delegate GetIsEmptyHandler ()
			{
				if (cb_isEmpty == null)
					cb_isEmpty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEmpty);
				return cb_isEmpty;
			}

			static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsEmpty;
			}
#pragma warning restore 0169

			public abstract bool IsEmpty {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages.LanguageSet']/method[@name='isEmpty' and count(parameter)=0]"
				[Register ("isEmpty", "()Z", "GetIsEmptyHandler")] get;
			}

			static Delegate cb_isSingleton;
#pragma warning disable 0169
			static Delegate GetIsSingletonHandler ()
			{
				if (cb_isSingleton == null)
					cb_isSingleton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSingleton);
				return cb_isSingleton;
			}

			static bool n_IsSingleton (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsSingleton;
			}
#pragma warning restore 0169

			public abstract bool IsSingleton {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages.LanguageSet']/method[@name='isSingleton' and count(parameter)=0]"
				[Register ("isSingleton", "()Z", "GetIsSingletonHandler")] get;
			}

			static Delegate cb_contains_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetContains_Ljava_lang_String_Handler ()
			{
				if (cb_contains_Ljava_lang_String_ == null)
					cb_contains_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Contains_Ljava_lang_String_);
				return cb_contains_Ljava_lang_String_;
			}

			static bool n_Contains_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Contains (p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages.LanguageSet']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("contains", "(Ljava/lang/String;)Z", "GetContains_Ljava_lang_String_Handler")]
			public abstract bool Contains (string p0);

			static IntPtr id_from_Ljava_util_Set_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages.LanguageSet']/method[@name='from' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;']]"
			[Register ("from", "(Ljava/util/Set;)Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;", "")]
			public static unsafe global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet From (global::System.Collections.Generic.ICollection<string> langs)
			{
				if (id_from_Ljava_util_Set_ == IntPtr.Zero)
					id_from_Ljava_util_Set_ = JNIEnv.GetStaticMethodID (class_ref, "from", "(Ljava/util/Set;)Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;");
				IntPtr native_langs = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (langs);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_langs);
					global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_from_Ljava_util_Set_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_langs);
				}
			}

			static Delegate cb_restrictTo_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_;
#pragma warning disable 0169
			static Delegate GetRestrictTo_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_Handler ()
			{
				if (cb_restrictTo_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ == null)
					cb_restrictTo_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RestrictTo_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_);
				return cb_restrictTo_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_;
			}

			static IntPtr n_RestrictTo_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet p0 = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RestrictTo (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages.LanguageSet']/method[@name='restrictTo' and count(parameter)=1 and parameter[1][@type='org.apache.commons.codec.language.bm.Languages.LanguageSet']]"
			[Register ("restrictTo", "(Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;", "GetRestrictTo_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_Handler")]
			public abstract global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet RestrictTo (global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet p0);

		}

		[global::Android.Runtime.Register ("org/apache/commons/codec/language/bm/Languages$LanguageSet", DoNotGenerateAcw=true)]
		internal partial class LanguageSetInvoker : LanguageSet {

			public LanguageSetInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (LanguageSetInvoker); }
			}

			static IntPtr id_getAny;
			public override unsafe string Any {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages.LanguageSet']/method[@name='getAny' and count(parameter)=0]"
				[Register ("getAny", "()Ljava/lang/String;", "GetGetAnyHandler")]
				get {
					if (id_getAny == IntPtr.Zero)
						id_getAny = JNIEnv.GetMethodID (class_ref, "getAny", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAny), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_isEmpty;
			public override unsafe bool IsEmpty {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages.LanguageSet']/method[@name='isEmpty' and count(parameter)=0]"
				[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
				get {
					if (id_isEmpty == IntPtr.Zero)
						id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
					try {
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEmpty);
					} finally {
					}
				}
			}

			static IntPtr id_isSingleton;
			public override unsafe bool IsSingleton {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages.LanguageSet']/method[@name='isSingleton' and count(parameter)=0]"
				[Register ("isSingleton", "()Z", "GetIsSingletonHandler")]
				get {
					if (id_isSingleton == IntPtr.Zero)
						id_isSingleton = JNIEnv.GetMethodID (class_ref, "isSingleton", "()Z");
					try {
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSingleton);
					} finally {
					}
				}
			}

			static IntPtr id_contains_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages.LanguageSet']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("contains", "(Ljava/lang/String;)Z", "GetContains_Ljava_lang_String_Handler")]
			public override unsafe bool Contains (string p0)
			{
				if (id_contains_Ljava_lang_String_ == IntPtr.Zero)
					id_contains_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "contains", "(Ljava/lang/String;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_contains_Ljava_lang_String_, __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_restrictTo_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages.LanguageSet']/method[@name='restrictTo' and count(parameter)=1 and parameter[1][@type='org.apache.commons.codec.language.bm.Languages.LanguageSet']]"
			[Register ("restrictTo", "(Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;", "GetRestrictTo_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_Handler")]
			public override unsafe global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet RestrictTo (global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet p0)
			{
				if (id_restrictTo_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ == IntPtr.Zero)
					id_restrictTo_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ = JNIEnv.GetMethodID (class_ref, "restrictTo", "(Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_restrictTo_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages.SomeLanguages']"
		[global::Android.Runtime.Register ("org/apache/commons/codec/language/bm/Languages$SomeLanguages", DoNotGenerateAcw=true)]
		public sealed partial class SomeLanguages : global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/apache/commons/codec/language/bm/Languages$SomeLanguages", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SomeLanguages); }
			}

			internal SomeLanguages (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getAny;
			public override unsafe string Any {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages.SomeLanguages']/method[@name='getAny' and count(parameter)=0]"
				[Register ("getAny", "()Ljava/lang/String;", "GetGetAnyHandler")]
				get {
					if (id_getAny == IntPtr.Zero)
						id_getAny = JNIEnv.GetMethodID (class_ref, "getAny", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAny), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_isEmpty;
			public override unsafe bool IsEmpty {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages.SomeLanguages']/method[@name='isEmpty' and count(parameter)=0]"
				[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
				get {
					if (id_isEmpty == IntPtr.Zero)
						id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
					try {
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEmpty);
					} finally {
					}
				}
			}

			static IntPtr id_isSingleton;
			public override unsafe bool IsSingleton {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages.SomeLanguages']/method[@name='isSingleton' and count(parameter)=0]"
				[Register ("isSingleton", "()Z", "GetIsSingletonHandler")]
				get {
					if (id_isSingleton == IntPtr.Zero)
						id_isSingleton = JNIEnv.GetMethodID (class_ref, "isSingleton", "()Z");
					try {
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSingleton);
					} finally {
					}
				}
			}

			static IntPtr id_getLanguages;
			public unsafe global::System.Collections.Generic.ICollection<string> Languages {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages.SomeLanguages']/method[@name='getLanguages' and count(parameter)=0]"
				[Register ("getLanguages", "()Ljava/util/Set;", "GetGetLanguagesHandler")]
				get {
					if (id_getLanguages == IntPtr.Zero)
						id_getLanguages = JNIEnv.GetMethodID (class_ref, "getLanguages", "()Ljava/util/Set;");
					try {
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLanguages), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_contains_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages.SomeLanguages']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("contains", "(Ljava/lang/String;)Z", "")]
			public override unsafe bool Contains (string language)
			{
				if (id_contains_Ljava_lang_String_ == IntPtr.Zero)
					id_contains_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "contains", "(Ljava/lang/String;)Z");
				IntPtr native_language = JNIEnv.NewString (language);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_language);
					bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_contains_Ljava_lang_String_, __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_language);
				}
			}

			static IntPtr id_merge_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages.SomeLanguages']/method[@name='merge' and count(parameter)=1 and parameter[1][@type='org.apache.commons.codec.language.bm.Languages.LanguageSet']]"
			[Register ("merge", "(Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;", "")]
			public unsafe global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet Merge (global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet other)
			{
				if (id_merge_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ == IntPtr.Zero)
					id_merge_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ = JNIEnv.GetMethodID (class_ref, "merge", "(Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (other);
					global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_merge_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_restrictTo_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages.SomeLanguages']/method[@name='restrictTo' and count(parameter)=1 and parameter[1][@type='org.apache.commons.codec.language.bm.Languages.LanguageSet']]"
			[Register ("restrictTo", "(Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;", "")]
			public override unsafe global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet RestrictTo (global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet other)
			{
				if (id_restrictTo_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ == IntPtr.Zero)
					id_restrictTo_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_ = JNIEnv.GetMethodID (class_ref, "restrictTo", "(Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;)Lorg/apache/commons/codec/language/bm/Languages$LanguageSet;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (other);
					global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Languages.LanguageSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_restrictTo_Lorg_apache_commons_codec_language_bm_Languages_LanguageSet_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/language/bm/Languages", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Languages); }
		}

		protected Languages (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getInstance", "(Ljava/lang/String;)Lorg/apache/commons/codec/language/bm/Languages;", "")]
		public static unsafe global::Org.Apache.Commons.Codec.Language.BM.Languages GetInstance (string languagesResourceName)
		{
			if (id_getInstance_Ljava_lang_String_ == IntPtr.Zero)
				id_getInstance_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Ljava/lang/String;)Lorg/apache/commons/codec/language/bm/Languages;");
			IntPtr native_languagesResourceName = JNIEnv.NewString (languagesResourceName);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_languagesResourceName);
				global::Org.Apache.Commons.Codec.Language.BM.Languages __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Languages> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_languagesResourceName);
			}
		}

		static IntPtr id_getInstance_Lorg_apache_commons_codec_language_bm_NameType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='org.apache.commons.codec.language.bm.NameType']]"
		[Register ("getInstance", "(Lorg/apache/commons/codec/language/bm/NameType;)Lorg/apache/commons/codec/language/bm/Languages;", "")]
		public static unsafe global::Org.Apache.Commons.Codec.Language.BM.Languages GetInstance (global::Org.Apache.Commons.Codec.Language.BM.NameType nameType)
		{
			if (id_getInstance_Lorg_apache_commons_codec_language_bm_NameType_ == IntPtr.Zero)
				id_getInstance_Lorg_apache_commons_codec_language_bm_NameType_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Lorg/apache/commons/codec/language/bm/NameType;)Lorg/apache/commons/codec/language/bm/Languages;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (nameType);
				global::Org.Apache.Commons.Codec.Language.BM.Languages __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Languages> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Lorg_apache_commons_codec_language_bm_NameType_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getLanguages;
#pragma warning disable 0169
		static Delegate GetGetLanguagesHandler ()
		{
			if (cb_getLanguages == null)
				cb_getLanguages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLanguages);
			return cb_getLanguages;
		}

		static IntPtr n_GetLanguages (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Commons.Codec.Language.BM.Languages __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.Languages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.GetLanguages ());
		}
#pragma warning restore 0169

		static IntPtr id_getLanguages;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='Languages']/method[@name='getLanguages' and count(parameter)=0]"
		[Register ("getLanguages", "()Ljava/util/Set;", "GetGetLanguagesHandler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<string> GetLanguages ()
		{
			if (id_getLanguages == IntPtr.Zero)
				id_getLanguages = JNIEnv.GetMethodID (class_ref, "getLanguages", "()Ljava/util/Set;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLanguages), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLanguages", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
