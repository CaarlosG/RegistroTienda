Imports MySql.Data.MySqlClient
Public Class Factura

    Sub factura()
        Dim textoc As String
        textoc = ventas.datoscliente
        textoc += vbCrLf & "-----------------------------------------------------"
        textoc += vbCrLf & "Cantidad    Producto        Subtotal"
        For i = 0 To ventas.producto.Length - 1 Step 1
            If ventas.producto(i) IsNot Nothing Then
                textoc += vbCrLf & ventas.cantidad(i) & "                " & ventas.producto(i) & "                 Q" & ventas.subtotal(i)
            End If
        Next
        textoc += vbCrLf & vbCrLf & "Total: " & "Q" & ventas.tbtotal.Text

        TextBox1.Text = textoc
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        factura()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        ventas.Show()
        TextBox1.Clear()

    End Sub
End Class