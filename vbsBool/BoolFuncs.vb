Public Class BoolFuncs
    Public Shared Function ToggleState(boolToChange)
        'Toggles the state of a boolean
        If boolToChange = True Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function StateToText(boolState As Boolean, trueString As String, falseString As String)
        'Takes a boolean and outputs text based on the state of the boolean
        If (boolState) Then
            Return trueString
        Else
            Return falseString
        End If
    End Function

    Public Shared Function RandomState(boolState As Boolean, divisor As Integer)
        'Sets a booleans state randomly: enter two for 50% change for true, 3 for 33% etc.
        Dim Rnd As New Random()
        If (Rnd.Next Mod divisor = 0) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
