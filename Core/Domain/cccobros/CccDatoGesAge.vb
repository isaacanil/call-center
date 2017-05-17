
Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces

Namespace Core.Domain.CccEntidades
    Public Class CccDatoGesAge
        Inherits DomainObject(Of String)
        Dim _nomrep As String
        Dim _nomges As String
        Dim _retirada As Integer
        Dim _bloqueada As Integer
        Dim _class As String
        Dim _codasi As String
        Dim _fec_tk As String

        Public Property ejecutivo() As String
            Get
                Return _nomrep
            End Get
            Set(ByVal value As String)
                _nomrep = value
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

        Public Property retirada() As Integer
            Get
                Return _retirada
            End Get
            Set(ByVal value As Integer)
                _retirada = value
            End Set
        End Property

        Public Property bloqueada() As Integer
            Get
                Return _bloqueada
            End Get
            Set(ByVal value As Integer)
                _bloqueada = value
            End Set
        End Property

        Public Property classf() As String
            Get
                Return _class
            End Get
            Set(ByVal value As String)
                _class = value
            End Set
        End Property

        Public Property codasi() As String
            Get
                Return _codasi
            End Get
            Set(ByVal value As String)
                _codasi = value
            End Set
        End Property

        Public Property fec_tk() As String
            Get
                Return _fec_tk
            End Get
            Set(ByVal value As String)
                _fec_tk = value
            End Set
        End Property






    End Class








End Namespace

