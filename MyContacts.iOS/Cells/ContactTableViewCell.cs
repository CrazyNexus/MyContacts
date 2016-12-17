using Foundation;
using System;
using UIKit;

namespace MyContacts.iOS
{
	public partial class ContactTableViewCell : UITableViewCell
	{
		public ContactTableViewCell(IntPtr handle) : base(handle)
		{
		}

		public void SetValues(Contact contact)
		{
			contactListNameLabel.Text = contact.Fullname;
			contactListEmailLabel.Text = contact.Email;
			contactListImageView.Image = contact.Photo;
		}

	}
}