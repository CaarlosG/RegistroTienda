Imports MySql.Data.MySqlClient
Public Class Inventario
    Sub inv()
        Dim cadenaConect = "Server=localhost;Database=tienda;User id=root;Password=;Port=3306;"
        Dim conect As New MySqlConnection(cadenaConect)
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        conect.Open()
        Dim sQuery = "select p.id_productos as 'ID', p.nombre_productos as 'Nombre producto', p.existencias as 'Existencias', p.id_proveedor as 'Proveedores', p.precio_venta as 'Precio', p.descripcion as 'Descripción' from productos p;"
        da = New MySqlDataAdapter(sQuery, conect)
        dt = New DataTable
        da.Fill(dt)
        DataGridView3.DataSource = dt
        conect.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Productos.Show()

    End Sub

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inv()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        inv()

    End Sub
End Class