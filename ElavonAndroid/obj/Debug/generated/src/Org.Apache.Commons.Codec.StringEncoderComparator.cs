using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec']/class[@name='StringEncoderComparator']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/StringEncoderComparator", DoNotGenerateAcw=true)]
	public partial class StringEncoderComparator : global::Java.Lang.Object, global::Java.Util.IComparator {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/StringEncoderComparator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StringEncoderComparator); }
		}

		protected StringEncoderComparator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec']/class[@name='StringEncoderComparator']/constructor[@name='StringEncoderComparator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StringEncoderComparator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (StringEncoderComparator)) {
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

		static IntPtr id_ctor_Lorg_apache_commons_codec_StringEncoder_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec']/class[@name='StringEncoderComparator']/constructor[@name='StringEncoderComparator' and count(parameter)=1 and parameter[1][@type='org.apache.commons.codec.StringEncoder']]"
		[Register (".ctor", "(Lorg/apache/commons/codec/StringEncoder;)V", "")]
		public unsafe StringEncoderComparator (global::Org.Apache.Commons.Codec.IStringEncoder stringEncoder)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (stringEncoder);
				if (((object) this).GetType () != typeof (StringEncoderComparator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/apache/commons/codec/StringEncoder;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/apache/commons/codec/StringEncoder;)V", __args);
					return;
				}

				if (id_ctor_Lorg_apache_commons_codec_StringEncoder_ == IntPtr.Zero)
					id_ctor_Lorg_apache_commons_codec_StringEncoder_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/commons/codec/StringEncoder;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_commons_codec_StringEncoder_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_apache_commons_codec_StringEncoder_, __args);
			} finally {
			}
		}

		static Delegate cb_compare_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCompare_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_compare_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_compare_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Compare_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_compare_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static int n_Compare_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o1, IntPtr native_o2)
		{
			global::Org.Apache.Commons.Codec.StringEncoderComparator __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Codec.StringEncoderComparator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object o1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_o1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object o2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_o2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Compare (o1, o2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compare_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec']/class[@name='StringEncoderComparator']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("compare", "(Ljava/lang/Object;Ljava/lang/Object;)I", "GetCompare_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe int Compare (global::Java.Lang.Object o1, global::Java.Lang.Object o2)
		{
			if (id_compare_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_compare_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (o1);
				__args [1] = new JValue (o2);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_compare_Ljava_lang_Object_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
