// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface ComentarPostHeaderCell : UITableViewCell {
	UIButton *_btnBorrarFoto;
	UIButton *_btnFotografia;
	UIButton *_btnPublicar;
	UIButton *_btnSeleccionarImagen;
	UITextView *_txtComentarPost;
	UIView *_vwComentarPost;
}

@property (nonatomic, retain) IBOutlet UIButton *btnBorrarFoto;

@property (nonatomic, retain) IBOutlet UIButton *btnFotografia;

@property (nonatomic, retain) IBOutlet UIButton *btnPublicar;

@property (nonatomic, retain) IBOutlet UIButton *btnSeleccionarImagen;

@property (nonatomic, retain) IBOutlet UITextView *txtComentarPost;

@property (nonatomic, retain) IBOutlet UIView *vwComentarPost;

- (IBAction)btnBorrarFoto_TouchUpInside:(UIButton *)sender;

- (IBAction)btnComentar_TouchUpInside:(UIButton *)sender;

- (IBAction)btnFotografia_TouchUpInside:(UIButton *)sender;

- (IBAction)btnSleccionarImagen_TouchUpInside:(UIButton *)sender;

@end
