Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces

Namespace Core.Domain.CccEntidades
    Public Class CccHisLLa
        Inherits DomainObject(Of String)
        Dim _TipLla As String
        Dim _NomCon As String
        Dim _TipCon As String
        Dim _dur As String
        Dim _FIni As String
        Dim _FFin As String
        Dim _NomU As String
        Public Property TipLla() As String
            Get
                Return _TipLla
            End Get
            Set(value As String)
                _TipLla = value
            End Set
        End Property
        Public Property NomCon() As String
            Get
                Return _NomCon
            End Get
            Set(value As String)
                _NomCon = value
            End Set
        End Property
        Public Property TipCon() As String
            Get
                Return _TipCon
            End Get
            Set(value As String)
                _TipCon = value
            End Set
        End Property
        Public Property dur() As String
            Get
                Return _dur
            End Get
            Set(value As String)
                _dur = value
            End Set
        End Property
        Public Property FIni() As String
            Get
                Return _FIni
            End Get
            Set(value As String)
                _FIni = value
            End Set
        End Property
        Public Property FFin() As String
            Get
                Return _FFin
            End Get
            Set(value As String)
                _FFin = value
            End Set
        End Property
        Public Property NomU() As String
            Get
                Return _NomU
            End Get
            Set(value As String)
                _NomU = value
            End Set
        End Property
    End Class
End Namespace


