using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        var workfowService = new WorkflowServiceWebReference.WorkflowService();
        var request = workfowService.getWorkflowRequest(261887, 383, 0);
        return request.requestName;
    }

    [WebMethod]
    public WorkflowServiceWebReference.WorkflowRequestInfo GetWorkflowRequest(int requestId, int userId)
    {
        var workfowService = new WorkflowServiceWebReference.WorkflowService();
        var request = workfowService.getWorkflowRequest(261887, 383, 0);
        return request;
    }

    

}
