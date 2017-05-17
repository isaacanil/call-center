Imports System
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.CccEntidades
Imports System.Windows.Forms
Imports Core.Domain.Logs
Imports System.Drawing
Public Class cccModDatoAge
    Dim FactoryModDatoAge As IDaoFactoryCcc
    Dim ProvDao As IProvDao
    Dim MunDao As IMunDao
    Dim SecDao As ISecDao
    Dim GenericRegDao As IGenericRegDao
    Dim bs As New BindingSource
    Private Sub cccModDatoAge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'NHibernateSessionManager.Instancia.BeginTransaction()
            FactoryModDatoAge = New NHibernateDaoFactoryCcc
            ProvDao = FactoryModDatoAge.GetProvDao
            MunDao = FactoryModDatoAge.GetMunDao
            SecDao = FactoryModDatoAge.GetSecDao
            GenericRegDao = FactoryModDatoAge.GetGenericRegDao

            dgv1.DataSource = bs
            bs.AddNew()
            dgv1.CurrentRow.Cells("nombre").Value = Me.txt_rep.Text
            dgv1.CurrentRow.Cells("nombre").Tag = txt_rep.Tag
            dgv1.CurrentRow.Cells("provincia").Value = Me.CmbPro.Text
            dgv1.CurrentRow.Cells("provincia").Tag = Me.CmbPro.Tag
            dgv1.CurrentRow.Cells("municipio").Value = Me.CmbMun.Text
            dgv1.CurrentRow.Cells("municipio").Tag = Me.CmbMun.Tag
            dgv1.CurrentRow.Cells("sector").Value = Me.CmbSec.Text
            dgv1.CurrentRow.Cells("sector").Tag = Me.CmbSec.Tag
            dgv1.CurrentRow.Cells("direccion").Value = Me.txt_dir.Text
            dgv1.CurrentRow.Cells("direccion").Tag = Me.txt_dir.Tag
            dgv1.CurrentRow.Cells("telefono1").Value = Me.txt1.Text
            dgv1.CurrentRow.Cells("telefono1").Tag = Me.txt1.Tag
            dgv1.CurrentRow.Cells("telefono2").Value = Me.txt2.Text
            dgv1.CurrentRow.Cells("telefono2").Tag = Me.txt2.Tag
            dgv1.CurrentRow.Cells("telefono3").Value = Me.txt3.Text
            dgv1.CurrentRow.Cells("telefono3").Tag = Me.txt3.Tag
            dgv1.CurrentRow.Cells("telefono4").Value = Me.txt4.Text
            dgv1.CurrentRow.Cells("telefono4").Tag = Me.txt4.Tag
            dgv1.CurrentRow.Cells("telefono5").Value = Me.txt5.Text
            dgv1.CurrentRow.Cells("telefono5").Tag = Me.txt5.Tag
            dgv1.CurrentRow.Cells("correo").Value = Me.txt_email.Text
            dgv1.CurrentRow.Cells("correo").Tag = Me.txt_email.Tag

        Catch ex As Exception
            Dim logEr As New LogErrorWrite
            logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

            Dim EnviaErr As New EnvioMsj
            EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)

            MsgBox("Error en la carga de formulario. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
    Private Sub Btnaceptar_Click(sender As Object, e As EventArgs) Handles Btnaceptar.Click
        Try
            Dim str1 As String = ""
            Dim str2 As String = ""
            Dim str3 As String = ""
            Dim str4 As String = ""
            bs.AddNew()
            For Each txt As Object In Me.GbInfGen.Controls
                'verificamos si el campos ha sido modificado y si se solicite que se borre el dato
                If txt.BackColor = Color.LightPink Then
                    dgv1.CurrentRow.Cells(txt.tag).Value = IIf(LTrim(RTrim(txt.text)) = "", "Borrar Dato", txt.text)
                End If
            Next
            For Each txt As Object In Me.GroupBox1.Controls
                If txt.BackColor = Color.LightPink Then
                    dgv1.CurrentRow.Cells(txt.tag).Value = IIf(LTrim(RTrim(txt.text)) = "", "Borrar Dato", txt.text)
                End If
            Next
            For Each col As DataGridViewCell In dgv1.Rows(1).Cells
                'Con este if validamos solo los campos que han sido modificados
                If LTrim(RTrim(col.Value)) <> "" Then
                    If str1 <> "" Then
                        str4 = str4 & " "
                        str1 = str1 & "|" & str4 & dgv1.Rows(0).Cells(col.ColumnIndex).Tag
                        str2 = str2 & "|" & str4 & dgv1.Rows(0).Cells(col.ColumnIndex).Value
                        str3 = str3 & "|" & str4 & col.Value
                    Else
                        str4 = " "
                        str1 = str4 & dgv1.Rows(0).Cells(col.ColumnIndex).Tag
                        str2 = str4 & dgv1.Rows(0).Cells(col.ColumnIndex).Value
                        str3 = str4 & col.Value
                    End If
                End If
            Next
            Dim result As New List(Of CccGenericReg)
            result = GenericRegDao.GetEnvioSolModAge(str1, str2, str3)
            MsgBox(result(0).resultado, MsgBoxStyle.Information, "Call Center")
            Me.Close()
        Catch ex As Exception
            Dim logEr As New LogErrorWrite
            logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

            Dim EnviaErr As New EnvioMsj
            EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)

            MsgBox("Error en la carga de formulario. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub CmbPro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPro.SelectedIndexChanged
        Try
            If Not MunDao Is Nothing Then
                If Me.CmbPro.SelectedIndex <> 0 Then
                    Me.CmbMun.Enabled = True
                    Me.CmbMun.DataSource = MunDao.GetByProv(Me.CmbPro.SelectedValue)
                    Me.CmbMun.DisplayMember = "desmun"
                    Me.CmbMun.ValueMember = "id"
                Else
                    CmbMun.DataSource = Nothing
                    CmbMun.Enabled = False
                    CmbSec.Enabled = False
                End If
                lblpro.Visible = True
                lblmun.Visible = True
                lblsec.Visible = True
                CmbPro.BackColor = Color.LightPink
            End If
        Catch ex As Exception
            MsgBox("Error en la carga de municipios. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub CmbMun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMun.SelectedIndexChanged
        If Not SecDao Is Nothing Then
            If Me.CmbMun.SelectedIndex <> 0 Then
                Me.CmbSec.Enabled = True
                Me.CmbSec.DataSource = SecDao.GetByMun(Me.CmbMun.SelectedValue)
                Me.CmbSec.DisplayMember = "dessec"
                Me.CmbSec.ValueMember = "id"
            Else
                CmbSec.DataSource = Nothing
                CmbSec.Enabled = False
            End If
            lblmun.Visible = True
            lblsec.Visible = True
            CmbMun.BackColor = Color.LightPink
        End If
    End Sub
    Private Sub CmbSec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSec.SelectedIndexChanged
        If Not SecDao Is Nothing Then
            lblsec.Visible = True
            CmbSec.BackColor = Color.LightPink
        End If
    End Sub
    Private Sub txt_rep_TextChanged(sender As Object, e As EventArgs) Handles txt_rep.TextChanged
        If Not MunDao Is Nothing Then
            txt_rep.BackColor = Color.LightPink
        End If
    End Sub
    Private Sub txt_dir_TextChanged(sender As Object, e As EventArgs) Handles txt_dir.TextChanged
        If Not MunDao Is Nothing Then
            txt_dir.BackColor = Color.LightPink
        End If
    End Sub
    Private Sub txt1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged
        If Not MunDao Is Nothing Then
            txt1.BackColor = Color.LightPink
        End If
    End Sub
    Private Sub txt2_TextChanged(sender As Object, e As EventArgs) Handles txt2.TextChanged
        If Not MunDao Is Nothing Then
            txt2.BackColor = Color.LightPink
        End If
    End Sub
    Private Sub txt3_TextChanged(sender As Object, e As EventArgs) Handles txt3.TextChanged
        If Not MunDao Is Nothing Then
            txt3.BackColor = Color.LightPink
        End If
    End Sub
    Private Sub txt4_TextChanged(sender As Object, e As EventArgs) Handles txt4.TextChanged
        If Not MunDao Is Nothing Then
            txt4.BackColor = Color.LightPink
        End If
    End Sub
    Private Sub txt5_TextChanged(sender As Object, e As EventArgs) Handles txt5.TextChanged
        If Not MunDao Is Nothing Then
            txt5.BackColor = Color.LightPink
        End If
    End Sub
    Private Sub txt_email_TextChanged(sender As Object, e As EventArgs) Handles txt_email.TextChanged
        If Not MunDao Is Nothing Then
            txt_email.BackColor = Color.LightPink
        End If
    End Sub
End Class