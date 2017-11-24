// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface CuentaMembresiasCell : UITableViewCell {
	UIButton *_btnRenovar;
	UILabel *_lblCantidad;
	UILabel *_lblFechaVencimiento;
	UILabel *_lblNombreMembresia;
	UIView *_vwMembresias;
}

@property (nonatomic, retain) IBOutlet UIButton *btnRenovar;

@property (nonatomic, retain) IBOutlet UILabel *lblCantidad;

@property (nonatomic, retain) IBOutlet UILabel *lblFechaVencimiento;

@property (nonatomic, retain) IBOutlet UILabel *lblNombreMembresia;

@property (nonatomic, retain) IBOutlet UIView *vwMembresias;

- (IBAction)btnRenovar_TouchUPInside:(UIButton *)sender;

@end
