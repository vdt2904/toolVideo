﻿Imports System.Web.Configuration
Imports System.Web.Http
Imports System.Web.Optimization
Imports Microsoft.IdentityModel.Tokens
Imports Microsoft.Owin.Security.Jwt
Imports Microsoft.VisualBasic.ApplicationServices
Imports Owin

Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Sub Application_Start()
        AreaRegistration.RegisterAllAreas()
        GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)
    End Sub
End Class
