// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface SucursalesViewController : UIViewController {
	UIButton *_btnCancelar;
	UIButton *_btnSeleccionar;
	UIPickerView *_pcvSucursales;
	UIView *_vwSucursales;
}

@property (nonatomic, retain) IBOutlet UIButton *btnCancelar;

@property (nonatomic, retain) IBOutlet UIButton *btnSeleccionar;

@property (nonatomic, retain) IBOutlet UIPickerView *pcvSucursales;

@property (nonatomic, retain) IBOutlet UIView *vwSucursales;

- (IBAction)btnCancelar_Touch:(UIButton *)sender;

- (IBAction)btnSeleccionar_Touch:(UIButton *)sender;

@end
