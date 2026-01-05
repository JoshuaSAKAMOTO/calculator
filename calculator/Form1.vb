Public Class Form1

    ' 現在表示している文字
    Private currentInput As String = "0"
    Private firstValue As Double = 0
    Private currentOperator As String = ""
    Private Sub btnNumber_Click(sender As Object, e As EventArgs) Handles _
        btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click,
        btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click

        Dim btn As Button = CType(sender, Button)
        Dim number As String = btn.Text

        If currentInput = "0" Then
            currentInput = number
        Else
            currentInput &= number
        End If

        txtDisplay.Text = currentInput
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        currentInput = "0"
        txtDisplay.Text = currentInput
    End Sub

    Private Sub btnOperator_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        firstValue = Double.Parse(currentInput)
        currentOperator = "+"
        currentInput = "0"
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        Dim secondValue As Double = Double.Parse(currentInput)
        Dim result As Double = 0

        If currentOperator = "+" Then
            result = firstValue + secondValue
        End If

        currentInput = result.ToString()
        txtDisplay.Text = currentInput

        ' 連続計算できるように「結果を次のfirstValueにする」
        firstValue = result
    End Sub
End Class
