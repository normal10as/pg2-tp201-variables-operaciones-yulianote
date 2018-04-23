Module _07semanas
    Sub Main()
        Const diasdesemana As Byte = 7
        Const diasdelano As UInteger = 365
        Const diaslaborales As Byte = 5
        Dim diaslaboralesdelano As UInteger
        Dim semanasdelano As Byte
        diaslaboralesdelano = (diasdelano / diasdesemana) * diaslaborales
        semanasdelano = diasdelano / diasdesemana
        diaslaboralesdelano = diaslaboralesdelano / 7
        Console.WriteLine("Semanas del año = " & semanasdelano)
        Console.WriteLine("Semanas laborales = " & diaslaboralesdelano)
    End Sub
End Module
