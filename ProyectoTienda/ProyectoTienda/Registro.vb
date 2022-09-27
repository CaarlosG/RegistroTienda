Imports MySql.Data.MySqlClient
Public Class Registro
    Dim iduser As String
    Sub agregarusu()
        Dim cadenaconect = "Server=localhost;Database=tienda;User id=root;Password=;Port=3306;"
        Dim conect As New MySqlConnection(cadenaconect)
        conect.Open()

        Dim cmd As New MySqlCommand("Insert into encargado(id_encargado, nombre_encargado,tel_encargado, cui_encargado, usuario_encargado, contraseña_encargado)VALUES('""', '" & Me.tbname.Text & "', '" & Me.tbtel.Text & "', '" & Me.tbcui.Text & "', '" & Me.tbuser.Text & "', '" & Me.tbcontra1.Text & "')", conect)
        cmd.ExecuteNonQuery()

        conect.Close()

    End Sub
    Sub muni()
        Dim cadenaConect = "Server=localhost;Database=tienda;User id=root;Password=;Port=3306;"
        Dim conect As New MySqlConnection(cadenaConect)
        Dim da As MySqlDataAdapter
        Dim ds As New DataSet
        conect.Open()
        Dim sQuery = "SELECT id_municipio, nombre_muni from municipio;"
        da = New MySqlDataAdapter(sQuery, conect)

        da.Fill(ds)
        ComboBox1.DataSource = ds.Tables(0)

        ComboBox1.DisplayMember = "nombre_muni"
        ComboBox1.ValueMember = "id_municipio"
        conect.Close()
    End Sub
    Sub encargado()
        Dim cadenaConect = "Server=localhost;Database=tienda;User id=root;Password=;Port=3306;"
        Dim conect As New MySqlConnection(cadenaConect)
        Dim da As MySqlDataAdapter
        Dim ds As New DataSet
        conect.Open()
        Dim sQuery = "SELECT id_encargado from encargado where usuario_encargado = '" & Me.tbuser.Text & "' and contraseña_encargado = '" & Me.tbcontra1.Text & "';"
        da = New MySqlDataAdapter(sQuery, conect)

        da.Fill(ds, "encargado")
        iduser = ds.Tables("encargado").Rows(0).Item(0)

        conect.Close()
    End Sub
    Sub tienda()
        Dim cadenaconect = "Server=localhost;Database=tienda;User id=root;Password=;Port=3306;"
        Dim conect As New MySqlConnection(cadenaconect)
        conect.Open()

        Dim cmd As New MySqlCommand("Insert into tienda(id_tienda, id_municipio, direccion, id_encargado)VALUES('""', '" & Me.ComboBox1.SelectedIndex + 1 & "', '" & Me.tbdirec.Text & "', '" & iduser & "')", conect)
        cmd.ExecuteNonQuery()

        conect.Close()
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbtel.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbcui.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Inicio_sesion.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tbname.TextLength = 0 Or tbtel.TextLength = 0 Or tbcui.TextLength = 0 Or tbuser.TextLength = 0 Or tbcontra.TextLength = 0 Or tbcontra1.TextLength = 0 Then
            MessageBox.Show("Debe ingresar un dato en cada campo")
        ElseIf tbcontra.Text = tbcontra1.Text Then
            agregarusu()

            GroupBox2.Enabled = False
            Button2.Enabled = False
            GroupBox1.Enabled = True
            encargado()

        Else
            MessageBox.Show("Las contraseñas no coinciden")
            tbcontra1.Clear()

        End If

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Inicio_sesion.Show()

    End Sub

    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        muni()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If tbdirec.TextLength = 0 Then
            MessageBox.Show("Ingrese un dato en cada campo")
        Else
            tienda()
        End If
        Me.Close()
        Inicio_sesion.Show()

    End Sub
End Class