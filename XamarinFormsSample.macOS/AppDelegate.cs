using System;
using System.Drawing;
using Foundation;
using AppKit;
using ObjCRuntime;

using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;

namespace XamarinFormsSample.macOS
{
    public partial class AppDelegate : FormsApplicationDelegate
    {
		NSWindowStyle style = NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled;
		CoreGraphics.CGRect rect = new CoreGraphics.CGRect(200.0f, 1000.0f, 1024.0f, 768.0f);
        NSWindow window;

        public AppDelegate()
        {
            window = new NSWindow(rect, style, NSBackingStore.Buffered, false);
            window.Title = "Xamarin.Forms on Mac!";
				window.TitleVisibility = NSWindowTitleVisibility.Hidden;
        }

		public override NSWindow MainWindow{
			get { return window; }
		}

        public override void DidFinishLaunching(NSNotification notification)
        {
			Forms.Init();
			this.LoadApplication(new XamarinFormsSample.App());
            // FIXME: the line below reports an NRE which prevents launch TODO: report
			base.DidFinishLaunching(notification);
        }
    }
}
