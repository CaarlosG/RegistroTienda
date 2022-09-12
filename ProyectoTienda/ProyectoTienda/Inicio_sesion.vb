Imports MySql.Data.MySqlClient
Public Class Inicio_sesion
    Public encargado As String
    Public id As String
    Private Sub Inicio_sesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cadenaConect = "Server=localhost;Database=tienda;User id=root;Password=;Port=3306"
        Dim conect As New MySqlConnection(cadenaConect)
        Dim da As MySqlDataAdapter
        Dim ds As New DataSet
        conect.Open()
        Dim sQuery = "SELECT * FROM encargado"
        da = New MySqlDataAdapter(sQuery, conect)
        da.Fill(ds)
        conect.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conect As MySqlConnection = New MySqlConnection
        Dim cmd As MySqlCommand = New MySqlCommand
        Dim color1 As Color = Color.DarkSlateGray
        cmd.Connection = conect

        conect.ConnectionString = "Server=localhost;Database=tienda;User id=root;Password=;Port=3306"
        conect.Open()

        cmd.CommandText = "Select * from encargado where usuario_encargado = '" & Me.tbname.Text & "' AND contraseña_encargado = '" & Me.tbpassword.Text & "'"

        Dim read As MySqlDataReader

        read = cmd.ExecuteReader

        If read.HasRows <> False Then
            read.Read()

            encargado = read.GetString("nombre_encargado")
            id = read.GetString("id_encargado")
            MessageBox.Show("Bienvenido" & " " & read.GetString("nombre_encargado"))
            conect.Close()
            tbname.Clear()
            tbpassword.Clear()
            tbname.Focus()


            Me.Hide()
            Menuinicio.Show()

        Else
            MessageBox.Show("Usuario o contraseña incorrectos")
            tbpassword.Clear()
            tbpassword.Focus()

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
