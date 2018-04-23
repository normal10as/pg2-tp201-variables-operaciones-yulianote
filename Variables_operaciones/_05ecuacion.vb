Module _05ecuacion
    Sub Main()
        Const a As Byte = 1
        Const b As Byte = 5
        Const c As Byte = 2
        Dim x As Single
        x = (b ^ 2 - 4 * a * c) / (2 * a)
        Console.WriteLine("a=1 b=5 c=2 " & vbCrLf & "x=(b^2-4*a*c)/(2*a) = " & x)
    End Sub
End Module
