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
    public partial class ColeccionEditarIntereses : UICollectionViewController
    {

        const string IDENTIFIER_INTERESE_CELL = "Intereses";

        public List<EtiquetaModel> EtiquetasIntereses = new List<EtiquetaModel>();

        public ColeccionEditarIntereses (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.CollectionView.ReloadData();
        }

        public override nint NumberOfSections(UICollectionView collectionView)
        {
            return 1;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return this.EtiquetasIntereses.Count;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var celdaHabilidades = (CeldaIntereses)this.CollectionView.DequeueReusableCell(IDENTIFIER_INTERESE_CELL, indexPath);
            celdaHabilidades.UpdateCell(this.EtiquetasIntereses[indexPath.Row]);
            return celdaHabilidades;
        }

        [Export("collectionView:layout:insetForSectionAtIndex:")]
        public virtual UIEdgeInsets GetInsetForSection(UICollectionView collectionView, UICollectionViewLayout layout, Int32 section)
        {
            var sectionInsets = new UIEdgeInsets(5, 5, 5, 5);
            return sectionInsets;
        }

        [Export("collectionView:layout:minimumLineSpacingForSectionAtIndex:")]
        public nfloat GetMinimumLineSpacingForSection(UICollectionView collectionView, UICollectionViewLayout layout, nint section)
        {
            return 0;
        }


    }
}