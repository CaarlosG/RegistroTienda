Imports MySql.Data.MySqlClient
Public Class Inicio_sesion
    Private Sub Inicio_sesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tbname_TextChanged(sender As Object, e As EventArgs) Handles tbname.TextChanged
        If tbname.Focused Then
            tbname.Clear()
        Else
            tbname.Text = "Username"
        End If
    End Sub
End Class
