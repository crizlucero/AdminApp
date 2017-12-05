// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface FechaNacimientoPickerViewController : UIViewController {
	UIButton *_btnCancelar;
	UIButton *_btnSleccionar;
	UIDatePicker *_dtpFechaNacimiento;
}

@property (nonatomic, retain) IBOutlet UIButton *btnCancelar;

@property (nonatomic, retain) IBOutlet UIButton *btnSleccionar;

@property (nonatomic, retain) IBOutlet UIDatePicker *dtpFechaNacimiento;

- (IBAction)btnCancelar_TouchUpInside:(UIButton *)sender;

- (IBAction)btnSeleccionar_TouchUpInside:(UIButton *)sender;

- (IBAction)dtpFechaNacimiento_ValueChanged:(UIDatePicker *)sender;

@end
