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
        const string IDENTIFIER_NOHABILIDADES_CELL = "NoHabilidades";

        public List<EtiquetaModel> EtiquetasHabilidades = new List<EtiquetaModel>();

        bool HayHabilidades;

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
            if (this.EtiquetasHabilidades.Count >= 1)
            {
                HayHabilidades = true;
                return this.EtiquetasHabilidades.Count;
            }
            HayHabilidades = false;
            return 1;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            if (HayHabilidades)
            {
                var celdaHabilidades = (CeldaHabilidades)this.CollectionView.DequeueReusableCell(IDENTIFIER_HABILIDADES_CELL, indexPath);
                celdaHabilidades.UpdateCell(this.EtiquetasHabilidades[indexPath.Row]);
                return celdaHabilidades;
            }
            else
            {
                return (CeldaNoHabilidades)CollectionView.DequeueReusableCell(IDENTIFIER_NOHABILIDADES_CELL, indexPath);
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

    }
}