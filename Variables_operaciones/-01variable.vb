Module _1variable
    Private Const iva As Single = 21
    Public nombre As String
    Friend fechadeNacimiento As Date
    Friend tipoDocumento As String
    Friend numeroDocumento As UInteger
    Private localidad As String
    Private alturaCorporal As Single
    Private estadoCivil As String
    Private argentino As String
    Sub Main()
        Dim edad As Byte
        nombre = "Yuliano Silva"
        tipoDocumento = " DNI "
        localidad = "Misiones"
        numeroDocumento = "35487075"
        fechadeNacimiento = "27/10/1992 "
        edad = "25 "
        alturaCorporal = "1,79"
        estadoCivil = "Solero"
        argentino = "Argentino"
        Console.WriteLine("Nombre : " & nombre)
        Console.WriteLine("Tipo de documento : " & tipoDocumento)
        Console.WriteLine("Numero de documento : " & numeroDocumento)
        Console.WriteLine("Localidad : " & localidad)
        Console.WriteLine("Fecha de nacimiento : " & fechadeNacimiento)
        Console.WriteLine("Edad : " & edad)
        Console.WriteLine("Altura : " & alturaCorporal)
        Console.WriteLine("Estado civil : " & estadoCivil)
        Console.WriteLine("Nacionalidad : " & argentino)
        Console.ReadKey()



    End Sub

End Module
