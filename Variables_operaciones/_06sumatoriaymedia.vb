Module _06sumatoriaymedia
    Sub Main()
        Dim A As Integer
        Dim B As Integer
        Dim C As Integer
        Dim D As Integer
        Dim media As Single
        Dim sumatoria As Integer
        Console.WriteLine("Ingrese un Nro")
        A = Console.ReadLine()
        Console.WriteLine("Ingrese otro Nro")
        B = Console.ReadLine()
        Console.WriteLine("Ingrese otro Nro")
        C = Console.ReadLine()
        Console.WriteLine("Ingrese otro Nro")
        D = Console.ReadLine()
        sumatoria = (A + B + C + D)
        media = sumatoria / 4
        Console.WriteLine("La sumatoria de los nros ingresados = " & sumatoria)
        Console.WriteLine("La media de los nros ingresados es = " & media)

    End Sub
End Module
