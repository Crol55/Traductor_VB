Imports System.IO
Imports System.Text

Public Class ejecutar

    Public Sub GenerarFile_Java(ByVal instrucciones As String, ByVal clase As String)

        'Dim file As System.IO.StreamWriter
        'file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\carlo\OneDrive\Documentos\visual studio 2015\Projects\Traductor_VB_JAVA\Traductor_VB_JAVA\bin\Debug\" + clase + ".java", True)
        'file.WriteLine(instrucciones)
        'file.Close()

        Dim path As String = clase & ".java"
        Dim fs As FileStream = File.Create(path)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(instrucciones)
        fs.Write(info, 0, info.Length)
        fs.Close()


    End Sub

    Public Sub Ejecutar_Instrucciones(ByVal archivo As String)
        ' Dim a As Process = New Process()
        Dim text As String
        text = "javac " + archivo + ".java"
        Shell("cmd.exe /k" + text)


    End Sub




End Class
