using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.ServiceModel.Activation;

namespace WCFServiceWithJQuery.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWorkService" in both code and config file together.
    [ServiceContract]
    public interface IWorkService
    {
        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,UriTemplate = "DoWork")]
        string DoWork();

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "DoSquare")]
        int DoSquare(int value);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "Add")]
        int Add(AddValue values);
    }

   [DataContract]
    public class AddValue
    {
       [DataMember]
       public int value1 { get; set; }
       [DataMember]
       public int value2 { get; set; }
    }
}
