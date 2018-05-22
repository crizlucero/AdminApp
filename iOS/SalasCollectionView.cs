using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using System.Collections.Generic;

namespace WorklabsMx.iOS
{

    public interface SalaSeleccionada
	{
		void SalaSeleccionada(SalaJuntasModel SalaSeleccionada);
	}

	public partial class SalasCollectionView : UICollectionViewController
    {

		public SalaSeleccionada SalaSeleccionadaDelegate;
		public List<SalaJuntasModel> SalasJuntas = new List<SalaJuntasModel>();
		public SalaJuntasReservacionModel Reservaciones = new SalaJuntasReservacionModel();

        public SalasCollectionView (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
            
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
		}
        

        public override nint NumberOfSections(UICollectionView collectionView)
        {
            return 1;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
			if (this.SalasJuntas != null)
            {
				return this.SalasJuntas.Count;
            }
            return 0;
        }

		public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
			var CeldaSalas = (SalasCollectionCell)this.CollectionView.DequeueReusableCell("CeldaSala", indexPath);
			CeldaSalas.UpdateCell(this.SalasJuntas[indexPath.Row]);
			return CeldaSalas;
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

        public override void ItemSelected(UICollectionView collectionView, NSIndexPath indexPath)
        {
			SalaSeleccionadaDelegate.SalaSeleccionada(SalasJuntas[indexPath.Row]);
        }


	}
}