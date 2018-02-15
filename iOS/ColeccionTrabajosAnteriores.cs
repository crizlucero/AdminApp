using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using System.Collections.Generic;

namespace WorklabsMx.iOS
{
    public partial class ColeccionTrabajosAnteriores : UICollectionViewController
    {

        const string IDENTIFIER_TRABAJOS_CELL = "Trabajos";

        public List<EmpresaModel> Empresas_Anteriores;

        public ColeccionTrabajosAnteriores (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            Empresas_Anteriores = new List<EmpresaModel>();
        }
        public override nint NumberOfSections(UICollectionView collectionView)
        {
            return 1;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return this.Empresas_Anteriores.Count;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var celdaHabilidades = (CeldaTrabajosAnteriores)this.CollectionView.DequeueReusableCell(IDENTIFIER_TRABAJOS_CELL, indexPath);
            celdaHabilidades.UpdateCell(this.Empresas_Anteriores[indexPath.Row]);
            return celdaHabilidades;
        }

        [Export("collectionView:layout:insetForSectionAtIndex:")]
        public virtual UIEdgeInsets GetInsetForSection(UICollectionView collectionView, UICollectionViewLayout layout, Int32 section)
        {
            var sectionInsets = new UIEdgeInsets(2, 0, 2, 0);
            return sectionInsets;
        }

        [Export("collectionView:layout:minimumLineSpacingForSectionAtIndex:")]
        public nfloat GetMinimumLineSpacingForSection(UICollectionView collectionView, UICollectionViewLayout layout, nint section)
        {
            return 2;
        }
    }
}