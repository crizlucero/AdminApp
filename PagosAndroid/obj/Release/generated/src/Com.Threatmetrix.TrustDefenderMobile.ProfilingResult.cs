using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Threatmetrix.TrustDefenderMobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='ProfilingResult']"
	[global::Android.Runtime.Register ("com/threatmetrix/TrustDefenderMobile/ProfilingResult", DoNotGenerateAcw=true)]
	public partial class ProfilingResult : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/threatmetrix/TrustDefenderMobile/ProfilingResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProfilingResult); }
		}

		protected ProfilingResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getSessionID;
#pragma warning disable 0169
		static Delegate GetGetSessionIDHandler ()
		{
			if (cb_getSessionID == null)
				cb_getSessionID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSessionID);
			return cb_getSessionID;
		}

		static IntPtr n_GetSessionID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.ProfilingResult __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ProfilingResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SessionID);
		}
#pragma warning restore 0169

		static IntPtr id_getSessionID;
		public virtual unsafe string SessionID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='ProfilingResult']/method[@name='getSessionID' and count(parameter)=0]"
			[Register ("getSessionID", "()Ljava/lang/String;", "GetGetSessionIDHandler")]
			get {
				if (id_getSessionID == IntPtr.Zero)
					id_getSessionID = JNIEnv.GetMethodID (class_ref, "getSessionID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSessionID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSessionID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Threatmetrix.TrustDefenderMobile.ProfilingResult __this = global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.ProfilingResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Status);
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		public virtual unsafe global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.threatmetrix.TrustDefenderMobile']/class[@name='ProfilingResult']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;", "GetGetStatusHandler")]
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Threatmetrix.TrustDefenderMobile.THMStatusCode> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()Lcom/threatmetrix/TrustDefenderMobile/THMStatusCode;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
