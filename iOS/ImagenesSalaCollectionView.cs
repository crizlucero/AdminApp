using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace WorklabsMx.iOS
{
    public partial class ImagenesSalaCollectionView : UICollectionViewController
    {

		public List<UIImage> ImagenesSala = new List<UIImage>();

        public ImagenesSalaCollectionView (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
        {
            base.ViewDidLoad();

        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }


        public override nint NumberOfSections(UICollectionView collectionView)
        {
            return 1;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
			if (this.ImagenesSala != null)
            {
				return this.ImagenesSala.Count;
            }
            return 0;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
			var CeldaSalas = (CeldaImagenSala)this.CollectionView.DequeueReusableCell("CeldaImagenSala", indexPath);
			CeldaSalas.UpdateCell(this.ImagenesSala[indexPath.Row]);
            return CeldaSalas;
        }

        [Export("collectionView:layout:insetForSectionAtIndex:")]
        public virtual UIEdgeInsets GetInsetForSection(UICollectionView collectionView, UICollectionViewLayout layout, Int32 section)
        {
            var sectionInsets = new UIEdgeInsets(5, 7, 2, 2);
            return sectionInsets;
        }

        [Export("collectionView:layout:minimumLineSpacingForSectionAtIndex:")]
        public nfloat GetMinimumLineSpacingForSection(UICollectionView collectionView, UICollectionViewLayout layout, nint section)
        {
            return 5;
        }
        

    }
}