<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AcuPag
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TT1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbl_reg_age = New System.Windows.Forms.Label()
        Me.cbmPlan = New System.Windows.Forms.ComboBox()
        Me.btnMenPag = New System.Windows.Forms.Button()
        Me.btnMasPag = New System.Windows.Forms.Button()
        Me.btnRep = New System.Windows.Forms.Button()
        Me.btnGuardaCon = New System.Windows.Forms.Button()
        Me.btnEstCue = New System.Windows.Forms.Button()
        Me.btnMasObs = New System.Windows.Forms.Button()
        Me.GbInfGen = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txt_rep = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.gbCond = New System.Windows.Forms.GroupBox()
        Me.txtCanCuo = New System.Windows.Forms.NumericUpDown()
        Me.DtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMonCuo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.gbObs = New System.Windows.Forms.GroupBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbPer = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.gbDist = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTotalGenPag = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblBalGen = New System.Windows.Forms.Label()
        Me.gbPag = New System.Windows.Forms.GroupBox()
        Me.lblTotalPag = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvAcu = New System.Windows.Forms.DataGridView()
        Me.ncuo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fcuo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montocuo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GbInfGen.SuspendLayout()
        Me.gbCond.SuspendLayout()
        CType(Me.txtCanCuo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbObs.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDist.SuspendLayout()
        Me.gbPag.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAcu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TT1
        '
        Me.TT1.AutomaticDelay = 30
        Me.TT1.IsBalloon = True
        '
        'lbl_reg_age
        '
        Me.lbl_reg_age.AutoSize = True
        Me.lbl_reg_age.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_reg_age.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_reg_age.ForeColor = System.Drawing.Color.Red
        Me.lbl_reg_age.Location = New System.Drawing.Point(92, 12)
        Me.lbl_reg_age.Name = "lbl_reg_age"
        Me.lbl_reg_age.Size = New System.Drawing.Size(171, 16)
        Me.lbl_reg_age.TabIndex = 79
        Me.lbl_reg_age.Text = "Seleccione el agente !!!"
        Me.TT1.SetToolTip(Me.lbl_reg_age, "Agente seleccionado")
        '
        'cbmPlan
        '
        Me.cbmPlan.BackColor = System.Drawing.Color.White
        Me.cbmPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmPlan.FormattingEnabled = True
        Me.cbmPlan.Items.AddRange(New Object() {"Semanal", "Quincenal", "Mensual"})
        Me.cbmPlan.Location = New System.Drawing.Point(40, 474)
        Me.cbmPlan.Name = "cbmPlan"
        Me.cbmPlan.Size = New System.Drawing.Size(110, 21)
        Me.cbmPlan.TabIndex = 121
        Me.TT1.SetToolTip(Me.cbmPlan, "Seleccione la plantilla")
        '
        'btnMenPag
        '
        Me.btnMenPag.BackColor = System.Drawing.Color.White
        Me.btnMenPag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMenPag.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenPag.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnMenPag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnMenPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenPag.ForeColor = System.Drawing.Color.Black
        Me.btnMenPag.Image = Global.My.Resources.Resources.money_delete
        Me.btnMenPag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenPag.Location = New System.Drawing.Point(295, 51)
        Me.btnMenPag.Name = "btnMenPag"
        Me.btnMenPag.Size = New System.Drawing.Size(25, 26)
        Me.btnMenPag.TabIndex = 116
        Me.btnMenPag.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TT1.SetToolTip(Me.btnMenPag, "Quitar pago a cuota")
        Me.btnMenPag.UseVisualStyleBackColor = False
        '
        'btnMasPag
        '
        Me.btnMasPag.BackColor = System.Drawing.Color.White
        Me.btnMasPag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMasPag.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMasPag.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnMasPag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnMasPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMasPag.ForeColor = System.Drawing.Color.Black
        Me.btnMasPag.Image = Global.My.Resources.Resources.money_add
        Me.btnMasPag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMasPag.Location = New System.Drawing.Point(295, 19)
        Me.btnMasPag.Name = "btnMasPag"
        Me.btnMasPag.Size = New System.Drawing.Size(25, 26)
        Me.btnMasPag.TabIndex = 82
        Me.btnMasPag.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TT1.SetToolTip(Me.btnMasPag, "Aplicar pago a cuota")
        Me.btnMasPag.UseVisualStyleBackColor = False
        '
        'btnRep
        '
        Me.btnRep.BackColor = System.Drawing.Color.White
        Me.btnRep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRep.ForeColor = System.Drawing.Color.Black
        Me.btnRep.Image = Global.My.Resources.Resources.page_white_acrobat
        Me.btnRep.Location = New System.Drawing.Point(8, 470)
        Me.btnRep.Name = "btnRep"
        Me.btnRep.Size = New System.Drawing.Size(25, 26)
        Me.btnRep.TabIndex = 81
        Me.TT1.SetToolTip(Me.btnRep, "Exportar Estado de Cuenta")
        Me.btnRep.UseVisualStyleBackColor = False
        '
        'btnGuardaCon
        '
        Me.btnGuardaCon.BackColor = System.Drawing.Color.White
        Me.btnGuardaCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardaCon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardaCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardaCon.ForeColor = System.Drawing.Color.Black
        Me.btnGuardaCon.Image = Global.My.Resources.Resources.Pencil
        Me.btnGuardaCon.Location = New System.Drawing.Point(238, 15)
        Me.btnGuardaCon.Name = "btnGuardaCon"
        Me.btnGuardaCon.Size = New System.Drawing.Size(25, 26)
        Me.btnGuardaCon.TabIndex = 115
        Me.btnGuardaCon.Tag = "1"
        Me.TT1.SetToolTip(Me.btnGuardaCon, "Modificar condiciones")
        Me.btnGuardaCon.UseVisualStyleBackColor = False
        '
        'btnEstCue
        '
        Me.btnEstCue.BackColor = System.Drawing.Color.White
        Me.btnEstCue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEstCue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEstCue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEstCue.ForeColor = System.Drawing.Color.Black
        Me.btnEstCue.Image = Global.My.Resources.Resources.database_table
        Me.btnEstCue.Location = New System.Drawing.Point(205, 15)
        Me.btnEstCue.Name = "btnEstCue"
        Me.btnEstCue.Size = New System.Drawing.Size(25, 26)
        Me.btnEstCue.TabIndex = 112
        Me.btnEstCue.Tag = ""
        Me.TT1.SetToolTip(Me.btnEstCue, "Estado de Cuenta")
        Me.btnEstCue.UseVisualStyleBackColor = False
        '
        'btnMasObs
        '
        Me.btnMasObs.BackColor = System.Drawing.Color.White
        Me.btnMasObs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMasObs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMasObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMasObs.ForeColor = System.Drawing.Color.Black
        Me.btnMasObs.Image = Global.My.Resources.Resources.Add
        Me.btnMasObs.Location = New System.Drawing.Point(296, 19)
        Me.btnMasObs.Name = "btnMasObs"
        Me.btnMasObs.Size = New System.Drawing.Size(25, 26)
        Me.btnMasObs.TabIndex = 76
        Me.TT1.SetToolTip(Me.btnMasObs, "Agregar observacion")
        Me.btnMasObs.UseVisualStyleBackColor = False
        '
        'GbInfGen
        '
        Me.GbInfGen.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GbInfGen.Controls.Add(Me.Label6)
        Me.GbInfGen.Controls.Add(Me.TextBox2)
        Me.GbInfGen.Controls.Add(Me.txt_rep)
        Me.GbInfGen.Controls.Add(Me.Label5)
        Me.GbInfGen.Controls.Add(Me.TextBox3)
        Me.GbInfGen.Controls.Add(Me.Label7)
        Me.GbInfGen.Controls.Add(Me.Label4)
        Me.GbInfGen.Controls.Add(Me.Label3)
        Me.GbInfGen.Controls.Add(Me.TextBox1)
        Me.GbInfGen.Controls.Add(Me.TextBox7)
        Me.GbInfGen.Controls.Add(Me.lbl_reg_age)
        Me.GbInfGen.Controls.Add(Me.Label35)
        Me.GbInfGen.ForeColor = System.Drawing.Color.Navy
        Me.GbInfGen.Location = New System.Drawing.Point(2, 6)
        Me.GbInfGen.Name = "GbInfGen"
        Me.GbInfGen.Size = New System.Drawing.Size(774, 77)
        Me.GbInfGen.TabIndex = 40
        Me.GbInfGen.TabStop = False
        Me.GbInfGen.Text = "DATOS DE AGENTE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(667, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "##"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(95, 55)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(105, 20)
        Me.TextBox2.TabIndex = 82
        '
        'txt_rep
        '
        Me.txt_rep.BackColor = System.Drawing.Color.White
        Me.txt_rep.Location = New System.Drawing.Point(95, 32)
        Me.txt_rep.Name = "txt_rep"
        Me.txt_rep.ReadOnly = True
        Me.txt_rep.Size = New System.Drawing.Size(184, 20)
        Me.txt_rep.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(305, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Gestor"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(349, 55)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(160, 20)
        Me.TextBox3.TabIndex = 84
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(553, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 13)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "Estado de Acuerdo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(51, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Cedula"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(289, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Ejecutivo"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(349, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(160, 20)
        Me.TextBox1.TabIndex = 80
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.White
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.ForeColor = System.Drawing.Color.Blue
        Me.TextBox7.Location = New System.Drawing.Point(556, 55)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(160, 15)
        Me.TextBox7.TabIndex = 15
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(7, 35)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(90, 13)
        Me.Label35.TabIndex = 16
        Me.Label35.Text = "Representante"
        '
        'gbCond
        '
        Me.gbCond.BackColor = System.Drawing.Color.Azure
        Me.gbCond.Controls.Add(Me.txtCanCuo)
        Me.gbCond.Controls.Add(Me.btnGuardaCon)
        Me.gbCond.Controls.Add(Me.DtpFecFin)
        Me.gbCond.Controls.Add(Me.Label2)
        Me.gbCond.Controls.Add(Me.txtMonCuo)
        Me.gbCond.Controls.Add(Me.btnEstCue)
        Me.gbCond.Controls.Add(Me.Label15)
        Me.gbCond.Controls.Add(Me.gbObs)
        Me.gbCond.Controls.Add(Me.cmbPer)
        Me.gbCond.Controls.Add(Me.Label14)
        Me.gbCond.Controls.Add(Me.Label12)
        Me.gbCond.Controls.Add(Me.DtpFecIni)
        Me.gbCond.Controls.Add(Me.Label13)
        Me.gbCond.Controls.Add(Me.Label1)
        Me.gbCond.Controls.Add(Me.txtTotal)
        Me.gbCond.ForeColor = System.Drawing.Color.Navy
        Me.gbCond.Location = New System.Drawing.Point(2, 90)
        Me.gbCond.Name = "gbCond"
        Me.gbCond.Size = New System.Drawing.Size(774, 118)
        Me.gbCond.TabIndex = 78
        Me.gbCond.TabStop = False
        Me.gbCond.Text = "CONDICIONES DE ACUERDO"
        '
        'txtCanCuo
        '
        Me.txtCanCuo.Enabled = False
        Me.txtCanCuo.Location = New System.Drawing.Point(329, 45)
        Me.txtCanCuo.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.txtCanCuo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCanCuo.Name = "txtCanCuo"
        Me.txtCanCuo.Size = New System.Drawing.Size(38, 20)
        Me.txtCanCuo.TabIndex = 116
        Me.txtCanCuo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCanCuo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DtpFecFin
        '
        Me.DtpFecFin.Checked = False
        Me.DtpFecFin.Enabled = False
        Me.DtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecFin.Location = New System.Drawing.Point(89, 90)
        Me.DtpFecFin.MinDate = New Date(2017, 4, 8, 0, 0, 0, 0)
        Me.DtpFecFin.Name = "DtpFecFin"
        Me.DtpFecFin.Size = New System.Drawing.Size(111, 20)
        Me.DtpFecFin.TabIndex = 114
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Fecha Fin:"
        '
        'txtMonCuo
        '
        Me.txtMonCuo.BackColor = System.Drawing.Color.White
        Me.txtMonCuo.Enabled = False
        Me.txtMonCuo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonCuo.Location = New System.Drawing.Point(329, 70)
        Me.txtMonCuo.Name = "txtMonCuo"
        Me.txtMonCuo.ReadOnly = True
        Me.txtMonCuo.Size = New System.Drawing.Size(82, 22)
        Me.txtMonCuo.TabIndex = 112
        Me.txtMonCuo.Text = "0.0"
        Me.txtMonCuo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(224, 73)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 13)
        Me.Label15.TabIndex = 111
        Me.Label15.Text = "Monto por Cuota:"
        '
        'gbObs
        '
        Me.gbObs.BackColor = System.Drawing.Color.Azure
        Me.gbObs.Controls.Add(Me.btnMasObs)
        Me.gbObs.Controls.Add(Me.DataGridView3)
        Me.gbObs.ForeColor = System.Drawing.Color.Navy
        Me.gbObs.Location = New System.Drawing.Point(437, 12)
        Me.gbObs.Name = "gbObs"
        Me.gbObs.Size = New System.Drawing.Size(327, 96)
        Me.gbObs.TabIndex = 81
        Me.gbObs.TabStop = False
        Me.gbObs.Text = "OBSERVACIONES"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AllowUserToOrderColumns = True
        Me.DataGridView3.AllowUserToResizeRows = False
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DataGridView3.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataGridView3.Location = New System.Drawing.Point(9, 17)
        Me.DataGridView3.MultiSelect = False
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(287, 72)
        Me.DataGridView3.TabIndex = 2
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 60
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Obaservacion"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 205
        '
        'cmbPer
        '
        Me.cmbPer.BackColor = System.Drawing.Color.White
        Me.cmbPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPer.Enabled = False
        Me.cmbPer.FormattingEnabled = True
        Me.cmbPer.Items.AddRange(New Object() {"", "Semanal", "Quincenal", "Mensual"})
        Me.cmbPer.Location = New System.Drawing.Point(89, 43)
        Me.cmbPer.Name = "cmbPer"
        Me.cmbPer.Size = New System.Drawing.Size(110, 21)
        Me.cmbPer.TabIndex = 105
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(207, 47)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(122, 13)
        Me.Label14.TabIndex = 109
        Me.Label14.Text = "Cantidad de Cuotas:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(35, 51)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 104
        Me.Label12.Text = "Periodo:"
        '
        'DtpFecIni
        '
        Me.DtpFecIni.Checked = False
        Me.DtpFecIni.Enabled = False
        Me.DtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecIni.Location = New System.Drawing.Point(89, 67)
        Me.DtpFecIni.MinDate = New Date(2017, 4, 8, 0, 0, 0, 0)
        Me.DtpFecIni.Name = "DtpFecIni"
        Me.DtpFecIni.Size = New System.Drawing.Size(111, 20)
        Me.DtpFecIni.TabIndex = 108
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(8, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 13)
        Me.Label13.TabIndex = 107
        Me.Label13.Text = "Fecha Inicio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Monto Total:"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(89, 19)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(110, 20)
        Me.txtTotal.TabIndex = 17
        Me.txtTotal.Text = "0.0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gbDist
        '
        Me.gbDist.BackColor = System.Drawing.Color.Azure
        Me.gbDist.Controls.Add(Me.Label10)
        Me.gbDist.Controls.Add(Me.Label11)
        Me.gbDist.Controls.Add(Me.Label8)
        Me.gbDist.Controls.Add(Me.lblTotalGenPag)
        Me.gbDist.Controls.Add(Me.Label9)
        Me.gbDist.Controls.Add(Me.lblBalGen)
        Me.gbDist.Controls.Add(Me.gbPag)
        Me.gbDist.Controls.Add(Me.dgvAcu)
        Me.gbDist.ForeColor = System.Drawing.Color.Navy
        Me.gbDist.Location = New System.Drawing.Point(2, 210)
        Me.gbDist.Name = "gbDist"
        Me.gbDist.Size = New System.Drawing.Size(774, 243)
        Me.gbDist.TabIndex = 80
        Me.gbDist.TabStop = False
        Me.gbDist.Text = "DISTRIBUCION DE CUOTAS - TABLA DE AMORTIZACION"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(8, 215)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 16)
        Me.Label10.TabIndex = 122
        Me.Label10.Text = "Total Acuerdo:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(114, 213)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 20)
        Me.Label11.TabIndex = 121
        Me.Label11.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(515, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 16)
        Me.Label8.TabIndex = 118
        Me.Label8.Text = "Total Gral. de Pagos:"
        '
        'lblTotalGenPag
        '
        Me.lblTotalGenPag.AutoSize = True
        Me.lblTotalGenPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalGenPag.ForeColor = System.Drawing.Color.Blue
        Me.lblTotalGenPag.Location = New System.Drawing.Point(649, 176)
        Me.lblTotalGenPag.Name = "lblTotalGenPag"
        Me.lblTotalGenPag.Size = New System.Drawing.Size(18, 20)
        Me.lblTotalGenPag.TabIndex = 115
        Me.lblTotalGenPag.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(202, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 16)
        Me.Label9.TabIndex = 120
        Me.Label9.Text = "Balance General:"
        '
        'lblBalGen
        '
        Me.lblBalGen.AutoSize = True
        Me.lblBalGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalGen.ForeColor = System.Drawing.Color.Red
        Me.lblBalGen.Location = New System.Drawing.Point(327, 211)
        Me.lblBalGen.Name = "lblBalGen"
        Me.lblBalGen.Size = New System.Drawing.Size(19, 20)
        Me.lblBalGen.TabIndex = 119
        Me.lblBalGen.Text = "0"
        '
        'gbPag
        '
        Me.gbPag.BackColor = System.Drawing.Color.Azure
        Me.gbPag.Controls.Add(Me.lblTotalPag)
        Me.gbPag.Controls.Add(Me.DataGridView1)
        Me.gbPag.Controls.Add(Me.btnMenPag)
        Me.gbPag.Controls.Add(Me.btnMasPag)
        Me.gbPag.Enabled = False
        Me.gbPag.ForeColor = System.Drawing.Color.Navy
        Me.gbPag.Location = New System.Drawing.Point(437, 19)
        Me.gbPag.Name = "gbPag"
        Me.gbPag.Size = New System.Drawing.Size(327, 141)
        Me.gbPag.TabIndex = 118
        Me.gbPag.TabStop = False
        Me.gbPag.Text = "PAGOS A CUOTA"
        '
        'lblTotalPag
        '
        Me.lblTotalPag.AutoSize = True
        Me.lblTotalPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPag.ForeColor = System.Drawing.Color.Blue
        Me.lblTotalPag.Location = New System.Drawing.Point(212, 124)
        Me.lblTotalPag.Name = "lblTotalPag"
        Me.lblTotalPag.Size = New System.Drawing.Size(15, 16)
        Me.lblTotalPag.TabIndex = 121
        Me.lblTotalPag.Text = "0"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn10})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(287, 103)
        Me.DataGridView1.TabIndex = 117
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Referencia"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.ToolTipText = "Transacciones (depositos)"
        Me.DataGridViewTextBoxColumn11.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 60
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.ToolTipText = "Estado de solicitud de pago"
        Me.DataGridViewTextBoxColumn12.Width = 60
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Pago"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 70
        '
        'dgvAcu
        '
        Me.dgvAcu.AllowUserToAddRows = False
        Me.dgvAcu.AllowUserToDeleteRows = False
        Me.dgvAcu.AllowUserToOrderColumns = True
        Me.dgvAcu.AllowUserToResizeRows = False
        Me.dgvAcu.BackgroundColor = System.Drawing.Color.White
        Me.dgvAcu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvAcu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAcu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ncuo, Me.fcuo, Me.montocuo, Me.descri, Me.bal})
        Me.dgvAcu.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvAcu.Location = New System.Drawing.Point(6, 19)
        Me.dgvAcu.MultiSelect = False
        Me.dgvAcu.Name = "dgvAcu"
        Me.dgvAcu.ReadOnly = True
        Me.dgvAcu.RowHeadersVisible = False
        Me.dgvAcu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAcu.Size = New System.Drawing.Size(425, 189)
        Me.dgvAcu.TabIndex = 3
        '
        'ncuo
        '
        Me.ncuo.DataPropertyName = "ncuo"
        Me.ncuo.HeaderText = "No."
        Me.ncuo.Name = "ncuo"
        Me.ncuo.ReadOnly = True
        Me.ncuo.Width = 40
        '
        'fcuo
        '
        Me.fcuo.DataPropertyName = "fcuo"
        Me.fcuo.HeaderText = "Fecha"
        Me.fcuo.Name = "fcuo"
        Me.fcuo.ReadOnly = True
        Me.fcuo.Width = 90
        '
        'montocuo
        '
        Me.montocuo.DataPropertyName = "montocuo"
        Me.montocuo.HeaderText = "Cuota$"
        Me.montocuo.Name = "montocuo"
        Me.montocuo.ReadOnly = True
        Me.montocuo.Width = 90
        '
        'descri
        '
        Me.descri.DataPropertyName = "descri"
        Me.descri.HeaderText = "Estado"
        Me.descri.Name = "descri"
        Me.descri.ReadOnly = True
        Me.descri.Width = 80
        '
        'bal
        '
        Me.bal.DataPropertyName = "bal"
        Me.bal.HeaderText = "Balance$"
        Me.bal.Name = "bal"
        Me.bal.ReadOnly = True
        Me.bal.Width = 90
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.White
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.Black
        Me.btnAceptar.Image = Global.My.Resources.Resources.Clear_Green_Button
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(669, 459)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(107, 37)
        Me.btnAceptar.TabIndex = 86
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'AcuPag
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(778, 497)
        Me.Controls.Add(Me.cbmPlan)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.gbDist)
        Me.Controls.Add(Me.gbCond)
        Me.Controls.Add(Me.GbInfGen)
        Me.Controls.Add(Me.btnRep)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AcuPag"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acuerdo de Pago"
        Me.GbInfGen.ResumeLayout(False)
        Me.GbInfGen.PerformLayout()
        Me.gbCond.ResumeLayout(False)
        Me.gbCond.PerformLayout()
        CType(Me.txtCanCuo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbObs.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDist.ResumeLayout(False)
        Me.gbDist.PerformLayout()
        Me.gbPag.ResumeLayout(False)
        Me.gbPag.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAcu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TT1 As System.Windows.Forms.ToolTip
    Friend WithEvents GbInfGen As System.Windows.Forms.GroupBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txt_rep As System.Windows.Forms.TextBox
    Friend WithEvents gbCond As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_reg_age As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbPer As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DtpFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbDist As System.Windows.Forms.GroupBox
    Friend WithEvents btnRep As System.Windows.Forms.Button
    Friend WithEvents dgvAcu As System.Windows.Forms.DataGridView
    Friend WithEvents btnMasPag As System.Windows.Forms.Button
    Friend WithEvents lblTotalGenPag As System.Windows.Forms.Label
    Friend WithEvents gbObs As System.Windows.Forms.GroupBox
    Friend WithEvents btnMasObs As System.Windows.Forms.Button
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnEstCue As System.Windows.Forms.Button
    Friend WithEvents btnMenPag As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gbPag As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblBalGen As System.Windows.Forms.Label
    Friend WithEvents lblTotalPag As System.Windows.Forms.Label
    Friend WithEvents DtpFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMonCuo As System.Windows.Forms.TextBox
    Friend WithEvents cbmPlan As System.Windows.Forms.ComboBox
    Friend WithEvents btnGuardaCon As System.Windows.Forms.Button
    Friend WithEvents txtCanCuo As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ncuo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fcuo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents montocuo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descri As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
End Class
