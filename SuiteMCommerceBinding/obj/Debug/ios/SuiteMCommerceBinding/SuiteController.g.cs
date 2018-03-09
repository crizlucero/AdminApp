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
	[Register("SuiteController", true)]
	public unsafe partial class SuiteController : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SuiteController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SuiteController () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SuiteController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SuiteController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("AuthenticateWithBeanTokenization:bean3DS:")]
		[CompilerGenerated]
		public virtual void AuthenticateWithBeanTokenization (BeanTokenization beanTokenization, Bean3DS bean3DS)
		{
			if (beanTokenization == null)
				throw new ArgumentNullException ("beanTokenization");
			if (bean3DS == null)
				throw new ArgumentNullException ("bean3DS");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("AuthenticateWithBeanTokenization:bean3DS:"), beanTokenization.Handle, bean3DS.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("AuthenticateWithBeanTokenization:bean3DS:"), beanTokenization.Handle, bean3DS.Handle);
			}
		}
		
		[Export ("initOnEnvironment:currentViewController:delegate:")]
		[CompilerGenerated]
		public virtual global::System.IntPtr InitOnEnvironment (Environment environment, global::UIKit.UIViewController viewController, SuiteControllerDelegate Delegate)
		{
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			if (Delegate == null)
				throw new ArgumentNullException ("Delegate");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initOnEnvironment:currentViewController:delegate:"), (int)environment, viewController.Handle, Delegate.Handle);
			} else {
				return global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initOnEnvironment:currentViewController:delegate:"), (int)environment, viewController.Handle, Delegate.Handle);
			}
		}
		
		[Export ("sndPayWithCompany:xmlA:xmlM:")]
		[CompilerGenerated]
		public virtual void SndPayWithCompany (string company, string xmlA, string xmlM)
		{
			if (company == null)
				throw new ArgumentNullException ("company");
			if (xmlA == null)
				throw new ArgumentNullException ("xmlA");
			if (xmlM == null)
				throw new ArgumentNullException ("xmlM");
			var nscompany = NSString.CreateNative (company);
			var nsxmlA = NSString.CreateNative (xmlA);
			var nsxmlM = NSString.CreateNative (xmlM);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("sndPayWithCompany:xmlA:xmlM:"), nscompany, nsxmlA, nsxmlM);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("sndPayWithCompany:xmlA:xmlM:"), nscompany, nsxmlA, nsxmlM);
			}
			NSString.ReleaseNative (nscompany);
			NSString.ReleaseNative (nsxmlA);
			NSString.ReleaseNative (nsxmlM);
			
		}
		
		[Export ("sndPayWithTokenWithBeanTokenization:bean3DS:")]
		[CompilerGenerated]
		public virtual void SndPayWithTokenWithBeanTokenization (BeanTokenization beanTokenization, Bean3DS bean3DS)
		{
			if (beanTokenization == null)
				throw new ArgumentNullException ("beanTokenization");
			if (bean3DS == null)
				throw new ArgumentNullException ("bean3DS");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("sndPayWithTokenWithBeanTokenization:bean3DS:"), beanTokenization.Handle, bean3DS.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("sndPayWithTokenWithBeanTokenization:bean3DS:"), beanTokenization.Handle, bean3DS.Handle);
			}
		}
		
	} /* class SuiteController */
}
