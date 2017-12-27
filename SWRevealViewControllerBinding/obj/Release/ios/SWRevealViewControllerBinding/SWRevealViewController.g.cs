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

namespace SWRevealViewControllerBinding {
	[Register("SWRevealViewController", true)]
	public unsafe partial class SWRevealViewController : global::UIKit.UIViewController {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SWRevealViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SWRevealViewController () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public SWRevealViewController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SWRevealViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SWRevealViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithRearViewController:frontViewController:")]
		[CompilerGenerated]
		public SWRevealViewController (global::UIKit.UIViewController rearViewController, global::UIKit.UIViewController frontViewController)
			: base (NSObjectFlag.Empty)
		{
			if (rearViewController == null)
				throw new ArgumentNullException ("rearViewController");
			if (frontViewController == null)
				throw new ArgumentNullException ("frontViewController");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithRearViewController:frontViewController:"), rearViewController.Handle, frontViewController.Handle), "initWithRearViewController:frontViewController:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithRearViewController:frontViewController:"), rearViewController.Handle, frontViewController.Handle), "initWithRearViewController:frontViewController:");
			}
		}
		
		[Export ("pushFrontViewController:animated:")]
		[CompilerGenerated]
		public virtual void PushFrontViewController (global::UIKit.UIViewController frontViewController, bool animated)
		{
			if (frontViewController == null)
				throw new ArgumentNullException ("frontViewController");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("pushFrontViewController:animated:"), frontViewController.Handle, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("pushFrontViewController:animated:"), frontViewController.Handle, animated);
			}
		}
		
		[Export ("revealToggle:")]
		[CompilerGenerated]
		public virtual void RevealToggle (NSObject sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("revealToggle:"), sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("revealToggle:"), sender.Handle);
			}
		}
		
		[Export ("revealToggleAnimated:")]
		[CompilerGenerated]
		public virtual void RevealToggleAnimated (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("revealToggleAnimated:"), animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("revealToggleAnimated:"), animated);
			}
		}
		
		[Export ("rightRevealToggle:")]
		[CompilerGenerated]
		public virtual void RightRevealToggle (NSObject sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("rightRevealToggle:"), sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("rightRevealToggle:"), sender.Handle);
			}
		}
		
		[Export ("rightRevealToggleAnimated:")]
		[CompilerGenerated]
		public virtual void RightRevealToggleAnimated (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("rightRevealToggleAnimated:"), animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("rightRevealToggleAnimated:"), animated);
			}
		}
		
		[Export ("setFrontViewController:animated:")]
		[CompilerGenerated]
		public virtual void SetFrontViewController (global::UIKit.UIViewController frontViewController, bool animated)
		{
			if (frontViewController == null)
				throw new ArgumentNullException ("frontViewController");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("setFrontViewController:animated:"), frontViewController.Handle, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("setFrontViewController:animated:"), frontViewController.Handle, animated);
			}
		}
		
		[Export ("setFrontViewPosition:animated:")]
		[CompilerGenerated]
		public virtual void SetFrontViewPosition (FrontViewPosition frontViewPosition, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_int_bool (this.Handle, Selector.GetHandle ("setFrontViewPosition:animated:"), (int)frontViewPosition, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_int_bool (this.SuperHandle, Selector.GetHandle ("setFrontViewPosition:animated:"), (int)frontViewPosition, animated);
			}
		}
		
		[Export ("setRearViewController:animated:")]
		[CompilerGenerated]
		public virtual void SetRearViewController (global::UIKit.UIViewController rearViewController, bool animated)
		{
			if (rearViewController == null)
				throw new ArgumentNullException ("rearViewController");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("setRearViewController:animated:"), rearViewController.Handle, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("setRearViewController:animated:"), rearViewController.Handle, animated);
			}
		}
		
		[Export ("setRightViewController:animated:")]
		[CompilerGenerated]
		public virtual void SetRightViewController (global::UIKit.UIViewController rightViewController, bool animated)
		{
			if (rightViewController == null)
				throw new ArgumentNullException ("rightViewController");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("setRightViewController:animated:"), rightViewController.Handle, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("setRightViewController:animated:"), rightViewController.Handle, animated);
			}
		}
		
		[CompilerGenerated]
		public virtual bool BounceBackOnLeftOverdraw {
			[Export ("bounceBackOnLeftOverdraw")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("bounceBackOnLeftOverdraw"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bounceBackOnLeftOverdraw"));
				}
			}
			
			[Export ("setBounceBackOnLeftOverdraw:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setBounceBackOnLeftOverdraw:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setBounceBackOnLeftOverdraw:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool BounceBackOnOverdraw {
			[Export ("bounceBackOnOverdraw")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("bounceBackOnOverdraw"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bounceBackOnOverdraw"));
				}
			}
			
			[Export ("setBounceBackOnOverdraw:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setBounceBackOnOverdraw:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setBounceBackOnOverdraw:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual SWRevealViewControllerDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.UnsafeUnretained)]
			get {
				SWRevealViewControllerDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SWRevealViewControllerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret =  Runtime.GetNSObject<SWRevealViewControllerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value.Handle);
				}
				MarkDirty ();
				__mt_Delegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual float DraggableBorderWidth {
			[Export ("draggableBorderWidth")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("draggableBorderWidth"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("draggableBorderWidth"));
				}
			}
			
			[Export ("setDraggableBorderWidth:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setDraggableBorderWidth:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setDraggableBorderWidth:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIViewController FrontViewController {
			[Export ("frontViewController", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("frontViewController")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("frontViewController")));
				}
				return ret;
			}
			
			[Export ("setFrontViewController:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFrontViewController:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFrontViewController:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual FrontViewPosition FrontViewPosition {
			[Export ("frontViewPosition")]
			get {
				if (IsDirectBinding) {
					return (FrontViewPosition) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("frontViewPosition"));
				} else {
					return (FrontViewPosition) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("frontViewPosition"));
				}
			}
			
			[Export ("setFrontViewPosition:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setFrontViewPosition:"), (int)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setFrontViewPosition:"), (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Drawing.SizeF FrontViewShadowOffset {
			[Export ("frontViewShadowOffset", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::System.Drawing.SizeF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.SizeF_objc_msgSend (this.Handle, Selector.GetHandle ("frontViewShadowOffset"));
						} else {
							global::ApiDefinition.Messaging.SizeF_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("frontViewShadowOffset"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.SizeF_objc_msgSend (this.Handle, Selector.GetHandle ("frontViewShadowOffset"));
					} else {
						ret = global::ApiDefinition.Messaging.SizeF_objc_msgSend (this.Handle, Selector.GetHandle ("frontViewShadowOffset"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.SizeF_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("frontViewShadowOffset"));
						} else {
							global::ApiDefinition.Messaging.SizeF_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("frontViewShadowOffset"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.SizeF_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("frontViewShadowOffset"));
					} else {
						ret = global::ApiDefinition.Messaging.SizeF_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("frontViewShadowOffset"));
					}
				}
				return ret;
			}
			
			[Export ("setFrontViewShadowOffset:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_SizeF (this.Handle, Selector.GetHandle ("setFrontViewShadowOffset:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_SizeF (this.SuperHandle, Selector.GetHandle ("setFrontViewShadowOffset:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float FrontViewShadowOpacity {
			[Export ("frontViewShadowOpacity")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("frontViewShadowOpacity"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("frontViewShadowOpacity"));
				}
			}
			
			[Export ("setFrontViewShadowOpacity:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setFrontViewShadowOpacity:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setFrontViewShadowOpacity:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float FrontViewShadowRadius {
			[Export ("frontViewShadowRadius")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("frontViewShadowRadius"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("frontViewShadowRadius"));
				}
			}
			
			[Export ("setFrontViewShadowRadius:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setFrontViewShadowRadius:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setFrontViewShadowRadius:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIPanGestureRecognizer PanGestureRecognizer {
			[Export ("panGestureRecognizer")]
			get {
				global::UIKit.UIPanGestureRecognizer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIPanGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("panGestureRecognizer")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIPanGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("panGestureRecognizer")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool PresentFrontViewHierarchically {
			[Export ("presentFrontViewHierarchically")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("presentFrontViewHierarchically"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("presentFrontViewHierarchically"));
				}
			}
			
			[Export ("setPresentFrontViewHierarchically:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPresentFrontViewHierarchically:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setPresentFrontViewHierarchically:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float QuickFlickVelocity {
			[Export ("quickFlickVelocity")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("quickFlickVelocity"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("quickFlickVelocity"));
				}
			}
			
			[Export ("setQuickFlickVelocity:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setQuickFlickVelocity:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setQuickFlickVelocity:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIViewController RearViewController {
			[Export ("rearViewController", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rearViewController")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rearViewController")));
				}
				return ret;
			}
			
			[Export ("setRearViewController:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRearViewController:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRearViewController:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float RearViewRevealDisplacement {
			[Export ("rearViewRevealDisplacement")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("rearViewRevealDisplacement"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rearViewRevealDisplacement"));
				}
			}
			
			[Export ("setRearViewRevealDisplacement:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setRearViewRevealDisplacement:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setRearViewRevealDisplacement:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float RearViewRevealOverdraw {
			[Export ("rearViewRevealOverdraw")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("rearViewRevealOverdraw"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rearViewRevealOverdraw"));
				}
			}
			
			[Export ("setRearViewRevealOverdraw:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setRearViewRevealOverdraw:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setRearViewRevealOverdraw:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float RearViewRevealWidth {
			[Export ("rearViewRevealWidth")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("rearViewRevealWidth"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rearViewRevealWidth"));
				}
			}
			
			[Export ("setRearViewRevealWidth:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setRearViewRevealWidth:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setRearViewRevealWidth:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual double ReplaceViewAnimationDuration {
			[Export ("replaceViewAnimationDuration")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("replaceViewAnimationDuration"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("replaceViewAnimationDuration"));
				}
			}
			
			[Export ("setReplaceViewAnimationDuration:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setReplaceViewAnimationDuration:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setReplaceViewAnimationDuration:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIViewController RightViewController {
			[Export ("rightViewController", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewController")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewController")));
				}
				return ret;
			}
			
			[Export ("setRightViewController:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRightViewController:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRightViewController:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float RightViewRevealDisplacement {
			[Export ("rightViewRevealDisplacement")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewRevealDisplacement"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewRevealDisplacement"));
				}
			}
			
			[Export ("setRightViewRevealDisplacement:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setRightViewRevealDisplacement:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setRightViewRevealDisplacement:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float RightViewRevealOverdraw {
			[Export ("rightViewRevealOverdraw")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewRevealOverdraw"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewRevealOverdraw"));
				}
			}
			
			[Export ("setRightViewRevealOverdraw:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setRightViewRevealOverdraw:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setRightViewRevealOverdraw:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float RightViewRevealWidth {
			[Export ("rightViewRevealWidth")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewRevealWidth"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewRevealWidth"));
				}
			}
			
			[Export ("setRightViewRevealWidth:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setRightViewRevealWidth:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setRightViewRevealWidth:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool StableDragOnLeftOverdraw {
			[Export ("stableDragOnLeftOverdraw")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("stableDragOnLeftOverdraw"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stableDragOnLeftOverdraw"));
				}
			}
			
			[Export ("setStableDragOnLeftOverdraw:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setStableDragOnLeftOverdraw:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setStableDragOnLeftOverdraw:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool StableDragOnOverdraw {
			[Export ("stableDragOnOverdraw")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("stableDragOnOverdraw"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stableDragOnOverdraw"));
				}
			}
			
			[Export ("setStableDragOnOverdraw:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setStableDragOnOverdraw:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setStableDragOnOverdraw:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UITapGestureRecognizer TapGestureRecognizer {
			[Export ("tapGestureRecognizer")]
			get {
				global::UIKit.UITapGestureRecognizer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UITapGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("tapGestureRecognizer")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UITapGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("tapGestureRecognizer")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual double ToggleAnimationDuration {
			[Export ("toggleAnimationDuration")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("toggleAnimationDuration"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("toggleAnimationDuration"));
				}
			}
			
			[Export ("setToggleAnimationDuration:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setToggleAnimationDuration:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setToggleAnimationDuration:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
			}
		}
	} /* class SWRevealViewController */
}
