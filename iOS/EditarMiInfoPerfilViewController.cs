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

    public interface EventosActualizarHabilidades
    {
        void ActualizarHabilidades(List<EtiquetaModel> EtiquetasHabilidades);
    }

    public interface EventosActualizarInfoPerfil
    {
        void InfoSobreMi(UsuarioModel InfoActualizar);
    }

    public partial class EditarMiInfoPerfilViewController : UIViewController
    {

        UIStoryboardSegue segueHabilidades;

        public EventosActualizarHabilidades HabilidadesDelegate;

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
            txtMiInfo.Text = Miembro.Usuario_Descripcion;

            txtMiInfo.Changed += (sender, e) =>
            {
                MiembroActualizar.Usuario_Descripcion = txtMiInfo.Text;
                EditarInfoDelegate.InfoSobreMi(MiembroActualizar);
            };

            txtEmail.EditingChanged += (sender, e) =>
            {
                MiembroActualizar.Usuario_Correo_Electronico = txtEmail.Text;
                EditarInfoDelegate.InfoSobreMi(MiembroActualizar);
            };

            txtCelular.EditingChanged += (sender, e) =>
            {
                MiembroActualizar.Usuario_Celular = txtCelular.Text;
                EditarInfoDelegate.InfoSobreMi(MiembroActualizar);
            };

            txtTelefono.EditingChanged += (sender, e) =>
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
            EtiquetaModel EtiquetaHabilidad = new EtiquetaModel();
            EtiquetaHabilidad.Etiqueta_Nombre = txtHabilidad.Text;
            EtiquetasHabilidades.Add(EtiquetaHabilidad);
            //HabilidadesDelegate.ActualizarHabilidades(EtiquetasHabilidades);
            /*this.ViewDidLoad();
            this.ViewWillAppear(true);
            this.LoadView();*/
            this.PrepareForSegue(this.segueHabilidades, null);
        }

        partial void btnAgregarInteres_Touch(UIButton sender)
        {
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            
            if (segue.Identifier == "EditarHabilidades")
            {
                this.segueHabilidades = segue;
                var VistaHabilidades = (ColeccionEditarHabilidades)segue.DestinationViewController;
                VistaHabilidades.EtiquetasHabilidades = EtiquetasHabilidades;
                VistaHabilidades.ViewDidLoad();
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