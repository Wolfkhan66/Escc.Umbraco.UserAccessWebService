﻿using System.Web.Mvc;

namespace Escc.Umbraco.UserAccessWebService
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}