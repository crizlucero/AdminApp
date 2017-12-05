// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface EditarRedesSocialesTableViewController : UITableViewController {
	UITextField *_txtPaginaWeb;
	UITextField *_txtUsuarioFacebook;
	UITextField *_txtUsuarioInstagram;
	UITextField *_txtUsuarioTwitter;
}

@property (nonatomic, retain) IBOutlet UITextField *txtPaginaWeb;

@property (nonatomic, retain) IBOutlet UITextField *txtUsuarioFacebook;

@property (nonatomic, retain) IBOutlet UITextField *txtUsuarioInstagram;

@property (nonatomic, retain) IBOutlet UITextField *txtUsuarioTwitter;

- (IBAction)btnGardar:(UIBarButtonItem *)sender;

@end
