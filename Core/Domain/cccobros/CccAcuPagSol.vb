
Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces


Namespace Core.Domain.CccEntidades
    Public Class CccAcuPagSol
        Inherits DomainObject(Of String)

        Dim _IdPag As Integer
        Dim _IdAcue As Integer
        Dim _apro As String
        Dim _observ As String
        Dim _UApro As Integer
        Dim _FCrea As String
        Dim _FMod As String
        Dim _UCrea As Integer
        Dim _UMod As Integer
        Dim _act As String

        Public Property IdPag() As Integer
            Get
                Return _IdPag
            End Get
            Set(ByVal value As Integer)
                _IdPag = value
            End Set
        End Property
        Public Property IdAcue() As Integer
            Get
                Return _IdAcue
            End Get
            Set(ByVal value As Integer)
                _IdAcue = value
            End Set
        End Property

        Public Property apro() As String
            Get
                Return _apro
            End Get
            Set(ByVal value As String)
                _apro = value
            End Set
        End Property

        Public Property observ() As String
            Get
                Return _observ
            End Get
            Set(ByVal value As String)
                _observ = value
            End Set
        End Property
        Public Property UApro() As Integer
            Get
                Return _UApro
            End Get
            Set(ByVal value As Integer)
                _UApro = value
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

