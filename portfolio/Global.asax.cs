
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Data.Entity;
using portfolio.Models;
using portfolio.DAL;

using Microsoft.Web.Infrastructure.DynamicModuleHelper;

namespace portfolio
{
	public class MvcApplication : System.Web.HttpApplication
	{

		public static void RegisterModule (Type moduleType)
		{
			DynamicModuleUtility.RegisterModule(moduleType);
		}

		public static void RegisterRoutes (RouteCollection routes)
		{
			routes.IgnoreRoute ("{resource}.axd/{*pathInfo}");

			routes.MapRoute (
				"Default",
				"{controller}/{action}/{id}",
				new { controller = "Home", action = "Index", id = "" }
			);

		}

		public static void RegisterGlobalFilters (GlobalFilterCollection filters)
		{
			filters.Add (new HandleErrorAttribute ());
		}

		protected void Application_Start ()
		{
			AreaRegistration.RegisterAllAreas ();
			RegisterGlobalFilters (GlobalFilters.Filters);
			RegisterRoutes (RouteTable.Routes);

			Database.SetInitializer(new MyDbInitializer());
		}
	}
}