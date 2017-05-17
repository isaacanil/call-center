
Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces

Namespace Core.Domain.CccEntidades
    Public Class CccInfFinAge

        Inherits DomainObject(Of String)
        Dim _BalGralQJM As String
        Dim _BalDiaLR As String
        Dim _BalDiaQJM As String
        Dim _FacLR As String
        Dim _FacQJM As String
        Dim _BalGralLR As String

        Public Property BalGralQJM() As String
            Get
                Return _BalGralQJM
            End Get
            Set(ByVal value As String)
                _BalGralQJM = value
            End Set
        End Property
        Public Property BalDiaLR() As String
            Get
                Return _BalDiaLR
            End Get
            Set(ByVal value As String)
                _BalDiaLR = value
            End Set
        End Property
        Public Property BalDiaQJM() As String
            Get
                Return _BalDiaQJM
            End Get
            Set(ByVal value As String)
                _BalDiaQJM = value
            End Set
        End Property
        Public Property FacLR() As String
            Get
                Return _FacLR
            End Get
            Set(ByVal value As String)
                _FacLR = value
            End Set
        End Property
        Public Property FacQJM() As String
            Get
                Return _FacQJM
            End Get
            Set(ByVal value As String)
                _FacQJM = value
            End Set
        End Property
        Public Property BalGralLR() As String
            Get
                Return _BalGralLR
            End Get
            Set(ByVal value As String)
                _BalGralLR = value
            End Set
        End Property


    End Class
End Namespace

