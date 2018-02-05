using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Binary {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64InputStream']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/binary/Base64InputStream", DoNotGenerateAcw=true)]
	public partial class Base64InputStream : global::Org.Apache.Commons.Codec.Binary.BaseNCodecInputStream {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/binary/Base64InputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Base64InputStream); }
		}

		protected Base64InputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_InputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64InputStream']/constructor[@name='Base64InputStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
		public unsafe Base64InputStream (global::System.IO.Stream @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__in);
				if (((object) this).GetType () != typeof (Base64InputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/io/InputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/InputStream;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_InputStream_ == IntPtr.Zero)
					id_ctor_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_InputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
			}
		}

		static IntPtr id_ctor_Ljava_io_InputStream_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64InputStream']/constructor[@name='Base64InputStream' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/io/InputStream;Z)V", "")]
		public unsafe Base64InputStream (global::System.IO.Stream @in, bool doEncode)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native__in);
				__args [1] = new JValue (doEncode);
				if (((object) this).GetType () != typeof (Base64InputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/io/InputStream;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/InputStream;Z)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_InputStream_Z == IntPtr.Zero)
					id_ctor_Ljava_io_InputStream_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_InputStream_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
			}
		}

		static IntPtr id_ctor_Ljava_io_InputStream_ZIarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base64InputStream']/constructor[@name='Base64InputStream' and count(parameter)=4 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
		[Register (".ctor", "(Ljava/io/InputStream;ZI[B)V", "")]
		public unsafe Base64InputStream (global::System.IO.Stream @in, bool doEncode, int lineLength, byte[] lineSeparator)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			IntPtr native_lineSeparator = JNIEnv.NewArray (lineSeparator);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native__in);
				__args [1] = new JValue (doEncode);
				__args [2] = new JValue (lineLength);
				__args [3] = new JValue (native_lineSeparator);
				if (((object) this).GetType () != typeof (Base64InputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/io/InputStream;ZI[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/InputStream;ZI[B)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_InputStream_ZIarrayB == IntPtr.Zero)
					id_ctor_Ljava_io_InputStream_ZIarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;ZI[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_ZIarrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_InputStream_ZIarrayB, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
				if (lineSeparator != null) {
					JNIEnv.CopyArray (native_lineSeparator, lineSeparator);
					JNIEnv.DeleteLocalRef (native_lineSeparator);
				}
			}
		}

	}
}
