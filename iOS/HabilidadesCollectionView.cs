using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using System.Collections.Generic;

namespace WorklabsMx.iOS
{
    public partial class HabilidadesCollectionView : UICollectionViewController
    {

        const string IDENTIFIER_HABILIDADES_CELL = "Habilidades";

        public List<EtiquetaModel> EtiquetasHabilidades = new List<EtiquetaModel>();

        public HabilidadesCollectionView (IntPtr handle) : base (handle)
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
            return this.EtiquetasHabilidades.Count;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var celdaHabilidades = (CeldaHabilidades)this.CollectionView.DequeueReusableCell(IDENTIFIER_HABILIDADES_CELL, indexPath);
            celdaHabilidades.UpdateCell(this.EtiquetasHabilidades[indexPath.Row]);
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

        [Export("collectionView:layout:minimumInteritemSpacingForSection:")]
        public nfloat GetMinimumInteritemSpacingForSection(UICollectionView view, UICollectionViewLayout layout, nint section)
        {
            return 0;
        }

    }
}