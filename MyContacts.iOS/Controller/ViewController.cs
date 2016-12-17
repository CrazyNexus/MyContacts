//
// ViewController.cs
//
// Created by Thomas Dubiel on 17.12.2016
// Copyright 2016 Thomas Dubiel. All rights reserved.
//
using System;

using UIKit;

namespace MyContacts.iOS
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			imageButton.TouchUpInside += ImageButton_TouchUpInside;
			saveButton.Clicked += SaveButton_Clicked;
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		void SaveButton_Clicked(object sender, EventArgs e)
		{
			var contact = new Contact()
			{
				Fullname = fullNAmeTextField.Text,
				Email = emailTextField.Text,
				Photo = photoImageView.Image
			};

			var appDelegate = UIApplication.SharedApplication.Delegate as AppDelegate;
			appDelegate.contactList.Add(contact);

			NavigationController.PopViewController(true);
		}

		void ImageButton_TouchUpInside(object sender, EventArgs e)
		{

		}
	}
}
