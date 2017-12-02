Module Archivo2

    Sub Main()
        SentenciaCiclos()
        hacerOperaciones()
        Matrices()
    End Sub


    Sub SentenciaCiclos()
        Dim opcion As Integer = 0
        While opcion <> 7
            Console.WriteLine("Seleccione una opcion")
            Console.WriteLine("1. For incremental en 1")
            Console.WriteLine("2. For incremental en 3")
            Console.WriteLine("3. For decremental")
            Console.WriteLine("4. While con condicion")
            Console.WriteLine("5. While con break")
            Console.WriteLine("6. Do while")
            Console.WriteLine("7. Salir")

            opcion = Console.ReadLine

            Select Case opcion
                Case 1
                    Console.WriteLine("For incremental")
                    For number As Integer = 0 To 10 Step 1
                        Console.WriteLine(number & " ")
                    Next

                Case 2
                    Console.WriteLine("For incremental en 3")
                    For number As Integer = 0 To 20 Step 3
                        Console.WriteLine(number & " ")
                    Next

                Case 3
                    Console.WriteLine("For decremental")
                    For number As Integer = 20 To 0 Step -1
                        Console.WriteLine(number & " ")
                    Next

                Case 4
                    Console.WriteLine("While con condicion")
                    Console.WriteLine("Ingrese el limite final")
                    Dim fin As Integer = Console.ReadLine
                    Dim inicio As Integer = 0
                    While inicio <= fin
                        Console.WriteLine(inicio & " ")
                        inicio = inicio + 1
                    End While

                Case 5
                    Console.WriteLine("while con break")

                    While True
                        Console.WriteLine("ingrese un numero")
                        Dim num As Integer = Console.ReadLine
                        If num = 10 Then
                            Exit While
                        Else
                            Console.WriteLine(num)
                        End If

                    End While

                Case 6
                    Console.WriteLine("Do while")
                    Console.WriteLine("ingrese un numero")
                    Dim num As Integer = Console.ReadLine
                    Do
                        Console.WriteLine(num & " ")
                        num = num + 1
                    Loop Until num > 10
                Case 7
                    If True Then
                    Exit While
                    End If

                Case Else
                    Console.WriteLine("Opcion Incorrecta")
            End Select
        End While
    End Sub

    Function sumar(ByVal op1 As Integer, ByVal op2 As Integer) As Integer
        Return op1 + op2
    End Function

    Function multiplicar(ByVal op1 As Integer, ByVal op2 As Integer) As Integer
        Return op1 * op2
    End Function

    Function concatenar(ByVal valor As Integer) As String
        Return "El resultado es " & valor
    End Function
    Sub hacerOperaciones()
        Dim op As Integer
        op = 0
        Dim operando1, operando2 As Integer
        While op <> 3
            Console.WriteLine("Seleccione una opcion")
            Console.WriteLine("1. Sumar")
            Console.WriteLine("2. Multiplicar")
            Console.WriteLine("3. Salir")

            op = Console.ReadLine

            Select Case op
                Case 1
                    Console.WriteLine("ingrese el primer operando")
                    operando1 = Console.ReadLine
                    Console.WriteLine("ingrese el segundo operando")
                    operando2 = Console.ReadLine
                    Dim resultado As Integer = sumar(operando1, operando2)
                    Dim cadena As String = concatenar(resultado)
                    Console.WriteLine(cadena)

                Case 2
                    Console.WriteLine("ingrese el primer operando")
                    operando1 = Console.ReadLine
                    Console.WriteLine("ingrese el segundo operando")
                    operando2 = Console.ReadLine
                    resultado = multiplicar(operando1, operando2)
                    cadena = concatenar(resultado)
                    Console.WriteLine(cadena)
                Case 3
                    
                    If True Then
                    Exit While
                    End If

                Case Else
                    Console.WriteLine("Opcion Incorrecta")
            End Select
        End While
    End Sub

    Sub Matrices()
        Dim matriz[5, 5] As Integer
        For i As Integer = 0 To 5 Step 1
            For j As Integer = 0 To 5 Step 1
                matriz[i, j] = i * 2
            Next
        Next
        Console.WriteLine("Imprimir valores de las matrices")

        For i As Integer = 0 To 5 Step 1
            For j As Integer = 0 To 5 Step 1
                Console.WriteLine(matriz[i, j])
            Next
        Next
    End Sub



End Module

