using System;
using Foundation;
using UIKit;
using SuitemCommerce;

namespace WorklabsMx.iOS
{
    public partial class EjemploPagos : SuiteControllerDelegate
    {
        SuiteController suiteController;
        Bean3DS bean3DS;
        BeanTokenization beanTokenization;

        public EjemploPagos()
        {
        }

        public void Pagar(PagosTableViewController VistaPagos)
        {
            suiteController = new SuiteController(SuitemCommerce.Environment.Sandbox, VistaPagos, this);
            beanTokenization = new BeanTokenization
            {
                Branch = "0001",
                Company = "SX001",
                Country = "MX",
                User = "SNDBXUS3R",
                Password = "SNDBXP44S",
                Merchant = "123456",
                Currency = Currency.Mxn,
                OperationType = "6",
                Token = "1234567890124242",
                Reference = "REFERENCIA SNDBX001",
                Amount = "100.00"
            };

            bean3DS = new Bean3DS
            {
                Branch = "0001",
                Company = "SX001",
                Country = "MX",
                User = "SNDBXUS3R",
                Password = "SNDBXP44S",
                Merchant = "123456",
                Currency = Currency.Mxn,
                Reference = "REFERENCIA SNDBX001",
                AuthKey = "516883575148515057485348"
            };
            suiteController.AuthenticateWithBeanTokenization(beanTokenization, bean3DS);
            suiteController.SndPayWithTokenWithBeanTokenization(beanTokenization, bean3DS);
        }


        public override void DidFinishAuthenticationProcess(BeanTokenizeResponse tokenizeResponse, SuiteError error)
        {
            //throw new NotImplementedException();
        }

        public override void DidFinishPayProcess(string response, SuiteError error)
        {
            //throw new NotImplementedException();
        }

        public override void DidFinishTokenizeTransantion(BeanPaymentWithToken beanPaymentWithToken, SuiteError error)
        {
            //throw new NotImplementedException();
        }

        public override void OperationCanceledByUser()
        {
            //throw new NotImplementedException();
        }
    }



}
