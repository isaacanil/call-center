Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces


Namespace Core.Domain.CccEntidades
    Public Class CccAcuCuo
        Inherits DomainObject(Of String)
        Dim _IdAcu As Integer
        Dim _IdEstCuo As Integer
        Dim _NCuo As Integer
        Dim _FCuo As String
        Dim _montocuo As Decimal
        Dim _bal As Decimal
        Dim _FCrea As String
        Dim _FMod As String
        Dim _UCrea As Integer
        Dim _UMod As Integer
        Dim _act As String




        Public Property IdAcu() As Integer
            Get
                Return _IdAcu
            End Get
            Set(ByVal value As Integer)
                _IdAcu = value
            End Set
        End Property
        Public Property IdEstCuo() As Integer
            Get
                Return _IdEstCuo
            End Get
            Set(ByVal value As Integer)
                _IdEstCuo = value
            End Set
        End Property



        Public Property NCuo() As Integer
            Get
                Return _NCuo
            End Get
            Set(ByVal value As Integer)
                _NCuo = value
            End Set
        End Property

        Public Property FCuo() As String
            Get
                Return _FCuo
            End Get
            Set(ByVal value As String)
                _FCuo = value
            End Set
        End Property

        Public Property montocuo() As Decimal
            Get
                Return _montocuo
            End Get
            Set(ByVal value As Decimal)
                _montocuo = value
            End Set
        End Property

        Public Property bal() As Decimal
            Get
                Return _bal
            End Get
            Set(ByVal value As Decimal)
                _bal = value
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

