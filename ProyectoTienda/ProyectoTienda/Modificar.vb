Imports MySql.Data.MySqlClient
Public Class Modificar
    Sub dis()
        tb1.Enabled = False
        tb2.Enabled = False
        tb3.Enabled = False
        tb4.Enabled = False
        cb1.Enabled = False
        Button3.Enabled = False
    End Sub
    Sub en()
        tb1.Enabled = True
        tb2.Enabled = True
        tb3.Enabled = True
        tb4.Enabled = True
        cb1.Enabled = True
        Button3.Enabled = True
    End Sub
    Sub prod()
        Dim cadenaConect = "Server=localhost;Database=tienda;User id=root;Password=;Port=3306;"
        Dim conect As New MySqlConnection(cadenaConect)
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        conect.Open()
        Dim sQuery = "select p.id_productos as 'ID', p.nombre_productos as 'Nombre producto', p.existencias as 'Existencias', p.id_proveedor as 'Proveedores', p.precio_venta as 'Precio', p.descripcion as 'Descripción' from productos p;"
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
        Dim sQuery = "SELECT id_proveedores from proveedores;"
        da = New MySqlDataAdapter(sQuery, conect)

        da.Fill(ds)
        cb1.DataSource = ds.Tables(0)
        cb1.DisplayMember = "id_proveedores"
        cb1.ValueMember = "id_proveedores"
        conect.Close()
    End Sub
    Sub sel()
        Dim cadenaConect = "Server=localhost;Database=tienda;User id=root;Password=;Port=3306;"
        Dim conect As New MySqlConnection(cadenaConect)
        Dim da As MySqlDataAdapter
        Dim ds As New DataSet
        conect.Open()
        Dim sQuery = "SELECT nombre_productos, existencias, id_proveedor, precio_venta, descripcion FROM productos WHERE id_productos = '" & Me.tbcodigo.Text & "';"
        da = New MySqlDataAdapter(sQuery, conect)

        tb1.Clear()
        tb2.Clear()
        tb3.Clear()
        tb4.Clear()
        cb1.ResetText()

        da.Fill(ds, "productos")

        Me.tb1.Text = ds.Tables("productos").Rows(0).Item(0)
        Me.tb2.Text = ds.Tables("productos").Rows(0).Item(1)
        Me.cb1.Text = ds.Tables("productos").Rows(0).Item(2)
        Me.tb3.Text = ds.Tables("productos").Rows(0).Item(3)
        Me.tb4.Text = ds.Tables("productos").Rows(0).Item(4)
    End Sub
    Sub m()
        Dim cadenaConect = "Server=localhost;Database=tienda;User id=root;Password=;Port=3306;"
        Dim conect As New MySqlConnection(cadenaConect)
        conect.Open()

        Dim cmd As New MySqlCommand("UPDATE productos SET nombre_productos = '" & Me.tb1.Text & "', existencias = '" & Me.tb2.Text & "', id_proveedor = '" & Me.cb1.Text & "' , precio_venta = '" & Me.tb3.Text & "' , descripcion = '" & Me.tb4.Text & "' Where id_productos = '" & Conversion.Int(Me.tbcodigo.Text) & "'", conect)
        cmd.ExecuteNonQuery()

        conect.Close()

        tbcodigo.Clear()
        tb1.Clear()
        tb2.Clear()
        tb3.Clear()
        tb4.Clear()
        cb1.ResetText()
    End Sub
    Private Sub Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prod()
        cb()
        dis()

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbcodigo.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tbcodigo.TextLength = 0 Then
            MessageBox.Show("Debe ingresar un código valido")
        Else
            sel()
            tbcodigo.Enabled = False
            en()

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Productos.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        m()
        tbcodigo.Enabled = True
        dis()
        prod()

    End Sub

    Private Sub tb3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb3.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class