using System;
using UIKit;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using System.Collections.Generic;
using Foundation;

namespace WorklabsMx.iOS
{
    public partial class coleccionColaboradores : UICollectionViewController
    {

        const string IDENTIFIER_COLABORADORES = "Colaboradores";
        public UsuarioModel Miembro = new UsuarioModel();

        List<UsuarioModel> Colaboradores;

        public coleccionColaboradores (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Colaboradores = new UsuariosController().GetColaboradoresCardAsync(Miembro.Usuario_Id);
        }

        public override nint NumberOfSections(UICollectionView collectionView)
        {
            return 1;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return this.Colaboradores.Count;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var CeldaColaboradores = (CeldaColaboradores)this.CollectionView.DequeueReusableCell(IDENTIFIER_COLABORADORES, indexPath);
            CeldaColaboradores.UpdateCell(this.Colaboradores[indexPath.Row]);
            return CeldaColaboradores;
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