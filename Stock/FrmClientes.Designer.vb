<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
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
		Me.LblCodigo = New System.Windows.Forms.Label()
		Me.TxtCodigo = New System.Windows.Forms.TextBox()
		Me.LblNombre = New System.Windows.Forms.Label()
		Me.TxtNombre = New System.Windows.Forms.TextBox()
		Me.TxtDireccion = New System.Windows.Forms.TextBox()
		Me.LblDireccion = New System.Windows.Forms.Label()
		Me.TxtTelefono = New System.Windows.Forms.TextBox()
		Me.LblTelefono = New System.Windows.Forms.Label()
		Me.TxtCedula = New System.Windows.Forms.TextBox()
		Me.LblCedula = New System.Windows.Forms.Label()
		Me.TxtRuc = New System.Windows.Forms.TextBox()
		Me.LblRuc = New System.Windows.Forms.Label()
		Me.DtpNacimiento = New System.Windows.Forms.DateTimePicker()
		Me.LblNacimiento = New System.Windows.Forms.Label()
		Me.TxtEmail = New System.Windows.Forms.TextBox()
		Me.LblEmail = New System.Windows.Forms.Label()
		Me.TxtCantidadHijos = New System.Windows.Forms.NumericUpDown()
		Me.LblCantidadHijos = New System.Windows.Forms.Label()
		Me.LblSalario = New System.Windows.Forms.Label()
		Me.TxtSalario = New System.Windows.Forms.NumericUpDown()
		Me.PctFoto = New System.Windows.Forms.PictureBox()
		Me.BtnBuscarFoto = New System.Windows.Forms.Button()
		Me.BtnEliminarFoto = New System.Windows.Forms.Button()
		Me.RdbMasculino = New System.Windows.Forms.RadioButton()
		Me.RdbFemenino = New System.Windows.Forms.RadioButton()
		Me.GrpGenero = New System.Windows.Forms.GroupBox()
		Me.GrdClientes = New System.Windows.Forms.DataGridView()
		Me.IdClientesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.BtnEliminar = New System.Windows.Forms.Button()
		Me.BtnGrabar = New System.Windows.Forms.Button()
		Me.BtnNuevo = New System.Windows.Forms.Button()
		Me.BtnSalir = New System.Windows.Forms.Button()
		CType(Me.TxtCantidadHijos, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxtSalario, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PctFoto, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GrpGenero.SuspendLayout()
		CType(Me.GrdClientes, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'LblCodigo
		'
		Me.LblCodigo.AutoSize = True
		Me.LblCodigo.Location = New System.Drawing.Point(28, 21)
		Me.LblCodigo.Name = "LblCodigo"
		Me.LblCodigo.Size = New System.Drawing.Size(43, 13)
		Me.LblCodigo.TabIndex = 17
		Me.LblCodigo.Text = "Codigo:"
		'
		'TxtCodigo
		'
		Me.TxtCodigo.Location = New System.Drawing.Point(77, 18)
		Me.TxtCodigo.Name = "TxtCodigo"
		Me.TxtCodigo.ReadOnly = True
		Me.TxtCodigo.Size = New System.Drawing.Size(60, 20)
		Me.TxtCodigo.TabIndex = 16
		Me.TxtCodigo.Text = "0"
		Me.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'LblNombre
		'
		Me.LblNombre.AutoSize = True
		Me.LblNombre.Location = New System.Drawing.Point(24, 47)
		Me.LblNombre.Name = "LblNombre"
		Me.LblNombre.Size = New System.Drawing.Size(47, 13)
		Me.LblNombre.TabIndex = 18
		Me.LblNombre.Text = "Nombre:"
		'
		'TxtNombre
		'
		Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.TxtNombre.Location = New System.Drawing.Point(77, 44)
		Me.TxtNombre.MaxLength = 200
		Me.TxtNombre.Name = "TxtNombre"
		Me.TxtNombre.Size = New System.Drawing.Size(180, 20)
		Me.TxtNombre.TabIndex = 0
		'
		'TxtDireccion
		'
		Me.TxtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.TxtDireccion.Location = New System.Drawing.Point(77, 70)
		Me.TxtDireccion.MaxLength = 200
		Me.TxtDireccion.Multiline = True
		Me.TxtDireccion.Name = "TxtDireccion"
		Me.TxtDireccion.Size = New System.Drawing.Size(180, 50)
		Me.TxtDireccion.TabIndex = 1
		'
		'LblDireccion
		'
		Me.LblDireccion.AutoSize = True
		Me.LblDireccion.Location = New System.Drawing.Point(16, 73)
		Me.LblDireccion.Name = "LblDireccion"
		Me.LblDireccion.Size = New System.Drawing.Size(55, 13)
		Me.LblDireccion.TabIndex = 19
		Me.LblDireccion.Text = "Dirección:"
		'
		'TxtTelefono
		'
		Me.TxtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.TxtTelefono.Location = New System.Drawing.Point(77, 126)
		Me.TxtTelefono.MaxLength = 100
		Me.TxtTelefono.Name = "TxtTelefono"
		Me.TxtTelefono.Size = New System.Drawing.Size(130, 20)
		Me.TxtTelefono.TabIndex = 2
		'
		'LblTelefono
		'
		Me.LblTelefono.AutoSize = True
		Me.LblTelefono.Location = New System.Drawing.Point(19, 129)
		Me.LblTelefono.Name = "LblTelefono"
		Me.LblTelefono.Size = New System.Drawing.Size(52, 13)
		Me.LblTelefono.TabIndex = 20
		Me.LblTelefono.Text = "Telefono:"
		'
		'TxtCedula
		'
		Me.TxtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.TxtCedula.Location = New System.Drawing.Point(77, 152)
		Me.TxtCedula.MaxLength = 100
		Me.TxtCedula.Name = "TxtCedula"
		Me.TxtCedula.Size = New System.Drawing.Size(130, 20)
		Me.TxtCedula.TabIndex = 3
		'
		'LblCedula
		'
		Me.LblCedula.AutoSize = True
		Me.LblCedula.Location = New System.Drawing.Point(28, 155)
		Me.LblCedula.Name = "LblCedula"
		Me.LblCedula.Size = New System.Drawing.Size(43, 13)
		Me.LblCedula.TabIndex = 21
		Me.LblCedula.Text = "Cedula:"
		'
		'TxtRuc
		'
		Me.TxtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.TxtRuc.Location = New System.Drawing.Point(77, 178)
		Me.TxtRuc.MaxLength = 100
		Me.TxtRuc.Name = "TxtRuc"
		Me.TxtRuc.Size = New System.Drawing.Size(130, 20)
		Me.TxtRuc.TabIndex = 4
		'
		'LblRuc
		'
		Me.LblRuc.AutoSize = True
		Me.LblRuc.Location = New System.Drawing.Point(41, 181)
		Me.LblRuc.Name = "LblRuc"
		Me.LblRuc.Size = New System.Drawing.Size(30, 13)
		Me.LblRuc.TabIndex = 22
		Me.LblRuc.Text = "Ruc:"
		'
		'DtpNacimiento
		'
		Me.DtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.DtpNacimiento.Location = New System.Drawing.Point(77, 204)
		Me.DtpNacimiento.Name = "DtpNacimiento"
		Me.DtpNacimiento.Size = New System.Drawing.Size(130, 20)
		Me.DtpNacimiento.TabIndex = 5
		'
		'LblNacimiento
		'
		Me.LblNacimiento.AutoSize = True
		Me.LblNacimiento.Location = New System.Drawing.Point(8, 207)
		Me.LblNacimiento.Name = "LblNacimiento"
		Me.LblNacimiento.Size = New System.Drawing.Size(63, 13)
		Me.LblNacimiento.TabIndex = 23
		Me.LblNacimiento.Text = "Nacimiento:"
		'
		'TxtEmail
		'
		Me.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.TxtEmail.Location = New System.Drawing.Point(77, 230)
		Me.TxtEmail.MaxLength = 100
		Me.TxtEmail.Name = "TxtEmail"
		Me.TxtEmail.Size = New System.Drawing.Size(180, 20)
		Me.TxtEmail.TabIndex = 6
		'
		'LblEmail
		'
		Me.LblEmail.AutoSize = True
		Me.LblEmail.Location = New System.Drawing.Point(36, 233)
		Me.LblEmail.Name = "LblEmail"
		Me.LblEmail.Size = New System.Drawing.Size(35, 13)
		Me.LblEmail.TabIndex = 24
		Me.LblEmail.Text = "Email:"
		'
		'TxtCantidadHijos
		'
		Me.TxtCantidadHijos.Location = New System.Drawing.Point(77, 256)
		Me.TxtCantidadHijos.Name = "TxtCantidadHijos"
		Me.TxtCantidadHijos.Size = New System.Drawing.Size(130, 20)
		Me.TxtCantidadHijos.TabIndex = 7
		Me.TxtCantidadHijos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'LblCantidadHijos
		'
		Me.LblCantidadHijos.AutoSize = True
		Me.LblCantidadHijos.Location = New System.Drawing.Point(10, 260)
		Me.LblCantidadHijos.Name = "LblCantidadHijos"
		Me.LblCantidadHijos.Size = New System.Drawing.Size(61, 13)
		Me.LblCantidadHijos.TabIndex = 25
		Me.LblCantidadHijos.Text = "Cant. Hijos:"
		'
		'LblSalario
		'
		Me.LblSalario.AutoSize = True
		Me.LblSalario.Location = New System.Drawing.Point(29, 284)
		Me.LblSalario.Name = "LblSalario"
		Me.LblSalario.Size = New System.Drawing.Size(42, 13)
		Me.LblSalario.TabIndex = 26
		Me.LblSalario.Text = "Salario:"
		'
		'TxtSalario
		'
		Me.TxtSalario.DecimalPlaces = 2
		Me.TxtSalario.Location = New System.Drawing.Point(77, 282)
		Me.TxtSalario.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
		Me.TxtSalario.Name = "TxtSalario"
		Me.TxtSalario.Size = New System.Drawing.Size(130, 20)
		Me.TxtSalario.TabIndex = 8
		Me.TxtSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.TxtSalario.ThousandsSeparator = True
		'
		'PctFoto
		'
		Me.PctFoto.Location = New System.Drawing.Point(263, 18)
		Me.PctFoto.Name = "PctFoto"
		Me.PctFoto.Size = New System.Drawing.Size(150, 150)
		Me.PctFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PctFoto.TabIndex = 20
		Me.PctFoto.TabStop = False
		'
		'BtnBuscarFoto
		'
		Me.BtnBuscarFoto.Location = New System.Drawing.Point(347, 174)
		Me.BtnBuscarFoto.Name = "BtnBuscarFoto"
		Me.BtnBuscarFoto.Size = New System.Drawing.Size(30, 23)
		Me.BtnBuscarFoto.TabIndex = 9
		Me.BtnBuscarFoto.Text = "..."
		Me.BtnBuscarFoto.UseVisualStyleBackColor = True
		'
		'BtnEliminarFoto
		'
		Me.BtnEliminarFoto.Location = New System.Drawing.Point(383, 174)
		Me.BtnEliminarFoto.Name = "BtnEliminarFoto"
		Me.BtnEliminarFoto.Size = New System.Drawing.Size(30, 23)
		Me.BtnEliminarFoto.TabIndex = 10
		Me.BtnEliminarFoto.Text = "X"
		Me.BtnEliminarFoto.UseVisualStyleBackColor = True
		'
		'RdbMasculino
		'
		Me.RdbMasculino.AutoSize = True
		Me.RdbMasculino.Checked = True
		Me.RdbMasculino.Location = New System.Drawing.Point(39, 20)
		Me.RdbMasculino.Name = "RdbMasculino"
		Me.RdbMasculino.Size = New System.Drawing.Size(73, 17)
		Me.RdbMasculino.TabIndex = 0
		Me.RdbMasculino.TabStop = True
		Me.RdbMasculino.Text = "Masculino"
		Me.RdbMasculino.UseVisualStyleBackColor = True
		'
		'RdbFemenino
		'
		Me.RdbFemenino.AutoSize = True
		Me.RdbFemenino.Location = New System.Drawing.Point(39, 43)
		Me.RdbFemenino.Name = "RdbFemenino"
		Me.RdbFemenino.Size = New System.Drawing.Size(71, 17)
		Me.RdbFemenino.TabIndex = 1
		Me.RdbFemenino.Text = "Femenino"
		Me.RdbFemenino.UseVisualStyleBackColor = True
		'
		'GrpGenero
		'
		Me.GrpGenero.Controls.Add(Me.RdbMasculino)
		Me.GrpGenero.Controls.Add(Me.RdbFemenino)
		Me.GrpGenero.Location = New System.Drawing.Point(263, 207)
		Me.GrpGenero.Name = "GrpGenero"
		Me.GrpGenero.Size = New System.Drawing.Size(150, 80)
		Me.GrpGenero.TabIndex = 11
		Me.GrpGenero.TabStop = False
		Me.GrpGenero.Text = "Genero"
		'
		'GrdClientes
		'
		Me.GrdClientes.AllowUserToAddRows = False
		Me.GrdClientes.AllowUserToDeleteRows = False
		Me.GrdClientes.AutoGenerateColumns = False
		Me.GrdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.GrdClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdClientesDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn})
		Me.GrdClientes.DataSource = Me.ClienteBindingSource
		Me.GrdClientes.Location = New System.Drawing.Point(419, 18)
		Me.GrdClientes.MultiSelect = False
		Me.GrdClientes.Name = "GrdClientes"
		Me.GrdClientes.ReadOnly = True
		Me.GrdClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.GrdClientes.Size = New System.Drawing.Size(303, 150)
		Me.GrdClientes.TabIndex = 27
		'
		'IdClientesDataGridViewTextBoxColumn
		'
		Me.IdClientesDataGridViewTextBoxColumn.DataPropertyName = "Id_Clientes"
		Me.IdClientesDataGridViewTextBoxColumn.HeaderText = "Id_Clientes"
		Me.IdClientesDataGridViewTextBoxColumn.Name = "IdClientesDataGridViewTextBoxColumn"
		Me.IdClientesDataGridViewTextBoxColumn.ReadOnly = True
		'
		'NombreDataGridViewTextBoxColumn
		'
		Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
		Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
		Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
		Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
		'
		'ClienteBindingSource
		'
		Me.ClienteBindingSource.DataSource = GetType(Stock.Cliente)
		'
		'BtnEliminar
		'
		Me.BtnEliminar.Location = New System.Drawing.Point(530, 175)
		Me.BtnEliminar.Name = "BtnEliminar"
		Me.BtnEliminar.Size = New System.Drawing.Size(60, 23)
		Me.BtnEliminar.TabIndex = 13
		Me.BtnEliminar.Text = "Eliminar"
		Me.BtnEliminar.UseVisualStyleBackColor = True
		'
		'BtnGrabar
		'
		Me.BtnGrabar.Location = New System.Drawing.Point(464, 176)
		Me.BtnGrabar.Name = "BtnGrabar"
		Me.BtnGrabar.Size = New System.Drawing.Size(60, 23)
		Me.BtnGrabar.TabIndex = 12
		Me.BtnGrabar.Text = "Grabar"
		Me.BtnGrabar.UseVisualStyleBackColor = True
		'
		'BtnNuevo
		'
		Me.BtnNuevo.Location = New System.Drawing.Point(596, 176)
		Me.BtnNuevo.Name = "BtnNuevo"
		Me.BtnNuevo.Size = New System.Drawing.Size(60, 23)
		Me.BtnNuevo.TabIndex = 14
		Me.BtnNuevo.Text = "Nuevo"
		Me.BtnNuevo.UseVisualStyleBackColor = True
		'
		'BtnSalir
		'
		Me.BtnSalir.Location = New System.Drawing.Point(662, 176)
		Me.BtnSalir.Name = "BtnSalir"
		Me.BtnSalir.Size = New System.Drawing.Size(60, 23)
		Me.BtnSalir.TabIndex = 15
		Me.BtnSalir.Text = "Salir"
		Me.BtnSalir.UseVisualStyleBackColor = True
		'
		'FrmClientes
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(734, 362)
		Me.Controls.Add(Me.BtnSalir)
		Me.Controls.Add(Me.BtnNuevo)
		Me.Controls.Add(Me.BtnGrabar)
		Me.Controls.Add(Me.BtnEliminar)
		Me.Controls.Add(Me.GrdClientes)
		Me.Controls.Add(Me.GrpGenero)
		Me.Controls.Add(Me.BtnEliminarFoto)
		Me.Controls.Add(Me.BtnBuscarFoto)
		Me.Controls.Add(Me.PctFoto)
		Me.Controls.Add(Me.LblSalario)
		Me.Controls.Add(Me.TxtSalario)
		Me.Controls.Add(Me.LblCantidadHijos)
		Me.Controls.Add(Me.TxtCantidadHijos)
		Me.Controls.Add(Me.TxtEmail)
		Me.Controls.Add(Me.LblEmail)
		Me.Controls.Add(Me.LblNacimiento)
		Me.Controls.Add(Me.DtpNacimiento)
		Me.Controls.Add(Me.TxtRuc)
		Me.Controls.Add(Me.LblRuc)
		Me.Controls.Add(Me.TxtCedula)
		Me.Controls.Add(Me.LblCedula)
		Me.Controls.Add(Me.TxtTelefono)
		Me.Controls.Add(Me.LblTelefono)
		Me.Controls.Add(Me.TxtDireccion)
		Me.Controls.Add(Me.LblDireccion)
		Me.Controls.Add(Me.TxtNombre)
		Me.Controls.Add(Me.LblNombre)
		Me.Controls.Add(Me.TxtCodigo)
		Me.Controls.Add(Me.LblCodigo)
		Me.Name = "FrmClientes"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Clientes"
		CType(Me.TxtCantidadHijos, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxtSalario, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PctFoto, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GrpGenero.ResumeLayout(False)
		Me.GrpGenero.PerformLayout()
		CType(Me.GrdClientes, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents LblCodigo As Label
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents LblDireccion As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents LblTelefono As Label
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents LblCedula As Label
    Friend WithEvents TxtRuc As TextBox
    Friend WithEvents LblRuc As Label
    Friend WithEvents DtpNacimiento As DateTimePicker
    Friend WithEvents LblNacimiento As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents LblEmail As Label
    Friend WithEvents TxtCantidadHijos As NumericUpDown
    Friend WithEvents LblCantidadHijos As Label
    Friend WithEvents LblSalario As Label
    Friend WithEvents TxtSalario As NumericUpDown
    Friend WithEvents PctFoto As PictureBox
    Friend WithEvents BtnBuscarFoto As Button
    Friend WithEvents BtnEliminarFoto As Button
    Friend WithEvents RdbMasculino As RadioButton
    Friend WithEvents RdbFemenino As RadioButton
    Friend WithEvents GrpGenero As GroupBox
    Friend WithEvents GrdClientes As DataGridView
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnGrabar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnSalir As Button
	Friend WithEvents IdClientesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents ClienteBindingSource As BindingSource
End Class
