using System;
using Plugin.KeyChain.Abstractions;
using Security;
using Foundation;

namespace WorklabsMx.iOS.Helpers
{
    public class KeyChainHelper
    {

        public static string serviceId = "KeyChainAccountStore";

        public static bool SetKey(string keyName, string keyValue)
        {

            var statusCode = SecStatusCode.Success;

            var existing = GetKey(keyName);

            if (!string.IsNullOrEmpty(existing))
            {
                DeleteKey(keyName);
            }

            var data = NSData.FromString(keyValue);
            var record = new SecRecord(SecKind.GenericPassword);
            record.Service = serviceId;
            record.Account = keyName;
            record.Generic = data;
            record.Accessible = SecAccessible.WhenUnlocked;

            statusCode = SecKeyChain.Add(record);

            if (statusCode != SecStatusCode.Success)
            {
                return false;
            }
            return true;
        }

        public static string GetKey(string keyName)
        {
            var query = new SecRecord(SecKind.GenericPassword);
            query.Service = serviceId;
            query.Account = keyName;

            SecStatusCode statusCode;
            var record = SecKeyChain.QueryAsRecord(query, out statusCode);

            return statusCode == SecStatusCode.Success ? Uri.UnescapeDataString(record.Generic.ToString()) : "";
        }


        public static bool DeleteKey(string keyName)
        {
            var query = new SecRecord(SecKind.GenericPassword);
            query.Service = serviceId;
            query.Account = keyName;

            var statusCode = SecKeyChain.Remove(query);

            if (statusCode != SecStatusCode.Success)
            {
                return false;
            }
            return true;
        }



    }
}
