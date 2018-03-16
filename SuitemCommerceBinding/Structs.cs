using System;
using System.Runtime.InteropServices;
using CoreAnimation;
using CoreFoundation;
using CoreGraphics;
using CoreText;
using CoreVideo;
using Foundation;
using IOSurface;
using ImageIO;
using Metal;
using ObjCRuntime;
using OpenGLES;
using Security;
using UIKit;

namespace SuitemCommerce
{
    public enum Environment : uint
    {
        Sandbox,
        Dev,
        Qa,
        Prod
    }

    public enum PaymentType : uint
    {
        C,
        To3M,
        To6M,
        To9M,
        To12M
    }

    public enum Currency : uint
    {
        Mxn,
        Usd
    }
}
