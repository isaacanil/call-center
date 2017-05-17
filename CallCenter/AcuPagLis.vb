Imports System
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.CccEntidades
Imports System.Windows.Forms
Imports Core.Domain.Logs
Imports System.Drawing
Public Class AcuPagLis
    Dim FactoryDao As IDaoFactoryCcc
    Dim AcuDao As IAcuLisDao
    Private Sub AcuPagLis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FactoryDao = New NHibernateDaoFactoryCcc
        AcuDao = FactoryDao.GetAcuLisDao

        Cargar_DgvAcu()

    End Sub
    Public Sub Cargar_DgvAcu()
        Try


            Dim lista As New List(Of CccAcu)

            lista = AcuDao.GetAcuLis("")

            Me.dgv_h_reg.DataSource = lista
        Catch ex As Exception
            Dim logEr As New LogErrorWrite
            logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

            Dim EnviaErr As New EnvioMsj
            EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)

            MsgBox("Error en la carga de formulario Acuerdo de Pagos. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try


    End Sub

End Class


 