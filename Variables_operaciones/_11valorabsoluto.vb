Module _11valorabsoluto
    Sub Main()
        Dim x As Integer
        Dim c As Long
        Dim h As UInteger
        Console.WriteLine("Ingrese un numero x = ")
        x = Console.ReadLine()
        x = Math.Abs(x)
        Console.WriteLine("El valor absoluto de el numero es = " & x)
        c = x ^ 10
        Console.WriteLine("si elevamos x ah la decima potencia es = " & c)
        h = c ^ 1 / 2
        Console.WriteLine("la raiz cuadrada del resultado de decima potencia es = " & h)
    End Sub
End Module
