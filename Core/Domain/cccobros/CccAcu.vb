Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces

Namespace Core.Domain.CccEntidades
    Public Class CccAcu
        Inherits DomainObject(Of String)
        Dim _age As String
        Dim _monto As String
        Dim _bal As String
        Dim _nCuo As Integer
        Dim _fini As String
        Dim _ffin As String
        Dim _Per As String
        Dim _Est As String
        Dim _color As String
        Dim _uCrea As String 'Nombre del usuario que crea
        Public Property uCrea() As String
            Get
                Return _uCrea
            End Get
            Set(ByVal value As String)
                _uCrea = value
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
        Public Property Est() As String
            Get
                Return _Est
            End Get
            Set(ByVal value As String)
                _Est = value
            End Set
        End Property
        Public Property Per() As String
            Get
                Return _Per
            End Get
            Set(ByVal value As String)
                _Per = value
            End Set
        End Property
        Public Property ffin() As String
            Get
                Return _ffin
            End Get
            Set(ByVal value As String)
                _ffin = value
            End Set
        End Property
        Public Property fini() As String
            Get
                Return _fini
            End Get
            Set(ByVal value As String)
                _fini = value
            End Set
        End Property
        Public Property nCuo() As Integer
            Get
                Return _nCuo
            End Get
            Set(ByVal value As Integer)
                _nCuo = value
            End Set
        End Property
        Public Property bal() As String
            Get
                Return _bal
            End Get
            Set(ByVal value As String)
                _bal = value
            End Set
        End Property
        Public Property monto() As String
            Get
                Return _monto
            End Get
            Set(ByVal value As String)
                _monto = value
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

