//
// DetailsViewController.cs
//
// Created by Thomas Dubiel on 17.12.2016
// Copyright 2016 Thomas Dubiel. All rights reserved.
//
using Foundation;
using System;
using UIKit;
using MessageUI;
using System.Linq;

namespace MyContacts.iOS
{
	public partial class DetailsViewController : UIViewController
	{
		public Contact contact;

		public DetailsViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			detailsNameLabel.Text = contact.Fullname;
			detailsEmailLabel.Text = contact.Email;
			detailsPhotoImageView.Image = contact.Photo;

			emailButton.TouchUpInside += EmailButton_TouchUpInside;
		}

		void EmailButton_TouchUpInside(object sender, EventArgs e)
		{
			if (MFMailComposeViewController.CanSendMail)
			{
				var emailController = new MFMailComposeViewController();
				var recp = new string[] { detailsEmailLabel.Text };
				emailController.SetToRecipients(recp);
				emailController.SetSubject("testmail");
				emailController.Finished += EmailController_Finished;

				PresentViewController(emailController, true, null);
			}
		}

		void EmailController_Finished(object sender, MFComposeResultEventArgs e)
		{
			e.Controller.DismissViewController(true, null);
		}
	}
}