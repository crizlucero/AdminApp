// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface CeldaCarritoProductos : UITableViewCell {
	UIDatePicker *_dpkFechaInicio;
	UILabel *_lblCantidadMeses;
	UILabel *_lblCantidadProductos;
	UILabel *_lblFechaInicio;
	UILabel *_lblMensajeMeses;
	UILabel *_lblMensajeProporcionalMes;
	UILabel *_lblMensajeTarifa;
	UILabel *_lblNombreProducto;
	UILabel *_lblProporcionalMes;
	UILabel *_lblTarifa;
	UILabel *_lblTotal;
	UIPickerView *_pkvSucursal;
	UIStepper *_stpCantidadMeses;
	UIStepper *_stpCantidadProductos;
	UIView *_vwControlesTarifaMensual;
	UIView *_vwProductos;
}

@property (nonatomic, retain) IBOutlet UIDatePicker *dpkFechaInicio;

@property (nonatomic, retain) IBOutlet UILabel *lblCantidadMeses;

@property (nonatomic, retain) IBOutlet UILabel *lblCantidadProductos;

@property (nonatomic, retain) IBOutlet UILabel *lblFechaInicio;

@property (nonatomic, retain) IBOutlet UILabel *lblMensajeMeses;

@property (nonatomic, retain) IBOutlet UILabel *lblMensajeProporcionalMes;

@property (nonatomic, retain) IBOutlet UILabel *lblMensajeTarifa;

@property (nonatomic, retain) IBOutlet UILabel *lblNombreProducto;

@property (nonatomic, retain) IBOutlet UILabel *lblProporcionalMes;

@property (nonatomic, retain) IBOutlet UILabel *lblTarifa;

@property (nonatomic, retain) IBOutlet UILabel *lblTotal;

@property (nonatomic, retain) IBOutlet UIPickerView *pkvSucursal;

@property (nonatomic, retain) IBOutlet UIStepper *stpCantidadMeses;

@property (nonatomic, retain) IBOutlet UIStepper *stpCantidadProductos;

@property (nonatomic, retain) IBOutlet UIView *vwControlesTarifaMensual;

@property (nonatomic, retain) IBOutlet UIView *vwProductos;

- (IBAction)dtpFechaInicio_ValueChanged:(UIDatePicker *)sender;

- (IBAction)stpCantidadProductos_Changed:(UIStepper *)sender;

- (IBAction)stpMeses_Changed:(UIStepper *)sender;

@end
