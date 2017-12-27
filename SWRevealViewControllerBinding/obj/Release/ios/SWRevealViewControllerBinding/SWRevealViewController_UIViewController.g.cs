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
	public unsafe static partial class SWRevealViewController_UIViewController  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("UIViewController");
		
		[Export ("revealViewController")]
		[CompilerGenerated]
		public static SWRevealViewController RevealViewController (this global::UIKit.UIViewController This)
		{
			return  Runtime.GetNSObject<SWRevealViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("revealViewController")));
		}
		
	} /* class SWRevealViewController_UIViewController */
}
