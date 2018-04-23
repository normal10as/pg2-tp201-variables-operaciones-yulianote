Module _12exesoydefecto
    Sub Main()
        Dim x As Single
        Console.WriteLine("INGRESE UN VALOR :")
        x = Console.ReadLine()
        Console.WriteLine("El numero por exeso es = " & Math.Ceiling(x))
        Console.WriteLine("el numero de defecto es = " & Math.Floor(x))
        Console.WriteLine("El numero por redondeado es = " & Math.Round(x))
    End Sub
End Module
