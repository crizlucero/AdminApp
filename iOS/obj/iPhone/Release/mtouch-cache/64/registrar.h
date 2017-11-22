#pragma clang diagnostic ignored "-Wdeprecated-declarations"
#pragma clang diagnostic ignored "-Wtypedef-redefinition"
#pragma clang diagnostic ignored "-Wobjc-designated-initializers"
#include <stdarg.h>
#include <objc/objc.h>
#include <objc/runtime.h>
#include <objc/message.h>
#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import <Photos/Photos.h>
#import <MessageUI/MessageUI.h>
#import <Contacts/Contacts.h>
#import <EventKit/EventKit.h>
#import <QuartzCore/QuartzCore.h>
#import <CloudKit/CloudKit.h>
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
@class DashboardController;
@class SubMenuController;
@class FacturasController;
@class MiMembresiaController;
@protocol TKCalendarDataSource;
@class WorklabsMx_iOS_CalendarDataSource;
@protocol TKCalendarDelegate;
@class WorklabsMx_iOS_CalendarDelegate;
@class TabBarColaboradorController;
@class TabBarController;
@class EmpresaMiembroController;
@class AboutMeController;
@class NoComentsCell;
@class ComentariosBodyCell;
@class ComentarPostHeaderCell;
@class ComentarioViewCell;
@class NoComentariosViewCell;
@class DetailCommentImage;
@class HeaderCarritoProductos;
@class CeldaCarritoProductos;
@class CeldaNoProductos;
@class TableViewCellMembresias;
@class TableViewCellNoMembresias;
@class CeldaNoDetalleVenta;
@class CeldaVentaDetalle;
@class VentaDetalleHeader;
@class EscritorioHeaderCell;
@class EscritorioController;
@class DetalleVentaViewController;
@class CanjearCuponController;
@class WorklabsMx_iOS_ViewElements_UICheckBox;
@class WorklabsMx_iOS_ViewElements_HorarioEventos;
@class WorklabsMx_iOS_ViewElements_UIDropdownList;
@class WorklabsMx_iOS_ViewElements_CommentCard;
@class WorklabsMx_iOS_ViewElements_UIRadioButton;
@class WorklabsMx_iOS_Models_PickerModel;
@class WorklabsMx_iOS_Models_SucursalesModel;
@class WorklabsMx_iOS_Models_CarritoCompras;
@class WorklabsMx_iOS_Styles_STLButton;
@class WorklabsMx_iOS_Styles_STLTextField;
@class WorklabsMx_iOS_Styles_STLLabel;
@class WorklabsMx_iOS_Styles_STLImageLabel;
@class WorklabsMx_iOS_Styles_PickerDataModel;
@class WorklabsMx_iOS_Styles_STLDropDownList;
@class WorklabsMx_iOS_Styles_STLCarritoCompra;
@class WorklabsMx_iOS_Styles_STLLine;
@class WorklabsMx_iOS_Helpers_LoadingView;
@class TKView;
@class TKCalendar;
@class WorklabsMx_iOS_Helpers_Calendario;
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
@class ReservaController;
@class RegistroInvitadosController;
@class TarifasController;
@class PaymentController;
@class EmpresaMiembroModificaController;
@class AboutMeModificaController;
@class PublicarPostViewController;
@class ComentarPostTableViewController;
@class SeccionComentariosTableViewController;
@class CarritoProductos;
@class TableViewMembresia;
@class VentaDetalleTableViewController;
@class TabBarDetalleVenta;
@class WorklabsMx_iOS_ViewElements_PostCard;
@class WorklabsMx_iOS_Styles_STLTableViewSource;
@class WorklabsMx_iOS_Styles_STLImageView;
@class __UIGestureRecognizerToken;
@class __UIGestureRecognizerParameterlessToken;
@class __UIGestureRecognizerParametrizedToken;
@class __NSObject_Disposer;
@class UIKit_UIImagePickerController__UIImagePickerControllerDelegate;
@class UIKit_UIView_UIViewAppearance;
@class UIKit_UILabel_UILabelAppearance;
@class __UILongPressGestureRecognizer;
@class __UIPanGestureRecognizer;
@class UIKit_UIControl_UIControlAppearance;
@class __UIRotationGestureRecognizer;
@class __UITapGestureRecognizer;
@class __UIPinchGestureRecognizer;
@class __UISwipeGestureRecognizer;
@class __UIScreenEdgePanGestureRecognizer;
@class UIKit_UIAlertView__UIAlertViewDelegate;
@class UIKit_UIBarButtonItem_Callback;
@class UIKit_UIButton_UIButtonAppearance;
@class UIKit_UIScrollView_UIScrollViewAppearance;
@class UIKit_UICollectionView_UICollectionViewAppearance;
@class UIKit_UITableView_UITableViewAppearance;
@class UIKit_UITableViewCell_UITableViewCellAppearance;
@class UIKit_UITextField__UITextFieldDelegate;
@class UIKit_UITextField_UITextFieldAppearance;
@class UIKit_UIScrollView__UIScrollViewDelegate;
@class UIKit_UITextView__UITextViewDelegate;
@class UIKit_UICollectionReusableView_UICollectionReusableViewAppearance;
@class UIKit_UICollectionViewCell_UICollectionViewCellAppearance;
@class TKAlert;
@class TKAlertAction;
@protocol TKAlertDelegate;
@class TKStyleNode;
@class TKAlertStyle;
@class TKAutoCompleteController;
@protocol TKAutoCompleteDataSource;
@protocol TKAutoCompleteDelegate;
@protocol TKAutoCompleteSuggestViewDelegate;
@class TKAutoCompleteToken;
@class TKShape;
@class TKBalloonShape;
@class TKCalendarCellStyle;
@class TKCalendarDayCellStyle;
@class TKCalendarDayViewAllDayEventCellStyle;
@class TKCalendarDayViewAllDayEventsViewStyle;
@class TKCalendarDayViewEventCellStyle;
@class TKCalendarDayViewEventsLayout;
@class TKCalendarDayViewEventsViewStyle;
@class TKCalendarDayViewPresenterStyle;
@class TKCalendarDayViewTimeLineLayoutAttributes;
@protocol TKCalendarEventProtocol;
@class TKCalendarEvent;
@class TKCalendarEventKitDataSource;
@protocol TKCalendarEventKitDataSourceDelegate;
@protocol TKCalendarPresenter;
@class TKCalendarFlowPresenter;
@class TKCalendarInlineViewTableViewCellStyle;
@class TKTheme;
@class TKCalendarIPadTheme;
@protocol TKCalendarPresenterDelegate;
@protocol TKCalendarMonthPresenterDelegate;
@class TKCalendarMonthPresenterStyle;
@class TKCalendarMonthViewController;
@class TKCalendarYearPresenterStyle;
@class TKCalendarYearViewController;
@protocol TKCalendarYearViewControllerDelegate;
@class TKChartSeries;
@class TKChartFinancialIndicator;
@class TKChartSignalLineIndicator;
@class TKChartMACDIndicator;
@class TKChartAbsoluteVolumeOscillator;
@class TKChartAccumulationDistributionLine;
@class TKChartAdaptiveMovingAverageIndicator;
@class TKChartAnnotation;
@class TKChartAnnotationStyle;
@class TKChartLineSeries;
@class TKChartAreaSeries;
@class TKChartTrueRangeIndicator;
@class TKChartAverageTrueRangeIndicator;
@class TKChartAxis;
@class TKChartLabelStyle;
@class TKChartAxisLabelStyle;
@class TKChartAxisTickStyle;
@class TKChartAxisMajorTickStyle;
@class TKChartRender;
@class TKChartAxisRender;
@class TKChartAxisStyle;
@class TKChartAxisTitleStyle;
@class TKChartPointAnnotation;
@class TKChartBalloonAnnotation;
@class TKChartBalloonAnnotationStyle;
@class TKChartBandAnnotation;
@class TKChartGridLineAnnotationStyle;
@class TKChartBandAnnotationStyle;
@class TKChartBandIndicator;
@class TKChartVisualPoint;
@class TKChartBandVisualPoint;
@class TKChartBarSeries;
@class TKChartBollingerBandIndicator;
@protocol TKChartData;
@class TKChartBubbleDataPoint;
@class TKChartScatterSeries;
@class TKChartBubbleSeries;
@class TKChartBubbleVisualPoint;
@class TKChartColumnSeries;
@class TKChartOhlcSeries;
@class TKChartCandlestickSeries;
@class TKChartCategoryAxis;
@class TKChartChaikinOscillator;
@class TKChartCommodityChannelIndex;
@class TKChartCrossLineAnnotation;
@class TKChartCrossLineAnnotationStyle;
@class TKChartDataPoint;
@protocol TKChartDataSource;
@class TKChartDateTimeAxis;
@class TKChartDateTimeCategoryAxis;
@protocol TKChartDelegate;
@class TKChartDetrendedPriceOscillator;
@class TKChartPieSeries;
@class TKChartDonutSeries;
@class TKChartEaseOfMovementIndicator;
@class TKChartSimpleMovingAverageIndicator;
@class TKChartExponentialMovingAverageIndicator;
@class TKChartFastStochasticIndicator;
@class TKChartFinancialDataPoint;
@class TKChartForceIndexIndicator;
@class TKChartSlowStochasticIndicator;
@class TKChartFullStochasticIndicator;
@class TKChartGridLineAnnotation;
@class TKChartGridStyle;
@class TKChartLayerAnnotation;
@protocol TKChartLegendItemDelegate;
@class TKChartLegendItemStyle;
@class TKChartLegendStyle;
@class TKChartNumericAxis;
@class TKChartLogarithmicAxis;
@class TKChartMarketFacilitationIndex;
@class TKChartMedianPriceIndicator;
@class TKChartModifiedMovingAverageIndicator;
@class TKChartMoneyFlowIndexIndicator;
@class TKChartMovingAverageEnvelopesIndicator;
@class TKChartNegativeVolumeIndexIndicator;
@class TKChartOnBalanceVolumeIndicator;
@class TKChartPalette;
@class TKChartPaletteItem;
@class TKChartPercentagePriceOscillator;
@class TKChartPercentageVolumeOscillator;
@class TKChartPieVisualPoint;
@class TKChartPointLabel;
@class TKChartPointLabelRender;
@class TKChartPointLabelStyle;
@class TKChartPositiveVolumeIndexIndicator;
@class TKChartPriceVolumeTrendIndicator;
@class TKChartRangeBarSeries;
@class TKChartRangeColumnSeries;
@class TKChartRangeDataPoint;
@class TKChartRangeVisualPoint;
@class TKChartRapidAdaptiveVarianceIndicator;
@class TKChartRateOfChangeIndicator;
@class TKChartRelativeMomentumIndex;
@class TKChartRelativeStrengthIndex;
@class TKChartSelectionInfo;
@class TKChartSeriesRender;
@class TKChartSeriesRenderState;
@class TKChartSeriesStyle;
@class TKChartSplineAreaSeries;
@class TKChartSplineSeries;
@class TKChartStackInfo;
@class TKChartStandardDeviationIndicator;
@class TKChartTitleStyle;
@class TKChartTrackball;
@class TKChartTrackballLineAnnotation;
@class TKChartTrackballTooltipAnnotation;
@class TKChartTriangularMovingAverageIndicator;
@class TKChartTRIXIndicator;
@class TKChartTypicalPriceIndicator;
@class TKChartUltimateOscillator;
@class TKChartViewAnnotation;
@class TKChartViewController;
@class TKChartWeightedCloseIndicator;
@class TKChartWeightedMovingAverageIndicator;
@class TKChartWilliamsPercentIndicator;
@class TKCoreLayoutItem;
@class TKCoreStackLayout;
@class TKDataFormAutocompleteController;
@protocol TKDataFormDataSource;
@protocol TKDataFormDelegate;
@class TKDataFormEditorStyle;
@class TKDataFormPropertyValidator;
@class TKDataFormEmailValidator;
@class TKEntity;
@class TKDataFormEntityDataSource;
@class TKDataFormGroupTitleStyle;
@class TKDataFormMaximumLengthValidator;
@class TKDataFormMinimumLengthValidator;
@class TKDataFormNonEmptyValidator;
@class TKDataFormPhoneValidator;
@class TKDataFormRangeValidator;
@protocol TKDataFormValidator;
@class TKDataFormViewController;
@class TKDataSource;
@class TKDataSourceAutoCompleteSettings;
@class TKDataSourceCalendarSettings;
@class TKDataSourceChartSettings;
@class TKDataSourceCollectionViewSettings;
@class TKDataSourceFilterDescriptor;
@class TKDataSourceGroup;
@class TKDataSourceGroupDescriptor;
@class TKDataSourceListViewSettings;
@class TKDataSourceSettings;
@class TKDataSourceSortDescriptor;
@class TKDataSourceTableViewSettings;
@class TKDateRange;
@protocol TKDrawing;
@class TKEntityProperty;
@class TKEntityPropertyGroup;
@class TKExamplesDetailViewController;
@class TKExamplesExampleInfo;
@class TKExamplesExampleViewController;
@class TKExamplesMasterViewController;
@class TKExamplesOptionInfo;
@class TKExamplesSectionInfo;
@class TKExamplesSplitViewController;
@class TKFeedback;
@class TKFeedbackController;
@protocol TKFeedbackDataSource;
@class TKFeedbackItem;
@class TKFill;
@protocol TKGaugeDelegate;
@class TKGaugeIndicator;
@class TKGaugeLabels;
@class TKGaugeScale;
@class TKGaugeLinearScale;
@class TKGaugeNeedle;
@class TKGaugeRadialScale;
@class TKGaugeSegment;
@class TKGaugeTicks;
@class TKGradientFill;
@protocol TKLayout;
@class TKGridLayout;
@class TKGridLayoutCellDefinition;
@class TKImageFill;
@class TKLayer;
@class TKLayoutInfo;
@class TKLinearGradientFill;
@protocol TKListViewDataSource;
@protocol TKListViewDelegate;
@class TKListViewLinearLayout;
@class TKListViewGridLayout;
@protocol TKListViewLinearLayoutDelegate;
@class TKListViewStaggeredLayout;
@class TKMutableArray;
@class TKPlatformFeedbackSource;
@class TKPredefinedShape;
@class TKRadialGradientFill;
@class TKRange;
@class TKSideDrawerController;
@protocol TKSideDrawerDelegate;
@class TKSideDrawerItem;
@class TKSideDrawerItemStyle;
@class TKSideDrawerSection;
@class TKSideDrawerStyle;
@class TKSideDrawerTransition;
@protocol TKSlideViewDelegate;
@class TKSolidFill;
@class TKStackLayout;
@class TKStroke;
@class TKStyleGroup;
@class TKStyleID;
@class TKStyleSheet;
@class TKWeakReference;
@class TelerikUI_TKView_TKViewAppearance;
@class TelerikUI_TKAlertButtonsView_TKAlertButtonsViewAppearance;
@class TKAlertButtonsView;
@class TelerikUI_TKAlertContentView_TKAlertContentViewAppearance;
@class TKAlertContentView;
@class TelerikUI_TKAlertView_TKAlertViewAppearance;
@class TKAlertView;
@class TelerikUI_TKAutoCompleteCoverView_TKAutoCompleteCoverViewAppearance;
@class TKAutoCompleteCoverView;
@class TelerikUI_TKListViewReusableCell_TKListViewReusableCellAppearance;
@class TelerikUI_TKListViewCell_TKListViewCellAppearance;
@class TelerikUI_TKAutoCompleteSuggestionCell_TKAutoCompleteSuggestionCellAppearance;
@class TKListViewReusableCell;
@class TKListViewCell;
@class TKAutoCompleteSuggestionCell;
@class TelerikUI_TKAutoCompleteTextView_TKAutoCompleteTextViewAppearance;
@class TKAutoCompleteTextView;
@class TelerikUI_TKAutoCompleteTokenHolderView_TKAutoCompleteTokenHolderViewAppearance;
@class TKAutoCompleteTokenHolderView;
@class TelerikUI_TKAutoCompleteTokenRemoveButton_TKAutoCompleteTokenRemoveButtonAppearance;
@class TKAutoCompleteTokenRemoveButton;
@class TelerikUI_TKAutoCompleteTokenView_TKAutoCompleteTokenViewAppearance;
@class TKAutoCompleteTokenView;
@class TelerikUI_TKCalendar_TKCalendarAppearance;
@class TelerikUI_TKCalendarCell_TKCalendarCellAppearance;
@class TKCalendarCell;
@class TelerikUI_TKCalendarDayCell_TKCalendarDayCellAppearance;
@class TKCalendarDayCell;
@class TelerikUI_TKCalendarDayNameCell_TKCalendarDayNameCellAppearance;
@class TKCalendarDayNameCell;
@class TelerikUI_TKCalendarDayView_TKCalendarDayViewAppearance;
@class TKCalendarDayView;
@class TelerikUI_TKCalendarDayViewAllDayEventCell_TKCalendarDayViewAllDayEventCellAppearance;
@class TKCalendarDayViewAllDayEventCell;
@class TelerikUI_TKCalendarDayViewAllDayEventsView_TKCalendarDayViewAllDayEventsViewAppearance;
@class TKCalendarDayViewAllDayEventsView;
@class TelerikUI_TKCalendarDayViewEventCell_TKCalendarDayViewEventCellAppearance;
@class TKCalendarDayViewEventCell;
@class TelerikUI_TKCalendarDayViewEventsView_TKCalendarDayViewEventsViewAppearance;
@class TKCalendarDayViewEventsView;
@class TelerikUI_TKCalendarPresenterBase_TKCalendarPresenterBaseAppearance;
@class TelerikUI_TKCalendarDayViewPresenter_TKCalendarDayViewPresenterAppearance;
@class TKCalendarPresenterBase;
@class TKCalendarDayViewPresenter;
@class TelerikUI_TKCalendarDayViewTimeLine_TKCalendarDayViewTimeLineAppearance;
@class TKCalendarDayViewTimeLine;
@class TelerikUI_TKCalendarInlineView_TKCalendarInlineViewAppearance;
@class TKCalendarInlineView;
@class TelerikUI_TKCalendarInlineViewTableViewCell_TKCalendarInlineViewTableViewCellAppearance;
@class TKCalendarInlineViewTableViewCell;
@class TelerikUI_TKCalendarMonthCell_TKCalendarMonthCellAppearance;
@class TKCalendarMonthCell;
@class TelerikUI_TKCalendarMonthNameCell_TKCalendarMonthNameCellAppearance;
@class TKCalendarMonthNameCell;
@class TelerikUI_TKCalendarMonthNamesPresenter_TKCalendarMonthNamesPresenterAppearance;
@class TKCalendarMonthNamesPresenter;
@class TelerikUI_TKCalendarMonthPresenter_TKCalendarMonthPresenterAppearance;
@class TKCalendarMonthPresenter;
@class TelerikUI_TKCalendarTitleCell_TKCalendarTitleCellAppearance;
@class TelerikUI_TKCalendarMonthTitleCell_TKCalendarMonthTitleCellAppearance;
@class TKCalendarTitleCell;
@class TKCalendarMonthTitleCell;
@class TelerikUI_TKCalendarMonthView_TKCalendarMonthViewAppearance;
@class TKCalendarMonthView;
@class TelerikUI_TKCalendarWeekDayCell_TKCalendarWeekDayCellAppearance;
@class TKCalendarWeekDayCell;
@class TelerikUI_TKCalendarWeekNumberCell_TKCalendarWeekNumberCellAppearance;
@class TKCalendarWeekNumberCell;
@class TelerikUI_TKCalendarWeekPresenter_TKCalendarWeekPresenterAppearance;
@class TKCalendarWeekPresenter;
@class TelerikUI_TKCalendarYearNumberCell_TKCalendarYearNumberCellAppearance;
@class TKCalendarYearNumberCell;
@class TelerikUI_TKCalendarYearNumbersPresenter_TKCalendarYearNumbersPresenterAppearance;
@class TKCalendarYearNumbersPresenter;
@class TelerikUI_TKCalendarYearPresenter_TKCalendarYearPresenterAppearance;
@class TKCalendarYearPresenter;
@class TelerikUI_TKCalendarYearTitleView_TKCalendarYearTitleViewAppearance;
@class TKCalendarYearTitleView;
@class TelerikUI_TKChart_TKChartAppearance;
@class TKChart;
@class TelerikUI_TKCoreStackLayoutView_TKCoreStackLayoutViewAppearance;
@class TelerikUI_TKChartLegendContainer_TKChartLegendContainerAppearance;
@class TKCoreStackLayoutView;
@class TKChartLegendContainer;
@class TelerikUI_TKChartLegendItem_TKChartLegendItemAppearance;
@class TKChartLegendItem;
@class TelerikUI_TKChartLegendView_TKChartLegendViewAppearance;
@class TKChartLegendView;
@class TelerikUI_TKChartPlotView_TKChartPlotViewAppearance;
@class TKChartPlotView;
@class TelerikUI_TKChartTitleView_TKChartTitleViewAppearance;
@class TKChartTitleView;
@class TelerikUI_TKCheckView_TKCheckViewAppearance;
@class TKCheckView;
@class TelerikUI_TKCollectionViewCell_TKCollectionViewCellAppearance;
@class TKCollectionViewCell;
@class TelerikUI_TKDataForm_TKDataFormAppearance;
@class TKDataForm;
@class TelerikUI_TKDataFormAccessoryView_TKDataFormAccessoryViewAppearance;
@class TKDataFormAccessoryView;
@class TelerikUI_TKDataFormEditor_TKDataFormEditorAppearance;
@class TelerikUI_TKDataFormViewControllerEditor_TKDataFormViewControllerEditorAppearance;
@class TelerikUI_TKDataFormAutocompleteEditor_TKDataFormAutocompleteEditorAppearance;
@class TKDataFormEditor;
@class TKDataFormViewControllerEditor;
@class TKDataFormAutocompleteEditor;
@class TelerikUI_TKDataFormAutoCompleteInlineEditor_TKDataFormAutoCompleteInlineEditorAppearance;
@class TKDataFormAutoCompleteInlineEditor;
@class TelerikUI_TKDataFormInlineEditor_TKDataFormInlineEditorAppearance;
@class TelerikUI_TKDataFormDatePickerEditor_TKDataFormDatePickerEditorAppearance;
@class TKDataFormInlineEditor;
@class TKDataFormDatePickerEditor;
@class TelerikUI_TKDataFormTextFieldEditor_TKDataFormTextFieldEditorAppearance;
@class TelerikUI_TKDataFormDecimalEditor_TKDataFormDecimalEditorAppearance;
@class TKDataFormTextFieldEditor;
@class TKDataFormDecimalEditor;
@class TelerikUI_TKDataFormEmailEditor_TKDataFormEmailEditorAppearance;
@class TKDataFormEmailEditor;
@class TelerikUI_TKDataFormMultilineTextEditor_TKDataFormMultilineTextEditorAppearance;
@class TKDataFormMultilineTextEditor;
@class TelerikUI_TKDataFormNamePhoneEditor_TKDataFormNamePhoneEditorAppearance;
@class TKDataFormNamePhoneEditor;
@class TelerikUI_TKDataFormNumberEditor_TKDataFormNumberEditorAppearance;
@class TKDataFormNumberEditor;
@class TelerikUI_TKDataFormOptionsEditor_TKDataFormOptionsEditorAppearance;
@class TKDataFormOptionsEditor;
@class TelerikUI_TKDataFormPasswordEditor_TKDataFormPasswordEditorAppearance;
@class TKDataFormPasswordEditor;
@class TelerikUI_TKDataFormPhoneEditor_TKDataFormPhoneEditorAppearance;
@class TKDataFormPhoneEditor;
@class TelerikUI_TKDataFormPickerViewEditor_TKDataFormPickerViewEditorAppearance;
@class TKDataFormPickerViewEditor;
@class TelerikUI_TKDataFormSegmentedEditor_TKDataFormSegmentedEditorAppearance;
@class TKDataFormSegmentedEditor;
@class TelerikUI_TKDataFormSliderEditor_TKDataFormSliderEditorAppearance;
@class TKDataFormSliderEditor;
@class TelerikUI_TKDataFormStepperEditor_TKDataFormStepperEditorAppearance;
@class TKDataFormStepperEditor;
@class TelerikUI_TKDataFormSwitchEditor_TKDataFormSwitchEditorAppearance;
@class TKDataFormSwitchEditor;
@class TelerikUI_TKDataFormTimePickerEditor_TKDataFormTimePickerEditorAppearance;
@class TKDataFormTimePickerEditor;
@class TelerikUI_TKEntityPropertyGroupEditorsView_TKEntityPropertyGroupEditorsViewAppearance;
@class TKEntityPropertyGroupEditorsView;
@class TelerikUI_TKEntityPropertyGroupTitleView_TKEntityPropertyGroupTitleViewAppearance;
@class TKEntityPropertyGroupTitleView;
@class TelerikUI_TKEntityPropertyGroupTitleViewIndicator_TKEntityPropertyGroupTitleViewIndicatorAppearance;
@class TKEntityPropertyGroupTitleViewIndicator;
@class TelerikUI_TKEntityPropertyGroupView_TKEntityPropertyGroupViewAppearance;
@class TKEntityPropertyGroupView;
@class TelerikUI_TKGauge_TKGaugeAppearance;
@class TKGauge;
@class TelerikUI_TKLabel_TKLabelAppearance;
@class TKLabel;
@class TelerikUI_TKLinearGauge_TKLinearGaugeAppearance;
@class TKLinearGauge;
@class TelerikUI_TKListView_TKListViewAppearance;
@class TKListView;
@class TelerikUI_TKListViewCellBackgroundView_TKListViewCellBackgroundViewAppearance;
@class TKListViewCellBackgroundView;
@class TelerikUI_TKListViewFooterCell_TKListViewFooterCellAppearance;
@class TKListViewFooterCell;
@class TelerikUI_TKListViewHeaderCell_TKListViewHeaderCellAppearance;
@class TKListViewHeaderCell;
@class TelerikUI_TKListViewLoadOnDemandCell_TKListViewLoadOnDemandCellAppearance;
@class TKListViewLoadOnDemandCell;
@class TelerikUI_TKListViewLoadOnDemandView_TKListViewLoadOnDemandViewAppearance;
@class TKListViewLoadOnDemandView;
@class TelerikUI_TKListViewPullToRefreshView_TKListViewPullToRefreshViewAppearance;
@class TKListViewPullToRefreshView;
@class TelerikUI_TKModifiedTextField_TKModifiedTextFieldAppearance;
@class TKModifiedTextField;
@class TelerikUI_TKRadialGauge_TKRadialGaugeAppearance;
@class TKRadialGauge;
@class TelerikUI_TKSideDrawer_TKSideDrawerAppearance;
@class TKSideDrawer;
@class TelerikUI_TKSideDrawerHeader_TKSideDrawerHeaderAppearance;
@class TKSideDrawerHeader;
@class TelerikUI_TKSideDrawerTableView_TKSideDrawerTableViewAppearance;
@class TKSideDrawerTableView;
@class TelerikUI_TKSideDrawerTableViewCell_TKSideDrawerTableViewCellAppearance;
@class TKSideDrawerTableViewCell;
@class TelerikUI_TKSideDrawerView_TKSideDrawerViewAppearance;
@class TKSideDrawerView;
@class TelerikUI_TKSlideView_TKSlideViewAppearance;
@class TKSlideView;
@class TelerikUI_TKSuggestionListView_TKSuggestionListViewAppearance;
@class TKSuggestionListView;
@class TelerikUI_TKTextField_TKTextFieldAppearance;
@class TKTextField;
@class TelerikUI_TKViewTransition_TKViewTransitionAppearance;
@class TKViewTransition;
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

@interface DashboardController : UITableViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
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

@interface FacturasController : UIViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
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

@protocol TKCalendarDataSource
	@optional -(NSArray *) calendar:(id)p0 eventsForDate:(NSDate *)p1;
	@optional -(void) calendar:(id)p0 eventsFromDate:(NSDate *)p1 toDate:(NSDate *)p2 withCallback:(id)p3;
@end

@protocol TKCalendarDelegate
	@optional -(BOOL) calendar:(id)p0 shouldSelectDate:(NSDate *)p1;
	@optional -(void) calendar:(id)p0 didSelectDate:(NSDate *)p1;
	@optional -(void) calendar:(id)p0 didDeselectedDate:(NSDate *)p1;
	@optional -(void) calendar:(id)p0 didTapCell:(id)p1;
	@optional -(void) calendar:(id)p0 willNavigateToDate:(NSDate *)p1;
	@optional -(void) calendar:(id)p0 didNavigateToDate:(NSDate *)p1;
	@optional -(void) calendar:(id)p0 didChangedViewModeFrom:(int)p1 to:(int)p2;
	@optional -(id) calendar:(id)p0 viewForCellOfKind:(int)p1;
	@optional -(void) calendar:(id)p0 updateVisualsForCell:(id)p1;
	@optional -(id) calendar:(id)p0 shapeForEvent:(id)p1;
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

