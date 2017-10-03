using System;

namespace WorklabsMx.iOS.Helpers
{
    public class InternetConectionHelper
    {
        public bool VerificarConexion()
        {
            NetworkStatus internetStatus = Reachability.InternetConnectionStatus();
            return true;
        }
    }
}
