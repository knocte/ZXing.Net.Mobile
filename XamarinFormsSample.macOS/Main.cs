using System;
using System.Drawing;
using Foundation;
using AppKit;


namespace XamarinFormsSample.macOS
{
    class MainClass
    {
        static void Main(string[] args)
        {
            NSApplication.Init();
			NSApplication.SharedApplication.Delegate = new AppDelegate();
			NSApplication.Main(args);
        }
    }
}
