//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;

namespace SuiteMCommerceBinding {
	[Protocol (Name = "SuiteControllerDelegate", WrapperType = typeof (SuiteControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishPayProcess", Selector = "didFinishPayProcess:error:", ParameterType = new Type [] { typeof (string), typeof (SuiteMCommerceBinding.SuiteError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishAuthenticationProcess", Selector = "didFinishAuthenticationProcess:error:", ParameterType = new Type [] { typeof (SuiteMCommerceBinding.BeanTokenizeResponse), typeof (SuiteMCommerceBinding.SuiteError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishTokenizeTransantion", Selector = "didFinishTokenizeTransantion:error:", ParameterType = new Type [] { typeof (SuiteMCommerceBinding.BeanPaymentWithToken), typeof (SuiteMCommerceBinding.SuiteError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OperationCanceledByUser", Selector = "operationCanceledByUser")]
	public interface ISuiteControllerDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class SuiteControllerDelegate_Extensions {
		[CompilerGenerated]
		public static void DidFinishPayProcess (this ISuiteControllerDelegate This, string response, SuiteError error)
		{
			if (response == null)
				throw new ArgumentNullException ("response");
			if (error == null)
				throw new ArgumentNullException ("error");
			var nsresponse = NSString.CreateNative (response);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("didFinishPayProcess:error:"), nsresponse, error.Handle);
			NSString.ReleaseNative (nsresponse);
			
		}
		
		[CompilerGenerated]
		public static void DidFinishAuthenticationProcess (this ISuiteControllerDelegate This, BeanTokenizeResponse tokenizeResponse, SuiteError error)
		{
			if (tokenizeResponse == null)
				throw new ArgumentNullException ("tokenizeResponse");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("didFinishAuthenticationProcess:error:"), tokenizeResponse.Handle, error.Handle);
		}
		
		[CompilerGenerated]
		public static void DidFinishTokenizeTransantion (this ISuiteControllerDelegate This, BeanPaymentWithToken beanPaymentWithToken, SuiteError error)
		{
			if (beanPaymentWithToken == null)
				throw new ArgumentNullException ("beanPaymentWithToken");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("didFinishTokenizeTransantion:error:"), beanPaymentWithToken.Handle, error.Handle);
		}
		
		[CompilerGenerated]
		public static void OperationCanceledByUser (this ISuiteControllerDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("operationCanceledByUser"));
		}
		
	}
	
	internal sealed class SuiteControllerDelegateWrapper : BaseWrapper, ISuiteControllerDelegate {
		[Preserve (Conditional = true)]
		public SuiteControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace SuiteMCommerceBinding {
	[Protocol()]
	[Register("SuiteControllerDelegate", false)]
	[Model]
	public unsafe partial class SuiteControllerDelegate : NSObject, ISuiteControllerDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SuiteControllerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SuiteControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SuiteControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("didFinishAuthenticationProcess:error:")]
		[CompilerGenerated]
		public virtual void DidFinishAuthenticationProcess (BeanTokenizeResponse tokenizeResponse, SuiteError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didFinishPayProcess:error:")]
		[CompilerGenerated]
		public virtual void DidFinishPayProcess (string response, SuiteError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didFinishTokenizeTransantion:error:")]
		[CompilerGenerated]
		public virtual void DidFinishTokenizeTransantion (BeanPaymentWithToken beanPaymentWithToken, SuiteError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("operationCanceledByUser")]
		[CompilerGenerated]
		public virtual void OperationCanceledByUser ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class SuiteControllerDelegate */
}
