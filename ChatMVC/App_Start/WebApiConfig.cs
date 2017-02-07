using System.Web.Http;

namespace ChatMVC
{
    /// <summary>
    /// web api config
    /// </summary>
    public static class WebApiConfig
    {
        #region Public Methods

        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        #endregion
    }
}