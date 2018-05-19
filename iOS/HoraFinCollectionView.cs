using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace WorklabsMx.iOS
{
    public partial class HoraFinCollectionView : UICollectionViewController
    {
        
		public HoraSeleccionada HoraFinDelegate;
		public List<string> Horas = new List<string>();

        public HoraFinCollectionView (IntPtr handle) : base (handle)
        {
        }


		public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.CollectionView.PagingEnabled = true;
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }


        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            if (this.Horas != null)
            {
                return this.Horas.Count;
            }
            return 0;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var CeldaHoraInicio = (CeldaHoraFin)this.CollectionView.DequeueReusableCell("CeldaHoraFin", indexPath);
            CeldaHoraInicio.UpdateCell(this.Horas[indexPath.Row]);
            return CeldaHoraInicio;
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

        public override void ItemSelected(UICollectionView collectionView, NSIndexPath indexPath)
        {
			HoraFinDelegate.SeleccionarHoraFin(Horas[indexPath.Row]);
        }

        
    }
}