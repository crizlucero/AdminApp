using System;
using UIKit;
using System.Collections.Generic;
using WorklabsMx.Models;
using BigTed;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.iOS.Models;
using Foundation;

namespace WorklabsMx.iOS
{

    public interface ColeccionMembresiasInt
    {
        void MembresiaSeleccionada(MembresiaModel MembresiaSeleccionada);
    }

    public partial class ColeccionMembresias : UICollectionViewController
    {
        public List<MembresiaModel> allMembresias = new List<MembresiaModel>();

        public ColeccionMembresiasInt MembresiasDelegate;

        private MembresiaModel MembresiaSelecionada = new MembresiaModel();

        public ColeccionMembresias (IntPtr handle) : base (handle)
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
            if(this.allMembresias != null)
            {
                return this.allMembresias.Count;
            }
            return 0;

        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var celdaMembresias = (CeldaMembresias)this.CollectionView.DequeueReusableCell("CeldaMembresias", indexPath);
            celdaMembresias.UpdateCell(this.allMembresias[indexPath.Row]);
            return celdaMembresias;
        }

        [Export("collectionView:layout:insetForSectionAtIndex:")]
        public virtual UIEdgeInsets GetInsetForSection(UICollectionView collectionView, UICollectionViewLayout layout, Int32 section)
        {
            var sectionInsets = new UIEdgeInsets(3, 1, 2, 1);
            return sectionInsets;
        }

       /* [Export("collectionView:layout:minimumLineSpacingForSectionAtIndex:")]
        public nfloat GetMinimumLineSpacingForSection(UICollectionView collectionView, UICollectionViewLayout layout, nint section)
        {
            return 5;
        }*/

        [Export("collectionView:layout:minimumInteritemSpacingForSection:")]
        public nfloat GetMinimumInteritemSpacingForSection(UICollectionView view, UICollectionViewLayout layout, nint section)
        {
            return 0;
        }

        public override void ItemSelected(UICollectionView collectionView, NSIndexPath indexPath)
        {
            MembresiasDelegate.MembresiaSeleccionada(allMembresias[indexPath.Row]);
        }

  
    }
}