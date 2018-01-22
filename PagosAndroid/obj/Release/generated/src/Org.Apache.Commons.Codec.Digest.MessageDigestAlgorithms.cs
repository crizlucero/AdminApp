using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Codec.Digest {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='MessageDigestAlgorithms']"
	[global::Android.Runtime.Register ("org/apache/commons/codec/digest/MessageDigestAlgorithms", DoNotGenerateAcw=true)]
	public partial class MessageDigestAlgorithms : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='MessageDigestAlgorithms']/field[@name='MD2']"
		[Register ("MD2")]
		public const string Md2 = (string) "MD2";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='MessageDigestAlgorithms']/field[@name='MD5']"
		[Register ("MD5")]
		public const string Md5 = (string) "MD5";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='MessageDigestAlgorithms']/field[@name='SHA_1']"
		[Register ("SHA_1")]
		public const string Sha1 = (string) "SHA-1";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='MessageDigestAlgorithms']/field[@name='SHA_256']"
		[Register ("SHA_256")]
		public const string Sha256 = (string) "SHA-256";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='MessageDigestAlgorithms']/field[@name='SHA_384']"
		[Register ("SHA_384")]
		public const string Sha384 = (string) "SHA-384";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.codec.digest']/class[@name='MessageDigestAlgorithms']/field[@name='SHA_512']"
		[Register ("SHA_512")]
		public const string Sha512 = (string) "SHA-512";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/codec/digest/MessageDigestAlgorithms", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageDigestAlgorithms); }
		}

		protected MessageDigestAlgorithms (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
