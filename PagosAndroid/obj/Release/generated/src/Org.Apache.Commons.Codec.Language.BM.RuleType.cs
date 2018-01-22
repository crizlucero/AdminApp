using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Language.BM {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='RuleType']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/language/bm/RuleType", DoNotGenerateAcw=true)]
	public sealed partial class RuleType : global::Java.Lang.Enum {


		static IntPtr APPROX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='RuleType']/field[@name='APPROX']"
		[Register ("APPROX")]
		public static global::Org.Apache.Commons.Codec.Language.BM.RuleType Approx {
			get {
				if (APPROX_jfieldId == IntPtr.Zero)
					APPROX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPROX", "Lorg/apache/commons/codec/language/bm/RuleType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPROX_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.RuleType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXACT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='RuleType']/field[@name='EXACT']"
		[Register ("EXACT")]
		public static global::Org.Apache.Commons.Codec.Language.BM.RuleType Exact {
			get {
				if (EXACT_jfieldId == IntPtr.Zero)
					EXACT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXACT", "Lorg/apache/commons/codec/language/bm/RuleType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXACT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.RuleType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RULES_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='RuleType']/field[@name='RULES']"
		[Register ("RULES")]
		public static global::Org.Apache.Commons.Codec.Language.BM.RuleType Rules {
			get {
				if (RULES_jfieldId == IntPtr.Zero)
					RULES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RULES", "Lorg/apache/commons/codec/language/bm/RuleType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RULES_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.RuleType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/language/bm/RuleType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RuleType); }
		}

		internal RuleType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getName;
		public unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='RuleType']/method[@name='getName' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='RuleType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/apache/commons/codec/language/bm/RuleType;", "")]
		public static unsafe global::Org.Apache.Commons.Codec.Language.BM.RuleType ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/apache/commons/codec/language/bm/RuleType;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Org.Apache.Commons.Codec.Language.BM.RuleType __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.BM.RuleType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language.bm']/class[@name='RuleType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/apache/commons/codec/language/bm/RuleType;", "")]
		public static unsafe global::Org.Apache.Commons.Codec.Language.BM.RuleType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/apache/commons/codec/language/bm/RuleType;");
			try {
				return (global::Org.Apache.Commons.Codec.Language.BM.RuleType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Apache.Commons.Codec.Language.BM.RuleType));
			} finally {
			}
		}

	}
}
