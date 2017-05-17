Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces

Namespace Core.Domain.CccEntidades
    Public Class Municipios
        Inherits DomainObject(Of String)
        Dim _desmun As String

        Public Property desmun() As String
            Get
                Return _desmun
            End Get
            Set(ByVal value As String)
                _desmun = value
            End Set
        End Property

    End Class
End Namespace
