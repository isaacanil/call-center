Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces

Namespace Core.Domain.CccEntidades
    Public Class CccRegistraLLamada
        Inherits DomainObject(Of String)
        Dim _resultado As String
        Public Property resultado() As String
            Get
                Return _resultado
            End Get
            Set(value As String)
                _resultado = value
            End Set
        End Property
    End Class
End Namespace

