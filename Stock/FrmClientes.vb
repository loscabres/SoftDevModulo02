Imports MySql.Data.MySqlClient
Public Class FrmClientes

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dispose()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxtCodigo.Text = 0
        TxtNombre.Clear()
        TxtDireccion.Clear()
        TxtTelefono.Clear()
        TxtCedula.Clear()
        TxtRuc.Clear()
        DtpNacimiento.Text = Now
        TxtEmail.Clear()
        TxtCantidadHijos.Value = 0
        TxtSalario.Value = 0
        PctFoto.Image = Nothing
        RdbMasculino.Checked = True

        TxtNombre.Focus()
    End Sub

    Private Sub BtnEliminarFoto_Click(sender As Object, e As EventArgs) Handles BtnEliminarFoto.Click
        PctFoto.Image = Nothing
    End Sub

    Private Sub BtnBuscarFoto_Click(sender As Object, e As EventArgs) Handles BtnBuscarFoto.Click
        Dim AbrirArchivo As New OpenFileDialog
        AbrirArchivo.Filter = "Imagenes jpg|*.jpg"
        AbrirArchivo.ShowDialog()

        If AbrirArchivo.FileName <> "" Then
            PctFoto.Image = Image.FromFile(AbrirArchivo.FileName)
        End If

    End Sub

    Private Sub TxtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDireccion.Focus()
        End If
    End Sub

    Private Sub TxtDireccion_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtDireccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTelefono.Focus()
        End If
    End Sub

    Private Sub TxtTelefono_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtTelefono.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtCedula.Focus()
        End If
    End Sub

    Private Sub TxtCedula_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCedula.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtRuc.Focus()
        End If
    End Sub

    Private Sub TxtRuc_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtRuc.KeyDown
        If e.KeyCode = Keys.Enter Then
            DtpNacimiento.Focus()
        End If
    End Sub

    Private Sub DtpNacimiento_KeyDown(sender As Object, e As KeyEventArgs) Handles DtpNacimiento.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtEmail.Focus()
        End If
    End Sub

    Private Sub TxtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtCantidadHijos.Focus()
        End If
    End Sub

    Private Sub TxtCantidadHijos_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCantidadHijos.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtSalario.Focus()
        End If
    End Sub

    Private Sub TxtSalario_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSalario.KeyDown
        If e.KeyCode = Keys.Enter Then
            RdbMasculino.Focus()
        End If
    End Sub

    Private Sub RdbMasculino_KeyDown(sender As Object, e As KeyEventArgs) Handles RdbMasculino.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnGrabar.Focus()
        End If
    End Sub

	Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Try
			GrdClientes.DataSource = Cliente.RecuperarTodosLosClientes
		Catch ex As Exception
			MessageBox.Show("Ocurrio este error: " & ex.Message)
		End Try
	End Sub

	Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
		Try
			Dim NuevoCliente As New Cliente
			Dim Id_Cliente As Integer

			NuevoCliente.Id_Clientes = TxtCodigo.Text

			NuevoCliente.Nombre = TxtNombre.Text.Trim
			NuevoCliente.Direccion = TxtDireccion.Text.Trim
			NuevoCliente.Telefono = TxtTelefono.Text.Trim
			NuevoCliente.Cedula = TxtCedula.Text.Trim
			NuevoCliente.Ruc = TxtRuc.Text.Trim
			NuevoCliente.Nacimiento = DtpNacimiento.Value
			NuevoCliente.Email = TxtEmail.Text.Trim
			NuevoCliente.CantidadHijos = TxtCantidadHijos.Value
			NuevoCliente.Salario = TxtSalario.Value
			NuevoCliente.Foto = PctFoto.Image
			NuevoCliente.Genero = RdbFemenino.Checked

			If TxtCodigo.Text = 0 Then
				Id_Cliente = Cliente.InsertarClientes(NuevoCliente)
			Else
				Cliente.EditarClientes(NuevoCliente)
			End If

			BtnNuevo_Click(Nothing, Nothing)
			GrdClientes.DataSource = Cliente.RecuperarTodosLosClientes

			MessageBox.Show("Operacion realizada")
		Catch ex As Exception
			MessageBox.Show("Ocurrio este error: " & ex.Message)
		End Try
	End Sub

	Private Sub GrdClientes_SelectionChanged(sender As Object, e As EventArgs) Handles GrdClientes.SelectionChanged
		If GrdClientes.SelectedRows.Count > 0 Then
			Dim Id_Clientes As Integer = GrdClientes.SelectedRows(0).Cells(0).Value

			Dim ClienteElegido As Cliente

			ClienteElegido = Cliente.RecuperarUnCliente(Id_Clientes)

			TxtCodigo.Text = ClienteElegido.Id_Clientes
			TxtNombre.Text = ClienteElegido.Nombre
			TxtDireccion.Text = ClienteElegido.Direccion
			TxtTelefono.Text = ClienteElegido.Telefono
			TxtCedula.Text = ClienteElegido.Cedula
			TxtRuc.Text = ClienteElegido.Ruc
			DtpNacimiento.Value = ClienteElegido.Nacimiento
			TxtEmail.Text = ClienteElegido.Email
			TxtCantidadHijos.Value = ClienteElegido.CantidadHijos
			TxtSalario.Value = ClienteElegido.Salario

			If ClienteElegido.Genero = 0 Then
				RdbMasculino.Checked = True
			Else
				RdbFemenino.Checked = True
			End If

			PctFoto.Image = ClienteElegido.Foto

		End If
	End Sub

	Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
		If MessageBox.Show("Quiere eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
			Dim NuevoCliente As New Cliente
			NuevoCliente.Id_Clientes = TxtCodigo.Text
			Cliente.EliminarClientes(NuevoCliente)

			BtnNuevo_Click(Nothing, Nothing)
			GrdClientes.DataSource = Cliente.RecuperarTodosLosClientes

			MessageBox.Show("Operacion realizada")
		End If

	End Sub
End Class
