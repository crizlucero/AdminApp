// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface PerfilTableViewController : UITableViewController {
	UIButton *_btnEditarFecha;
	UIButton *_btnEditarGenero;
	UIButton *_btnFotografia;
	UIButton *_btnGuardarCambios;
	UIImageView *_imgPerfil;
	UILabel *_lblFechaNacimiento;
	UILabel *_lblGenero;
	UITextField *_txtApellido;
	UITextField *_txtEmail;
	UITextField *_txtHabilidades;
	UITextField *_txtNombre;
	UITextField *_txtProfesion;
	UITextField *_txtTelefono;
}

@property (nonatomic, retain) IBOutlet UIButton *btnEditarFecha;

@property (nonatomic, retain) IBOutlet UIButton *btnEditarGenero;

@property (nonatomic, retain) IBOutlet UIButton *btnFotografia;

@property (nonatomic, retain) IBOutlet UIButton *btnGuardarCambios;

@property (nonatomic, retain) IBOutlet UIImageView *imgPerfil;

@property (nonatomic, retain) IBOutlet UILabel *lblFechaNacimiento;

@property (nonatomic, retain) IBOutlet UILabel *lblGenero;

@property (nonatomic, retain) IBOutlet UITextField *txtApellido;

@property (nonatomic, retain) IBOutlet UITextField *txtEmail;

@property (nonatomic, retain) IBOutlet UITextField *txtHabilidades;

@property (nonatomic, retain) IBOutlet UITextField *txtNombre;

@property (nonatomic, retain) IBOutlet UITextField *txtProfesion;

@property (nonatomic, retain) IBOutlet UITextField *txtTelefono;

- (IBAction)btnEditarFecha_TouchUpInside:(UIButton *)sender;

- (IBAction)btnEditarGenero_TouchUpInside:(UIButton *)sender;

- (IBAction)btnFoto_TpuchUpInside:(UIButton *)sender;

- (IBAction)btnGuardarCambios_TouchUpInside:(UIButton *)sender;

@end
