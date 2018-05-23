using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace WorklabsMx.iOS
{

	public interface CantidadPersonasSeleccionadas
	{
		void SeleccionarCantidadPersonas(string CantidadPersonas);
	}

    public partial class CantidadPersonasCollection : UICollectionViewController
    {
		public CantidadPersonasSeleccionadas CantidadPersonasDelegate;
		public List<string> CantidadPersonas = new List<string>();
		private int SelectedCell = -1;
		CeldaCantidadPersonas CeldaCantidadPersonas;

        public CantidadPersonasCollection (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.CollectionView.PagingEnabled = true;
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }


        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
			if (this.CantidadPersonas != null)
            {
				return this.CantidadPersonas.Count;
            }
            return 0;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
			CeldaCantidadPersonas = (CeldaCantidadPersonas)this.CollectionView.DequeueReusableCell("CeldaCantidadPersonas", indexPath);
			CeldaCantidadPersonas.UpdateCell(this.CantidadPersonas[indexPath.Row], indexPath.Row);
			CeldaCantidadPersonas.ReloadCells();
			if (SelectedCell == indexPath.Row)
            {
                CeldaCantidadPersonas.PintarCeldas();
            }
			CeldaCantidadPersonas.PersonasSeleccionadasDelegate = this;
			return CeldaCantidadPersonas;
        }

        [Export("collectionView:layout:insetForSectionAtIndex:")]
        public virtual UIEdgeInsets GetInsetForSection(UICollectionView collectionView, UICollectionViewLayout layout, Int32 section)
        {
            var sectionInsets = new UIEdgeInsets(5, 7, 2, 2);
            return sectionInsets;
        }

        [Export("collectionView:layout:minimumLineSpacingForSectionAtIndex:")]
        public nfloat GetMinimumLineSpacingForSection(UICollectionView collectionView, UICollectionViewLayout layout, nint section)
        {
            return 5;
        }
        
      
    }
	public partial class CantidadPersonasCollection : PersonasSeleccionadas
	{
		public void SeleccionarPersonas(string Personas, int SelectedCell)
		{
			this.SelectedCell = SelectedCell;
			this.CollectionView.ReloadData();
			CantidadPersonasDelegate.SeleccionarCantidadPersonas(Personas);
		}
	}
    
}