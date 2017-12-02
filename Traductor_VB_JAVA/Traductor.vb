Public Class Traductor




    Public Function Generar_corchete(ByVal size As Integer) As String
        ' MessageBox.Show("el jodido tamñao es   " + size)
        Dim cad As String = "[]"
        Dim cad2 As String = Nothing

        For i As Integer = 1 To size
            cad2 += cad

        Next

        Return cad2

    End Function
    Function Condicional_For(ByVal inicio As Integer, ByVal final As Integer, ByVal id As String, ByVal simbolo As String, ByVal steep As String) As String
        Dim ret As String = ""

        If inicio < final Then

            ret = id + "<" + final.ToString() + ";"
            If simbolo.Equals("") Then

                ret += id + "=" + id + "+" + simbolo + steep
            End If
        Else
            ret = id + ">" + final.ToString() + ";"
            If simbolo.Equals("-") Then
                ret += id + "=" + id + simbolo + steep
            End If

        End If



        Return ret
    End Function

    Function iteracion_For() As String

        Return ""
    End Function




End Class
