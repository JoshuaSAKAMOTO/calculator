Public Class Form1

    ' 入力表示（文字列で保持）
    Private currentInput As String = "0"

    ' 計算用
    Private firstValue As Double = 0
    Private currentOperator As String = ""
    Private isNewInput As Boolean = False

    ' 数字ボタン（0-9）
    Private Sub btnNumber_Click(sender As Object, e As EventArgs) Handles _
    btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click,
    btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click

        Dim btn As Button = CType(sender, Button)
        Dim number As String = btn.Text

        If isNewInput OrElse currentInput = "0" Then
            currentInput = number
            isNewInput = False
        Else
            currentInput &= number
        End If

        txtDisplay.Text = currentInput
    End Sub


    ' クリア
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        currentInput = "0"
        firstValue = 0
        currentOperator = ""
        txtDisplay.Text = currentInput
        lblExpression.Text = ""
    End Sub

    ' 演算子（＋ − × ÷）共通
    Private Sub btnOperator_Click(sender As Object, e As EventArgs) Handles _
    btnAdd.Click, btnSub.Click, btnMul.Click, btnDiv.Click

        firstValue = Double.Parse(currentInput)

        Dim btn As Button = CType(sender, Button)
        currentOperator = btn.Text   ' "+", "-", "*", "/"

        ' ★ txtDisplay は変えない（0にしない）
        UpdateExpression()

        ' 次に数字を入力したら上書きしたい場合はフラグ方式が必要
        isNewInput = True
    End Sub


    ' ＝
    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        Dim secondValue As Double = Double.Parse(currentInput)
        Dim result As Double

        Select Case currentOperator
            Case "+"
                result = firstValue + secondValue
            Case "-"
                result = firstValue - secondValue
            Case "×", "*"
                result = firstValue * secondValue
            Case "÷", "/"
                If secondValue = 0 Then
                    MessageBox.Show("0で割れません")
                    Return
                End If
                result = firstValue / secondValue
            Case Else
                ' 演算子未選択なら何もしない（または表示維持）
                result = secondValue
        End Select

        currentInput = result.ToString()
        txtDisplay.Text = currentInput

        ' 連続計算
        firstValue = result
        lblExpression.Text = ""
        isNewInput = True
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        If isNewInput Then
            currentInput = "0"
            isNewInput = False
        End If

        If currentInput.Contains(".") Then Return

        If currentInput = "0" Then
            currentInput = "0."
        Else
            currentInput &= "."
        End If

        txtDisplay.Text = currentInput
    End Sub


    Private Sub UpdateExpressionDisplay(Optional showSecond As Boolean = False)
        If currentOperator = "" Then
            lblExpression.Text = ""
            Return
        End If

        If showSecond Then
            lblExpression.Text = $"{firstValue} {currentOperator} {currentInput}"
        Else
            lblExpression.Text = $"{firstValue} {currentOperator}"
        End If
    End Sub

    Private Sub UpdateExpression()
        If currentOperator = "" Then
            lblExpression.Text = ""
        Else
            lblExpression.Text = $"{firstValue} {currentOperator}"
        End If
    End Sub


End Class
