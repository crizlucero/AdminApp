using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mitec.Suitemcommerce.Utilities {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Currency']"
	[global::Android.Runtime.Register ("com/mitec/suitemcommerce/utilities/Currency", DoNotGenerateAcw=true)]
	public sealed partial class Currency : global::Java.Lang.Enum {


		static IntPtr MXN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Currency']/field[@name='MXN']"
		[Register ("MXN")]
		public static global::Com.Mitec.Suitemcommerce.Utilities.Currency Mxn {
			get {
				if (MXN_jfieldId == IntPtr.Zero)
					MXN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MXN", "Lcom/mitec/suitemcommerce/utilities/Currency;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MXN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Currency> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr USD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Currency']/field[@name='USD']"
		[Register ("USD")]
		public static global::Com.Mitec.Suitemcommerce.Utilities.Currency Usd {
			get {
				if (USD_jfieldId == IntPtr.Zero)
					USD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USD", "Lcom/mitec/suitemcommerce/utilities/Currency;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Currency> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mitec/suitemcommerce/utilities/Currency", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Currency); }
		}

		internal Currency (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getValue;
		public unsafe string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Currency']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Currency']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/mitec/suitemcommerce/utilities/Currency;", "")]
		public static unsafe global::Com.Mitec.Suitemcommerce.Utilities.Currency ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mitec/suitemcommerce/utilities/Currency;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.Mitec.Suitemcommerce.Utilities.Currency __ret = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.Currency> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='Currency']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/mitec/suitemcommerce/utilities/Currency;", "")]
		public static unsafe global::Com.Mitec.Suitemcommerce.Utilities.Currency[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mitec/suitemcommerce/utilities/Currency;");
			try {
				return (global::Com.Mitec.Suitemcommerce.Utilities.Currency[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mitec.Suitemcommerce.Utilities.Currency));
			} finally {
			}
		}

	}
}
