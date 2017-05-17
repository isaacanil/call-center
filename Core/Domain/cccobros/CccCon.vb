Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces

Namespace Core.Domain.CccEntidades
    Public Class CccCon
        Inherits DomainObject(Of String)
        Dim _des As String

        Public Property des() As String
            Get
                Return _des
            End Get
            Set(ByVal value As String)
                _des = value
            End Set
        End Property

    End Class
End Namespace

