Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces

Namespace Core.Domain.CccEntidades
    Public Class Sectores
        Inherits DomainObject(Of String)
        Dim _dessec As String

        Public Property dessec() As String
            Get
                Return _dessec
            End Get
            Set(ByVal value As String)
                _dessec = value
            End Set
        End Property

    End Class
End Namespace

