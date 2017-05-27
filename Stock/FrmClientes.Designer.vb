<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LblCodigo = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.LblCedula = New System.Windows.Forms.Label()
        Me.TxtRuc = New System.Windows.Forms.TextBox()
        Me.LblRuc = New System.Windows.Forms.Label()
        Me.LblNacimiento = New System.Windows.Forms.Label()
        Me.DtpNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblCantidadHijos = New System.Windows.Forms.Label()
        Me.TxtCantidadHijos = New System.Windows.Forms.NumericUpDown()
        Me.TxtSalario = New System.Windows.Forms.NumericUpDown()
        Me.LblSalario = New System.Windows.Forms.Label()
        Me.PctFoto = New System.Windows.Forms.PictureBox()
        Me.BtnBuscarFoto = New System.Windows.Forms.Button()
        Me.BtnEliminarFoto = New System.Windows.Forms.Button()
        Me.GpbGenero = New System.Windows.Forms.GroupBox()
        Me.RdbFemenino = New System.Windows.Forms.RadioButton()
        Me.RdbMasculino = New System.Windows.Forms.RadioButton()
        Me.GrdClientes = New System.Windows.Forms.DataGridView()
        Me.IdClientesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.BtnBuscarPorNombre = New System.Windows.Forms.Button()
        Me.BtnBuscarPorCedula = New System.Windows.Forms.Button()
        CType(Me.TxtCantidadHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSalario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpbGenero.SuspendLayout()
        CType(Me.GrdClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.Location = New System.Drawing.Point(26, 16)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.LblCodigo.TabIndex = 17
        Me.LblCodigo.Text = "Codigo:"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(75, 13)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.Size = New System.Drawing.Size(55, 20)
        Me.TxtCodigo.TabIndex = 27
        Me.TxtCodigo.Text = "0"
        Me.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(22, 42)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(47, 13)
        Me.LblNombre.TabIndex = 18
        Me.LblNombre.Text = "Nombre:"
        '
        'TxtNombre
        '
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Location = New System.Drawing.Point(75, 39)
        Me.TxtNombre.MaxLength = 200
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(176, 20)
        Me.TxtNombre.TabIndex = 0
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.Location = New System.Drawing.Point(14, 68)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(55, 13)
        Me.LblDireccion.TabIndex = 19
        Me.LblDireccion.Text = "Direccion:"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDireccion.Location = New System.Drawing.Point(75, 65)
        Me.TxtDireccion.MaxLength = 200
        Me.TxtDireccion.Multiline = True
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(213, 53)
        Me.TxtDireccion.TabIndex = 1
        '
        'TxtTelefono
        '
        Me.TxtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTelefono.Location = New System.Drawing.Point(75, 124)
        Me.TxtTelefono.MaxLength = 100
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TxtTelefono.TabIndex = 2
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(17, 127)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.LblTelefono.TabIndex = 20
        Me.LblTelefono.Text = "Telefono:"
        '
        'TxtCedula
        '
        Me.TxtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCedula.Location = New System.Drawing.Point(75, 150)
        Me.TxtCedula.MaxLength = 100
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(100, 20)
        Me.TxtCedula.TabIndex = 3
        '
        'LblCedula
        '
        Me.LblCedula.AutoSize = True
        Me.LblCedula.Location = New System.Drawing.Point(26, 153)
        Me.LblCedula.Name = "LblCedula"
        Me.LblCedula.Size = New System.Drawing.Size(43, 13)
        Me.LblCedula.TabIndex = 21
        Me.LblCedula.Text = "Cedula:"
        '
        'TxtRuc
        '
        Me.TxtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRuc.Location = New System.Drawing.Point(75, 176)
        Me.TxtRuc.MaxLength = 100
        Me.TxtRuc.Name = "TxtRuc"
        Me.TxtRuc.Size = New System.Drawing.Size(100, 20)
        Me.TxtRuc.TabIndex = 4
        '
        'LblRuc
        '
        Me.LblRuc.AutoSize = True
        Me.LblRuc.Location = New System.Drawing.Point(39, 179)
        Me.LblRuc.Name = "LblRuc"
        Me.LblRuc.Size = New System.Drawing.Size(30, 13)
        Me.LblRuc.TabIndex = 22
        Me.LblRuc.Text = "Ruc:"
        '
        'LblNacimiento
        '
        Me.LblNacimiento.AutoSize = True
        Me.LblNacimiento.Location = New System.Drawing.Point(6, 205)
        Me.LblNacimiento.Name = "LblNacimiento"
        Me.LblNacimiento.Size = New System.Drawing.Size(63, 13)
        Me.LblNacimiento.TabIndex = 23
        Me.LblNacimiento.Text = "Nacimiento:"
        '
        'DtpNacimiento
        '
        Me.DtpNacimiento.CustomFormat = ""
        Me.DtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpNacimiento.Location = New System.Drawing.Point(75, 202)
        Me.DtpNacimiento.Name = "DtpNacimiento"
        Me.DtpNacimiento.Size = New System.Drawing.Size(100, 20)
        Me.DtpNacimiento.TabIndex = 5
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(75, 228)
        Me.TxtEmail.MaxLength = 100
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(213, 20)
        Me.TxtEmail.TabIndex = 6
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(31, 231)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(38, 13)
        Me.LblEmail.TabIndex = 24
        Me.LblEmail.Text = "E-mail:"
        '
        'LblCantidadHijos
        '
        Me.LblCantidadHijos.AutoSize = True
        Me.LblCantidadHijos.Location = New System.Drawing.Point(8, 259)
        Me.LblCantidadHijos.Name = "LblCantidadHijos"
        Me.LblCantidadHijos.Size = New System.Drawing.Size(61, 13)
        Me.LblCantidadHijos.TabIndex = 25
        Me.LblCantidadHijos.Text = "Cant. Hijos:"
        '
        'TxtCantidadHijos
        '
        Me.TxtCantidadHijos.Location = New System.Drawing.Point(75, 257)
        Me.TxtCantidadHijos.Name = "TxtCantidadHijos"
        Me.TxtCantidadHijos.Size = New System.Drawing.Size(100, 20)
        Me.TxtCantidadHijos.TabIndex = 7
        Me.TxtCantidadHijos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtCantidadHijos.ThousandsSeparator = True
        '
        'TxtSalario
        '
        Me.TxtSalario.DecimalPlaces = 2
        Me.TxtSalario.Location = New System.Drawing.Point(75, 283)
        Me.TxtSalario.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.TxtSalario.Name = "TxtSalario"
        Me.TxtSalario.Size = New System.Drawing.Size(100, 20)
        Me.TxtSalario.TabIndex = 8
        Me.TxtSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtSalario.ThousandsSeparator = True
        '
        'LblSalario
        '
        Me.LblSalario.AutoSize = True
        Me.LblSalario.Location = New System.Drawing.Point(27, 285)
        Me.LblSalario.Name = "LblSalario"
        Me.LblSalario.Size = New System.Drawing.Size(42, 13)
        Me.LblSalario.TabIndex = 26
        Me.LblSalario.Text = "Salario:"
        '
        'PctFoto
        '
        Me.PctFoto.Location = New System.Drawing.Point(294, 42)
        Me.PctFoto.Name = "PctFoto"
        Me.PctFoto.Size = New System.Drawing.Size(150, 150)
        Me.PctFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctFoto.TabIndex = 20
        Me.PctFoto.TabStop = False
        '
        'BtnBuscarFoto
        '
        Me.BtnBuscarFoto.Location = New System.Drawing.Point(376, 195)
        Me.BtnBuscarFoto.Name = "BtnBuscarFoto"
        Me.BtnBuscarFoto.Size = New System.Drawing.Size(31, 23)
        Me.BtnBuscarFoto.TabIndex = 10
        Me.BtnBuscarFoto.Text = "..."
        Me.BtnBuscarFoto.UseVisualStyleBackColor = True
        '
        'BtnEliminarFoto
        '
        Me.BtnEliminarFoto.Location = New System.Drawing.Point(413, 195)
        Me.BtnEliminarFoto.Name = "BtnEliminarFoto"
        Me.BtnEliminarFoto.Size = New System.Drawing.Size(31, 23)
        Me.BtnEliminarFoto.TabIndex = 11
        Me.BtnEliminarFoto.Text = "X"
        Me.BtnEliminarFoto.UseVisualStyleBackColor = True
        '
        'GpbGenero
        '
        Me.GpbGenero.Controls.Add(Me.RdbFemenino)
        Me.GpbGenero.Controls.Add(Me.RdbMasculino)
        Me.GpbGenero.Location = New System.Drawing.Point(294, 224)
        Me.GpbGenero.Name = "GpbGenero"
        Me.GpbGenero.Size = New System.Drawing.Size(150, 79)
        Me.GpbGenero.TabIndex = 9
        Me.GpbGenero.TabStop = False
        Me.GpbGenero.Text = "Genero"
        '
        'RdbFemenino
        '
        Me.RdbFemenino.AutoSize = True
        Me.RdbFemenino.Location = New System.Drawing.Point(33, 42)
        Me.RdbFemenino.Name = "RdbFemenino"
        Me.RdbFemenino.Size = New System.Drawing.Size(71, 17)
        Me.RdbFemenino.TabIndex = 1
        Me.RdbFemenino.Text = "Femenino"
        Me.RdbFemenino.UseVisualStyleBackColor = True
        '
        'RdbMasculino
        '
        Me.RdbMasculino.AutoSize = True
        Me.RdbMasculino.Checked = True
        Me.RdbMasculino.Location = New System.Drawing.Point(33, 19)
        Me.RdbMasculino.Name = "RdbMasculino"
        Me.RdbMasculino.Size = New System.Drawing.Size(73, 17)
        Me.RdbMasculino.TabIndex = 0
        Me.RdbMasculino.TabStop = True
        Me.RdbMasculino.Text = "Masculino"
        Me.RdbMasculino.UseVisualStyleBackColor = True
        '
        'GrdClientes
        '
        Me.GrdClientes.AllowUserToAddRows = False
        Me.GrdClientes.AllowUserToDeleteRows = False
        Me.GrdClientes.AutoGenerateColumns = False
        Me.GrdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdClientesDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn})
        Me.GrdClientes.DataSource = Me.ClienteBindingSource
        Me.GrdClientes.Location = New System.Drawing.Point(450, 39)
        Me.GrdClientes.MultiSelect = False
        Me.GrdClientes.Name = "GrdClientes"
        Me.GrdClientes.ReadOnly = True
        Me.GrdClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrdClientes.Size = New System.Drawing.Size(288, 179)
        Me.GrdClientes.TabIndex = 16
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
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(675, 254)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(63, 23)
        Me.BtnSalir.TabIndex = 15
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(606, 254)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(63, 23)
        Me.BtnNuevo.TabIndex = 14
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(537, 254)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(63, 23)
        Me.BtnEliminar.TabIndex = 13
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Location = New System.Drawing.Point(468, 254)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(63, 23)
        Me.BtnGrabar.TabIndex = 12
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'BtnBuscarPorNombre
        '
        Me.BtnBuscarPorNombre.Location = New System.Drawing.Point(257, 36)
        Me.BtnBuscarPorNombre.Name = "BtnBuscarPorNombre"
        Me.BtnBuscarPorNombre.Size = New System.Drawing.Size(31, 23)
        Me.BtnBuscarPorNombre.TabIndex = 28
        Me.BtnBuscarPorNombre.Text = "B"
        Me.BtnBuscarPorNombre.UseVisualStyleBackColor = True
        '
        'BtnBuscarPorCedula
        '
        Me.BtnBuscarPorCedula.Location = New System.Drawing.Point(181, 147)
        Me.BtnBuscarPorCedula.Name = "BtnBuscarPorCedula"
        Me.BtnBuscarPorCedula.Size = New System.Drawing.Size(31, 23)
        Me.BtnBuscarPorCedula.TabIndex = 29
        Me.BtnBuscarPorCedula.Text = "B"
        Me.BtnBuscarPorCedula.UseVisualStyleBackColor = True
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 343)
        Me.Controls.Add(Me.BtnBuscarPorCedula)
        Me.Controls.Add(Me.BtnBuscarPorNombre)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.GrdClientes)
        Me.Controls.Add(Me.GpbGenero)
        Me.Controls.Add(Me.BtnEliminarFoto)
        Me.Controls.Add(Me.BtnBuscarFoto)
        Me.Controls.Add(Me.PctFoto)
        Me.Controls.Add(Me.TxtSalario)
        Me.Controls.Add(Me.LblSalario)
        Me.Controls.Add(Me.TxtCantidadHijos)
        Me.Controls.Add(Me.LblCantidadHijos)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.DtpNacimiento)
        Me.Controls.Add(Me.LblNacimiento)
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
        Me.GpbGenero.ResumeLayout(False)
        Me.GpbGenero.PerformLayout()
        CType(Me.GrdClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblCodigo As Label
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblDireccion As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents LblTelefono As Label
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents LblCedula As Label
    Friend WithEvents TxtRuc As TextBox
    Friend WithEvents LblRuc As Label
    Friend WithEvents LblNacimiento As Label
    Friend WithEvents DtpNacimiento As DateTimePicker
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblCantidadHijos As Label
    Friend WithEvents TxtCantidadHijos As NumericUpDown
    Friend WithEvents TxtSalario As NumericUpDown
    Friend WithEvents LblSalario As Label
    Friend WithEvents PctFoto As PictureBox
    Friend WithEvents BtnBuscarFoto As Button
    Friend WithEvents BtnEliminarFoto As Button
    Friend WithEvents GpbGenero As GroupBox
    Friend WithEvents RdbFemenino As RadioButton
    Friend WithEvents RdbMasculino As RadioButton
    Friend WithEvents GrdClientes As DataGridView
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnGrabar As Button
    Friend WithEvents IdClientesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents BtnBuscarPorNombre As Button
    Friend WithEvents BtnBuscarPorCedula As Button
End Class
