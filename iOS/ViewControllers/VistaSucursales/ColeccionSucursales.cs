using Foundation;
using System;
using UIKit;
using WorklabsMx.Controllers;
using System.Collections.Generic;
using WorklabsMx.Models;
using CoreGraphics;
using WorklabsMx.iOS.Helpers;


namespace WorklabsMx.iOS
{
    public partial class ColeccionSucursales : UICollectionViewController
    {
        const string IDENTIFIER_SUCURSALES_CELL = "Sucursales";

        List<SucursalModel> products = new List<SucursalModel>();


        string SucursalId;

        public ColeccionSucursales(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.products = MenuHelper.ListaSucursales;
        }

        public override nint NumberOfSections(UICollectionView collectionView)
        {
            return 1;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return this.products.Count;
        }

        partial void btnBack_Touch(UIBarButtonItem sender)
        {
            this.NavigationController.PopViewController(true);
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cellProducts = (CeldaSucursales)this.CollectionView.DequeueReusableCell(IDENTIFIER_SUCURSALES_CELL, indexPath);
            cellProducts.UpdateCell(this.products[indexPath.Row]);
            cellProducts.EventosCeldasSucursalesDelegate = this;
            return cellProducts;
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

       
        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "ReservarSalaJuntas")
            {
                var ReservarView = (ReservarSalaJuntasViewTableController)segue.DestinationViewController;
                ReservarView.SucursalId = this.SucursalId;
            }
        }
    }

    public partial class ColeccionSucursales : EventosCeldasSucursales
    {
        public void SucursalSeleccionada(string SucursalId)
        {
            this.SucursalId = SucursalId;
            this.PerformSegue("ReservarSalaJuntas", null);
        }
    }
}