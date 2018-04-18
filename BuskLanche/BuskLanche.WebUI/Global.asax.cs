﻿using BuskLanche.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Script.Serialization;
using System.Web.Security;
using System.Web.SessionState;

namespace BuskLanche.WebUI
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_PostAuthenticateRequest(Object sender, EventArgs e)
        {
            try
            {
                var authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
                if (authCookie != null)
                {
                    var authTicket = FormsAuthentication.Decrypt(authCookie.Value);
                    var serializer = new JavaScriptSerializer();
                    var serializeModel = serializer.Deserialize<Usuario>(authTicket.UserData);
                    HttpContext.Current.User = serializeModel;
                }
            }
            catch (CryptographicException)
            {
                FormsAuthentication.SignOut();
            }
        }
    }
}