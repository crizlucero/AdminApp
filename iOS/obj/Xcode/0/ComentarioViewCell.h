// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface ComentarioViewCell : UITableViewCell {
	UIButton *_btnImagenComentario;
	UIButton *_btnLikes;
	UIImageView *_imgPerfil;
	UILabel *_lblContenido;
	UILabel *_lblFechaPost;
	UILabel *_lblLikes;
	UILabel *_lblNombre;
	UILabel *_lblPuesto;
}

@property (nonatomic, retain) IBOutlet UIButton *btnImagenComentario;

@property (nonatomic, retain) IBOutlet UIButton *btnLikes;

@property (nonatomic, retain) IBOutlet UIImageView *imgPerfil;

@property (nonatomic, retain) IBOutlet UILabel *lblContenido;

@property (nonatomic, retain) IBOutlet UILabel *lblFechaPost;

@property (nonatomic, retain) IBOutlet UILabel *lblLikes;

@property (nonatomic, retain) IBOutlet UILabel *lblNombre;

@property (nonatomic, retain) IBOutlet UILabel *lblPuesto;

- (IBAction)btnImagenComentario_TouchUpInside:(UIButton *)sender;

- (IBAction)btnLikes_TouchUpInside:(UIButton *)sender;

@end
