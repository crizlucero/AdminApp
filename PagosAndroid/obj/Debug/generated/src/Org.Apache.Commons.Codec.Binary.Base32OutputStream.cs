using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Binary {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base32OutputStream']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/binary/Base32OutputStream", DoNotGenerateAcw=true)]
	public partial class Base32OutputStream : global::Org.Apache.Commons.Codec.Binary.BaseNCodecOutputStream {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/binary/Base32OutputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Base32OutputStream); }
		}

		protected Base32OutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_OutputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base32OutputStream']/constructor[@name='Base32OutputStream' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register (".ctor", "(Ljava/io/OutputStream;)V", "")]
		public unsafe Base32OutputStream (global::System.IO.Stream @out)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__out);
				if (((object) this).GetType () != typeof (Base32OutputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/io/OutputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/OutputStream;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_OutputStream_ == IntPtr.Zero)
					id_ctor_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/OutputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_OutputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_OutputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
			}
		}

		static IntPtr id_ctor_Ljava_io_OutputStream_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base32OutputStream']/constructor[@name='Base32OutputStream' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/io/OutputStream;Z)V", "")]
		public unsafe Base32OutputStream (global::System.IO.Stream @out, bool doEncode)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native__out);
				__args [1] = new JValue (doEncode);
				if (((object) this).GetType () != typeof (Base32OutputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/io/OutputStream;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/OutputStream;Z)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_OutputStream_Z == IntPtr.Zero)
					id_ctor_Ljava_io_OutputStream_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/OutputStream;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_OutputStream_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_OutputStream_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
			}
		}

		static IntPtr id_ctor_Ljava_io_OutputStream_ZIarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.binary']/class[@name='Base32OutputStream']/constructor[@name='Base32OutputStream' and count(parameter)=4 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
		[Register (".ctor", "(Ljava/io/OutputStream;ZI[B)V", "")]
		public unsafe Base32OutputStream (global::System.IO.Stream @out, bool doEncode, int lineLength, byte[] lineSeparator)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			IntPtr native_lineSeparator = JNIEnv.NewArray (lineSeparator);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native__out);
				__args [1] = new JValue (doEncode);
				__args [2] = new JValue (lineLength);
				__args [3] = new JValue (native_lineSeparator);
				if (((object) this).GetType () != typeof (Base32OutputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/io/OutputStream;ZI[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/OutputStream;ZI[B)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_OutputStream_ZIarrayB == IntPtr.Zero)
					id_ctor_Ljava_io_OutputStream_ZIarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/OutputStream;ZI[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_OutputStream_ZIarrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_OutputStream_ZIarrayB, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
				if (lineSeparator != null) {
					JNIEnv.CopyArray (native_lineSeparator, lineSeparator);
					JNIEnv.DeleteLocalRef (native_lineSeparator);
				}
			}
		}

	}
}
