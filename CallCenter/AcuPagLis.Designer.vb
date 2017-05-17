<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AcuPagLis
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
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.lbl_cant = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_h_reg = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.con = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_Age = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.GroupBox7.SuspendLayout()
        CType(Me.dgv_h_reg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox7.Controls.Add(Me.Button2)
        Me.GroupBox7.Controls.Add(Me.Button6)
        Me.GroupBox7.Controls.Add(Me.lbl_cant)
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Controls.Add(Me.dgv_h_reg)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(6, 27)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(439, 196)
        Me.GroupBox7.TabIndex = 85
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "LISTADO DE ACUERDOS DE PAGOS"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = Global.My.Resources.Resources.page_delete
        Me.Button2.Location = New System.Drawing.Point(408, 49)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 26)
        Me.Button2.TabIndex = 100
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Image = Global.My.Resources.Resources.page_add
        Me.Button6.Location = New System.Drawing.Point(408, 17)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(25, 26)
        Me.Button6.TabIndex = 99
        Me.Button6.UseVisualStyleBackColor = False
        Me.Button6.Visible = False
        '
        'lbl_cant
        '
        Me.lbl_cant.AutoSize = True
        Me.lbl_cant.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cant.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbl_cant.Location = New System.Drawing.Point(118, 174)
        Me.lbl_cant.Name = "lbl_cant"
        Me.lbl_cant.Size = New System.Drawing.Size(14, 13)
        Me.lbl_cant.TabIndex = 98
        Me.lbl_cant.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "No. de Acuerdos:"
        '
        'dgv_h_reg
        '
        Me.dgv_h_reg.AllowUserToAddRows = False
        Me.dgv_h_reg.AllowUserToDeleteRows = False
        Me.dgv_h_reg.AllowUserToOrderColumns = True
        Me.dgv_h_reg.AllowUserToResizeRows = False
        Me.dgv_h_reg.BackgroundColor = System.Drawing.Color.White
        Me.dgv_h_reg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_h_reg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_h_reg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.mot, Me.inc, Me.con})
        Me.dgv_h_reg.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgv_h_reg.Location = New System.Drawing.Point(9, 17)
        Me.dgv_h_reg.MultiSelect = False
        Me.dgv_h_reg.Name = "dgv_h_reg"
        Me.dgv_h_reg.ReadOnly = True
        Me.dgv_h_reg.RowHeadersVisible = False
        Me.dgv_h_reg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_h_reg.Size = New System.Drawing.Size(393, 154)
        Me.dgv_h_reg.TabIndex = 2
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'mot
        '
        Me.mot.DataPropertyName = "mot"
        Me.mot.HeaderText = "FECHA INICIO"
        Me.mot.Name = "mot"
        Me.mot.ReadOnly = True
        Me.mot.Width = 120
        '
        'inc
        '
        Me.inc.DataPropertyName = "inc"
        Me.inc.HeaderText = "ESTADO"
        Me.inc.Name = "inc"
        Me.inc.ReadOnly = True
        Me.inc.Width = 120
        '
        'con
        '
        Me.con.DataPropertyName = "con"
        Me.con.HeaderText = "BALANCE"
        Me.con.Name = "con"
        Me.con.ReadOnly = True
        Me.con.Width = 120
        '
        'lbl_Age
        '
        Me.lbl_Age.AutoSize = True
        Me.lbl_Age.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Age.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Age.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbl_Age.Location = New System.Drawing.Point(3, 9)
        Me.lbl_Age.Name = "lbl_Age"
        Me.lbl_Age.Size = New System.Drawing.Size(139, 13)
        Me.lbl_Age.TabIndex = 96
        Me.lbl_Age.Text = "Seleccione el agente!!!"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.White
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Image = Global.My.Resources.Resources.Cancel_Red_Button
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_cancelar.Location = New System.Drawing.Point(247, 229)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(96, 37)
        Me.btn_cancelar.TabIndex = 98
        Me.btn_cancelar.Text = "Cerrar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.White
        Me.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.ForeColor = System.Drawing.Color.Black
        Me.btn_cerrar.Image = Global.My.Resources.Resources.Clear_Green_Button
        Me.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cerrar.Location = New System.Drawing.Point(349, 229)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(96, 37)
        Me.btn_cerrar.TabIndex = 97
        Me.btn_cerrar.Text = "Aceptar"
        Me.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'AcuPagLis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(451, 267)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.lbl_Age)
        Me.Controls.Add(Me.GroupBox7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AcuPagLis"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACUERDOS DE PAGOS"
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.dgv_h_reg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_h_reg As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_cant As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Age As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents con As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
