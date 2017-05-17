Imports System
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.MsjErrorEntidades

Namespace Data
    Public Class EnvioMsj
        Dim FactoryError As IDaoFactoryMsjError
        Dim envioDao As IMsjErrorDao
        Public Sub EnviarLogError(ByVal Usuario As String, ByVal NombrePC As String, ByVal fecha As String, ByVal mensaje As String, ByVal origen As String, ByVal funcion As String)
            Try
                FactoryError = New NHibernateDaoFactoryMsjError
                envioDao = FactoryError.GetMsjErrorDao

                Dim envio As New List(Of MsjError)
                envio = envioDao.SendMsj(Usuario, NombrePC, fecha, mensaje, origen, funcion)
            Catch ex As Exception
                Throw New Exception("Error enviando Log", ex)
            End Try
        End Sub

        End Class

End Namespace

