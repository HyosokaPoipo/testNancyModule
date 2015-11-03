using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace NancyApplication1.Modules
{
    public class HomeModuleClass : NancyModule
    {
        public HomeModuleClass()
        {
            Get["/"] = param =>
            {
                return View["ViewPage1"];
            };
        }
    }
}