using Foundation;
using System;
using UIKit;

namespace MyContacts.iOS
{
	public partial class ContactListTableViewController : UITableViewController
	{
		public ContactListTableViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
			TableView.ReloadData();
		}

		public override nint NumberOfSections(UITableView tableView)
		{
			return 1;
		}

		public override nint RowsInSection(UITableView tableView, nint section)
		{
			return (UIApplication.SharedApplication.Delegate as AppDelegate).contactList.Count;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell("contactCell", indexPath) as ContactTableViewCell;

			var contact = (UIApplication.SharedApplication.Delegate as AppDelegate).contactList[indexPath.Row];
			cell.SetValues(contact);

			return cell;
		}

		public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
		{
			return 100.0f;
		}

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue(segue, sender);

			if (segue.Identifier == "showDetails")
			{
				var controller = segue.DestinationViewController as DetailsViewController;
				var indexPath = TableView.IndexPathForSelectedRow;
				controller.contact = (UIApplication.SharedApplication.Delegate as AppDelegate).contactList[indexPath.Row];
			}

		}
	}
}