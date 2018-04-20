
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Support.V4.Content;
using Android.Support.V4.Graphics.Drawable;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.Helpers;
using WorklabsMx.Enum;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid.ViewElement
{
    public class MenuView
    {
        readonly Activity context;
        readonly SimpleStorage localStorage;
        List<string> DataUsuario;
        readonly List<ItemsMenu> ListMenu;
        readonly string usuario_imagen_path;
        public MenuView(Activity context)
        {
            this.context = context;
            localStorage = SimpleStorage.EditGroup("Login");
            ListMenu = new EscritorioController().GetMenuAndroid(Convert.ToInt32(localStorage.Get("Usuario_Tipo")));
            usuario_imagen_path = new ConfigurationsController().GetListConfiguraciones().Find(parametro => parametro.Parametro_Descripcion == "RUTA DE IMAGENES DE PERFILES DE USUARIOS").Parametro_Varchar_1;
        }

        public void FillMemberCard(ref string nombre, ref byte[] foto, ref string puesto, ref string empresa)
        {
            DataUsuario = new UsuariosController().GetMemberName(localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"));
            nombre = DataUsuario[(int)CamposMiembro.Usuario_Nombre];
            foto = new UploadImages().DownloadFileFTP(DataUsuario[(int)CamposMiembro.Usuario_Fotografia], usuario_imagen_path);
            puesto = DataUsuario[(int)CamposMiembro.Usuario_Puesto];
            empresa = DataUsuario[(int)CamposMiembro.Usuario_Empresa_Nombre];
            ImageView imgFoto = context.FindViewById<ImageView>(Resource.Id.imgProfileMenu);
            if (foto.Length != 0)
                imgFoto.SetImageBitmap(ImagesHelper.GetRoundedShape(BitmapFactory.DecodeByteArray(foto, 0, foto.Length)));
            else
                imgFoto.SetImageResource(Resource.Mipmap.ic_profile_empty);
            TextView NombreUsuario = context.FindViewById<TextView>(Resource.Id.lblNombreMenu);
            NombreUsuario.Text = nombre;
            NombreUsuario.SetMaxWidth(context.Resources.DisplayMetrics.WidthPixels - 110);
            context.FindViewById<TextView>(Resource.Id.lblEmpresaMenu).Text = empresa;
            context.FindViewById<GridLayout>(Resource.Id.glPerfil).Click += (sender, e) => ShowPerfilCard(new UsuariosController().GetMemberData(localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo")));
        }

        public void FillMenu()
        {
            TableLayout menuLayout = context.FindViewById<TableLayout>(Resource.Id.menu_layout);
            menuLayout.RemoveAllViews();
            menuLayout.SetMinimumWidth(context.Resources.DisplayMetrics.WidthPixels);
            ListMenu.Where((ItemsMenu arg) => arg.Menu_Padre_Id == (localStorage.Get("Parent") ?? "")).AsParallel().ToList().ForEach(menu =>
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
                if ((int)Build.VERSION.SdkInt > 22)
                    icon.SetTintList(context.GetColorStateList(Resource.Color.comment_pressed));
                else
                    DrawableCompat.SetTint(icon, ContextCompat.GetColor(context, Resource.Color.comment_pressed));
                icon.SetBounds(0, 0, 30, 30);
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
                    Intent intent;
                    switch (menu.Controller)
                    {
                        case "SubMenuActivity":
                            localStorage.Put("Parent", menu.Menu_Id);
                            FillMenu();
                            break;
                        case "LogoutActivity":
                            localStorage.Delete("Usuario_Id"); localStorage.Delete("Usuario_Tipo");
                            context.StartActivity(new Intent(context, typeof(LoginActivity)));
                            context.Finish();
                            break;
                        case "DirectorioActivity":
                            intent = new Intent(context, typeof(DirectorioActivity));
                            intent.PutExtra("Titulo", menu.Label);
                            context.StartActivity(intent); break;
                        case "ComprasActivity":
                            intent = new Intent(context, typeof(ComprasActivity));
                            intent.PutExtra("Titulo", menu.Label);
                            context.StartActivity(intent); break;
                        case "ReservaSalaJuntasActivity":
                            intent = new Intent(context, typeof(TabSalasJuntasHistorialActivity));
                            intent.PutExtra("Titulo", menu.Label);
                            context.StartActivity(intent); break;
                        case "RegistroInvitadosActivity":
                            intent = new Intent(context, typeof(InvitadosActivity));
                            intent.PutExtra("Titulo", menu.Label);
                            context.StartActivity(intent); break;
                        case "PerfilActivity":
                            intent = new Intent(context, typeof(PerfilCardActivity));
                            intent.PutExtra("Titulo", menu.Label);
                            intent.PutExtra("Miembro", JsonConvert.SerializeObject(new UsuariosController().GetMemberData(localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"))));
                            context.StartActivity(intent);
                            context.Finish();
                            break;
                        case "DatosFacturacionActivity":
                            intent = new Intent(context, typeof(DatosFacturacionActivity));
                            intent.PutExtra("Titulo", menu.Label);
                            context.StartActivity(intent); break;
                        case "AccesoActivity":
                            intent = new Intent(context, typeof(AccesoActivity));
                            intent.PutExtra("Titulo", menu.Label);
                            context.StartActivity(intent); break;
                        case "AboutUsActivity":
                            intent = new Intent(context, typeof(AboutUsActivity));
                            intent.PutExtra("Titulo", menu.Label);
                            context.StartActivity(intent); break;
                        default: break;
                    }

                };
                row.AddView(btnMenu);
                menuLayout.AddView(row);
            });
        }

        void ShowPerfilCard(UsuarioModel miembro)
        {
            Intent intent = new Intent(context, typeof(PerfilCardActivity));
            intent.PutExtra("Miembro", JsonConvert.SerializeObject(miembro));
            context.StartActivity(intent);
        }
    }
}