﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMascotas.App_Start
{
    public class AppConfig
    {

        public static string UriBase
        {
            get
            {
                return VirtualPathUtility.ToAbsolute("~/");
            }
        }
    }
}