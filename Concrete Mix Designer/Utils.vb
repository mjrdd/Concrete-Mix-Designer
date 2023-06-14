Module Utils
    Public Function Rand(min As Integer, max As Integer) As Integer
        Return (max * Rnd()) + min
    End Function

    Public Function Rand(min As Double, max As Double) As Double
        ' TODO: Dynamic number of decimals
        Return Math.Round(max * Rnd() + min, 3)
    End Function

    Public Function Interpolate(x1 As Double, y1 As Double, x2 As Double, y2 As Double, x As Double) As Double
        Return y2 + ((x - x1) * (y2 - y1)) / (x2 - x1)
    End Function
End Module
