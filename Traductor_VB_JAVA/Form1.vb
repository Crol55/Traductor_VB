Imports System.IO

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MyParser.Setup()


        If MyParser.Parse(New StringReader(Me.txtarea.Text)) Then
            MessageBox.Show("Cadena correcta°°°°°°°°°")
            txtarea2.Text = MyParser.txt_salida.ToString()
        Else
            MessageBox.Show("Cadena incorrecta")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim er As New html
        er.Errores_html(MyParser.Errores_)

    End Sub
End Class
