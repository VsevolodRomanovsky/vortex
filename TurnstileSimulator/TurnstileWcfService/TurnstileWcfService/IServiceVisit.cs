using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace TurnstileWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceVisit" in both code and config file together.
    [ServiceContract]
    public interface IServiceVisit
    {
        [OperationContract]
        bool CheckValidation(int permitId, int enterType);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.WrappedResponse)]
        List<Visitor> AllVisitors();
    }
}
