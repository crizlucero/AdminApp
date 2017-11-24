// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface LoginViewController : UIViewController {
	UIButton *_btnIniciarSesion;
	UIButton *_btnRecuperar;
	UIButton *_btnRegistro;
	UIButton *_btnRestaurar;
	UITextField *_txtEmail;
	UITextField *_txtEmailRecuperar;
	UITextField *_txtPassword;
}

@property (nonatomic, retain) IBOutlet UIButton *btnIniciarSesion;

@property (nonatomic, retain) IBOutlet UIButton *btnRecuperar;

@property (nonatomic, retain) IBOutlet UIButton *btnRegistro;

@property (nonatomic, retain) IBOutlet UIButton *btnRestaurar;

@property (nonatomic, retain) IBOutlet UITextField *txtEmail;

@property (nonatomic, retain) IBOutlet UITextField *txtEmailRecuperar;

@property (nonatomic, retain) IBOutlet UITextField *txtPassword;

- (IBAction)BtnIniciarSesion_TouchUpInside:(UIButton *)sender;

- (IBAction)BtnRegistro_TouchUpInside:(UIButton *)sender;

- (IBAction)BtnRestaurar_TouchUpInside:(UIButton *)sender;

@end