@interface ComentariosBodyCell : UITableViewCell {
}
	@property (nonatomic, assign) UIButton * btnImagenComentatio;
	@property (nonatomic, assign) UIButton * btnLikes;
	@property (nonatomic, assign) UIImageView * imgComentarios;
	@property (nonatomic, assign) UIImageView * imgPerfil;
	@property (nonatomic, assign) UILabel * lblComentarios;
	@property (nonatomic, assign) UILabel * lblDetalleComentario;
	@property (nonatomic, assign) UILabel * lblFechaPost;
	@property (nonatomic, assign) UILabel * lblLikes;
	@property (nonatomic, assign) UILabel * lblNombre;
	@property (nonatomic, assign) UILabel * lblOcupacion;
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
	-(UILabel *) lblDetalleComentario;
	-(void) setLblDetalleComentario:(UILabel *)p0;
	-(UILabel *) lblFechaPost;
	-(void) setLblFechaPost:(UILabel *)p0;
	-(UILabel *) lblLikes;
	-(void) setLblLikes:(UILabel *)p0;
	-(UILabel *) lblNombre;
	-(void) setLblNombre:(UILabel *)p0;
	-(UILabel *) lblOcupacion;
	-(void) setLblOcupacion:(UILabel *)p0;
	-(UIView *) vwVistaComentario;
	-(void) setVwVistaComentario:(UIView *)p0;
	-(void) btnComentarPost_TouchUpInside:(UIButton *)p0;
	-(void) btnImagenComentatio_touchUpInside:(UIButton *)p0;
	-(void) btnLikes_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface ComentarPostHeaderCell : UITableViewCell {
}
	@property (nonatomic, assign) UIButton * btnBorrarFoto;
	@property (nonatomic, assign) UIButton * btnFotografia;
	@property (nonatomic, assign) UIButton * btnPublicar;
	@property (nonatomic, assign) UIButton * btnSeleccionarImagen;
	@property (nonatomic, assign) UITextView * txtComentarPost;
	@property (nonatomic, assign) UIView * vwComentarPost;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnBorrarFoto;
	-(void) setBtnBorrarFoto:(UIButton *)p0;
	-(UIButton *) btnFotografia;
	-(void) setBtnFotografia:(UIButton *)p0;
	-(UIButton *) btnPublicar;
	-(void) setBtnPublicar:(UIButton *)p0;
	-(UIButton *) btnSeleccionarImagen;
	-(void) setBtnSeleccionarImagen:(UIButton *)p0;
	-(UITextView *) txtComentarPost;
	-(void) setTxtComentarPost:(UITextView *)p0;
	-(UIView *) vwComentarPost;
	-(void) setVwComentarPost:(UIView *)p0;
	-(void) btnBorrarFoto_TouchUpInside:(UIButton *)p0;
	-(void) btnComentar_TouchUpInside:(UIButton *)p0;
	-(void) btnFotografia_TouchUpInside:(UIButton *)p0;
	-(void) btnSleccionarImagen_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface ComentarioViewCell : UITableViewCell {
}
	@property (nonatomic, assign) UIButton * btnImagenComentario;
	@property (nonatomic, assign) UIButton * btnLikes;
	@property (nonatomic, assign) UIImageView * imgPerfil;
	@property (nonatomic, assign) UILabel * lblContenido;
	@property (nonatomic, assign) UILabel * lblFechaPost;
	@property (nonatomic, assign) UILabel * lblLikes;
	@property (nonatomic, assign) UILabel * lblNombre;
	@property (nonatomic, assign) UILabel * lblPuesto;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnImagenComentario;
	-(void) setBtnImagenComentario:(UIButton *)p0;
	-(UIButton *) btnLikes;
	-(void) setBtnLikes:(UIButton *)p0;
	-(UIImageView *) imgPerfil;
	-(void) setImgPerfil:(UIImageView *)p0;
	-(UILabel *) lblContenido;
	-(void) setLblContenido:(UILabel *)p0;
	-(UILabel *) lblFechaPost;
	-(void) setLblFechaPost:(UILabel *)p0;
	-(UILabel *) lblLikes;
	-(void) setLblLikes:(UILabel *)p0;
	-(UILabel *) lblNombre;
	-(void) setLblNombre:(UILabel *)p0;
	-(UILabel *) lblPuesto;
	-(void) setLblPuesto:(UILabel *)p0;
	-(void) btnImagenComentario_TouchUpInside:(UIButton *)p0;
	-(void) btnLikes_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface NoComentariosViewCell : UITableViewCell {
}
	@property (nonatomic, assign) UILabel * lblNoComentariosInfo;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UILabel *) lblNoComentariosInfo;
	-(void) setLblNoComentariosInfo:(UILabel *)p0;
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
	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1;
	-(void) btnToScanQr_TouchUpInside:(UIBarButtonItem *)p0;
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

@interface TKView : UIView {
}
	-(NSArray *) drawables;
	-(void) setDrawables:(NSArray *)p0;
	-(id) fill;
	-(void) setFill:(id)p0;
	-(id) layout;
	-(void) setLayout:(id)p0;
	-(id) shape;
	-(void) setShape:(id)p0;
	-(id) stroke;
	-(void) setStroke:(id)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithFrame:(CGRect)p0;
@end

