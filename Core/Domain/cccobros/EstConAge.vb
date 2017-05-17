Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces

Namespace Core.Domain.CccEntidades
    Public Class EstConAge
        Inherits DomainObject(Of String)
        Dim _act As String
        Dim _des As String
        Dim _color As String

        Public Property act() As String
            Get
                Return _act
            End Get
            Set(ByVal value As String)
                _act = value
            End Set
        End Property

        Public Property des() As String
            Get
                Return _des
            End Get
            Set(ByVal value As String)
                _des = value
            End Set
        End Property

        Public Property color() As String
            Get
                Return _color
            End Get
            Set(ByVal value As String)
                _color = value
            End Set
        End Property

    End Class
End Namespace
