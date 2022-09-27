Imports MySql.Data.MySqlClient
Public Class Registro_ventas
    Sub ventas()
        Dim cadenaConect = "Server=localhost;Database=tienda;User id=root;Password=;Port=3306;"
        Dim conect As New MySqlConnection(cadenaConect)
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        conect.Open()
        Dim sQuery = "SELECT v.id_ventas as 'ID', t.direccion as 'Tienda', c.nombre_cliente as 'Cliente', v.ingresos as 'Ingresos', v.fecha_venta as 'Fecha y hora' from ventas v inner join tienda t on v.id_tienda = t.id_tienda inner join clientes c on v.id_cliente = c.id_clientes;"
        da = New MySqlDataAdapter(sQuery, conect)
        dt = New DataTable
        da.Fill(dt)
        DataGridView3.DataSource = dt
        conect.Close()
    End Sub
    Private Sub Registro_ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ventas()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Menuinicio.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ventas()

    End Sub
End Class