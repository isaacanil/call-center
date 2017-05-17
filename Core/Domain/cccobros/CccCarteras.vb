Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces

Namespace Core.Domain.CccEntidades
    Public Class CccCarteras
        Inherits DomainObject(Of String)
        Dim _codges As Integer
        Dim _codemp As Integer
        Dim _tip As Integer
        Dim _balpos As Integer
        Dim _balneg As Integer
        Dim _blosi As Integer
        Dim _blono As Integer
        Dim _ticsi As Integer
        Dim _ticno As Integer
        Dim _estret As Integer
        Dim _estact As Integer
        Dim _llam As Integer
        Dim _total As Decimal
        Dim _act As String
        Public Property act() As String
            Get
                Return _act
            End Get
            Set(ByVal value As String)
                _act = value
            End Set
        End Property
        Public Property total() As Decimal
            Get
                Return _total
            End Get
            Set(ByVal value As Decimal)
                _total = value
            End Set
        End Property
        Public Property llam() As Integer
            Get
                Return _llam
            End Get
            Set(ByVal value As Integer)
                _llam = value
            End Set
        End Property
        Public Property estact() As Integer
            Get
                Return _estact
            End Get
            Set(ByVal value As Integer)
                _estact = value
            End Set
        End Property
        Public Property estret() As Integer
            Get
                Return _estret
            End Get
            Set(ByVal value As Integer)
                _estret = value
            End Set
        End Property

        Public Property ticno() As Integer
            Get
                Return _ticno
            End Get
            Set(ByVal value As Integer)
                _ticno = value
            End Set
        End Property
        Public Property ticsi() As Integer
            Get
                Return _ticsi
            End Get
            Set(ByVal value As Integer)
                _ticsi = value
            End Set
        End Property
        Public Property blono() As Integer
            Get
                Return _blono
            End Get
            Set(ByVal value As Integer)
                _blono = value
            End Set
        End Property
        Public Property blosi() As Integer
            Get
                Return _blosi
            End Get
            Set(ByVal value As Integer)
                _blosi = value
            End Set
        End Property
        Public Property balneg() As Integer
            Get
                Return _balneg
            End Get
            Set(ByVal value As Integer)
                _balneg = value
            End Set
        End Property
        Public Property balpos() As Integer
            Get
                Return _balpos
            End Get
            Set(ByVal value As Integer)
                _balpos = value
            End Set
        End Property
        Public Property tip() As Integer
            Get
                Return _tip
            End Get
            Set(ByVal value As Integer)
                _tip = value
            End Set
        End Property
        Public Property codemp() As Integer
            Get
                Return _codemp
            End Get
            Set(ByVal value As Integer)
                _codemp = value
            End Set
        End Property
        Public Property codges() As Integer
            Get
                Return _codges
            End Get
            Set(ByVal value As Integer)
                _codges = value
            End Set
        End Property

    End Class
End Namespace

