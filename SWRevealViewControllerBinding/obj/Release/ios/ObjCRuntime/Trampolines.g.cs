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

namespace ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::SWRevealViewControllerBinding.SegueCallback))]
		internal delegate void DSegueCallback (IntPtr block, IntPtr segue, IntPtr svc, IntPtr dvc);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDSegueCallback {
			static internal readonly DSegueCallback Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DSegueCallback))]
			static unsafe void Invoke (IntPtr block, IntPtr segue, IntPtr svc, IntPtr dvc) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::SWRevealViewControllerBinding.SegueCallback) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<SWRevealViewControllerBinding.SWRevealViewControllerSegueSetController> (segue),  Runtime.GetNSObject<UIViewController> (svc),  Runtime.GetNSObject<UIViewController> (dvc));
			}
		} /* class SDSegueCallback */
		
		internal class NIDSegueCallback {
			IntPtr blockPtr;
			DSegueCallback invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDSegueCallback (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DSegueCallback> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDSegueCallback ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::SWRevealViewControllerBinding.SegueCallback Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::SWRevealViewControllerBinding.SegueCallback;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDSegueCallback ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::SWRevealViewControllerBinding.SWRevealViewControllerSegueSetController segue, global::UIKit.UIViewController svc, global::UIKit.UIViewController dvc)
			{
				invoker (blockPtr, segue == null ? IntPtr.Zero : segue.Handle, svc == null ? IntPtr.Zero : svc.Handle, dvc == null ? IntPtr.Zero : dvc.Handle);
			}
		} /* class NIDSegueCallback */
	}
}
