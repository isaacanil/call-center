Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces

Namespace Core.Domain.CccEntidades
    Public Class ClasificacionesLot
        Inherits DomainObject(Of String)
        Dim _clas As String
        Dim _tp_clas As String
        Dim _ri As ULong
        Dim _rf As ULong

        Public Property CLAS() As String
            Get
                Return _clas
            End Get
            Set(value As String)
                _clas = value
            End Set
        End Property

        Public Property TP_CLAS() As String
            Get
                Return _tp_clas
            End Get
            Set(value As String)
                _tp_clas = value
            End Set
        End Property

        Public Property RI() As ULong
            Get
                Return _ri
            End Get
            Set(value As ULong)
                _ri = value
            End Set
        End Property
        Public Property RF() As ULong
            Get
                Return _rf
            End Get
            Set(value As ULong)
                _rf = value
            End Set
        End Property
    End Class
End Namespace