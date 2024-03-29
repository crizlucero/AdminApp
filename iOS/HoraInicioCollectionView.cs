using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace WorklabsMx.iOS
{

    public interface HoraSeleccionada
	{
		void SeleccionarHoraInicio(string HoraInicioSeleccionada);
		void SeleccionarHoraFin(string HoraFinSeleccionada);
	}

    public partial class HoraInicioCollectionView : UICollectionViewController
    {
		public HoraSeleccionada HoraInicioDelegate;
		public List<string> Horas = new List<string>();
		private int SelectedCell = -1;
        public HoraInicioCollectionView (IntPtr handle) : base (handle)
        {
        }
       
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			this.CollectionView.ReloadData();
			this.CollectionView.PagingEnabled = true;
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
		}


		public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
			if (this.Horas != null)
            {
				return this.Horas.Count;
            }
            return 0;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
			var CeldaHoraInicio = (CeldaHoraInicio)this.CollectionView.DequeueReusableCell("CeldaHoraInicio", indexPath);
			CeldaHoraInicio.UpdateCell(this.Horas[indexPath.Row], indexPath.Row);
            CeldaHoraInicio.ReloadCells();
            if (SelectedCell == indexPath.Row)
            {
                CeldaHoraInicio.PintarCeldas();
            }
            CeldaHoraInicio.HoraInicioDelegate = this;
            return CeldaHoraInicio;
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
    

	public partial class HoraInicioCollectionView : HoraInicioSeleccionada
    {
        public void SeleccionarHoraInicio(string HoraInicio, int SelectedCell)
        {
            this.SelectedCell = SelectedCell;
            CollectionView.ReloadData();
			HoraInicioDelegate.SeleccionarHoraInicio(HoraInicio);
        }
    }
}