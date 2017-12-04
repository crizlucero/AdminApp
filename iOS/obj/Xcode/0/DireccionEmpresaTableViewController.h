// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface DireccionEmpresaTableViewController : UITableViewController {
	UIButton *_btnEditarColonia;
	UITextField *_txtCalle;
	UITextField *_txtCodigoPostal;
	UITextField *_txtColonia;
	UITextField *_txtEstado;
	UITextField *_txtMunicipio;
	UITextField *_txtNumeroExterior;
	UITextField *_txtNumeroInterior;
}

@property (nonatomic, retain) IBOutlet UIButton *btnEditarColonia;

@property (nonatomic, retain) IBOutlet UITextField *txtCalle;

@property (nonatomic, retain) IBOutlet UITextField *txtCodigoPostal;

@property (nonatomic, retain) IBOutlet UITextField *txtColonia;

@property (nonatomic, retain) IBOutlet UITextField *txtEstado;

@property (nonatomic, retain) IBOutlet UITextField *txtMunicipio;

@property (nonatomic, retain) IBOutlet UITextField *txtNumeroExterior;

@property (nonatomic, retain) IBOutlet UITextField *txtNumeroInterior;

- (IBAction)btnEditarColonia_TouchupInside:(UIButton *)sender;

- (IBAction)btnGuardar:(UIBarButtonItem *)sender;

- (IBAction)txtCodigoPostal_ValueChanged:(UITextField *)sender;

@end
