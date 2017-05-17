Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces

Namespace Core.Domain.CccEntidades
    Public Class Juegos
        Inherits DomainObject(Of String)
        Dim _codigo As String
        Dim _descripcion As String
        Dim _codigojuego As String
        Public Property codigo() As String
            Get
                Return _codigo
            End Get
            Set(ByVal value As String)
                _codigo = value
            End Set
        End Property
        Public Property descripcion() As String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As String)
                _descripcion = value
            End Set
        End Property
        Public Property codigojuego() As String
            Get
                Return _codigojuego
            End Get
            Set(ByVal value As String)
                _codigojuego = value
            End Set
        End Property

    End Class
End Namespace