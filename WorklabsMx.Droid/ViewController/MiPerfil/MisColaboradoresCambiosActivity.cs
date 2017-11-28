
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using WorklabsMx.Controllers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "MisColaboradoresCambiosActivity")]
    public class MisColaboradoresCambiosActivity : Activity
    {
        string colaborador_id, colaborador_tipo;
        EditText txtNombre, txtApellidos, txtCorreo, txtNacimiento,
        txtProfesion, txtPuesto, txtHabilidades, txtTelefono, txtCelular;
        Spinner spGenero;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ColaboradorCambioLayout);
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.MisColaboradores);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            //ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);
            InitiateView();
            colaborador_id = Intent.GetStringExtra("colaborador_id");
            colaborador_tipo = Intent.GetStringExtra("colaborador_tipo");
            if (!string.IsNullOrEmpty(colaborador_id) && !string.IsNullOrEmpty(colaborador_tipo))
            {
                FillData();
            }
        }

        void InitiateView()
        {
            txtNombre = FindViewById<EditText>(Resource.Id.txtNombre);
            txtApellidos = FindViewById<EditText>(Resource.Id.txtApellidos);
            txtCorreo = FindViewById<EditText>(Resource.Id.txtEmail);
            txtNacimiento = FindViewById<EditText>(Resource.Id.txtFechaNacimiento);
            txtProfesion = FindViewById<EditText>(Resource.Id.txtProfesion);
            txtPuesto = FindViewById<EditText>(Resource.Id.txtPuesto);
            txtHabilidades = FindViewById<EditText>(Resource.Id.txtHabilidades);
            txtTelefono = FindViewById<EditText>(Resource.Id.txtTelefono);
            txtCelular = FindViewById<EditText>(Resource.Id.txtCelular);
            spGenero = FindViewById<Spinner>(Resource.Id.txtGenero);
            spGenero.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleDropDownItem1Line, new PickerItemsController().GetGeneros().ToArray());
        }

        void FillData()
        {
            ColaboradorModel colaborador = new ColaboradoresController().GetColaborador(colaborador_id);

            txtNombre.Text = colaborador.Colaborador_Nombre;
            txtApellidos.Text = colaborador.Colaborador_Apellidos;
            txtCorreo.Text = colaborador.Colaborador_Correo_Electronico;
            txtNacimiento.Text = colaborador.Colaborador_Fecha_Nacimiento;
            txtProfesion.Text = colaborador.Colaborador_Profesion;
            txtPuesto.Text = colaborador.Colaborador_Puesto;
            txtHabilidades.Text = colaborador.Colaborador_Habilidades;
            txtTelefono.Text = colaborador.Colaborador_Telefono;
            txtCelular.Text = colaborador.Colaborador_Celular;
            spGenero.SetSelection(Convert.ToInt32(colaborador.Genero_Id) - 1, true);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.send_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {

            switch (item.ItemId)
            {
                case Resource.Id.menu_send:
                    new ColaboradoresController().AddChangeColaborador(PerpetualEngine.Storage.SimpleStorage.EditGroup("Login").Get("Empresa_Id"), txtNombre.Text, txtApellidos.Text,
                                                                       txtCorreo.Text, txtTelefono.Text, txtCelular.Text, txtProfesion.Text,
                                                                       txtPuesto.Text, txtHabilidades.Text, txtNacimiento.ToString(),
                                                                       colaborador_id);
                    break;
                default:
                    StartActivity(new Intent(this, typeof(TabColaboradoresActivity)));
                    Finish();
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}
