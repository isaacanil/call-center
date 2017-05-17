Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace Core.Domain

    Public MustInherit Class DomainObject(Of idT)

        Dim _id As idT

        Public Property ID() As idT
            Get
                Return _id
            End Get
            Set(ByVal value As idT)
                _id = value
            End Set
        End Property
    End Class

End Namespace