@interface TKCalendar : TKView {
}
	-(void) clearSelection;
	-(NSArray *) eventsForDate:(NSDate *)p0;
	-(void) navigateBack:(BOOL)p0;
	-(void) navigateForward:(BOOL)p0;
	-(void) navigateToDate:(NSDate *)p0 animated:(BOOL)p1;
	-(void) reloadData;
	-(void) update:(BOOL)p0;
	-(BOOL) allowPinchZoom;
	-(void) setAllowPinchZoom:(BOOL)p0;
	-(NSCalendar *) calendar;
	-(void) setCalendar:(NSCalendar *)p0;
	-(NSDate *) displayedDate;
	-(NSLocale *) locale;
	-(void) setLocale:(NSLocale *)p0;
	-(NSDate *) maxDate;
	-(void) setMaxDate:(NSDate *)p0;
	-(NSDate *) minDate;
	-(void) setMinDate:(NSDate *)p0;
	-(NSObject *) presenter;
	-(NSDate *) selectedDate;
	-(void) setSelectedDate:(NSDate *)p0;
	-(NSArray *) selectedDates;
	-(void) setSelectedDates:(NSArray *)p0;
	-(id) selectedDatesRange;
	-(void) setSelectedDatesRange:(id)p0;
	-(int) selectionMode;
	-(void) setSelectionMode:(int)p0;
	-(id) theme;
	-(void) setTheme:(id)p0;
	-(int) viewMode;
	-(void) setViewMode:(int)p0;
	-(NSObject *) dataSource;
	-(void) setDataSource:(NSObject *)p0;
	-(NSObject *) delegate;
	-(void) setDelegate:(NSObject *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithFrame:(CGRect)p0;
@end

@interface WorklabsMx_iOS_Helpers_Calendario : TKCalendar {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
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

@interface ReservaController : UIViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
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

@interface ComentarPostTableViewController : UITableViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(void) viewWillDisappear:(BOOL)p0;
	-(UIView *) tableView:(UITableView *)p0 viewForHeaderInSection:(NSInteger)p1;
	-(CGFloat) tableView:(UITableView *)p0 heightForHeaderInSection:(NSInteger)p1;
	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1;
	-(void) imagePickerController:(UIImagePickerController *)p0 didFinishPickingImage:(UIImage *)p1 editingInfo:(NSDictionary *)p2;
	-(void) imagePickerControllerDidCancel:(UIImagePickerController *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface SeccionComentariosTableViewController : UITableViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1;
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
	-(void) btnAtras:(UIBarButtonItem *)p0;
	-(void) viewDidLoad;
	-(void) viewWillAppear:(BOOL)p0;
	-(UIView *) tableView:(UITableView *)p0 viewForHeaderInSection:(NSInteger)p1;
	-(CGFloat) tableView:(UITableView *)p0 heightForHeaderInSection:(NSInteger)p1;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(void) tableView:(UITableView *)p0 didSelectRowAtIndexPath:(NSIndexPath *)p1;
	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1;
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
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface UIKit_UILabel_UILabelAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface UIKit_UIControl_UIControlAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface UIKit_UIButton_UIButtonAppearance : UIKit_UIControl_UIControlAppearance {
}
@end

@interface UIKit_UIScrollView_UIScrollViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface UIKit_UICollectionView_UICollectionViewAppearance : UIKit_UIScrollView_UIScrollViewAppearance {
}
@end

@interface UIKit_UITableView_UITableViewAppearance : UIKit_UIScrollView_UIScrollViewAppearance {
}
@end

@interface UIKit_UITableViewCell_UITableViewCellAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface UIKit_UITextField_UITextFieldAppearance : UIKit_UIControl_UIControlAppearance {
}
@end

@interface UIKit_UICollectionReusableView_UICollectionReusableViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface UIKit_UICollectionViewCell_UICollectionViewCellAppearance : UIKit_UICollectionReusableView_UICollectionReusableViewAppearance {
}
@end

@interface TKAlert : NSObject {
}
	-(id) actionAtIndex:(NSInteger)p0;
	-(void) addAction:(id)p0;
	-(id) addActionWithTitle:(NSString *)p0 handler:(id)p1;
	-(void) dismiss:(BOOL)p0;
	-(void) removeAction:(id)p0;
	-(void) removeActionAtIndex:(NSInteger)p0;
	-(void) shake;
	-(void) show:(BOOL)p0;
	-(NSArray *) actions;
	-(long long) actionsLayout;
	-(void) setActionsLayout:(long long)p0;
	-(id) alertView;
	-(BOOL) allowParallaxEffect;
	-(void) setAllowParallaxEffect:(BOOL)p0;
	-(CGFloat) animationDuration;
	-(void) setAnimationDuration:(CGFloat)p0;
	-(NSAttributedString *) attributedMessage;
	-(void) setAttributedMessage:(NSAttributedString *)p0;
	-(NSAttributedString *) attributedTitle;
	-(void) setAttributedTitle:(NSAttributedString *)p0;
	-(id) buttonsView;
	-(id) contentView;
	-(CGRect) customFrame;
	-(void) setCustomFrame:(CGRect)p0;
	-(long long) dismissMode;
	-(void) setDismissMode:(long long)p0;
	-(double) dismissTimeout;
	-(void) setDismissTimeout:(double)p0;
	-(id) headerView;
	-(NSString *) message;
	-(void) setMessage:(NSString *)p0;
	-(id) style;
	-(void) setStyle:(id)p0;
	-(long long) swipeDismissDirection;
	-(void) setSwipeDismissDirection:(long long)p0;
	-(UIColor *) tintColor;
	-(void) setTintColor:(UIColor *)p0;
	-(NSString *) title;
	-(void) setTitle:(NSString *)p0;
	-(BOOL) isVisible;
	-(void) setVisible:(BOOL)p0;
	-(NSObject *) delegate;
	-(void) setDelegate:(NSObject *)p0;
	-(id) init;
	-(id) initWithTitle:(NSString *)p0 message:(NSString *)p1 delegate:(NSObject *)p2 cancelActionTitle:(NSString *)p3 otherActionTitles:(NSObject *)p4, ...;
@end

@interface TKAlertAction : NSObject {
}
	-(UIColor *) backgroundColor;
	-(void) setBackgroundColor:(UIColor *)p0;
	-(CGFloat) cornerRadius;
	-(void) setCornerRadius:(CGFloat)p0;
	-(UIFont *) font;
	-(void) setFont:(UIFont *)p0;
	-(id) handler;
	-(void) setHandler:(id)p0;
	-(NSInteger) tag;
	-(void) setTag:(NSInteger)p0;
	-(NSString *) title;
	-(void) setTitle:(NSString *)p0;
	-(UIColor *) titleColor;
	-(void) setTitleColor:(UIColor *)p0;
	-(id) init;
	-(id) initWithTitle:(NSString *)p0 handler:(id)p1;
@end

@protocol TKAlertDelegate
	@optional -(UIButton *) alert:(id)p0 buttonForAction:(id)p1;
	@optional -(void) alert:(id)p0 didDismissWithAction:(id)p1;
	@optional -(void) alertWillShow:(id)p0;
	@optional -(void) alertDidShow:(id)p0;
	@optional -(void) alertWillDismiss:(id)p0;
	@optional -(void) alertDidDismiss:(id)p0;
@end

@interface TKStyleNode : NSObject {
}
	-(void) beginThemeBlock;
	-(BOOL) canSetValue:(NSInteger)p0;
	-(void) endThemeBlock;
	-(void) resetLocalValues;
	-(BOOL) isThemeBlock;
	-(id) styleID;
	-(void) setStyleID:(id)p0;
	-(id) init;
@end

@interface TKAlertStyle : TKStyleNode {
}
	-(UIColor *) backgroundColor;
	-(void) setBackgroundColor:(UIColor *)p0;
	-(CGFloat) backgroundDimAlpha;
	-(void) setBackgroundDimAlpha:(CGFloat)p0;
	-(long long) backgroundStyle;
	-(void) setBackgroundStyle:(long long)p0;
	-(UIColor *) backgroundTintColor;
	-(void) setBackgroundTintColor:(UIColor *)p0;
	-(CGFloat) buttonHeight;
	-(void) setButtonHeight:(CGFloat)p0;
	-(CGFloat) buttonSpacing;
	-(void) setButtonSpacing:(CGFloat)p0;
	-(UIEdgeInsets) buttonsInset;
	-(void) setButtonsInset:(UIEdgeInsets)p0;
	-(BOOL) centerFrame;
	-(void) setCenterFrame:(BOOL)p0;
	-(CGFloat) contentHeight;
	-(void) setContentHeight:(CGFloat)p0;
	-(UIEdgeInsets) contentInset;
	-(void) setContentInset:(UIEdgeInsets)p0;
	-(CGFloat) contentSeparatorWidth;
	-(void) setContentSeparatorWidth:(CGFloat)p0;
	-(CGFloat) cornerRadius;
	-(void) setCornerRadius:(CGFloat)p0;
	-(long long) dismissAnimation;
	-(void) setDismissAnimation:(long long)p0;
	-(CGFloat) headerHeight;
	-(void) setHeaderHeight:(CGFloat)p0;
	-(CGFloat) maxWidth;
	-(void) setMaxWidth:(CGFloat)p0;
	-(UIColor *) messageColor;
	-(void) setMessageColor:(UIColor *)p0;
	-(long long) showAnimation;
	-(void) setShowAnimation:(long long)p0;
	-(UIColor *) titleColor;
	-(void) setTitleColor:(UIColor *)p0;
	-(CGFloat) titleSeparatorWidth;
	-(void) setTitleSeparatorWidth:(CGFloat)p0;
	-(id) init;
@end

@interface TKAutoCompleteController : UIViewController {
}
	-(id) autocomplete;
	-(void) setAutocomplete:(id)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@protocol TKAutoCompleteDataSource
	@optional -(NSArray *) autoComplete:(id)p0 completionForPrefix:(NSString *)p1;
	@optional -(void) autoComplete:(id)p0 completionsForString:(NSString *)p1;
@end

@protocol TKAutoCompleteDelegate
	@optional -(void) autoComplete:(id)p0 updateTokenView:(id)p1;
	@optional -(void) autoComplete:(id)p0 didAutoComplete:(id)p1;
	@optional -(id) autoComplete:(id)p0 viewForToken:(id)p1;
	@optional -(void) autoComplete:(id)p0 willShowSuggestionList:(NSArray *)p1;
	@optional -(void) autoComplete:(id)p0 suggestionListUpdated:(NSArray *)p1;
	@optional -(void) autoComplete:(id)p0 shouldAddToken:(id)p1;
	@optional -(void) autoComplete:(id)p0 didAddToken:(id)p1;
	@optional -(BOOL) autoComplete:(id)p0 shouldRemoveToken:(id)p1;
	@optional -(void) autoComplete:(id)p0 didRemoveToken:(id)p1;
	@optional -(void) autoComplete:(id)p0 didSelectToken:(id)p1;
	@optional -(void) autoCompleteDidStartEditing:(id)p0;
@end

@protocol TKAutoCompleteSuggestViewDelegate
	@optional -(void) populateWithItems:(NSArray *)p0;
	@optional -(void) reloadSuggestions;
	@optional -(id) selectedItem;
	@optional -(BOOL) shouldAlwaysHideSuggestionView;
	@optional -(void) show;
	@optional -(void) hide;
@end

@interface TKAutoCompleteToken : NSObject {
}
	-(NSAttributedString *) attributedText;
	-(void) setAttributedText:(NSAttributedString *)p0;
	-(UIImage *) image;
	-(void) setImage:(UIImage *)p0;
	-(NSString *) text;
	-(void) setText:(NSString *)p0;
	-(id) init;
	-(id) initWithText:(NSString *)p0;
@end

@interface TKShape : NSObject {
}
	-(void) drawInContext:(id)p0 withCenter:(CGPoint)p1 drawings:(NSArray *)p2;
	-(void) drawInContext:(id)p0 withCenter:(CGPoint)p1 drawings:(NSArray *)p2 scale:(CGFloat)p3;
	-(UIEdgeInsets) insets;
	-(CGSize) size;
	-(void) setSize:(CGSize)p0;
	-(id) init;
	-(id) initWithSize:(CGSize)p0;
@end

@interface TKBalloonShape : TKShape {
}
	-(CGFloat) arrowOffset;
	-(void) setArrowOffset:(CGFloat)p0;
	-(int) arrowPosition;
	-(void) setArrowPosition:(int)p0;
	-(CGSize) arrowSize;
	-(void) setArrowSize:(CGSize)p0;
	-(CGFloat) cornerRadius;
	-(void) setCornerRadius:(CGFloat)p0;
	-(BOOL) useStrictArrowPosition;
	-(void) setUseStrictArrowPosition:(BOOL)p0;
	-(id) init;
	-(id) initWithArrowPosition:(int)p0 size:(CGSize)p1;
@end

@interface TKCalendarCellStyle : TKStyleNode {
}
	-(UIColor *) backgroundColor;
	-(void) setBackgroundColor:(UIColor *)p0;
	-(UIColor *) bottomBorderColor;
	-(void) setBottomBorderColor:(UIColor *)p0;
	-(CGFloat) bottomBorderWidth;
	-(void) setBottomBorderWidth:(CGFloat)p0;
	-(UIColor *) leftBorderColor;
	-(void) setLeftBorderColor:(UIColor *)p0;
	-(CGFloat) leftBorderWidth;
	-(void) setLeftBorderWidth:(CGFloat)p0;
	-(UIColor *) rightBorderColor;
	-(void) setRightBorderColor:(UIColor *)p0;
	-(CGFloat) rightBorderWidth;
	-(void) setRightBorderWidth:(CGFloat)p0;
	-(id) shape;
	-(void) setShape:(id)p0;
	-(id) shapeFill;
	-(void) setShapeFill:(id)p0;
	-(id) shapeStroke;
	-(void) setShapeStroke:(id)p0;
	-(int) textAlignment;
	-(void) setTextAlignment:(int)p0;
	-(UIColor *) textColor;
	-(void) setTextColor:(UIColor *)p0;
	-(UIFont *) textFont;
	-(void) setTextFont:(UIFont *)p0;
	-(UIEdgeInsets) textInsets;
	-(void) setTextInsets:(UIEdgeInsets)p0;
	-(UIColor *) topBorderColor;
	-(void) setTopBorderColor:(UIColor *)p0;
	-(CGFloat) topBorderWidth;
	-(void) setTopBorderWidth:(CGFloat)p0;
	-(id) init;
@end

@interface TKCalendarDayCellStyle : TKCalendarCellStyle {
}
	-(UIColor *) defaultSelectionColor;
	-(void) setDefaultSelectionColor:(UIColor *)p0;
	-(BOOL) displayEventsAsText;
	-(void) setDisplayEventsAsText:(BOOL)p0;
	-(int) eventAlignment;
	-(void) setEventAlignment:(int)p0;
	-(UIFont *) eventFont;
	-(void) setEventFont:(UIFont *)p0;
	-(UIEdgeInsets) eventInsets;
	-(void) setEventInsets:(UIEdgeInsets)p0;
	-(int) eventOrientation;
	-(void) setEventOrientation:(int)p0;
	-(id) eventShape;
	-(void) setEventShape:(id)p0;
	-(float) eventSpacing;
	-(void) setEventSpacing:(float)p0;
	-(UIColor *) eventTextColor;
	-(void) setEventTextColor:(UIColor *)p0;
	-(NSInteger) maxEventsCount;
	-(void) setMaxEventsCount:(NSInteger)p0;
	-(BOOL) stretchEvents;
	-(void) setStretchEvents:(BOOL)p0;
	-(BOOL) useDefaultSelectionStyle;
	-(void) setUseDefaultSelectionStyle:(BOOL)p0;
	-(BOOL) wrapEventText;
	-(void) setWrapEventText:(BOOL)p0;
	-(id) init;
@end

@interface TKCalendarDayViewAllDayEventCellStyle : TKStyleNode {
}
	-(UIColor *) backgroundColor;
	-(void) setBackgroundColor:(UIColor *)p0;
	-(UIColor *) textColor;
	-(void) setTextColor:(UIColor *)p0;
	-(UIFont *) textFont;
	-(void) setTextFont:(UIFont *)p0;
	-(UIEdgeInsets) textInsets;
	-(void) setTextInsets:(UIEdgeInsets)p0;
	-(id) init;
@end

@interface TKCalendarDayViewAllDayEventsViewStyle : TKStyleNode {
}
	-(CGFloat) eventHeight;
	-(void) setEventHeight:(CGFloat)p0;
	-(NSInteger) eventsPerRow;
	-(void) setEventsPerRow:(NSInteger)p0;
	-(UIEdgeInsets) eventsViewInsets;
	-(void) setEventsViewInsets:(UIEdgeInsets)p0;
	-(CGFloat) itemSpacing;
	-(void) setItemSpacing:(CGFloat)p0;
	-(UIEdgeInsets) labelInsets;
	-(void) setLabelInsets:(UIEdgeInsets)p0;
	-(CGFloat) labelWidth;
	-(void) setLabelWidth:(CGFloat)p0;
	-(CGFloat) lineSpacing;
	-(void) setLineSpacing:(CGFloat)p0;
	-(CGFloat) maxVisibleLines;
	-(void) setMaxVisibleLines:(CGFloat)p0;
	-(id) init;
@end

@interface TKCalendarDayViewEventCellStyle : TKStyleNode {
}
	-(CGFloat) decorationWidth;
	-(void) setDecorationWidth:(CGFloat)p0;
	-(UIFont *) detailFont;
	-(void) setDetailFont:(UIFont *)p0;
	-(UIEdgeInsets) detailInsets;
	-(void) setDetailInsets:(UIEdgeInsets)p0;
	-(NSInteger) detailNumberOfLines;
	-(void) setDetailNumberOfLines:(NSInteger)p0;
	-(UIEdgeInsets) insets;
	-(void) setInsets:(UIEdgeInsets)p0;
	-(UIColor *) textColor;
	-(void) setTextColor:(UIColor *)p0;
	-(UIFont *) titleFont;
	-(void) setTitleFont:(UIFont *)p0;
	-(UIEdgeInsets) titleInsets;
	-(void) setTitleInsets:(UIEdgeInsets)p0;
	-(NSInteger) titleNumberOfLines;
	-(void) setTitleNumberOfLines:(NSInteger)p0;
	-(CGFloat) transparency;
	-(void) setTransparency:(CGFloat)p0;
	-(id) init;
@end

@interface TKCalendarDayViewEventsLayout : UICollectionViewLayout {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TKCalendarDayViewEventsViewStyle : TKStyleNode {
}
	-(CGFloat) bottomOffset;
	-(void) setBottomOffset:(CGFloat)p0;
	-(CGFloat) eventsLeadingOffset;
	-(void) setEventsLeadingOffset:(CGFloat)p0;
	-(CGFloat) eventsSpacing;
	-(void) setEventsSpacing:(CGFloat)p0;
	-(CGFloat) eventsTrailingOffset;
	-(void) setEventsTrailingOffset:(CGFloat)p0;
	-(NSDateFormatter *) labelFormatter;
	-(void) setLabelFormatter:(NSDateFormatter *)p0;
	-(CGFloat) labelOffset;
	-(void) setLabelOffset:(CGFloat)p0;
	-(UIColor *) labelTextColor;
	-(void) setLabelTextColor:(UIColor *)p0;
	-(CGFloat) labelTextSize;
	-(void) setLabelTextSize:(CGFloat)p0;
	-(CGFloat) minEventHeight;
	-(void) setMinEventHeight:(CGFloat)p0;
	-(UIColor *) separatorColor;
	-(void) setSeparatorColor:(UIColor *)p0;
	-(CGFloat) separatorLeadingOffset;
	-(void) setSeparatorLeadingOffset:(CGFloat)p0;
	-(CGFloat) separatorSpacing;
	-(void) setSeparatorSpacing:(CGFloat)p0;
	-(CGFloat) separatorTrailingOffset;
	-(void) setSeparatorTrailingOffset:(CGFloat)p0;
	-(CGFloat) separatorWidth;
	-(void) setSeparatorWidth:(CGFloat)p0;
	-(CGFloat) topOffset;
	-(void) setTopOffset:(CGFloat)p0;
	-(id) init;
@end

@interface TKCalendarDayViewPresenterStyle : TKStyleNode {
}
	-(UIColor *) backgroundColor;
	-(void) setBackgroundColor:(UIColor *)p0;
	-(CGFloat) columnSpacing;
	-(void) setColumnSpacing:(CGFloat)p0;
	-(CGFloat) dayCellHeight;
	-(void) setDayCellHeight:(CGFloat)p0;
	-(CGFloat) dayNameCellHeight;
	-(void) setDayNameCellHeight:(CGFloat)p0;
	-(int) dayNameTextEffect;
	-(void) setDayNameTextEffect:(int)p0;
	-(CGFloat) titleCellHeight;
	-(void) setTitleCellHeight:(CGFloat)p0;
	-(CGFloat) weekNumberCellWidth;
	-(void) setWeekNumberCellWidth:(CGFloat)p0;
	-(id) init;
@end

@interface TKCalendarDayViewTimeLineLayoutAttributes : UICollectionViewLayoutAttributes {
}
	-(id) owner;
	-(id) init;
@end

@protocol TKCalendarEventProtocol
	@optional @property (nonatomic, retain) NSDate * startDate;
	@optional @property (nonatomic, retain) NSDate * endDate;
	@optional @property (nonatomic, retain) NSString * title;
	@optional @property (nonatomic, retain) NSString * detail;
	@optional @property (nonatomic, retain) UIColor * eventColor;
	@optional @property (nonatomic, assign, getter = isAllDay) BOOL allDay;
@end

@interface TKCalendarEvent : NSObject {
}
	-(BOOL) isAllDay;
	-(void) setAllDay:(BOOL)p0;
	-(NSString *) detail;
	-(void) setDetail:(NSString *)p0;
	-(NSDate *) endDate;
	-(void) setEndDate:(NSDate *)p0;
	-(UIColor *) eventColor;
	-(void) setEventColor:(UIColor *)p0;
	-(NSString *) location;
	-(void) setLocation:(NSString *)p0;
	-(NSDate *) startDate;
	-(void) setStartDate:(NSDate *)p0;
	-(NSString *) title;
	-(void) setTitle:(NSString *)p0;
	-(id) init;
@end

@interface TKCalendarEventKitDataSource : NSObject {
}
	-(id) createCalendarEvent:(EKEvent *)p0 inCalendar:(EKCalendar *)p1;
	-(NSArray *) eventsForCalendar:(EKCalendar *)p0 fromDate:(NSDate *)p1 toDate:(NSDate *)p2;
	-(NSArray *) calendar:(id)p0 eventsForDate:(NSDate *)p1;
	-(void) calendar:(id)p0 eventsFromDate:(NSDate *)p1 toDate:(NSDate *)p2 withCallback:(id)p3;
	-(NSArray *) calendars;
	-(NSObject *) delegate;
	-(void) setDelegate:(NSObject *)p0;
	-(id) init;
@end

@protocol TKCalendarEventKitDataSourceDelegate
	@optional -(BOOL) shouldImportEventsFromCalendar:(EKCalendar *)p0;
	@optional -(BOOL) shouldImportEvent:(EKEvent *)p0;
@end

@protocol TKCalendarPresenter
	@optional -(void) update:(BOOL)p0;
	@optional -(void) updateState:(NSDate *)p0;
	@optional -(BOOL) navigateForward:(BOOL)p0;
	@optional -(BOOL) navigateBack:(BOOL)p0;
	@optional -(void) navigateToDate:(NSDate *)p0 animated:(BOOL)p1;
	@optional -(NSDate *) dateFromPoint:(CGPoint)p0;
@end

@interface TKCalendarFlowPresenter : NSObject {
}
	-(UICollectionView *) collectionView;
	-(id) init;
@end

@interface TKCalendarInlineViewTableViewCellStyle : TKStyleNode {
}
	-(UIColor *) backgroundColor;
	-(void) setBackgroundColor:(UIColor *)p0;
	-(UIColor *) eventColor;
	-(void) setEventColor:(UIColor *)p0;
	-(UIFont *) eventFont;
	-(void) setEventFont:(UIFont *)p0;
	-(UIColor *) separatorColor;
	-(void) setSeparatorColor:(UIColor *)p0;
	-(CGSize) shapeSize;
	-(void) setShapeSize:(CGSize)p0;
	-(UIColor *) timeColor;
	-(void) setTimeColor:(UIColor *)p0;
	-(UIFont *) timeFont;
	-(void) setTimeFont:(UIFont *)p0;
	-(id) init;
@end

@interface TKTheme : NSObject {
}
	-(void) addStyleGroupWithClass:(Class)p0 settings:(NSDictionary *)p1;
	-(void) addStyleGroupWithClass:(Class)p0 state:(NSInteger)p1 settings:(NSDictionary *)p2;
	-(void) removeAllStyleGroups;
	-(void) removeStyleGroup:(id)p0;
	-(id) stylesForClass:(Class)p0;
	-(void) addStyleGroup:(id)p0;
	-(id) init;
@end

@interface TKCalendarIPadTheme : TKTheme {
}
	-(id) init;
@end

@protocol TKCalendarPresenterDelegate
	@optional -(void) presenter:(id)p0 beginTransition:(id)p1;
	@optional -(void) presenter:(id)p0 finishTransition:(id)p1 isCanceled:(BOOL)p2;
@end

@protocol TKCalendarMonthPresenterDelegate
	@optional -(void) monthPresenter:(id)p0 inlineEventsViewDidShowForCell:(id)p1;
	@optional -(void) monthPresenter:(id)p0 inlineEventsViewDidHideForCell:(id)p1;
	@optional -(void) monthPresenter:(id)p0 inlineEventSelected:(id)p1;
@end

@interface TKCalendarMonthPresenterStyle : TKStyleNode {
}
	-(UIColor *) backgroundColor;
	-(void) setBackgroundColor:(UIColor *)p0;
	-(CGFloat) columnSpacing;
	-(void) setColumnSpacing:(CGFloat)p0;
	-(CGFloat) dayNameCellHeight;
	-(void) setDayNameCellHeight:(CGFloat)p0;
	-(int) dayNameTextEffect;
	-(void) setDayNameTextEffect:(int)p0;
	-(int) monthNameTextEffect;
	-(void) setMonthNameTextEffect:(int)p0;
	-(UIColor *) popoverColor;
	-(void) setPopoverColor:(UIColor *)p0;
	-(CGFloat) rowSpacing;
	-(void) setRowSpacing:(CGFloat)p0;
	-(CGFloat) titleCellHeight;
	-(void) setTitleCellHeight:(CGFloat)p0;
	-(CGFloat) weekNumberCellWidth;
	-(void) setWeekNumberCellWidth:(CGFloat)p0;
	-(id) init;
@end

@interface TKCalendarMonthViewController : UIViewController {
}
	-(id) contentView;
	-(UIBarButtonItem *) todayButton;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TKCalendarYearPresenterStyle : TKStyleNode {
}
	-(UIFont *) dayFont;
	-(void) setDayFont:(UIFont *)p0;
	-(UIFont *) dayNameFont;
	-(void) setDayNameFont:(UIFont *)p0;
	-(UIColor *) dayNameTextColor;
	-(void) setDayNameTextColor:(UIColor *)p0;
	-(int) dayNameTextEffect;
	-(void) setDayNameTextEffect:(int)p0;
	-(UIColor *) dayTextColor;
	-(void) setDayTextColor:(UIColor *)p0;
	-(UIFont *) monthNameFont;
	-(void) setMonthNameFont:(UIFont *)p0;
	-(NSInteger) monthNameTextAlignment;
	-(void) setMonthNameTextAlignment:(NSInteger)p0;
	-(UIColor *) monthNameTextColor;
	-(void) setMonthNameTextColor:(UIColor *)p0;
	-(int) monthNameTextEffect;
	-(void) setMonthNameTextEffect:(int)p0;
	-(NSInteger) monthsPerPage;
	-(void) setMonthsPerPage:(NSInteger)p0;
	-(id) todayShape;
	-(void) setTodayShape:(id)p0;
	-(id) todayShapeFill;
	-(void) setTodayShapeFill:(id)p0;
	-(id) todayShapeStroke;
	-(void) setTodayShapeStroke:(id)p0;
	-(UIColor *) todayTextColor;
	-(void) setTodayTextColor:(UIColor *)p0;
	-(UIColor *) weekendTextColor;
	-(void) setWeekendTextColor:(UIColor *)p0;
	-(id) init;
@end

@interface TKCalendarYearViewController : UIViewController {
}
	-(void) calendar:(id)p0 didChangedViewModeFrom:(int)p1 to:(int)p2;
	-(void) calendar:(id)p0 didDeselectedDate:(NSDate *)p1;
	-(void) calendar:(id)p0 didNavigateToDate:(NSDate *)p1;
	-(void) calendar:(id)p0 didSelectDate:(NSDate *)p1;
	-(void) calendar:(id)p0 didTapCell:(id)p1;
	-(id) calendar:(id)p0 shapeForEvent:(id)p1;
	-(BOOL) calendar:(id)p0 shouldSelectDate:(NSDate *)p1;
	-(void) calendar:(id)p0 updateVisualsForCell:(id)p1;
	-(id) calendar:(id)p0 viewForCellOfKind:(int)p1;
	-(void) calendar:(id)p0 willNavigateToDate:(NSDate *)p1;
	-(id) contentView;
	-(id) delegate;
	-(void) setDelegate:(id)p0;
	-(CGRect) selectedItemRect;
	-(UIBarButtonItem *) todayButton;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@protocol TKCalendarYearViewControllerDelegate
	@optional -(void) navigatedToMonthViewController:(id)p0;
@end

@interface TKChartSeries : NSObject {
}
	-(id) dataPointAtIndex:(NSUInteger)p0;
	-(BOOL) pointIsSelected:(NSInteger)p0;
	-(void) prepareForReuse;
	-(id) renderForChart:(id)p0;
	-(BOOL) hidden;
	-(void) setHidden:(BOOL)p0;
	-(NSUInteger) index;
	-(BOOL) isSelected;
	-(NSArray *) items;
	-(NSString *) reuseIdentifier;
	-(int) selection;
	-(void) setSelection:(int)p0;
	-(id) stackInfo;
	-(void) setStackInfo:(id)p0;
	-(id) style;
	-(NSInteger) tag;
	-(void) setTag:(NSInteger)p0;
	-(NSString *) title;
	-(void) setTitle:(NSString *)p0;
	-(BOOL) visibleInLegend;
	-(void) setVisibleInLegend:(BOOL)p0;
	-(NSArray *) visiblePoints;
	-(id) xAxis;
	-(void) setXAxis:(id)p0;
	-(id) yAxis;
	-(void) setYAxis:(id)p0;
	-(id) init;
	-(id) initWithItems:(NSArray *)p0;
	-(id) initWithItems:(NSArray *)p0 reuseIdentifier:(NSString *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1 reuseIdentifier:(NSString *)p2;
	-(id) initWithItems:(NSArray *)p0 xValueKey:(NSString *)p1 yValueKey:(NSString *)p2;
@end

@interface TKChartFinancialIndicator : TKChartSeries {
}
	-(CGFloat) marginForHitDetection;
	-(void) setMarginForHitDetection:(CGFloat)p0;
	-(id) series;
	-(void) setSeries:(id)p0;
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartSignalLineIndicator : TKChartFinancialIndicator {
}
	-(BOOL) isSignalState;
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartMACDIndicator : TKChartSignalLineIndicator {
}
	-(NSUInteger) longPeriod;
	-(void) setLongPeriod:(NSUInteger)p0;
	-(NSUInteger) shortPeriod;
	-(void) setShortPeriod:(NSUInteger)p0;
	-(NSUInteger) signalPeriod;
	-(void) setSignalPeriod:(NSUInteger)p0;
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartAbsoluteVolumeOscillator : TKChartMACDIndicator {
}
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartAccumulationDistributionLine : TKChartFinancialIndicator {
}
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartAdaptiveMovingAverageIndicator : TKChartFinancialIndicator {
}
	-(NSUInteger) fastPeriod;
	-(void) setFastPeriod:(NSUInteger)p0;
	-(NSUInteger) period;
	-(void) setPeriod:(NSUInteger)p0;
	-(NSUInteger) slowPerod;
	-(void) setSlowPerod:(NSUInteger)p0;
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartAnnotation : NSObject {
}
	-(void) annotationWasAddedToChart:(id)p0 withLayer:(CALayer *)p1;
	-(void) annotationWillBeRemovedFromChart:(id)p0;
	-(void) drawInContext:(id)p0;
	-(void) layoutInRect:(CGRect)p0 forChart:(id)p1 inLayer:(CALayer *)p2;
	-(float) locationOfValue:(NSObject *)p0 withAxis:(id)p1 inBounds:(CGRect)p2;
	-(BOOL) hidden;
	-(void) setHidden:(BOOL)p0;
	-(int) zPosition;
	-(void) setZPosition:(int)p0;
	-(id) init;
@end

@interface TKChartAnnotationStyle : TKStyleNode {
}
	-(id) init;
@end

@interface TKChartLineSeries : TKChartSeries {
}
	-(BOOL) displayNilValuesAsGaps;
	-(void) setDisplayNilValuesAsGaps:(BOOL)p0;
	-(CGFloat) marginForHitDetection;
	-(void) setMarginForHitDetection:(CGFloat)p0;
	-(id) init;
	-(id) initWithItems:(NSArray *)p0;
	-(id) initWithItems:(NSArray *)p0 reuseIdentifier:(NSString *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1 reuseIdentifier:(NSString *)p2;
	-(id) initWithItems:(NSArray *)p0 xValueKey:(NSString *)p1 yValueKey:(NSString *)p2;
@end

@interface TKChartAreaSeries : TKChartLineSeries {
}
	-(id) init;
	-(id) initWithItems:(NSArray *)p0;
	-(id) initWithItems:(NSArray *)p0 reuseIdentifier:(NSString *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1 reuseIdentifier:(NSString *)p2;
	-(id) initWithItems:(NSArray *)p0 xValueKey:(NSString *)p1 yValueKey:(NSString *)p2;
@end

@interface TKChartTrueRangeIndicator : TKChartFinancialIndicator {
}
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartAverageTrueRangeIndicator : TKChartTrueRangeIndicator {
}
	-(NSUInteger) period;
	-(void) setPeriod:(NSUInteger)p0;
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartAxis : NSObject {
}
	-(NSString *) formatValue:(NSObject *)p0;
	-(double) numericValue:(NSObject *)p0;
	-(void) panToDataPoint:(id)p0;
	-(id) renderForChart:(id)p0;
	-(NSObject *) tickValue:(NSInteger)p0;
	-(BOOL) allowPan;
	-(void) setAllowPan:(BOOL)p0;
	-(BOOL) allowZoom;
	-(void) setAllowZoom:(BOOL)p0;
	-(NSAttributedString *) attributedTitle;
	-(void) setAttributedTitle:(NSAttributedString *)p0;
	-(NSDictionary *) customLabels;
	-(void) setCustomLabels:(NSDictionary *)p0;
	-(BOOL) isVertical;
	-(NSString *) labelFormat;
	-(void) setLabelFormat:(NSString *)p0;
	-(NSFormatter *) labelFormatter;
	-(void) setLabelFormatter:(NSFormatter *)p0;
	-(NSUInteger) majorTickCount;
	-(double) normalizedPan;
	-(void) setNormalizedPan:(double)p0;
	-(double) pan;
	-(void) setPan:(double)p0;
	-(int) plotMode;
	-(int) position;
	-(void) setPosition:(int)p0;
	-(id) range;
	-(void) setRange:(id)p0;
	-(id) style;
	-(void) setStyle:(id)p0;
	-(NSString *) title;
	-(void) setTitle:(NSString *)p0;
	-(double) zoom;
	-(void) setZoom:(double)p0;
	-(id) init;
	-(id) initWithRange:(id)p0;
	-(id) initWithMinimum:(NSObject *)p0 andMaximum:(NSObject *)p1;
	-(id) initWithMinimum:(NSObject *)p0 andMaximum:(NSObject *)p1 position:(int)p2;
@end

@interface TKChartLabelStyle : TKStyleNode {
}
	-(UIFont *) font;
	-(void) setFont:(UIFont *)p0;
	-(UIColor *) shadowColor;
	-(void) setShadowColor:(UIColor *)p0;
	-(CGSize) shadowOffset;
	-(void) setShadowOffset:(CGSize)p0;
	-(UIColor *) textColor;
	-(void) setTextColor:(UIColor *)p0;
	-(BOOL) textHidden;
	-(void) setTextHidden:(BOOL)p0;
	-(id) init;
@end

@interface TKChartAxisLabelStyle : TKChartLabelStyle {
}
	-(int) firstLabelTextAlignment;
	-(void) setFirstLabelTextAlignment:(int)p0;
	-(UIOffset) firstLabelTextOffset;
	-(void) setFirstLabelTextOffset:(UIOffset)p0;
	-(int) fitMode;
	-(void) setFitMode:(int)p0;
	-(int) maxLabelClippingMode;
	-(void) setMaxLabelClippingMode:(int)p0;
	-(int) minLabelClippingMode;
	-(void) setMinLabelClippingMode:(int)p0;
	-(CGFloat) rotationAngle;
	-(void) setRotationAngle:(CGFloat)p0;
	-(int) textAlignment;
	-(void) setTextAlignment:(int)p0;
	-(UIOffset) textOffset;
	-(void) setTextOffset:(UIOffset)p0;
	-(id) init;
@end

@interface TKChartAxisTickStyle : TKStyleNode {
}
	-(id) ticksFill;
	-(void) setTicksFill:(id)p0;
	-(BOOL) ticksHidden;
	-(void) setTicksHidden:(BOOL)p0;
	-(CGFloat) ticksLength;
	-(void) setTicksLength:(CGFloat)p0;
	-(CGFloat) ticksOffset;
	-(void) setTicksOffset:(CGFloat)p0;
	-(id) ticksStroke;
	-(void) setTicksStroke:(id)p0;
	-(CGFloat) ticksWidth;
	-(void) setTicksWidth:(CGFloat)p0;
	-(id) init;
@end

@interface TKChartAxisMajorTickStyle : TKChartAxisTickStyle {
}
	-(int) maxTickClippingMode;
	-(void) setMaxTickClippingMode:(int)p0;
	-(int) minTickClippingMode;
	-(void) setMinTickClippingMode:(int)p0;
	-(id) init;
@end

@interface TKChartRender : CALayer {
}
	-(void) setup;
	-(void) update;
	-(id) chart;
	-(BOOL) initialized;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithChart:(id)p0;
@end

@interface TKChartAxisRender : TKChartRender {
}
	-(CGRect) boundsRect;
	-(CGSize) sizeThatFits:(CGSize)p0;
	-(id) axis;
	-(BOOL) isVertical;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithAxis:(id)p0 chart:(id)p1;
@end

@interface TKChartAxisStyle : TKStyleNode {
}
	-(id) backgroundFill;
	-(void) setBackgroundFill:(id)p0;
	-(id) labelStyle;
	-(BOOL) lineHidden;
	-(void) setLineHidden:(BOOL)p0;
	-(id) lineStroke;
	-(void) setLineStroke:(id)p0;
	-(id) majorTickStyle;
	-(id) minorTickStyle;
	-(id) titleStyle;
	-(id) init;
@end

@interface TKChartAxisTitleStyle : TKChartLabelStyle {
}
	-(int) alignment;
	-(void) setAlignment:(int)p0;
	-(CGFloat) rotationAngle;
	-(void) setRotationAngle:(CGFloat)p0;
	-(id) init;
@end

@interface TKChartPointAnnotation : TKChartAnnotation {
}
	-(CGPoint) locationInRect:(CGRect)p0 forChart:(id)p1;
	-(UIOffset) offset;
	-(void) setOffset:(UIOffset)p0;
	-(id) position;
	-(void) setPosition:(id)p0;
	-(id) series;
	-(void) setSeries:(id)p0;
	-(id) init;
	-(id) initWithX:(NSObject *)p0 Y:(NSObject *)p1 forSeries:(id)p2;
	-(id) initWithPoint:(id)p0 forSeries:(id)p1;
	-(id) initWithX:(NSObject *)p0 Y:(NSObject *)p1 forXAxis:(id)p2 forYAxis:(id)p3;
	-(id) initWithPoint:(id)p0 forXAxis:(id)p1 forYAxis:(id)p2;
@end

@interface TKChartBalloonAnnotation : TKChartPointAnnotation {
}
	-(NSAttributedString *) attributedText;
	-(void) setAttributedText:(NSAttributedString *)p0;
	-(CGSize) size;
	-(void) setSize:(CGSize)p0;
	-(id) style;
	-(NSString *) text;
	-(void) setText:(NSString *)p0;
	-(UIView *) view;
	-(void) setView:(UIView *)p0;
	-(id) init;
	-(id) initWithX:(NSObject *)p0 Y:(NSObject *)p1 forSeries:(id)p2;
	-(id) initWithPoint:(id)p0 forSeries:(id)p1;
	-(id) initWithX:(NSObject *)p0 Y:(NSObject *)p1 forXAxis:(id)p2 forYAxis:(id)p3;
	-(id) initWithPoint:(id)p0 forXAxis:(id)p1 forYAxis:(id)p2;
	-(id) initWithText:(NSString *)p0 X:(NSObject *)p1 Y:(NSObject *)p2 forSeries:(id)p3;
	-(id) initWithText:(NSString *)p0 point:(id)p1 forSeries:(id)p2;
	-(id) initWithText:(NSString *)p0 X:(NSObject *)p1 Y:(NSObject *)p2 forXAxis:(id)p3 forYAxis:(id)p4;
	-(id) initWithText:(NSString *)p0 point:(id)p1 forXAxis:(id)p2 forYAxis:(id)p3;
	-(id) initWithText:(NSString *)p0;
@end

@interface TKChartBalloonAnnotationStyle : TKChartAnnotationStyle {
}
	-(CGSize) arrowSize;
	-(void) setArrowSize:(CGSize)p0;
	-(CGFloat) cornerRadius;
	-(void) setCornerRadius:(CGFloat)p0;
	-(CGFloat) distanceFromPoint;
	-(void) setDistanceFromPoint:(CGFloat)p0;
	-(id) fill;
	-(void) setFill:(id)p0;
	-(UIFont *) font;
	-(void) setFont:(UIFont *)p0;
	-(int) horizontalAlign;
	-(void) setHorizontalAlign:(int)p0;
	-(UIEdgeInsets) insets;
	-(void) setInsets:(UIEdgeInsets)p0;
	-(id) stroke;
	-(void) setStroke:(id)p0;
	-(NSInteger) textAlignment;
	-(void) setTextAlignment:(NSInteger)p0;
	-(UIColor *) textColor;
	-(void) setTextColor:(UIColor *)p0;
	-(int) textOrientation;
	-(void) setTextOrientation:(int)p0;
	-(int) verticalAlign;
	-(void) setVerticalAlign:(int)p0;
	-(id) init;
@end

@interface TKChartBandAnnotation : TKChartAnnotation {
}
	-(id) axis;
	-(void) setAxis:(id)p0;
	-(id) range;
	-(void) setRange:(id)p0;
	-(id) style;
	-(id) init;
	-(id) initWithRange:(id)p0 forAxis:(id)p1;
	-(id) initWithRange:(id)p0 forAxis:(id)p1 withFill:(id)p2 withStroke:(id)p3;
@end

@interface TKChartGridLineAnnotationStyle : TKChartAnnotationStyle {
}
	-(id) stroke;
	-(void) setStroke:(id)p0;
	-(id) init;
@end

@interface TKChartBandAnnotationStyle : TKChartGridLineAnnotationStyle {
}
	-(id) fill;
	-(void) setFill:(id)p0;
	-(id) init;
@end

@interface TKChartBandIndicator : TKChartFinancialIndicator {
}
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartVisualPoint : NSObject {
}
	-(UIDynamicAnimator *) animator;
	-(void) setAnimator:(UIDynamicAnimator *)p0;
	-(CGRect) bounds;
	-(CGPoint) CGPoint;
	-(CGPoint) center;
	-(void) setCenter:(CGPoint)p0;
	-(double) doubleValue;
	-(CGFloat) opacity;
	-(void) setOpacity:(CGFloat)p0;
	-(CGFloat) scaleFactor;
	-(void) setScaleFactor:(CGFloat)p0;
	-(CGAffineTransform) transform;
	-(void) setTransform:(CGAffineTransform)p0;
	-(CGFloat) x;
	-(void) setX:(CGFloat)p0;
	-(CGFloat) y;
	-(void) setY:(CGFloat)p0;
	-(id) init;
	-(id) initWithPoint:(CGPoint)p0;
@end

@interface TKChartBandVisualPoint : TKChartVisualPoint {
}
	-(CGFloat) signalY;
	-(void) setSignalY:(CGFloat)p0;
	-(id) init;
	-(id) initWithPoint:(CGPoint)p0 signalY:(CGFloat)p1;
@end

@interface TKChartBarSeries : TKChartSeries {
}
	-(BOOL) allowClustering;
	-(void) setAllowClustering:(BOOL)p0;
	-(CGFloat) gapLength;
	-(void) setGapLength:(CGFloat)p0;
	-(NSNumber *) maxBarHeight;
	-(void) setMaxBarHeight:(NSNumber *)p0;
	-(NSNumber *) minBarHeight;
	-(void) setMinBarHeight:(NSNumber *)p0;
	-(id) init;
	-(id) initWithItems:(NSArray *)p0;
	-(id) initWithItems:(NSArray *)p0 reuseIdentifier:(NSString *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1 reuseIdentifier:(NSString *)p2;
	-(id) initWithItems:(NSArray *)p0 xValueKey:(NSString *)p1 yValueKey:(NSString *)p2;
@end

@interface TKChartBollingerBandIndicator : TKChartBandIndicator {
}
	-(NSUInteger) period;
	-(void) setPeriod:(NSUInteger)p0;
	-(NSUInteger) width;
	-(void) setWidth:(NSUInteger)p0;
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@protocol TKChartData
	@optional @property (nonatomic, assign, readonly) NSObject * dataXValue;
	@optional @property (nonatomic, assign, readonly) NSObject * dataYValue;
	@optional @property (nonatomic, assign, readonly) NSString * dataName;
	@optional @property (nonatomic, assign, readonly) NSNumber * area;
	@optional @property (nonatomic, assign, readonly) NSNumber * open;
	@optional @property (nonatomic, assign, readonly) NSNumber * high;
	@optional @property (nonatomic, assign, readonly) NSNumber * low;
	@optional @property (nonatomic, assign, readonly) NSNumber * close;
	@optional @property (nonatomic, assign, readonly) NSNumber * volume;
	@optional @property (nonatomic, assign, readonly) NSObject * signalYValue;
@end

@interface TKChartBubbleDataPoint : NSObject {
}
	-(NSNumber *) area;
	-(void) setArea:(NSNumber *)p0;
	-(NSNumber *) close;
	-(NSString *) dataName;
	-(NSObject *) dataXValue;
	-(void) setDataXValue:(NSObject *)p0;
	-(NSObject *) dataYValue;
	-(void) setDataYValue:(NSObject *)p0;
	-(NSNumber *) high;
	-(NSNumber *) low;
	-(NSNumber *) open;
	-(NSObject *) signalYValue;
	-(NSNumber *) volume;
	-(id) init;
	-(id) initWithX:(NSObject *)p0 Y:(NSObject *)p1 area:(NSNumber *)p2;
@end

@interface TKChartScatterSeries : TKChartSeries {
}
	-(CGFloat) marginForHitDetection;
	-(void) setMarginForHitDetection:(CGFloat)p0;
	-(id) init;
	-(id) initWithItems:(NSArray *)p0;
	-(id) initWithItems:(NSArray *)p0 reuseIdentifier:(NSString *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1 reuseIdentifier:(NSString *)p2;
	-(id) initWithItems:(NSArray *)p0 xValueKey:(NSString *)p1 yValueKey:(NSString *)p2;
@end

@interface TKChartBubbleSeries : TKChartScatterSeries {
}
	-(NSNumber *) biggestBubbleDiameterForAutoscale;
	-(void) setBiggestBubbleDiameterForAutoscale:(NSNumber *)p0;
	-(NSNumber *) scale;
	-(void) setScale:(NSNumber *)p0;
	-(id) init;
	-(id) initWithItems:(NSArray *)p0;
	-(id) initWithItems:(NSArray *)p0 reuseIdentifier:(NSString *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1 reuseIdentifier:(NSString *)p2;
	-(id) initWithItems:(NSArray *)p0 xValueKey:(NSString *)p1 yValueKey:(NSString *)p2;
@end

@interface TKChartBubbleVisualPoint : TKChartVisualPoint {
}
	-(CGFloat) diameter;
	-(void) setDiameter:(CGFloat)p0;
	-(id) init;
@end

@interface TKChartColumnSeries : TKChartSeries {
}
	-(BOOL) allowClustering;
	-(void) setAllowClustering:(BOOL)p0;
	-(CGFloat) gapLength;
	-(void) setGapLength:(CGFloat)p0;
	-(NSNumber *) maxColumnWidth;
	-(void) setMaxColumnWidth:(NSNumber *)p0;
	-(NSNumber *) minColumnWidth;
	-(void) setMinColumnWidth:(NSNumber *)p0;
	-(id) init;
	-(id) initWithItems:(NSArray *)p0;
	-(id) initWithItems:(NSArray *)p0 reuseIdentifier:(NSString *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1 reuseIdentifier:(NSString *)p2;
	-(id) initWithItems:(NSArray *)p0 xValueKey:(NSString *)p1 yValueKey:(NSString *)p2;
@end

@interface TKChartOhlcSeries : TKChartColumnSeries {
}
	-(id) init;
	-(id) initWithItems:(NSArray *)p0;
	-(id) initWithItems:(NSArray *)p0 reuseIdentifier:(NSString *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1 reuseIdentifier:(NSString *)p2;
	-(id) initWithItems:(NSArray *)p0 xValueKey:(NSString *)p1 yValueKey:(NSString *)p2;
@end

@interface TKChartCandlestickSeries : TKChartOhlcSeries {
}
	-(id) init;
	-(id) initWithItems:(NSArray *)p0;
	-(id) initWithItems:(NSArray *)p0 reuseIdentifier:(NSString *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1 reuseIdentifier:(NSString *)p2;
	-(id) initWithItems:(NSArray *)p0 xValueKey:(NSString *)p1 yValueKey:(NSString *)p2;
@end

@interface TKChartCategoryAxis : TKChartAxis {
}
	-(void) addCategoriesFromArray:(NSArray *)p0;
	-(void) addCategory:(NSObject *)p0;
	-(void) removeAllCategories;
	-(void) removeCategoriesInArray:(NSArray *)p0;
	-(void) removeCategory:(NSObject *)p0;
	-(NSInteger) baseline;
	-(void) setBaseline:(NSInteger)p0;
	-(NSArray *) categories;
	-(NSUInteger) majorTickInterval;
	-(void) setMajorTickInterval:(NSUInteger)p0;
	-(NSUInteger) minorTickInterval;
	-(void) setMinorTickInterval:(NSUInteger)p0;
	-(NSInteger) offset;
	-(void) setOffset:(NSInteger)p0;
	-(int) plotMode;
	-(void) setPlotMode:(int)p0;
	-(id) init;
	-(id) initWithCategories:(NSArray *)p0;
	-(id) initWithCategories:(NSArray *)p0 andRange:(id)p1;
	-(id) initWithRange:(id)p0;
	-(id) initWithMinimum:(NSObject *)p0 andMaximum:(NSObject *)p1;
	-(id) initWithMinimum:(NSObject *)p0 andMaximum:(NSObject *)p1 position:(int)p2;
@end

@interface TKChartChaikinOscillator : TKChartFinancialIndicator {
}
	-(NSUInteger) longPeriod;
	-(void) setLongPeriod:(NSUInteger)p0;
	-(NSUInteger) shortPeriod;
	-(void) setShortPeriod:(NSUInteger)p0;
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartCommodityChannelIndex : TKChartFinancialIndicator {
}
	-(NSUInteger) period;
	-(void) setPeriod:(NSUInteger)p0;
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartCrossLineAnnotation : TKChartPointAnnotation {
}
	-(id) style;
	-(id) init;
	-(id) initWithX:(NSObject *)p0 Y:(NSObject *)p1 forSeries:(id)p2;
	-(id) initWithPoint:(id)p0 forSeries:(id)p1;
	-(id) initWithX:(NSObject *)p0 Y:(NSObject *)p1 forXAxis:(id)p2 forYAxis:(id)p3;
	-(id) initWithPoint:(id)p0 forXAxis:(id)p1 forYAxis:(id)p2;
@end

@interface TKChartCrossLineAnnotationStyle : TKChartAnnotationStyle {
}
	-(id) horizontalLineStroke;
	-(void) setHorizontalLineStroke:(id)p0;
	-(UIEdgeInsets) insets;
	-(void) setInsets:(UIEdgeInsets)p0;
	-(int) orientation;
	-(void) setOrientation:(int)p0;
	-(id) pointShape;
	-(void) setPointShape:(id)p0;
	-(id) pointShapeFill;
	-(void) setPointShapeFill:(id)p0;
	-(UIEdgeInsets) pointShapeInsets;
	-(void) setPointShapeInsets:(UIEdgeInsets)p0;
	-(id) pointShapeStroke;
	-(void) setPointShapeStroke:(id)p0;
	-(id) verticalLineStroke;
	-(void) setVerticalLineStroke:(id)p0;
	-(id) init;
@end

@interface TKChartDataPoint : NSObject {
}
	-(NSNumber *) area;
	-(NSNumber *) close;
	-(NSString *) dataName;
	-(void) setDataName:(NSString *)p0;
	-(NSObject *) dataXValue;
	-(void) setDataXValue:(NSObject *)p0;
	-(NSObject *) dataYValue;
	-(void) setDataYValue:(NSObject *)p0;
	-(NSNumber *) high;
	-(NSNumber *) low;
	-(NSNumber *) open;
	-(NSObject *) signalYValue;
	-(NSNumber *) volume;
	-(id) init;
	-(id) initWithX:(NSObject *)p0 Y:(NSObject *)p1;
	-(id) initWithX:(NSObject *)p0 Y:(NSObject *)p1 name:(NSString *)p2;
@end

@protocol TKChartDataSource
	@optional -(NSUInteger) numberOfSeriesForChart:(id)p0;
	@optional -(id) seriesForChart:(id)p0 atIndex:(NSUInteger)p1;
	@optional -(NSUInteger) chart:(id)p0 numberOfDataPointsForSeriesAtIndex:(NSUInteger)p1;
	@optional -(id) chart:(id)p0 dataPointAtIndex:(NSUInteger)p1 forSeriesAtIndex:(NSUInteger)p2;
	@optional -(NSArray *) chart:(id)p0 dataPointsForSeriesAtIndex:(NSUInteger)p1;
@end

@interface TKChartDateTimeAxis : TKChartAxis {
}
	-(NSDate *) baseline;
	-(void) setBaseline:(NSDate *)p0;
	-(NSInteger) majorTickCount;
	-(void) setMajorTickCount:(NSInteger)p0;
	-(double) majorTickInterval;
	-(void) setMajorTickInterval:(double)p0;
	-(int) majorTickIntervalUnit;
	-(void) setMajorTickIntervalUnit:(int)p0;
	-(int) minorTickIntervalUnit;
	-(void) setMinorTickIntervalUnit:(int)p0;
	-(NSDate *) offset;
	-(void) setOffset:(NSDate *)p0;
	-(int) plotMode;
	-(void) setPlotMode:(int)p0;
	-(id) init;
	-(id) initWithMinimumDate:(NSDate *)p0 andMaximumDate:(NSDate *)p1;
	-(id) initWithRange:(id)p0;
	-(id) initWithMinimum:(NSObject *)p0 andMaximum:(NSObject *)p1;
	-(id) initWithMinimum:(NSObject *)p0 andMaximum:(NSObject *)p1 position:(int)p2;
@end

@interface TKChartDateTimeCategoryAxis : TKChartAxis {
}
	-(NSDate *) baseline;
	-(void) setBaseline:(NSDate *)p0;
	-(NSArray *) categories;
	-(NSUInteger) dateComponent;
	-(void) setDateComponent:(NSUInteger)p0;
	-(NSInteger) majorTickInterval;
	-(NSNumber *) minorTickInterval;
	-(void) setMinorTickInterval:(NSNumber *)p0;
	-(NSDate *) offset;
	-(void) setOffset:(NSDate *)p0;
	-(int) plotMode;
	-(void) setPlotMode:(int)p0;
	-(id) init;
	-(id) initWithMinimumDate:(NSDate *)p0 andMaximumDate:(NSDate *)p1;
@end

@protocol TKChartDelegate
	@optional -(id) chart:(id)p0 paletteItemForSeries:(id)p1 atIndex:(NSInteger)p2;
	@optional -(id) chart:(id)p0 paletteItemForPoint:(NSUInteger)p1 inSeries:(id)p2;
	@optional -(id) chart:(id)p0 shapeForSeries:(id)p1 atIndex:(NSUInteger)p2;
	@optional -(CAAnimation *) chart:(id)p0 animationForSeries:(id)p1 withState:(id)p2 inRect:(CGRect)p3;
	@optional -(void) chart:(id)p0 didSelectSeries:(id)p1;
	@optional -(void) chart:(id)p0 didDeselectSeries:(id)p1;
	@optional -(void) chart:(id)p0 didSelectPoint:(id)p1 inSeries:(id)p2 atIndex:(NSInteger)p3;
	@optional -(void) chart:(id)p0 didDeselectPoint:(id)p1 inSeries:(id)p2 atIndex:(NSInteger)p3;
	@optional -(void) chartWillZoom:(id)p0;
	@optional -(void) chartDidZoom:(id)p0;
	@optional -(void) chartWillPan:(id)p0;
	@optional -(void) chartDidPan:(id)p0;
	@optional -(void) chart:(id)p0 trackballDidTrackSelection:(NSArray *)p1;
	@optional -(void) chart:(id)p0 trackballDidHideSelection:(NSArray *)p1;
	@optional -(id) chart:(id)p0 labelForDataPoint:(id)p1 property:(NSString *)p2 inSeries:(id)p3 atIndex:(NSUInteger)p4;
	@optional -(NSString *) chart:(id)p0 textForLabelAtPoint:(id)p1 inSeries:(id)p2 atIndex:(NSUInteger)p3;
	@optional -(id) chart:(id)p0 pointLabelRenderForSeries:(id)p1 withRender:(id)p2;
	@optional -(NSString *) chart:(id)p0 textForAxis:(id)p1 value:(NSObject *)p2 atIndex:(NSUInteger)p3;
	@optional -(id) chart:(id)p0 legendItemForSeries:(id)p1 atIndex:(NSUInteger)p2;
	@optional -(NSString *) chart:(id)p0 attributedTextForAxis:(id)p1 value:(NSObject *)p2 atIndex:(NSUInteger)p3;
	@optional -(void) chart:(id)p0 updateLegendItem:(id)p1 forSeries:(id)p2 atIndex:(NSUInteger)p3;
	@optional -(void) chart:(id)p0 didTapOnLegendItem:(id)p1;
@end

@interface TKChartDetrendedPriceOscillator : TKChartFinancialIndicator {
}
	-(NSUInteger) period;
	-(void) setPeriod:(NSUInteger)p0;
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartPieSeries : TKChartSeries {
}
	-(BOOL) adjustSizeToFit;
	-(void) setAdjustSizeToFit:(BOOL)p0;
	-(BOOL) displayPercentage;
	-(void) setDisplayPercentage:(BOOL)p0;
	-(CGFloat) endAngle;
	-(void) setEndAngle:(CGFloat)p0;
	-(CGFloat) expandRadius;
	-(void) setExpandRadius:(CGFloat)p0;
	-(int) labelDisplayMode;
	-(void) setLabelDisplayMode:(int)p0;
	-(CGFloat) outerRadius;
	-(void) setOuterRadius:(CGFloat)p0;
	-(CGFloat) radiusInset;
	-(void) setRadiusInset:(CGFloat)p0;
	-(CGFloat) rotationAngle;
	-(void) setRotationAngle:(CGFloat)p0;
	-(CGFloat) rotationDeceleration;
	-(void) setRotationDeceleration:(CGFloat)p0;
	-(BOOL) rotationEnabled;
	-(void) setRotationEnabled:(BOOL)p0;
	-(NSNumber *) selectionAngle;
	-(void) setSelectionAngle:(NSNumber *)p0;
	-(CGFloat) startAngle;
	-(void) setStartAngle:(CGFloat)p0;
	-(id) init;
	-(id) initWithItems:(NSArray *)p0;
	-(id) initWithItems:(NSArray *)p0 reuseIdentifier:(NSString *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1 reuseIdentifier:(NSString *)p2;
	-(id) initWithItems:(NSArray *)p0 xValueKey:(NSString *)p1 yValueKey:(NSString *)p2;
@end

@interface TKChartDonutSeries : TKChartPieSeries {
}
	-(CGFloat) innerRadius;
	-(void) setInnerRadius:(CGFloat)p0;
	-(id) init;
	-(id) initWithItems:(NSArray *)p0;
	-(id) initWithItems:(NSArray *)p0 reuseIdentifier:(NSString *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1 reuseIdentifier:(NSString *)p2;
	-(id) initWithItems:(NSArray *)p0 xValueKey:(NSString *)p1 yValueKey:(NSString *)p2;
@end

@interface TKChartEaseOfMovementIndicator : TKChartFinancialIndicator {
}
	-(NSUInteger) period;
	-(void) setPeriod:(NSUInteger)p0;
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartSimpleMovingAverageIndicator : TKChartFinancialIndicator {
}
	-(NSUInteger) period;
	-(void) setPeriod:(NSUInteger)p0;
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartExponentialMovingAverageIndicator : TKChartSimpleMovingAverageIndicator {
}
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartFastStochasticIndicator : TKChartSignalLineIndicator {
}
	-(NSUInteger) period;
	-(void) setPeriod:(NSUInteger)p0;
	-(NSUInteger) signalPeriod;
	-(void) setSignalPeriod:(NSUInteger)p0;
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartFinancialDataPoint : NSObject {
}
	-(NSNumber *) close;
	-(void) setClose:(NSNumber *)p0;
	-(NSObject *) dataXValue;
	-(void) setDataXValue:(NSObject *)p0;
	-(NSObject *) dataYValue;
	-(void) setDataYValue:(NSObject *)p0;
	-(NSNumber *) high;
	-(void) setHigh:(NSNumber *)p0;
	-(NSNumber *) low;
	-(void) setLow:(NSNumber *)p0;
	-(NSNumber *) open;
	-(void) setOpen:(NSNumber *)p0;
	-(NSNumber *) volume;
	-(void) setVolume:(NSNumber *)p0;
	-(id) init;
	-(id) initWithX:(NSObject *)p0 open:(NSNumber *)p1 high:(NSNumber *)p2 low:(NSNumber *)p3 close:(NSNumber *)p4 volume:(NSNumber *)p5;
@end

@interface TKChartForceIndexIndicator : TKChartFinancialIndicator {
}
	-(NSUInteger) period;
	-(void) setPeriod:(NSUInteger)p0;
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartSlowStochasticIndicator : TKChartFastStochasticIndicator {
}
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartFullStochasticIndicator : TKChartSlowStochasticIndicator {
}
	-(NSUInteger) smoothPeriod;
	-(void) setSmoothPeriod:(NSUInteger)p0;
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartGridLineAnnotation : TKChartAnnotation {
}
	-(id) axis;
	-(void) setAxis:(id)p0;
	-(id) style;
	-(NSObject *) value;
	-(void) setValue:(NSObject *)p0;
	-(id) init;
	-(id) initWithValue:(NSObject *)p0 forAxis:(id)p1;
	-(id) initWithValue:(NSObject *)p0 forAxis:(id)p1 withStroke:(id)p2;
@end

@interface TKChartGridStyle : TKStyleNode {
}
	-(id) backgroundFill;
	-(void) setBackgroundFill:(id)p0;
	-(int) drawOrder;
	-(void) setDrawOrder:(int)p0;
	-(id) horizontalAlternateFill;
	-(void) setHorizontalAlternateFill:(id)p0;
	-(id) horizontalFill;
	-(void) setHorizontalFill:(id)p0;
	-(id) horizontalLineAlternateStroke;
	-(void) setHorizontalLineAlternateStroke:(id)p0;
	-(id) horizontalLineStroke;
	-(void) setHorizontalLineStroke:(id)p0;
	-(BOOL) horizontalLinesHidden;
	-(void) setHorizontalLinesHidden:(BOOL)p0;
	-(id) verticalAlternateFill;
	-(void) setVerticalAlternateFill:(id)p0;
	-(id) verticalFill;
	-(void) setVerticalFill:(id)p0;
	-(id) verticalLineAlternateStroke;
	-(void) setVerticalLineAlternateStroke:(id)p0;
	-(id) verticalLineStroke;
	-(void) setVerticalLineStroke:(id)p0;
	-(BOOL) verticalLinesHidden;
	-(void) setVerticalLinesHidden:(BOOL)p0;
	-(int) zPosition;
	-(void) setZPosition:(int)p0;
	-(id) init;
@end

@interface TKChartLayerAnnotation : TKChartPointAnnotation {
}
	-(CALayer *) layer;
	-(void) setLayer:(CALayer *)p0;
	-(id) init;
	-(id) initWithX:(NSObject *)p0 Y:(NSObject *)p1 forSeries:(id)p2;
	-(id) initWithPoint:(id)p0 forSeries:(id)p1;
	-(id) initWithX:(NSObject *)p0 Y:(NSObject *)p1 forXAxis:(id)p2 forYAxis:(id)p3;
	-(id) initWithPoint:(id)p0 forXAxis:(id)p1 forYAxis:(id)p2;
	-(id) initWithLayer:(CALayer *)p0 X:(NSObject *)p1 Y:(NSObject *)p2 forSeries:(id)p3;
	-(id) initWithLayer:(CALayer *)p0 point:(id)p1 forSeries:(id)p2;
	-(id) initWithLayer:(CALayer *)p0 X:(NSObject *)p1 Y:(NSObject *)p2 forXAxis:(id)p3 forYAxis:(id)p4;
	-(id) initWithLayer:(CALayer *)p0 point:(id)p1 forXAxis:(id)p2 forYAxis:(id)p3;
	-(id) initWithLayer:(CALayer *)p0;
@end

@protocol TKChartLegendItemDelegate
	@optional -(NSUInteger) legendItemCountForChart:(id)p0;
	@optional -(id) legendItemForChart:(id)p0 atIndex:(NSUInteger)p1;
@end

@interface TKChartLegendItemStyle : TKStyleNode {
}
	-(id) fill;
	-(void) setFill:(id)p0;
	-(CGSize) iconSize;
	-(void) setIconSize:(CGSize)p0;
	-(id) labelStyle;
	-(void) setLabelStyle:(id)p0;
	-(id) stroke;
	-(void) setStroke:(id)p0;
	-(id) init;
@end

@interface TKChartLegendStyle : TKStyleNode {
}
	-(id) fill;
	-(void) setFill:(id)p0;
	-(UIEdgeInsets) insets;
	-(void) setInsets:(UIEdgeInsets)p0;
	-(UIOffset) offset;
	-(void) setOffset:(UIOffset)p0;
	-(int) offsetOrigin;
	-(void) setOffsetOrigin:(int)p0;
	-(int) position;
	-(void) setPosition:(int)p0;
	-(id) stroke;
	-(void) setStroke:(id)p0;
	-(id) init;
@end

@interface TKChartNumericAxis : TKChartAxis {
}
	-(NSNumber *) baseline;
	-(void) setBaseline:(NSNumber *)p0;
	-(int) labelDisplayMode;
	-(void) setLabelDisplayMode:(int)p0;
	-(NSNumber *) majorTickInterval;
	-(void) setMajorTickInterval:(NSNumber *)p0;
	-(NSNumber *) minorTickInterval;
	-(void) setMinorTickInterval:(NSNumber *)p0;
	-(NSNumber *) offset;
	-(void) setOffset:(NSNumber *)p0;
	-(id) init;
	-(id) initWithRange:(id)p0;
	-(id) initWithMinimum:(NSObject *)p0 andMaximum:(NSObject *)p1;
	-(id) initWithMinimum:(NSObject *)p0 andMaximum:(NSObject *)p1 position:(int)p2;
@end

@interface TKChartLogarithmicAxis : TKChartNumericAxis {
}
	-(NSNumber *) exponentStep;
	-(void) setExponentStep:(NSNumber *)p0;
	-(NSNumber *) logarithmBase;
	-(void) setLogarithmBase:(NSNumber *)p0;
	-(id) init;
@end

@interface TKChartMarketFacilitationIndex : TKChartFinancialIndicator {
}
	-(CGFloat) gapLength;
	-(void) setGapLength:(CGFloat)p0;
	-(NSNumber *) maxColumnWidth;
	-(void) setMaxColumnWidth:(NSNumber *)p0;
	-(NSNumber *) minColumnWidth;
	-(void) setMinColumnWidth:(NSNumber *)p0;
	-(NSUInteger) range;
	-(void) setRange:(NSUInteger)p0;
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartMedianPriceIndicator : TKChartFinancialIndicator {
}
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartModifiedMovingAverageIndicator : TKChartExponentialMovingAverageIndicator {
}
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartMoneyFlowIndexIndicator : TKChartFinancialIndicator {
}
	-(NSUInteger) period;
	-(void) setPeriod:(NSUInteger)p0;
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartMovingAverageEnvelopesIndicator : TKChartBandIndicator {
}
	-(CGFloat) envelopesPercentage;
	-(void) setEnvelopesPercentage:(CGFloat)p0;
	-(NSUInteger) period;
	-(void) setPeriod:(NSUInteger)p0;
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartNegativeVolumeIndexIndicator : TKChartFinancialIndicator {
}
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartOnBalanceVolumeIndicator : TKChartFinancialIndicator {
}
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartPalette : NSObject {
}
	-(void) addPaletteItem:(id)p0;
	-(void) addPaletteItems:(NSArray *)p0;
	-(void) clearPalette;
	-(void) insertPaletteItem:(id)p0 atIndex:(NSUInteger)p1;
	-(id) paletteItemAtIndex:(NSUInteger)p0;
	-(void) replacePaletteItem:(id)p0 atIndex:(NSUInteger)p1;
	-(NSArray *) items;
	-(NSUInteger) itemsCount;
	-(id) init;
@end

@interface TKChartPaletteItem : NSObject {
}
	-(NSArray *) drawables;
	-(void) setDrawables:(NSArray *)p0;
	-(id) fill;
	-(void) setFill:(id)p0;
	-(UIFont *) font;
	-(void) setFont:(UIFont *)p0;
	-(id) stroke;
	-(void) setStroke:(id)p0;
	-(UIColor *) textColor;
	-(void) setTextColor:(UIColor *)p0;
	-(id) init;
	-(id) initWithFill:(id)p0;
	-(id) initWithStroke:(id)p0;
	-(id) initWithStroke:(id)p0 andFill:(id)p1;
	-(id) initWithDrawables:(NSArray *)p0;
@end

@interface TKChartPercentagePriceOscillator : TKChartMACDIndicator {
}
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartPercentageVolumeOscillator : TKChartMACDIndicator {
}
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartPieVisualPoint : TKChartVisualPoint {
}
	-(CGFloat) distanceFromCenter;
	-(void) setDistanceFromCenter:(CGFloat)p0;
	-(CGFloat) startAngle;
	-(void) setStartAngle:(CGFloat)p0;
	-(id) init;
@end

@interface TKChartPointLabel : NSObject {
}
	-(void) drawInContext:(id)p0 inRect:(CGRect)p1 forVisualPoint:(id)p2 color:(UIColor *)p3;
	-(CGSize) sizeThatFits:(CGSize)p0;
	-(id) dataPoint;
	-(id) style;
	-(NSString *) text;
	-(void) setText:(NSString *)p0;
	-(id) init;
	-(id) initWithPoint:(id)p0 series:(id)p1 text:(NSString *)p2;
@end

@interface TKChartPointLabelRender : NSObject {
}
	-(BOOL) isPoint:(CGPoint)p0 insideRect:(CGRect)p1;
	-(id) labelForDataPoint:(id)p0 inSeries:(id)p1 atIndex:(NSUInteger)p2;
	-(CGPoint) locationForDataPoint:(id)p0 forSeries:(id)p1 inRect:(CGRect)p2;
	-(void) renderPointLabelsForSeries:(id)p0 inRect:(CGRect)p1 context:(id)p2;
	-(id) render;
	-(id) init;
	-(id) initWithRender:(id)p0;
@end

@interface TKChartPointLabelStyle : TKChartLabelStyle {
}
	-(float) blurRadius;
	-(void) setBlurRadius:(float)p0;
	-(int) clipMode;
	-(void) setClipMode:(int)p0;
	-(float) cornerRadius;
	-(void) setCornerRadius:(float)p0;
	-(id) fill;
	-(void) setFill:(id)p0;
	-(NSFormatter *) formatter;
	-(void) setFormatter:(NSFormatter *)p0;
	-(UIEdgeInsets) insets;
	-(void) setInsets:(UIEdgeInsets)p0;
	-(UIOffset) labelOffset;
	-(void) setLabelOffset:(UIOffset)p0;
	-(int) layoutMode;
	-(void) setLayoutMode:(int)p0;
	-(NSString *) stringFormat;
	-(void) setStringFormat:(NSString *)p0;
	-(id) stroke;
	-(void) setStroke:(id)p0;
	-(NSInteger) textAlignment;
	-(void) setTextAlignment:(NSInteger)p0;
	-(int) textOrientation;
	-(void) setTextOrientation:(int)p0;
	-(id) init;
@end

@interface TKChartPositiveVolumeIndexIndicator : TKChartFinancialIndicator {
}
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartPriceVolumeTrendIndicator : TKChartFinancialIndicator {
}
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartRangeBarSeries : TKChartBarSeries {
}
	-(id) init;
	-(id) initWithItems:(NSArray *)p0;
	-(id) initWithItems:(NSArray *)p0 reuseIdentifier:(NSString *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1 reuseIdentifier:(NSString *)p2;
	-(id) initWithItems:(NSArray *)p0 xValueKey:(NSString *)p1 yValueKey:(NSString *)p2;
@end

@interface TKChartRangeColumnSeries : TKChartColumnSeries {
}
	-(id) init;
	-(id) initWithItems:(NSArray *)p0;
	-(id) initWithItems:(NSArray *)p0 reuseIdentifier:(NSString *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1 reuseIdentifier:(NSString *)p2;
	-(id) initWithItems:(NSArray *)p0 xValueKey:(NSString *)p1 yValueKey:(NSString *)p2;
@end

@interface TKChartRangeDataPoint : NSObject {
}
	-(NSNumber *) area;
	-(NSNumber *) close;
	-(NSString *) dataName;
	-(NSObject *) dataXValue;
	-(void) setDataXValue:(NSObject *)p0;
	-(NSObject *) dataYValue;
	-(void) setDataYValue:(NSObject *)p0;
	-(NSObject *) high;
	-(void) setHigh:(NSObject *)p0;
	-(NSObject *) low;
	-(void) setLow:(NSObject *)p0;
	-(NSNumber *) open;
	-(NSObject *) signalYValue;
	-(NSNumber *) volume;
	-(id) init;
@end

@interface TKChartRangeVisualPoint : TKChartVisualPoint {
}
	-(CGFloat) high;
	-(void) setHigh:(CGFloat)p0;
	-(CGFloat) low;
	-(void) setLow:(CGFloat)p0;
	-(id) init;
	-(id) initWithPoint:(CGPoint)p0 low:(CGFloat)p1 high:(CGFloat)p2;
@end

@interface TKChartRapidAdaptiveVarianceIndicator : TKChartFinancialIndicator {
}
	-(NSUInteger) longPeriod;
	-(void) setLongPeriod:(NSUInteger)p0;
	-(NSUInteger) shortPeriod;
	-(void) setShortPeriod:(NSUInteger)p0;
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartRateOfChangeIndicator : TKChartFinancialIndicator {
}
	-(NSUInteger) period;
	-(void) setPeriod:(NSUInteger)p0;
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartRelativeMomentumIndex : TKChartFinancialIndicator {
}
	-(NSUInteger) momentum;
	-(void) setMomentum:(NSUInteger)p0;
	-(NSUInteger) period;
	-(void) setPeriod:(NSUInteger)p0;
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartRelativeStrengthIndex : TKChartFinancialIndicator {
}
	-(NSUInteger) period;
	-(void) setPeriod:(NSUInteger)p0;
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartSelectionInfo : NSObject {
}
	-(id) dataPoint;
	-(NSInteger) dataPointIndex;
	-(CGFloat) distance;
	-(CGPoint) location;
	-(id) series;
	-(id) init;
	-(id) initWithSeries:(id)p0 dataPointIndex:(NSInteger)p1;
	-(id) initWithSeries:(id)p0 dataPointIndex:(NSInteger)p1 distance:(CGFloat)p2;
@end

@interface TKChartSeriesRender : TKChartRender {
}
	-(BOOL) addSeries:(id)p0;
	-(id) createVisualPoint:(id)p0 pointIndex:(NSUInteger)p1 inSeries:(id)p2;
	-(id) hitTestForPoint:(CGPoint)p0;
	-(BOOL) isCompatibleWithSeries:(id)p0;
	-(CGPoint) locationOfPoint:(id)p0 inSeries:(id)p1;
	-(double) locationOfXNumericValue:(double)p0 inSeries:(id)p1;
	-(double) locationOfYNumericValue:(double)p0 inSeries:(id)p1;
	-(id) pointFromData:(id)p0 pointIndex:(NSUInteger)p1 inSeries:(id)p2;
	-(void) selectionWillChangeForSeries:(id)p0 andPoint:(NSInteger)p1;
	-(NSArray *) series;
	-(id) seriesRenderStates;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithChart:(id)p0 forSeries:(NSArray *)p1;
@end

@interface TKChartSeriesRenderState : NSObject {
}
	-(NSString *) animationKeyPathForPointAtIndex:(NSUInteger)p0;
	-(NSUInteger) index;
	-(id) oldPoints;
	-(id) points;
	-(void) setPoints:(id)p0;
	-(id) init;
	-(id) initWithIndex:(NSUInteger)p0;
@end

@interface TKChartSeriesStyle : TKStyleNode {
}
	-(id) fill;
	-(void) setFill:(id)p0;
	-(id) palette;
	-(void) setPalette:(id)p0;
	-(int) paletteMode;
	-(void) setPaletteMode:(int)p0;
	-(id) pointLabelStyle;
	-(void) setPointLabelStyle:(id)p0;
	-(id) pointShape;
	-(void) setPointShape:(id)p0;
	-(int) shapeMode;
	-(void) setShapeMode:(int)p0;
	-(id) shapePalette;
	-(void) setShapePalette:(id)p0;
	-(id) stroke;
	-(void) setStroke:(id)p0;
	-(id) init;
@end

@interface TKChartSplineAreaSeries : TKChartAreaSeries {
}
	-(id) init;
	-(id) initWithItems:(NSArray *)p0;
	-(id) initWithItems:(NSArray *)p0 reuseIdentifier:(NSString *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1 reuseIdentifier:(NSString *)p2;
	-(id) initWithItems:(NSArray *)p0 xValueKey:(NSString *)p1 yValueKey:(NSString *)p2;
@end

@interface TKChartSplineSeries : TKChartLineSeries {
}
	-(id) init;
	-(id) initWithItems:(NSArray *)p0;
	-(id) initWithItems:(NSArray *)p0 reuseIdentifier:(NSString *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1;
	-(id) initWithItems:(NSArray *)p0 forKeys:(NSDictionary *)p1 reuseIdentifier:(NSString *)p2;
	-(id) initWithItems:(NSArray *)p0 xValueKey:(NSString *)p1 yValueKey:(NSString *)p2;
@end

@interface TKChartStackInfo : NSObject {
}
	-(NSObject *) stackID;
	-(void) setStackID:(NSObject *)p0;
	-(int) stackMode;
	-(void) setStackMode:(int)p0;
	-(id) init;
	-(id) initWithID:(NSObject *)p0 withStackMode:(int)p1;
@end

@interface TKChartStandardDeviationIndicator : TKChartSimpleMovingAverageIndicator {
}
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartTitleStyle : TKStyleNode {
}
	-(id) init;
@end

@interface TKChartTrackball : NSObject {
}
	-(void) hide;
	-(void) showAtPoint:(CGPoint)p0;
	-(int) hideMode;
	-(void) setHideMode:(int)p0;
	-(BOOL) isVisible;
	-(id) line;
	-(CGFloat) marginForHitDetection;
	-(void) setMarginForHitDetection:(CGFloat)p0;
	-(CGFloat) minimumPressDuration;
	-(void) setMinimumPressDuration:(CGFloat)p0;
	-(int) orientation;
	-(void) setOrientation:(int)p0;
	-(int) snapMode;
	-(void) setSnapMode:(int)p0;
	-(id) tooltip;
	-(id) init;
	-(id) initWithChart:(id)p0;
@end

@interface TKChartTrackballLineAnnotation : TKChartAnnotation {
}
	-(void) updateContent;
	-(NSArray *) selectedPoints;
	-(void) setSelectedPoints:(NSArray *)p0;
	-(id) style;
	-(void) setStyle:(id)p0;
	-(id) init;
	-(id) initWithTrackball:(id)p0;
@end

@interface TKChartTrackballTooltipAnnotation : TKChartBalloonAnnotation {
}
	-(void) updateContent;
	-(int) pinPosition;
	-(void) setPinPosition:(int)p0;
	-(id) init;
	-(id) initWithTrackball:(id)p0;
@end

@interface TKChartTriangularMovingAverageIndicator : TKChartSimpleMovingAverageIndicator {
}
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartTRIXIndicator : TKChartSimpleMovingAverageIndicator {
}
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartTypicalPriceIndicator : TKChartFinancialIndicator {
}
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartUltimateOscillator : TKChartFinancialIndicator {
}
	-(NSUInteger) longPeriod;
	-(void) setLongPeriod:(NSUInteger)p0;
	-(NSUInteger) middlePeriod;
	-(void) setMiddlePeriod:(NSUInteger)p0;
	-(NSUInteger) shortPeriod;
	-(void) setShortPeriod:(NSUInteger)p0;
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartViewAnnotation : TKChartPointAnnotation {
}
	-(UIView *) view;
	-(void) setView:(UIView *)p0;
	-(id) init;
	-(id) initWithX:(NSObject *)p0 Y:(NSObject *)p1 forSeries:(id)p2;
	-(id) initWithPoint:(id)p0 forSeries:(id)p1;
	-(id) initWithX:(NSObject *)p0 Y:(NSObject *)p1 forXAxis:(id)p2 forYAxis:(id)p3;
	-(id) initWithPoint:(id)p0 forXAxis:(id)p1 forYAxis:(id)p2;
	-(id) initWithView:(UIView *)p0 X:(NSObject *)p1 Y:(NSObject *)p2 forSeries:(id)p3;
	-(id) initWithView:(UIView *)p0 point:(id)p1 forSeries:(id)p2;
	-(id) initWithView:(UIView *)p0 X:(NSObject *)p1 Y:(NSObject *)p2 forXAxis:(id)p3 forYAxis:(id)p4;
	-(id) initWithView:(UIView *)p0 point:(id)p1 forXAxis:(id)p2 forYAxis:(id)p3;
	-(id) initWithView:(UIView *)p0;
@end

@interface TKChartViewController : UIViewController {
}
	-(CAAnimation *) chart:(id)p0 animationForSeries:(id)p1 withState:(id)p2 inRect:(CGRect)p3;
	-(NSString *) chart:(id)p0 attributedTextForAxis:(id)p1 value:(NSObject *)p2 atIndex:(NSUInteger)p3;
	-(void) chartDidPan:(id)p0;
	-(void) chart:(id)p0 didTapOnLegendItem:(id)p1;
	-(void) chartDidZoom:(id)p0;
	-(NSArray *) chart:(id)p0 dataPointsForSeriesAtIndex:(NSUInteger)p1;
	-(id) chart:(id)p0 dataPointAtIndex:(NSUInteger)p1 forSeriesAtIndex:(NSUInteger)p2;
	-(id) seriesForChart:(id)p0 atIndex:(NSUInteger)p1;
	-(id) chart:(id)p0 labelForDataPoint:(id)p1 property:(NSString *)p2 inSeries:(id)p3 atIndex:(NSUInteger)p4;
	-(id) chart:(id)p0 legendItemForSeries:(id)p1 atIndex:(NSUInteger)p2;
	-(NSUInteger) numberOfSeriesForChart:(id)p0;
	-(id) chart:(id)p0 paletteItemForPoint:(NSUInteger)p1 inSeries:(id)p2;
	-(id) chart:(id)p0 paletteItemForSeries:(id)p1 atIndex:(NSInteger)p2;
	-(void) chart:(id)p0 didDeselectPoint:(id)p1 inSeries:(id)p2 atIndex:(NSInteger)p3;
	-(id) chart:(id)p0 pointLabelRenderForSeries:(id)p1 withRender:(id)p2;
	-(void) chart:(id)p0 didSelectPoint:(id)p1 inSeries:(id)p2 atIndex:(NSInteger)p3;
	-(NSUInteger) chart:(id)p0 numberOfDataPointsForSeriesAtIndex:(NSUInteger)p1;
	-(void) chart:(id)p0 didDeselectSeries:(id)p1;
	-(void) chart:(id)p0 didSelectSeries:(id)p1;
	-(id) chart:(id)p0 shapeForSeries:(id)p1 atIndex:(NSUInteger)p2;
	-(NSString *) chart:(id)p0 textForAxis:(id)p1 value:(NSObject *)p2 atIndex:(NSUInteger)p3;
	-(NSString *) chart:(id)p0 textForLabelAtPoint:(id)p1 inSeries:(id)p2 atIndex:(NSUInteger)p3;
	-(void) chart:(id)p0 trackballDidHideSelection:(NSArray *)p1;
	-(void) chart:(id)p0 trackballDidTrackSelection:(NSArray *)p1;
	-(void) chart:(id)p0 updateLegendItem:(id)p1 forSeries:(id)p2 atIndex:(NSUInteger)p3;
	-(void) chartWillPan:(id)p0;
	-(void) chartWillZoom:(id)p0;
	-(id) chart;
	-(void) setChart:(id)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TKChartWeightedCloseIndicator : TKChartFinancialIndicator {
}
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartWeightedMovingAverageIndicator : TKChartSimpleMovingAverageIndicator {
}
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKChartWilliamsPercentIndicator : TKChartFinancialIndicator {
}
	-(NSUInteger) period;
	-(void) setPeriod:(NSUInteger)p0;
	-(id) init;
	-(id) initWithSeries:(id)p0;
@end

@interface TKCoreLayoutItem : NSObject {
}
	-(void) arrange:(CGRect)p0;
	-(void) itemWasAddedInLayout:(id)p0;
	-(void) itemWasRemoved;
	-(CGSize) measure:(CGSize)p0;
	-(int) alignmentMode;
	-(void) setAlignmentMode:(int)p0;
	-(NSObject *) content;
	-(CGSize) desiredSize;
	-(UIEdgeInsets) margin;
	-(void) setMargin:(UIEdgeInsets)p0;
	-(int) sizingMode;
	-(void) setSizingMode:(int)p0;
	-(int) stretchMode;
	-(void) setStretchMode:(int)p0;
	-(id) init;
	-(id) initWithView:(UIView *)p0;
	-(id) initWithLayer:(CALayer *)p0;
	-(id) initWithLayout:(id)p0;
@end

@interface TKCoreStackLayout : NSObject {
}
	-(BOOL) addItem:(id)p0;
	-(void) arrange:(CGRect)p0;
	-(BOOL) insertItem:(id)p0 atIndex:(NSUInteger)p1;
	-(id) itemAtIndex:(NSUInteger)p0;
	-(void) itemWasAddedInLayout:(id)p0;
	-(void) itemWasRemoved;
	-(CGSize) measure:(CGSize)p0;
	-(void) removeAllItems;
	-(BOOL) removeItem:(id)p0;
	-(BOOL) removeItemAtIndex:(NSUInteger)p0;
	-(int) alignmentMode;
	-(void) setAlignmentMode:(int)p0;
	-(NSInteger) count;
	-(CGSize) desiredSize;
	-(int) itemOrder;
	-(void) setItemOrder:(int)p0;
	-(CGFloat) itemSpacing;
	-(void) setItemSpacing:(CGFloat)p0;
	-(id) lastItem;
	-(int) orientation;
	-(void) setOrientation:(int)p0;
	-(int) stretchMode;
	-(void) setStretchMode:(int)p0;
	-(id) init;
@end

@interface TKDataFormAutocompleteController : TKAutoCompleteController {
}
	-(void) autoCompleteDidStartEditing:(id)p0;
	-(void) autoComplete:(id)p0 didAddToken:(id)p1;
	-(void) autoComplete:(id)p0 didAutoComplete:(id)p1;
	-(void) autoComplete:(id)p0 didRemoveToken:(id)p1;
	-(void) autoComplete:(id)p0 didSelectToken:(id)p1;
	-(void) autoComplete:(id)p0 shouldAddToken:(id)p1;
	-(BOOL) autoComplete:(id)p0 shouldRemoveToken:(id)p1;
	-(void) autoComplete:(id)p0 suggestionListUpdated:(NSArray *)p1;
	-(void) autoComplete:(id)p0 updateTokenView:(id)p1;
	-(id) autoComplete:(id)p0 viewForToken:(id)p1;
	-(void) autoComplete:(id)p0 willShowSuggestionList:(NSArray *)p1;
	-(id) dataSource;
	-(id) editor;
	-(void) setEditor:(id)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@protocol TKDataFormDataSource
	@optional -(id) dataForm:(id)p0 propertyInGroup:(unsigned int)p1 atIndex:(unsigned int)p2;
	@optional -(NSInteger) dataForm:(id)p0 numberOfPropertiesInGroup:(unsigned int)p1;
	@optional -(void) dataForm:(id)p0 setValue:(NSObject *)p1 forProperty:(id)p2;
	@optional -(id) dataForm:(id)p0 groupAtIndex:(unsigned int)p1;
	@optional -(NSInteger) numberOfGroupsInDataForm:(id)p0;
	@optional -(NSString *) dataForm:(id)p0 titleForHeaderInGroup:(unsigned int)p1;
	@optional -(Class) dataForm:(id)p0 editorClassForProperty:(id)p1;
@end

@protocol TKDataFormDelegate
	@optional -(void) dataForm:(id)p0 didSelectEditor:(id)p1 forProperty:(id)p2;
	@optional -(void) dataForm:(id)p0 didDeselectEditor:(id)p1 forProperty:(id)p2;
	@optional -(void) dataForm:(id)p0 didEditProperty:(id)p1;
	@optional -(void) dataForm:(id)p0 didValidateProperty:(id)p1 editor:(id)p2;
	@optional -(BOOL) dataForm:(id)p0 validateProperty:(id)p1 editor:(id)p2;
	@optional -(void) dataForm:(id)p0 setupEditor:(id)p1 forProperty:(id)p2;
	@optional -(void) dataForm:(id)p0 updateEditor:(id)p1 forProperty:(id)p2;
	@optional -(void) dataForm:(id)p0 updateGroupView:(id)p1 forGroupAtIndex:(unsigned int)p2;
	@optional -(void) dataForm:(id)p0 willCommitProperty:(id)p1;
	@optional -(void) dataForn:(id)p0 didCommitProperty:(id)p1;
	@optional -(UIView *) dataForm:(id)p0 viewForHeaderInGroup:(unsigned int)p1;
	@optional -(CGFloat) dataForm:(id)p0 heightForEditorInGroup:(unsigned int)p1 atIndex:(unsigned int)p2;
	@optional -(CGFloat) dataForm:(id)p0 heightForHeaderInGroup:(unsigned int)p1;
	@optional -(id) inputAccessoryViewForDataForm:(id)p0;
	@optional -(void) dataForm:(id)p0 initViewController:(UIViewController *)p1 forEditor:(id)p2;
	@optional -(void) dataForm:(id)p0 didCollapseGroupView:(id)p1;
	@optional -(void) dataForm:(id)p0 didExpandGroupView:(id)p1;
@end

@interface TKDataFormEditorStyle : TKStyleNode {
}
	-(CGSize) accessoryArrowSize;
	-(void) setAccessoryArrowSize:(CGSize)p0;
	-(id) accessoryArrowStroke;
	-(void) setAccessoryArrowStroke:(id)p0;
	-(UIOffset) editorOffset;
	-(void) setEditorOffset:(UIOffset)p0;
	-(CGSize) feedbackImageSize;
	-(void) setFeedbackImageSize:(CGSize)p0;
	-(UIOffset) feedbackImageViewOffset;
	-(void) setFeedbackImageViewOffset:(UIOffset)p0;
	-(UIOffset) feedbackLabelOffset;
	-(void) setFeedbackLabelOffset:(UIOffset)p0;
	-(id) fill;
	-(void) setFill:(id)p0;
	-(UIOffset) imageViewOffset;
	-(void) setImageViewOffset:(UIOffset)p0;
	-(CGSize) imageViewSize;
	-(void) setImageViewSize:(CGSize)p0;
	-(UIEdgeInsets) insets;
	-(void) setInsets:(UIEdgeInsets)p0;
	-(id) separatorColor;
	-(void) setSeparatorColor:(id)p0;
	-(float) separatorLeadingSpace;
	-(void) setSeparatorLeadingSpace:(float)p0;
	-(float) separatorTrailingSpace;
	-(void) setSeparatorTrailingSpace:(float)p0;
	-(id) stroke;
	-(void) setStroke:(id)p0;
	-(int) textLabelDisplayMode;
	-(void) setTextLabelDisplayMode:(int)p0;
	-(UIOffset) textLabelOffset;
	-(void) setTextLabelOffset:(UIOffset)p0;
	-(id) init;
@end

@interface TKDataFormPropertyValidator : NSObject {
}
	-(BOOL) validateProperty:(id)p0;
	-(NSString *) errorMessage;
	-(void) setErrorMessage:(NSString *)p0;
	-(NSString *) positiveMessage;
	-(void) setPositiveMessage:(NSString *)p0;
	-(id) init;
@end

@interface TKDataFormEmailValidator : TKDataFormPropertyValidator {
}
	-(id) init;
@end

@interface TKEntity : NSObject {
}
	-(id) addGroupWithName:(NSString *)p0 propertyNames:(NSArray *)p1;
	-(void) addGroup:(id)p0;
	-(BOOL) commit;
	-(id) groupAtIndex:(unsigned int)p0;
	-(id) groupWithName:(NSString *)p0;
	-(void) insertGroup:(id)p0 atIndex:(unsigned int)p1;
	-(id) propertyWithName:(NSString *)p0;
	-(void) removeAllGroups;
	-(void) removeGroupAtIndex:(unsigned int)p0;
	-(void) removeGroup:(id)p0;
	-(void) setSourceObject:(NSObject *)p0 withPropertyNames:(NSArray *)p1;
	-(void) setSourceObject:(NSObject *)p0 withProperties:(NSArray *)p1;
	-(NSArray *) validate;
	-(NSError *) writeJSONToStream:(NSOutputStream *)p0;
	-(NSString *) writeJSONToString;
	-(id) defaultGroup;
	-(NSArray *) groups;
	-(NSArray *) properties;
	-(NSObject *) sourceObject;
	-(void) setSourceObject:(NSObject *)p0;
	-(id) init;
	-(id) initWithObject:(NSObject *)p0;
	-(id) initWithJSONString:(NSString *)p0 rootItemKeyPath:(NSString *)p1;
	-(id) initWithDataFromJSONResource:(NSString *)p0 ofType:(NSString *)p1 rootItemKeyPath:(NSString *)p2;
	-(id) initWithJSONFromURL:(NSString *)p0 rootItemKeyPath:(NSString *)p1 completion:(id)p2;
	-(id) initWithObject:(NSObject *)p0 propertyNames:(NSArray *)p1;
@end

@interface TKDataFormEntityDataSource : TKEntity {
}
	-(id) init;
	-(id) initWithObject:(NSObject *)p0;
	-(id) initWithObject:(NSObject *)p0 propertyNames:(NSArray *)p1;
	-(id) initWithJSONString:(NSString *)p0 rootItemKeyPath:(NSString *)p1;
	-(id) initWithDataFromJSONResource:(NSString *)p0 ofType:(NSString *)p1 rootItemKeyPath:(NSString *)p2;
	-(id) initWithJSONFromURL:(NSString *)p0 rootItemKeyPath:(NSString *)p1 completion:(id)p2;
@end

@interface TKDataFormGroupTitleStyle : TKStyleNode {
}
	-(id) fill;
	-(void) setFill:(id)p0;
	-(UIEdgeInsets) insets;
	-(void) setInsets:(UIEdgeInsets)p0;
	-(id) separatorColor;
	-(void) setSeparatorColor:(id)p0;
	-(float) separatorLeadingSpace;
	-(void) setSeparatorLeadingSpace:(float)p0;
	-(float) separatorTrailingSpace;
	-(void) setSeparatorTrailingSpace:(float)p0;
	-(id) stroke;
	-(void) setStroke:(id)p0;
	-(id) init;
@end

@interface TKDataFormMaximumLengthValidator : TKDataFormPropertyValidator {
}
	-(int) maximumLength;
	-(void) setMaximumLength:(int)p0;
	-(id) init;
	-(id) initWithMaximumLength:(int)p0;
@end

@interface TKDataFormMinimumLengthValidator : TKDataFormPropertyValidator {
}
	-(int) minimumLength;
	-(void) setMinimumLength:(int)p0;
	-(id) init;
	-(id) initWithMinimumLength:(int)p0;
@end

@interface TKDataFormNonEmptyValidator : TKDataFormPropertyValidator {
}
	-(id) init;
@end

@interface TKDataFormPhoneValidator : TKDataFormPropertyValidator {
}
	-(id) init;
@end

@interface TKDataFormRangeValidator : TKDataFormPropertyValidator {
}
	-(id) range;
	-(void) setRange:(id)p0;
	-(id) init;
	-(id) initWithRange:(id)p0;
@end

@protocol TKDataFormValidator
	@required @property (nonatomic, assign, readonly) NSString * positiveMessage;
	@required @property (nonatomic, assign, readonly) NSString * errorMessage;
	@required -(BOOL) validateProperty:(id)p0;
@end

@interface TKDataFormViewController : UIViewController {
}
	-(id) dataForm;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TKDataSource : NSObject {
}
	-(void) addFilterDescriptor:(id)p0;
	-(void) addGroupDescriptor:(id)p0;
	-(void) addSortDescriptor:(id)p0;
	-(NSArray *) autoComplete:(id)p0 completionForPrefix:(NSString *)p1;
	-(void) autoComplete:(id)p0 completionsForString:(NSString *)p1;
	-(void) listView:(id)p0 didReorderItemFromIndexPath:(NSIndexPath *)p1 toIndexPath:(NSIndexPath *)p2;
	-(void) enumerate:(id)p0;
	-(void) filter:(id)p0;
	-(NSArray *) filterDescriptors;
	-(void) filterWithQuery:(NSString *)p0;
	-(void) formatText:(id)p0;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(UICollectionViewCell *) collectionView:(UICollectionView *)p0 cellForItemAtIndexPath:(NSIndexPath *)p1;
	-(NSInteger) collectionView:(UICollectionView *)p0 numberOfItemsInSection:(NSInteger)p1;
	-(void) group:(id)p0;
	-(void) group:(id)p0 comparator:(id)p1;
	-(NSArray *) groupDescriptors;
	-(void) groupWithKey:(NSString *)p0;
	-(void) groupWithKey:(NSString *)p0 comparator:(id)p1;
	-(void) loadDataFromJSONResource:(NSString *)p0 ofType:(NSString *)p1 rootItemKeyPath:(NSString *)p2;
	-(void) loadDataFromJSONString:(NSString *)p0 rootItemKeyPath:(NSString *)p1;
	-(void) loadDataFromURL:(NSString *)p0 dataFormat:(int)p1 rootItemKeyPath:(NSString *)p2 completion:(id)p3;
	-(void) map:(id)p0;
	-(void) moveItemAtIndex:(NSInteger)p0 toIndex:(NSInteger)p1;
	-(NSObject *) reduce:(NSObject *)p0 with:(id)p1;
	-(void) reloadData;
	-(void) removeAllFilterDescriptors;
	-(void) removeAllGroupDescriptors;
	-(void) removeAllSortDescriptors;
	-(void) removeFilterDescriptor:(id)p0;
	-(void) removeGroupDescriptor:(id)p0;
	-(void) removeSortDescriptor:(id)p0;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(void) setDataSourceFor:(UIView *)p0;
	-(void) setDelegateFor:(UIView *)p0;
	-(void) sort:(id)p0;
	-(NSArray *) sortDescriptors;
	-(void) sortWithKey:(NSString *)p0 ascending:(BOOL)p1;
	-(NSString *) textFromItem:(NSObject *)p0 inGroup:(id)p1;
	-(NSObject *) valueForItem:(NSObject *)p0 inGroup:(id)p1;
	-(BOOL) allowItemsReorder;
	-(void) setAllowItemsReorder:(BOOL)p0;
	-(NSObject *) currentItem;
	-(void) setCurrentItem:(NSObject *)p0;
	-(NSString *) displayKey;
	-(void) setDisplayKey:(NSString *)p0;
	-(NSFormatter *) formatter;
	-(void) setFormatter:(NSFormatter *)p0;
	-(NSString *) groupItemSourceKey;
	-(void) setGroupItemSourceKey:(NSString *)p0;
	-(NSObject *) itemSource;
	-(void) setItemSource:(NSObject *)p0;
	-(NSArray *) items;
	-(id) settings;
	-(NSString *) valueKey;
	-(void) setValueKey:(NSString *)p0;
	-(id) init;
	-(id) initWithItemSource:(NSObject *)p0;
	-(id) initWithArray:(NSArray *)p0;
	-(id) initWithArray:(NSArray *)p0 displayKey:(NSString *)p1;
	-(id) initWithArray:(NSArray *)p0 displayKey:(NSString *)p1 valueKey:(NSString *)p2;
	-(id) initWithJSONString:(NSString *)p0;
	-(id) initWithDataFromURL:(NSString *)p0 dataFormat:(int)p1 rootItemKeyPath:(NSString *)p2 completion:(id)p3;
	-(id) initWithDataFromJSONResource:(NSString *)p0 ofType:(NSString *)p1 rootItemKeyPath:(NSString *)p2;
@end

@interface TKDataSourceAutoCompleteSettings : NSObject {
}
	-(void) createToken:(id)p0;
	-(int) completionMode;
	-(void) setCompletionMode:(int)p0;
	-(UIColor *) highlightColor;
	-(void) setHighlightColor:(UIColor *)p0;
	-(BOOL) highlightMatch;
	-(void) setHighlightMatch:(BOOL)p0;
	-(NSString *) valueKey;
	-(void) setValueKey:(NSString *)p0;
	-(id) init;
@end

@interface TKDataSourceCalendarSettings : NSObject {
}
	-(UIColor *) defaultEventColor;
	-(void) setDefaultEventColor:(UIColor *)p0;
	-(NSString *) endDateKey;
	-(void) setEndDateKey:(NSString *)p0;
	-(NSString *) eventColorKey;
	-(void) setEventColorKey:(NSString *)p0;
	-(NSString *) startDateKey;
	-(void) setStartDateKey:(NSString *)p0;
	-(id) init;
@end

@interface TKDataSourceChartSettings : NSObject {
}
	-(void) createPoint:(id)p0;
	-(void) createSeries:(id)p0;
	-(id) init;
@end

@interface TKDataSourceCollectionViewSettings : NSObject {
}
	-(void) createCell:(id)p0;
	-(void) initCell:(id)p0;
	-(id) init;
@end

@interface TKDataSourceFilterDescriptor : NSObject {
}
	-(BOOL) evaluate:(NSObject *)p0;
	-(id) filterBlock;
	-(NSString *) query;
	-(id) init;
	-(id) initWithQuery:(NSString *)p0;
	-(id) initWithBlock:(id)p0;
@end

@interface TKDataSourceGroup : NSObject {
}
	-(NSString *) displayKey;
	-(void) setDisplayKey:(NSString *)p0;
	-(NSArray *) items;
	-(NSObject *) key;
	-(void) setKey:(NSObject *)p0;
	-(NSString *) valueKey;
	-(void) setValueKey:(NSString *)p0;
	-(id) init;
	-(id) initWithItems:(NSArray *)p0 valueKey:(NSString *)p1 displayKey:(NSString *)p2;
@end

@interface TKDataSourceGroupDescriptor : NSObject {
}
	-(NSObject *) keyForItem:(NSObject *)p0;
	-(id) comparator;
	-(id) keyForItemBlock;
	-(NSString *) propertyName;
	-(id) init;
	-(id) initWithProperty:(NSString *)p0;
	-(id) initWithProperty:(NSString *)p0 Comparator:(id)p1;
	-(id) initWithBlock:(id)p0 comparator:(id)p1;
	-(id) initWithBlock:(id)p0;
@end

@interface TKDataSourceListViewSettings : NSObject {
}
	-(void) createCell:(id)p0;
	-(void) createSupplementaryView:(id)p0;
	-(void) initCell:(id)p0;
	-(void) initFooter:(id)p0;
	-(void) initHeader:(id)p0;
	-(Class) defaultCellClass;
	-(void) setDefaultCellClass:(Class)p0;
	-(NSString *) defaultCellID;
	-(void) setDefaultCellID:(NSString *)p0;
	-(id) init;
@end

@interface TKDataSourceSettings : NSObject {
}
	-(id) autocomplete;
	-(id) calendar;
	-(id) chart;
	-(id) collectionView;
	-(id) listView;
	-(id) tableView;
	-(id) init;
@end

@interface TKDataSourceSortDescriptor : NSObject {
}
	-(NSSortDescriptor *) descriptor;
	-(BOOL) ascending;
	-(id) comparator;
	-(NSString *) propertyName;
	-(id) init;
	-(id) initWithProperty:(NSString *)p0 ascending:(BOOL)p1;
	-(id) initWithComparator:(id)p0;
@end

@interface TKDataSourceTableViewSettings : NSObject {
}
	-(void) createCell:(id)p0;
	-(void) initCell:(id)p0;
	-(id) init;
@end

@interface TKDateRange : NSObject {
}
	-(BOOL) containsDate:(NSDate *)p0;
	-(void) normalize;
	-(NSDate *) endDate;
	-(void) setEndDate:(NSDate *)p0;
	-(NSDate *) startDate;
	-(void) setStartDate:(NSDate *)p0;
	-(id) init;
	-(id) initWithStart:(NSDate *)p0 end:(NSDate *)p1;
@end

@protocol TKDrawing
	@optional @property (nonatomic, assign) UIEdgeInsets insets;
	@optional -(void) drawInContext:(id)p0 withRect:(CGRect)p1;
	@optional -(void) drawInContext:(id)p0 withPath:(id)p1;
@end

@interface TKEntityProperty : NSObject {
}
	-(BOOL) commit;
	-(BOOL) validate;
	-(NSString *) displayName;
	-(void) setDisplayName:(NSString *)p0;
	-(Class) editorClass;
	-(void) setEditorClass:(Class)p0;
	-(UIImage *) errorImage;
	-(void) setErrorImage:(UIImage *)p0;
	-(NSString *) errorMessage;
	-(void) setErrorMessage:(NSString *)p0;
	-(NSFormatter *) formatter;
	-(void) setFormatter:(NSFormatter *)p0;
	-(NSString *) groupName;
	-(void) setGroupName:(NSString *)p0;
	-(BOOL) hidden;
	-(void) setHidden:(BOOL)p0;
	-(NSString *) hintText;
	-(void) setHintText:(NSString *)p0;
	-(UIImage *) image;
	-(void) setImage:(UIImage *)p0;
	-(unsigned int) index;
	-(void) setIndex:(unsigned int)p0;
	-(BOOL) isValid;
	-(id) layoutInfo;
	-(void) setLayoutInfo:(id)p0;
	-(NSString *) name;
	-(NSObject *) originalValue;
	-(id) owner;
	-(BOOL) pickersUseIndexValue;
	-(void) setPickersUseIndexValue:(BOOL)p0;
	-(UIImage *) positiveImage;
	-(void) setPositiveImage:(UIImage *)p0;
	-(NSString *) positiveMessage;
	-(void) setPositiveMessage:(NSString *)p0;
	-(Class) propertyClass;
	-(id) range;
	-(void) setRange:(id)p0;
	-(BOOL) readOnly;
	-(void) setReadOnly:(BOOL)p0;
	-(BOOL) required;
	-(void) setRequired:(BOOL)p0;
	-(int) type;
	-(void) setType:(int)p0;
	-(NSArray *) validators;
	-(void) setValidators:(NSArray *)p0;
	-(NSObject *) valueCandidate;
	-(void) setValueCandidate:(NSObject *)p0;
	-(NSArray *) valuesProvider;
	-(void) setValuesProvider:(NSArray *)p0;
	-(BOOL) wasValidated;
	-(id) init;
	-(id) initWithEntity:(id)p0 forPropertyName:(NSString *)p1;
@end

@interface TKEntityPropertyGroup : NSObject {
}
	-(void) addProperty:(id)p0;
	-(void) insertProperty:(id)p0 atIndex:(unsigned int)p1;
	-(id) propertyAtIndex:(unsigned int)p0;
	-(id) propertyWithName:(NSString *)p0;
	-(void) removeAllProperties;
	-(void) removePropertyAtIndex:(unsigned int)p0;
	-(void) removeProperty:(id)p0;
	-(BOOL) hidden;
	-(void) setHidden:(BOOL)p0;
	-(NSString *) name;
	-(void) setName:(NSString *)p0;
	-(id) owner;
	-(void) setOwner:(id)p0;
	-(NSArray *) properties;
	-(id) init;
	-(id) initWithName:(NSString *)p0 properties:(NSArray *)p1;
@end

@interface TKExamplesDetailViewController : UIViewController {
}
	-(id) example;
	-(void) setExample:(id)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TKExamplesExampleInfo : NSObject {
}
	-(NSString *) exampleClass;
	-(void) setExampleClass:(NSString *)p0;
	-(NSArray *) examples;
	-(void) setExamples:(NSArray *)p0;
	-(NSString *) title;
	-(void) setTitle:(NSString *)p0;
	-(UIViewController *) viewControllerForExample;
	-(id) init;
	-(id) initWithTitle:(NSString *)p0 examples:(NSArray *)p1;
@end

@interface TKExamplesExampleViewController : UIViewController {
}
	-(void) addOption:(NSString *)p0 selector:(SEL)p1;
	-(void) addOption:(NSString *)p0 selector:(SEL)p1 inSection:(NSString *)p2;
	-(void) addOption:(NSString *)p0 action:(id)p1;
	-(void) addOption:(NSString *)p0 inSection:(NSString *)p1 withAction:(id)p2;
	-(void) didSelectOption:(id)p0 atIndex:(NSUInteger)p1;
	-(void) setSelectedOption:(NSInteger)p0 inSection:(NSInteger)p1;
	-(NSArray *) options;
	-(NSArray *) sections;
	-(NSUInteger) selectedOption;
	-(void) setSelectedOption:(NSUInteger)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TKExamplesMasterViewController : UITableViewController {
}
	-(id) dataSource;
	-(void) setDataSource:(id)p0;
	-(id) example;
	-(void) setExample:(id)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithExample:(id)p0;
@end

@interface TKExamplesOptionInfo : NSObject {
}
	-(void) select;
	-(BOOL) isSelected;
	-(id) owner;
	-(void) setOwner:(id)p0;
	-(SEL) selector;
	-(void) setSelector:(SEL)p0;
	-(NSString *) title;
	-(void) setTitle:(NSString *)p0;
	-(id) init;
	-(id) initWithTitle:(NSString *)p0 selector:(SEL)p1;
@end

@interface TKExamplesSectionInfo : NSObject {
}
	-(NSMutableArray *) options;
	-(void) setOptions:(NSMutableArray *)p0;
	-(NSInteger) selectedOption;
	-(void) setSelectedOption:(NSInteger)p0;
	-(NSString *) title;
	-(void) setTitle:(NSString *)p0;
	-(id) init;
	-(id) initWithTitle:(NSString *)p0;
@end

@interface TKExamplesSplitViewController : UISplitViewController {
}
	-(id) detailController;
	-(id) masterController;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TKFeedback : NSObject {
}
	-(id) init;
@end

@interface TKFeedbackController : UIViewController {
}
	-(void) sendFeedback;
	-(void) showFeedback;
	-(UIViewController *) contentController;
	-(void) setContentController:(UIViewController *)p0;
	-(id) dataSource;
	-(void) setDataSource:(id)p0;
	-(BOOL) showOnShake;
	-(void) setShowOnShake:(BOOL)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithContentController:(UIViewController *)p0;
@end

@protocol TKFeedbackDataSource
	@optional @property (nonatomic, copy) NSString * userName;
	@optional @property (nonatomic, copy) NSString * userEmail;
	@optional -(void) feedbackItems:(id)p0;
	@optional -(void) addFeedback:(id)p0 completionHandler:(id)p1;
	@optional -(void) editWithKey:(NSString *)p0 state:(NSString *)p1 completionHandler:(id)p2;
	@optional -(void) deleteWithKey:(NSString *)p0 completionHandler:(id)p1;
	@optional -(void) feedbackItemsByState:(NSString *)p0 completionHandler:(id)p1;
	@optional -(void) feedbackItemsByState:(NSString *)p0 skip:(NSInteger)p1 completionHandler:(id)p2;
	@optional -(void) imageForKey:(NSString *)p0 completionHandler:(id)p1;
	@optional -(void) subItemsForKey:(NSString *)p0 completionHandler:(id)p1;
	@optional -(void) addSubItemForKey:(NSString *)p0 subItem:(id)p1 completionHandler:(id)p2;
@end

@interface TKFeedbackItem : NSObject {
}
	-(void) addSubItem:(id)p0;
	-(void) insertSubItem:(id)p0 atIndex:(NSUInteger)p1;
	-(NSString *) author;
	-(void) setAuthor:(NSString *)p0;
	-(NSDate *) createdAt;
	-(void) setCreatedAt:(NSDate *)p0;
	-(UIImage *) image;
	-(void) setImage:(UIImage *)p0;
	-(NSString *) key;
	-(void) setKey:(NSString *)p0;
	-(NSDate *) modifiedAt;
	-(void) setModifiedAt:(NSDate *)p0;
	-(NSString *) state;
	-(void) setState:(NSString *)p0;
	-(NSArray *) subItems;
	-(NSString *) text;
	-(void) setText:(NSString *)p0;
	-(id) init;
@end

@interface TKFill : NSObject {
}
	-(void) drawFillInContext:(id)p0 withRect:(CGRect)p1;
	-(void) drawFillInContext:(id)p0 withPath:(id)p1;
	-(CGFloat) alpha;
	-(void) setAlpha:(CGFloat)p0;
	-(CGFloat) cornerRadius;
	-(void) setCornerRadius:(CGFloat)p0;
	-(NSUInteger) corners;
	-(void) setCorners:(NSUInteger)p0;
	-(UIEdgeInsets) insets;
	-(void) setInsets:(UIEdgeInsets)p0;
	-(CGFloat) shadowBlur;
	-(void) setShadowBlur:(CGFloat)p0;
	-(UIColor *) shadowColor;
	-(void) setShadowColor:(UIColor *)p0;
	-(CGSize) shadowOffset;
	-(void) setShadowOffset:(CGSize)p0;
	-(id) init;
@end

@protocol TKGaugeDelegate
	@optional -(void) gauge:(id)p0 valueChanged:(CGFloat)p1 forScale:(id)p2;
	@optional -(NSString *) gauge:(id)p0 textForLabel:(NSObject *)p1;
@end

@interface TKGaugeIndicator : CALayer {
}
	-(BOOL) allowTouch;
	-(void) setAllowTouch:(BOOL)p0;
	-(id) fill;
	-(void) setFill:(id)p0;
	-(id) owner;
	-(void) setOwner:(id)p0;
	-(id) stroke;
	-(void) setStroke:(id)p0;
	-(CGFloat) value;
	-(void) setValue:(CGFloat)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TKGaugeLabels : NSObject {
}
	-(UIColor *) color;
	-(void) setColor:(UIColor *)p0;
	-(NSInteger) count;
	-(void) setCount:(NSInteger)p0;
	-(UIFont *) font;
	-(void) setFont:(UIFont *)p0;
	-(NSFormatter *) formatter;
	-(void) setFormatter:(NSFormatter *)p0;
	-(BOOL) hidden;
	-(void) setHidden:(BOOL)p0;
	-(NSString *) labelFormat;
	-(void) setLabelFormat:(NSString *)p0;
	-(CGFloat) offset;
	-(void) setOffset:(CGFloat)p0;
	-(int) position;
	-(void) setPosition:(int)p0;
	-(id) init;
@end

@interface TKGaugeScale : CALayer {
}
	-(void) addIndicator:(id)p0;
	-(void) addSegment:(id)p0;
	-(CGFloat) denormalize:(CGFloat)p0;
	-(id) indicatorAtIndex:(NSInteger)p0;
	-(void) insertSegment:(id)p0 atIndex:(NSInteger)p1;
	-(void) insetIndicator:(id)p0 atIndex:(NSInteger)p1;
	-(CGFloat) locationForValue:(CGFloat)p0;
	-(void) removeAllIndicators;
	-(void) removeAllSegments;
	-(void) removeIndicator:(id)p0;
	-(void) removeIndicatorAtIndex:(NSInteger)p0;
	-(void) removeSegment:(id)p0;
	-(void) removeSegmentAtIndex:(NSInteger)p0;
	-(id) segmentAtIndex:(NSInteger)p0;
	-(NSString *) textForValue:(CGFloat)p0;
	-(CGFloat) valueForPoint:(CGPoint)p0;
	-(id) fill;
	-(void) setFill:(id)p0;
	-(NSArray *) indicators;
	-(id) labels;
	-(id) owner;
	-(void) setOwner:(id)p0;
	-(id) range;
	-(void) setRange:(id)p0;
	-(NSArray *) segments;
	-(id) stroke;
	-(void) setStroke:(id)p0;
	-(id) ticks;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithRange:(id)p0;
	-(id) initWithMinimum:(NSObject *)p0 maximum:(NSObject *)p1;
@end

@interface TKGaugeLinearScale : TKGaugeScale {
}
	-(CGFloat) endPoint;
	-(void) setEndPoint:(CGFloat)p0;
	-(CGFloat) offset;
	-(void) setOffset:(CGFloat)p0;
	-(CGFloat) startPoint;
	-(void) setStartPoint:(CGFloat)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithRange:(id)p0;
	-(id) initWithMinimum:(NSObject *)p0 maximum:(NSObject *)p1;
@end

@interface TKGaugeNeedle : TKGaugeIndicator {
}
	-(void) setValueAnimated:(CGFloat)p0 withDuration:(CGFloat)p1 mediaTimingFunction:(NSString *)p2;
	-(id) circleFill;
	-(void) setCircleFill:(id)p0;
	-(CGFloat) circleInnerRadius;
	-(void) setCircleInnerRadius:(CGFloat)p0;
	-(CGFloat) circleRadius;
	-(void) setCircleRadius:(CGFloat)p0;
	-(id) circleStroke;
	-(void) setCircleStroke:(id)p0;
	-(CGFloat) length;
	-(void) setLength:(CGFloat)p0;
	-(CGFloat) offset;
	-(void) setOffset:(CGFloat)p0;
	-(CGFloat) topWidth;
	-(void) setTopWidth:(CGFloat)p0;
	-(CGFloat) width;
	-(void) setWidth:(CGFloat)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithValue:(CGFloat)p0;
	-(id) initWithValue:(CGFloat)p0 length:(CGFloat)p1;
@end

@interface TKGaugeRadialScale : TKGaugeScale {
}
	-(CGFloat) endAngle;
	-(void) setEndAngle:(CGFloat)p0;
	-(CGFloat) radius;
	-(void) setRadius:(CGFloat)p0;
	-(CGFloat) startAngle;
	-(void) setStartAngle:(CGFloat)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithRange:(id)p0;
	-(id) initWithMinimum:(NSObject *)p0 maximum:(NSObject *)p1;
@end

@interface TKGaugeSegment : CALayer {
}
	-(void) setRangeAnimated:(id)p0 withDuration:(CGFloat)p1 mediaTimingFunction:(NSString *)p2;
	-(BOOL) allowTouch;
	-(void) setAllowTouch:(BOOL)p0;
	-(int) Cap;
	-(void) setCap:(int)p0;
	-(id) fill;
	-(void) setFill:(id)p0;
	-(CGFloat) location;
	-(void) setLocation:(CGFloat)p0;
	-(id) owner;
	-(void) setOwner:(id)p0;
	-(id) range;
	-(void) setRange:(id)p0;
	-(id) stroke;
	-(void) setStroke:(id)p0;
	-(CGFloat) width;
	-(void) setWidth:(CGFloat)p0;
	-(CGFloat) width2;
	-(void) setWidth2:(CGFloat)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithRange:(id)p0;
	-(id) initWithMinimum:(NSObject *)p0 maximum:(NSObject *)p1;
@end

@interface TKGaugeTicks : NSObject {
}
	-(BOOL) hidden;
	-(void) setHidden:(BOOL)p0;
	-(int) majorTicksCount;
	-(void) setMajorTicksCount:(int)p0;
	-(id) majorTicksFill;
	-(void) setMajorTicksFill:(id)p0;
	-(CGFloat) majorTicksLength;
	-(void) setMajorTicksLength:(CGFloat)p0;
	-(id) majorTicksStroke;
	-(void) setMajorTicksStroke:(id)p0;
	-(int) minorTicksCount;
	-(void) setMinorTicksCount:(int)p0;
	-(id) mimorTicksFill;
	-(void) setMimorTicksFill:(id)p0;
	-(CGFloat) minorTicksLength;
	-(void) setMinorTicksLength:(CGFloat)p0;
	-(id) mimorTicksStroke;
	-(void) setMimorTicksStroke:(id)p0;
	-(CGFloat) offset;
	-(void) setOffset:(CGFloat)p0;
	-(int) position;
	-(void) setPosition:(int)p0;
	-(id) init;
@end

@interface TKGradientFill : TKFill {
}
	-(NSArray *) colors;
	-(void) setColors:(NSArray *)p0;
	-(NSArray *) locations;
	-(void) setLocations:(NSArray *)p0;
	-(id) init;
	-(id) initWithColors:(NSArray *)p0;
	-(id) initWithColors:(NSArray *)p0 cornerRadius:(CGFloat)p1;
	-(id) initWithColors:(NSArray *)p0 locations:(NSArray *)p1;
	-(id) initWithColors:(NSArray *)p0 locations:(NSArray *)p1 cornerRadius:(CGFloat)p2;
@end

@protocol TKLayout
	@optional @property (nonatomic, assign) CGRect frame;
	@optional @property (nonatomic, assign) int orientation;
	@optional @property (nonatomic, assign, readonly) NSArray * arrangedViews;
	@optional -(void) addArrangedView:(UIView *)p0;
	@optional -(void) insertArrangedView:(UIView *)p0 atIndex:(unsigned int)p1;
	@optional -(void) removeArrangedView:(UIView *)p0;
	@optional -(void) removeAllArrangedViews;
	@optional -(void) layoutArrangedViews;
	@optional -(CGSize) measurePreferredSizeThatFitsSize:(CGSize)p0;
@end

@interface TKGridLayout : NSObject {
}
	-(void) addArrangedView:(UIView *)p0;
	-(void) addDefinition:(id)p0;
	-(id) addDefinitionForView:(UIView *)p0 atRow:(NSNumber *)p1 column:(NSNumber *)p2 rowSpan:(int)p3 columnSpan:(int)p4;
	-(id) definitionForView:(UIView *)p0;
	-(void) insertArrangedView:(UIView *)p0 atIndex:(unsigned int)p1;
	-(void) layoutArrangedViews;
	-(CGSize) measurePreferredSizeThatFitsSize:(CGSize)p0;
	-(void) removeAllArrangedViews;
	-(void) removeAllDefinitions;
	-(void) removeArrangedView:(UIView *)p0;
	-(void) removeDefinition:(id)p0;
	-(void) setHeight:(CGFloat)p0 forRow:(int)p1;
	-(void) setWidth:(CGFloat)p0 forColumn:(int)p1;
	-(NSArray *) arrangedViews;
	-(NSArray *) definitions;
	-(CGRect) frame;
	-(void) setFrame:(CGRect)p0;
	-(CGFloat) horizontalSpacing;
	-(void) setHorizontalSpacing:(CGFloat)p0;
	-(int) orientation;
	-(void) setOrientation:(int)p0;
	-(CGFloat) verticalSpacing;
	-(void) setVerticalSpacing:(CGFloat)p0;
	-(id) init;
	-(id) initWithFrame:(CGRect)p0;
@end

@interface TKGridLayoutCellDefinition : NSObject {
}
	-(int) alignment;
	-(void) setAlignment:(int)p0;
	-(NSNumber *) column;
	-(void) setColumn:(NSNumber *)p0;
	-(unsigned int) columnSpan;
	-(void) setColumnSpan:(unsigned int)p0;
	-(UIOffset) contentOffset;
	-(void) setContentOffset:(UIOffset)p0;
	-(NSNumber *) row;
	-(void) setRow:(NSNumber *)p0;
	-(unsigned int) rowSpan;
	-(void) setRowSpan:(unsigned int)p0;
	-(UIView *) view;
	-(void) setView:(UIView *)p0;
	-(id) init;
	-(id) initWithView:(UIView *)p0;
	-(id) initWithView:(UIView *)p0 atRow:(NSNumber *)p1 column:(NSNumber *)p2;
	-(id) initWithView:(UIView *)p0 atRow:(NSNumber *)p1 column:(NSNumber *)p2 rowSpan:(int)p3 colSpan:(int)p4;
@end

@interface TKImageFill : TKFill {
}
	-(UIImage *) image;
	-(void) setImage:(UIImage *)p0;
	-(int) resizingMode;
	-(void) setResizingMode:(int)p0;
	-(id) init;
	-(id) initWithImage:(UIImage *)p0;
	-(id) initWithImage:(UIImage *)p0 cornerRadius:(CGFloat)p1;
@end

@interface TKLayer : CALayer {
}
	-(CGSize) sizeThatFits:(CGSize)p0;
	-(void) sizeToFit;
	-(id) fill;
	-(void) setFill:(id)p0;
	-(id) shape;
	-(void) setShape:(id)p0;
	-(id) stroke;
	-(void) setStroke:(id)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TKLayoutInfo : NSObject {
}
	-(unsigned int) column;
	-(void) setColumn:(unsigned int)p0;
	-(unsigned int) columnSpan;
	-(void) setColumnSpan:(unsigned int)p0;
	-(unsigned int) row;
	-(void) setRow:(unsigned int)p0;
	-(unsigned int) rowSpan;
	-(void) setRowSpan:(unsigned int)p0;
	-(id) init;
	-(id) initWithRow:(unsigned int)p0 column:(unsigned int)p1 rowSpan:(unsigned int)p2 columnSpan:(unsigned int)p3;
@end

@interface TKLinearGradientFill : TKGradientFill {
}
	-(CGPoint) endPoint;
	-(void) setEndPoint:(CGPoint)p0;
	-(CGPoint) startPoint;
	-(void) setStartPoint:(CGPoint)p0;
	-(id) init;
	-(id) initWithColors:(NSArray *)p0 startPoint:(CGPoint)p1 endPoint:(CGPoint)p2;
	-(id) initWithColors:(NSArray *)p0 locations:(NSArray *)p1 startPoint:(CGPoint)p2 endPoint:(CGPoint)p3;
@end

@protocol TKListViewDataSource
	@optional -(int) listView:(id)p0 numberOfItemsInSection:(int)p1;
	@optional -(id) listView:(id)p0 cellForItemAtIndexPath:(NSIndexPath *)p1;
	@optional -(int) numberOfSectionsInListView:(id)p0;
	@optional -(id) listView:(id)p0 viewForSupplementaryElementOfKind:(NSString *)p1 atIndexPath:(NSIndexPath *)p2;
@end

@protocol TKListViewDelegate
	@optional -(BOOL) listView:(id)p0 shouldHighlightItemAtIndexPath:(NSIndexPath *)p1;
	@optional -(void) listView:(id)p0 didHighlightItemAtIndexPath:(NSIndexPath *)p1;
	@optional -(void) listView:(id)p0 didUnhighlightItemAtIndexPath:(NSIndexPath *)p1;
	@optional -(BOOL) listView:(id)p0 shouldSelectItemAtIndexPath:(NSIndexPath *)p1;
	@optional -(BOOL) listView:(id)p0 shouldDeselectItemAtIndexPath:(NSIndexPath *)p1;
	@optional -(void) listView:(id)p0 didSelectItemAtIndexPath:(NSIndexPath *)p1;
	@optional -(void) listView:(id)p0 didDeselectItemAtIndexPath:(NSIndexPath *)p1;
	@optional -(void) listView:(id)p0 willReorderItemAtIndexPath:(NSIndexPath *)p1;
	@optional -(void) listView:(id)p0 didReorderItemFromIndexPath:(NSIndexPath *)p1 toIndexPath:(NSIndexPath *)p2;
	@optional -(BOOL) listView:(id)p0 shouldSwipeCell:(id)p1 atIndexPath:(NSIndexPath *)p2;
	@optional -(void) listView:(id)p0 didSwipeCell:(id)p1 atIndexPath:(NSIndexPath *)p2 withOffset:(CGPoint)p3;
	@optional -(void) listView:(id)p0 didFinishSwipeCell:(id)p1 atIndexPath:(NSIndexPath *)p2 withOffset:(CGPoint)p3;
	@optional -(void) listView:(id)p0 didPullWithOffset:(CGFloat)p1;
	@optional -(void) listView:(id)p0 didLongPressCell:(id)p1 atIndexPath:(NSIndexPath *)p2;
	@optional -(BOOL) listView:(id)p0 shouldLoadMoreDataAtIndexPath:(NSIndexPath *)p1;
	@optional -(BOOL) listViewShouldRefreshOnPull:(id)p0;
	@optional -(void) willReloadData:(id)p0;
	@optional -(void) didReloadData:(id)p0;
@end

@interface TKListViewLinearLayout : UICollectionViewLayout {
}
	-(CGFloat) animationDuration;
	-(void) setAnimationDuration:(CGFloat)p0;
	-(id) delegate;
	-(void) setDelegate:(id)p0;
	-(BOOL) dynamicItemSize;
	-(void) setDynamicItemSize:(BOOL)p0;
	-(CGSize) footerReferenceSize;
	-(void) setFooterReferenceSize:(CGSize)p0;
	-(CGSize) headerReferenceSize;
	-(void) setHeaderReferenceSize:(CGSize)p0;
	-(int) itemAlignment;
	-(void) setItemAlignment:(int)p0;
	-(int) itemAppearAnimation;
	-(void) setItemAppearAnimation:(int)p0;
	-(int) itemDeleteAnimation;
	-(void) setItemDeleteAnimation:(int)p0;
	-(int) itemInsertAnimation;
	-(void) setItemInsertAnimation:(int)p0;
	-(CGSize) itemSize;
	-(void) setItemSize:(CGSize)p0;
	-(CGFloat) itemSpacing;
	-(void) setItemSpacing:(CGFloat)p0;
	-(int) scrollDirection;
	-(void) setScrollDirection:(int)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TKListViewGridLayout : TKListViewLinearLayout {
}
	-(CGFloat) lineSpacing;
	-(void) setLineSpacing:(CGFloat)p0;
	-(NSInteger) spanCount;
	-(void) setSpanCount:(NSInteger)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@protocol TKListViewLinearLayoutDelegate
	@optional -(CGSize) listView:(id)p0 layout:(id)p1 sizeForItemAtIndexPath:(NSIndexPath *)p2;
@end

@interface TKListViewStaggeredLayout : TKListViewGridLayout {
}
	-(BOOL) alignLastLine;
	-(void) setAlignLastLine:(BOOL)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TKMutableArray : NSObject {
}
	-(void) addObject:(NSObject *)p0;
	-(NSObject *) objectAtIndex:(NSUInteger)p0;
	-(NSObject *) objectAtIndexedSubscript:(NSUInteger)p0;
	-(void) removeObject:(NSObject *)p0;
	-(void) removeObjectAtIndex:(NSUInteger)p0;
	-(void) setObject:(NSObject *)p0 atIndexedSubscript:(NSUInteger)p1;
	-(NSArray *) array;
	-(NSUInteger) count;
	-(NSObject *) firstObject;
	-(NSObject *) lastObject;
	-(id) init;
	-(id) initWithArray:(NSArray *)p0;
@end

@interface TKPlatformFeedbackSource : NSObject {
}
	-(void) addFeedback:(id)p0 completionHandler:(id)p1;
	-(void) addSubItemForKey:(NSString *)p0 subItem:(id)p1 completionHandler:(id)p2;
	-(void) deleteWithKey:(NSString *)p0 completionHandler:(id)p1;
	-(void) editWithKey:(NSString *)p0 state:(NSString *)p1 completionHandler:(id)p2;
	-(void) feedbackItems:(id)p0;
	-(void) feedbackItemsByState:(NSString *)p0 completionHandler:(id)p1;
	-(void) feedbackItemsByState:(NSString *)p0 skip:(NSInteger)p1 completionHandler:(id)p2;
	-(void) imageForKey:(NSString *)p0 completionHandler:(id)p1;
	-(void) subItemsForKey:(NSString *)p0 completionHandler:(id)p1;
	-(NSString *) apiKey;
	-(void) setApiKey:(NSString *)p0;
	-(NSString *) UID;
	-(void) setUID:(NSString *)p0;
	-(NSString *) userEmail;
	-(void) setUserEmail:(NSString *)p0;
	-(NSString *) userName;
	-(void) setUserName:(NSString *)p0;
	-(id) init;
	-(id) initWithKey:(NSString *)p0;
	-(id) initWithKey:(NSString *)p0 uid:(NSString *)p1;
@end

@interface TKPredefinedShape : TKShape {
}
	-(int) type;
	-(id) init;
	-(id) initWithType:(int)p0 andSize:(CGSize)p1;
@end

@interface TKRadialGradientFill : TKGradientFill {
}
	-(CGPoint) endCenter;
	-(void) setEndCenter:(CGPoint)p0;
	-(CGFloat) endRadius;
	-(void) setEndRadius:(CGFloat)p0;
	-(int) gradientRadiusType;
	-(void) setGradientRadiusType:(int)p0;
	-(CGPoint) startCenter;
	-(void) setStartCenter:(CGPoint)p0;
	-(CGFloat) startRadius;
	-(void) setStartRadius:(CGFloat)p0;
	-(id) init;
	-(id) initWithColors:(NSArray *)p0 startCenter:(CGPoint)p1 startRadius:(CGFloat)p2 endCenter:(CGPoint)p3 endRadius:(CGFloat)p4;
	-(id) initWithColors:(NSArray *)p0 startCenter:(CGPoint)p1 startRadius:(CGFloat)p2 endCenter:(CGPoint)p3 endRadius:(CGFloat)p4 radiusType:(int)p5;
@end

@interface TKRange : NSObject {
}
	-(void) setMinimum:(NSObject *)p0 andMaximum:(NSObject *)p1;
	-(void) setMinimum:(NSObject *)p0 andMaximum:(NSObject *)p1 calcWithCurrent:(BOOL)p2;
	-(NSObject *) maximum;
	-(void) setMaximum:(NSObject *)p0;
	-(NSObject *) minimum;
	-(void) setMinimum:(NSObject *)p0;
	-(id) init;
	-(id) initWithMinimum:(NSObject *)p0 andMaximum:(NSObject *)p1;
@end

@interface TKSideDrawerController : UIViewController {
}
	-(void) addSideDrawer:(id)p0;
	-(id) addSideDrawerAtPosition:(int)p0;
	-(void) removeAllSideDrawers;
	-(void) removeSideDrawer:(id)p0;
	-(UIViewController *) contentController;
	-(void) setContentController:(UIViewController *)p0;
	-(id) defaultSideDrawer;
	-(NSArray *) sideDrawers;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithContent:(UIViewController *)p0;
@end

@protocol TKSideDrawerDelegate
	@optional -(void) sideDrawer:(id)p0 didSelectItemAtIndexPath:(NSIndexPath *)p1;
	@optional -(void) willShowSideDrawer:(id)p0;
	@optional -(void) didShowSideDrawer:(id)p0;
	@optional -(void) willDismissSideDrawer:(id)p0;
	@optional -(void) didDismissSideDrawer:(id)p0;
	@optional -(void) didPanSideDrawer:(id)p0;
	@optional -(UIView *) sideDrawer:(id)p0 viewForHeaderInSection:(int)p1;
	@optional -(CGFloat) sideDrawer:(id)p0 heightForItemAtIndexPath:(NSIndexPath *)p1;
	@optional -(void) sideDrawer:(id)p0 updateVisualsForItemAtIndexPath:(NSIndexPath *)p1;
	@optional -(void) sideDrawer:(id)p0 updateVisualsForSection:(int)p1;
	@optional -(id) sideDrawer:(id)p0 cellForItemAtIndexPath:(NSIndexPath *)p1;
@end

@interface TKSideDrawerItem : NSObject {
}
	-(UIImage *) image;
	-(void) setImage:(UIImage *)p0;
	-(id) style;
	-(NSString *) title;
	-(void) setTitle:(NSString *)p0;
	-(id) init;
	-(id) initWithTitle:(NSString *)p0;
	-(id) initWithTitle:(NSString *)p0 image:(UIImage *)p1;
@end

@interface TKSideDrawerItemStyle : TKStyleNode {
}
	-(UIEdgeInsets) contentInsets;
	-(void) setContentInsets:(UIEdgeInsets)p0;
	-(id) fill;
	-(void) setFill:(id)p0;
	-(UIFont *) font;
	-(void) setFont:(UIFont *)p0;
	-(int) imagePosition;
	-(void) setImagePosition:(int)p0;
	-(id) separatorColor;
	-(void) setSeparatorColor:(id)p0;
	-(id) stroke;
	-(void) setStroke:(id)p0;
	-(NSInteger) textAlignment;
	-(void) setTextAlignment:(NSInteger)p0;
	-(UIColor *) textColor;
	-(void) setTextColor:(UIColor *)p0;
	-(id) init;
@end

@interface TKSideDrawerSection : TKSideDrawerItem {
}
	-(void) addItem:(id)p0;
	-(id) addItemWithTitle:(NSString *)p0;
	-(id) addItemWithTitle:(NSString *)p0 image:(UIImage *)p1;
	-(void) insertItem:(id)p0 atIndex:(int)p1;
	-(void) removeAllItems;
	-(void) removeItem:(id)p0;
	-(NSArray *) items;
	-(id) init;
	-(id) initWithTitle:(NSString *)p0;
	-(id) initWithTitle:(NSString *)p0 image:(UIImage *)p1;
@end

@interface TKSideDrawerStyle : TKStyleNode {
}
	-(NSInteger) blurEffect;
	-(void) setBlurEffect:(NSInteger)p0;
	-(UIColor *) blurTintColor;
	-(void) setBlurTintColor:(UIColor *)p0;
	-(int) blurType;
	-(void) setBlurType:(int)p0;
	-(CGFloat) dimOpacity;
	-(void) setDimOpacity:(CGFloat)p0;
	-(CGFloat) footerHeight;
	-(void) setFooterHeight:(CGFloat)p0;
	-(CGFloat) headerHeight;
	-(void) setHeaderHeight:(CGFloat)p0;
	-(CGFloat) itemHeight;
	-(void) setItemHeight:(CGFloat)p0;
	-(CGFloat) sectionHeaderHeight;
	-(void) setSectionHeaderHeight:(CGFloat)p0;
	-(int) shadowMode;
	-(void) setShadowMode:(int)p0;
	-(CGSize) shadowOffset;
	-(void) setShadowOffset:(CGSize)p0;
	-(CGFloat) shadowOpacity;
	-(void) setShadowOpacity:(CGFloat)p0;
	-(CGFloat) shadowRadius;
	-(void) setShadowRadius:(CGFloat)p0;
	-(id) init;
@end

@interface TKSideDrawerTransition : NSObject {
}
	-(void) dismiss;
	-(void) handleGesture:(UIGestureRecognizer *)p0;
	-(void) show;
	-(void) transitionBegan:(BOOL)p0;
	-(void) transitionEnded:(BOOL)p0;
	-(id) sideDrawer;
	-(void) setSideDrawer:(id)p0;
	-(id) init;
	-(id) initWithSideDrawer:(id)p0;
@end

@protocol TKSlideViewDelegate
	@optional -(BOOL) slideViewWillSlideToView:(UIView *)p0;
	@optional -(void) slideViewDidSlideToView:(UIView *)p0;
@end

@interface TKSolidFill : TKFill {
}
	-(UIColor *) color;
	-(void) setColor:(UIColor *)p0;
	-(id) init;
	-(id) initWithColor:(UIColor *)p0;
	-(id) initWithColor:(UIColor *)p0 cornerRadius:(CGFloat)p1;
@end

@interface TKStackLayout : NSObject {
}
	-(void) addArrangedView:(UIView *)p0;
	-(void) insertArrangedView:(UIView *)p0 atIndex:(unsigned int)p1;
	-(void) layoutArrangedViews;
	-(CGSize) measurePreferredSizeThatFitsSize:(CGSize)p0;
	-(void) removeAllArrangedViews;
	-(void) removeArrangedView:(UIView *)p0;
	-(int) alignment;
	-(void) setAlignment:(int)p0;
	-(NSArray *) arrangedViews;
	-(int) distribution;
	-(void) setDistribution:(int)p0;
	-(CGRect) frame;
	-(void) setFrame:(CGRect)p0;
	-(int) orientation;
	-(void) setOrientation:(int)p0;
	-(CGFloat) spacing;
	-(void) setSpacing:(CGFloat)p0;
	-(id) init;
	-(id) initWithFrame:(CGRect)p0;
@end

@interface TKStroke : NSObject {
}
	-(BOOL) allowsAntialiasing;
	-(void) setAllowsAntialiasing:(BOOL)p0;
	-(UIColor *) color;
	-(CGFloat) cornerRadius;
	-(void) setCornerRadius:(CGFloat)p0;
	-(NSUInteger) corners;
	-(void) setCorners:(NSUInteger)p0;
	-(NSArray *) dashPattern;
	-(void) setDashPattern:(NSArray *)p0;
	-(id) fill;
	-(void) setFill:(id)p0;
	-(int) lineCap;
	-(void) setLineCap:(int)p0;
	-(int) lineJoin;
	-(void) setLineJoin:(int)p0;
	-(CGFloat) miterLimit;
	-(void) setMiterLimit:(CGFloat)p0;
	-(CGFloat) phase;
	-(void) setPhase:(CGFloat)p0;
	-(int) strokeSides;
	-(void) setStrokeSides:(int)p0;
	-(CGFloat) width;
	-(void) setWidth:(CGFloat)p0;
	-(id) init;
	-(id) initWithColor:(UIColor *)p0;
	-(id) initWithColor:(UIColor *)p0 width:(CGFloat)p1;
	-(id) initWithFill:(id)p0;
	-(id) initWithFill:(id)p0 width:(CGFloat)p1;
@end

@interface TKStyleGroup : NSObject {
}
	-(NSDictionary *) properties;
	-(id) styleID;
	-(void) setStyleID:(id)p0;
	-(id) init;
@end

@interface TKStyleID : NSObject {
}
	-(Class) conditionClass;
	-(void) setConditionClass:(Class)p0;
	-(NSInteger) state;
	-(void) setState:(NSInteger)p0;
	-(Class) stylableClass;
	-(void) setStylableClass:(Class)p0;
	-(id) init;
	-(id) initWithClass:(Class)p0 withState:(NSInteger)p1;
@end

@interface TKStyleSheet : NSObject {
}
	-(void) addStyleGroup:(id)p0;
	-(void) applyStylesToNode:(id)p0;
	-(void) removeAllStyleGroups;
	-(void) removeStyleGroup:(id)p0;
	-(NSInteger) styleGroupsCount;
	-(id) init;
@end

@interface TKWeakReference : NSObject {
}
	-(NSObject *) target;
	-(void) setTarget:(NSObject *)p0;
	-(id) init;
@end

@interface TelerikUI_TKView_TKViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface TelerikUI_TKAlertButtonsView_TKAlertButtonsViewAppearance : TelerikUI_TKView_TKViewAppearance {
}
@end

@interface TKAlertButtonsView : TKView {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKAlertContentView_TKAlertContentViewAppearance : TelerikUI_TKView_TKViewAppearance {
}
@end

@interface TKAlertContentView : TKView {
}
	-(UIImageView *) imageView;
	-(void) setImageView:(UIImageView *)p0;
	-(id) style;
	-(void) setStyle:(id)p0;
	-(UILabel *) textLabel;
	-(void) setTextLabel:(UILabel *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKAlertView_TKAlertViewAppearance : TelerikUI_TKView_TKViewAppearance {
}
@end

@interface TKAlertView : TKView {
}
	-(id) alert;
	-(void) setAlert:(id)p0;
	-(id) buttonsView;
	-(void) setButtonsView:(id)p0;
	-(id) contentView;
	-(void) setContentView:(id)p0;
	-(id) headerView;
	-(void) setHeaderView:(id)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKAutoCompleteCoverView_TKAutoCompleteCoverViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface TKAutoCompleteCoverView : UIView {
}
	-(CGRect) visibleRect;
	-(void) setVisibleRect:(CGRect)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKListViewReusableCell_TKListViewReusableCellAppearance : UIKit_UICollectionViewCell_UICollectionViewCellAppearance {
}
@end

@interface TelerikUI_TKListViewCell_TKListViewCellAppearance : TelerikUI_TKListViewReusableCell_TKListViewReusableCellAppearance {
}
@end

@interface TelerikUI_TKAutoCompleteSuggestionCell_TKAutoCompleteSuggestionCellAppearance : TelerikUI_TKListViewCell_TKListViewCellAppearance {
}
@end

@interface TKListViewReusableCell : UICollectionViewCell {
}
	-(UILabel *) textLabel;
	-(void) setTextLabel:(UILabel *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TKListViewCell : TKListViewReusableCell {
}
	-(UIEdgeInsets) contentInsets;
	-(void) setContentInsets:(UIEdgeInsets)p0;
	-(UILabel *) detailTextLabel;
	-(UIImageView *) imageView;
	-(void) setImageView:(UIImageView *)p0;
	-(BOOL) offsetContentViewInMultipleSelection;
	-(void) setOffsetContentViewInMultipleSelection:(BOOL)p0;
	-(id) ownerListView;
	-(UIView *) reorderHandle;
	-(void) setReorderHandle:(UIView *)p0;
	-(UIView *) swipeBackgroundView;
	-(void) setSwipeBackgroundView:(UIView *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithFrame:(CGRect)p0;
@end

@interface TKAutoCompleteSuggestionCell : TKListViewCell {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKAutoCompleteTextView_TKAutoCompleteTextViewAppearance : TelerikUI_TKView_TKViewAppearance {
}
@end

@interface TKAutoCompleteTextView : TKView {
}
	-(void) addToken:(id)p0;
	-(void) completeSuggestionViewPopulation:(NSArray *)p0;
	-(void) insertToken:(id)p0 atIndex:(NSUInteger)p1;
	-(void) removeAllTokens;
	-(void) removeToken:(id)p0;
	-(void) removeTokenAtIndex:(NSUInteger)p0;
	-(void) resetAutocomplete;
	-(id) tokenAtIndex:(NSUInteger)p0;
	-(NSArray *) tokens;
	-(BOOL) allowCustomTokens;
	-(void) setAllowCustomTokens:(BOOL)p0;
	-(BOOL) allowTokenHighlighting;
	-(void) setAllowTokenHighlighting:(BOOL)p0;
	-(CGFloat) autocompleteInset;
	-(void) setAutocompleteInset:(CGFloat)p0;
	-(UIButton *) closeButton;
	-(id) contentView;
	-(CGFloat) currentWrapHeight;
	-(int) displayMode;
	-(void) setDisplayMode:(int)p0;
	-(UIImageView *) imageView;
	-(int) layoutMode;
	-(void) setLayoutMode:(int)p0;
	-(NSUInteger) maximumTokensCount;
	-(void) setMaximumTokensCount:(NSUInteger)p0;
	-(CGFloat) maximumWrapHeight;
	-(void) setMaximumWrapHeight:(CGFloat)p0;
	-(NSUInteger) minimumCharactersToSearch;
	-(void) setMinimumCharactersToSearch:(NSUInteger)p0;
	-(UILabel *) noResultsLabel;
	-(BOOL) readOnly;
	-(void) setReadOnly:(BOOL)p0;
	-(BOOL) showAllItemsInitially;
	-(void) setShowAllItemsInitially:(BOOL)p0;
	-(int) suggestMode;
	-(void) setSuggestMode:(int)p0;
	-(CGFloat) suggestionViewHeight;
	-(void) setSuggestionViewHeight:(CGFloat)p0;
	-(BOOL) suggestionViewOutOfFrame;
	-(void) setSuggestionViewOutOfFrame:(BOOL)p0;
	-(UITextField *) textField;
	-(UILabel *) titleLabel;
	-(CGFloat) tokenInset;
	-(void) setTokenInset:(CGFloat)p0;
	-(NSArray *) tokeninzingSymbols;
	-(void) setTokeninzingSymbols:(NSArray *)p0;
	-(NSObject *) dataSource;
	-(void) setDataSource:(NSObject *)p0;
	-(NSObject *) delegate;
	-(void) setDelegate:(NSObject *)p0;
	-(UIView *) suggestionView;
	-(void) setSuggestionView:(UIView *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithFrame:(CGRect)p0;
@end

@interface TelerikUI_TKAutoCompleteTokenHolderView_TKAutoCompleteTokenHolderViewAppearance : UIKit_UIScrollView_UIScrollViewAppearance {
}
@end

@interface TKAutoCompleteTokenHolderView : UIScrollView {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKAutoCompleteTokenRemoveButton_TKAutoCompleteTokenRemoveButtonAppearance : UIKit_UIButton_UIButtonAppearance {
}
@end

@interface TKAutoCompleteTokenRemoveButton : UIButton {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKAutoCompleteTokenView_TKAutoCompleteTokenViewAppearance : TelerikUI_TKView_TKViewAppearance {
}
@end

@interface TKAutoCompleteTokenView : TKView {
}
	-(void) deleteBackward;
	-(void) insertText:(NSString *)p0;
	-(NSInteger) autocapitalizationType;
	-(void) setAutocapitalizationType:(NSInteger)p0;
	-(NSInteger) autocorrectionType;
	-(void) setAutocorrectionType:(NSInteger)p0;
	-(BOOL) enablesReturnKeyAutomatically;
	-(void) setEnablesReturnKeyAutomatically:(BOOL)p0;
	-(BOOL) hasText;
	-(UIView *) highlightedView;
	-(void) setHighlightedView:(UIView *)p0;
	-(UIImageView *) imageView;
	-(BOOL) isCloseButtonVisisble;
	-(void) setIsCloseButtonVisisble:(BOOL)p0;
	-(BOOL) isHighlighted;
	-(void) setIsHighlighted:(BOOL)p0;
	-(NSInteger) keyboardAppearance;
	-(void) setKeyboardAppearance:(NSInteger)p0;
	-(NSInteger) keyboardType;
	-(void) setKeyboardType:(NSInteger)p0;
	-(id) owner;
	-(void) setOwner:(id)p0;
	-(UIButton *) removeButton;
	-(void) setRemoveButton:(UIButton *)p0;
	-(NSInteger) returnKeyType;
	-(void) setReturnKeyType:(NSInteger)p0;
	-(BOOL) isSecureTextEntry;
	-(void) setSecureTextEntry:(BOOL)p0;
	-(NSInteger) spellCheckingType;
	-(void) setSpellCheckingType:(NSInteger)p0;
	-(UILabel *) textLabel;
	-(id) token;
	-(void) setToken:(id)p0;
	-(CGFloat) tokenInset;
	-(void) setTokenInset:(CGFloat)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithToken:(id)p0;
@end

@interface TelerikUI_TKCalendar_TKCalendarAppearance : TelerikUI_TKView_TKViewAppearance {
}
@end

@interface TelerikUI_TKCalendarCell_TKCalendarCellAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface TKCalendarCell : UIView {
}
	-(void) applyStyleForState:(NSInteger)p0;
	-(void) updateVisuals;
	-(UILabel *) label;
	-(id) owner;
	-(id) style;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithFrame:(CGRect)p0;
@end

@interface TelerikUI_TKCalendarDayCell_TKCalendarDayCellAppearance : TelerikUI_TKCalendarCell_TKCalendarCellAppearance {
}
@end

@interface TKCalendarDayCell : TKCalendarCell {
}
	-(void) attachWithCalendar:(id)p0 withDate:(NSDate *)p1;
	-(void) drawEvents:(id)p0 rect:(CGRect)p1;
	-(int) stateForDate:(NSDate *)p0;
	-(NSDictionary *) textAttributesForEvent:(id)p0;
	-(NSDate *) date;
	-(NSArray *) events;
	-(int) state;
	-(void) setState:(int)p0;
	-(id) style;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithFrame:(CGRect)p0;
@end

@interface TelerikUI_TKCalendarDayNameCell_TKCalendarDayNameCellAppearance : TelerikUI_TKCalendarCell_TKCalendarCellAppearance {
}
@end

@interface TKCalendarDayNameCell : TKCalendarCell {
}
	-(void) attachWithCalendar:(id)p0 withDayOffset:(NSInteger)p1;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKCalendarDayView_TKCalendarDayViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface TKCalendarDayView : UIView {
}
	-(void) attachWithEvents:(NSArray *)p0 forDate:(NSDate *)p1 withCalendar:(NSCalendar *)p2;
	-(NSArray *) allDayEvents;
	-(id) allDayEventsView;
	-(NSCalendar *) calendar;
	-(UIView *) date;
	-(NSArray *) events;
	-(id) eventsView;
	-(NSObject *) dataSource;
	-(void) setDataSource:(NSObject *)p0;
	-(NSObject *) delegate;
	-(void) setDelegate:(NSObject *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKCalendarDayViewAllDayEventCell_TKCalendarDayViewAllDayEventCellAppearance : UIKit_UICollectionViewCell_UICollectionViewCellAppearance {
}
@end

@interface TKCalendarDayViewAllDayEventCell : UICollectionViewCell {
}
	-(void) attachWithEvent:(id)p0;
	-(id) event;
	-(UILabel *) label;
	-(id) style;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKCalendarDayViewAllDayEventsView_TKCalendarDayViewAllDayEventsViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface TKCalendarDayViewAllDayEventsView : UIView {
}
	-(void) attachWithEvents:(NSArray *)p0 forDate:(NSDate *)p1;
	-(UICollectionView *) createEventsView;
	-(UIView *) createLabelView;
	-(void) updateLayout;
	-(NSDate *) date;
	-(NSArray *) events;
	-(UICollectionView *) eventsView;
	-(UIView *) labelView;
	-(id) style;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKCalendarDayViewEventCell_TKCalendarDayViewEventCellAppearance : UIKit_UICollectionViewCell_UICollectionViewCellAppearance {
}
@end

@interface TKCalendarDayViewEventCell : UICollectionViewCell {
}
	-(void) attachWithEvent:(id)p0;
	-(id) event;
	-(id) style;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKCalendarDayViewEventsView_TKCalendarDayViewEventsViewAppearance : UIKit_UICollectionView_UICollectionViewAppearance {
}
@end

@interface TKCalendarDayViewEventsView : UICollectionView {
}
	-(void) attachWithEvents:(NSArray *)p0 forDate:(NSDate *)p1 withCalendar:(NSCalendar *)p2;
	-(CGFloat) offsetForComponents:(NSDateComponents *)p0;
	-(CGFloat) offsetForHour:(NSInteger)p0 minute:(NSInteger)p1 second:(NSInteger)p2;
	-(CGFloat) slotsCount;
	-(CGFloat) timeLineHeight;
	-(NSString *) labelForTimeInterval:(double)p0;
	-(void) updateLayout;
	-(BOOL) allowZoom;
	-(void) setAllowZoom:(BOOL)p0;
	-(NSCalendar *) calendar;
	-(NSDate *) date;
	-(double) endTime;
	-(void) setEndTime:(double)p0;
	-(NSArray *) events;
	-(double) interval;
	-(void) setInterval:(double)p0;
	-(CGFloat) maxZoom;
	-(void) setMaxZoom:(CGFloat)p0;
	-(CGFloat) minZoom;
	-(void) setMinZoom:(CGFloat)p0;
	-(double) startTime;
	-(void) setStartTime:(double)p0;
	-(id) style;
	-(CGFloat) zoom;
	-(void) setZoom:(CGFloat)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKCalendarPresenterBase_TKCalendarPresenterBaseAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface TelerikUI_TKCalendarDayViewPresenter_TKCalendarDayViewPresenterAppearance : TelerikUI_TKCalendarPresenterBase_TKCalendarPresenterBaseAppearance {
}
@end

@interface TKCalendarPresenterBase : UIView {
}
	-(NSDate *) dateFromPoint:(CGPoint)p0;
	-(BOOL) navigateBack:(BOOL)p0;
	-(BOOL) navigateForward:(BOOL)p0;
	-(void) navigateToDate:(NSDate *)p0 animated:(BOOL)p1;
	-(void) update:(BOOL)p0;
	-(void) updateState:(NSDate *)p0;
	-(CGFloat) panGestureSensitivity;
	-(void) setPanGestureSensitivity:(CGFloat)p0;
	-(double) transitionDuration;
	-(void) setTransitionDuration:(double)p0;
	-(BOOL) transitionIsReverse;
	-(void) setTransitionIsReverse:(BOOL)p0;
	-(BOOL) transitionIsVertical;
	-(void) setTransitionIsVertical:(BOOL)p0;
	-(int) transitionMode;
	-(void) setTransitionMode:(int)p0;
	-(NSObject *) delegate;
	-(void) setDelegate:(NSObject *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TKCalendarDayViewPresenter : TKCalendarPresenterBase {
}
	-(id) cellForDate:(NSDate *)p0;
	-(id) createCellWithType:(int)p0;
	-(BOOL) dayNamesHidden;
	-(void) setDayNamesHidden:(BOOL)p0;
	-(UIView *) dayNamesView;
	-(id) dayView;
	-(id) owner;
	-(id) style;
	-(BOOL) titleHidden;
	-(void) setTitleHidden:(BOOL)p0;
	-(UIView *) titleView;
	-(BOOL) weekHidden;
	-(void) setWeekHidden:(BOOL)p0;
	-(BOOL) weekNumbersHidden;
	-(void) setWeekNumbersHidden:(BOOL)p0;
	-(UIView *) weekView;
	-(BOOL) weekendsHidden;
	-(void) setWeekendsHidden:(BOOL)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKCalendarDayViewTimeLine_TKCalendarDayViewTimeLineAppearance : UIKit_UICollectionReusableView_UICollectionReusableViewAppearance {
}
@end

@interface TKCalendarDayViewTimeLine : UICollectionReusableView {
}
	-(id) owner;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKCalendarInlineView_TKCalendarInlineViewAppearance : TelerikUI_TKView_TKViewAppearance {
}
@end

@interface TKCalendarInlineView : TKView {
}
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(id) dayCell;
	-(CGFloat) desiredWidthInPopoverMode;
	-(void) setDesiredWidthInPopoverMode:(CGFloat)p0;
	-(BOOL) fixedHeight;
	-(void) setFixedHeight:(BOOL)p0;
	-(CGFloat) maxHeight;
	-(void) setMaxHeight:(CGFloat)p0;
	-(id) owner;
	-(CGFloat) rowHeight;
	-(void) setRowHeight:(CGFloat)p0;
	-(UITableView *) tableView;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKCalendarInlineViewTableViewCell_TKCalendarInlineViewTableViewCellAppearance : UIKit_UITableViewCell_UITableViewCellAppearance {
}
@end

@interface TKCalendarInlineViewTableViewCell : UITableViewCell {
}
	-(void) attachWithCell:(id)p0 eventIndex:(NSInteger)p1;
	-(void) updateTextForEvent:(id)p0 withCell:(id)p1;
	-(id) style;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKCalendarMonthCell_TKCalendarMonthCellAppearance : UIKit_UICollectionViewCell_UICollectionViewCellAppearance {
}
@end

@interface TKCalendarMonthCell : UICollectionViewCell {
}
	-(void) attachWithCalendar:(id)p0 presenter:(id)p1 withYear:(NSInteger)p2 andMonth:(NSInteger)p3;
	-(id) monthView;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKCalendarMonthNameCell_TKCalendarMonthNameCellAppearance : TelerikUI_TKCalendarCell_TKCalendarCellAppearance {
}
@end

@interface TKCalendarMonthNameCell : TKCalendarCell {
}
	-(void) attachWithCalendar:(id)p0 withDate:(NSDate *)p1;
	-(NSDate *) date;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithFrame:(CGRect)p0;
@end

@interface TelerikUI_TKCalendarMonthNamesPresenter_TKCalendarMonthNamesPresenterAppearance : TelerikUI_TKCalendarPresenterBase_TKCalendarPresenterBaseAppearance {
}
@end

@interface TKCalendarMonthNamesPresenter : TKCalendarPresenterBase {
}
	-(NSInteger) columns;
	-(void) setColumns:(NSInteger)p0;
	-(UIView *) contentView;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKCalendarMonthPresenter_TKCalendarMonthPresenterAppearance : TelerikUI_TKCalendarPresenterBase_TKCalendarPresenterBaseAppearance {
}
@end

@interface TKCalendarMonthPresenter : TKCalendarPresenterBase {
}
	-(id) cellForDate:(NSDate *)p0;
	-(id) createCellWithType:(int)p0;
	-(NSDate *) dateForRow:(NSInteger)p0 col:(NSInteger)p1;
	-(void) hideInlineEvents:(BOOL)p0;
	-(void) showInlineEventsForCell:(id)p0 animated:(BOOL)p1;
	-(UIView *) contentView;
	-(BOOL) dayNamesHidden;
	-(void) setDayNamesHidden:(BOOL)p0;
	-(BOOL) equalWeekNumber;
	-(void) setEqualWeekNumber:(BOOL)p0;
	-(BOOL) headerIsSticky;
	-(void) setHeaderIsSticky:(BOOL)p0;
	-(UIView *) headerView;
	-(id) inlineEventsView;
	-(void) setInlineEventsView:(id)p0;
	-(NSInteger) inlineEventsViewMode;
	-(void) setInlineEventsViewMode:(NSInteger)p0;
	-(id) owner;
	-(id) style;
	-(BOOL) titleHidden;
	-(void) setTitleHidden:(BOOL)p0;
	-(BOOL) weekNumbersHidden;
	-(void) setWeekNumbersHidden:(BOOL)p0;
	-(BOOL) weekendsHidden;
	-(void) setWeekendsHidden:(BOOL)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKCalendarTitleCell_TKCalendarTitleCellAppearance : TelerikUI_TKCalendarCell_TKCalendarCellAppearance {
}
@end

@interface TelerikUI_TKCalendarMonthTitleCell_TKCalendarMonthTitleCellAppearance : TelerikUI_TKCalendarTitleCell_TKCalendarTitleCellAppearance {
}
@end

@interface TKCalendarTitleCell : TKCalendarCell {
}
	-(void) attachWithCalendar:(id)p0 withText:(NSString *)p1;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TKCalendarMonthTitleCell : TKCalendarTitleCell {
}
	-(int) layoutMode;
	-(void) setLayoutMode:(int)p0;
	-(UIButton *) nextYearButton;
	-(void) setNextYearButton:(UIButton *)p0;
	-(UIButton *) nextMonthButton;
	-(void) setNextMonthButton:(UIButton *)p0;
	-(UIButton *) previousMonthButton;
	-(void) setPreviousMonthButton:(UIButton *)p0;
	-(UIButton *) previousYearButton;
	-(void) setPreviousYearButton:(UIButton *)p0;
	-(UILabel *) yearLabel;
	-(void) setYearLabel:(UILabel *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKCalendarMonthView_TKCalendarMonthViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface TKCalendarMonthView : UIView {
}
	-(void) attachWithCalendar:(id)p0 presenter:(id)p1 withYear:(NSInteger)p2 andMonth:(NSInteger)p3;
	-(NSDate *) date;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKCalendarWeekDayCell_TKCalendarWeekDayCellAppearance : TelerikUI_TKCalendarDayCell_TKCalendarDayCellAppearance {
}
@end

@interface TKCalendarWeekDayCell : TKCalendarDayCell {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKCalendarWeekNumberCell_TKCalendarWeekNumberCellAppearance : TelerikUI_TKCalendarCell_TKCalendarCellAppearance {
}
@end

@interface TKCalendarWeekNumberCell : TKCalendarCell {
}
	-(void) attachWithCalendar:(id)p0 withWeekNumber:(NSInteger)p1;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKCalendarWeekPresenter_TKCalendarWeekPresenterAppearance : TelerikUI_TKCalendarMonthPresenter_TKCalendarMonthPresenterAppearance {
}
@end

@interface TKCalendarWeekPresenter : TKCalendarMonthPresenter {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKCalendarYearNumberCell_TKCalendarYearNumberCellAppearance : TelerikUI_TKCalendarCell_TKCalendarCellAppearance {
}
@end

@interface TKCalendarYearNumberCell : TKCalendarCell {
}
	-(void) attachWithCalendar:(id)p0 withDate:(NSDate *)p1;
	-(NSDate *) date;
	-(NSInteger) state;
	-(void) setState:(NSInteger)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKCalendarYearNumbersPresenter_TKCalendarYearNumbersPresenterAppearance : TelerikUI_TKCalendarPresenterBase_TKCalendarPresenterBaseAppearance {
}
@end

@interface TKCalendarYearNumbersPresenter : TKCalendarPresenterBase {
}
	-(NSInteger) columns;
	-(void) setColumns:(NSInteger)p0;
	-(NSInteger) rows;
	-(void) setRows:(NSInteger)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKCalendarYearPresenter_TKCalendarYearPresenterAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface TKCalendarYearPresenter : UIView {
}
	-(NSDate *) dateFromPoint:(CGPoint)p0;
	-(BOOL) navigateBack:(BOOL)p0;
	-(BOOL) navigateForward:(BOOL)p0;
	-(void) navigateToDate:(NSDate *)p0 animated:(BOOL)p1;
	-(void) update:(BOOL)p0;
	-(void) updateState:(NSDate *)p0;
	-(UICollectionView *) collectionView;
	-(NSInteger) columns;
	-(void) setColumns:(NSInteger)p0;
	-(Class) monthCellClass;
	-(void) setMonthCellClass:(Class)p0;
	-(id) style;
	-(Class) titleViewClass;
	-(void) setTitleViewClass:(Class)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKCalendarYearTitleView_TKCalendarYearTitleViewAppearance : UIKit_UICollectionReusableView_UICollectionReusableViewAppearance {
}
@end

@interface TKCalendarYearTitleView : UICollectionReusableView {
}
	-(void) attachWithCalendar:(id)p0 withText:(NSString *)p1;
	-(id) view;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKChart_TKChartAppearance : TelerikUI_TKView_TKViewAppearance {
}
@end

@interface TKChart : TKView {
}
	-(void) addAnnotation:(id)p0;
	-(void) addAxis:(id)p0;
	-(void) addSeries:(id)p0;
	-(void) animate;
	-(void) beginUpdates;
	-(NSObject *) dequeueReusableSeriesWithIdentifier:(NSString *)p0;
	-(void) deselect:(id)p0;
	-(void) endUpdates;
	-(id) hitTestForPoint:(CGPoint)p0;
	-(id) paletteItemForPoint:(NSUInteger)p0 inSeries:(id)p1;
	-(id) paletteItemForSeries:(id)p0 atIndex:(NSUInteger)p1;
	-(void) reloadData;
	-(void) removeAllAnnotations;
	-(void) removeAllData;
	-(void) removeAnnotation:(id)p0;
	-(BOOL) removeAxis:(id)p0;
	-(void) removeSeries:(id)p0;
	-(void) select:(id)p0;
	-(void) update;
	-(void) updateAnnotations;
	-(id) visualPointForSeries:(id)p0 dataPointIndex:(NSInteger)p1;
	-(NSArray *) visualPointsForSeries:(id)p0;
	-(BOOL) allowAnimations;
	-(void) setAllowAnimations:(BOOL)p0;
	-(BOOL) allowPanDeceleration;
	-(void) setAllowPanDeceleration:(BOOL)p0;
	-(BOOL) allowTrackball;
	-(void) setAllowTrackball:(BOOL)p0;
	-(double) animationDuration;
	-(void) setAnimationDuration:(double)p0;
	-(NSArray *) annotations;
	-(NSArray *) axes;
	-(int) dataPointSelectionMode;
	-(void) setDataPointSelectionMode:(int)p0;
	-(BOOL) forceAutoAxis;
	-(void) setForceAutoAxis:(BOOL)p0;
	-(id) gridStyle;
	-(BOOL) handleDoubleTap;
	-(void) setHandleDoubleTap:(BOOL)p0;
	-(UIEdgeInsets) insets;
	-(void) setInsets:(UIEdgeInsets)p0;
	-(id) legend;
	-(id) plotView;
	-(NSArray *) selectedPoints;
	-(NSArray *) selectedSeries;
	-(int) selectionMode;
	-(void) setSelectionMode:(int)p0;
	-(NSArray *) series;
	-(int) seriesSelectionMode;
	-(void) setSeriesSelectionMode:(int)p0;
	-(id) theme;
	-(void) setTheme:(id)p0;
	-(id) title;
	-(id) trackball;
	-(NSObject *) dataSource;
	-(void) setDataSource:(NSObject *)p0;
	-(NSObject *) delegate;
	-(void) setDelegate:(NSObject *)p0;
	-(id) xAxis;
	-(void) setXAxis:(id)p0;
	-(id) yAxis;
	-(void) setYAxis:(id)p0;
	-(int) zoomMode;
	-(void) setZoomMode:(int)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithFrame:(CGRect)p0;
@end

@interface TelerikUI_TKCoreStackLayoutView_TKCoreStackLayoutViewAppearance : UIKit_UIScrollView_UIScrollViewAppearance {
}
@end

@interface TelerikUI_TKChartLegendContainer_TKChartLegendContainerAppearance : TelerikUI_TKCoreStackLayoutView_TKCoreStackLayoutViewAppearance {
}
@end

@interface TKCoreStackLayoutView : UIScrollView {
}
	-(id) stack;
	-(void) setStack:(id)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TKChartLegendContainer : TKCoreStackLayoutView {
}
	-(void) addItem:(id)p0;
	-(id) itemAtIndex:(NSUInteger)p0;
	-(void) removeAllItems;
	-(NSUInteger) itemCount;
	-(CGSize) preferredSize;
	-(void) setPreferredSize:(CGSize)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKChartLegendItem_TKChartLegendItemAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface TKChartLegendItem : UIView {
}
	-(UIView *) icon;
	-(void) setIcon:(UIView *)p0;
	-(UILabel *) label;
	-(void) setLabel:(UILabel *)p0;
	-(id) selectionInfo;
	-(void) setSelectionInfo:(id)p0;
	-(id) style;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKChartLegendView_TKChartLegendViewAppearance : TelerikUI_TKView_TKViewAppearance {
}
@end

@interface TKChartLegendView : TKView {
}
	-(void) reloadItems;
	-(BOOL) allowSelection;
	-(void) setAllowSelection:(BOOL)p0;
	-(id) chart;
	-(void) setChart:(id)p0;
	-(id) container;
	-(int) legendItemsIconShape;
	-(void) setLegendItemsIconShape:(int)p0;
	-(BOOL) showTitle;
	-(void) setShowTitle:(BOOL)p0;
	-(id) style;
	-(UILabel *) titleLabel;
	-(CGRect) legendItemsIconSize;
	-(void) setLegendItemsIconSize:(CGRect)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithChart:(id)p0;
@end

@interface TelerikUI_TKChartPlotView_TKChartPlotViewAppearance : TelerikUI_TKView_TKViewAppearance {
}
@end

@interface TKChartPlotView : TKView {
}
	-(id) hitTestForPoint:(CGPoint)p0;
	-(id) renderForSeries:(id)p0;
	-(UITapGestureRecognizer *) doubleTapGestureRecognizer;
	-(void) setDoubleTapGestureRecognizer:(UITapGestureRecognizer *)p0;
	-(id) grid;
	-(void) setGrid:(id)p0;
	-(BOOL) handleTap;
	-(void) setHandleTap:(BOOL)p0;
	-(UILongPressGestureRecognizer *) longPressRecognizer;
	-(void) setLongPressRecognizer:(UILongPressGestureRecognizer *)p0;
	-(UIGestureRecognizer *) panZoomRecognizer;
	-(void) setPanZoomRecognizer:(UIGestureRecognizer *)p0;
	-(UIGestureRecognizer *) rotateOneFingerRecognizer;
	-(void) setRotateOneFingerRecognizer:(UIGestureRecognizer *)p0;
	-(UIRotationGestureRecognizer *) rotateTwoFingerRecognizer;
	-(void) setRotateTwoFingerRecognizer:(UIRotationGestureRecognizer *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKChartTitleView_TKChartTitleViewAppearance : UIKit_UILabel_UILabelAppearance {
}
@end

@interface TKChartTitleView : UILabel {
}
	-(int) position;
	-(void) setPosition:(int)p0;
	-(id) style;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKCheckView_TKCheckViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface TKCheckView : UIView {
}
	-(id) checkFill;
	-(void) setCheckFill:(id)p0;
	-(id) checkShape;
	-(void) setCheckShape:(id)p0;
	-(id) checkStroke;
	-(void) setCheckStroke:(id)p0;
	-(BOOL) isChecked;
	-(void) setIsChecked:(BOOL)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKCollectionViewCell_TKCollectionViewCellAppearance : UIKit_UICollectionViewCell_UICollectionViewCellAppearance {
}
@end

@interface TKCollectionViewCell : UICollectionViewCell {
}
	-(UILabel *) label;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKDataForm_TKDataFormAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface TKDataForm : UIView {
}
	-(void) commit;
	-(id) groupViewForGroup:(id)p0;
	-(BOOL) hasValidationErrors;
	-(void) registerEditor:(Class)p0 forProperty:(NSString *)p1;
	-(void) registerEditor:(Class)p0 forPropertyOfClass:(Class)p1;
	-(void) registerEditor:(Class)p0 forPropertyOfType:(int)p1;
	-(void) reloadData;
	-(void) setEditorOnFocus:(id)p0;
	-(void) update;
	-(void) updateEditorForProperty:(id)p0;
	-(BOOL) allowScroll;
	-(void) setAllowScroll:(BOOL)p0;
	-(int) commitMode;
	-(void) setCommitMode:(int)p0;
	-(id) delegate;
	-(void) setDelegate:(id)p0;
	-(CGFloat) groupSpacing;
	-(void) setGroupSpacing:(CGFloat)p0;
	-(BOOL) readOnly;
	-(void) setReadOnly:(BOOL)p0;
	-(int) validationMode;
	-(void) setValidationMode:(int)p0;
	-(NSObject *) dataSource;
	-(void) setDataSource:(NSObject *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithFrame:(CGRect)p0;
@end

@interface TelerikUI_TKDataFormAccessoryView_TKDataFormAccessoryViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface TKDataFormAccessoryView : UIView {
}
	-(UIBarButtonItem *) doneBarItem;
	-(UIBarButtonItem *) nextBarItem;
	-(UIBarButtonItem *) previousBarItem;
	-(UIToolbar *) toolbar;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKDataFormEditor_TKDataFormEditorAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface TelerikUI_TKDataFormViewControllerEditor_TKDataFormViewControllerEditorAppearance : TelerikUI_TKDataFormEditor_TKDataFormEditorAppearance {
}
@end

@interface TelerikUI_TKDataFormAutocompleteEditor_TKDataFormAutocompleteEditorAppearance : TelerikUI_TKDataFormViewControllerEditor_TKDataFormViewControllerEditorAppearance {
}
@end

@interface TKDataFormEditor : UIView {
}
	-(void) update;
	-(UIView *) editor;
	-(UIImageView *) feedbackImageView;
	-(UILabel *) feedbackLabel;
	-(id) gridLayout;
	-(UIImageView *) imageView;
	-(id) owner;
	-(void) setOwner:(id)p0;
	-(id) property;
	-(void) setProperty:(id)p0;
	-(BOOL) selected;
	-(id) selectedView;
	-(void) setSelectedView:(id)p0;
	-(id) style;
	-(id) textLabel;
	-(NSObject *) value;
	-(void) setValue:(NSObject *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithProperty:(id)p0;
@end

@interface TKDataFormViewControllerEditor : TKDataFormEditor {
}
	-(UIViewController *) createViewController;
	-(void) presentViewController;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TKDataFormAutocompleteEditor : TKDataFormViewControllerEditor {
}
	-(UIImageView *) accessoryImageView;
	-(NSArray *) options;
	-(void) setOptions:(NSArray *)p0;
	-(NSString *) placeholder;
	-(void) setPlaceholder:(NSString *)p0;
	-(NSString *) selectedItem;
	-(void) setSelectedItem:(NSString *)p0;
	-(id) selectedOptionLabel;
	-(BOOL) showAccessoryImage;
	-(void) setShowAccessoryImage:(BOOL)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKDataFormAutoCompleteInlineEditor_TKDataFormAutoCompleteInlineEditorAppearance : TelerikUI_TKDataFormEditor_TKDataFormEditorAppearance {
}
@end

@interface TKDataFormAutoCompleteInlineEditor : TKDataFormEditor {
}
	-(id) autoCompleteView;
	-(void) setAutoCompleteView:(id)p0;
	-(id) dataSource;
	-(NSArray *) options;
	-(void) setOptions:(NSArray *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKDataFormInlineEditor_TKDataFormInlineEditorAppearance : TelerikUI_TKDataFormEditor_TKDataFormEditorAppearance {
}
@end

@interface TelerikUI_TKDataFormDatePickerEditor_TKDataFormDatePickerEditorAppearance : TelerikUI_TKDataFormInlineEditor_TKDataFormInlineEditorAppearance {
}
@end

@interface TKDataFormInlineEditor : TKDataFormEditor {
}
	-(UIImageView *) accessoryImageView;
	-(int) displayMode;
	-(void) setDisplayMode:(int)p0;
	-(id) editorValueLabel;
	-(BOOL) showAccessoryImage;
	-(void) setShowAccessoryImage:(BOOL)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TKDataFormDatePickerEditor : TKDataFormInlineEditor {
}
	-(NSDateFormatter *) dateFormatter;
	-(void) setDateFormatter:(NSDateFormatter *)p0;
	-(UIDatePicker *) datePicker;
	-(NSString *) placeholder;
	-(void) setPlaceholder:(NSString *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKDataFormTextFieldEditor_TKDataFormTextFieldEditorAppearance : TelerikUI_TKDataFormEditor_TKDataFormEditorAppearance {
}
@end

@interface TelerikUI_TKDataFormDecimalEditor_TKDataFormDecimalEditorAppearance : TelerikUI_TKDataFormTextFieldEditor_TKDataFormTextFieldEditorAppearance {
}
@end

@interface TKDataFormTextFieldEditor : TKDataFormEditor {
}
	-(id) textField;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TKDataFormDecimalEditor : TKDataFormTextFieldEditor {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKDataFormEmailEditor_TKDataFormEmailEditorAppearance : TelerikUI_TKDataFormTextFieldEditor_TKDataFormTextFieldEditorAppearance {
}
@end

@interface TKDataFormEmailEditor : TKDataFormTextFieldEditor {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKDataFormMultilineTextEditor_TKDataFormMultilineTextEditorAppearance : TelerikUI_TKDataFormEditor_TKDataFormEditorAppearance {
}
@end

@interface TKDataFormMultilineTextEditor : TKDataFormEditor {
}
	-(UITextView *) textView;
	-(void) setTextView:(UITextView *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKDataFormNamePhoneEditor_TKDataFormNamePhoneEditorAppearance : TelerikUI_TKDataFormTextFieldEditor_TKDataFormTextFieldEditorAppearance {
}
@end

@interface TKDataFormNamePhoneEditor : TKDataFormTextFieldEditor {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKDataFormNumberEditor_TKDataFormNumberEditorAppearance : TelerikUI_TKDataFormTextFieldEditor_TKDataFormTextFieldEditorAppearance {
}
@end

@interface TKDataFormNumberEditor : TKDataFormTextFieldEditor {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKDataFormOptionsEditor_TKDataFormOptionsEditorAppearance : TelerikUI_TKDataFormViewControllerEditor_TKDataFormViewControllerEditorAppearance {
}
@end

@interface TKDataFormOptionsEditor : TKDataFormViewControllerEditor {
}
	-(UIImageView *) accessoryImageView;
	-(NSArray *) options;
	-(void) setOptions:(NSArray *)p0;
	-(int) selectedIndex;
	-(void) setSelectedIndex:(int)p0;
	-(id) selectedOptionLabel;
	-(BOOL) showAccessoryImage;
	-(void) setShowAccessoryImage:(BOOL)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKDataFormPasswordEditor_TKDataFormPasswordEditorAppearance : TelerikUI_TKDataFormTextFieldEditor_TKDataFormTextFieldEditorAppearance {
}
@end

@interface TKDataFormPasswordEditor : TKDataFormTextFieldEditor {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKDataFormPhoneEditor_TKDataFormPhoneEditorAppearance : TelerikUI_TKDataFormTextFieldEditor_TKDataFormTextFieldEditorAppearance {
}
@end

@interface TKDataFormPhoneEditor : TKDataFormTextFieldEditor {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKDataFormPickerViewEditor_TKDataFormPickerViewEditorAppearance : TelerikUI_TKDataFormInlineEditor_TKDataFormInlineEditorAppearance {
}
@end

@interface TKDataFormPickerViewEditor : TKDataFormInlineEditor {
}
	-(NSArray *) options;
	-(void) setOptions:(NSArray *)p0;
	-(UIPickerView *) pickerView;
	-(int) selectedIndex;
	-(void) setSelectedIndex:(int)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKDataFormSegmentedEditor_TKDataFormSegmentedEditorAppearance : TelerikUI_TKDataFormEditor_TKDataFormEditorAppearance {
}
@end

@interface TKDataFormSegmentedEditor : TKDataFormEditor {
}
	-(NSArray *) options;
	-(void) setOptions:(NSArray *)p0;
	-(UISegmentedControl *) segmentedControl;
	-(int) selectedIndex;
	-(void) setSelectedIndex:(int)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKDataFormSliderEditor_TKDataFormSliderEditorAppearance : TelerikUI_TKDataFormEditor_TKDataFormEditorAppearance {
}
@end

@interface TKDataFormSliderEditor : TKDataFormEditor {
}
	-(UISlider *) sliderView;
	-(CGFloat) stepValue;
	-(void) setStepValue:(CGFloat)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKDataFormStepperEditor_TKDataFormStepperEditorAppearance : TelerikUI_TKDataFormEditor_TKDataFormEditorAppearance {
}
@end

@interface TKDataFormStepperEditor : TKDataFormEditor {
}
	-(NSNumberFormatter *) formatter;
	-(void) setFormatter:(NSNumberFormatter *)p0;
	-(UIStepper *) stepperView;
	-(UILabel *) valueLabel;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKDataFormSwitchEditor_TKDataFormSwitchEditorAppearance : TelerikUI_TKDataFormEditor_TKDataFormEditorAppearance {
}
@end

@interface TKDataFormSwitchEditor : TKDataFormEditor {
}
	-(UISwitch *) switchView;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKDataFormTimePickerEditor_TKDataFormTimePickerEditorAppearance : TelerikUI_TKDataFormDatePickerEditor_TKDataFormDatePickerEditorAppearance {
}
@end

@interface TKDataFormTimePickerEditor : TKDataFormDatePickerEditor {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKEntityPropertyGroupEditorsView_TKEntityPropertyGroupEditorsViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface TKEntityPropertyGroupEditorsView : UIView {
}
	-(void) addItem:(UIView *)p0;
	-(void) removeAllItems;
	-(void) removeItem:(UIView *)p0;
	-(NSArray *) items;
	-(id) layout;
	-(void) setLayout:(id)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKEntityPropertyGroupTitleView_TKEntityPropertyGroupTitleViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface TKEntityPropertyGroupTitleView : UIView {
}
	-(BOOL) allowIndicatorAnimation;
	-(void) setAllowIndicatorAnimation:(BOOL)p0;
	-(int) indicatorPosition;
	-(void) setIndicatorPosition:(int)p0;
	-(UIView *) indicatorView;
	-(void) setIndicatorView:(UIView *)p0;
	-(CGFloat) itemSpacing;
	-(void) setItemSpacing:(CGFloat)p0;
	-(id) style;
	-(id) titleLabel;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKEntityPropertyGroupTitleViewIndicator_TKEntityPropertyGroupTitleViewIndicatorAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface TKEntityPropertyGroupTitleViewIndicator : UIView {
}
	-(id) fillColor;
	-(void) setFillColor:(id)p0;
	-(CGSize) size;
	-(void) setSize:(CGSize)p0;
	-(id) strokeColor;
	-(void) setStrokeColor:(id)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKEntityPropertyGroupView_TKEntityPropertyGroupViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface TKEntityPropertyGroupView : UIView {
}
	-(BOOL) collapsible;
	-(void) setCollapsible:(BOOL)p0;
	-(id) editorsContainer;
	-(id) group;
	-(id) titleView;
	-(void) setTitleView:(id)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKGauge_TKGaugeAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface TKGauge : UIView {
}
	-(void) addScale:(id)p0;
	-(void) insetScale:(id)p0 atIndex:(NSInteger)p1;
	-(void) removeAllScales;
	-(void) removeScale:(id)p0;
	-(void) removeScaleAtIndex:(NSInteger)p0;
	-(id) scaleAtIndex:(NSInteger)p0;
	-(UIEdgeInsets) insets;
	-(void) setInsets:(UIEdgeInsets)p0;
	-(UILabel *) labelSubtitle;
	-(CGPoint) labelSubtitleOffset;
	-(void) setLabelSubtitleOffset:(CGPoint)p0;
	-(UILabel *) labelTitle;
	-(CGPoint) labelTitleOffset;
	-(void) setLabelTitleOffset:(CGPoint)p0;
	-(NSArray *) scales;
	-(NSObject *) delegate;
	-(void) setDelegate:(NSObject *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKLabel_TKLabelAppearance : UIKit_UILabel_UILabelAppearance {
}
@end

@interface TKLabel : UILabel {
}
	-(UIEdgeInsets) textInsets;
	-(void) setTextInsets:(UIEdgeInsets)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithFrame:(CGRect)p0;
@end

@interface TelerikUI_TKLinearGauge_TKLinearGaugeAppearance : TelerikUI_TKGauge_TKGaugeAppearance {
}
@end

@interface TKLinearGauge : TKGauge {
}
	-(int) labelOrientation;
	-(void) setLabelOrientation:(int)p0;
	-(int) labelPosition;
	-(void) setLabelPosition:(int)p0;
	-(CGFloat) labelSpacing;
	-(void) setLabelSpacing:(CGFloat)p0;
	-(int) orientation;
	-(void) setOrientation:(int)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKListView_TKListViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface TKListView : UIView {
}
	-(id) cellForItemAtIndexPath:(NSIndexPath *)p0;
	-(void) clearSelectedItems;
	-(void) deleteItemsAtIndexPaths:(NSArray *)p0;
	-(id) dequeueLoadOnDemandCellForIndexPath:(NSIndexPath *)p0;
	-(NSObject *) dequeueReusableCellWithReuseIdentifier:(NSString *)p0 forIndexPath:(NSIndexPath *)p1;
	-(NSObject *) dequeueReusableSupplementaryViewOfKind:(NSString *)p0 withReuseIdentifier:(NSString *)p1 forIndexPath:(NSIndexPath *)p2;
	-(void) deselectItemAtIndexPath:(NSIndexPath *)p0 animated:(BOOL)p1;
	-(void) didLoadDataOnDemand;
	-(void) didRefreshOnPull;
	-(void) endSwipe:(BOOL)p0;
	-(NSIndexPath *) indexPathForCell:(id)p0;
	-(NSIndexPath *) indexPathForItemAtPoint:(CGPoint)p0;
	-(NSArray *) indexPathsForSelectedItems;
	-(void) insertItemsAtIndexPaths:(NSArray *)p0;
	-(void) moveItemAtIndexPath:(NSIndexPath *)p0 toIndexPath:(NSIndexPath *)p1;
	-(NSInteger) numberOfItemsInSection:(NSInteger)p0;
	-(void) performBatchUpdates:(id)p0 completion:(id)p1;
	-(void) registerClass:(Class)p0 forCellWithReuseIdentifier:(NSString *)p1;
	-(void) registerClass:(Class)p0 forSupplementaryViewOfKind:(NSString *)p1 withReuseIdentifier:(NSString *)p2;
	-(void) registerLoadOnDemandCell:(Class)p0;
	-(void) registerNib:(UINib *)p0 forCellReuseIdentifier:(NSString *)p1;
	-(void) registerNib:(UINib *)p0 forSupplementaryViewOfKind:(NSString *)p1 withReuseIdentifier:(NSString *)p2;
	-(void) reloadData;
	-(void) reloadItemsAtIndexPaths:(NSArray *)p0;
	-(void) scrollToItemAtIndexPath:(NSIndexPath *)p0 atScrollPosition:(NSUInteger)p1 animated:(BOOL)p2;
	-(void) selectItemAtIndexPath:(NSIndexPath *)p0 animated:(BOOL)p1 scrollPosition:(NSUInteger)p2;
	-(BOOL) allowsCellReorder;
	-(void) setAllowsCellReorder:(BOOL)p0;
	-(BOOL) allowsCellSwipe;
	-(void) setAllowsCellSwipe:(BOOL)p0;
	-(BOOL) allowsMultipleSelection;
	-(void) setAllowsMultipleSelection:(BOOL)p0;
	-(BOOL) allowsPullToRefresh;
	-(void) setAllowsPullToRefresh:(BOOL)p0;
	-(BOOL) autoRestrictSwipeDirection;
	-(void) setAutoRestrictSwipeDirection:(BOOL)p0;
	-(CGFloat) autoScrollTreshold;
	-(void) setAutoScrollTreshold:(CGFloat)p0;
	-(UIView *) backgroundView;
	-(void) setBackgroundView:(UIView *)p0;
	-(CGFloat) cellSwipeAnimationDuration;
	-(void) setCellSwipeAnimationDuration:(CGFloat)p0;
	-(UIEdgeInsets) cellSwipeLimits;
	-(void) setCellSwipeLimits:(UIEdgeInsets)p0;
	-(CGFloat) cellSwipeTreshold;
	-(void) setCellSwipeTreshold:(CGFloat)p0;
	-(UIEdgeInsets) contentInset;
	-(void) setContentInset:(UIEdgeInsets)p0;
	-(CGPoint) contentOffset;
	-(void) setContentOffset:(CGPoint)p0;
	-(BOOL) deselectOnSecondTap;
	-(void) setDeselectOnSecondTap:(BOOL)p0;
	-(NSArray *) indexPathsForVisibleItems;
	-(BOOL) isSwiping;
	-(UICollectionViewLayout *) layout;
	-(void) setLayout:(UICollectionViewLayout *)p0;
	-(int) loadOnDemandBufferSize;
	-(void) setLoadOnDemandBufferSize:(int)p0;
	-(int) loadOnDemandMode;
	-(void) setLoadOnDemandMode:(int)p0;
	-(id) loadOnDemandView;
	-(void) setLoadOnDemandView:(id)p0;
	-(NSInteger) numberOfSections;
	-(CGFloat) pullToRefreshTreshold;
	-(void) setPullToRefreshTreshold:(CGFloat)p0;
	-(id) pullToRefreshView;
	-(void) setPullToRefreshView:(id)p0;
	-(NSInteger) reorderMode;
	-(void) setReorderMode:(NSInteger)p0;
	-(int) scrollDirection;
	-(void) setScrollDirection:(int)p0;
	-(int) selectionBehavior;
	-(void) setSelectionBehavior:(int)p0;
	-(NSArray *) visibleCells;
	-(NSObject *) dataSource;
	-(void) setDataSource:(NSObject *)p0;
	-(NSObject *) delegate;
	-(void) setDelegate:(NSObject *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithFrame:(CGRect)p0;
@end

@interface TelerikUI_TKListViewCellBackgroundView_TKListViewCellBackgroundViewAppearance : TelerikUI_TKView_TKViewAppearance {
}
@end

@interface TKListViewCellBackgroundView : TKView {
}
	-(BOOL) allowsMultipleSelection;
	-(void) setAllowsMultipleSelection:(BOOL)p0;
	-(CGFloat) checkInset;
	-(void) setCheckInset:(CGFloat)p0;
	-(id) checkView;
	-(BOOL) isSelectedBackground;
	-(void) setIsSelectedBackground:(BOOL)p0;
	-(BOOL) isVertical;
	-(void) setIsVertical:(BOOL)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKListViewFooterCell_TKListViewFooterCellAppearance : TelerikUI_TKListViewReusableCell_TKListViewReusableCellAppearance {
}
@end

@interface TKListViewFooterCell : TKListViewReusableCell {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKListViewHeaderCell_TKListViewHeaderCellAppearance : TelerikUI_TKListViewReusableCell_TKListViewReusableCellAppearance {
}
@end

@interface TKListViewHeaderCell : TKListViewReusableCell {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKListViewLoadOnDemandCell_TKListViewLoadOnDemandCellAppearance : TelerikUI_TKListViewCell_TKListViewCellAppearance {
}
@end

@interface TKListViewLoadOnDemandCell : TKListViewCell {
}
	-(void) updateState;
	-(UIActivityIndicatorView *) activityIndicator;
	-(void) setActivityIndicator:(UIActivityIndicatorView *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKListViewLoadOnDemandView_TKListViewLoadOnDemandViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface TKListViewLoadOnDemandView : UIView {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKListViewPullToRefreshView_TKListViewPullToRefreshViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface TKListViewPullToRefreshView : UIView {
}
	-(void) startAnimating;
	-(void) stopAnimating;
	-(UIActivityIndicatorView *) activityIndicator;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKModifiedTextField_TKModifiedTextFieldAppearance : UIKit_UITextField_UITextFieldAppearance {
}
@end

@interface TKModifiedTextField : UITextField {
}
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKRadialGauge_TKRadialGaugeAppearance : TelerikUI_TKGauge_TKGaugeAppearance {
}
@end

@interface TKRadialGauge : TKGauge {
}
	-(CGFloat) labelSpacing;
	-(void) setLabelSpacing:(CGFloat)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKSideDrawer_TKSideDrawerAppearance : TelerikUI_TKView_TKViewAppearance {
}
@end

@interface TKSideDrawer : TKView {
}
	-(void) addSection:(id)p0;
	-(id) addSectionWithTitle:(NSString *)p0;
	-(id) addSectionWithTitle:(NSString *)p0 image:(UIImage *)p1;
	-(void) dismiss;
	-(void) insertSection:(id)p0 atIndex:(int)p1;
	-(void) removeAllSections;
	-(void) removeSection:(id)p0;
	-(void) selectItemAtIndexPath:(NSIndexPath *)p0;
	-(void) show;
	-(void) showWithTransition:(int)p0;
	-(BOOL) allowEdgeSwipe;
	-(void) setAllowEdgeSwipe:(BOOL)p0;
	-(BOOL) allowGestures;
	-(void) setAllowGestures:(BOOL)p0;
	-(BOOL) allowScroll;
	-(void) setAllowScroll:(BOOL)p0;
	-(UIView *) content;
	-(void) setContent:(UIView *)p0;
	-(id) delegate;
	-(void) setDelegate:(id)p0;
	-(CGFloat) edgeSwipeTreshold;
	-(void) setEdgeSwipeTreshold:(CGFloat)p0;
	-(UIView *) footerView;
	-(void) setFooterView:(UIView *)p0;
	-(UIView *) headerView;
	-(void) setHeaderView:(UIView *)p0;
	-(UIView *) hostview;
	-(BOOL) isVisible;
	-(int) position;
	-(void) setPosition:(int)p0;
	-(NSArray *) sections;
	-(id) style;
	-(id) theme;
	-(void) setTheme:(id)p0;
	-(NSString *) title;
	-(void) setTitle:(NSString *)p0;
	-(CGFloat) transitionDuration;
	-(void) setTransitionDuration:(CGFloat)p0;
	-(id) transitionManager;
	-(void) setTransitionManager:(id)p0;
	-(int) transition;
	-(void) setTransition:(int)p0;
	-(CGFloat) width;
	-(void) setWidth:(CGFloat)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKSideDrawerHeader_TKSideDrawerHeaderAppearance : TelerikUI_TKView_TKViewAppearance {
}
@end

@interface TKSideDrawerHeader : TKView {
}
	-(UIButton *) actionButton;
	-(void) setActionButton:(UIButton *)p0;
	-(int) buttonPosition;
	-(void) setButtonPosition:(int)p0;
	-(UIEdgeInsets) contentInsets;
	-(void) setContentInsets:(UIEdgeInsets)p0;
	-(int) imagePosition;
	-(void) setImagePosition:(int)p0;
	-(UIImageView *) imageView;
	-(UIView *) separator;
	-(id) separatorColor;
	-(void) setSeparatorColor:(id)p0;
	-(id) stack;
	-(UILabel *) titleLabel;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithTitle:(NSString *)p0;
	-(id) initWithTitle:(NSString *)p0 button:(UIButton *)p1;
	-(id) initWithTitle:(NSString *)p0 image:(UIImage *)p1;
	-(id) initWithTitle:(NSString *)p0 button:(UIButton *)p1 image:(UIImage *)p2;
@end

@interface TelerikUI_TKSideDrawerTableView_TKSideDrawerTableViewAppearance : UIKit_UITableView_UITableViewAppearance {
}
@end

@interface TKSideDrawerTableView : UITableView {
}
	-(id) sideDrawer;
	-(void) setSideDrawer:(id)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithSideDrawer:(id)p0;
@end

@interface TelerikUI_TKSideDrawerTableViewCell_TKSideDrawerTableViewCellAppearance : UIKit_UITableViewCell_UITableViewCellAppearance {
}
@end

@interface TKSideDrawerTableViewCell : UITableViewCell {
}
	-(id) item;
	-(void) setItem:(id)p0;
	-(UIView *) separator;
	-(void) setSeparator:(UIView *)p0;
	-(id) stack;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface TelerikUI_TKSideDrawerView_TKSideDrawerViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface TKSideDrawerView : UIView {
}
	-(void) addSideDrawer:(id)p0;
	-(id) addSideDrawerAtPosition:(int)p0;
	-(void) removeAllSideDrawers;
	-(void) removeSideDrawer:(id)p0;
	-(id) defaultSideDrawer;
	-(UIView *) mainView;
	-(void) setMainView:(UIView *)p0;
	-(NSArray *) sideDrawers;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithFrame:(CGRect)p0 mainView:(UIView *)p1;
	-(id) initWithFrame:(CGRect)p0;
@end

@interface TelerikUI_TKSlideView_TKSlideViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface TKSlideView : UIView {
}
	-(void) next;
	-(void) previous;
	-(UIGestureRecognizer *) bottomSwipe;
	-(void) setBottomSwipe:(UIGestureRecognizer *)p0;
	-(UIView *) currentView;
	-(void) setCurrentView:(UIView *)p0;
	-(id) delegate;
	-(void) setDelegate:(id)p0;
	-(BOOL) isAnimated;
	-(void) setIsAnimated:(BOOL)p0;
	-(BOOL) disableSwipe;
	-(void) setDisableSwipe:(BOOL)p0;
	-(UIGestureRecognizer *) leftSwipe;
	-(void) setLeftSwipe:(UIGestureRecognizer *)p0;
	-(int) slideDirection;
	-(void) setSlideDirection:(int)p0;
	-(int) pageSpacing;
	-(void) setPageSpacing:(int)p0;
	-(UIGestureRecognizer *) rightSwipe;
	-(void) setRightSwipe:(UIGestureRecognizer *)p0;
	-(UIGestureRecognizer *) topSwipe;
	-(void) setTopSwipe:(UIGestureRecognizer *)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithFrame:(CGRect)p0;
@end

@interface TelerikUI_TKSuggestionListView_TKSuggestionListViewAppearance : TelerikUI_TKListView_TKListViewAppearance {
}
@end

@interface TKSuggestionListView : TKListView {
}
	-(id) listView:(id)p0 cellForItemAtIndexPath:(NSIndexPath *)p1;
	-(void) listView:(id)p0 didDeselectItemAtIndexPath:(NSIndexPath *)p1;
	-(void) listView:(id)p0 didFinishSwipeCell:(id)p1 atIndexPath:(NSIndexPath *)p2 withOffset:(CGPoint)p3;
	-(void) listView:(id)p0 didHighlightItemAtIndexPath:(NSIndexPath *)p1;
	-(void) listView:(id)p0 didLongPressCell:(id)p1 atIndexPath:(NSIndexPath *)p2;
	-(void) listView:(id)p0 didPullWithOffset:(CGFloat)p1;
	-(void) didReloadData:(id)p0;
	-(void) listView:(id)p0 didReorderItemFromIndexPath:(NSIndexPath *)p1 toIndexPath:(NSIndexPath *)p2;
	-(void) listView:(id)p0 didSelectItemAtIndexPath:(NSIndexPath *)p1;
	-(void) listView:(id)p0 didSwipeCell:(id)p1 atIndexPath:(NSIndexPath *)p2 withOffset:(CGPoint)p3;
	-(void) listView:(id)p0 didUnhighlightItemAtIndexPath:(NSIndexPath *)p1;
	-(void) hide;
	-(BOOL) listViewShouldRefreshOnPull:(id)p0;
	-(int) listView:(id)p0 numberOfItemsInSection:(int)p1;
	-(int) numberOfSectionsInListView:(id)p0;
	-(void) populateWithItems:(NSArray *)p0;
	-(void) reloadSuggestions;
	-(id) selectedItem;
	-(BOOL) shouldAlwaysHideSuggestionView;
	-(BOOL) listView:(id)p0 shouldDeselectItemAtIndexPath:(NSIndexPath *)p1;
	-(BOOL) listView:(id)p0 shouldHighlightItemAtIndexPath:(NSIndexPath *)p1;
	-(BOOL) listView:(id)p0 shouldLoadMoreDataAtIndexPath:(NSIndexPath *)p1;
	-(BOOL) listView:(id)p0 shouldSelectItemAtIndexPath:(NSIndexPath *)p1;
	-(BOOL) listView:(id)p0 shouldSwipeCell:(id)p1 atIndexPath:(NSIndexPath *)p2;
	-(void) show;
	-(id) listView:(id)p0 viewForSupplementaryElementOfKind:(NSString *)p1 atIndexPath:(NSIndexPath *)p2;
	-(void) willReloadData:(id)p0;
	-(void) listView:(id)p0 willReorderItemAtIndexPath:(NSIndexPath *)p1;
	-(NSArray *) items;
	-(void) setItems:(NSArray *)p0;
	-(id) owner;
	-(void) setOwner:(id)p0;
	-(UIProgressView *) progressBar;
	-(NSIndexPath *) selectedIndexPath;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithAutoComplete:(id)p0;
@end

@interface TelerikUI_TKTextField_TKTextFieldAppearance : UIKit_UITextField_UITextFieldAppearance {
}
@end

@interface TKTextField : UITextField {
}
	-(UIEdgeInsets) textInsets;
	-(void) setTextInsets:(UIEdgeInsets)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithFrame:(CGRect)p0;
@end

@interface TelerikUI_TKViewTransition_TKViewTransitionAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface TKViewTransition : UIView {
}
	-(int) direction;
	-(BOOL) isForward;
	-(BOOL) isVertical;
	-(int) orientation;
	-(float) transitionDuration;
	-(void) setTransitionDuration:(float)p0;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
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


