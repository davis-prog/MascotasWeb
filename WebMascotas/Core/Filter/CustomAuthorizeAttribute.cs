using System.Web.Mvc;
using System.Web.Routing;

namespace WebMascotas.Core.Filter
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        public CustomAuthorizeAttribute(params string[] roles) : base()
        {
            Roles = string.Join(",", roles);
        }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                var path = filterContext.HttpContext.Request.UrlReferrer.PathAndQuery;
                filterContext.Result = new RedirectResult("~/Error/AccessDenied");
            }
            else
            {
                base.HandleUnauthorizedRequest(filterContext); 
                if (filterContext.HttpContext.Request.IsAjaxRequest())
                {
                    var returnUrl = filterContext.HttpContext.Request.UrlReferrer.PathAndQuery;
                    var redirectToUrl = new UrlHelper(filterContext.RequestContext).Action("Login", "Account", new { returnUrl = returnUrl });
                    filterContext.Result = new JavaScriptResult() { Script = "window.location = '" + redirectToUrl + "'" };
                }
                else
                {
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                    {
                        controller = "Login",
                        action = "RegistroDeUsuarioMascota"
                    }));
                }
            }
        }

    }
}