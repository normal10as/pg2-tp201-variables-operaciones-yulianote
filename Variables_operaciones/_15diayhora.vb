Module _15diayhora
    Sub Main()
        Dim dia As Byte
        Dim hs As Byte
        Dim hoy As Date
        Console.WriteLine("INGRESE UN DIA DEL 1 HASTA 31 =")
        dia = Console.ReadLine()
        Console.WriteLine("INGRESE UN HORA DE 0 HASTA 24 =")
        hs = Console.ReadLine()
        hoy = Now
        Console.WriteLine(vbCrLf & "Fecha y hora del ordenador" & hoy & vbCrLf)
        Console.WriteLine(vbCrLf & "Fecha ingresada =" & dia & "/" & hoy.Month & "/" & hoy.Year)
        Console.WriteLine("Horas ingresadas " & hs & ":" & hoy.Minute & ":" & hoy.Second & vbCrLf)
    End Sub
End Module
