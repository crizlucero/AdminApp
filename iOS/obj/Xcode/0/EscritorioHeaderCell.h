// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface EscritorioHeaderCell : UITableViewCell {
	UIImageView *_impPublicar;
	UILabel *_lblNombre;
	UILabel *_lblProfesion;
	UIButton *_btnPublicar;
}

@property (nonatomic, retain) IBOutlet UIImageView *impPublicar;

@property (nonatomic, retain) IBOutlet UILabel *lblNombre;

@property (nonatomic, retain) IBOutlet UILabel *lblProfesion;

@property (nonatomic, retain) IBOutlet UIButton *btnPublicar;

- (IBAction)btnPublicar_TouchUpInside:(UIButton *)sender;

@end
