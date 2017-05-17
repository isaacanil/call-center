
Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces

Namespace Core.Domain.CccEntidades
    Public Class CccAcuObs
        Inherits DomainObject(Of String)

        Dim _obs As String     
        Dim _act As String

        Public Property obs() As String
            Get
                Return _obs
            End Get
            Set(ByVal value As String)
                _obs = value
            End Set
        End Property
        Public Property color() As String
            Get
                Return _act
            End Get
            Set(ByVal value As String)
                _act = value
            End Set
        End Property

       
    End Class
End Namespace

