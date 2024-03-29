﻿using System;
using System.Collections.Generic;
using Foundation;
//using PerpetualEngine.Storage;
using UIKit;
using WorklabsMx.Models;
using BigTed;
using System.Threading.Tasks;
using WorklabsMx.iOS.Helpers;
using SidebarNavigation;
using Plugin.Connectivity;

namespace WorklabsMx.iOS.Styles
{
    public class STLTableViewSource : UITableViewSource
    {

        internal List<ItemsMenu> TableItems;
        string CellIdentifier = "TableCell";
        readonly UITableViewController owner;
        public STLTableViewSource(List<ItemsMenu> items, UITableViewController owner)
        {
            TableItems = items;
            this.owner = owner;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            tableView.SeparatorStyle = UITableViewCellSeparatorStyle.None;
            UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
            string item = TableItems[indexPath.Row].Label;
            if (cell == null)
                cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier);
            cell.TextLabel.Text = item;
            if (!TableItems[indexPath.Row].Principal)
            {
                cell.ImageView.Image = UIImage.FromBundle(TableItems[indexPath.Row].Image);
            }
            else
            {
                using (var url = new NSUrl(TableItems[indexPath.Row].Image))
                {
                    var reach = CrossConnectivity.Current.IsReachable("http://desarrolloworklabs.com");
                    if (reach.Wait(0))
                    {
                        using (var data = NSData.FromUrl(url))
                        {
                            if (data != null)
                            {
                                cell.ImageView.Image = UIImage.LoadFromData(data);
                                cell.ImageView.Layer.MasksToBounds = true;
                                cell.ImageView.Layer.CornerRadius = 20;
                            }
                        }
                    }
                   
                }
            }
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section) => TableItems.Count;

        public override async void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            if (TableItems[indexPath.Row].Controller != null)
            {
                if (!TableItems[indexPath.Row].Controller.Contains("Login"))
                {

                    BTProgressHUD.Show();
                    await Task.Delay(500);
                    //var localStorage = SimpleStorage.EditGroup("Menu");

                    KeyChainHelper.SetKey("Menu_Id", TableItems[indexPath.Row].Menu_Id);
                    UIViewController controller = owner.Storyboard.InstantiateViewController(TableItems[indexPath.Row].Controller);

                    controller.Title = TableItems[indexPath.Row].Label;
                    BTProgressHUD.Dismiss();
                    owner.NavigationController.PushViewController(controller, true);
                }
                else
                {
                    KeyChainHelper.DeleteKey("EmailRegex");
                    KeyChainHelper.DeleteKey("LongitudEmail");
                    KeyChainHelper.DeleteKey("PasswordRegex");
                    KeyChainHelper.DeleteKey("LongitudPassword");
                    KeyChainHelper.DeleteKey("LongitudEmail");
                    KeyChainHelper.DeleteKey("Usuario_Id");
                    KeyChainHelper.DeleteKey("Usuario_Tipo");
                    KeyChainHelper.DeleteKey("Empresa_Id");
                    KeyChainHelper.DeleteKey("Colaborador_Id");
                    KeyChainHelper.DeleteKey("Menu_Id");

                    var controller = UIStoryboard.FromName("Main", null)
                        .InstantiateViewController("LoginViewController");
                    controller.Title = "Iniciar Sesión";
                    UIApplication.SharedApplication.Windows[0].RootViewController = controller;
                }
            }else if(indexPath.Row == 0){
				//var localStorage = SimpleStorage.EditGroup("Menu");
				KeyChainHelper.SetKey("Menu_Id", TableItems[indexPath.Row].Menu_Id);
                UIViewController controller = owner.Storyboard.InstantiateViewController("PerfilController");

				controller.Title = TableItems[indexPath.Row].Label;
				owner.NavigationController.PushViewController(controller, true);
            }
        }
    }
}