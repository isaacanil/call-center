Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces

Namespace Core.Domain.CccEntidades
    Public Class CccAcuPag
        Inherits DomainObject(Of String)

        Dim _IdCuo As Integer
        Dim _montopag As Decimal
        Dim _IdTran As String
        Dim _codban As String
        Dim _FTran As String
        Dim _FCrea As String
        Dim _FMod As String
        Dim _UCrea As Integer
        Dim _UMod As Integer
        Dim _act As String


        Public Property IdCuo() As Integer
            Get
                Return _IdCuo
            End Get
            Set(ByVal value As Integer)
                _IdCuo = value
            End Set
        End Property
        Public Property montopag() As Decimal
            Get
                Return _montopag
            End Get
            Set(ByVal value As Decimal)
                _montopag = value
            End Set
        End Property
        Public Property IdTran() As String
            Get
                Return _IdTran
            End Get
            Set(ByVal value As String)
                _IdTran = value
            End Set
        End Property
        Public Property codban() As String
            Get
                Return _codban
            End Get
            Set(ByVal value As String)
                _codban = value
            End Set
        End Property

        Public Property FTran() As String
            Get
                Return _FTran
            End Get
            Set(ByVal value As String)
                _FTran = value
            End Set
        End Property

        Public Property FCrea() As String
            Get
                Return _FCrea
            End Get
            Set(ByVal value As String)
                _FCrea = value
            End Set
        End Property

        Public Property FMod() As String
            Get
                Return _FMod
            End Get
            Set(ByVal value As String)
                _FMod = value
            End Set
        End Property
        Public Property UCrea() As Integer
            Get
                Return _UCrea
            End Get
            Set(ByVal value As Integer)
                _UCrea = value
            End Set
        End Property

        Public Property UMod() As Integer
            Get
                Return _UMod
            End Get
            Set(ByVal value As Integer)
                _UMod = value
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


