Imports System
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.CccEntidades
Imports System.Windows.Forms
Imports Core.Domain.Logs
Imports System.Drawing

Public Class cccobros

    Dim FactoryCcc As IDaoFactoryCcc
    Dim AgeDao As IAgeDao
    Dim DatoAgeDao As IDatoAgeDao
    Dim DatoGesAgeDao As IDatoGesAge
    Dim RegistraDao As IRegistraDao
    Dim GesUsuDao As IGesUsuDao
    Dim EjeDao As IEjecutivosDao
    Dim AgeConDao As IAgeConDao
    Dim MotDao As IMotDao
    Dim IncDao As IIncDao
    Dim ConDao As IConDao
    Dim TecDao As ITecnicosDao
    Dim ClasLotDao As IClasLotDao
    Dim ProvDao As IProvDao
    Dim MunDao As IMunDao
    Dim SecDao As ISecDao
    Dim EstConAgeDao As IEstConAgeDao
    Dim carDao As ICarDao
    Dim GComboDao As IGenericComboDao
    Dim HisLLaDao As ICccHisLLa
    Dim HisLlaActDao As ICccHisLLaAct
    Dim InfFinAgeDao As IInfFinAgeDao
    Dim reg_bind As New BindingSource
    Dim EjeBind As New BindingSource
    Dim TecBind As New BindingSource
    Dim cont As String
    Dim SolTK As Boolean = False
    Private Sub cccobros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'NHibernateSessionManager.Instancia.BeginTransaction()
            FactoryCcc = New NHibernateDaoFactoryCcc
            AgeDao = FactoryCcc.GetAgeDao
            DatoAgeDao = FactoryCcc.GetDatoAgeDao
            RegistraDao = FactoryCcc.SetRegistraDao
            GesUsuDao = FactoryCcc.GetGesUsuDao
            EjeDao = FactoryCcc.GetEjecutivosDao
            MotDao = FactoryCcc.GetMotDao
            IncDao = FactoryCcc.GetIncDao
            ConDao = FactoryCcc.GetConDao
            ClasLotDao = FactoryCcc.GetClasLotDao
            ProvDao = FactoryCcc.GetProvDao
            MunDao = FactoryCcc.GetMunDao
            SecDao = FactoryCcc.GetSecDao
            EstConAgeDao = FactoryCcc.GetEstConAgeDao
            carDao = FactoryCcc.GetCarDao
            TecDao = FactoryCcc.GetTecnicosDao
            AgeConDao = FactoryCcc.GetAgeConDao
            DatoGesAgeDao = FactoryCcc.GetDatoGesAge
            GComboDao = FactoryCcc.GetGenericComboDao
            HisLLaDao = FactoryCcc.GetHisLLa
            HisLlaActDao = FactoryCcc.GetHisLLaAct
            InfFinAgeDao = FactoryCcc.GetInfFinAgeDao

            'carga tipo contactos
            Me.cmb_icon.DataSource = GComboDao.GetTipCon()
            Me.cmb_icon.DisplayMember = "descr"
            Me.cmb_icon.ValueMember = "id"

            'carga de gestores
            Me.CmbGes.DataSource = GesUsuDao.GetByUsu()
            Me.CmbGes.DisplayMember = "nomges"
            Me.CmbGes.ValueMember = "id"

            'carga de ejecutivos
            Me.CmbEje.DataSource = EjeDao.GetByEmp()
            Me.CmbEje.DisplayMember = "nombre"
            Me.CmbEje.ValueMember = "id"

            EjeBind.DataSource = CmbEje.DataSource

            'carga estado de contacto de agente
            Me.CmbCon.DataSource = EstConAgeDao.GetByEst()
            Me.CmbCon.DisplayMember = "des"
            Me.CmbCon.ValueMember = "id"

            'carga de clasificacion de loterias
            Me.CmbClaLot.DataSource = ClasLotDao.GetByClas("L")
            Me.CmbClaLot.DisplayMember = "clas"
            Me.CmbClaLot.ValueMember = "id"

            'carga de provincias
            Me.CmbPro.DataSource = ProvDao.GetByProv
            Me.CmbPro.DisplayMember = "despro"
            Me.CmbPro.ValueMember = "id"

            'carga de tecnicos
            TecBind.DataSource = TecDao.GetByTec()

            Me.pag_reg.Parent = Nothing

        Catch ex As Exception
            Dim logEr As New LogErrorWrite
            logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

            Dim EnviaErr As New EnvioMsj
            EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)

            MsgBox("Error en la carga de formulario. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub limpia_campos()
        Me.dgv_agentes.DataSource = ""
        Me.lbl_tk.Visible = False
        Me.txt_pro.Text = ""
        Me.txt1.Text = ""

        Me.txt_dir.Text = ""
        Me.txt_rep.Text = ""
        Me.txt_ruta.Text = ""
        Me.txt_eje.Text = ""
        Me.txt_ges.Text = ""
        Me.txt_esta.Text = ""
        Me.txt_clas.Text = ""
        Me.lbl_total.Text = "0"
        Me.lbl_sv.Visible = False
    End Sub

    Private Sub cargar_InfFinAge(ByVal age As String)
        Dim _InfFinAge As New List(Of CccInfFinAge)
        _InfFinAge = InfFinAgeDao.GetByage(age)
        txt_FacLR.Text = _InfFinAge.Item(0).FacLR
        txt_FacQJM.Text = _InfFinAge.Item(0).FacQJM
        txt_BalGralLR.Text = _InfFinAge.Item(0).BalGralLR
        txt_BalGralQJM.Text = _InfFinAge.Item(0).BalGralQJM
        txt_BalDiaQJM.Text = _InfFinAge.Item(0).BalDiaQJM
        txt_BalDiaLR.Text = _InfFinAge.Item(0).BalDiaLR

    End Sub
    Private Sub carga_datos_agens(ByVal age As String)
        Try
            'cargamos los datos del agente
            Dim l_DatoAge As New List(Of CccDatoAge)
            l_DatoAge = DatoAgeDao.GetByAge(age)
            If Not l_DatoAge Is Nothing Then
                Me.txt_rep.Text = l_DatoAge.Item(0).nomrep

                Me.txt_email.Text = l_DatoAge.Item(0).email
                Me.txt_pro.Text = l_DatoAge.Item(0).descpro
                Me.txt_mun.Text = l_DatoAge.Item(0).desmun
                Me.txt_sec.Text = l_DatoAge.Item(0).dessec
                Me.txt_dir.Text = l_DatoAge.Item(0).direccion
                Me.btn_latlon.Tag = l_DatoAge.Item(0).cy & "," & l_DatoAge.Item(0).cx
                Me.txt1.Text = l_DatoAge.Item(0).telefono1
                Me.txt2.Text = l_DatoAge.Item(0).telefono2
                Me.txt3.Text = l_DatoAge.Item(0).telcon1
                Me.txt4.Text = l_DatoAge.Item(0).telcon2
                Me.txt5.Text = l_DatoAge.Item(0).fax

            End If
        Catch ex As Exception
            Dim logEr As New LogErrorWrite
            logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

            Dim EnviaErr As New EnvioMsj
            EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)

            MsgBox("Error en la carga de datos generales del agente. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try

        'Me.lbl_reg_age.Text = Me.dgv_agentes.CurrentRow.Cells("ID").Value & " - " & Me.dgv_agentes.CurrentRow.Cells("nombre").Value
    End Sub
    Public Sub Cargar_Datos_GesAge(ByVal ListaGesAge As String)
        Try
            'Esa I_Dato_GesAge variable hace intancia CccDatoGesAge
            Dim I_Dato_GesAge As New List(Of CccDatoGesAge)
            I_Dato_GesAge = DatoGesAgeDao.GetByDatoGesAge(ListaGesAge)
            'Si eso es nada
            If Not I_Dato_GesAge Is Nothing Then
                Dim bloq As String = IIf(I_Dato_GesAge.Item(0).bloqueada = 0, "", "/Bloqueado")
                Me.txt_eje.Text = I_Dato_GesAge.Item(0).ejecutivo
                Me.txt_ges.Text = I_Dato_GesAge.Item(0).nomges
                Me.txt_clas.Text = I_Dato_GesAge.Item(0).classf
                Me.txt_ruta.Text = I_Dato_GesAge.Item(0).codasi
                Me.lbl_tk.Text = I_Dato_GesAge.Item(0).fec_tk
                Me.txt_esta.Text = IIf(I_Dato_GesAge.Item(0).retirada = 0, "Activo", "Retirada") & bloq

            End If

        Catch ex As Exception
            Dim logEr As New LogErrorWrite
            logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

            Dim EnviaErr As New EnvioMsj
            EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)

            MsgBox("Error en la carga de datos generales del agente. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub CargaHistLlaAge(age As String, top As String)
        Try
            Dim histlla As New List(Of CccHisLLa)
            histlla = HisLLaDao.GetByAge(age, top)
            If Not histlla Is Nothing Then
                If histlla.Count > 0 Then
                    dgv_hist.DataSource = histlla
                    Me.lbl_t_ll.Text = histlla.Count
                Else
                    dgv_hist.DataSource = Nothing
                    Me.lbl_t_ll.Text = "0"
                End If
            Else
                dgv_hist.DataSource = Nothing
                Me.lbl_t_ll.Text = "0"
            End If
            
        Catch ex As Exception
            Dim logEr As New LogErrorWrite
            logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

            Dim EnviaErr As New EnvioMsj
            EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)

            MsgBox("Error en la carga de historial de llamada del agente. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub carga_dgv_agentes(ByVal list_agentes As List(Of CccAge))
        Me.dgv_agentes.DataSource = list_agentes
        Me.lbl_total.Text = list_agentes.Count
    End Sub
    Private Sub carga_agentes()
        Try
            Dim age As New List(Of CccAge)

            If IsNumeric(Me.txt_agente.Text) Then
                If Me.txt_agente.Text.Length = 8 Then
                    age = AgeDao.GetByParam("where codgtech = '" & Me.txt_agente.Text & "'", "")
                Else
                    age = AgeDao.GetByParam("where codgtech like '%" & Me.txt_agente.Text & "%' and (codgtech like '8%' or codgtech like '7%' or codgtech like '9%') ", "")
                End If
            Else
                age = AgeDao.GetByParam("where nombre like '%" & Me.txt_agente.Text & "%' and (codgtech like '8%' or codgtech like '7%' or codgtech like '9%') ", "")
            End If
            If Not age Is Nothing Then
                If age.Count = 0 Then
                    limpia_campos()
                    MsgBox("No se encontraron agentes para esta consulta.", MsgBoxStyle.Exclamation, "Call Center")
                Else
                    carga_dgv_agentes(age)
                    Me.dgv_agentes.Focus()
                End If
            Else
                MsgBox("No se encontraron agentes para esta consulta.", MsgBoxStyle.Exclamation, "Call Center")
            End If

        Catch ex As Exception
            Dim logEr As New LogErrorWrite
            logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

            Dim EnviaErr As New EnvioMsj
            EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)

            MsgBox("Error en la carga de consulta avanzada. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub txt_agente_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_agente.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Me.txt_agente.Focused Then
                    carga_agentes()
                End If
            End If
        Catch ex As Exception
            Dim logEr As New LogErrorWrite
            logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

            Dim EnviaErr As New EnvioMsj
            EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)

            MsgBox("Error en la carga de consulta avanzada. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub BtnConAva_MouseHover(sender As Object, e As EventArgs) Handles BtnConAva.MouseHover
        VerConsulta(True)
    End Sub

    Private Sub cccobros_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        VerConsulta(False)
    End Sub

    Private Sub VerConsulta(ByVal ver As Boolean)
        Try
            If ver = True Then
                Me.FlpConAva.Visible = True
                Me.BtnConAva.Visible = False
                Me.GbAge.Enabled = False
                Me.GbInfGen.Enabled = False
                Me.TbReg.Enabled = False
            Else
                Me.FlpConAva.Visible = False
                Me.BtnConAva.Visible = True
                If Me.btn_guardar.Tag = 1 Then Me.GbAge.Enabled = True
                Me.GbInfGen.Enabled = True
                Me.TbReg.Enabled = True
            End If
        Catch ex As Exception
            Dim logEr As New LogErrorWrite
            logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

            Dim EnviaErr As New EnvioMsj
            EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)

            MsgBox("Error en la carga de consulta avanzada. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try

    End Sub
    Private Sub CtrlChb(ByVal chb1 As Object, ByVal chb2 As Object)
        If chb1.checked Then
            chb2.checked = False
        End If
    End Sub
    Private Sub UnCheckChb(ByVal chb As Object, ByVal chb1 As Object, ByVal chb2 As Object)
        If chb.checked = False Then
            chb1.checked = False
            chb2.checked = False
        End If
    End Sub
    Private Sub ChbBalPos_CheckedChanged(sender As Object, e As EventArgs) Handles ChbBalPos.CheckedChanged
        CtrlChb(ChbBalPos, ChbBalNeg)
    End Sub
    Private Sub ChbBalNeg_CheckedChanged(sender As Object, e As EventArgs) Handles ChbBalNeg.CheckedChanged
        CtrlChb(ChbBalNeg, ChbBalPos)
    End Sub
    Private Sub ChbBloSi_CheckedChanged(sender As Object, e As EventArgs) Handles ChbBloSi.CheckedChanged
        CtrlChb(ChbBloSi, ChbBloNo)
    End Sub
    Private Sub ChbBloNo_CheckedChanged(sender As Object, e As EventArgs) Handles ChbBloNo.CheckedChanged
        CtrlChb(ChbBloNo, ChbBloSi)
    End Sub
    Private Sub ChbEstRet_CheckedChanged(sender As Object, e As EventArgs) Handles ChbEstRet.CheckedChanged
        CtrlChb(ChbEstRet, ChbEstAct)
    End Sub
    Private Sub ChbEstAct_CheckedChanged(sender As Object, e As EventArgs) Handles ChbEstAct.CheckedChanged
        CtrlChb(ChbEstAct, ChbEstRet)
    End Sub
    Private Sub ChbTicSi_CheckedChanged(sender As Object, e As EventArgs)
        CtrlChb(ChbTicSi, ChbTicNo)
    End Sub
    Private Sub ChbTicNo_CheckedChanged(sender As Object, e As EventArgs)
        CtrlChb(ChbTicNo, ChbTicSi)
    End Sub
    Private Sub ChbDep_CheckedChanged(sender As Object, e As EventArgs) Handles ChbDep.CheckedChanged
        UnCheckChb(ChbDep, DtpDepDes, DtpDepHas)
    End Sub
    Private Sub ChbRem_CheckedChanged(sender As Object, e As EventArgs) Handles ChbRem.CheckedChanged
        UnCheckChb(ChbRem, DtpRemDes, DtpRemHas)
    End Sub
    Private Sub ChbAcu_CheckedChanged(sender As Object, e As EventArgs) Handles ChbAcu.CheckedChanged
        UnCheckChb(ChbAcu, DtpAcuDes, DtpAcuHas)
    End Sub
    Private Sub ChbPag_CheckedChanged(sender As Object, e As EventArgs) Handles ChbPag.CheckedChanged
        UnCheckChb(ChbPag, DtpPagDes, DtpPagHas)
    End Sub
    Private Sub ChbCom_CheckedChanged(sender As Object, e As EventArgs) Handles ChbCom.CheckedChanged
        UnCheckChb(ChbCom, DtpComDes, DtpComHas)
    End Sub
    Private Sub keyDown_Focus(ctrl As Object, e As KeyEventArgs)
        Try
            If e.KeyCode = Keys.Enter Then
                ctrl.Focus()
            End If
        Catch ex As Exception
            Dim logEr As New LogErrorWrite
            logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

            Dim EnviaErr As New EnvioMsj
            EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)

            MsgBox("Error en la seleccion " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub CmbGes_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbGes.KeyDown
        keyDown_Focus(Me.CmbEje, e)
    End Sub
    Private Sub CmbEje_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbEje.KeyDown
        keyDown_Focus(Me.CmbCon, e)
    End Sub
    Private Sub CmbPro_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbPro.KeyDown
        keyDown_Focus(Me.CmbMun, e)
    End Sub
    Private Sub CmbMun_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbMun.KeyDown
        keyDown_Focus(Me.CmbSec, e)
    End Sub

    Private Sub CmbPro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPro.SelectedIndexChanged
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
    End Sub
    Private Sub CmbMun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMun.SelectedIndexChanged
        If Me.CmbMun.SelectedIndex <> 0 Then
            Me.CmbSec.Enabled = True
            Me.CmbSec.DataSource = SecDao.GetByMun(Me.CmbMun.SelectedValue)
            Me.CmbSec.DisplayMember = "dessec"
            Me.CmbSec.ValueMember = "id"
        Else
            CmbSec.DataSource = Nothing
            CmbSec.Enabled = False
        End If
    End Sub
    Private Sub CargaCartera(tip As Integer, cod As Integer)
        Dim CarList As New List(Of CccCarteras)
        CarList = carDao.GetByCod(tip, cod)
        If Not CarList Is Nothing Then
            Me.LblTicSi.Text = CarList(0).ticsi
            Me.LblTicNo.Text = CarList(0).ticno
            Me.LblBalPos.Text = CarList(0).balpos
            Me.LblBalNeg.Text = CarList(0).balneg
            Me.LblBloSi.Text = CarList(0).blosi
            Me.LblBloNo.Text = CarList(0).blono
            Me.LblEstAct.Text = CarList(0).estact
            Me.LblEstRet.Text = CarList(0).estret
            Me.LblBalCar.Text = IIf(tip = 1, Me.CmbGes.SelectedText, Me.CmbEje.SelectedText)
            Me.TxtBalCar.Text = CarList(0).total
            Me.LblLla.Text = CarList(0).llam
        End If
        Me.GbCar.Visible = True
    End Sub
    Private Sub LimpiaCartera()
        Me.LblTicSi.Text = ""
        Me.LblTicNo.Text = ""
        Me.LblBalPos.Text = ""
        Me.LblBalNeg.Text = ""
        Me.LblBloSi.Text = ""
        Me.LblBloNo.Text = ""
        Me.LblEstAct.Text = ""
        Me.LblEstRet.Text = ""
        Me.TxtBalCar.Text = ""
        Me.LblBalCar.Text = ""
        Me.GbCar.Visible = False
    End Sub
    Private Sub CmbGes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbGes.SelectedIndexChanged
        Try
            If Me.CmbGes.SelectedIndex <> 0 Then
                CargaCartera(1, Me.CmbGes.SelectedValue)
            Else
                If Me.CmbEje.SelectedIndex <> 0 Then
                    CargaCartera(2, Me.CmbEje.SelectedValue)
                Else
                    LimpiaCartera()
                End If
            End If
        Catch ex As Exception
            Dim logEr As New LogErrorWrite
            logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

            Dim EnviaErr As New EnvioMsj
            EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)

            MsgBox("Error en la seleccion " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub CmbEje_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEje.SelectedIndexChanged
        Try
            If Me.CmbGes.SelectedIndex = 0 Then
                If Me.CmbEje.SelectedIndex <> 0 Then
                    CargaCartera(2, Me.CmbEje.SelectedValue)
                Else
                    LimpiaCartera()
                End If
            End If
        Catch ex As Exception
            Dim logEr As New LogErrorWrite
            logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

            Dim EnviaErr As New EnvioMsj
            EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)

            MsgBox("Error en la seleccion " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try

    End Sub
    Private Sub btn_guardar_MouseHover(sender As Object, e As EventArgs) Handles btn_guardar.MouseHover
        If Me.btn_guardar.Tag = 1 Then
            Me.btn_guardar.Text = "INICIAR LLAMADA"
            Me.btn_guardar.Width = 159
        End If
    End Sub
    Private Sub btn_guardar_MouseLeave(sender As Object, e As EventArgs) Handles btn_guardar.MouseLeave
        If Me.btn_guardar.Tag = 1 Then
            Me.btn_guardar.Text = ""
            Me.btn_guardar.Width = 45
        End If
    End Sub
    Private Sub BtnReset_Click(sender As Object, e As EventArgs)
        lbl_seg.Text = 0
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_seg.Text = Val(lbl_seg.Text) + 1
        If lbl_seg.Text = "60" Then
            BtnReset_Click(sender, e)
            lbl_min.Text = Val(lbl_min.Text) + 1
            If lbl_min.Text = "60" Then
                lbl_min.Text = 0
                lbl_hor.Text = Val(lbl_hor.Text) + 1
            End If
        End If
    End Sub
    Private Sub cerrar_llamada()
        Timer1.Enabled = False
        lbl_seg.Text = 0
        lbl_min.Text = 0
        lbl_hor.Text = 0
        Me.txt_cont.Text = ""
    End Sub
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Try
            If Me.btn_guardar.Tag = 1 Then
                Me.btn_guardar.Text = "FINALIZAR LLAMADA"
                Me.btn_guardar.ForeColor = Color.Red
                Me.btn_guardar.Width = 179
                Me.btn_guardar.Tag = 2
                Me.pag_reg.Parent = Me.TbReg
                Me.TbReg.SelectedIndex = 1
                Me.cmb_tip.Focus()
                Me.gbtime.Visible = True
                Timer1.Enabled = True
                Me.reg_bind.Clear()
                Me.dgv_reg.DataSource = reg_bind
                Me.cmb_icon.SelectedIndex = 0
                'Obtener la hora del servicios (hora de inicio)
            Else
                If dgv_agentes.RowCount > 0 Then
                    'INSERTAR LLAMADA
                    Dim reglla As New List(Of CccRegistraLLamada)
                    Dim idcont As Integer = 0
                    If Me.cmbcont.Visible = True Then idcont = Me.cmbcont.SelectedValue
                    Dim dur As String = "" 'duracion de la llamada
                    dur = lbl_hor.Text & ":" & lbl_min.Text & ":" & lbl_seg.Text
                    reglla = RegistraDao.SetLla(idcont, Me.cmb_icon.SelectedValue, Me.cmb_icon.Text, cont, "", cmb_tip.Text, Me.dgv_agentes.CurrentRow.Cells("ID").Value, dur, 1)
                    'INSERTAR REGISTROS
                    If Not reglla Is Nothing Then
                        Dim IdLlam As Integer = reglla.Item(0).ID
                        Dim cuenta As Integer = reg_bind.Count


                        For Each row As DataGridViewRow In dgv_reg.Rows
                            reglla = RegistraDao.SetReg(row.Cells("IdTMIC").Value, IdLlam, row.Cells("NOTA").Value)
                        Next
                    End If

                    'ASIGNAMOS IdLla A ACUERDO DE PAGO

                    'ASIGNAMOS IdLla A HISTORIAL DE ACUERDO
                End If


                'LIMPIAR CAMPOS
                cerrar_llamada()
                Me.btn_guardar.Text = ""
                Me.btn_guardar.ForeColor = Color.Green
                Me.btn_guardar.Width = 45
                Me.btn_guardar.Tag = 1
                Me.pag_reg.Parent = Nothing
                Me.TbReg.TabPages(0).Focus()
                Me.gbtime.Visible = False
                Me.GbAge.Enabled = True
                CargaHistLlaAge(Me.dgv_agentes.CurrentRow.Cells("ID").Value, 10)
            End If
        Catch ex As Exception
            Dim logEr As New LogErrorWrite
            logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

            Dim EnviaErr As New EnvioMsj
            EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)

            MsgBox("Error en registro de llamada" & Chr(13), MsgBoxStyle.Information, "Call Center")
        End Try
    End Sub
    Private Sub cmb_icon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_icon.SelectedIndexChanged
        Try
            If cmb_icon.SelectedIndex = 0 Then 'contactos del agente
                If Me.dgv_agentes.RowCount > 0 Then
                    Me.cmbcont.DataSource = AgeConDao.GetByAge(Me.dgv_agentes.CurrentRow.Cells("ID").Value)
                End If
                Me.cmbcont.Visible = True
                Me.txt_cont.Visible = False
                Me.btnNuevoCont.Visible = True
            ElseIf cmb_icon.SelectedIndex = 1 Then 'ejecutivos
                Me.cmbcont.DataSource = EjeBind.DataSource
                Me.cmbcont.Visible = True
                Me.txt_cont.Visible = False
                Me.btnNuevoCont.Visible = False
            ElseIf cmb_icon.SelectedIndex = 2 Then 'tecnicos
                Me.cmbcont.DataSource = TecBind.DataSource
                Me.cmbcont.Visible = True
                Me.txt_cont.Visible = False
                Me.btnNuevoCont.Visible = False
            ElseIf cmb_icon.SelectedIndex = 3 Then 'todos los empleados
                Me.cmbcont.DataSource = TecBind.DataSource 'por ahora traemos los tecnicos pero aqui deben ir todos los empleados de loto real
                Me.cmbcont.Visible = True
                Me.txt_cont.Visible = False
                Me.btnNuevoCont.Visible = False
            Else
                Me.cmbcont.Visible = False
                Me.btnNuevoCont.Visible = False
                Me.txt_cont.Visible = True
                Me.txt_cont.Focus()
            End If
            Me.cmbcont.DisplayMember = "nombre"
            Me.cmbcont.ValueMember = "id"
        Catch ex As Exception
            Dim logEr As New LogErrorWrite
            logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

            Dim EnviaErr As New EnvioMsj
            EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)

            MsgBox("Error en la carga de contacto " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub btnNuevoCont_Click(sender As Object, e As EventArgs) Handles btnNuevoCont.Click
        Me.cmbcont.Visible = False
        Me.btnNuevoCont.Visible = False
        Me.txt_cont.Visible = True
        Me.txt_cont.Focus()
    End Sub
    Private Sub cmb_tip_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tip.SelectedIndexChanged
        Try
            'carga de motivos
            Me.cmb_mov.DataSource = MotDao.GetByTip(Me.cmb_tip.SelectedIndex + 1)
            Me.cmb_mov.DisplayMember = "des"
            Me.cmb_mov.ValueMember = "id"
        Catch ex As Exception
            Dim logEr As New LogErrorWrite
            logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

            Dim EnviaErr As New EnvioMsj
            EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)

            MsgBox("Error en la seleccion " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub cmb_mov_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_mov.SelectedIndexChanged
        Try
            If cmb_mov.SelectedIndex <> 0 Then
                Me.cmb_inc.DataSource = IncDao.GetByTipMot(Me.cmb_tip.SelectedIndex + 1, Me.cmb_mov.SelectedValue)
                Me.cmb_inc.DisplayMember = "des"
                Me.cmb_inc.ValueMember = "id"
            Else
                cmb_inc.DataSource = Nothing
            End If
        Catch ex As Exception
            Dim logEr As New LogErrorWrite
            logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

            Dim EnviaErr As New EnvioMsj
            EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)

            MsgBox("Error en la seleccion " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub cmb_inc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_inc.SelectedIndexChanged
        Try
            If cmb_inc.SelectedIndex <> 0 Then
                Me.cmb_con.DataSource = ConDao.GetByTipMotInc(Me.cmb_tip.SelectedIndex + 1, Me.cmb_mov.SelectedValue, Me.cmb_inc.SelectedValue)
                Me.cmb_con.DisplayMember = "des"
                Me.cmb_con.ValueMember = "id"
            Else
                cmb_con.DataSource = Nothing
            End If
        Catch ex As Exception
            Dim logEr As New LogErrorWrite
            logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

            Dim EnviaErr As New EnvioMsj
            EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)

            MsgBox("Error en la seleccion " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub inicializar_registro()
        Try
            Me.txt_coment.Text = ""
            Me.cmb_mov.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Error inicializando registros. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub Agrega_reg(age As String, mot As String, id_mot As String, inc As String, id_inc As String, con As String, id_con As String, nota As String)
        Me.reg_bind.AddNew()
        Me.dgv_reg.CurrentRow.Cells("RETAILER").Value = age
        Me.dgv_reg.CurrentRow.Cells("MOTIVO").Value = mot
        Me.dgv_reg.CurrentRow.Cells("ID_MOTIVO").Value = id_mot
        Me.dgv_reg.CurrentRow.Cells("INCIDENCIA").Value = inc
        Me.dgv_reg.CurrentRow.Cells("ID_INCIDENCIA").Value = id_inc
        Me.dgv_reg.CurrentRow.Cells("CONCLUSION").Value = con
        Me.dgv_reg.CurrentRow.Cells("ID_CONCLUSION").Value = id_con
        Me.dgv_reg.CurrentRow.Cells("NOTA").Value = nota
        Me.dgv_reg.CurrentRow.Cells("IdTMIC").Value = GComboDao.GetTMIC(Me.cmb_tip.SelectedIndex + 1, id_mot, id_inc, id_con).Item(0).ID

        Select Case Me.dgv_reg.CurrentRow.Cells("IdTMIC").Value 'En caso de que se solicite la apertura de un ticket
            Case 6, 13
                SolTK = True
        End Select

        inicializar_registro()
        Me.GbAge.Enabled = False
        Me.cmb_tip.Enabled = True
        Me.cmb_mov.Focus()
    End Sub
    Private Sub btn_agrega_act_Click(sender As Object, e As EventArgs) Handles btn_agrega_act.Click
        Try
            If cmb_tip.Text <> "" And cmb_mov.Text <> "" And cmb_inc.Text <> "" And cmb_con.Text <> "" And cont <> "" Then
                If Me.dgv_agentes.RowCount > 0 Then
                    Dim reg As Boolean = True
                    For Each row As DataGridViewRow In dgv_reg.Rows
                        If dgv_reg.Item("MOTIVO", row.Index).Value = cmb_mov.Text And dgv_reg.Item("INCIDENCIA", row.Index).Value = cmb_inc.Text Then
                            MsgBox("La Incidencia seleccionada ya se encuentra registrada." & Chr(13), MsgBoxStyle.Information, "Call Center")
                            reg = False
                            Exit For
                        End If
                    Next
                    If reg Then
                        Agrega_reg(Me.dgv_agentes.CurrentRow.Cells("ID").Value, cmb_mov.Text, cmb_mov.SelectedValue, cmb_inc.Text, cmb_inc.SelectedValue, cmb_con.Text, cmb_con.SelectedValue, txt_coment.Text)
                    End If
                Else
                    MsgBox("Debe seleccionar el agente para realizar el registro." & Chr(13), MsgBoxStyle.Critical, "Call Center")
                    Me.txt_agente.Focus()
                End If
            Else
                MsgBox("Complete todos los campos para realizar el registro" & Chr(13), MsgBoxStyle.Critical, "Call Center")
            End If

        Catch ex As Exception
            Dim logEr As New LogErrorWrite
            logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

            Dim EnviaErr As New EnvioMsj
            EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)

            MsgBox("Error en la seleccion " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub txt_cont_GotFocus(sender As Object, e As EventArgs) Handles txt_cont.GotFocus
        cont = txt_cont.Text
    End Sub
    Private Sub txt_cont_LostFocus(sender As Object, e As EventArgs) Handles txt_cont.LostFocus
        cont = txt_cont.Text
    End Sub
    Private Sub cmb_eje_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcont.SelectedIndexChanged
        cont = cmbcont.Text
    End Sub
    Private Sub dgv_agentes_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_agentes.SelectionChanged
        Try
            If Me.dgv_agentes.RowCount > 0 Then
                Cargar_Datos_GesAge(Me.dgv_agentes.CurrentRow.Cells("ID").Value)
                carga_datos_agens(Me.dgv_agentes.CurrentRow.Cells("ID").Value)
                CargaHistLlaAge(Me.dgv_agentes.CurrentRow.Cells("ID").Value, 10)
                cargar_InfFinAge(Me.dgv_agentes.CurrentRow.Cells("ID").Value)
            End If
            'carga contacto de llamada
            If Me.cmb_icon.SelectedIndex = 0 Then
                Me.cmb_icon.SelectedIndex = 1
            End If
        Catch ex As Exception
            Dim logEr As New LogErrorWrite
            logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

            Dim EnviaErr As New EnvioMsj
            EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)

            MsgBox("Error al cargar detalle de Agente: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub cmb_top_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_top.SelectedIndexChanged
        Try
            CargaHistLlaAge(Me.dgv_agentes.CurrentRow.Cells("ID").Value, cmb_top.Text.Substring(cmb_top.Text.Length - 2, 2))
        Catch ex As Exception
            Dim logEr As New LogErrorWrite
            logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

            Dim EnviaErr As New EnvioMsj
            EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)

            MsgBox("Error al cargar historial de llamdas: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub btn_mod_Click(sender As Object, e As EventArgs) Handles btn_mod.Click
        
        If Me.dgv_agentes.RowCount > 0 Then
            Dim childformMod As New cccModDatoAge
            childformMod.txt_rep.Text = Me.txt_rep.Text

            'Cargamos las provincias
            childformMod.CmbPro.DataSource = Me.CmbPro.DataSource
            childformMod.CmbPro.DisplayMember = "despro"
            childformMod.CmbPro.ValueMember = "id"
            'Seleccionamos la provincia que tiene el agente
            childformMod.CmbPro.Text = Me.txt_pro.Text

            'cargamos los municipios de la provincia que tiene el agente
            childformMod.CmbMun.Enabled = True
            childformMod.CmbMun.DataSource = MunDao.GetByProv(childformMod.CmbPro.SelectedValue)
            childformMod.CmbMun.DisplayMember = "desmun"
            childformMod.CmbMun.ValueMember = "id"
            'seleccionamos el municipio que tiene el agente
            childformMod.CmbMun.Text = Me.txt_mun.Text

            'cargamos los sectores del municipio que tiene el agente
            childformMod.CmbSec.Enabled = True
            childformMod.CmbSec.DataSource = SecDao.GetByMun(childformMod.CmbMun.SelectedValue)
            childformMod.CmbSec.DisplayMember = "dessec"
            childformMod.CmbSec.ValueMember = "id"
            'seleccionamos el sector que tiene el agente
            childformMod.CmbSec.Text = Me.txt_sec.Text

            'cargamos los datos faltantes
            childformMod.txt_dir.Text = Me.txt_dir.Text
            childformMod.txt1.Text = Me.txt1.Text
            childformMod.txt2.Text = Me.txt2.Text
            childformMod.txt3.Text = Me.txt3.Text
            childformMod.txt4.Text = Me.txt4.Text
            childformMod.txt5.Text = Me.txt5.Text
            childformMod.txt_email.Text = Me.txt_email.Text

            childformMod.ShowDialog()
        End If

    End Sub

    Private Sub dgv_hist_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_hist.CellContentDoubleClick
        Try
            If Me.dgv_hist.RowCount > 0 Then
                Dim childform As New cct_reg_aux
                'Dim t0, t1 As Date
                't0 = CType(Me.dgv_hist.CurrentRow.Cells("HORA").Value, Date)
                't1 = CType(Me.dgv_hist.CurrentRow.Cells("HORA_FIN").Value, Date)

                Dim hla As New List(Of CccHisLlaAct)
                hla = HisLlaActDao.GetByIdLla(Me.dgv_hist.CurrentRow.Cells("id_llam").Value)

                With childform
                    .lbl_llamada.Text = Me.dgv_hist.CurrentRow.Cells("TipLla").Value
                    .lbl_fecha.Text = Me.dgv_hist.CurrentRow.Cells("Fini").Value.ToString.Substring(0, 10)
                    .txt_cont.Text = Me.dgv_hist.CurrentRow.Cells("NomCon").Value
                    .txt_tp_cont.Text = Me.dgv_hist.CurrentRow.Cells("TipCon").Value
                    .lbl_hi.Text = Me.dgv_hist.CurrentRow.Cells("Fini").Value.ToString.Substring(11, 8)
                    .lbl_hf.Text = Me.dgv_hist.CurrentRow.Cells("Ffin").Value.ToString.Substring(11, 8)
                    .lbl_dur.Text = Me.dgv_hist.CurrentRow.Cells("dur").Value
                    .lbl_usu.Text = "aqui va el usuario"
                    'Esto es completado si el usuario es tecnico o administrador ------
                    '.lbl_tk_a.Text = Me.dgv_hist.CurrentRow.Cells("TK_ABIERTOS").Value
                    '.lbl_tk_c.Text = Me.dgv_hist.CurrentRow.Cells("TK_CERRADOS").Value
                    '.lbl_tk_pr.Text = Me.dgv_hist.CurrentRow.Cells("POR_REVISAR").Value
                    '------------------------------------------------------------------

                    'Llenamos el data grid de las actividades registradas en la llamada-
                    .dgv_h_reg.DataSource = hla
                    '-------------------------------------------------------------------
                End With

                childform.ShowDialog()
            End If

        Catch ex As Exception
            Dim logEr As New LogErrorWrite
            logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

            Dim EnviaErr As New EnvioMsj
            EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)

            MsgBox("Error en la carga el detalle de la llamada." & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub dgv_agentes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_agentes.CellContentClick

    End Sub

    Private Sub dgv_hist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_hist.CellContentClick

    End Sub

    Private Sub CmbPro_TabIndexChanged(sender As Object, e As EventArgs) Handles CmbPro.TabIndexChanged

    End Sub

    Private Sub btn_acupag_Click(sender As Object, e As EventArgs) Handles btn_acupag.Click
        If Me.dgv_agentes.RowCount > 0 Then
            Dim chfAcuPag As New AcuPagLis
            chfAcuPag.lbl_Age.Text = Me.dgv_agentes.CurrentRow.Cells("ID").Value & " - " & Me.dgv_agentes.CurrentRow.Cells("nombre").Value
            chfAcuPag.ShowDialog()


        End If
    End Sub
End Class