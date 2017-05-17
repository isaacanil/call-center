Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces

Namespace Core.Domain.CccEntidades
    Public Class CccCuoEst
        Inherits DomainObject(Of String)

        Dim _desc As String
        Dim _color As String
        Dim _act As String

        Public Property desc() As String
            Get
                Return _desc
            End Get
            Set(ByVal value As String)
                _desc = value
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

        Public Property act() As String
            Get
                Return _act
            End Get
            Set(ByVal value As String)
                _act = value
            End Set
        End Property
    End Class


End Namespace