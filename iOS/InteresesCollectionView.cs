using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using System.Collections.Generic;
using WorklabsMx.Controllers;
using CoreGraphics;
using WorklabsMx.iOS.Helpers;


namespace WorklabsMx.iOS
{
    public partial class InteresesCollectionView : UICollectionViewController
    {

        const string IDENTIFIER_INTERESE_CELL = "Intereses";
        const string IDENTIFIER_NOINTERESES_CELL = "NoIntereses";

        public List<EtiquetaModel> EtiquetasIntereses = new List<EtiquetaModel>();

        bool HayIntereses;

        public InteresesCollectionView (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override nint NumberOfSections(UICollectionView collectionView)
        {
            return 1;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            if(EtiquetasIntereses.Count >= 1)
            {
                HayIntereses = true;
                return this.EtiquetasIntereses.Count;
            }
            else
            {
                HayIntereses = false;
                return 1;
            }
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            if (HayIntereses)
            {
                var celdaHabilidades = (CeldaIntereses)this.CollectionView.DequeueReusableCell(IDENTIFIER_INTERESE_CELL, indexPath);
                celdaHabilidades.UpdateCell(this.EtiquetasIntereses[indexPath.Row]);
                return celdaHabilidades;
            }
            else
            {
                var NoIntereses = (CeldaNoIntereses)this.CollectionView.DequeueReusableCell(IDENTIFIER_NOINTERESES_CELL, indexPath);
                NoIntereses.UpdateInfo();
                return NoIntereses;
            }

        }

        [Export("collectionView:layout:insetForSectionAtIndex:")]
        public virtual UIEdgeInsets GetInsetForSection(UICollectionView collectionView, UICollectionViewLayout layout, Int32 section)
        {
            var sectionInsets = new UIEdgeInsets(2, 2, 0, 2);
            return sectionInsets;
        }


        [Export("collectionView:layout:minimumLineSpacingForSectionAtIndex:")]
        public nfloat GetMinimumLineSpacingForSection(UICollectionView collectionView, UICollectionViewLayout layout, nint section)
        {
            return 2;
        }

        [Export("collectionView:layout:referenceSizeForHeaderInSection:")]
        public virtual CGSize GetReferenceSizeForHeader(UICollectionView collectionView, UICollectionViewLayout layout, Int32 section)
        {
            return new CGSize(this.CollectionView.Frame.Size.Width, 60);
        }

    }
}