Imports System.IO

Public Class html


    Public Sub Errores_html(ByVal errorr As ArrayList)
        MessageBox.Show("el tamaño del vector es :" + errorr.Count.ToString())
        Dim ruta As String = "C:\Users\carlo\OneDrive\Documentos\visual studio 2015\Projects\Traductor_VB_JAVA\Traductor_VB_JAVA\bin\Debug\ERRORES.html"
        Dim streamw As StreamWriter
        Dim numero As Integer = 1



        streamw = File.CreateText(ruta)
        streamw.WriteLine("<html><head><title>Errores Lexicos y Sintacticos</title><link rel=""stylesheet"" type=""text/css"" href=""styles.css"" /> </head><body><table border=1><tr><th>Linea</th><th>Columna</th><th>Tipo De Error</th><th>Token Recibido(incorrecto)</th><th>Token Esperado</th></tr>")

        Dim aux As String
        For Each aux In errorr
            Dim aux2() As String
            aux2 = aux.Split("&")
            streamw.WriteLine("<tr><th>" + aux2(0) + "</th><th>" + aux2(1) + "</th><th>" + aux2(2) + "</th><th>" + aux2(3) + "</th><th>" + aux2(4) + "</th></tr>")

        Next
        streamw.WriteLine("</table></body></html>")
        streamw.Flush()
        streamw.Close()



    End Sub




End Class
