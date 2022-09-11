Imports MySql.Data.MySqlClient
Public Class Eliminar
    Sub prod()
        Dim cadenaConect = "Server=localhost;Database=tienda;User id=root;Password=;Port=3306;"
        Dim conect As New MySqlConnection(cadenaConect)
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        conect.Open()
        Dim sQuery = "select p.id_productos as 'ID', p.nombre_productos as 'Nombre producto', p.existencias as 'Existencias', p.id_proveedor as 'Proveedores', p.precio as 'Precio', p.descripcion as 'Descripción' from productos p;"
        da = New MySqlDataAdapter(sQuery, conect)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conect.Close()
    End Sub
    Sub delete()
        Dim cadenaConect = "Server=localhost;Database=tienda;User id=root;Password=;Port=3306;"
        Dim conect As New MySqlConnection(cadenaConect)
        conect.Open()

        Dim cmd As New MySqlCommand("Delete from productos where id_productos = '" & Me.tbcodigo.Text & "'", conect)
        cmd.ExecuteNonQuery()

        tbcodigo.Clear()
    End Sub
    Private Sub Eliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prod()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If tbcodigo.TextLength = 0 Then
            MessageBox.Show("Debe ingresar un código válido")
        Else
            delete()
            prod()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Productos.Show()

    End Sub
End Class