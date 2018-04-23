Module _13elmayor
    Sub Main()
        Dim primer As UInt32
        Dim segundo As UInt32
        Dim tercer As UInt32
        Dim mayor As UInt32
        Console.WriteLine("INGRESE EL PRIMER NUMERO = ")
        primer = Console.ReadLine()
        Console.WriteLine("INGRESE EL SEGUNDO NUMERO = ")
        segundo = Console.ReadLine()
        Console.WriteLine("INGRESE EL TERCER NUMERO = ")
        tercer = Console.ReadLine()
        mayor = Math.Max(primer, segundo)
        mayor = Math.Max(mayor, tercer)
        Console.WriteLine(vbCrLf & "El mayor es el TERCERO numero ingresado = " & mayor & vbCrLf)
    End Sub
End Module
