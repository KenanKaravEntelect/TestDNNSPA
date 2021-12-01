using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using DotNetNuke.Entities.Portals;
using DotNetNuke.Entities.Users;
using DotNetNuke.Security.Roles;
using DotNetNuke.Web.Api;

namespace TestWebApi
{
  public class TestController : DnnApiController
  {
  
    [HttpGet]
    public async Task<HttpResponseMessage> GetPublicRoles()
    {
      var results = new List<RoleDTO> { new RoleDTO { RoleID = 1, Subscribed = true} };

      return await Task.FromResult(Request.CreateResponse(HttpStatusCode.OK, results, Configuration.Formatters.JsonFormatter));
    }
    [HttpPost]
    public HttpResponseMessage SetRole(RoleDTO dto)
    {
      return Request.CreateResponse(HttpStatusCode.OK);
    }
    public class RoleDTO
    {
      public int RoleID { get; set; }
      public bool Subscribed { get; set; }
    }
  }
  public class SubscribedRoles
  {
    public int RoleId;
    public string RoleName;
    public bool Subscribed;
  }
}
