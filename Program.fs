open System

open AppKit
open CoreGraphics
open type AppKit.NSWindowStyle

NSApplication.Init ()

NSApplication.SharedApplication.Delegate <- {
    new NSApplicationDelegate() with
        override this.DidFinishLaunching(_) =
            let wnd = new NSWindow(CGRect(0., 0., 500., 500.), Titled ||| Closable ||| Miniaturizable ||| Resizable, NSBackingStore.Buffered, false)
            let content = NSTextField.CreateLabel("Hello, .NET 6!")
            wnd.Center()
            wnd.ContentView <- content
            wnd.MakeKeyAndOrderFront(this)
}

NSApplication.Main(Environment.GetCommandLineArgs())
