using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class RestBasedJsonWebService : IRestBasedJsonWebService
{
    // returns a welcome message
    public Student Welcome(string yourName)
    {
        // add welcome message to field of TextMessage object
        Student obj = new Student();
        obj.Name = yourName;
        return obj;
    } // end method Welcome    
}
