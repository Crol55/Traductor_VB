Module Archivo1

    Sub Main()
        SentenciaSwtich(1)
        SentenciaIf(63)
    End Sub

    Sub SentenciaSwtich(ByVal nota As Integer)

        Select Case nota
            Case 1
                Console.WriteLine("Su numero ingresada es 1")
            Case 2
                Console.WriteLine("Su numero ingresada es 2")
            Case 3
                Console.WriteLine("Su numero ingresada es 3")
            Case Else
                Console.WriteLine("ES OTRA NUMERO")
        End Select
    End Sub

    Sub SentenciaIf(ByVal nota As Integer)
        Console.WriteLine("Sunota es " & nota)
        If nota <= 100 And nota >= 0 Then
            If nota <= 100 And nota >= 80 Then
                Console.WriteLine("Gano con buena nota")
            ElseIf nota < 80 And nota > 64 Then
                Console.WriteLine("Gano")
            ElseIf nota < 65 And nota > 60 Then
                Console.WriteLine("Ufff, casi pierde, pero gano :D")
            End If
        Else
            Console.WriteLine("La nota no es valida")
        End If
    End Sub


End Module
