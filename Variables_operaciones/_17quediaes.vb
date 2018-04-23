Module _17quediaes
    Enum numeracionsemanas As Byte
        Domingo = 0
        Lunes = 1
        Martes = 2
        Miercoles = 3
        Jueves = 4
        Viernes = 5
        Sabado = 6
    End Enum
    Sub Main()
        Dim numerodedias As UInt32
        Dim dia As Int32
        Dim mes As Int32
        Dim ano As Int32
        Console.WriteLine("INGRESE UNA FECHA Y UN NUMERO DADO")
        Console.WriteLine("INGRESE UN DIA DE SU FECHA DESDE EL 1 HASTA 31: ")
        dia = Console.ReadLine()
        Console.WriteLine("INGRESE UN MES EN SU FECHA DESDE EL 1 HASTA 12:")
        mes = Console.ReadLine()
        Console.WriteLine("INGRESE UN AÑO EN SU FECHA DESDE EL 1 HASTA 2018:")
        ano = Console.ReadLine()
        Console.WriteLine("INGRESE UN NUMERO DE DIAS A SUMAR: ")
        numerodedias = Console.ReadLine()
        Console.WriteLine("La fecha construida es = " & dia & "/" & mes & "/" & ano)
        Dim diassumados As New DateTime(ano, mes, dia)
        Console.WriteLine("La fecha construida Final es  = " & diassumados.AddDays(numerodedias))
        Dim lafecha As New DateTime(diassumados.Year, diassumados.Month, diassumados.Day)
        Dim mostrar As numeracionsemanas
        mostrar = diassumados.DayOfWeek
        Console.WriteLine("EL COMPORTAMIENTO DEL DIA DE LA FECHA FINAL =" & vbCrLf & "Domingo = 0" &
                          vbCrLf & "Lunes = 1" & vbCrLf & "Martes = 2" & vbCrLf & "Miercoles = 3" & vbCrLf &
                          "Jueves = 4" & vbCrLf & "Viernes = 5" & vbCrLf & "Sabado = 6" & vbCrLf &
                          "EL NUMERO DE LA FECHA FINAL ES = " & mostrar & vbCrLf &
                          "EL DIA DE LA FECHA ES: " & mostrar.ToString)
    End Sub
End Module
