using Microsoft.AspNetCore.Mvc;
using Nop.Web.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Web;
using Nop.Core.Data;
using System.Data.Entity;
using Nop.Services.Media;
using Nop.Services.Seo;
using System.Globalization;
using System.Threading;
using Nop.Core;
using Nop.Services.Catalog;
using Nop.Services.Topics;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Nop.Core.Domain.Common;
using Nop.Core.Domain.Blogs;
using Nop.Core.Domain.News;
using Nop.Core.Domain.Forums;
using Nop.Core.Domain.Security;
using System.Xml;
using Nop.Core.Infrastructure;
using Nop.Services.Blogs;
using Nop.Services.News;
using Nop.Core.Domain.Catalog;
using Nop.Core.Caching;

namespace Nop.Plugin.Widgets.Arazsoft.Controllers
{


    public class LetsEncryptController : BasePublicController
    {


       
        public async Task<IActionResult> index(string filename)
        {


            //.well-known/acme-challenge/ge8pmTMLcZ3K3Yo88uEbvZWQFTg2QHSanybuzNqZGvo


            if (filename == null)
                return Content("filename not present");



            var path = Path.Combine(
                           Directory.GetCurrentDirectory(), ".well-known", "acme-challenge",
                            filename);



            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, "text/plain", Path.GetFileName(path));
        }

       


    }

}

