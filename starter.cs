using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Core;
using Autofac.Util;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Nop.Core.Configuration;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;
using Nop.Web.Framework;
using Nop.Web.Framework.Localization;
using Nop.Web.Framework.Mvc.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Builder;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;



namespace Nop.Plugin.Widgets.Sitemap
{
    class RouteProvider : IRouteProvider
    {
        public int Priority => 2000000000;

        public void RegisterRoutes(IRouteBuilder routeBuilder)
        {


            //.well-known/acme-challenge/ge8pmTMLcZ3K3Yo88uEbvZWQFTg2QHSanybuzNqZGvo

            

            routeBuilder.MapLocalizedRoute("well-known", ".well-known/acme-challenge/{filename}", new { controller = "LetsEncrypt", action = "index" });

         
        }
    }

}
