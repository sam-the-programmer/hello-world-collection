Module Program
    Public Function fib(ByVal n As Integer) As Integer

        If n <= 2 Then
            Return 1
        Else
            Return fib(n - 1) + fib(n - 2)
        End If

    End Function

    Sub Main()
        Dim StartTime As DateTime = Now

        For i As Integer = 1 To 40
            fib(i)
        Next i

        Dim EndTime As DateTime = Now
        Dim TimeDiff As TimeSpan = EndTime.Subtract(StartTime)
        Dim TotalSeconds As Integer = TimeDiff.TotalSeconds

        Console.WriteLine(TotalSeconds)
    End Sub
End Module