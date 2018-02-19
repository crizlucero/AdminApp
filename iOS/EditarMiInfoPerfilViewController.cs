using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using Foundation;
using Photos;
using AVFoundation;
using WorklabsMx.Helpers;
using WorklabsMx.Models;
using System.Collections.Generic;


namespace WorklabsMx.iOS
{

    public interface EventosActualizarInfoPerfil
    {
        void InfoSobreMi(UsuarioModel InfoActualizar);
    }

    public partial class EditarMiInfoPerfilViewController : UIViewController
    {

        public EventosActualizarInfoPerfil EditarInfoDelegate;

        public UsuarioModel Miembro = new UsuarioModel();
        UsuarioModel MiembroActualizar = new UsuarioModel();

        public List<EtiquetaModel> Etiquetas;

        List<EtiquetaModel> EtiquetasHabilidades = new List<EtiquetaModel>();
        List<EtiquetaModel> EtiquetasIntereses = new List<EtiquetaModel>();

        public EditarMiInfoPerfilViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            MiembroActualizar = Miembro;
            txtEmail.Text = Miembro.Usuario_Correo_Electronico;
            txtTelefono.Text = Miembro.Usuario_Telefono;
            txtCelular.Text = Miembro.Usuario_Celular;

            txtMiInfo.Changed += (sender, e) =>
            {
                MiembroActualizar.Usuario_Descripcion = txtMiInfo.Text;
                EditarInfoDelegate.InfoSobreMi(MiembroActualizar);
            };

            txtEmail.ValueChanged += (sender, e) =>
            {
                MiembroActualizar.Usuario_Correo_Electronico = txtEmail.Text;
                EditarInfoDelegate.InfoSobreMi(MiembroActualizar);
            };

            txtCelular.ValueChanged += (sender, e) =>
            {
                MiembroActualizar.Usuario_Celular = txtCelular.Text;
                EditarInfoDelegate.InfoSobreMi(MiembroActualizar);
            };

            txtTelefono.ValueChanged += (sender, e) =>
            {
                MiembroActualizar.Usuario_Telefono = txtTelefono.Text;
                EditarInfoDelegate.InfoSobreMi(MiembroActualizar);
            };

            StyleHelper.Style(this.vwEmail.Layer);
            StyleHelper.Style(this.vwTelefono.Layer);
            StyleHelper.Style(this.vwCelular.Layer);
            StyleHelper.Style(this.vwMiInfo.Layer);
            StyleHelper.Style(this.vwIntereses.Layer);
            StyleHelper.Style(this.vwHabilidades.Layer);
            var Tap = new UITapGestureRecognizer(this.Tapped);
            this.View.AddGestureRecognizer(Tap);
            this.Etiquetas = Miembro.Etiquetas;
            if (this.Etiquetas != null)
            {
                foreach (EtiquetaModel Etiqueta in Etiquetas)
                {
                    if (Etiqueta.Etiqueta_Tipo == "HABILIDAD")
                    {
                        EtiquetasHabilidades.Add(Etiqueta);
                    }
                    else if (Etiqueta.Etiqueta_Tipo == "INTERES")
                    {
                        EtiquetasIntereses.Add(Etiqueta);
                    }
                }
            }


        }

        partial void btnAgregarHabilad_Touch(UIButton sender)
        {
            ColeccionEditarHabilidades obj = new ColeccionEditarHabilidades(this.Handle);
            obj.CollectionView.ReloadData();
        }

        partial void btnAgregarInteres_Touch(UIButton sender)
        {
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "EditarHabilidades")
            {
                var VistaHabilidades = (ColeccionEditarHabilidades)segue.DestinationViewController;
                VistaHabilidades.EtiquetasHabilidades = EtiquetasHabilidades;
            }
            else if (segue.Identifier == "EditarIntereses")
            {
                var VistaIntereses = (ColeccionEditarIntereses)segue.DestinationViewController;
                VistaIntereses.EtiquetasIntereses = EtiquetasIntereses;
            }
            else if (segue.Identifier == "FechaNacimiento")
            {
                var BirthDateView = (FechaNacimientoPickerViewController)segue.DestinationViewController;
                BirthDateView.FechaSeleccionadaDelegate = this;
            }
        }

        private void Tapped(UITapGestureRecognizer Recognizer)
        {
            this.View.EndEditing(true);
        }

        partial void BtnFechaNacimiento_Touch(UIButton sender)
        {
            this.PerformSegue("FechaNacimiento", null);
        }
    }

    public partial class EditarMiInfoPerfilViewController : FechaNacimientoSeleccionada
    {
        public void FechaSeleccionada(String FechaNacimiento)
        {
            MiembroActualizar.Usuario_Fecha_Nacimiento = FechaNacimiento;
            EditarInfoDelegate.InfoSobreMi(MiembroActualizar);
            this.btnFechaNacimiento.SetTitle(FechaNacimiento, UIControlState.Normal);
        }
    } 
}