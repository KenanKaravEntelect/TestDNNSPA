using DotNetNuke.Web.Api;

namespace TestWebApi
{
  public class RouteMapper : IServiceRouteMapper
  {
    public void RegisterRoutes(IMapRoute mapRouteManager)
    {
      mapRouteManager.MapHttpRoute("TestWebApi", "default", "{controller}/{action}", new[] { "TestWebApi" });
    }
  }
}
