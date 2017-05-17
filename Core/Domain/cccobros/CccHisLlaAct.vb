Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces

Namespace Core.Domain.CccEntidades
    Public Class CccHisLlaAct
        Inherits DomainObject(Of String)
        Dim _mot As String
        Dim _inc As String
        Dim _con As String
        Dim _nota As String
        Public Property mot() As String
            Get
                Return _mot
            End Get
            Set(value As String)
                _mot = value
            End Set
        End Property
        Public Property inc() As String
            Get
                Return _inc
            End Get
            Set(value As String)
                _inc = value
            End Set
        End Property
        Public Property con() As String
            Get
                Return _con
            End Get
            Set(value As String)
                _con = value
            End Set
        End Property
        Public Property nota() As String
            Get
                Return _nota
            End Get
            Set(value As String)
                _nota = value
            End Set
        End Property
        
    End Class
End Namespace

