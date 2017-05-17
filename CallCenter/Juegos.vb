Imports System
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.CccEntidades
Imports System.Windows.Forms
Imports Core.Domain.Logs
Imports System.Drawing

Public Class Juegos_form

    Dim FactoryCcc As IDaoFactoryCcc
    Dim jueDao As IJuegosDao

    Private Sub Juegos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FactoryCcc = New NHibernateDaoFactoryCcc
        jueDao = FactoryCcc.GetJuegosDao

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim lista As New List(Of Juegos)

            lista = jueDao.GetTodos("")

            Me.DataGridView1.DataSource = lista
        Catch ex As Exception
            Dim logEr As New LogErrorWrite
            logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

            Dim EnviaErr As New EnvioMsj
            EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)

            MsgBox("Error en la carga de formulario. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnvisible.Click
        btnvisible.Visible = True
    End Sub
End Class