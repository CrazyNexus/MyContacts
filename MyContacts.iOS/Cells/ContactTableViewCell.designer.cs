// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MyContacts.iOS
{
    [Register ("ContactTableViewCell")]
    partial class ContactTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel contactListEmailLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView contactListImageView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel contactListNameLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (contactListEmailLabel != null) {
                contactListEmailLabel.Dispose ();
                contactListEmailLabel = null;
            }

            if (contactListImageView != null) {
                contactListImageView.Dispose ();
                contactListImageView = null;
            }

            if (contactListNameLabel != null) {
                contactListNameLabel.Dispose ();
                contactListNameLabel = null;
            }
        }
    }
}