Imports MySql.Data.MySqlClient
Public Class Menuinicio
    Public tienda As String
    Sub tiendas()
        Dim cadenaConect = "Server=localhost;Database=tienda;User id=root;Password=;Port=3306"
        Dim conect As New MySqlConnection(cadenaConect)
        Dim da As MySqlDataAdapter
        Dim ds As New DataSet
        conect.Open()
        Dim sQuery = "Select t.id_tienda, m.nombre_muni, t.direccion from tienda t INNER JOIN municipio m on t.id_municipio = m.id_municipio where t.id_encargado = '" & Inicio_sesion.id & "';"
        da = New MySqlDataAdapter(sQuery, conect)
        da.Fill(ds, "tienda")
        conect.Close()

        tienda = ds.Tables("tienda").Rows(0).Item(0)
        tbtienda.Text = ds.Tables("tienda").Rows(0).Item(1) & " " & ds.Tables("tienda").Rows(0).Item(2)

        tbencargado.Text = Inicio_sesion.id & " " & Inicio_sesion.encargado

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tbencargado.Clear()
        tbencargado.Clear()

        Me.Close()
        Inicio_sesion.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Productos.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        ventas.Show()

    End Sub

    Private Sub Menuinicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tiendas()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Registro_ventas.Show()

    End Sub
End Class