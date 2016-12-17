//
// Contact.cs
//
// Created by Thomas Dubiel on 17.12.2016
// Copyright 2016 Thomas Dubiel. All rights reserved.
//
using System;
using UIKit;

namespace MyContacts.iOS
{
	public class Contact
	{
		public string Fullname
		{
			get;
			set;
		}

		public string Email
		{
			get;
			set;
		}

		public UIImage Photo
		{
			get;
			set;
		}

		public Contact()
		{
		}
	}
}
