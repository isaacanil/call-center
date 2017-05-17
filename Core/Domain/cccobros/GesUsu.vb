Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces

Namespace Core.Domain.CccEntidades
    Public Class GesUsu
        Inherits DomainObject(Of String)
        Dim _codges As Integer
        Dim _nomges As String
        Dim _codusu As String

        Public Property codges() As Integer
            Get
                Return _codges
            End Get
            Set(ByVal value As Integer)
                _codges = value
            End Set
        End Property
        Public Property nomges() As String
            Get
                Return _nomges
            End Get
            Set(ByVal value As String)
                _nomges = value
            End Set
        End Property
        Public Property codusu() As String
            Get
                Return _codusu
            End Get
            Set(ByVal value As String)
                _codusu = value
            End Set
        End Property
    End Class
End Namespace

