using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Language.BM {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='NameType']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/language/bm/NameType", DoNotGenerateAcw=true)]
	public sealed partial class NameType : global::Java.Lang.Enum {


		static IntPtr ASHKENAZI_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='NameType']/field[@name='ASHKENAZI']"
		[Register ("ASHKENAZI")]
		public static global::Org.Apache.Commons.Codec.Language.BM.NameType Ashkenazi {
			get {
				if (ASHKENAZI_jfieldId == IntPtr.Zero)
					ASHKENAZI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ASHKENAZI", "Lorg/apache/commons/codec/language/bm/NameType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ASHKENAZI_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.NameType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr GENERIC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='NameType']/field[@name='GENERIC']"
		[Register ("GENERIC")]
		public static global::Org.Apache.Commons.Codec.Language.BM.NameType Generic {
			get {
				if (GENERIC_jfieldId == IntPtr.Zero)
					GENERIC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GENERIC", "Lorg/apache/commons/codec/language/bm/NameType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GENERIC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.NameType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SEPHARDIC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='NameType']/field[@name='SEPHARDIC']"
		[Register ("SEPHARDIC")]
		public static global::Org.Apache.Commons.Codec.Language.BM.NameType Sephardic {
			get {
				if (SEPHARDIC_jfieldId == IntPtr.Zero)
					SEPHARDIC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SEPHARDIC", "Lorg/apache/commons/codec/language/bm/NameType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SEPHARDIC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.NameType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/language/bm/NameType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NameType); }
		}

		internal NameType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getName;
		public unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='NameType']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='NameType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/apache/commons/codec/language/bm/NameType;", "")]
		public static unsafe global::Org.Apache.Commons.Codec.Language.BM.NameType ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/apache/commons/codec/language/bm/NameType;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Org.Apache.Commons.Codec.Language.BM.NameType __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.NameType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='NameType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/apache/commons/codec/language/bm/NameType;", "")]
		public static unsafe global::Org.Apache.Commons.Codec.Language.BM.NameType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/apache/commons/codec/language/bm/NameType;");
			try {
				return (global::Org.Apache.Commons.Codec.Language.BM.NameType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Apache.Commons.Codec.Language.BM.NameType));
			} finally {
			}
		}

	}
}
