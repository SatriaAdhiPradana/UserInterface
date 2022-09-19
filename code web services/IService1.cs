using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HW3
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebGet(ResponseFormat=WebMessageFormat.Json,UriTemplate="population?input={input}")]
        string population(string input);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "password?passwordLength={passwordLength}")]
        string password(int passwordLength);

        [OperationContract]
        string expenses(double totalBudget, double duration, int members);

        [OperationContract]
        string list(string inputList);
    }
}
