using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace SuitemCommerce
{
    
    [BaseType(typeof(NSObject))]
    interface Bean3DS
    {
        // @property (nonatomic, strong) NSString * branch;
        [Export("branch", ArgumentSemantic.Strong)]
        string Branch { get; set; }

        // @property (nonatomic, strong) NSString * company;
        [Export("company", ArgumentSemantic.Strong)]
        string Company { get; set; }

        // @property (nonatomic, strong) NSString * country;
        [Export("country", ArgumentSemantic.Strong)]
        string Country { get; set; }

        // @property (nonatomic, strong) NSString * user;
        [Export("user", ArgumentSemantic.Strong)]
        string User { get; set; }

        // @property (nonatomic, strong) NSString * password;
        [Export("password", ArgumentSemantic.Strong)]
        string Password { get; set; }

        // @property (nonatomic, strong) NSString * merchant;
        [Export("merchant", ArgumentSemantic.Strong)]
        string Merchant { get; set; }

        // @property (assign, nonatomic) enum Currency currency;
        [Export("currency", ArgumentSemantic.Assign)]
        Currency Currency { get; set; }

        // @property (nonatomic, strong) NSString * authKey;
        [Export("authKey", ArgumentSemantic.Strong)]
        string AuthKey { get; set; }

        // @property (nonatomic, strong) NSString * reference;
        [Export("reference", ArgumentSemantic.Strong)]
        string Reference { get; set; }
    }

    // @interface BeanPaymentResponse : NSObject
    [BaseType(typeof(NSObject))]
    interface BeanPaymentResponse
    {
        // @property (nonatomic, strong) NSString * response;
        [Export("response", ArgumentSemantic.Strong)]
        string Response { get; set; }
    }

    [BaseType(typeof(NSObject))]
    interface BeanPaymentWithToken
    {
        // @property (nonatomic, strong) NSString * reference;
        [Export("reference", ArgumentSemantic.Strong)]
        string Reference { get; set; }

        // @property (nonatomic, strong) NSString * response;
        [Export("response", ArgumentSemantic.Strong)]
        string Response { get; set; }

        // @property (nonatomic, strong) NSString * folio;
        [Export("folio", ArgumentSemantic.Strong)]
        string Folio { get; set; }

        // @property (nonatomic, strong) NSString * auth;
        [Export("auth", ArgumentSemantic.Strong)]
        string Auth { get; set; }

        // @property (nonatomic, strong) NSString * cdResponse;
        [Export("cdResponse", ArgumentSemantic.Strong)]
        string CdResponse { get; set; }

        // @property (nonatomic, strong) NSString * cdError;
        [Export("cdError", ArgumentSemantic.Strong)]
        string CdError { get; set; }

        // @property (nonatomic, strong) NSString * nbError;
        [Export("nbError", ArgumentSemantic.Strong)]
        string NbError { get; set; }

        // @property (nonatomic, strong) NSString * company;
        [Export("company", ArgumentSemantic.Strong)]
        string Company { get; set; }

        // @property (nonatomic, strong) NSString * merchant;
        [Export("merchant", ArgumentSemantic.Strong)]
        string Merchant { get; set; }

        // @property (nonatomic, strong) NSString * street;
        [Export("street", ArgumentSemantic.Strong)]
        string Street { get; set; }

        // @property (nonatomic, strong) NSString * ccType;
        [Export("ccType", ArgumentSemantic.Strong)]
        string CcType { get; set; }

        // @property (nonatomic, strong) NSString * tpOperation;
        [Export("tpOperation", ArgumentSemantic.Strong)]
        string TpOperation { get; set; }

        // @property (nonatomic, strong) NSString * ccName;
        [Export("ccName", ArgumentSemantic.Strong)]
        string CcName { get; set; }

        // @property (nonatomic, strong) NSString * ccNumber;
        [Export("ccNumber", ArgumentSemantic.Strong)]
        string CcNumber { get; set; }

        // @property (nonatomic, strong) NSString * ccExpMonth;
        [Export("ccExpMonth", ArgumentSemantic.Strong)]
        string CcExpMonth { get; set; }

        // @property (nonatomic, strong) NSString * ccExpYear;
        [Export("ccExpYear", ArgumentSemantic.Strong)]
        string CcExpYear { get; set; }

        // @property (nonatomic, strong) NSString * amount;
        [Export("amount", ArgumentSemantic.Strong)]
        string Amount { get; set; }

        // @property (nonatomic, strong) NSString * voucher;
        [Export("voucher", ArgumentSemantic.Strong)]
        string Voucher { get; set; }
    }


    [BaseType(typeof(NSObject))]
    interface BeanTokenization
    {
        // @property (nonatomic, strong) NSString * branch;
        [Export("branch", ArgumentSemantic.Strong)]
        string Branch { get; set; }

        // @property (nonatomic, strong) NSString * company;
        [Export("company", ArgumentSemantic.Strong)]
        string Company { get; set; }

        // @property (nonatomic, strong) NSString * country;
        [Export("country", ArgumentSemantic.Strong)]
        string Country { get; set; }

        // @property (nonatomic, strong) NSString * user;
        [Export("user", ArgumentSemantic.Strong)]
        string User { get; set; }

        // @property (nonatomic, strong) NSString * password;
        [Export("password", ArgumentSemantic.Strong)]
        string Password { get; set; }

        // @property (nonatomic, strong) NSString * merchant;
        [Export("merchant", ArgumentSemantic.Strong)]
        string Merchant { get; set; }

        // @property (assign, nonatomic) enum Currency currency;
        [Export("currency", ArgumentSemantic.Assign)]
        Currency Currency { get; set; }

        // @property (nonatomic, strong) NSString * operationType;
        [Export("operationType", ArgumentSemantic.Strong)]
        string OperationType { get; set; }

        // @property (nonatomic, strong) NSString * token;
        [Export("token", ArgumentSemantic.Strong)]
        string Token { get; set; }

        // @property (nonatomic, strong) NSString * amount;
        [Export("amount", ArgumentSemantic.Strong)]
        string Amount { get; set; }

        // @property (nonatomic, strong) NSString * reference;
        [Export("reference", ArgumentSemantic.Strong)]
        string Reference { get; set; }
    }


    // @interface BeanTokenizeResponse : NSObject
    [BaseType(typeof(NSObject))]
    interface BeanTokenizeResponse
    {
        // @property (nonatomic, strong) NSString * token;
        [Export("token", ArgumentSemantic.Strong)]
        string Token { get; set; }
    }


    // @protocol SuiteControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface SuiteControllerDelegate
    {
        // @required -(void)didFinishPayProcess:(NSString *)response error:(SuiteError *)error;
        [Abstract]
        [Export("didFinishPayProcess:error:")]
        void DidFinishPayProcess(string response, SuiteError error);

        // @required -(void)didFinishAuthenticationProcess:(BeanTokenizeResponse *)tokenizeResponse error:(SuiteError *)error;
        [Abstract]
        [Export("didFinishAuthenticationProcess:error:")]
        void DidFinishAuthenticationProcess(BeanTokenizeResponse tokenizeResponse, SuiteError error);

        // @required -(void)didFinishTokenizeTransantion:(BeanPaymentWithToken *)beanPaymentWithToken error:(SuiteError *)error;
        [Abstract]
        [Export("didFinishTokenizeTransantion:error:")]
        void DidFinishTokenizeTransantion(BeanPaymentWithToken beanPaymentWithToken, SuiteError error);

        // @required -(void)operationCanceledByUser;
        [Abstract]
        [Export("operationCanceledByUser")]
        void OperationCanceledByUser();
    }


    [BaseType(typeof(NSObject))]
    interface SuiteController
    {
        [Export("suiteControllerDelegate")]
        SuiteControllerDelegate _delegate { get; set; }
        // -(id)initOnEnvironment:(Environment)environment currentViewController:(UIViewController *)viewController delegate:(id<SuiteControllerDelegate>)delegate;
        [Export("initOnEnvironment:currentViewController:delegate:")]
        IntPtr Constructor(Environment environment, UIViewController viewController, SuiteControllerDelegate @delegate);

        // -(void)sndPayWithCompany:(NSString *)company xmlA:(NSString *)xmlA xmlM:(NSString *)xmlM;
        [Export("sndPayWithCompany:xmlA:xmlM:")]
        void SndPayWithCompany(string company, string xmlA, string xmlM);

        // -(void)AuthenticateWithBeanTokenization:(BeanTokenization *)beanTokenization bean3DS:(Bean3DS *)bean3DS;
        [Export("AuthenticateWithBeanTokenization:bean3DS:")]
        void AuthenticateWithBeanTokenization(BeanTokenization beanTokenization, Bean3DS bean3DS);

        // -(void)sndPayWithTokenWithBeanTokenization:(BeanTokenization *)beanTokenization bean3DS:(Bean3DS *)bean3DS;
        [Export("sndPayWithTokenWithBeanTokenization:bean3DS:")]
        void SndPayWithTokenWithBeanTokenization(BeanTokenization beanTokenization, Bean3DS bean3DS);
    }

    // @interface SuiteError : NSObject
    [BaseType(typeof(NSObject))]
    interface SuiteError
    {
        // -(id)initWithCode:(NSString *)code description:(NSString *)description;
        [Export("initWithCode:description:")]
        IntPtr Constructor(string code, string description);

        // -(NSString *)getCode;
        [Export("getCode")]
        string Code { get; }

        // -(NSString *)getDescription;
        [Export("getDescription")]
        string Description { get; }
    }


}
