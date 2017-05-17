<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cccModDatoAge
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
        Me.GbInfGen = New System.Windows.Forms.GroupBox()
        Me.lblsec = New System.Windows.Forms.Label()
        Me.lblmun = New System.Windows.Forms.Label()
        Me.lblpro = New System.Windows.Forms.Label()
        Me.CmbSec = New System.Windows.Forms.ComboBox()
        Me.CmbMun = New System.Windows.Forms.ComboBox()
        Me.CmbPro = New System.Windows.Forms.ComboBox()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Btnaceptar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txt_rep = New System.Windows.Forms.TextBox()
        Me.txt_dir = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Municipio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sector = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GbInfGen.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbInfGen
        '
        Me.GbInfGen.BackColor = System.Drawing.Color.Azure
        Me.GbInfGen.Controls.Add(Me.lblsec)
        Me.GbInfGen.Controls.Add(Me.lblmun)
        Me.GbInfGen.Controls.Add(Me.lblpro)
        Me.GbInfGen.Controls.Add(Me.CmbSec)
        Me.GbInfGen.Controls.Add(Me.CmbMun)
        Me.GbInfGen.Controls.Add(Me.CmbPro)
        Me.GbInfGen.Controls.Add(Me.btncancelar)
        Me.GbInfGen.Controls.Add(Me.Btnaceptar)
        Me.GbInfGen.Controls.Add(Me.GroupBox1)
        Me.GbInfGen.Controls.Add(Me.Label22)
        Me.GbInfGen.Controls.Add(Me.Label27)
        Me.GbInfGen.Controls.Add(Me.Label23)
        Me.GbInfGen.Controls.Add(Me.Label24)
        Me.GbInfGen.Controls.Add(Me.Label35)
        Me.GbInfGen.Controls.Add(Me.txt_rep)
        Me.GbInfGen.Controls.Add(Me.txt_dir)
        Me.GbInfGen.ForeColor = System.Drawing.Color.Navy
        Me.GbInfGen.Location = New System.Drawing.Point(1, 4)
        Me.GbInfGen.Name = "GbInfGen"
        Me.GbInfGen.Size = New System.Drawing.Size(356, 259)
        Me.GbInfGen.TabIndex = 40
        Me.GbInfGen.TabStop = False
        Me.GbInfGen.Text = "INFORMACION GENERAL"
        '
        'lblsec
        '
        Me.lblsec.AutoSize = True
        Me.lblsec.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsec.ForeColor = System.Drawing.Color.Red
        Me.lblsec.Location = New System.Drawing.Point(314, 79)
        Me.lblsec.Name = "lblsec"
        Me.lblsec.Size = New System.Drawing.Size(20, 25)
        Me.lblsec.TabIndex = 89
        Me.lblsec.Text = "*"
        Me.lblsec.Visible = False
        '
        'lblmun
        '
        Me.lblmun.AutoSize = True
        Me.lblmun.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmun.ForeColor = System.Drawing.Color.Red
        Me.lblmun.Location = New System.Drawing.Point(314, 57)
        Me.lblmun.Name = "lblmun"
        Me.lblmun.Size = New System.Drawing.Size(20, 25)
        Me.lblmun.TabIndex = 88
        Me.lblmun.Text = "*"
        Me.lblmun.Visible = False
        '
        'lblpro
        '
        Me.lblpro.AutoSize = True
        Me.lblpro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpro.ForeColor = System.Drawing.Color.Red
        Me.lblpro.Location = New System.Drawing.Point(315, 35)
        Me.lblpro.Name = "lblpro"
        Me.lblpro.Size = New System.Drawing.Size(20, 25)
        Me.lblpro.TabIndex = 87
        Me.lblpro.Text = "*"
        Me.lblpro.Visible = False
        '
        'CmbSec
        '
        Me.CmbSec.BackColor = System.Drawing.Color.White
        Me.CmbSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSec.Enabled = False
        Me.CmbSec.FormattingEnabled = True
        Me.CmbSec.Location = New System.Drawing.Point(76, 79)
        Me.CmbSec.Name = "CmbSec"
        Me.CmbSec.Size = New System.Drawing.Size(238, 21)
        Me.CmbSec.TabIndex = 86
        Me.CmbSec.Tag = "Sector"
        '
        'CmbMun
        '
        Me.CmbMun.BackColor = System.Drawing.Color.White
        Me.CmbMun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMun.Enabled = False
        Me.CmbMun.FormattingEnabled = True
        Me.CmbMun.Location = New System.Drawing.Point(76, 57)
        Me.CmbMun.Name = "CmbMun"
        Me.CmbMun.Size = New System.Drawing.Size(238, 21)
        Me.CmbMun.TabIndex = 85
        Me.CmbMun.Tag = "Municipio"
        '
        'CmbPro
        '
        Me.CmbPro.BackColor = System.Drawing.Color.White
        Me.CmbPro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPro.FormattingEnabled = True
        Me.CmbPro.Location = New System.Drawing.Point(76, 35)
        Me.CmbPro.Name = "CmbPro"
        Me.CmbPro.Size = New System.Drawing.Size(238, 21)
        Me.CmbPro.TabIndex = 84
        Me.CmbPro.Tag = "Provincia"
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.White
        Me.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.Black
        Me.btncancelar.Image = Global.My.Resources.Resources.Cancel_Red_Button
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(127, 213)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(100, 39)
        Me.btncancelar.TabIndex = 83
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'Btnaceptar
        '
        Me.Btnaceptar.BackColor = System.Drawing.Color.White
        Me.Btnaceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btnaceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnaceptar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Btnaceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnaceptar.ForeColor = System.Drawing.Color.Black
        Me.Btnaceptar.Image = Global.My.Resources.Resources.Clear_Green_Button
        Me.Btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnaceptar.Location = New System.Drawing.Point(241, 213)
        Me.Btnaceptar.Name = "Btnaceptar"
        Me.Btnaceptar.Size = New System.Drawing.Size(100, 39)
        Me.Btnaceptar.TabIndex = 82
        Me.Btnaceptar.Text = "Aceptar"
        Me.Btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnaceptar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Azure
        Me.GroupBox1.Controls.Add(Me.Label64)
        Me.GroupBox1.Controls.Add(Me.txt5)
        Me.GroupBox1.Controls.Add(Me.Label63)
        Me.GroupBox1.Controls.Add(Me.txt4)
        Me.GroupBox1.Controls.Add(Me.Label61)
        Me.GroupBox1.Controls.Add(Me.txt3)
        Me.GroupBox1.Controls.Add(Me.Label53)
        Me.GroupBox1.Controls.Add(Me.txt2)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txt_email)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.txt1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(6, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 64)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Telefonos"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.Color.Black
        Me.Label64.Location = New System.Drawing.Point(103, 42)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(18, 13)
        Me.Label64.TabIndex = 81
        Me.Label64.Text = "5:"
        '
        'txt5
        '
        Me.txt5.BackColor = System.Drawing.Color.White
        Me.txt5.Location = New System.Drawing.Point(121, 38)
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(79, 20)
        Me.txt5.TabIndex = 80
        Me.txt5.Tag = "Telefono5"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.Color.Black
        Me.Label63.Location = New System.Drawing.Point(1, 39)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(18, 13)
        Me.Label63.TabIndex = 79
        Me.Label63.Text = "4:"
        '
        'txt4
        '
        Me.txt4.BackColor = System.Drawing.Color.White
        Me.txt4.Location = New System.Drawing.Point(19, 38)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(78, 20)
        Me.txt4.TabIndex = 78
        Me.txt4.Tag = "Telefono4"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.Black
        Me.Label61.Location = New System.Drawing.Point(227, 17)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(18, 13)
        Me.Label61.TabIndex = 77
        Me.Label61.Text = "3:"
        '
        'txt3
        '
        Me.txt3.BackColor = System.Drawing.Color.White
        Me.txt3.Location = New System.Drawing.Point(245, 14)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(83, 20)
        Me.txt3.TabIndex = 76
        Me.txt3.Tag = "Telefono3"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.Black
        Me.Label53.Location = New System.Drawing.Point(103, 17)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(18, 13)
        Me.Label53.TabIndex = 75
        Me.Label53.Text = "2:"
        '
        'txt2
        '
        Me.txt2.BackColor = System.Drawing.Color.White
        Me.txt2.Location = New System.Drawing.Point(121, 14)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(79, 20)
        Me.txt2.TabIndex = 74
        Me.txt2.Tag = "Telefono2"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(204, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "Email:"
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.White
        Me.txt_email.Location = New System.Drawing.Point(245, 36)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(83, 20)
        Me.txt_email.TabIndex = 72
        Me.txt_email.Tag = "correo"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(1, 17)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(18, 13)
        Me.Label34.TabIndex = 45
        Me.Label34.Text = "1:"
        '
        'txt1
        '
        Me.txt1.BackColor = System.Drawing.Color.White
        Me.txt1.Location = New System.Drawing.Point(19, 15)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(78, 20)
        Me.txt1.TabIndex = 44
        Me.txt1.Tag = "Telefono1"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(26, 82)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 13)
        Me.Label22.TabIndex = 70
        Me.Label22.Text = "Sector:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(9, 60)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(65, 13)
        Me.Label27.TabIndex = 69
        Me.Label27.Text = "Municipio:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(10, 38)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 13)
        Me.Label23.TabIndex = 68
        Me.Label23.Text = "Provincia:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(9, 109)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(65, 13)
        Me.Label24.TabIndex = 60
        Me.Label24.Text = "Dirección:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(1, 17)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(73, 13)
        Me.Label35.TabIndex = 16
        Me.Label35.Text = "Rep. Legal:"
        '
        'txt_rep
        '
        Me.txt_rep.BackColor = System.Drawing.Color.White
        Me.txt_rep.Location = New System.Drawing.Point(76, 14)
        Me.txt_rep.Name = "txt_rep"
        Me.txt_rep.Size = New System.Drawing.Size(238, 20)
        Me.txt_rep.TabIndex = 1
        Me.txt_rep.Tag = "Nombre"
        '
        'txt_dir
        '
        Me.txt_dir.BackColor = System.Drawing.Color.White
        Me.txt_dir.Location = New System.Drawing.Point(76, 103)
        Me.txt_dir.Multiline = True
        Me.txt_dir.Name = "txt_dir"
        Me.txt_dir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_dir.Size = New System.Drawing.Size(238, 37)
        Me.txt_dir.TabIndex = 4
        Me.txt_dir.Tag = "Direccion"
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Provincia, Me.Municipio, Me.Sector, Me.Direccion, Me.Telefono1, Me.Telefono2, Me.Telefono3, Me.Telefono4, Me.Telefono5, Me.correo})
        Me.dgv1.Location = New System.Drawing.Point(1, 210)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(121, 75)
        Me.dgv1.TabIndex = 41
        Me.dgv1.Visible = False
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Provincia
        '
        Me.Provincia.HeaderText = "Provincia"
        Me.Provincia.Name = "Provincia"
        '
        'Municipio
        '
        Me.Municipio.HeaderText = "Municipio"
        Me.Municipio.Name = "Municipio"
        '
        'Sector
        '
        Me.Sector.HeaderText = "Sector"
        Me.Sector.Name = "Sector"
        '
        'Direccion
        '
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        '
        'Telefono1
        '
        Me.Telefono1.HeaderText = "Telefono1"
        Me.Telefono1.Name = "Telefono1"
        '
        'Telefono2
        '
        Me.Telefono2.HeaderText = "Telefono2"
        Me.Telefono2.Name = "Telefono2"
        '
        'Telefono3
        '
        Me.Telefono3.HeaderText = "Telefono3"
        Me.Telefono3.Name = "Telefono3"
        '
        'Telefono4
        '
        Me.Telefono4.HeaderText = "Telefono4"
        Me.Telefono4.Name = "Telefono4"
        '
        'Telefono5
        '
        Me.Telefono5.HeaderText = "Telefono5"
        Me.Telefono5.Name = "Telefono5"
        '
        'correo
        '
        Me.correo.HeaderText = "correo"
        Me.correo.Name = "correo"
        '
        'cccModDatoAge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(358, 265)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.GbInfGen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cccModDatoAge"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitud de Modificación de Datos"
        Me.GbInfGen.ResumeLayout(False)
        Me.GbInfGen.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbInfGen As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents txt5 As System.Windows.Forms.TextBox
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents txt4 As System.Windows.Forms.TextBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txt_rep As System.Windows.Forms.TextBox
    Friend WithEvents txt_dir As System.Windows.Forms.TextBox
    Friend WithEvents Btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents CmbSec As System.Windows.Forms.ComboBox
    Friend WithEvents CmbMun As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPro As System.Windows.Forms.ComboBox
    Friend WithEvents lblsec As System.Windows.Forms.Label
    Friend WithEvents lblmun As System.Windows.Forms.Label
    Friend WithEvents lblpro As System.Windows.Forms.Label
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Provincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Municipio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sector As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents correo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
