// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface PublicarPostViewController : UIViewController {
	UIButton *_btnClose;
	UIButton *_btnDeleteImge;
	UIButton *_btnGaleria;
	UIButton *_btnImageComment;
	UIButton *_btnPublicar;
	UIImageView *_imgPerfil;
	UILabel *_lblFechaPublicacion;
	UILabel *_lblNombre;
	UILabel *_lblOcupacion;
	UITextView *_txtPublicacion;
	UIView *_vwVistaComentar;
}

@property (nonatomic, retain) IBOutlet UIButton *btnClose;

@property (nonatomic, retain) IBOutlet UIButton *btnDeleteImge;

@property (nonatomic, retain) IBOutlet UIButton *btnGaleria;

@property (nonatomic, retain) IBOutlet UIButton *btnImageComment;

@property (nonatomic, retain) IBOutlet UIButton *btnPublicar;

@property (nonatomic, retain) IBOutlet UIImageView *imgPerfil;

@property (nonatomic, retain) IBOutlet UILabel *lblFechaPublicacion;

@property (nonatomic, retain) IBOutlet UILabel *lblNombre;

@property (nonatomic, retain) IBOutlet UILabel *lblOcupacion;

@property (nonatomic, retain) IBOutlet UITextView *txtPublicacion;

@property (nonatomic, retain) IBOutlet UIView *vwVistaComentar;

- (IBAction)btnClose_TouchUpInside:(UIButton *)sender;

- (IBAction)btnDeleteImage_TouchUpInside:(UIButton *)sender;

- (IBAction)btnGaleria_TouchUpInside:(UIButton *)sender;

- (IBAction)btnImageComment_TouchUpInside:(UIButton *)sender;

- (IBAction)btnPublicar_TouchUpInside:(UIButton *)sender;

@end
