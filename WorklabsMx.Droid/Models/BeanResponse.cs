using Com.Mitec.Suitemcommerce.Utilities;

namespace WorklabsMx.Droid.Models
{
    public class BeanResponse
    {
        string reference;
        string response;
        string auth;
        string error;
        string ccName;
        string ccNum;
        string amount;
        string type;
        static long serialVersionUID = 1L;

        public BeanResponse(string response)
        {
            Utilities utilities = new Utilities(null);
            reference = utilities.GetDataXML("referencia", response);
            this.response = utilities.GetDataXML("response", response);
            auth = utilities.GetDataXML("aut", response);
            error = utilities.GetDataXML("error", response);
            ccName = utilities.GetDataXML("ccName", response);
            ccNum = utilities.GetDataXML("ccNum", response);
            amount = utilities.GetDataXML("amount", response);
            type = utilities.GetDataXML("type", response);
        }

        public string getReference()
        {
            return reference;
        }

        public void setReference(string reference)
        {
            this.reference = reference;
        }

        public string getResponse()
        {
            return response;
        }

        public void setResponse(string response)
        {
            this.response = response;
        }

        public string getAuth()
        {
            return auth;
        }

        public void setAuth(string auth)
        {
            this.auth = auth;
        }

        public string getError()
        {
            return error;
        }

        public void setError(string error)
        {
            this.error = error;
        }

        public string getCcName()
        {
            return ccName;
        }

        public void setCcName(string ccName)
        {
            this.ccName = ccName;
        }

        public string getCcNum()
        {
            return ccNum;
        }

        public void setCcNum(string ccNum)
        {
            this.ccNum = ccNum;
        }

        public string getAmount()
        {
            return amount;
        }

        public void setAmount(string amount)
        {
            this.amount = amount;
        }

        public string getType()
        {
            return type;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public static long getSerialVersionUID()
        {
            return serialVersionUID;
        }


        public override string ToString()
        {
            return "BeanPaymentResponse{" +
                    "reference='" + reference + '\'' +
                    ", response='" + response + '\'' +
                    ", auth='" + auth + '\'' +
                    ", error='" + error + '\'' +
                    ", ccName='" + ccName + '\'' +
                    ", ccNum='" + ccNum + '\'' +
                    ", amount='" + amount + '\'' +
                    ", type='" + type + '\'' +
                    '}';
        }

        public void Dispose()
        {
        }
    }
}
