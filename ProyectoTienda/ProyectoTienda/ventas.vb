Imports MySql.Data.MySqlClient
Public Class ventas
    Public cliente As String
    Public datoscliente As String
    Public producto(100) As String
    Public cantidad(100) As Integer
    Public precio(100) As Double
    Public subtotal(100) As Double
    Dim fecha As String
    Public total As Double
    Dim contador = 0
    Dim idc As String
    Sub datosc()
        Dim nombre, direccion, nit As String
        fecha = DateTime.Now()
        nombre = tbname.Text
        direccion = tbdireccion.Text
        nit = tbnit.Text

        datoscliente = "Fecha y hora: " & fecha & vbCrLf & "Nombre: " & nombre & vbCrLf & "Dirección: " & direccion & vbCrLf & "NIT: " & nit
    End Sub
    Sub coneccion()
        Dim cadenaConect = "Server=localhost;Database=tienda;User id=root;Password=;Port=3306;"
        Dim conect As New MySqlConnection(cadenaConect)
        conect.Open()
        Dim sQuery = "SELECT * from productos;"
        conect.Close()
    End Sub
    Sub agcliente()
        Dim cadenaConect = "Server=localhost;Database=tienda;User id=root;Password=;Port=3306;"
        Dim conect As New MySqlConnection(cadenaConect)
        conect.Open()

        Dim cmd As New MySqlCommand("Insert into clientes(id_clientes, nombre_cliente, direccion_cliente, nit_cliente)VALUES('""', '" & Me.tbname.Text & "', '" & Me.tbdireccion.Text & "', '" & Me.tbnit.Text & "')", conect)
        cmd.ExecuteNonQuery()

        conect.Close()

        GroupBox1.Enabled = False
        GroupBox2.Enabled = True

    End Sub
    Sub agprod()
        Dim cadenaConect = "Server=localhost;Database=tienda;User id=root;Password=;Port=3306;"
        Dim conect As New MySqlConnection(cadenaConect)
        Dim da As MySqlDataAdapter
        Dim ds As New DataSet
        conect.Open()
        Dim sQuery = "SELECT nombre_productos, precio FROM productos WHERE id_productos = '" & Me.tbcodprod.Text & "';"
        da = New MySqlDataAdapter(sQuery, conect)

        da.Fill(ds, "productos")
        If contador < 101 Then
            producto(contador) = ds.Tables("productos").Rows(0).Item(0)
            precio(contador) = ds.Tables("productos").Rows(0).Item(1)
            cantidad(contador) = nudcant.Value
            subtotal(contador) = Math.Round((cantidad(contador) * precio(contador) * 1.12), 2, MidpointRounding.ToEven)
            total += subtotal(contador)
            tbtotal.Text = total
            contador += 1
            tbcodprod.Clear()
            nudcant.Value = 0
            tbcodprod.Focus()
        Else
            MessageBox.Show("No puede agregar más productos")
            tbcodprod.Clear()
            nudcant.Value = 0
            tbcodprod.Focus()
        End If

        lbproducto.Items.Clear()
        lbcant.Items.Clear()
        lbsubtotal.Items.Clear()
        For i = 0 To 100 Step 1
            If producto(i) IsNot Nothing Then
                lbproducto.Items.Add(producto(i))
                lbcant.Items.Add(cantidad(i))
                lbsubtotal.Items.Add(subtotal(i))
            End If
        Next

    End Sub
    Sub idcliente()
        Dim cadenaConect = "Server=localhost;Database=tienda;User id=root;Password=;Port=3306"
        Dim conect As New MySqlConnection(cadenaConect)
        Dim da As MySqlDataAdapter
        Dim ds As New DataSet
        conect.Open()
        Dim sQuery = "SELECT id_clientes from clientes WHERE nombre_cliente = '" & Me.tbname.Text & "';"
        da = New MySqlDataAdapter(sQuery, conect)
        da.Fill(ds, "clientes")
        conect.Close()

        idc = ds.Tables("clientes").Rows(0).Item(0)
    End Sub
    Sub venta()
        Dim cadenaConect = "Server=localhost;Database=tienda;User id=root;Password=;Port=3306;"
        Dim conect As New MySqlConnection(cadenaConect)
        conect.Open()

        Dim cmd As New MySqlCommand("Insert into ventas(id_ventas, id_tienda, id_cliente, ingresos, fecha_venta)VALUES('""', '" & Menuinicio.tienda & "', '" & idc & "', '" & Me.tbtotal.Text & "', '" & fecha & "')", conect)
        cmd.ExecuteNonQuery()

        conect.Close()

    End Sub
    Sub reinicio()
        GroupBox1.Enabled = True
        tbname.Clear()
        tbdireccion.Clear()
        tbnit.Clear()
        GroupBox2.Enabled = False
        tbcodprod.Clear()
        nudcant.Value = 0
        lbproducto.Items.Clear()
        lbcant.Items.Clear()
        lbsubtotal.Items.Clear()
        tbtotal.Clear()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Menuinicio.Show()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        agprod()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If tbname.TextLength = 0 Or tbnit.TextLength = 0 Or tbdireccion.TextLength = 0 Then
            MessageBox.Show("Debe ingresar un cliente")
        Else
            agcliente()
            datosc()
            idcliente()

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If lbproducto.Items.Count = 0 Then
            MessageBox.Show("Debe ingresar algún producto")
        Else
            Me.Hide()
            Factura.Show()
            venta()
            reinicio()

        End If

    End Sub

    Private Sub ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class