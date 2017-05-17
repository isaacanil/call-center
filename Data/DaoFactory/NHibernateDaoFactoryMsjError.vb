Imports Core.DataInterfaces
Imports Core.Domain.MsjErrorEntidades
Imports NHibernate
Imports NHibernate.Expression

Namespace Data

    Public Class NHibernateDaoFactoryMsjError
        Implements IDaoFactoryMsjError

#Region "Mensajeria"
        Public Function GetMsjErrorDao() As IMsjErrorDao Implements IDaoFactoryMsjError.GetMsjErrorDao
            Return New MsjErrorDao
        End Function

        Public Class MsjErrorDao
            Inherits GenericNHibernateDao(Of MsjError, String)
            Implements IMsjErrorDao
            Public Function SendMsj(Usuario As String, NombrePc As String, fecha As String, mensaje As String, origen As String, funcion As String) As List(Of MsjError) Implements IMsjErrorDao.SendMsj
                Dim Resulado As IList
                Try
                    Resulado = NHibernateSession.GetNamedQuery("EnvioLogError").SetString("Usuario", Usuario).SetString("NombrePc", NombrePc).SetString("fecha", fecha).SetString("mensaje", mensaje).SetString("origen", origen).SetString("funcion", funcion).List
                    If Resulado.Count > 0 Then
                        Return ConvertToGenericList(Resulado)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error enviando Log", ex)
                    Return Nothing
                End Try
            End Function




        End Class
#End Region


    End Class
End Namespace
