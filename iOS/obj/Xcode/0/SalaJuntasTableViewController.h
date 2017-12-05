// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface SalaJuntasTableViewController : UITableViewController {
	UIButton *_btnComprarHoras;
	UIButton *_btnEditarSalaJuntas;
	UILabel *_lblHorasDisponibles;
	UILabel *_lblSalaJuntas;
	UIView *_vwCalendarioJuntas;
}

@property (nonatomic, retain) IBOutlet UIButton *btnComprarHoras;

@property (nonatomic, retain) IBOutlet UIButton *btnEditarSalaJuntas;

@property (nonatomic, retain) IBOutlet UILabel *lblHorasDisponibles;

@property (nonatomic, retain) IBOutlet UILabel *lblSalaJuntas;

@property (nonatomic, retain) IBOutlet UIView *vwCalendarioJuntas;

- (IBAction)btnComprarHoras_Touch:(UIButton *)sender;

- (IBAction)btnEditarSalaJuntas_Touch:(UIButton *)sender;

@end
