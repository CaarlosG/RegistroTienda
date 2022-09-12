Imports MySql.Data.MySqlClient
Public Class Agregar
    Sub prod()
        Dim cadenaConect = "Server=localhost;Database=tienda;User id=root;Password=;Port=3306;"
        Dim conect As New MySqlConnection(cadenaConect)
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        conect.Open()
        Dim sQuery = "SELECT p.id_productos as 'ID', p.nombre_productos as 'Nombre producto', p.existencias as 'Existencias', pr.nombre as 'Proveedores', p.precio as 'Precio', p.descripcion as 'Descripción' from productos p inner join proveedores pr on p.id_proveedor = p.id_proveedor;"
        da = New MySqlDataAdapter(sQuery, conect)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conect.Close()
    End Sub
    Sub cb()
        Dim cadenaConect = "Server=localhost;Database=tienda;User id=root;Password=;Port=3306;"
        Dim conect As New MySqlConnection(cadenaConect)
        Dim da As MySqlDataAdapter
        Dim ds As New DataSet
        conect.Open()
        Dim sQuery = "SELECT id_proveedores, nombre from proveedores;"
        da = New MySqlDataAdapter(sQuery, conect)

        da.Fill(ds)
        cb1.DataSource = ds.Tables(0)
        cb1.DisplayMember = "nombre"
        cb1.ValueMember = "id_proveedores"
        conect.Close()
    End Sub
    Sub agr()
        Dim cadenaConect = "Server=localhost;Database=tienda;User id=root;Password=;Port=3306;"
        Dim conect As New MySqlConnection(cadenaConect)
        conect.Open()

        Dim cmd As New MySqlCommand("Insert into productos(id_productos, nombre_productos, existencias, id_proveedor, precio, descripcion)VALUES('""', '" & Me.tb1.Text & "', '" & Me.tb2.Text & "', '" & Me.cb1.SelectedIndex + 1 & "','" & Me.tb3.Text & "', '" & Me.tb4.Text & "')", conect)
        cmd.ExecuteNonQuery()

        conect.Close()

        tb1.Clear()
        tb2.Clear()
        cb1.ResetText()
        tb3.Clear()
        tb4.Clear()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Productos.Show()

    End Sub

    Private Sub Agregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prod()
        cb()

    End Sub

    Private Sub tb3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb3.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If tb1.TextLength = 0 Or tb2.TextLength = 0 Or tb3.TextLength = 0 Or tb4.TextLength = 0 Then
            MessageBox.Show("Debe ingresar un dato en cada campo")
        Else
            agr()
            prod()
        End If
    End Sub
End Class