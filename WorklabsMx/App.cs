using System.Collections.Generic;

namespace WorklabsMx
{
    public partial class App
    {
        public static bool UseMockDataStore = true;
        public static string BackendUrl = "http://localhost:5000";

        public App()
        {
        }

        public static void Initialize()
        {
        }

        public static IDictionary<string, string> LoginParameters => null;
    }
}
