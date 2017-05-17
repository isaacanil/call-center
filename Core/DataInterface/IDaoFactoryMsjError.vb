Imports Core.Domain.MsjErrorEntidades

Namespace Core.DataInterfaces
    Public Interface IDaoFactoryMsjError
        Function GetMsjErrorDao() As IMsjErrorDao

    End Interface
#Region "Mensajeria"
    Public Interface IMsjErrorDao

        Inherits IGenericDao(Of MsjError, String)
        Function SendMsj(ByVal Usuario As String, ByVal NombrePC As String, ByVal fecha As String, ByVal mensaje As String, ByVal origen As String, ByVal funcion As String) As List(Of MsjError)

    End Interface
#End Region

End Namespace

