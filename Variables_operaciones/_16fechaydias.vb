Module _16fechaydias
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
    End Sub
End Module
