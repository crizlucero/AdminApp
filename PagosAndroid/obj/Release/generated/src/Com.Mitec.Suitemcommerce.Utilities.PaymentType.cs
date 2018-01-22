using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mitec.Suitemcommerce.Utilities {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='PaymentType']"
	[global::Android.Runtime.Register ("com/mitec/suitemcommerce/utilities/PaymentType", DoNotGenerateAcw=true)]
	public sealed partial class PaymentType : global::Java.Lang.Enum {


		static IntPtr C_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='PaymentType']/field[@name='C']"
		[Register ("C")]
		public static global::Com.Mitec.Suitemcommerce.Utilities.PaymentType C {
			get {
				if (C_jfieldId == IntPtr.Zero)
					C_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "C", "Lcom/mitec/suitemcommerce/utilities/PaymentType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, C_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.PaymentType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr to12M_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='PaymentType']/field[@name='to12M']"
		[Register ("to12M")]
		public static global::Com.Mitec.Suitemcommerce.Utilities.PaymentType To12M {
			get {
				if (to12M_jfieldId == IntPtr.Zero)
					to12M_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "to12M", "Lcom/mitec/suitemcommerce/utilities/PaymentType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, to12M_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.PaymentType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr to3M_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='PaymentType']/field[@name='to3M']"
		[Register ("to3M")]
		public static global::Com.Mitec.Suitemcommerce.Utilities.PaymentType To3M {
			get {
				if (to3M_jfieldId == IntPtr.Zero)
					to3M_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "to3M", "Lcom/mitec/suitemcommerce/utilities/PaymentType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, to3M_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.PaymentType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr to6M_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='PaymentType']/field[@name='to6M']"
		[Register ("to6M")]
		public static global::Com.Mitec.Suitemcommerce.Utilities.PaymentType To6M {
			get {
				if (to6M_jfieldId == IntPtr.Zero)
					to6M_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "to6M", "Lcom/mitec/suitemcommerce/utilities/PaymentType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, to6M_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.PaymentType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr to9M_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='PaymentType']/field[@name='to9M']"
		[Register ("to9M")]
		public static global::Com.Mitec.Suitemcommerce.Utilities.PaymentType To9M {
			get {
				if (to9M_jfieldId == IntPtr.Zero)
					to9M_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "to9M", "Lcom/mitec/suitemcommerce/utilities/PaymentType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, to9M_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.PaymentType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mitec/suitemcommerce/utilities/PaymentType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PaymentType); }
		}

		internal PaymentType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getValue;
		public unsafe string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='PaymentType']/method[@name='getValue' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='PaymentType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/mitec/suitemcommerce/utilities/PaymentType;", "")]
		public static unsafe global::Com.Mitec.Suitemcommerce.Utilities.PaymentType ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mitec/suitemcommerce/utilities/PaymentType;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.Mitec.Suitemcommerce.Utilities.PaymentType __ret = global::Java.Lang.Object.GetObject<global::Com.Mitec.Suitemcommerce.Utilities.PaymentType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mitec.suitemcommerce.utilities']/class[@name='PaymentType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/mitec/suitemcommerce/utilities/PaymentType;", "")]
		public static unsafe global::Com.Mitec.Suitemcommerce.Utilities.PaymentType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mitec/suitemcommerce/utilities/PaymentType;");
			try {
				return (global::Com.Mitec.Suitemcommerce.Utilities.PaymentType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mitec.Suitemcommerce.Utilities.PaymentType));
			} finally {
			}
		}

	}
}
