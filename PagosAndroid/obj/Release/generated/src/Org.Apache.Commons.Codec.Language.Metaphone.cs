using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Language {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='Metaphone']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/language/Metaphone", DoNotGenerateAcw=true)]
	public partial class Metaphone : global::Java.Lang.Object, global::Org.Apache.Commons.Codec.IStringEncoder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/language/Metaphone", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Metaphone); }
		}

		protected Metaphone (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='Metaphone']/constructor[@name='Metaphone' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Metaphone ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Metaphone)) {
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

		static Delegate cb_getMaxCodeLen;
#pragma warning disable 0169
		static Delegate GetGetMaxCodeLenHandler ()
		{
			if (cb_getMaxCodeLen == null)
				cb_getMaxCodeLen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxCodeLen);
			return cb_getMaxCodeLen;
		}

		static int n_GetMaxCodeLen (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Commons.Codec.Language.Metaphone __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.Metaphone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxCodeLen;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxCodeLen_I;
#pragma warning disable 0169
		static Delegate GetSetMaxCodeLen_IHandler ()
		{
			if (cb_setMaxCodeLen_I == null)
				cb_setMaxCodeLen_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxCodeLen_I);
			return cb_setMaxCodeLen_I;
		}

		static void n_SetMaxCodeLen_I (IntPtr jnienv, IntPtr native__this, int maxCodeLen)
		{
			global::Org.Apache.Commons.Codec.Language.Metaphone __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.Metaphone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxCodeLen = maxCodeLen;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxCodeLen;
		static IntPtr id_setMaxCodeLen_I;
		public virtual unsafe int MaxCodeLen {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='Metaphone']/method[@name='getMaxCodeLen' and count(parameter)=0]"
			[Register ("getMaxCodeLen", "()I", "GetGetMaxCodeLenHandler")]
			get {
				if (id_getMaxCodeLen == IntPtr.Zero)
					id_getMaxCodeLen = JNIEnv.GetMethodID (class_ref, "getMaxCodeLen", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxCodeLen);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxCodeLen", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='Metaphone']/method[@name='setMaxCodeLen' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxCodeLen", "(I)V", "GetSetMaxCodeLen_IHandler")]
			set {
				if (id_setMaxCodeLen_I == IntPtr.Zero)
					id_setMaxCodeLen_I = JNIEnv.GetMethodID (class_ref, "setMaxCodeLen", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaxCodeLen_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxCodeLen", "(I)V"), __args);
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

		static IntPtr n_Encode_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			global::Org.Apache.Commons.Codec.Language.Metaphone __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.Metaphone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Encode (obj));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='Metaphone']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("encode", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetEncode_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object Encode (global::Java.Lang.Object obj)
		{
			if (id_encode_Ljava_lang_Object_ == IntPtr.Zero)
				id_encode_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/Object;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);

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

		static IntPtr n_Encode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str)
		{
			global::Org.Apache.Commons.Codec.Language.Metaphone __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.Metaphone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Encode (str));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='Metaphone']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encode", "(Ljava/lang/String;)Ljava/lang/String;", "GetEncode_Ljava_lang_String_Handler")]
		public virtual unsafe string Encode (string str)
		{
			if (id_encode_Ljava_lang_String_ == IntPtr.Zero)
				id_encode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static Delegate cb_isMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_isMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_isMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_IsMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_);
			return cb_isMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_IsMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str1, IntPtr native_str2)
		{
			global::Org.Apache.Commons.Codec.Language.Metaphone __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.Metaphone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string str1 = JNIEnv.GetString (native_str1, JniHandleOwnership.DoNotTransfer);
			string str2 = JNIEnv.GetString (native_str2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsMetaphoneEqual (str1, str2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='Metaphone']/method[@name='isMetaphoneEqual' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("isMetaphoneEqual", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetIsMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsMetaphoneEqual (string str1, string str2)
		{
			if (id_isMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_isMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isMetaphoneEqual", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_str1 = JNIEnv.NewString (str1);
			IntPtr native_str2 = JNIEnv.NewString (str2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str1);
				__args [1] = new JValue (native_str2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMetaphoneEqual", "(Ljava/lang/String;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str1);
				JNIEnv.DeleteLocalRef (native_str2);
			}
		}

		static Delegate cb_metaphone_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokeMetaphone_Ljava_lang_String_Handler ()
		{
			if (cb_metaphone_Ljava_lang_String_ == null)
				cb_metaphone_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeMetaphone_Ljava_lang_String_);
			return cb_metaphone_Ljava_lang_String_;
		}

		static IntPtr n_InvokeMetaphone_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_txt)
		{
			global::Org.Apache.Commons.Codec.Language.Metaphone __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.Language.Metaphone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string txt = JNIEnv.GetString (native_txt, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.InvokeMetaphone (txt));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_metaphone_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.language']/class[@name='Metaphone']/method[@name='metaphone' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("metaphone", "(Ljava/lang/String;)Ljava/lang/String;", "GetInvokeMetaphone_Ljava_lang_String_Handler")]
		public virtual unsafe string InvokeMetaphone (string txt)
		{
			if (id_metaphone_Ljava_lang_String_ == IntPtr.Zero)
				id_metaphone_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "metaphone", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_txt = JNIEnv.NewString (txt);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_txt);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_metaphone_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "metaphone", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_txt);
			}
		}

	}
}
