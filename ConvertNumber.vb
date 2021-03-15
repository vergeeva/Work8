Public Class ConvertNumber
    Private Number As Integer
    Private ReadOnly Arabian() As Integer = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1}
    Private ReadOnly Roman() As String = {"M", "CM", "D", "CD", "С", "ХС", "L", "XL", "X", "IX", "V", "IV", "I"}

    Public Sub New(Number As Integer)
        If CheckNumber(Number) Then
            Me.Number = Number
        Else Me.Number = 1
        End If
    End Sub
    Public Property Numbr() As Integer
        Get
            Return Number
        End Get
        Set(value As Integer)
            If CheckNumber(value) Then
                Number = value
            End If
        End Set
    End Property

    Private Function CheckNumber(Number As Integer) As Boolean
        Return Number > 0 And Number <= 3999
    End Function

    Public Function ConvertToRoman() As String
        Dim result As String = ""
        While Number > 0
            For index = 0 To Arabian.Count - 1
                If Arabian(index) <= Number Then
                    While Arabian(index) <= Number
                        result += Roman(index)
                        Number -= Arabian(index)
                    End While
                End If
            Next
        End While
        Return result
    End Function
End Class
