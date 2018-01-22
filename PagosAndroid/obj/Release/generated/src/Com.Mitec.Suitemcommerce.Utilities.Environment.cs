using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mitec.Suitemcommerce.Utilities {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Environment']"
	[global::Android.Runtime.Register ("com/mitec/suitemcommerce/utilities/Environment", DoNotGenerateAcw=true)]
	public sealed partial class Environment : global::Java.Lang.Enum {


		static IntPtr DEV_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Environment']/field[@name='DEV']"
		[Register ("DEV")]
		public static global::Com.Mitec.Suitemcommerce.Utilities.Environment Dev {
			get {
				if (DEV_jfieldId == IntPtr.Zero)
					DEV_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEV", "Lcom/mitec/suitemcommerce/utilities/Environment;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEV_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Environment> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PROD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Environment']/field[@name='PROD']"
		[Register ("PROD")]
		public static global::Com.Mitec.Suitemcommerce.Utilities.Environment Prod {
			get {
				if (PROD_jfieldId == IntPtr.Zero)
					PROD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROD", "Lcom/mitec/suitemcommerce/utilities/Environment;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Environment> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr QA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Environment']/field[@name='QA']"
		[Register ("QA")]
		public static global::Com.Mitec.Suitemcommerce.Utilities.Environment Qa {
			get {
				if (QA_jfieldId == IntPtr.Zero)
					QA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QA", "Lcom/mitec/suitemcommerce/utilities/Environment;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, QA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Environment> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SANDBOX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Environment']/field[@name='SANDBOX']"
		[Register ("SANDBOX")]
		public static global::Com.Mitec.Suitemcommerce.Utilities.Environment Sandbox {
			get {
				if (SANDBOX_jfieldId == IntPtr.Zero)
					SANDBOX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SANDBOX", "Lcom/mitec/suitemcommerce/utilities/Environment;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SANDBOX_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Environment> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mitec/suitemcommerce/utilities/Environment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Environment); }
		}

		internal Environment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Environment']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/mitec/suitemcommerce/utilities/Environment;", "")]
		public static unsafe global::Com.Mitec.Suitemcommerce.Utilities.Environment ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mitec/suitemcommerce/utilities/Environment;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.Mitec.Suitemcommerce.Utilities.Environment __ret = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Environment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Environment']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/mitec/suitemcommerce/utilities/Environment;", "")]
		public static unsafe global::Com.Mitec.Suitemcommerce.Utilities.Environment[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mitec/suitemcommerce/utilities/Environment;");
			try {
				return (global::Com.Mitec.Suitemcommerce.Utilities.Environment[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mitec.Suitemcommerce.Utilities.Environment));
			} finally {
			}
		}

	}
}
