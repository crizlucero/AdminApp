#pragma clang diagnostic ignored "-Wdeprecated-declarations"
#pragma clang diagnostic ignored "-Wtypedef-redefinition"
#pragma clang diagnostic ignored "-Wobjc-designated-initializers"
#include <stdarg.h>
#include <objc/objc.h>
#include <objc/runtime.h>
#include <objc/message.h>
#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import <MessageUI/MessageUI.h>
#import <CloudKit/CloudKit.h>
#import <Contacts/Contacts.h>
#import <QuartzCore/QuartzCore.h>
#import <Photos/Photos.h>
#import <ContactsUI/ContactsUI.h>
#import <Intents/Intents.h>
#import <AVFoundation/AVFoundation.h>
#import <CoreGraphics/CoreGraphics.h>

@protocol UIPickerViewModel;
@class Foundation_InternalNSNotificationHandler;
@class __MonoMac_NSActionDispatcher;
@class __Xamarin_NSTimerActionDispatcher;
@class __MonoMac_NSAsyncActionDispatcher;
@class MessageUI_Mono_MFMailComposeViewControllerDelegate;
@class UIKit_UIControlEventProxy;
@class AppDelegate;
@class TableViewController;
@class SubMenuController;
@class MiMembresiaController;
@class ReservaController;
@class TabBarColaboradorController;
@class TabBarController;
@class EmpresaMiembroController;
@class AboutMeController;
@class HeaderCarritoProductos;
@class ComentariosBodyCell;
@class EscritorioHeaderCell;
@class NoComentsCell;
@class MiCuentaViewController;
@class ProductosMiCuentaViewController;
@class CuentaProductosCell;
@class NoInfoCuentaProductosCell;
@class MembresiasMiCuentaViewController;
@class CuentaMembresiasCell;
@class NoInfoCuentaMembresiasCell;
@class CeldaCarritoProductos;
@class CeldaNoProductos;
@class TableViewCellMembresias;
@class TableViewCellNoMembresias;
@class VentaDetalleHeader;
@class CeldaVentaDetalle;
@class CeldaNoDetalleVenta;
@class CanjearCuponController;
@class DetalleVentaViewController;
@class DetailCommentImage;
@class cloudViewController;
@class TelefoniaTableView;
@class EditarRedesSocialesTableViewController;
@class FechaNacimientoPickerViewController;
@class SalaJuntasTableViewController;
@class HorariosTableViewController;
@class HorariosTableViewCell;
@class comentarTableView;
@class HeaderComentarTableView;
@class ComentarNoInfoCell;
@class ComentarviewController;
@class BodyComentarTableView;
@class WorklabsMx_iOS_ViewElements_UICheckBox;
@class WorklabsMx_iOS_ViewElements_HorarioEventos;
@class WorklabsMx_iOS_ViewElements_UIDropdownList;
@class WorklabsMx_iOS_ViewElements_CommentCard;
@class WorklabsMx_iOS_ViewElements_UIRadioButton;
@class WorklabsMx_iOS_Models_PickerModel;
@class WorklabsMx_iOS_Models_SucursalesModel;
@class WorklabsMx_iOS_Models_CarritoCompras;
@class WorklabsMx_iOS_Models_OrdenVentaController;
@class WorklabsMx_iOS_Models_OrdenVentaDetalle;
@class WorklabsMx_iOS_Styles_STLButton;
@class WorklabsMx_iOS_Styles_STLTextField;
@class WorklabsMx_iOS_Styles_STLLabel;
@class WorklabsMx_iOS_Styles_STLImageLabel;
@class WorklabsMx_iOS_Styles_PickerDataModel;
@class WorklabsMx_iOS_Styles_STLDropDownList;
@class WorklabsMx_iOS_Styles_STLCarritoCompra;
@class WorklabsMx_iOS_Styles_STLLine;
@class WorklabsMx_iOS_Helpers_LoadingView;
@class WorklabsMx_iOS_Helpers_DropDownListSource;
@class SplitViewController;
@class LoginViewController;
@class AccesoController;
@class ReporteController;
@class PerfilController;
@class DatosFacturacionController;
@class DirectorioEmpresasController;
@class DirectorioUsuarioController;
@class CarritoCompraController;
@class MisColaboradoresBajaController;
@class MisColaboradoresCambiosController;
@class MisColaboradoresController;
@class RegistroInvitadosController;
@class TarifasController;
@class PaymentController;
@class EmpresaMiembroModificaController;
@class AboutMeModificaController;
@class PublicarPostViewController;
@class EscritorioController;
@class TabBarDetalleVenta;
@class CarritoProductos;
@class TableViewMembresia;
@class VentaDetalleTableViewController;
@class PerfilTableViewController;
@class DatosEmpresaTableViewController;
@class DireccionEmpresaTableViewController;
@class WorklabsMx_iOS_GeneroViewController_StackOverflowModel;
@class GeneroViewController;
@class WorklabsMx_iOS_ColoniaViewController_StackOverflowModel;
@class ColoniaViewController;
@class WorklabsMx_iOS_SucursalesViewController_StackOverflowModel;
@class SucursalesViewController;
@class WorklabsMx_iOS_ViewElements_PostCard;
@class WorklabsMx_iOS_Styles_STLTableViewSource;
@class WorklabsMx_iOS_Styles_STLImageView;
@class __UIGestureRecognizerToken;
@class __UIGestureRecognizerParameterlessToken;
@class __UIGestureRecognizerParametrizedToken;
@class __NSObject_Disposer;
@class UIKit_UIImagePickerController__UIImagePickerControllerDelegate;
@class __UILongPressGestureRecognizer;
@class UIKit_UIView_UIViewAppearance;
@class UIKit_UINavigationBar_UINavigationBarAppearance;
@class __UIPanGestureRecognizer;
@class UIKit_UIAlertView__UIAlertViewDelegate;
@class UIKit_UIBarButtonItem_Callback;
@class __UIRotationGestureRecognizer;
@class __UITapGestureRecognizer;
@class __UIPinchGestureRecognizer;
@class __UISwipeGestureRecognizer;
@class __UIScreenEdgePanGestureRecognizer;
@class UIKit_UITextField__UITextFieldDelegate;
@class UIKit_UIScrollView__UIScrollViewDelegate;
@class UIKit_UITextView__UITextViewDelegate;
@class BigTed_ProgressHUD;

@protocol UIPickerViewModel<UIPickerViewDataSource, UIPickerViewDelegate>
@end

