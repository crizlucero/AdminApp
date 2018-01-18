using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Digest {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/digest/DigestUtils", DoNotGenerateAcw=true)]
	public partial class DigestUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/digest/DigestUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DigestUtils); }
		}

		protected DigestUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/constructor[@name='DigestUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DigestUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DigestUtils)) {
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

		static IntPtr id_getMd2Digest;
		public static unsafe global::Java.Security.MessageDigest Md2Digest {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='getMd2Digest' and count(parameter)=0]"
			[Register ("getMd2Digest", "()Ljava/security/MessageDigest;", "GetGetMd2DigestHandler")]
			get {
				if (id_getMd2Digest == IntPtr.Zero)
					id_getMd2Digest = JNIEnv.GetStaticMethodID (class_ref, "getMd2Digest", "()Ljava/security/MessageDigest;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Security.MessageDigest> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMd2Digest), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMd5Digest;
		public static unsafe global::Java.Security.MessageDigest Md5Digest {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='getMd5Digest' and count(parameter)=0]"
			[Register ("getMd5Digest", "()Ljava/security/MessageDigest;", "GetGetMd5DigestHandler")]
			get {
				if (id_getMd5Digest == IntPtr.Zero)
					id_getMd5Digest = JNIEnv.GetStaticMethodID (class_ref, "getMd5Digest", "()Ljava/security/MessageDigest;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Security.MessageDigest> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMd5Digest), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSha1Digest;
		public static unsafe global::Java.Security.MessageDigest Sha1Digest {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='getSha1Digest' and count(parameter)=0]"
			[Register ("getSha1Digest", "()Ljava/security/MessageDigest;", "GetGetSha1DigestHandler")]
			get {
				if (id_getSha1Digest == IntPtr.Zero)
					id_getSha1Digest = JNIEnv.GetStaticMethodID (class_ref, "getSha1Digest", "()Ljava/security/MessageDigest;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Security.MessageDigest> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSha1Digest), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSha256Digest;
		public static unsafe global::Java.Security.MessageDigest Sha256Digest {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='getSha256Digest' and count(parameter)=0]"
			[Register ("getSha256Digest", "()Ljava/security/MessageDigest;", "GetGetSha256DigestHandler")]
			get {
				if (id_getSha256Digest == IntPtr.Zero)
					id_getSha256Digest = JNIEnv.GetStaticMethodID (class_ref, "getSha256Digest", "()Ljava/security/MessageDigest;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Security.MessageDigest> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSha256Digest), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSha384Digest;
		public static unsafe global::Java.Security.MessageDigest Sha384Digest {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='getSha384Digest' and count(parameter)=0]"
			[Register ("getSha384Digest", "()Ljava/security/MessageDigest;", "GetGetSha384DigestHandler")]
			get {
				if (id_getSha384Digest == IntPtr.Zero)
					id_getSha384Digest = JNIEnv.GetStaticMethodID (class_ref, "getSha384Digest", "()Ljava/security/MessageDigest;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Security.MessageDigest> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSha384Digest), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSha512Digest;
		public static unsafe global::Java.Security.MessageDigest Sha512Digest {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='getSha512Digest' and count(parameter)=0]"
			[Register ("getSha512Digest", "()Ljava/security/MessageDigest;", "GetGetSha512DigestHandler")]
			get {
				if (id_getSha512Digest == IntPtr.Zero)
					id_getSha512Digest = JNIEnv.GetStaticMethodID (class_ref, "getSha512Digest", "()Ljava/security/MessageDigest;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Security.MessageDigest> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSha512Digest), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getShaDigest;
		[Obsolete (@"deprecated")]
		public static unsafe global::Java.Security.MessageDigest ShaDigest {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='getShaDigest' and count(parameter)=0]"
			[Register ("getShaDigest", "()Ljava/security/MessageDigest;", "GetGetShaDigestHandler")]
			get {
				if (id_getShaDigest == IntPtr.Zero)
					id_getShaDigest = JNIEnv.GetStaticMethodID (class_ref, "getShaDigest", "()Ljava/security/MessageDigest;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Security.MessageDigest> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getShaDigest), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDigest_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='getDigest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDigest", "(Ljava/lang/String;)Ljava/security/MessageDigest;", "")]
		public static unsafe global::Java.Security.MessageDigest GetDigest (string algorithm)
		{
			if (id_getDigest_Ljava_lang_String_ == IntPtr.Zero)
				id_getDigest_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getDigest", "(Ljava/lang/String;)Ljava/security/MessageDigest;");
			IntPtr native_algorithm = JNIEnv.NewString (algorithm);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_algorithm);
				global::Java.Security.MessageDigest __ret = global::Java.Lang.Object.GetObject<global::Java.Security.MessageDigest> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDigest_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_algorithm);
			}
		}

		static IntPtr id_md2_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='md2' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("md2", "([B)[B", "")]
		public static unsafe byte[] Md2 (byte[] data)
		{
			if (id_md2_arrayB == IntPtr.Zero)
				id_md2_arrayB = JNIEnv.GetStaticMethodID (class_ref, "md2", "([B)[B");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_md2_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static IntPtr id_md2_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='md2' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("md2", "(Ljava/io/InputStream;)[B", "")]
		public static unsafe byte[] Md2 (global::System.IO.Stream data)
		{
			if (id_md2_Ljava_io_InputStream_ == IntPtr.Zero)
				id_md2_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "md2", "(Ljava/io/InputStream;)[B");
			IntPtr native_data = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_md2_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_md2_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='md2' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("md2", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] Md2 (string data)
		{
			if (id_md2_Ljava_lang_String_ == IntPtr.Zero)
				id_md2_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "md2", "(Ljava/lang/String;)[B");
			IntPtr native_data = JNIEnv.NewString (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_md2_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_md2Hex_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='md2Hex' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("md2Hex", "([B)Ljava/lang/String;", "")]
		public static unsafe string Md2Hex (byte[] data)
		{
			if (id_md2Hex_arrayB == IntPtr.Zero)
				id_md2Hex_arrayB = JNIEnv.GetStaticMethodID (class_ref, "md2Hex", "([B)Ljava/lang/String;");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_md2Hex_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static IntPtr id_md2Hex_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='md2Hex' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("md2Hex", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static unsafe string Md2Hex (global::System.IO.Stream data)
		{
			if (id_md2Hex_Ljava_io_InputStream_ == IntPtr.Zero)
				id_md2Hex_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "md2Hex", "(Ljava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_data = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_md2Hex_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_md2Hex_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='md2Hex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("md2Hex", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Md2Hex (string data)
		{
			if (id_md2Hex_Ljava_lang_String_ == IntPtr.Zero)
				id_md2Hex_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "md2Hex", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_data = JNIEnv.NewString (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_md2Hex_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_md5_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='md5' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("md5", "([B)[B", "")]
		public static unsafe byte[] Md5 (byte[] data)
		{
			if (id_md5_arrayB == IntPtr.Zero)
				id_md5_arrayB = JNIEnv.GetStaticMethodID (class_ref, "md5", "([B)[B");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_md5_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static IntPtr id_md5_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='md5' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("md5", "(Ljava/io/InputStream;)[B", "")]
		public static unsafe byte[] Md5 (global::System.IO.Stream data)
		{
			if (id_md5_Ljava_io_InputStream_ == IntPtr.Zero)
				id_md5_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "md5", "(Ljava/io/InputStream;)[B");
			IntPtr native_data = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_md5_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_md5_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='md5' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("md5", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] Md5 (string data)
		{
			if (id_md5_Ljava_lang_String_ == IntPtr.Zero)
				id_md5_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "md5", "(Ljava/lang/String;)[B");
			IntPtr native_data = JNIEnv.NewString (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_md5_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_md5Hex_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='md5Hex' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("md5Hex", "([B)Ljava/lang/String;", "")]
		public static unsafe string Md5Hex (byte[] data)
		{
			if (id_md5Hex_arrayB == IntPtr.Zero)
				id_md5Hex_arrayB = JNIEnv.GetStaticMethodID (class_ref, "md5Hex", "([B)Ljava/lang/String;");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_md5Hex_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static IntPtr id_md5Hex_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='md5Hex' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("md5Hex", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static unsafe string Md5Hex (global::System.IO.Stream data)
		{
			if (id_md5Hex_Ljava_io_InputStream_ == IntPtr.Zero)
				id_md5Hex_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "md5Hex", "(Ljava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_data = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_md5Hex_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_md5Hex_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='md5Hex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("md5Hex", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Md5Hex (string data)
		{
			if (id_md5Hex_Ljava_lang_String_ == IntPtr.Zero)
				id_md5Hex_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "md5Hex", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_data = JNIEnv.NewString (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_md5Hex_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_sha_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Obsolete (@"deprecated")]
		[Register ("sha", "([B)[B", "")]
		public static unsafe byte[] Sha (byte[] data)
		{
			if (id_sha_arrayB == IntPtr.Zero)
				id_sha_arrayB = JNIEnv.GetStaticMethodID (class_ref, "sha", "([B)[B");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static IntPtr id_sha_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Obsolete (@"deprecated")]
		[Register ("sha", "(Ljava/io/InputStream;)[B", "")]
		public static unsafe byte[] Sha (global::System.IO.Stream data)
		{
			if (id_sha_Ljava_io_InputStream_ == IntPtr.Zero)
				id_sha_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "sha", "(Ljava/io/InputStream;)[B");
			IntPtr native_data = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_sha_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("sha", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] Sha (string data)
		{
			if (id_sha_Ljava_lang_String_ == IntPtr.Zero)
				id_sha_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sha", "(Ljava/lang/String;)[B");
			IntPtr native_data = JNIEnv.NewString (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_sha1_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha1' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("sha1", "([B)[B", "")]
		public static unsafe byte[] Sha1 (byte[] data)
		{
			if (id_sha1_arrayB == IntPtr.Zero)
				id_sha1_arrayB = JNIEnv.GetStaticMethodID (class_ref, "sha1", "([B)[B");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha1_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static IntPtr id_sha1_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha1' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("sha1", "(Ljava/io/InputStream;)[B", "")]
		public static unsafe byte[] Sha1 (global::System.IO.Stream data)
		{
			if (id_sha1_Ljava_io_InputStream_ == IntPtr.Zero)
				id_sha1_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "sha1", "(Ljava/io/InputStream;)[B");
			IntPtr native_data = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha1_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_sha1_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha1' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sha1", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] Sha1 (string data)
		{
			if (id_sha1_Ljava_lang_String_ == IntPtr.Zero)
				id_sha1_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sha1", "(Ljava/lang/String;)[B");
			IntPtr native_data = JNIEnv.NewString (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha1_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_sha1Hex_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha1Hex' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("sha1Hex", "([B)Ljava/lang/String;", "")]
		public static unsafe string Sha1Hex (byte[] data)
		{
			if (id_sha1Hex_arrayB == IntPtr.Zero)
				id_sha1Hex_arrayB = JNIEnv.GetStaticMethodID (class_ref, "sha1Hex", "([B)Ljava/lang/String;");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha1Hex_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static IntPtr id_sha1Hex_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha1Hex' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("sha1Hex", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static unsafe string Sha1Hex (global::System.IO.Stream data)
		{
			if (id_sha1Hex_Ljava_io_InputStream_ == IntPtr.Zero)
				id_sha1Hex_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "sha1Hex", "(Ljava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_data = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha1Hex_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_sha1Hex_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha1Hex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sha1Hex", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Sha1Hex (string data)
		{
			if (id_sha1Hex_Ljava_lang_String_ == IntPtr.Zero)
				id_sha1Hex_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sha1Hex", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_data = JNIEnv.NewString (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha1Hex_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_sha256_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha256' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("sha256", "([B)[B", "")]
		public static unsafe byte[] Sha256 (byte[] data)
		{
			if (id_sha256_arrayB == IntPtr.Zero)
				id_sha256_arrayB = JNIEnv.GetStaticMethodID (class_ref, "sha256", "([B)[B");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha256_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static IntPtr id_sha256_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha256' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("sha256", "(Ljava/io/InputStream;)[B", "")]
		public static unsafe byte[] Sha256 (global::System.IO.Stream data)
		{
			if (id_sha256_Ljava_io_InputStream_ == IntPtr.Zero)
				id_sha256_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "sha256", "(Ljava/io/InputStream;)[B");
			IntPtr native_data = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha256_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_sha256_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha256' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sha256", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] Sha256 (string data)
		{
			if (id_sha256_Ljava_lang_String_ == IntPtr.Zero)
				id_sha256_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sha256", "(Ljava/lang/String;)[B");
			IntPtr native_data = JNIEnv.NewString (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha256_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_sha256Hex_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha256Hex' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("sha256Hex", "([B)Ljava/lang/String;", "")]
		public static unsafe string Sha256Hex (byte[] data)
		{
			if (id_sha256Hex_arrayB == IntPtr.Zero)
				id_sha256Hex_arrayB = JNIEnv.GetStaticMethodID (class_ref, "sha256Hex", "([B)Ljava/lang/String;");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha256Hex_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static IntPtr id_sha256Hex_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha256Hex' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("sha256Hex", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static unsafe string Sha256Hex (global::System.IO.Stream data)
		{
			if (id_sha256Hex_Ljava_io_InputStream_ == IntPtr.Zero)
				id_sha256Hex_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "sha256Hex", "(Ljava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_data = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha256Hex_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_sha256Hex_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha256Hex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sha256Hex", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Sha256Hex (string data)
		{
			if (id_sha256Hex_Ljava_lang_String_ == IntPtr.Zero)
				id_sha256Hex_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sha256Hex", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_data = JNIEnv.NewString (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha256Hex_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_sha384_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha384' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("sha384", "([B)[B", "")]
		public static unsafe byte[] Sha384 (byte[] data)
		{
			if (id_sha384_arrayB == IntPtr.Zero)
				id_sha384_arrayB = JNIEnv.GetStaticMethodID (class_ref, "sha384", "([B)[B");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha384_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static IntPtr id_sha384_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha384' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("sha384", "(Ljava/io/InputStream;)[B", "")]
		public static unsafe byte[] Sha384 (global::System.IO.Stream data)
		{
			if (id_sha384_Ljava_io_InputStream_ == IntPtr.Zero)
				id_sha384_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "sha384", "(Ljava/io/InputStream;)[B");
			IntPtr native_data = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha384_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_sha384_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha384' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sha384", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] Sha384 (string data)
		{
			if (id_sha384_Ljava_lang_String_ == IntPtr.Zero)
				id_sha384_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sha384", "(Ljava/lang/String;)[B");
			IntPtr native_data = JNIEnv.NewString (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha384_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_sha384Hex_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha384Hex' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("sha384Hex", "([B)Ljava/lang/String;", "")]
		public static unsafe string Sha384Hex (byte[] data)
		{
			if (id_sha384Hex_arrayB == IntPtr.Zero)
				id_sha384Hex_arrayB = JNIEnv.GetStaticMethodID (class_ref, "sha384Hex", "([B)Ljava/lang/String;");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha384Hex_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static IntPtr id_sha384Hex_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha384Hex' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("sha384Hex", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static unsafe string Sha384Hex (global::System.IO.Stream data)
		{
			if (id_sha384Hex_Ljava_io_InputStream_ == IntPtr.Zero)
				id_sha384Hex_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "sha384Hex", "(Ljava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_data = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha384Hex_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_sha384Hex_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha384Hex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sha384Hex", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Sha384Hex (string data)
		{
			if (id_sha384Hex_Ljava_lang_String_ == IntPtr.Zero)
				id_sha384Hex_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sha384Hex", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_data = JNIEnv.NewString (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha384Hex_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_sha512_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha512' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("sha512", "([B)[B", "")]
		public static unsafe byte[] Sha512 (byte[] data)
		{
			if (id_sha512_arrayB == IntPtr.Zero)
				id_sha512_arrayB = JNIEnv.GetStaticMethodID (class_ref, "sha512", "([B)[B");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha512_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static IntPtr id_sha512_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha512' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("sha512", "(Ljava/io/InputStream;)[B", "")]
		public static unsafe byte[] Sha512 (global::System.IO.Stream data)
		{
			if (id_sha512_Ljava_io_InputStream_ == IntPtr.Zero)
				id_sha512_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "sha512", "(Ljava/io/InputStream;)[B");
			IntPtr native_data = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha512_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_sha512_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha512' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sha512", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] Sha512 (string data)
		{
			if (id_sha512_Ljava_lang_String_ == IntPtr.Zero)
				id_sha512_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sha512", "(Ljava/lang/String;)[B");
			IntPtr native_data = JNIEnv.NewString (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha512_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_sha512Hex_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha512Hex' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("sha512Hex", "([B)Ljava/lang/String;", "")]
		public static unsafe string Sha512Hex (byte[] data)
		{
			if (id_sha512Hex_arrayB == IntPtr.Zero)
				id_sha512Hex_arrayB = JNIEnv.GetStaticMethodID (class_ref, "sha512Hex", "([B)Ljava/lang/String;");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha512Hex_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static IntPtr id_sha512Hex_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha512Hex' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("sha512Hex", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static unsafe string Sha512Hex (global::System.IO.Stream data)
		{
			if (id_sha512Hex_Ljava_io_InputStream_ == IntPtr.Zero)
				id_sha512Hex_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "sha512Hex", "(Ljava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_data = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha512Hex_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_sha512Hex_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='sha512Hex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sha512Hex", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Sha512Hex (string data)
		{
			if (id_sha512Hex_Ljava_lang_String_ == IntPtr.Zero)
				id_sha512Hex_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sha512Hex", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_data = JNIEnv.NewString (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha512Hex_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_shaHex_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='shaHex' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Obsolete (@"deprecated")]
		[Register ("shaHex", "([B)Ljava/lang/String;", "")]
		public static unsafe string ShaHex (byte[] data)
		{
			if (id_shaHex_arrayB == IntPtr.Zero)
				id_shaHex_arrayB = JNIEnv.GetStaticMethodID (class_ref, "shaHex", "([B)Ljava/lang/String;");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_shaHex_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static IntPtr id_shaHex_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='shaHex' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Obsolete (@"deprecated")]
		[Register ("shaHex", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static unsafe string ShaHex (global::System.IO.Stream data)
		{
			if (id_shaHex_Ljava_io_InputStream_ == IntPtr.Zero)
				id_shaHex_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "shaHex", "(Ljava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_data = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_shaHex_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_shaHex_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='shaHex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("shaHex", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ShaHex (string data)
		{
			if (id_shaHex_Ljava_lang_String_ == IntPtr.Zero)
				id_shaHex_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "shaHex", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_data = JNIEnv.NewString (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_shaHex_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_updateDigest_Ljava_security_MessageDigest_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='updateDigest' and count(parameter)=2 and parameter[1][@type='java.security.MessageDigest'] and parameter[2][@type='byte[]']]"
		[Register ("updateDigest", "(Ljava/security/MessageDigest;[B)Ljava/security/MessageDigest;", "")]
		public static unsafe global::Java.Security.MessageDigest UpdateDigest (global::Java.Security.MessageDigest messageDigest, byte[] valueToDigest)
		{
			if (id_updateDigest_Ljava_security_MessageDigest_arrayB == IntPtr.Zero)
				id_updateDigest_Ljava_security_MessageDigest_arrayB = JNIEnv.GetStaticMethodID (class_ref, "updateDigest", "(Ljava/security/MessageDigest;[B)Ljava/security/MessageDigest;");
			IntPtr native_valueToDigest = JNIEnv.NewArray (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (messageDigest);
				__args [1] = new JValue (native_valueToDigest);
				global::Java.Security.MessageDigest __ret = global::Java.Lang.Object.GetObject<global::Java.Security.MessageDigest> (JNIEnv.CallStaticObjectMethod  (class_ref, id_updateDigest_Ljava_security_MessageDigest_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (valueToDigest != null) {
					JNIEnv.CopyArray (native_valueToDigest, valueToDigest);
					JNIEnv.DeleteLocalRef (native_valueToDigest);
				}
			}
		}

		static IntPtr id_updateDigest_Ljava_security_MessageDigest_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='updateDigest' and count(parameter)=2 and parameter[1][@type='java.security.MessageDigest'] and parameter[2][@type='java.io.InputStream']]"
		[Register ("updateDigest", "(Ljava/security/MessageDigest;Ljava/io/InputStream;)Ljava/security/MessageDigest;", "")]
		public static unsafe global::Java.Security.MessageDigest UpdateDigest (global::Java.Security.MessageDigest digest, global::System.IO.Stream data)
		{
			if (id_updateDigest_Ljava_security_MessageDigest_Ljava_io_InputStream_ == IntPtr.Zero)
				id_updateDigest_Ljava_security_MessageDigest_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "updateDigest", "(Ljava/security/MessageDigest;Ljava/io/InputStream;)Ljava/security/MessageDigest;");
			IntPtr native_data = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (data);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (digest);
				__args [1] = new JValue (native_data);
				global::Java.Security.MessageDigest __ret = global::Java.Lang.Object.GetObject<global::Java.Security.MessageDigest> (JNIEnv.CallStaticObjectMethod  (class_ref, id_updateDigest_Ljava_security_MessageDigest_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static IntPtr id_updateDigest_Ljava_security_MessageDigest_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='DigestUtils']/method[@name='updateDigest' and count(parameter)=2 and parameter[1][@type='java.security.MessageDigest'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateDigest", "(Ljava/security/MessageDigest;Ljava/lang/String;)Ljava/security/MessageDigest;", "")]
		public static unsafe global::Java.Security.MessageDigest UpdateDigest (global::Java.Security.MessageDigest messageDigest, string valueToDigest)
		{
			if (id_updateDigest_Ljava_security_MessageDigest_Ljava_lang_String_ == IntPtr.Zero)
				id_updateDigest_Ljava_security_MessageDigest_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "updateDigest", "(Ljava/security/MessageDigest;Ljava/lang/String;)Ljava/security/MessageDigest;");
			IntPtr native_valueToDigest = JNIEnv.NewString (valueToDigest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (messageDigest);
				__args [1] = new JValue (native_valueToDigest);
				global::Java.Security.MessageDigest __ret = global::Java.Lang.Object.GetObject<global::Java.Security.MessageDigest> (JNIEnv.CallStaticObjectMethod  (class_ref, id_updateDigest_Ljava_security_MessageDigest_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_valueToDigest);
			}
		}

	}
}
