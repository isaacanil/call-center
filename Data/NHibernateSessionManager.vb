Imports System
Imports System.Collections.Generic
Imports System.Runtime.Remoting.Messaging
Imports System.Text
Imports NHibernate
Imports NHibernate.Cache
Imports System.Web
Imports System.Data
Imports System.Configuration
Imports System.Security.Cryptography

Namespace Data

    Public Class NHibernateSessionManager

#Region "Thread-safe, lazy Singleton"

        Public Shared Property Instancia() As NHibernateSessionManager
            Get
                Return Nested._nHibernateSessionManager
            End Get
            Set(ByVal value As NHibernateSessionManager)

            End Set
        End Property

        Private Class Nested

            Shared Sub New()

            End Sub

            Public Shared ReadOnly _nHibernateSessionManager As New NHibernateSessionManager

        End Class

        Sub New()
            InicializarClase()
        End Sub

#End Region

        Public Function Encriptar(ByVal Input As String) As String

            Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi") 'La clave debe ser de 8 caracteres
            Dim EncryptionKey() As Byte = Convert.FromBase64String("saaSPvIvVRlrcdtzMU8/c37Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave
            Dim buffer() As Byte = Encoding.UTF8.GetBytes(Input)
            Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
            des.Key = EncryptionKey
            des.IV = IV

            Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

        End Function
        Public Function Desencriptar(ByVal Input As String) As String
            Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi") 'La clave debe ser de 8 caracteres
            Dim EncryptionKey() As Byte = Convert.FromBase64String("saaSPvIvVRlrcdtzMU8/c37Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave
            Dim buffer() As Byte = Convert.FromBase64String(Input)
            Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
            des.Key = EncryptionKey
            des.IV = IV
            Return Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length()))
        End Function

        Private Sub InicializarClase()

            'para que no de error la siguiente linea hay que poner en el app.config
            '<configSections>
            '    <section name="nhibernate" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0,Culture=neutral, PublicKeyToken=b77a5c561934e089"/>
            '</configSections>
            Dim cfg As New NHibernate.Cfg.Configuration

            If ConfigurationManager.AppSettings("HBM_MAP_HIBERNATE") Is Nothing Or ConfigurationManager.AppSettings("HBM_MAP_HIBERNATE") = "" Then
                Throw New ConfigurationErrorsException("2HHHH2")
            End If

            'Dim rutaAPP As String = AppDomain.CurrentDomain.BaseDirectory
            'Dim encriptacion As String = Encriptar(rutaAPP & "\Configuracion\fichero_nhibernate.cfg.xml")

            'Ahora con ruta relativa del proyecto
            'cfg.Configure(ConfigurationManager.AppSettings("HBM_MAP_HIBERNATE"))
            cfg.Configure(ConfigurationManager.AppSettings("HBM_MAP_HIBERNATE").Replace("{rutaAPP}", AppDomain.CurrentDomain.BaseDirectory))

            'para poder cargar los xml de enidades por el assembly tienen que estar en modo Recurso incrustado"

            sessionFactory = cfg.BuildSessionFactory()

        End Sub

        Public Sub RegistrarInterceptor(ByVal interceptor As IInterceptor)

            Dim session As ISession
            session = ContextSession

            If Not session Is Nothing And session.IsOpen Then
                Throw New CacheException("You cannot register an interceptor once a session has already been opened")
            End If

            GetSession(interceptor)

        End Sub

        Public Function GetSession() As ISession
            Return GetSession(Nothing)
        End Function

        Public Function GetSession(ByVal interceptor As IInterceptor) As ISession

            Dim session As ISession
            session = ContextSession

            If session Is Nothing Then
                If Not interceptor Is Nothing Then
                    session = sessionFactory.OpenSession(interceptor)
                Else
                    session = sessionFactory.OpenSession()
                End If
                ContextSession = session
            End If

            Return session

        End Function

        Public Sub CloseSession()
            Dim session As ISession
            session = ContextSession

            If Not session Is Nothing And session.IsOpen Then
                session.Flush()
                session.Close()
            End If

            ContextSession = Nothing

        End Sub

        Public Sub BeginTransaction()

            Dim transaction As ITransaction
            transaction = ContextTransaction

            If transaction Is Nothing Then
                transaction = GetSession.BeginTransaction
                ContextTransaction = transaction
            End If

        End Sub

        Public Sub CommitTransaction()

            Dim transaction As ITransaction
            transaction = ContextTransaction

            Try
                If HasOpenTransaction() Then
                    transaction.Commit()
                    ContextTransaction = Nothing
                End If
            Catch
                RollbackTransaction()
            Finally
                CloseSession()

            End Try
        End Sub

        Public Function HasOpenTransaction() As Boolean
            Dim transaction As ITransaction
            transaction = ContextTransaction

            If Not transaction Is Nothing Or Not transaction.WasCommitted Or Not transaction.WasRolledBack Then
                Return True
            Else
                Return False
            End If

        End Function


        Public Sub RollbackTransaction()

            Dim transaction As ITransaction
            transaction = ContextTransaction

            Try
                If HasOpenTransaction() Then
                    transaction.Rollback()
                End If
                ContextTransaction = Nothing

            Finally
                CloseSession()

            End Try
        End Sub

        Private Const TRANSACTION_KEY As String = "CONTEXT_TRANSACTION"
        Private Const SESSION_KEY As String = "CONTEXT_SESSION"
        Dim sessionFactory As ISessionFactory


        Private Property ContextTransaction() As ITransaction
            Get
                If IsInWebContext() Then
                    Return CType(HttpContext.Current.Items(TRANSACTION_KEY), ITransaction)
                Else
                    Return CType(CallContext.GetData(TRANSACTION_KEY), ITransaction)
                End If
            End Get
            Set(ByVal value As ITransaction)
                If IsInWebContext() Then
                    HttpContext.Current.Items(TRANSACTION_KEY) = value
                Else
                    CallContext.SetData(TRANSACTION_KEY, value)
                End If
            End Set
        End Property

        Private Property ContextSession() As ISession
            Get
                If IsInWebContext() Then
                    Return CType(HttpContext.Current.Items(SESSION_KEY), ISession)
                Else
                    Return CType(CallContext.GetData(SESSION_KEY), ISession)
                End If
            End Get
            Set(ByVal value As ISession)
                If IsInWebContext() Then
                    HttpContext.Current.Items(SESSION_KEY) = value
                Else
                    CallContext.SetData(SESSION_KEY, value)
                End If
            End Set
        End Property

        Private Function IsInWebContext() As Boolean
            If Not HttpContext.Current Is Nothing Then
                Return True

            Else
                Return False
            End If

        End Function

    End Class

End Namespace