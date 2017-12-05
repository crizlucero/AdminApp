// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface DatosEmpresaTableViewController : UITableViewController {
	UIButton *_btnActualizarEmpresa;
	UIButton *_btnEditarDireccion;
	UIButton *_btnEditarRedesSociales;
	UIButton *_imgCamara;
	UIImageView *_imgPerfil;
	UITextField *_txtCorreoElectronico;
	UITextField *_txtGiroComercial;
	UITextField *_txtNombreEmpresa;
	UITextField *_txtRazonSocial;
	UITextField *_txtRFC;
	UITextField *_txtTelefono;
}

@property (nonatomic, retain) IBOutlet UIButton *btnActualizarEmpresa;

@property (nonatomic, retain) IBOutlet UIButton *btnEditarDireccion;

@property (nonatomic, retain) IBOutlet UIButton *btnEditarRedesSociales;

@property (nonatomic, retain) IBOutlet UIButton *imgCamara;

@property (nonatomic, retain) IBOutlet UIImageView *imgPerfil;

@property (nonatomic, retain) IBOutlet UITextField *txtCorreoElectronico;

@property (nonatomic, retain) IBOutlet UITextField *txtGiroComercial;

@property (nonatomic, retain) IBOutlet UITextField *txtNombreEmpresa;

@property (nonatomic, retain) IBOutlet UITextField *txtRazonSocial;

@property (nonatomic, retain) IBOutlet UITextField *txtRFC;

@property (nonatomic, retain) IBOutlet UITextField *txtTelefono;

- (IBAction)btnActualizar_TouchUpInside:(UIButton *)sender;

- (IBAction)btnEditarDireccion_TouchUpInside:(UIButton *)sender;

- (IBAction)btnRedesSociales_TouchUpInside:(UIButton *)sender;

- (IBAction)btnTomarFoto_TouchUpInside:(UIButton *)sender;

@end
