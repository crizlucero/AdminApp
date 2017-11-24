// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface CuentaProductosCell : UITableViewCell {
	UIButton *_btnAgregar;
	UILabel *_lblCantidad;
	UILabel *_lblFechaVencimiento;
	UILabel *_lblNombreProducto;
	UIView *_vwProductos;
}

@property (nonatomic, retain) IBOutlet UIButton *btnAgregar;

@property (nonatomic, retain) IBOutlet UILabel *lblCantidad;

@property (nonatomic, retain) IBOutlet UILabel *lblFechaVencimiento;

@property (nonatomic, retain) IBOutlet UILabel *lblNombreProducto;

@property (nonatomic, retain) IBOutlet UIView *vwProductos;

- (IBAction)btnAgregar_TouchUpInside:(UIButton *)sender;

@end
