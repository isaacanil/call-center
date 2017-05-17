Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces

Namespace Core.Domain.CccEntidades
    Public Class Provincias
        Inherits DomainObject(Of String)
        Dim _despro As String

        Public Property despro() As String
            Get
                Return _despro
            End Get
            Set(ByVal value As String)
                _despro = value
            End Set
        End Property

    End Class
End Namespace