@interface AppDelegate : NSObject<UIApplicationDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIWindow *) window;
	-(void) setWindow:(UIWindow *)p0;
	-(BOOL) application:(UIApplication *)p0 didFinishLaunchingWithOptions:(NSDictionary *)p1;
	-(void) applicationWillResignActive:(UIApplication *)p0;
	-(void) applicationDidEnterBackground:(UIApplication *)p0;
	-(void) applicationWillEnterForeground:(UIApplication *)p0;
	-(void) applicationDidBecomeActive:(UIApplication *)p0;
	-(void) applicationWillTerminate:(UIApplication *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface TableViewController : UITableViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(void) didReceiveMemoryWarning;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface SubMenuController : UITableViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface MiMembresiaController : UIViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface ReservaController : UIViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface TabBarColaboradorController : UITabBarController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(void) tabBar:(UITabBar *)p0 didSelectItem:(UITabBarItem *)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface TabBarController : UITabBarController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(void) viewWillAppear:(BOOL)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface EmpresaMiembroController : UIViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface AboutMeController : UIViewController {
}
	@property (nonatomic, assign) UIButton * btnEditar;
	@property (nonatomic, assign) UILabel * lblCelular;
	@property (nonatomic, assign) UILabel * lblHabilidades;
	@property (nonatomic, assign) UILabel * lblProfesion;
	@property (nonatomic, assign) UILabel * lblPuesto;
	@property (nonatomic, assign) UILabel * lblTelefono;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnEditar;
	-(void) setBtnEditar:(UIButton *)p0;
	-(UILabel *) lblCelular;
	-(void) setLblCelular:(UILabel *)p0;
	-(UILabel *) lblHabilidades;
	-(void) setLblHabilidades:(UILabel *)p0;
	-(UILabel *) lblProfesion;
	-(void) setLblProfesion:(UILabel *)p0;
	-(UILabel *) lblPuesto;
	-(void) setLblPuesto:(UILabel *)p0;
	-(UILabel *) lblTelefono;
	-(void) setLblTelefono:(UILabel *)p0;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface HeaderCarritoProductos : UITableViewCell {
}
	@property (nonatomic, assign) UILabel * lblNumeroProductos;
	@property (nonatomic, assign) UILabel * lblTotalPagar;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UILabel *) lblNumeroProductos;
	-(void) setLblNumeroProductos:(UILabel *)p0;
	-(UILabel *) lblTotalPagar;
	-(void) setLblTotalPagar:(UILabel *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface ComentariosBodyCell : UITableViewCell {
}
	@property (nonatomic, assign) UIButton * btnImagenComentatio;
	@property (nonatomic, assign) UIButton * btnLikes;
	@property (nonatomic, assign) UIImageView * imgComentarios;
	@property (nonatomic, assign) UIImageView * imgPerfil;
	@property (nonatomic, assign) UILabel * lblComentarios;
	@property (nonatomic, assign) UILabel * lblFechaPost;
	@property (nonatomic, assign) UILabel * lblLikes;
	@property (nonatomic, assign) UILabel * lblNombre;
	@property (nonatomic, assign) UILabel * lblOcupacion;
	@property (nonatomic, assign) UITextView * txtComentario;
	@property (nonatomic, assign) UIView * vwVistaComentario;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnImagenComentatio;
	-(void) setBtnImagenComentatio:(UIButton *)p0;
	-(UIButton *) btnLikes;
	-(void) setBtnLikes:(UIButton *)p0;
	-(UIImageView *) imgComentarios;
	-(void) setImgComentarios:(UIImageView *)p0;
	-(UIImageView *) imgPerfil;
	-(void) setImgPerfil:(UIImageView *)p0;
	-(UILabel *) lblComentarios;
	-(void) setLblComentarios:(UILabel *)p0;
	-(UILabel *) lblFechaPost;
	-(void) setLblFechaPost:(UILabel *)p0;
	-(UILabel *) lblLikes;
	-(void) setLblLikes:(UILabel *)p0;
	-(UILabel *) lblNombre;
	-(void) setLblNombre:(UILabel *)p0;
	-(UILabel *) lblOcupacion;
	-(void) setLblOcupacion:(UILabel *)p0;
	-(UITextView *) txtComentario;
	-(void) setTxtComentario:(UITextView *)p0;
	-(UIView *) vwVistaComentario;
	-(void) setVwVistaComentario:(UIView *)p0;
	-(void) btnComentarPost_TouchUpInside:(UIButton *)p0;
	-(void) btnLikes_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface EscritorioHeaderCell : UITableViewCell {
}
	@property (nonatomic, assign) UIImageView * impPublicar;
	@property (nonatomic, assign) UILabel * lblNombre;
	@property (nonatomic, assign) UILabel * lblProfesion;
	@property (nonatomic, assign) UIButton * btnPublicar;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIImageView *) impPublicar;
	-(void) setImpPublicar:(UIImageView *)p0;
	-(UILabel *) lblNombre;
	-(void) setLblNombre:(UILabel *)p0;
	-(UILabel *) lblProfesion;
	-(void) setLblProfesion:(UILabel *)p0;
	-(UIButton *) btnPublicar;
	-(void) setBtnPublicar:(UIButton *)p0;
	-(void) btnPublicar_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface NoComentsCell : UITableViewCell {
}
	@property (nonatomic, assign) UILabel * lblMessageNoComments;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UILabel *) lblMessageNoComments;
	-(void) setLblMessageNoComments:(UILabel *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface MiCuentaViewController : UITabBarController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface ProductosMiCuentaViewController : UITableViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(void) viewWillAppear:(BOOL)p0;
	-(void) viewDidAppear:(BOOL)p0;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface CuentaProductosCell : UITableViewCell {
}
	@property (nonatomic, assign) UIButton * btnAgregar;
	@property (nonatomic, assign) UILabel * lblCantidad;
	@property (nonatomic, assign) UILabel * lblFechaVencimiento;
	@property (nonatomic, assign) UILabel * lblNombreProducto;
	@property (nonatomic, assign) UIView * vwProductos;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnAgregar;
	-(void) setBtnAgregar:(UIButton *)p0;
	-(UILabel *) lblCantidad;
	-(void) setLblCantidad:(UILabel *)p0;
	-(UILabel *) lblFechaVencimiento;
	-(void) setLblFechaVencimiento:(UILabel *)p0;
	-(UILabel *) lblNombreProducto;
	-(void) setLblNombreProducto:(UILabel *)p0;
	-(UIView *) vwProductos;
	-(void) setVwProductos:(UIView *)p0;
	-(void) btnAgregar_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface NoInfoCuentaProductosCell : UITableViewCell {
}
	@property (nonatomic, assign) UILabel * lblMensaje;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UILabel *) lblMensaje;
	-(void) setLblMensaje:(UILabel *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface MembresiasMiCuentaViewController : UITableViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(void) viewWillAppear:(BOOL)p0;
	-(void) viewDidAppear:(BOOL)p0;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface CuentaMembresiasCell : UITableViewCell {
}
	@property (nonatomic, assign) UIButton * btnRenovar;
	@property (nonatomic, assign) UILabel * lblCantidad;
	@property (nonatomic, assign) UILabel * lblFechaVencimiento;
	@property (nonatomic, assign) UILabel * lblNombreMembresia;
	@property (nonatomic, assign) UIView * vwMembresias;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnRenovar;
	-(void) setBtnRenovar:(UIButton *)p0;
	-(UILabel *) lblCantidad;
	-(void) setLblCantidad:(UILabel *)p0;
	-(UILabel *) lblFechaVencimiento;
	-(void) setLblFechaVencimiento:(UILabel *)p0;
	-(UILabel *) lblNombreMembresia;
	-(void) setLblNombreMembresia:(UILabel *)p0;
	-(UIView *) vwMembresias;
	-(void) setVwMembresias:(UIView *)p0;
	-(void) btnRenovar_TouchUPInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface NoInfoCuentaMembresiasCell : UITableViewCell {
}
	@property (nonatomic, assign) UILabel * lblMensaje;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UILabel *) lblMensaje;
	-(void) setLblMensaje:(UILabel *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface CeldaCarritoProductos : UITableViewCell {
}
	@property (nonatomic, assign) UIDatePicker * dpkFechaInicio;
	@property (nonatomic, assign) UILabel * lblCantidadMeses;
	@property (nonatomic, assign) UILabel * lblCantidadProductos;
	@property (nonatomic, assign) UILabel * lblFechaInicio;
	@property (nonatomic, assign) UILabel * lblMensajeMeses;
	@property (nonatomic, assign) UILabel * lblMensajeProporcionalMes;
	@property (nonatomic, assign) UILabel * lblMensajeTarifa;
	@property (nonatomic, assign) UILabel * lblNombreProducto;
	@property (nonatomic, assign) UILabel * lblProporcionalMes;
	@property (nonatomic, assign) UILabel * lblTarifa;
	@property (nonatomic, assign) UILabel * lblTotal;
	@property (nonatomic, assign) UIPickerView * pkvSucursal;
	@property (nonatomic, assign) UIStepper * stpCantidadMeses;
	@property (nonatomic, assign) UIStepper * stpCantidadProductos;
	@property (nonatomic, assign) UIView * vwControlesTarifaMensual;
	@property (nonatomic, assign) UIView * vwProductos;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIDatePicker *) dpkFechaInicio;
	-(void) setDpkFechaInicio:(UIDatePicker *)p0;
	-(UILabel *) lblCantidadMeses;
	-(void) setLblCantidadMeses:(UILabel *)p0;
	-(UILabel *) lblCantidadProductos;
	-(void) setLblCantidadProductos:(UILabel *)p0;
	-(UILabel *) lblFechaInicio;
	-(void) setLblFechaInicio:(UILabel *)p0;
	-(UILabel *) lblMensajeMeses;
	-(void) setLblMensajeMeses:(UILabel *)p0;
	-(UILabel *) lblMensajeProporcionalMes;
	-(void) setLblMensajeProporcionalMes:(UILabel *)p0;
	-(UILabel *) lblMensajeTarifa;
	-(void) setLblMensajeTarifa:(UILabel *)p0;
	-(UILabel *) lblNombreProducto;
	-(void) setLblNombreProducto:(UILabel *)p0;
	-(UILabel *) lblProporcionalMes;
	-(void) setLblProporcionalMes:(UILabel *)p0;
	-(UILabel *) lblTarifa;
	-(void) setLblTarifa:(UILabel *)p0;
	-(UILabel *) lblTotal;
	-(void) setLblTotal:(UILabel *)p0;
	-(UIPickerView *) pkvSucursal;
	-(void) setPkvSucursal:(UIPickerView *)p0;
	-(UIStepper *) stpCantidadMeses;
	-(void) setStpCantidadMeses:(UIStepper *)p0;
	-(UIStepper *) stpCantidadProductos;
	-(void) setStpCantidadProductos:(UIStepper *)p0;
	-(UIView *) vwControlesTarifaMensual;
	-(void) setVwControlesTarifaMensual:(UIView *)p0;
	-(UIView *) vwProductos;
	-(void) setVwProductos:(UIView *)p0;
	-(void) layoutIfNeeded;
	-(void) dtpFechaInicio_ValueChanged:(UIDatePicker *)p0;
	-(void) stpCantidadProductos_Changed:(UIStepper *)p0;
	-(void) stpMeses_Changed:(UIStepper *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface CeldaNoProductos : UITableViewCell {
}
	@property (nonatomic, assign) UILabel * lblMessageNoProducts;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UILabel *) lblMessageNoProducts;
	-(void) setLblMessageNoProducts:(UILabel *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface TableViewCellMembresias : UITableViewCell {
}
	@property (nonatomic, assign) UIDatePicker * dtpFechaInicio;
	@property (nonatomic, assign) UILabel * lblCantidadMembresias;
	@property (nonatomic, assign) UILabel * lblCantidadMeses;
	@property (nonatomic, assign) UILabel * lblNombreMembresia;
	@property (nonatomic, assign) UILabel * lblProporcionalMes;
	@property (nonatomic, assign) UILabel * lblTarifaInscripcion;
	@property (nonatomic, assign) UILabel * lblTarifaMensual;
	@property (nonatomic, assign) UILabel * lblTotal;
	@property (nonatomic, assign) UIPickerView * pcwSucursal;
	@property (nonatomic, assign) UIStepper * stpCantidadMembresias;
	@property (nonatomic, assign) UIStepper * stpCantidadMeses;
	@property (nonatomic, assign) UIView * vwMembresias;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIDatePicker *) dtpFechaInicio;
	-(void) setDtpFechaInicio:(UIDatePicker *)p0;
	-(UILabel *) lblCantidadMembresias;
	-(void) setLblCantidadMembresias:(UILabel *)p0;
	-(UILabel *) lblCantidadMeses;
	-(void) setLblCantidadMeses:(UILabel *)p0;
	-(UILabel *) lblNombreMembresia;
	-(void) setLblNombreMembresia:(UILabel *)p0;
	-(UILabel *) lblProporcionalMes;
	-(void) setLblProporcionalMes:(UILabel *)p0;
	-(UILabel *) lblTarifaInscripcion;
	-(void) setLblTarifaInscripcion:(UILabel *)p0;
	-(UILabel *) lblTarifaMensual;
	-(void) setLblTarifaMensual:(UILabel *)p0;
	-(UILabel *) lblTotal;
	-(void) setLblTotal:(UILabel *)p0;
	-(UIPickerView *) pcwSucursal;
	-(void) setPcwSucursal:(UIPickerView *)p0;
	-(UIStepper *) stpCantidadMembresias;
	-(void) setStpCantidadMembresias:(UIStepper *)p0;
	-(UIStepper *) stpCantidadMeses;
	-(void) setStpCantidadMeses:(UIStepper *)p0;
	-(UIView *) vwMembresias;
	-(void) setVwMembresias:(UIView *)p0;
	-(void) dtpFechaInicio_ValueChanged:(UIDatePicker *)p0;
	-(void) stpCantidadMembresias_ValueChanged:(UIStepper *)p0;
	-(void) stpCantidadMeses_ValueChanged:(UIStepper *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface TableViewCellNoMembresias : UITableViewCell {
}
	@property (nonatomic, assign) UILabel * lblMessage;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UILabel *) lblMessage;
	-(void) setLblMessage:(UILabel *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface VentaDetalleHeader : UITableViewCell {
}
	@property (nonatomic, assign) UIButton * btnUsarCupon;
	@property (nonatomic, assign) UILabel * lblDescuento;
	@property (nonatomic, assign) UILabel * lblImpuesto;
	@property (nonatomic, assign) UILabel * lblSubtotal;
	@property (nonatomic, assign) UILabel * lblTotal;
	@property (nonatomic, assign) UILabel * lblLeyendaTotalDescuento;
	@property (nonatomic, assign) UILabel * lblTotalConDescuento;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnUsarCupon;
	-(void) setBtnUsarCupon:(UIButton *)p0;
	-(UILabel *) lblDescuento;
	-(void) setLblDescuento:(UILabel *)p0;
	-(UILabel *) lblImpuesto;
	-(void) setLblImpuesto:(UILabel *)p0;
	-(UILabel *) lblSubtotal;
	-(void) setLblSubtotal:(UILabel *)p0;
	-(UILabel *) lblTotal;
	-(void) setLblTotal:(UILabel *)p0;
	-(UILabel *) lblLeyendaTotalDescuento;
	-(void) setLblLeyendaTotalDescuento:(UILabel *)p0;
	-(UILabel *) lblTotalConDescuento;
	-(void) setLblTotalConDescuento:(UILabel *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface CeldaVentaDetalle : UITableViewCell {
}
	@property (nonatomic, assign) UILabel * lblCantidad;
	@property (nonatomic, assign) UILabel * lblNombreProducto;
	@property (nonatomic, assign) UILabel * lblTotalPagar;
	@property (nonatomic, assign) UIView * vwVistaDetalleVenta;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UILabel *) lblCantidad;
	-(void) setLblCantidad:(UILabel *)p0;
	-(UILabel *) lblNombreProducto;
	-(void) setLblNombreProducto:(UILabel *)p0;
	-(UILabel *) lblTotalPagar;
	-(void) setLblTotalPagar:(UILabel *)p0;
	-(UIView *) vwVistaDetalleVenta;
	-(void) setVwVistaDetalleVenta:(UIView *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface CeldaNoDetalleVenta : UITableViewCell {
}
	@property (nonatomic, assign) UILabel * lblNoInfo;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UILabel *) lblNoInfo;
	-(void) setLblNoInfo:(UILabel *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface CanjearCuponController : UIViewController {
}
	@property (nonatomic, assign) UIButton * btnCanjearCupon;
	@property (nonatomic, assign) UITextField * txtCupon;
	@property (nonatomic, assign) UIView * vwCanjearCupon;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnCanjearCupon;
	-(void) setBtnCanjearCupon:(UIButton *)p0;
	-(UITextField *) txtCupon;
	-(void) setTxtCupon:(UITextField *)p0;
	-(UIView *) vwCanjearCupon;
	-(void) setVwCanjearCupon:(UIView *)p0;
	-(void) viewDidLoad;
	-(void) btnBack_TouchUpInside:(UIButton *)p0;
	-(void) btnCanjear_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface DetalleVentaViewController : UIViewController {
}
	@property (nonatomic, assign) UILabel * lblCantidadMeses;
	@property (nonatomic, assign) UILabel * lblCantidadProducto;
	@property (nonatomic, assign) UILabel * lblDisponibilidad;
	@property (nonatomic, assign) UILabel * lblImpuesto;
	@property (nonatomic, assign) UILabel * lblProducto;
	@property (nonatomic, assign) UILabel * lblSubtotal;
	@property (nonatomic, assign) UILabel * lblSucursal;
	@property (nonatomic, assign) UILabel * lblTarifaMensual;
	@property (nonatomic, assign) UILabel * lblTarifaProporcional;
	@property (nonatomic, assign) UILabel * lblTotal;
	@property (nonatomic, assign) UILabel * lblVigencia;
	@property (nonatomic, assign) UIView * vwDetalleProducto;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UILabel *) lblCantidadMeses;
	-(void) setLblCantidadMeses:(UILabel *)p0;
	-(UILabel *) lblCantidadProducto;
	-(void) setLblCantidadProducto:(UILabel *)p0;
	-(UILabel *) lblDisponibilidad;
	-(void) setLblDisponibilidad:(UILabel *)p0;
	-(UILabel *) lblImpuesto;
	-(void) setLblImpuesto:(UILabel *)p0;
	-(UILabel *) lblProducto;
	-(void) setLblProducto:(UILabel *)p0;
	-(UILabel *) lblSubtotal;
	-(void) setLblSubtotal:(UILabel *)p0;
	-(UILabel *) lblSucursal;
	-(void) setLblSucursal:(UILabel *)p0;
	-(UILabel *) lblTarifaMensual;
	-(void) setLblTarifaMensual:(UILabel *)p0;
	-(UILabel *) lblTarifaProporcional;
	-(void) setLblTarifaProporcional:(UILabel *)p0;
	-(UILabel *) lblTotal;
	-(void) setLblTotal:(UILabel *)p0;
	-(UILabel *) lblVigencia;
	-(void) setLblVigencia:(UILabel *)p0;
	-(UIView *) vwDetalleProducto;
	-(void) setVwDetalleProducto:(UIView *)p0;
	-(void) viewDidLoad;
	-(void) viewWillAppear:(BOOL)p0;
	-(void) btnBack_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface DetailCommentImage : UIViewController {
}
	@property (nonatomic, assign) UIButton * btnBack;
	@property (nonatomic, assign) UIImageView * imgCommnet;
	@property (nonatomic, assign) UIView * vwImageComment;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnBack;
	-(void) setBtnBack:(UIButton *)p0;
	-(UIImageView *) imgCommnet;
	-(void) setImgCommnet:(UIImageView *)p0;
	-(UIView *) vwImageComment;
	-(void) setVwImageComment:(UIView *)p0;
	-(void) viewDidLoad;
	-(void) btnBack_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface cloudViewController : UITableViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(void) viewWillAppear:(BOOL)p0;
	-(void) viewDidAppear:(BOOL)p0;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface TelefoniaTableView : UITableViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(void) viewWillAppear:(BOOL)p0;
	-(void) viewDidAppear:(BOOL)p0;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface EditarRedesSocialesTableViewController : UITableViewController {
}
	@property (nonatomic, assign) UITextField * txtPaginaWeb;
	@property (nonatomic, assign) UITextField * txtUsuarioFacebook;
	@property (nonatomic, assign) UITextField * txtUsuarioInstagram;
	@property (nonatomic, assign) UITextField * txtUsuarioTwitter;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UITextField *) txtPaginaWeb;
	-(void) setTxtPaginaWeb:(UITextField *)p0;
	-(UITextField *) txtUsuarioFacebook;
	-(void) setTxtUsuarioFacebook:(UITextField *)p0;
	-(UITextField *) txtUsuarioInstagram;
	-(void) setTxtUsuarioInstagram:(UITextField *)p0;
	-(UITextField *) txtUsuarioTwitter;
	-(void) setTxtUsuarioTwitter:(UITextField *)p0;
	-(void) viewDidLoad;
	-(void) btnGardar:(UIBarButtonItem *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface FechaNacimientoPickerViewController : UIViewController {
}
	@property (nonatomic, assign) UIButton * btnCancelar;
	@property (nonatomic, assign) UIButton * btnSleccionar;
	@property (nonatomic, assign) UIDatePicker * dtpFechaNacimiento;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnCancelar;
	-(void) setBtnCancelar:(UIButton *)p0;
	-(UIButton *) btnSleccionar;
	-(void) setBtnSleccionar:(UIButton *)p0;
	-(UIDatePicker *) dtpFechaNacimiento;
	-(void) setDtpFechaNacimiento:(UIDatePicker *)p0;
	-(void) viewDidLoad;
	-(void) viewWillAppear:(BOOL)p0;
	-(void) btnCancelar_TouchUpInside:(UIButton *)p0;
	-(void) btnSeleccionar_TouchUpInside:(UIButton *)p0;
	-(void) dtpFechaNacimiento_ValueChanged:(UIDatePicker *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface SalaJuntasTableViewController : UITableViewController {
}
	@property (nonatomic, assign) UIButton * btnComprarHoras;
	@property (nonatomic, assign) UIButton * btnEditarSalaJuntas;
	@property (nonatomic, assign) UILabel * lblHorasDisponibles;
	@property (nonatomic, assign) UILabel * lblSalaJuntas;
	@property (nonatomic, assign) UIView * vwCalendarioJuntas;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnComprarHoras;
	-(void) setBtnComprarHoras:(UIButton *)p0;
	-(UIButton *) btnEditarSalaJuntas;
	-(void) setBtnEditarSalaJuntas:(UIButton *)p0;
	-(UILabel *) lblHorasDisponibles;
	-(void) setLblHorasDisponibles:(UILabel *)p0;
	-(UILabel *) lblSalaJuntas;
	-(void) setLblSalaJuntas:(UILabel *)p0;
	-(UIView *) vwCalendarioJuntas;
	-(void) setVwCalendarioJuntas:(UIView *)p0;
	-(void) viewDidLoad;
	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1;
	-(void) btnComprarHoras_Touch:(UIButton *)p0;
	-(void) btnEditarSalaJuntas_Touch:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface HorariosTableViewController : UITableViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(void) viewWillAppear:(BOOL)p0;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface HorariosTableViewCell : UITableViewCell {
}
	@property (nonatomic, assign) UILabel * lblDisponibilidad;
	@property (nonatomic, assign) UILabel * lblHorario;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UILabel *) lblDisponibilidad;
	-(void) setLblDisponibilidad:(UILabel *)p0;
	-(UILabel *) lblHorario;
	-(void) setLblHorario:(UILabel *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface comentarTableView : UITableViewController {
}
	@property (nonatomic, assign) UIBarButtonItem * btnBack;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIBarButtonItem *) btnBack;
	-(void) setBtnBack:(UIBarButtonItem *)p0;
	-(void) viewDidLoad;
	-(void) viewWillAppear:(BOOL)p0;
	-(void) viewWillDisappear:(BOOL)p0;
	-(UIView *) tableView:(UITableView *)p0 viewForHeaderInSection:(NSInteger)p1;
	-(CGFloat) tableView:(UITableView *)p0 heightForHeaderInSection:(NSInteger)p1;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1;
	-(void) btnBack_TouchUpInside:(UIBarButtonItem *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface HeaderComentarTableView : UITableViewCell {
}
	@property (nonatomic, assign) UIButton * btnComentarios;
	@property (nonatomic, assign) UIButton * btnImagenComentario;
	@property (nonatomic, assign) UIButton * btnLikes;
	@property (nonatomic, assign) UIImageView * imgComentarios;
	@property (nonatomic, assign) UIImageView * imgPerfil;
	@property (nonatomic, assign) UILabel * lblComentarios;
	@property (nonatomic, assign) UILabel * lblFechaComentario;
	@property (nonatomic, assign) UILabel * lblLikes;
	@property (nonatomic, assign) UILabel * lblNombre;
	@property (nonatomic, assign) UILabel * lblProfesion;
	@property (nonatomic, assign) UITextView * txtComentario;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnComentarios;
	-(void) setBtnComentarios:(UIButton *)p0;
	-(UIButton *) btnImagenComentario;
	-(void) setBtnImagenComentario:(UIButton *)p0;
	-(UIButton *) btnLikes;
	-(void) setBtnLikes:(UIButton *)p0;
	-(UIImageView *) imgComentarios;
	-(void) setImgComentarios:(UIImageView *)p0;
	-(UIImageView *) imgPerfil;
	-(void) setImgPerfil:(UIImageView *)p0;
	-(UILabel *) lblComentarios;
	-(void) setLblComentarios:(UILabel *)p0;
	-(UILabel *) lblFechaComentario;
	-(void) setLblFechaComentario:(UILabel *)p0;
	-(UILabel *) lblLikes;
	-(void) setLblLikes:(UILabel *)p0;
	-(UILabel *) lblNombre;
	-(void) setLblNombre:(UILabel *)p0;
	-(UILabel *) lblProfesion;
	-(void) setLblProfesion:(UILabel *)p0;
	-(UITextView *) txtComentario;
	-(void) setTxtComentario:(UITextView *)p0;
	-(void) btnComentarios_TouchUpInside:(UIButton *)p0;
	-(void) btnImagenComentarios_TouchUpInside:(UIButton *)p0;
	-(void) btnLikes_TouchUpInSide:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface ComentarNoInfoCell : UITableViewCell {
}
	@property (nonatomic, assign) UILabel * lblNoInfo;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UILabel *) lblNoInfo;
	-(void) setLblNoInfo:(UILabel *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface ComentarviewController : UIViewController {
}
	@property (nonatomic, assign) UIButton * btnCamara;
	@property (nonatomic, assign) UIButton * btnComentar;
	@property (nonatomic, assign) UITextView * txtComentario;
	@property (nonatomic, assign) UIView * vwVistaComentar;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnCamara;
	-(void) setBtnCamara:(UIButton *)p0;
	-(UIButton *) btnComentar;
	-(void) setBtnComentar:(UIButton *)p0;
	-(UITextView *) txtComentario;
	-(void) setTxtComentario:(UITextView *)p0;
	-(UIView *) vwVistaComentar;
	-(void) setVwVistaComentar:(UIView *)p0;
	-(void) viewDidLoad;
	-(void) viewWillAppear:(BOOL)p0;
	-(void) btnCamara_TouchUpInside:(UIButton *)p0;
	-(void) btnClose_TouchUpInside:(UIButton *)p0;
	-(void) btnComentar_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface BodyComentarTableView : UITableViewCell {
}
	@property (nonatomic, assign) UIButton * btnImagen;
	@property (nonatomic, assign) UIButton * btnLikes;
	@property (nonatomic, assign) UIImageView * imgPerfil;
	@property (nonatomic, assign) UILabel * lblFecha;
	@property (nonatomic, assign) UILabel * lblLikes;
	@property (nonatomic, assign) UILabel * lblNombre;
	@property (nonatomic, assign) UILabel * lblProfesion;
	@property (nonatomic, assign) UITextView * txtComentario;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnImagen;
	-(void) setBtnImagen:(UIButton *)p0;
	-(UIButton *) btnLikes;
	-(void) setBtnLikes:(UIButton *)p0;
	-(UIImageView *) imgPerfil;
	-(void) setImgPerfil:(UIImageView *)p0;
	-(UILabel *) lblFecha;
	-(void) setLblFecha:(UILabel *)p0;
	-(UILabel *) lblLikes;
	-(void) setLblLikes:(UILabel *)p0;
	-(UILabel *) lblNombre;
	-(void) setLblNombre:(UILabel *)p0;
	-(UILabel *) lblProfesion;
	-(void) setLblProfesion:(UILabel *)p0;
	-(UITextView *) txtComentario;
	-(void) setTxtComentario:(UITextView *)p0;
	-(void) btnImagen_TouchUpInside:(UIButton *)p0;
	-(void) btnLikes_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface WorklabsMx_iOS_ViewElements_UICheckBox : UIView {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) touchesBegan:(NSSet *)p0 withEvent:(UIEvent *)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface WorklabsMx_iOS_ViewElements_HorarioEventos : UIScrollView {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface WorklabsMx_iOS_ViewElements_UIDropdownList : UITableView {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface WorklabsMx_iOS_ViewElements_CommentCard : UIView {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface WorklabsMx_iOS_ViewElements_UIRadioButton : UIButton {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface WorklabsMx_iOS_Models_PickerModel : NSObject<UIPickerViewModel> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(NSInteger) numberOfComponentsInPickerView:(UIPickerView *)p0;
	-(NSInteger) pickerView:(UIPickerView *)p0 numberOfRowsInComponent:(NSInteger)p1;
	-(NSString *) pickerView:(UIPickerView *)p0 titleForRow:(NSInteger)p1 forComponent:(NSInteger)p2;
	-(void) pickerView:(UIPickerView *)p0 didSelectRow:(NSInteger)p1 inComponent:(NSInteger)p2;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface WorklabsMx_iOS_Models_SucursalesModel : NSObject<UIPickerViewModel> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(NSInteger) numberOfComponentsInPickerView:(UIPickerView *)p0;
	-(NSInteger) pickerView:(UIPickerView *)p0 numberOfRowsInComponent:(NSInteger)p1;
	-(NSString *) pickerView:(UIPickerView *)p0 titleForRow:(NSInteger)p1 forComponent:(NSInteger)p2;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface WorklabsMx_iOS_Models_CarritoCompras : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface WorklabsMx_iOS_Models_OrdenVentaController : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface WorklabsMx_iOS_Models_OrdenVentaDetalle : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface WorklabsMx_iOS_Styles_STLButton : UIButton {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface WorklabsMx_iOS_Styles_STLTextField : UITextField {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface WorklabsMx_iOS_Styles_STLLabel : UILabel {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface WorklabsMx_iOS_Styles_STLImageLabel : UIView {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface WorklabsMx_iOS_Styles_PickerDataModel : NSObject<UIPickerViewModel> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(NSInteger) pickerView:(UIPickerView *)p0 numberOfRowsInComponent:(NSInteger)p1;
	-(NSString *) pickerView:(UIPickerView *)p0 titleForRow:(NSInteger)p1 forComponent:(NSInteger)p2;
	-(NSInteger) numberOfComponentsInPickerView:(UIPickerView *)p0;
	-(void) pickerView:(UIPickerView *)p0 didSelectRow:(NSInteger)p1 inComponent:(NSInteger)p2;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface WorklabsMx_iOS_Styles_STLDropDownList : UITableView {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface WorklabsMx_iOS_Styles_STLCarritoCompra : UITableViewCell {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) layoutSubviews;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface WorklabsMx_iOS_Styles_STLLine : UIView {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface WorklabsMx_iOS_Helpers_LoadingView : UIView {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface WorklabsMx_iOS_Helpers_DropDownListSource : NSObject<UIScrollViewDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(void) tableView:(UITableView *)p0 didSelectRowAtIndexPath:(NSIndexPath *)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface SplitViewController : UISplitViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(void) didReceiveMemoryWarning;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface LoginViewController : UIViewController {
}
	@property (nonatomic, assign) UIButton * btnIniciarSesion;
	@property (nonatomic, assign) UIButton * btnRecuperar;
	@property (nonatomic, assign) UIButton * btnRegistro;
	@property (nonatomic, assign) UIButton * btnRestaurar;
	@property (nonatomic, assign) UITextField * txtEmail;
	@property (nonatomic, assign) UITextField * txtEmailRecuperar;
	@property (nonatomic, assign) UITextField * txtPassword;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnIniciarSesion;
	-(void) setBtnIniciarSesion:(UIButton *)p0;
	-(UIButton *) btnRecuperar;
	-(void) setBtnRecuperar:(UIButton *)p0;
	-(UIButton *) btnRegistro;
	-(void) setBtnRegistro:(UIButton *)p0;
	-(UIButton *) btnRestaurar;
	-(void) setBtnRestaurar:(UIButton *)p0;
	-(UITextField *) txtEmail;
	-(void) setTxtEmail:(UITextField *)p0;
	-(UITextField *) txtEmailRecuperar;
	-(void) setTxtEmailRecuperar:(UITextField *)p0;
	-(UITextField *) txtPassword;
	-(void) setTxtPassword:(UITextField *)p0;
	-(void) viewDidLoad;
	-(void) viewWillAppear:(BOOL)p0;
	-(void) touchesBegan:(NSSet *)p0 withEvent:(UIEvent *)p1;
	-(void) BtnIniciarSesion_TouchUpInside:(UIButton *)p0;
	-(void) BtnRegistro_TouchUpInside:(UIButton *)p0;
	-(void) BtnRestaurar_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface AccesoController : UIViewController {
}
	@property (nonatomic, assign) UIImageView * imgQr;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIImageView *) imgQr;
	-(void) setImgQr:(UIImageView *)p0;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface ReporteController : UIViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface PerfilController : UIViewController {
}
	@property (nonatomic, assign) UILabel * lblGenero;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UILabel *) lblGenero;
	-(void) setLblGenero:(UILabel *)p0;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface DatosFacturacionController : UIViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface DirectorioEmpresasController : UIViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface DirectorioUsuarioController : UIViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface CarritoCompraController : UIViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface MisColaboradoresBajaController : UIViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidAppear:(BOOL)p0;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface MisColaboradoresCambiosController : UIViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface MisColaboradoresController : UIViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidAppear:(BOOL)p0;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface RegistroInvitadosController : UIViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface TarifasController : UIViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface PaymentController : UIViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface EmpresaMiembroModificaController : UIViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface AboutMeModificaController : UIViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface PublicarPostViewController : UIViewController {
}
	@property (nonatomic, assign) UIButton * btnClose;
	@property (nonatomic, assign) UIButton * btnDeleteImge;
	@property (nonatomic, assign) UIButton * btnGaleria;
	@property (nonatomic, assign) UIButton * btnImageComment;
	@property (nonatomic, assign) UIButton * btnPublicar;
	@property (nonatomic, assign) UIImageView * imgPerfil;
	@property (nonatomic, assign) UILabel * lblFechaPublicacion;
	@property (nonatomic, assign) UILabel * lblNombre;
	@property (nonatomic, assign) UILabel * lblOcupacion;
	@property (nonatomic, assign) UITextView * txtPublicacion;
	@property (nonatomic, assign) UIView * vwVistaComentar;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnClose;
	-(void) setBtnClose:(UIButton *)p0;
	-(UIButton *) btnDeleteImge;
	-(void) setBtnDeleteImge:(UIButton *)p0;
	-(UIButton *) btnGaleria;
	-(void) setBtnGaleria:(UIButton *)p0;
	-(UIButton *) btnImageComment;
	-(void) setBtnImageComment:(UIButton *)p0;
	-(UIButton *) btnPublicar;
	-(void) setBtnPublicar:(UIButton *)p0;
	-(UIImageView *) imgPerfil;
	-(void) setImgPerfil:(UIImageView *)p0;
	-(UILabel *) lblFechaPublicacion;
	-(void) setLblFechaPublicacion:(UILabel *)p0;
	-(UILabel *) lblNombre;
	-(void) setLblNombre:(UILabel *)p0;
	-(UILabel *) lblOcupacion;
	-(void) setLblOcupacion:(UILabel *)p0;
	-(UITextView *) txtPublicacion;
	-(void) setTxtPublicacion:(UITextView *)p0;
	-(UIView *) vwVistaComentar;
	-(void) setVwVistaComentar:(UIView *)p0;
	-(void) viewDidLoad;
	-(void) viewWillAppear:(BOOL)p0;
	-(void) touchesBegan:(NSSet *)p0 withEvent:(UIEvent *)p1;
	-(void) imagePickerController:(UIImagePickerController *)p0 didFinishPickingImage:(UIImage *)p1 editingInfo:(NSDictionary *)p2;
	-(void) imagePickerControllerDidCancel:(UIImagePickerController *)p0;
	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1;
	-(void) btnClose_TouchUpInside:(UIButton *)p0;
	-(void) btnDeleteImage_TouchUpInside:(UIButton *)p0;
	-(void) btnGaleria_TouchUpInside:(UIButton *)p0;
	-(void) btnImageComment_TouchUpInside:(UIButton *)p0;
	-(void) btnPublicar_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface EscritorioController : UITableViewController {
}
	@property (nonatomic, assign) UIBarButtonItem * btnScanQr;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIBarButtonItem *) btnScanQr;
	-(void) setBtnScanQr:(UIBarButtonItem *)p0;
	-(void) viewDidLoad;
	-(void) viewWillAppear:(BOOL)p0;
	-(void) viewDidAppear:(BOOL)p0;
	-(UIView *) tableView:(UITableView *)p0 viewForHeaderInSection:(NSInteger)p1;
	-(CGFloat) tableView:(UITableView *)p0 heightForHeaderInSection:(NSInteger)p1;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1;
	-(void) btnToScanQr_TouchUpInside:(UIBarButtonItem *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface TabBarDetalleVenta : UITabBarController {
}
	@property (nonatomic, assign) UIBarButtonItem * btnCarrito;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIBarButtonItem *) btnCarrito;
	-(void) setBtnCarrito:(UIBarButtonItem *)p0;
	-(void) viewDidLoad;
	-(void) tabBar:(UITabBar *)p0 didSelectItem:(UITabBarItem *)p1;
	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1;
	-(void) btnCarrito_Touch:(UIBarButtonItem *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface CarritoProductos : UITableViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(void) viewWillAppear:(BOOL)p0;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface TableViewMembresia : UITableViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(void) viewWillAppear:(BOOL)p0;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface VentaDetalleTableViewController : UITableViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(void) viewWillAppear:(BOOL)p0;
	-(UIView *) tableView:(UITableView *)p0 viewForHeaderInSection:(NSInteger)p1;
	-(CGFloat) tableView:(UITableView *)p0 heightForHeaderInSection:(NSInteger)p1;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(void) tableView:(UITableView *)p0 didSelectRowAtIndexPath:(NSIndexPath *)p1;
	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1;
	-(void) btnAtras:(UIBarButtonItem *)p0;
	-(void) btnPagar:(UIBarButtonItem *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface PerfilTableViewController : UITableViewController {
}
	@property (nonatomic, assign) UIButton * btnEditarFecha;
	@property (nonatomic, assign) UIButton * btnEditarGenero;
	@property (nonatomic, assign) UIButton * btnFotografia;
	@property (nonatomic, assign) UIButton * btnGuardarCambios;
	@property (nonatomic, assign) UIImageView * imgPerfil;
	@property (nonatomic, assign) UILabel * lblFechaNacimiento;
	@property (nonatomic, assign) UILabel * lblGenero;
	@property (nonatomic, assign) UITextField * txtApellido;
	@property (nonatomic, assign) UITextField * txtEmail;
	@property (nonatomic, assign) UITextField * txtHabilidades;
	@property (nonatomic, assign) UITextField * txtNombre;
	@property (nonatomic, assign) UITextField * txtProfesion;
	@property (nonatomic, assign) UITextField * txtTelefono;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnEditarFecha;
	-(void) setBtnEditarFecha:(UIButton *)p0;
	-(UIButton *) btnEditarGenero;
	-(void) setBtnEditarGenero:(UIButton *)p0;
	-(UIButton *) btnFotografia;
	-(void) setBtnFotografia:(UIButton *)p0;
	-(UIButton *) btnGuardarCambios;
	-(void) setBtnGuardarCambios:(UIButton *)p0;
	-(UIImageView *) imgPerfil;
	-(void) setImgPerfil:(UIImageView *)p0;
	-(UILabel *) lblFechaNacimiento;
	-(void) setLblFechaNacimiento:(UILabel *)p0;
	-(UILabel *) lblGenero;
	-(void) setLblGenero:(UILabel *)p0;
	-(UITextField *) txtApellido;
	-(void) setTxtApellido:(UITextField *)p0;
	-(UITextField *) txtEmail;
	-(void) setTxtEmail:(UITextField *)p0;
	-(UITextField *) txtHabilidades;
	-(void) setTxtHabilidades:(UITextField *)p0;
	-(UITextField *) txtNombre;
	-(void) setTxtNombre:(UITextField *)p0;
	-(UITextField *) txtProfesion;
	-(void) setTxtProfesion:(UITextField *)p0;
	-(UITextField *) txtTelefono;
	-(void) setTxtTelefono:(UITextField *)p0;
	-(void) viewDidLoad;
	-(void) imagePickerController:(UIImagePickerController *)p0 didFinishPickingImage:(UIImage *)p1 editingInfo:(NSDictionary *)p2;
	-(void) imagePickerControllerDidCancel:(UIImagePickerController *)p0;
	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1;
	-(void) btnEditarFecha_TouchUpInside:(UIButton *)p0;
	-(void) btnEditarGenero_TouchUpInside:(UIButton *)p0;
	-(void) btnFoto_TpuchUpInside:(UIButton *)p0;
	-(void) btnGuardarCambios_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface DatosEmpresaTableViewController : UITableViewController {
}
	@property (nonatomic, assign) UIButton * btnActualizarEmpresa;
	@property (nonatomic, assign) UIButton * btnEditarDireccion;
	@property (nonatomic, assign) UIButton * btnEditarRedesSociales;
	@property (nonatomic, assign) UIButton * imgCamara;
	@property (nonatomic, assign) UIImageView * imgPerfil;
	@property (nonatomic, assign) UITextField * txtCorreoElectronico;
	@property (nonatomic, assign) UITextField * txtGiroComercial;
	@property (nonatomic, assign) UITextField * txtNombreEmpresa;
	@property (nonatomic, assign) UITextField * txtRazonSocial;
	@property (nonatomic, assign) UITextField * txtRFC;
	@property (nonatomic, assign) UITextField * txtTelefono;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnActualizarEmpresa;
	-(void) setBtnActualizarEmpresa:(UIButton *)p0;
	-(UIButton *) btnEditarDireccion;
	-(void) setBtnEditarDireccion:(UIButton *)p0;
	-(UIButton *) btnEditarRedesSociales;
	-(void) setBtnEditarRedesSociales:(UIButton *)p0;
	-(UIButton *) imgCamara;
	-(void) setImgCamara:(UIButton *)p0;
	-(UIImageView *) imgPerfil;
	-(void) setImgPerfil:(UIImageView *)p0;
	-(UITextField *) txtCorreoElectronico;
	-(void) setTxtCorreoElectronico:(UITextField *)p0;
	-(UITextField *) txtGiroComercial;
	-(void) setTxtGiroComercial:(UITextField *)p0;
	-(UITextField *) txtNombreEmpresa;
	-(void) setTxtNombreEmpresa:(UITextField *)p0;
	-(UITextField *) txtRazonSocial;
	-(void) setTxtRazonSocial:(UITextField *)p0;
	-(UITextField *) txtRFC;
	-(void) setTxtRFC:(UITextField *)p0;
	-(UITextField *) txtTelefono;
	-(void) setTxtTelefono:(UITextField *)p0;
	-(void) viewDidLoad;
	-(void) imagePickerController:(UIImagePickerController *)p0 didFinishPickingImage:(UIImage *)p1 editingInfo:(NSDictionary *)p2;
	-(void) imagePickerControllerDidCancel:(UIImagePickerController *)p0;
	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1;
	-(void) btnActualizar_TouchUpInside:(UIButton *)p0;
	-(void) btnEditarDireccion_TouchUpInside:(UIButton *)p0;
	-(void) btnRedesSociales_TouchUpInside:(UIButton *)p0;
	-(void) btnTomarFoto_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface DireccionEmpresaTableViewController : UITableViewController {
}
	@property (nonatomic, assign) UIButton * btnEditarColonia;
	@property (nonatomic, assign) UITextField * txtCalle;
	@property (nonatomic, assign) UITextField * txtCodigoPostal;
	@property (nonatomic, assign) UITextField * txtColonia;
	@property (nonatomic, assign) UITextField * txtEstado;
	@property (nonatomic, assign) UITextField * txtMunicipio;
	@property (nonatomic, assign) UITextField * txtNumeroExterior;
	@property (nonatomic, assign) UITextField * txtNumeroInterior;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnEditarColonia;
	-(void) setBtnEditarColonia:(UIButton *)p0;
	-(UITextField *) txtCalle;
	-(void) setTxtCalle:(UITextField *)p0;
	-(UITextField *) txtCodigoPostal;
	-(void) setTxtCodigoPostal:(UITextField *)p0;
	-(UITextField *) txtColonia;
	-(void) setTxtColonia:(UITextField *)p0;
	-(UITextField *) txtEstado;
	-(void) setTxtEstado:(UITextField *)p0;
	-(UITextField *) txtMunicipio;
	-(void) setTxtMunicipio:(UITextField *)p0;
	-(UITextField *) txtNumeroExterior;
	-(void) setTxtNumeroExterior:(UITextField *)p0;
	-(UITextField *) txtNumeroInterior;
	-(void) setTxtNumeroInterior:(UITextField *)p0;
	-(void) viewDidLoad;
	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1;
	-(void) btnEditarColonia_TouchupInside:(UIButton *)p0;
	-(void) btnGuardar:(UIBarButtonItem *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface WorklabsMx_iOS_GeneroViewController_StackOverflowModel : NSObject<UIPickerViewModel> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(NSInteger) numberOfComponentsInPickerView:(UIPickerView *)p0;
	-(NSInteger) pickerView:(UIPickerView *)p0 numberOfRowsInComponent:(NSInteger)p1;
	-(NSString *) pickerView:(UIPickerView *)p0 titleForRow:(NSInteger)p1 forComponent:(NSInteger)p2;
	-(void) pickerView:(UIPickerView *)p0 didSelectRow:(NSInteger)p1 inComponent:(NSInteger)p2;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface GeneroViewController : UIViewController {
}
	@property (nonatomic, assign) UIButton * btnCancelar;
	@property (nonatomic, assign) UIButton * btnSeleccionar;
	@property (nonatomic, assign) UIPickerView * dtpGenero;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnCancelar;
	-(void) setBtnCancelar:(UIButton *)p0;
	-(UIButton *) btnSeleccionar;
	-(void) setBtnSeleccionar:(UIButton *)p0;
	-(UIPickerView *) dtpGenero;
	-(void) setDtpGenero:(UIPickerView *)p0;
	-(void) viewDidLoad;
	-(void) viewWillAppear:(BOOL)p0;
	-(void) btnCancelar_TouchUpInside:(UIButton *)p0;
	-(void) btnSeleccionar_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface WorklabsMx_iOS_ColoniaViewController_StackOverflowModel : NSObject<UIPickerViewModel> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(NSInteger) numberOfComponentsInPickerView:(UIPickerView *)p0;
	-(NSInteger) pickerView:(UIPickerView *)p0 numberOfRowsInComponent:(NSInteger)p1;
	-(NSString *) pickerView:(UIPickerView *)p0 titleForRow:(NSInteger)p1 forComponent:(NSInteger)p2;
	-(void) pickerView:(UIPickerView *)p0 didSelectRow:(NSInteger)p1 inComponent:(NSInteger)p2;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface ColoniaViewController : UIViewController {
}
	@property (nonatomic, assign) UIButton * btnCancelar;
	@property (nonatomic, assign) UIButton * btnSeleccionar;
	@property (nonatomic, assign) UIPickerView * dtpColonia;
	@property (nonatomic, assign) UIView * vwEditarColonia;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnCancelar;
	-(void) setBtnCancelar:(UIButton *)p0;
	-(UIButton *) btnSeleccionar;
	-(void) setBtnSeleccionar:(UIButton *)p0;
	-(UIPickerView *) dtpColonia;
	-(void) setDtpColonia:(UIPickerView *)p0;
	-(UIView *) vwEditarColonia;
	-(void) setVwEditarColonia:(UIView *)p0;
	-(void) viewDidLoad;
	-(void) viewWillAppear:(BOOL)p0;
	-(void) btnCancelar_TouchUpInside:(UIButton *)p0;
	-(void) btnSeleccionar_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface WorklabsMx_iOS_SucursalesViewController_StackOverflowModel : NSObject<UIPickerViewModel> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(NSInteger) numberOfComponentsInPickerView:(UIPickerView *)p0;
	-(NSInteger) pickerView:(UIPickerView *)p0 numberOfRowsInComponent:(NSInteger)p1;
	-(NSString *) pickerView:(UIPickerView *)p0 titleForRow:(NSInteger)p1 forComponent:(NSInteger)p2;
	-(void) pickerView:(UIPickerView *)p0 didSelectRow:(NSInteger)p1 inComponent:(NSInteger)p2;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface SucursalesViewController : UIViewController {
}
	@property (nonatomic, assign) UIButton * btnCancelar;
	@property (nonatomic, assign) UIButton * btnSeleccionar;
	@property (nonatomic, assign) UIPickerView * pcvSucursales;
	@property (nonatomic, assign) UIView * vwSucursales;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnCancelar;
	-(void) setBtnCancelar:(UIButton *)p0;
	-(UIButton *) btnSeleccionar;
	-(void) setBtnSeleccionar:(UIButton *)p0;
	-(UIPickerView *) pcvSucursales;
	-(void) setPcvSucursales:(UIPickerView *)p0;
	-(UIView *) vwSucursales;
	-(void) setVwSucursales:(UIView *)p0;
	-(void) viewDidLoad;
	-(void) viewWillAppear:(BOOL)p0;
	-(void) btnCancelar_Touch:(UIButton *)p0;
	-(void) btnSeleccionar_Touch:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface WorklabsMx_iOS_ViewElements_PostCard : UIView {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface WorklabsMx_iOS_Styles_STLTableViewSource : NSObject<UIScrollViewDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(void) tableView:(UITableView *)p0 didSelectRowAtIndexPath:(NSIndexPath *)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface WorklabsMx_iOS_Styles_STLImageView : UIImageView {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface __UIGestureRecognizerToken : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface __UIGestureRecognizerParameterlessToken : __UIGestureRecognizerToken {
}
	-(void) target;
@end

@interface __UIGestureRecognizerParametrizedToken : __UIGestureRecognizerToken {
}
	-(void) target:(UIGestureRecognizer *)p0;
@end

@interface UIKit_UIView_UIViewAppearance : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) setBackgroundColor:(UIColor *)p0;
	-(void) setTintColor:(UIColor *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface UIKit_UINavigationBar_UINavigationBarAppearance : UIKit_UIView_UIViewAppearance {
}
	-(void) setBarTintColor:(UIColor *)p0;
	-(void) setTranslucent:(BOOL)p0;
	-(void) setTitleTextAttributes:(NSDictionary *)p0;
@end

@interface BigTed_ProgressHUD : UIView {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) drawRect:(CGRect)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end


