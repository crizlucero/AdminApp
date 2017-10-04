using System;

namespace WorklabsMx.iOS.Helpers
{
    public class InternetConectionHelper
    {
        public static bool VerificarConexion()
        {
            NetworkStatus internetStatus = Reachability.InternetConnectionStatus();
            switch (internetStatus)
            {
                case NetworkStatus.NotReachable:
                    return false;
				case NetworkStatus.ReachableViaCarrierDataNetwork:
					return true;
				case NetworkStatus.ReachableViaWiFiNetwork:
					return true;
                default:
                    return false;
            }
        }
    }
}
