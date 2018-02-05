using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Binary {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodecOutputStream']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/binary/BaseNCodecOutputStream", DoNotGenerateAcw=true)]
	public partial class BaseNCodecOutputStream : global::Java.IO.FilterOutputStream {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/binary/BaseNCodecOutputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseNCodecOutputStream); }
		}

		protected BaseNCodecOutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_OutputStream_Lorg_apache_commons_codec_binary_BaseNCodec_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='BaseNCodecOutputStream']/constructor[@name='BaseNCodecOutputStream' and count(parameter)=3 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='org.apache.commons.codec.binary.BaseNCodec'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Ljava/io/OutputStream;Lorg/apache/commons/codec/binary/BaseNCodec;Z)V", "")]
		public unsafe BaseNCodecOutputStream (global::System.IO.Stream @out, global::Org.Apache.Commons.Codec.Binary.BaseNCodec basedCodec, bool doEncode)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native__out);
				__args [1] = new JValue (basedCodec);
				__args [2] = new JValue (doEncode);
				if (((object) this).GetType () != typeof (BaseNCodecOutputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/io/OutputStream;Lorg/apache/commons/codec/binary/BaseNCodec;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/OutputStream;Lorg/apache/commons/codec/binary/BaseNCodec;Z)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_OutputStream_Lorg_apache_commons_codec_binary_BaseNCodec_Z == IntPtr.Zero)
					id_ctor_Ljava_io_OutputStream_Lorg_apache_commons_codec_binary_BaseNCodec_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/OutputStream;Lorg/apache/commons/codec/binary/BaseNCodec;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_OutputStream_Lorg_apache_commons_codec_binary_BaseNCodec_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_OutputStream_Lorg_apache_commons_codec_binary_BaseNCodec_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
			}
		}

	}
}
