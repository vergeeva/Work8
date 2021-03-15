Public Class Form1
    Dim Numbr As ConvertNumber
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Value As Integer
        If TextBox1.Text <> "" Then
            Value = Convert.ToInt32(TextBox1.Text)
            If Value > 0 And Value <= 3999 Then
                Numbr = New ConvertNumber(Value)
                TextBox2.Text = Numbr.ConvertToRoman()
            Else MessageBox.Show("Число выходит за пределы диапазона от 1 до 3999", "Сообщение об ошибке")
            End If
        Else
            MessageBox.Show("Вы не ввели число", "Сообщение об ошибке")
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not (Char.IsControl(e.KeyChar)) And Not (Char.IsDigit(e.KeyChar)) And (e.KeyChar <> ".") Then
            e.Handled = True
        End If
    End Sub
End Class
