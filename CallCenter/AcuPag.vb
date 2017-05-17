Imports System
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.CccEntidades
Imports System.Windows.Forms
Imports Core.Domain.Logs
Imports System.Drawing

Public Class AcuPag

    Dim bindAcu As New BindingSource
    Private Sub txtTotal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTotal.KeyDown
        If e.KeyCode = Keys.Enter Then
            recalcular(txtTotal.Name)
        End If
    End Sub
    Private Sub cmbPer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPer.SelectedIndexChanged
        recalcular(Me.cmbPer.Name)
    End Sub
    Private Sub txtCanCuo_ValueChanged(sender As Object, e As EventArgs) Handles txtCanCuo.ValueChanged
        recalcular(txtCanCuo.Name)
    End Sub

    Private Sub DtpFecIni_TextChanged(sender As Object, e As EventArgs) Handles DtpFecIni.TextChanged
        'recalcular("DtpFecIni")
    End Sub
    Private Sub DtpFecIni_ValueChanged(sender As Object, e As EventArgs) Handles DtpFecIni.ValueChanged

    End Sub
    Private Sub recalcular(ByVal objMod As String)
        Try
            If cmbPer.SelectedIndex > 0 Then
                'recalculamos nuevamente
                If objMod = "txtTotal" Or objMod = "txtCanCuo" Then
                    If CType(txtTotal.Text, Double) > 0 Then
                        txtMonCuo.Text = CType(txtTotal.Text, Double) / txtCanCuo.Value
                    End If
                End If
                If objMod = "cmbPer" Or objMod = "DtpFecIni" Or objMod = "txtCanCuo" Then
                    Select Case cmbPer.SelectedIndex
                        Case 1
                            DtpFecFin.Text = IIf(txtCanCuo.Value = 1, DtpFecIni.Value, DateAdd(DateInterval.Day, ((txtCanCuo.Value - 1) * 7), DtpFecIni.Value))
                        Case 2
                            MsgBox(DatePart(DateInterval.Day, DtpFecIni.Value))
                            DtpFecFin.Text = IIf(txtCanCuo.Value = 1, DtpFecIni.Value, DateAdd(DateInterval.Day, ((txtCanCuo.Value - 1) * 15), DtpFecIni.Value))
                        Case 3
                            DtpFecFin.Text = IIf(txtCanCuo.Value = 1, DtpFecIni.Value, DateAdd(DateInterval.Month, (txtCanCuo.Value - 1), DtpFecIni.Value))
                    End Select
                End If
            End If
        Catch ex As Exception
            Dim logEr As New LogErrorWrite
            logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

            Dim EnviaErr As New EnvioMsj
            EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)

            MsgBox("Error al recalcular condiciones." & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try

    End Sub


    Private Sub btnGuardaCon_Click(sender As Object, e As EventArgs) Handles btnGuardaCon.Click
        If btnGuardaCon.Tag = "1" Then
            'habilita controles para modificacion

            'verifica si se han realizado pagos a cuotas
            '---------------

            '---------------
            'limpiar datagrid
            btnGuardaCon.Tag = "2"
            btnGuardaCon.Image = My.Resources.disk
            txtTotal.Enabled = True
            cmbPer.Enabled = True
            DtpFecIni.Enabled = True
            txtCanCuo.Enabled = True
            txtMonCuo.Enabled = True
            TT1.SetToolTip(btnGuardaCon, "Guardar")
            dgvAcu.DataSource = bindAcu
        Else
            'guarda cambios
            btnGuardaCon.Tag = "1"
            btnGuardaCon.Image = My.Resources.Pencil
            txtTotal.Enabled = False
            cmbPer.Enabled = False
            DtpFecIni.Enabled = False
            txtCanCuo.Enabled = False
            txtMonCuo.Enabled = False
            TT1.SetToolTip(btnGuardaCon, "Modificar condiciones")

            bindAcu.Clear()

            For i As Integer = 1 To txtCanCuo.Value
                bindAcu.AddNew()
                dgvAcu.CurrentRow.Cells("ncuo").Value = i
                Select Case cmbPer.SelectedIndex
                    Case 1
                        dgvAcu.CurrentRow.Cells("fcuo").Value = IIf(i = 1, DtpFecIni.Value, DateAdd(DateInterval.Day, ((i - 1) * 7), DtpFecIni.Value))
                    Case 2
                        dgvAcu.CurrentRow.Cells("fcuo").Value = IIf(i = 1, DtpFecIni.Value, DateAdd(DateInterval.Month, ((i - 1) / 2), DtpFecIni.Value))
                    Case 3
                        dgvAcu.CurrentRow.Cells("fcuo").Value = IIf(i = 1, DtpFecIni.Value, DateAdd(DateInterval.Month, (i - 1), DtpFecIni.Value))
                End Select

                dgvAcu.CurrentRow.Cells("montocuo").Value = txtMonCuo.Text
                dgvAcu.CurrentRow.Cells("descri").Value = "Espera de pago"
                dgvAcu.CurrentRow.Cells("bal").Value = txtMonCuo.Text
            Next

        End If
    End Sub
End Class