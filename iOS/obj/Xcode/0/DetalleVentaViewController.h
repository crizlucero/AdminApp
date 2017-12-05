// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface DetalleVentaViewController : UIViewController {
	UILabel *_lblCantidadMeses;
	UILabel *_lblCantidadProducto;
	UILabel *_lblDisponibilidad;
	UILabel *_lblImpuesto;
	UILabel *_lblProducto;
	UILabel *_lblSubtotal;
	UILabel *_lblSucursal;
	UILabel *_lblTarifaMensual;
	UILabel *_lblTarifaProporcional;
	UILabel *_lblTotal;
	UILabel *_lblVigencia;
	UIView *_vwDetalleProducto;
}

@property (nonatomic, retain) IBOutlet UILabel *lblCantidadMeses;

@property (nonatomic, retain) IBOutlet UILabel *lblCantidadProducto;

@property (nonatomic, retain) IBOutlet UILabel *lblDisponibilidad;

@property (nonatomic, retain) IBOutlet UILabel *lblImpuesto;

@property (nonatomic, retain) IBOutlet UILabel *lblProducto;

@property (nonatomic, retain) IBOutlet UILabel *lblSubtotal;

@property (nonatomic, retain) IBOutlet UILabel *lblSucursal;

@property (nonatomic, retain) IBOutlet UILabel *lblTarifaMensual;

@property (nonatomic, retain) IBOutlet UILabel *lblTarifaProporcional;

@property (nonatomic, retain) IBOutlet UILabel *lblTotal;

@property (nonatomic, retain) IBOutlet UILabel *lblVigencia;

@property (nonatomic, retain) IBOutlet UIView *vwDetalleProducto;

- (IBAction)btnBack_TouchUpInside:(UIButton *)sender;

@end
