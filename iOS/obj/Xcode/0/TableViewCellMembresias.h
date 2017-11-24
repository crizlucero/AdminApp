// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface TableViewCellMembresias : UITableViewCell {
	UIDatePicker *_dtpFechaInicio;
	UILabel *_lblCantidadMembresias;
	UILabel *_lblCantidadMeses;
	UILabel *_lblNombreMembresia;
	UILabel *_lblProporcionalMes;
	UILabel *_lblTarifaInscripcion;
	UILabel *_lblTarifaMensual;
	UILabel *_lblTotal;
	UIPickerView *_pcwSucursal;
	UIStepper *_stpCantidadMembresias;
	UIStepper *_stpCantidadMeses;
	UIView *_vwMembresias;
}

@property (nonatomic, retain) IBOutlet UIDatePicker *dtpFechaInicio;

@property (nonatomic, retain) IBOutlet UILabel *lblCantidadMembresias;

@property (nonatomic, retain) IBOutlet UILabel *lblCantidadMeses;

@property (nonatomic, retain) IBOutlet UILabel *lblNombreMembresia;

@property (nonatomic, retain) IBOutlet UILabel *lblProporcionalMes;

@property (nonatomic, retain) IBOutlet UILabel *lblTarifaInscripcion;

@property (nonatomic, retain) IBOutlet UILabel *lblTarifaMensual;

@property (nonatomic, retain) IBOutlet UILabel *lblTotal;

@property (nonatomic, retain) IBOutlet UIPickerView *pcwSucursal;

@property (nonatomic, retain) IBOutlet UIStepper *stpCantidadMembresias;

@property (nonatomic, retain) IBOutlet UIStepper *stpCantidadMeses;

@property (nonatomic, retain) IBOutlet UIView *vwMembresias;

- (IBAction)dtpFechaInicio_ValueChanged:(UIDatePicker *)sender;

- (IBAction)stpCantidadMembresias_ValueChanged:(UIStepper *)sender;

- (IBAction)stpCantidadMeses_ValueChanged:(UIStepper *)sender;

@end
