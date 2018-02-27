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

    public interface ColeccionProductosInt
    {
        void ProductoSeleccionado(ProductoModel ProductoSeleccionado);
    }

    public partial class ColeccionProductos : UICollectionViewController
    {

        public ColeccionProductosInt ProductosDelegate;

        public List<ProductoModel> allProducts = new List<ProductoModel>();

        private ProductoModel ProductoSeleccionado = new ProductoModel();

        public ColeccionProductos (IntPtr handle) : base (handle)
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
            return this.allProducts.Count;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var celdaProductos = (CeldaProductos)this.CollectionView.DequeueReusableCell("CeldaProductos", indexPath);
            celdaProductos.UpdateCell(this.allProducts[indexPath.Row]);
            return celdaProductos;
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
            return 5;
        }

        [Export("collectionView:layout:minimumInteritemSpacingForSection:")]
        public nfloat GetMinimumInteritemSpacingForSection(UICollectionView view, UICollectionViewLayout layout, nint section)
        {
            return 0;
        }

        public override void ItemSelected(UICollectionView collectionView, NSIndexPath indexPath)
        {
            ProductosDelegate.ProductoSeleccionado(allProducts[indexPath.Row]);
        }

    }
}