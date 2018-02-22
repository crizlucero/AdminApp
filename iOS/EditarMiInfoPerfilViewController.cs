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
        void Etiquetas(EtiquetaModel Etiquetas);
    }

    public partial class EditarMiInfoPerfilViewController : UIViewController
    {

        UIStoryboardSegue segueHabilidades;

        UIStoryboardSegue segueIntereses;

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
            txtInteres.AttributedPlaceholder = new NSAttributedString("  Escriba un interes", null, UIColor.Clear.FromHex(0x767676));
            txtHabilidad.AttributedPlaceholder = new NSAttributedString("  Escriba una habilidad", null, UIColor.Clear.FromHex(0x767676));
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
                    if (Etiqueta.Etiqueta_Tipo == "Habilidad")
                    {
                        EtiquetasHabilidades.Add(Etiqueta);
                    }
                    else if (Etiqueta.Etiqueta_Tipo == "Interes")
                    {
                        EtiquetasIntereses.Add(Etiqueta);
                    }
                }
            }


        }

        partial void btnAgregarHabilad_Touch(UIButton sender)
        {
            if (txtHabilidad.Text != "")
            {
                EtiquetaModel EtiquetaHabilidad = new EtiquetaModel();
                EtiquetaHabilidad.Etiqueta_Nombre = txtHabilidad.Text;
                EtiquetaHabilidad.Etiqueta_Tipo = "Habilidad";
                bool encontrada = false;
                if (EtiquetasHabilidades.Count > 0)
                {
                    foreach (EtiquetaModel Habilidad in EtiquetasHabilidades)
                    {
                        if (EtiquetaHabilidad.Etiqueta_Nombre == Habilidad.Etiqueta_Nombre)
                        {
                            encontrada = true;
                        }
                    }
                }

                if (!encontrada)
                {
                    EtiquetasHabilidades.Add(EtiquetaHabilidad);
                    EditarInfoDelegate.Etiquetas(EtiquetaHabilidad);
                    this.PrepareForSegue(this.segueHabilidades, null);
                }
                else
                {
                    new MessageDialog().SendToast("La etiqueta ya existe");
                }
            }
            else
            {
                
            }
           
               
        }

        partial void btnAgregarInteres_Touch(UIButton sender)
        {
            if(txtInteres.Text != "")
            {
                EtiquetaModel EtiquetaInteres = new EtiquetaModel();
                EtiquetaInteres.Etiqueta_Nombre = txtInteres.Text;
                EtiquetaInteres.Etiqueta_Tipo = "Interes";
                bool encontrada = false;
                if (EtiquetasIntereses.Count > 0)
                {
                    foreach (EtiquetaModel Interes in EtiquetasIntereses)
                    {
                        if (EtiquetaInteres.Etiqueta_Nombre == Interes.Etiqueta_Nombre)
                        {
                            encontrada = true;
                        }
                    }
                }

                if (!encontrada)
                {
                    EtiquetasIntereses.Add(EtiquetaInteres);
                    EditarInfoDelegate.Etiquetas(EtiquetaInteres);
                    this.PrepareForSegue(this.segueIntereses, null);
                }
                else
                {
                    new MessageDialog().SendToast("La etiqueta ya existe");
                }
            }
            else
            {
                
            }

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
                this.segueIntereses = segue;
                var VistaIntereses = (ColeccionEditarIntereses)segue.DestinationViewController;
                VistaIntereses.EtiquetasIntereses = EtiquetasIntereses;
                VistaIntereses.ViewDidLoad();
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