Module _08concatenacion
    Sub Main()
        Dim empresa As String
        Dim calle As String
        Dim altura As Char
        Dim fIncioAct As String
        Console.WriteLine("ingrese empresa")
        empresa = Console.ReadLine()
        Console.WriteLine("ingrese calle")
        calle = Console.ReadLine()
        Console.WriteLine("ingrese altura")
        altura = Console.ReadLine()
        Console.WriteLine("ingrese fecha de inicio de actividades")
        fIncioAct = Console.ReadLine()
        Console.WriteLine("-------------------------------------")
        Console.Write("Empresa:" + empresa + vbCrLf + "Calle:" + calle & vbCrLf + "Altura:" + altura & vbCrLf & "Fecha de Inicio de Actividades: " & fIncioAct & vbCrLf)
        altura = Convert.ToString(altura)
        Console.WriteLine("-------------------------------------")
        Console.Write("Empresa:" & empresa & vbCrLf & "Calle:" & calle & vbCrLf & "Altura:" & altura & vbCrLf & "Fecha de Inicio de Actividades: " & fIncioAct & vbCrLf)
    End Sub

End Module
