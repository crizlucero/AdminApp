using Foundation;
using System;
using UIKit;
//using SuiteMCommerceBinding;

namespace WorklabsMx.iOS
{
    public partial class PagosTableViewController : UITableViewController
    {


        //SuiteController suiteController;
        //Bean3DS bean3DS;
        //BeanTokenization beanTokenization;

        public PagosTableViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();



            /*suiteController = new SuiteController(Environment.EnvironmentSANDBOX, this, this);
            beanTokenization = new BeanTokenization
            {
                Branch = "0001",
                Company = "SX001",
                Country = "MX",
                User = "SNDBXUS3R",
                Password = "SNDBXP44S",
                Merchant = "123456",
                currency = Currency.CurrencyMXN,
                OperationType = "6",
                Reference = "REFERENCIA SNDBX001"

            };
            bean3DS = new Bean3DS
            {
                Branch = "0001",
                Company = "SX001",
                Country = "MX",
                User = "SNDBXUS3R",
                Password = "SNDBXP44S",
                Merchant = "123456",
                currency = Currency.CurrencyMXN,
                Reference = "REFERENCIA SNDBX001",
                AuthKey = "516883575148515057485348"
            };
            suiteController.AuthenticateWithBeanTokenization(beanTokenization, bean3DS);
            suiteController.SndPayWithTokenWithBeanTokenization(beanTokenization, bean3DS);*/

		}
	}
}