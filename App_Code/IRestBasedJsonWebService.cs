using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract]
public interface IRestBasedJsonWebService
{
    [OperationContract]
    [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/welcome/{myname}")]  //the name specified in UriTemplate must match the parameter name eg.. myname
    Student Welcome(string myname);

}
[DataContract]
public class Student
{
    [DataMember]
    public string Name  //The name of property is Name
    {
        get; //to get value of the property
        set; //to set value for the property
    }
}
