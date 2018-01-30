
using System;
using System.Collections.Generic;
using System.Linq;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Support.V4.Content;
using Android.Views;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.Helpers;
using WorklabsMx.Enum;
using WorklabsMx.Models;

namespace WorklabsMx.Droid.ViewElement
{
    public class MenuView
    {
        readonly Activity context;
        readonly SimpleStorage localStorage;
        List<string> DataUsuario;
        readonly List<ItemsMenu> ListMenu;
        public MenuView(Activity context)
        {
            this.context = context;
            localStorage = SimpleStorage.EditGroup("Login");
            ListMenu = new EscritorioController().GetMenuAndroid(Convert.ToInt32(localStorage.Get("Usuario_Tipo")));
        }

        public void FillMemberCard(ref string nombre, ref string foto, ref string puesto, ref string empresa)
        {
            DataUsuario = new UsuariosController().GetMemberName(localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"));
            nombre = DataUsuario[(int)CamposMiembro.Usuario_Nombre];
            foto = DataUsuario[(int)CamposMiembro.Usuario_Fotografia];
            puesto = DataUsuario[(int)CamposMiembro.Usuario_Puesto];
            empresa = DataUsuario[(int)CamposMiembro.Usuario_Empresa_Nombre];
            ImageView imgFoto = context.FindViewById<ImageView>(Resource.Id.imgProfileMenu);
            Bitmap bmFoto = ImagesHelper.GetImageBitmapFromUrl(foto);
            if (bmFoto != null)
                imgFoto.SetImageBitmap(bmFoto);
            else
                imgFoto.SetImageResource(Resource.Mipmap.ic_profile_empty);
            TextView NombreUsuario = context.FindViewById<TextView>(Resource.Id.lblNombreMenu);
            NombreUsuario.Text = nombre;
            NombreUsuario.SetMaxWidth(context.Resources.DisplayMetrics.WidthPixels - 110);
            context.FindViewById<TextView>(Resource.Id.lblEmpresaMenu).Text = empresa;
        }

        public void FillMenu()
        {
            TableLayout menuLayout = context.FindViewById<TableLayout>(Resource.Id.menu_layout);
            menuLayout.RemoveAllViews();
            menuLayout.SetMinimumWidth(context.Resources.DisplayMetrics.WidthPixels);
            ListMenu.Where((ItemsMenu arg) => arg.Menu_Padre_Id == (localStorage.Get("Parent") ?? "")).ToList().ForEach(menu =>
            {
                TableRow row = new TableRow(context);
                View line = new View(context);
                line.SetBackgroundColor(Color.LightGray);
                line.SetMinimumWidth(context.Resources.DisplayMetrics.WidthPixels);
                line.SetMinimumHeight(2);
                row.AddView(line);
                menuLayout.AddView(row);
                row = new TableRow(context);
                Drawable icon = ContextCompat.GetDrawable(context, context.Resources.GetIdentifier(menu.Image, "mipmap", context.PackageName));
                icon.SetTintList(context.GetColorStateList(Resource.Color.comment_pressed));
                icon.SetBounds(0, 0, 50, 50);
                Button btnMenu = new Button(context)
                {
                    Text = menu.Label,
                    TextAlignment = TextAlignment.ViewStart
                };
                btnMenu.SetTextColor(Color.White);
                btnMenu.Gravity = GravityFlags.CenterVertical | GravityFlags.Left;
                btnMenu.SetBackgroundColor(Color.Transparent);
                btnMenu.SetCompoundDrawables(icon, null, null, null);
                btnMenu.Click += delegate
                {
                    switch (menu.Controller)
                    {
                        case "MyMembershipActivity": context.StartActivity(new Intent(context, typeof(MyMembershipActivity))); break;
                        case "SubMenuActivity":
                            localStorage.Put("Parent", menu.Menu_Id);
                            FillMenu();
                            break;
                        case "LogoutActivity":
                            localStorage.Delete("Usuario_Id"); localStorage.Delete("Usuario_Tipo"); localStorage.Delete("Empresa_Id");
                            context.StartActivity(new Intent(context, typeof(LoginActivity)));
                            context.Finish();
                            break;
                        case "ColeccionProductosActivity": context.StartActivity(new Intent(context, typeof(ColeccionProductosActivity))); break;
                        case "ReservaSalaJuntasActivity": context.StartActivity(new Intent(context, typeof(TabSalasJuntasHistorialActivity))); break;
                        case "RegistroInvitadosActivity": context.StartActivity(new Intent(context, typeof(InvitadosActivity))); break;
                        case "PerfilActivity": context.StartActivity(new Intent(context, typeof(TabPerfilActivity))); break;
                        case "DatosFacturacionActivity": context.StartActivity(new Intent(context, typeof(DatosFacturacionActivity))); break;
                        case "MisColaboradoresActivity": context.StartActivity(new Intent(context, typeof(TabColaboradoresActivity))); break;
                        case "DirectorioActivity": context.StartActivity(new Intent(context, typeof(DirectorioActivity))); break;
                    }
                };
                row.AddView(btnMenu);
                menuLayout.AddView(row);
            });
        }
    }
}