using Plugin.Connectivity;  namespace WorklabsMx.iOS.Helpers {
	public class InternetConectionHelper
	{
		public static bool VerificarConexion()
		{
			if (CrossConnectivity.Current.IsConnected)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	} }  