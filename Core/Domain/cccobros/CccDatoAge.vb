Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces

Namespace Core.Domain.CccEntidades
    Public Class CccDatoAge
        Inherits DomainObject(Of String)

        Dim _nomrep As String
        Dim _cedrep As String
        Dim _telefono1 As String
        Dim _telefono2 As String
        Dim _telcon1 As String
        Dim _telcon2 As String
        Dim _fax As String
        Dim _email As String
        Dim _cx As String
        Dim _cy As String
        Dim _direccion As String
        Dim _descpro As String
        Dim _desmun As String
        Dim _dessec As String
        Public Property dessec() As String
            Get
                Return _dessec
            End Get
            Set(ByVal value As String)
                _dessec = value
            End Set
        End Property
        Public Property desmun() As String
            Get
                Return _desmun
            End Get
            Set(ByVal value As String)
                _desmun = value
            End Set
        End Property
        Public Property descpro() As String
            Get
                Return _descpro
            End Get
            Set(ByVal value As String)
                _descpro = value
            End Set
        End Property
        Public Property direccion() As String
            Get
                Return _direccion
            End Get
            Set(ByVal value As String)
                _direccion = value
            End Set
        End Property
        Public Property cy() As String
            Get
                Return _cy
            End Get
            Set(ByVal value As String)
                _cy = value
            End Set
        End Property
        Public Property cx() As String
            Get
                Return _cx
            End Get
            Set(ByVal value As String)
                _cx = value
            End Set
        End Property

        Public Property email() As String
            Get
                Return _email
            End Get
            Set(ByVal value As String)
                _email = value
            End Set
        End Property
        Public Property fax() As String
            Get
                Return _fax
            End Get
            Set(ByVal value As String)
                _fax = value
            End Set
        End Property
        Public Property telcon2() As String
            Get
                Return _telcon2
            End Get
            Set(ByVal value As String)
                _telcon2 = value
            End Set
        End Property
        Public Property telcon1() As String
            Get
                Return _telcon1
            End Get
            Set(ByVal value As String)
                _telcon1 = value
            End Set
        End Property
        Public Property telefono2() As String
            Get
                Return _telefono2
            End Get
            Set(ByVal value As String)
                _telefono2 = value
            End Set
        End Property
        Public Property telefono1() As String
            Get
                Return _telefono1
            End Get
            Set(ByVal value As String)
                _telefono1 = value
            End Set
        End Property
        Public Property cedrep() As String
            Get
                Return _cedrep
            End Get
            Set(ByVal value As String)
                _cedrep = value
            End Set
        End Property

        Public Property nomrep() As String
            Get
                Return _nomrep
            End Get
            Set(ByVal value As String)
                _nomrep = value
            End Set
        End Property

    End Class
End Namespace
