Module Archivo3

    Sub Main()
        TercerArchivo()
    End Sub

    Sub TercerArchivo()
        Dim op As Integer = 0

        While op <> 6
            Console.WriteLine("Seleccione una opcion")
            Console.WriteLine("1. Crear Matriz")
            Console.WriteLine("2. Mostrar Transpuesta")
            Console.WriteLine("3. Sumar Matrices")
            Console.WriteLine("4. Serie Fibonacci")
            Console.WriteLine("5. Salir")

            op = Console.ReadLine

            Select Case op
                Case 1
                    'Console.WriteLine("Ingrese la cantidad de filas")
                    Dim filas As Integer = Console.ReadLine
                    Console.WriteLine("Ingrese la cantidad de columnas")
                    Dim col As Integer = Console.ReadLine

                    Dim matriz[filas,col] As Integer
                    For i As Integer = 0 To 5 Step 1
                        For j As Integer = 0 To 5 Step 1
                            matriz[i, j] = i * 2
                        Next
                    Next

                    Console.WriteLine("Imprimir valores de las matrices")
                    Dim impresionMatriz As String

                    For i As Integer = 0 To 5 Step 1
                        impresionMatriz = ""
                        For j As Integer = 0 To 5 Step 1
                            impresionMatriz = impresionMatriz & " " & matriz[i, j] & " "
                        Next
                        Console.WriteLine(impresionMatriz)
                    Next

                Case 2
                    Console.WriteLine("Ingrese la cantidad de filas")
                    Dim filas As Integer = Console.ReadLine
                    Console.WriteLine("Ingrese la cantidad de columnas")
                    Dim col As Integer = Console.ReadLine

                    Dim matriz[filas, col] As Integer
                    For i As Integer = 0 To 5 Step 1
                        For j As Integer = 0 To 5 Step 1
                            matriz[i, j] = i * 2
                        Next
                    Next

                    Console.WriteLine("-----------VALORES MATRIZ-----------")
                    Dim impresionMatriz As String

                    For i As Integer = 0 To 5 Step 1
                        impresionMatriz = ""
                        For j As Integer = 0 To 5 Step 1
                            impresionMatriz = impresionMatriz & " " & matriz[i, j] & " "
                        Next
                        Console.WriteLine(impresionMatriz)
                    Next

                    Console.WriteLine("-----------VALORES TRANSPUESTA-----------")
                    Dim impresionMatrizT As String

                    For i As Integer = 0 To 5 Step 1
                        impresionMatrizT = ""
                        For j As Integer = 0 To 5 Step 1
                            impresionMatrizT = impresionMatrizT & " " & matriz[j, i] & " "
                        Next
                        Console.WriteLine(impresionMatrizT)
                    Next


                Case 3
                    Console.WriteLine("Ingrese la cantidad de filas")
                    Dim filas1 As Integer = Console.ReadLine
                    Console.WriteLine("Ingrese la cantidad de columnas")
                    Dim col1 As Integer = Console.ReadLine

                    Dim matriz1[filas1, col1] As Integer
                    For i As Integer = 0 To 5 Step 1
                        For j As Integer = 0 To 5 Step 1
                            matriz1[i, j] = i * 2
                        Next
                    Next

                    Dim matriz2[filas1, col1] As Integer
                    For i As Integer = 0 To 5 Step 1
                        For j As Integer = 0 To 5 Step 1
                            matriz2[i, j] = i * j
                        Next
                    Next


                    Console.WriteLine("----------MATRIZ1----------")
                    Dim impresionMatriz1 As String

                    For i As Integer = 0 To 5 Step 1
                        impresionMatriz1 = ""
                        For j As Integer = 0 To 5 Step 1
                            impresionMatriz1 = impresionMatriz1 & " " & matriz1[i, j] & " "
                        Next
                        Console.WriteLine(impresionMatriz1)
                    Next

                    Console.WriteLine("----------MATRIZ2----------")

                    Console.WriteLine("Imprimir valores de las matrices")
                    Dim impresionMatriz2 As String

                    For i As Integer = 0 To 5 Step 1
                        impresionMatriz2 = ""
                        For j As Integer = 0 To 4 Step 1
                            impresionMatriz2 = impresionMatriz2 & " " & matriz2[i, j] & " "
                        Next
                        Console.WriteLine(impresionMatriz2)
                    Next

                    Console.WriteLine("----------MATRIZ1 + MATRIZ2----------")

                    For i As Integer = 0 To 5 Step 1
                        impresionMatriz2 = ""
                        For j As Integer = 0 To 4 Step 1
                            impresionMatriz2 = impresionMatriz2 & " " & matriz1[i, j] + matriz2[i, j] & " "
                        Next
                        Console.WriteLine(impresionMatriz2)
                    Next

                Case 4
                    Console.WriteLine("Ingrese el numero limite de la serie")
                    Dim limit As Integer = Console.ReadLine
                    Console.WriteLine("La serie de " & limit & " es:")
                    Dim res As String
                    For i As Integer = 0 To 3 Step 1
                        If i = limit Then
                            res = res & serieFibonacci(i)
                        Else
                            res = res & serieFibonacci(i) & ","
                        End If

                    Next

                    Console.WriteLine(res)

            End Select
        End While

    End Sub

    Function serieFibonacci(ByVal n As Integer) As Integer
        Dim res As Integer
        If n > 1 Then
            Return serieFibonacci(n - 1) + serieFibonacci(n - 2)
        ElseIf n = 1 Or n = 0 Then
            res = n
        End If

        Return res
    End Function

End Module
