// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface ComentariosBodyCell : UITableViewCell {
	UIButton *_btnImagenComentatio;
	UIButton *_btnLikes;
	UIImageView *_imgComentarios;
	UIImageView *_imgPerfil;
	UILabel *_lblComentarios;
	UILabel *_lblFechaPost;
	UILabel *_lblLikes;
	UILabel *_lblNombre;
	UILabel *_lblOcupacion;
	UITextView *_txtComentario;
	UIView *_vwVistaComentario;
}

@property (nonatomic, retain) IBOutlet UIButton *btnImagenComentatio;

@property (nonatomic, retain) IBOutlet UIButton *btnLikes;

@property (nonatomic, retain) IBOutlet UIImageView *imgComentarios;

@property (nonatomic, retain) IBOutlet UIImageView *imgPerfil;

@property (nonatomic, retain) IBOutlet UILabel *lblComentarios;

@property (nonatomic, retain) IBOutlet UILabel *lblFechaPost;

@property (nonatomic, retain) IBOutlet UILabel *lblLikes;

@property (nonatomic, retain) IBOutlet UILabel *lblNombre;

@property (nonatomic, retain) IBOutlet UILabel *lblOcupacion;

@property (nonatomic, retain) IBOutlet UITextView *txtComentario;

@property (nonatomic, retain) IBOutlet UIView *vwVistaComentario;

- (IBAction)btnComentarPost_TouchUpInside:(UIButton *)sender;

- (IBAction)btnImagenComentatio_Touch:(UIButton *)sender;

- (IBAction)btnLikes_TouchUpInside:(UIButton *)sender;

@end
