Module Utils
    Public Function RandomNumber(Min As Integer, Max As Integer) As Integer
        Randomize()
        Return (Max - Min) * Rnd() + Min
    End Function

    Public Function RandomNumber(Min As Double, Max As Double) As Double
        Randomize()
        Return (Max - Min) * Rnd() + Min
    End Function

    Public Function RandomNumber(Min As Double, Max As Double, Precision As Integer) As Double
        Randomize()
        Return Math.Round((Max - Min) * Rnd() + Min, Precision)
    End Function

    Public Function LinearInterpolate(
        x1 As Double,
        y1 As Double,
        x2 As Double,
        y2 As Double,
        x As Double
    ) As Double
        Return y2 + ((x - x1) * (y2 - y1)) / (x2 - x1)
    End Function
End Module
