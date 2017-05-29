Imports System.ComponentModel
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Cliente

	Private _Id_Clientes As Integer
	Public Property Id_Clientes As Integer
		Get
			Return _Id_Clientes
		End Get
		Set(value As Integer)
			_Id_Clientes = value
		End Set
	End Property

	Private _Nombre As String
	Public Property Nombre As String
		Get
			Return _Nombre
		End Get
		Set(value As String)
			_Nombre = value
		End Set
	End Property

	Private _Direccion As String
	Public Property Direccion As String
		Get
			Return _Direccion
		End Get
		Set(value As String)
			_Direccion = value
		End Set
	End Property

	Private _Telefono As String
	Public Property Telefono As String
		Get
			Return _Telefono
		End Get
		Set(value As String)
			_Telefono = value
		End Set
	End Property

	Private _Cedula As String
	Public Property Cedula As String
		Get
			Return _Cedula
		End Get
		Set(value As String)
			_Cedula = value
		End Set
	End Property

	Private _Ruc As String
	Public Property Ruc As String
		Get
			Return _Ruc
		End Get
		Set(value As String)
			_Ruc = value
		End Set
	End Property

	Private _Nacimiento As Date
	Public Property Nacimiento As Date
		Get
			Return _Nacimiento
		End Get
		Set(value As Date)
			_Nacimiento = value
		End Set
	End Property

	Private _Email As String
	Public Property Email As String
		Get
			Return _Email
		End Get
		Set(value As String)
			_Email = value
		End Set
	End Property

	Private _CantidadHijos As Integer
	Public Property CantidadHijos As Integer
		Get
			Return _CantidadHijos
		End Get
		Set(value As Integer)
			_CantidadHijos = value
		End Set
	End Property

	Private _Salario As Double
	Public Property Salario As Double
		Get
			Return _Salario
		End Get
		Set(value As Double)
			_Salario = value
		End Set
	End Property

	Private _Foto As Image
	Public Property Foto As Image
		Get
			Return _Foto
		End Get
		Set(value As Image)
			_Foto = value
		End Set
	End Property

	Private _Genero As Integer
	Public Property Genero As Integer
		Get
			Return _Genero
		End Get
		Set(value As Integer)
			_Genero = value
		End Set
	End Property

	Public Shared Function Image2Bytes(ByVal Img As Image) As Byte()
		If Img Is Nothing Then
			Return Nothing
		Else
			Dim converter As New ImageConverter
			Return converter.ConvertTo(Img, GetType(Byte()))
		End If
	End Function

	Public Shared Function Bytes2Image(ByVal bytes() As Byte) As Image
		If bytes Is Nothing Then
			Return Nothing
		Else
			Dim ms As New MemoryStream(bytes)

			Dim Img As Image = Nothing
			Try
				Img = Image.FromStream(ms)
			Catch ex As Exception

			End Try

			Return Img
		End If
	End Function

	Public Shared Function RecuperarTodosLosClientes() As BindingList(Of Cliente)
		Dim Retorno As New BindingList(Of Cliente)

		'CONEXION A LA BASE DE DATOS

		Dim Conexion As New MySqlConnection
		Conexion.ConnectionString = "Server=localhost;Port=3306;Database=stock;Uid=root;Pwd=123456;"

		Try
			Conexion.Open()

			'COMANDO
			Dim Comando As New MySqlCommand
			Comando.Connection = Conexion
			Comando.CommandType = CommandType.StoredProcedure
			Comando.CommandText = "Pa_ConsultarClientes"
			Comando.Parameters.AddWithValue("ParOpcion", 1)
			Comando.Parameters.AddWithValue("ParId", 0)

			Dim Lector As MySqlDataReader
			Lector = Comando.ExecuteReader

			If Lector.HasRows Then
				While Lector.Read
					Dim Obj As New Cliente

					Obj.Id_Clientes = Lector.GetValue(0)
					Obj.Nombre = Lector.GetValue(1)

					Retorno.Add(Obj)
				End While
			End If

		Catch ex As Exception
			Throw
		Finally
			If Conexion.State = ConnectionState.Open Then
				Conexion.Close()
			End If
		End Try

		Return Retorno
	End Function

	Public Shared Function RecuperarUnCliente(ByVal Id_Clientes As Integer) As Cliente
		Dim Retorno As New Cliente

		'CONEXION A LA BASE DE DATOS

		Dim Conexion As New MySqlConnection
		Conexion.ConnectionString = "Server=localhost;Port=3306;Database=stock;Uid=root;Pwd=123456;"

		Try
			Conexion.Open()

			'COMANDO
			Dim Comando As New MySqlCommand
			Comando.Connection = Conexion
			Comando.CommandType = CommandType.StoredProcedure
			Comando.CommandText = "Pa_ConsultarClientes"
			Comando.Parameters.AddWithValue("ParOpcion", 2)
			Comando.Parameters.AddWithValue("ParId", Id_Clientes)

			Dim Lector As MySqlDataReader
			Lector = Comando.ExecuteReader

			If Lector.HasRows Then
				While Lector.Read

					Retorno.Id_Clientes = Lector.GetValue(0)
					Retorno.Nombre = Lector.GetValue(1)
					Retorno.Direccion = Lector.GetValue(2)
					Retorno.Telefono = Lector.GetValue(3)
					Retorno.Cedula = Lector.GetValue(4)
					Retorno.Ruc = Lector.GetValue(5)
					Retorno.Nacimiento = Lector.GetValue(6)
					Retorno.Email = Lector.GetValue(7)
					Retorno.CantidadHijos = Lector.GetValue(8)
					Retorno.Salario = Lector.GetValue(9)
					Retorno.Genero = Lector.GetValue(11)

					If Not IsDBNull(Lector.GetValue(10)) Then
						Retorno.Foto = Bytes2Image(Lector.GetValue(10))
					End If

				End While
			End If

		Catch ex As Exception
			Throw
		Finally
			If Conexion.State = ConnectionState.Open Then
				Conexion.Close()
			End If
		End Try

		Return Retorno
	End Function

	Public Shared Function InsertarClientes(ByVal ObjCliente As Cliente) As Integer
		Dim Retorno As Integer

		'CONEXION A LA BASE DE DATOS
		Dim Conexion As New MySqlConnection
		Conexion.ConnectionString = "Server=localhost;Port=3306;Database=stock;Uid=root;Pwd=123456;"

		Try
			Conexion.Open()

			'COMANDO
			Dim Comando As New MySqlCommand
			Comando.Connection = Conexion
			Comando.CommandType = CommandType.StoredProcedure
			Comando.CommandText = "Pa_InsertarClientes"
			Comando.Parameters.AddWithValue("ParOpcion", 1)
			Comando.Parameters.AddWithValue("ParNombre", ObjCliente.Nombre)
			Comando.Parameters.AddWithValue("ParDireccion", ObjCliente.Direccion)
			Comando.Parameters.AddWithValue("ParTelefono", ObjCliente.Telefono)
			Comando.Parameters.AddWithValue("ParCedula", ObjCliente.Cedula)
			Comando.Parameters.AddWithValue("ParRuc", ObjCliente.Ruc)
			Comando.Parameters.AddWithValue("ParNacimiento", ObjCliente.Nacimiento)
			Comando.Parameters.AddWithValue("ParEmail", ObjCliente.Email)
			Comando.Parameters.AddWithValue("ParCantidadHijos", ObjCliente.CantidadHijos)
			Comando.Parameters.AddWithValue("ParSalario", ObjCliente.Salario)
			Comando.Parameters.AddWithValue("ParGenero", ObjCliente.Genero)

			If ObjCliente.Foto Is Nothing Then
				Comando.Parameters.AddWithValue("ParFoto", Nothing)
			Else
				Comando.Parameters.AddWithValue("ParFoto", Image2Bytes(ObjCliente.Foto))
			End If

			Retorno = Comando.ExecuteScalar
		Catch ex As Exception
			Throw
		Finally
			If Conexion.State = ConnectionState.Open Then
				Conexion.Close()
			End If
		End Try

		Return Retorno

	End Function

	Public Shared Sub EditarClientes(ByVal ObjCliente As Cliente)
		'CONEXION A LA BASE DE DATOS
		Dim Conexion As New MySqlConnection
		Conexion.ConnectionString = "Server=localhost;Port=3306;Database=stock;Uid=root;Pwd=123456;"

		Try
			Conexion.Open()

			'COMANDO
			Dim Comando As New MySqlCommand
			Comando.Connection = Conexion
			Comando.CommandType = CommandType.StoredProcedure
			Comando.CommandText = "Pa_EditarClientes"
			Comando.Parameters.AddWithValue("ParOpcion", 1)
			Comando.Parameters.AddWithValue("ParNombre", ObjCliente.Nombre)
			Comando.Parameters.AddWithValue("ParDireccion", ObjCliente.Direccion)
			Comando.Parameters.AddWithValue("ParTelefono", ObjCliente.Telefono)
			Comando.Parameters.AddWithValue("ParCedula", ObjCliente.Cedula)
			Comando.Parameters.AddWithValue("ParRuc", ObjCliente.Ruc)
			Comando.Parameters.AddWithValue("ParNacimiento", ObjCliente.Nacimiento)
			Comando.Parameters.AddWithValue("ParEmail", ObjCliente.Email)
			Comando.Parameters.AddWithValue("ParCantidadHijos", ObjCliente.CantidadHijos)
			Comando.Parameters.AddWithValue("ParSalario", ObjCliente.Salario)
			Comando.Parameters.AddWithValue("ParGenero", ObjCliente.Genero)
			Comando.Parameters.AddWithValue("ParId", ObjCliente.Id_Clientes)

			If ObjCliente.Foto Is Nothing Then
				Comando.Parameters.AddWithValue("ParFoto", Nothing)
			Else
				Comando.Parameters.AddWithValue("ParFoto", Image2Bytes(ObjCliente.Foto))
			End If

			Comando.ExecuteNonQuery()

		Catch ex As Exception
			Throw
		Finally
			If Conexion.State = ConnectionState.Open Then
				Conexion.Close()
			End If
		End Try

	End Sub

	Public Shared Sub EliminarClientes(ByVal ObjCliente As Cliente)
		'CONEXION A LA BASE DE DATOS
		Dim Conexion As New MySqlConnection
		Conexion.ConnectionString = "Server=localhost;Port=3306;Database=stock;Uid=root;Pwd=123456;"

		Try
			Conexion.Open()

			'COMANDO
			Dim Comando As New MySqlCommand
			Comando.Connection = Conexion
			Comando.CommandType = CommandType.StoredProcedure
			Comando.CommandText = "Pa_EliminarClientes"
			Comando.Parameters.AddWithValue("ParOpcion", 1)
			Comando.Parameters.AddWithValue("ParId", ObjCliente.Id_Clientes)

			Comando.ExecuteNonQuery()

		Catch ex As Exception
			Throw
		Finally
			If Conexion.State = ConnectionState.Open Then
				Conexion.Close()
			End If
		End Try

	End Sub


End Class
