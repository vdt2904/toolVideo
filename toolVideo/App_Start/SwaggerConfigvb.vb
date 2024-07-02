Imports System.Web.Http
Imports WebActivatorEx
Imports Swashbuckle.Application
Imports toolVideo.toolVideo


<Assembly: PreApplicationStartMethod(GetType(SwaggerConfig), "Register")>

Namespace toolVideo
    Public Class SwaggerConfig
        Public Shared Sub Register()
            ' Enable Swagger
            GlobalConfiguration.Configuration.EnableSwagger(Function(c)
                                                                c.SingleApiVersion("v1", "toolVideo API") ' Đặt tên và phiên bản của API của bạn ở đây
                                                            End Function).EnableSwaggerUi(Function(c)
                                                                                              ' Cấu hình Swagger UI (nếu cần thiết)
                                                                                          End Function)
        End Sub
    End Class
End Namespace
