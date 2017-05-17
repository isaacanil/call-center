Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces

Namespace Core.Domain.CccEntidades
    Public Class CccAgeCon
        Inherits DomainObject(Of String)
        Dim _nombre As String
        Dim _age As String
        Public Property nombre() As String
            Get
                Return _nombre
            End Get
            Set(ByVal value As String)
                _nombre = value
            End Set
        End Property

        Public Property age() As String
            Get
                Return _age
            End Get
            Set(ByVal value As String)
                _age = value
            End Set
        End Property

    End Class
End Namespace
