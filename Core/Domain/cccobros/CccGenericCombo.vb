Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces

Namespace Core.Domain.CccEntidades
    Public Class CccGenericCombo
        Inherits DomainObject(Of String)
        Dim _descr As String

        Public Property descr() As String
            Get
                Return _descr
            End Get
            Set(ByVal value As String)
                _descr = value
            End Set
        End Property

    End Class
End Namespace

