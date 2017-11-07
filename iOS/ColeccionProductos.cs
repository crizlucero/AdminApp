using Foundation;
using System;
using UIKit;
using WorklabsMx.Controllers;
using System.Collections.Generic;
using WorklabsMx.Models;
using CoreGraphics;

namespace WorklabsMx.iOS
{
    public partial class ColeccionProductos : UICollectionViewController
    {

        const string IDENTIFIER_PRODUCTS_CELL = "productsCell";

        const string IDENTIFIER_HEADER = "ProductosHeader";

        List<ProductoModel> products = new List<ProductoModel>();

        public ColeccionProductos(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.products = new PickerItemsController().GetProductos();
        }

        //[Export("collectionView:viewForSupplementaryElementOfKind:atIndexPath:")]
        public override UICollectionReusableView GetViewForSupplementaryElement(UICollectionView collectionView, NSString elementKind, NSIndexPath indexPath)
        {
            var header = (ProductosHeader)collectionView.DequeueReusableSupplementaryView(elementKind, IDENTIFIER_HEADER, indexPath);
            return header;
        }

        public override nint NumberOfSections(UICollectionView collectionView)
        {
            return 1;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return this.products.Count;
        }


        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cellProducts = (ProductsCell) this.CollectionView.DequeueReusableCell(IDENTIFIER_PRODUCTS_CELL, indexPath);
            cellProducts.UpdateCell(this.products[indexPath.Row]);
            return cellProducts;
        }


        [Export("collectionView:layout:sizeForItemAtIndexPath:")]
        public virtual CGSize GetSizeForItem(UICollectionView collectionView, UICollectionViewLayout layout, NSIndexPath indexPath)
        {
            return new CGSize((this.CollectionView.Layer.Bounds.Size.Width / 2) - 20, 200);
        }

        [Export("collectionView:layout:insetForSectionAtIndex:")]
        public virtual UIEdgeInsets GetInsetForSection(UICollectionView collectionView, UICollectionViewLayout layout, Int32 section)
        {
            var sectionInsets = new UIEdgeInsets(10, 10, 0, 10);
            return sectionInsets;
        }

        [Export("collectionView:layout:minimumLineSpacingForSectionAtIndex:")]
        public nfloat GetMinimumLineSpacingForSection(UICollectionView collectionView, UICollectionViewLayout layout, nint section)
        {
            return 10;
        }

        [Export("collectionView:layout:referenceSizeForHeaderInSection:")]
        public virtual CGSize GetReferenceSizeForHeader(UICollectionView collectionView, UICollectionViewLayout layout, Int32 section)
        {
            return new CGSize(this.CollectionView.Frame.Size.Width, 60);
        }




    }

}