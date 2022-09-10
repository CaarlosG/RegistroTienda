Imports MySql.Data.MySqlClient
Public Class ventas
    Dim cliente As String
    Dim producto(100) as String
    Dim cantidad(100) As Integer
    Dim subtotal(100) As Double
    Dim total As Double
    Dim contador = 0

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

        Dim cmd As New MySqlCommand("Insert into cliente(id_clientes, nombre_cliente, direccion_cliente, nit_cliente)VALUES('""', '" & Me.tbname.Text & "', '" & Me.tbdireccion.Text & "', '" & Me.tbnit.Text & "')", conect)
        cmd.ExecuteNonQuery()

        conect.Close()

        tbname.Enabled = False
        tbdireccion.Enabled = False
        tbnit.Enabled = False

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Menuinicio.Show()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If contador < 101 Then
            producto(contador) = tbproducto.Text
            cantidad(contador) = nudcant.Value
            subtotal(contador) = Math.Round((cantidad(contador) * tb.Text * 1.12), 2, MidpointRounding.ToEven)
            total += subtotal(contador)
            TextBox6.Text = total
            contador += 1
            TextBox4.Clear()
            NumericUpDown1.Value = 0
            TextBox5.Clear()
            TextBox4.Focus()
        Else
            MessageBox.Show("No se pueden Agregar Más productos")
                TextBox4.Clear()
                NumericUpDown1.Value = 0
                TextBox5.Clear()
                TextBox4.Focus()
            End If
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            ListBox3.Items.Clear()
        For i = 0 To 9 Step 1
            If Productos(i) IsNot Nothing Then
                ListBox1.Items.Add(Productos(i))
                ListBox2.Items.Add(cant(i))
                ListBox3.Items.Add(subtotal(i))
            End If
        Next
    End Sub
End Class