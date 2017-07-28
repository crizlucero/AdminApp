using System;
using System.Threading.Tasks;
using Foundation;
using UIKit;
using WorklabsMx.iOS.Styles;

namespace WorklabsMx.iOS.Helpers
{
    public class ImageGallery
    {
        UIImagePickerController imagePicker;
        public UIImageView imageView;
        public ImageGallery(UIImagePickerController imagePicker, UIImageView imageView)
        {
            this.imagePicker = imagePicker;
            imagePicker.SourceType = UIImagePickerControllerSourceType.PhotoLibrary;
            imagePicker.MediaTypes = UIImagePickerController.AvailableMediaTypes(UIImagePickerControllerSourceType.PhotoLibrary);
            imagePicker.FinishedPickingMedia += Handle_FinishedPickingMedia;
            imagePicker.Canceled += Handle_Canceled;
            this.imageView = imageView;
        }

        public void Handle_Canceled(object sender, EventArgs e)
        {
            imagePicker.DismissViewController(true, () => { });
        }

        public void Handle_FinishedPickingMedia(object sender, UIImagePickerMediaPickedEventArgs e)
        {
            bool isImage = false;
            switch (e.Info[UIImagePickerController.MediaType].ToString())
            {
                case "public.image":
                    Console.WriteLine("Image selected");
                    isImage = true;
                    break;
                case "public.video":
                    Console.WriteLine("Video selected");
                    break;
            }

            // get common info (shared between images and video)
            NSUrl referenceURL = e.Info[new NSString("UIImagePickerControllerReferenceUrl")] as NSUrl;
            if (referenceURL != null)
                Console.WriteLine("Url:" + referenceURL.ToString());

            // if it was an image, get the other image info
            if (isImage)
            {
                // get the original image
                UIImage originalImage = e.Info[UIImagePickerController.OriginalImage] as UIImage;
                if (originalImage != null)
                {
                    // do something with the image
                    imageView.Image = originalImage; // display
                }

                UIImage editedImage = e.Info[UIImagePickerController.EditedImage] as UIImage;
                if (editedImage != null)
                {
                    // do something with the image
                    Console.WriteLine("got the edited image");
                    imageView.Image = editedImage;
                }
            }

            // dismiss the picker
            imagePicker.DismissViewController(true, () => { });
        }

        public static  UIImage LoadImage(string imagen)
        {
            if (imagen != null)
               using (var url = new NSUrl("http://desarrolloworklabs.com/Dashboard_Client/" + imagen.Replace(@"\", "/")))

                {
                    using (var data = NSData.FromUrl(url))
                    {
                        if (data != null)
                            return UIImage.LoadFromData(data);
                    }
                }
            return UIImage.FromBundle("ProfileImage");
        }

        public static UIImage LoadImageUrl(string llave)
        {
            if (llave != null || llave != "")
            {
                int loop = 0;
                while (true)
                {
                    using (var url = new NSUrl("https://api.qrserver.com/v1/create-qr-code/?data=" + llave))
                    {
                        using (var data = NSData.FromUrl(url))
                        {
                            if (data != null)
                                return UIImage.LoadFromData(data);
                        }
                    }
                    Console.WriteLine(loop);
                    ++loop;
                }
            }
            return UIImage.FromBundle("ProfileImage");
        }

        public static UIButton SelectPhoto(UIViewController owner, UIImageView imagen, ImageGallery selectImage)
        {
            UIButton btnPhoto = new STLButton("Seleccionar imagen");
            btnPhoto.TouchUpInside += (s, e) =>
            {
                UIImagePickerController imagePicker = new UIImagePickerController();
                selectImage = new ImageGallery(imagePicker, imagen);
                owner.PresentViewController(imagePicker, true, () => { });
            };

            return btnPhoto;
        }
    }
}
