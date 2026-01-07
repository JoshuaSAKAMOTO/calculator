Public Class Form1

    ' 入力表示（文字列で保持）
    Private currentInput As String = "0"

    ' 計算用
    Private firstValue As Double = 0
    Private currentOperator As String = ""
    Private isNewInput As Boolean = False

    ' 連続計算用（=を繰り返し押す用）
    Private lastOperator As String = ""
    Private lastValue As Double = 0

    ' 計算式の履歴
    Private expressionHistory As String = ""

    ' 桁数制限
    Private Const MAX_DIGITS As Integer = 10

    ' ダークモード
    Private isDarkMode As Boolean = False

    ' 桁数をカウント（小数点・マイナス符号を除く）
    Private Function GetDigitCount(input As String) As Integer
        Return input.Replace("-", "").Replace(".", "").Length
    End Function

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
            ' 桁数制限チェック
            If GetDigitCount(currentInput) >= MAX_DIGITS Then Return
            currentInput &= number
        End If

        txtDisplay.Text = currentInput
    End Sub


    ' クリア
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        currentInput = "0"
        firstValue = 0
        currentOperator = ""
        lastOperator = ""
        lastValue = 0
        expressionHistory = ""
        txtDisplay.Text = currentInput
        lblExpression.Text = ""
    End Sub

    ' 演算子（＋ − × ÷）共通
    Private Sub btnOperator_Click(sender As Object, e As EventArgs) Handles _
    btnAdd.Click, btnSub.Click, btnMul.Click, btnDiv.Click

        Dim btn As Button = CType(sender, Button)

        ' 前の演算子があり、新しい数値が入力されている場合は先に計算
        If currentOperator <> "" AndAlso Not isNewInput Then
            ' 計算式の履歴に追加してから計算
            expressionHistory &= $"{currentInput} {btn.Text} "
            CalculateResult()
        Else
            ' 最初の数値と演算子を履歴に追加
            expressionHistory = $"{currentInput} {btn.Text} "
        End If

        firstValue = Double.Parse(currentInput)
        currentOperator = btn.Text   ' "+", "-", "*", "/"

        ' 履歴を表示
        lblExpression.Text = expressionHistory

        ' 次に数字を入力したら上書きしたい場合はフラグ方式が必要
        isNewInput = True
    End Sub


    ' ＝
    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        Dim secondValue As Double
        Dim operatorToUse As String
        Dim firstVal As Double

        ' 演算子が空の場合（=を連続で押した場合）は、保存した演算子と値を使用
        If currentOperator = "" AndAlso lastOperator <> "" Then
            operatorToUse = lastOperator
            secondValue = lastValue
            firstVal = Double.Parse(currentInput)
        Else
            operatorToUse = currentOperator
            secondValue = Double.Parse(currentInput)
            firstVal = firstValue
        End If

        Dim result As Double

        Select Case operatorToUse
            Case "+"
                result = firstVal + secondValue
            Case "-"
                result = firstVal - secondValue
            Case "×", "*"
                result = firstVal * secondValue
            Case "÷", "/"
                If secondValue = 0 Then
                    MessageBox.Show("0で割れません")
                    Return
                End If
                result = firstVal / secondValue
            Case Else
                ' 演算子未選択なら何もしない（または表示維持）
                result = secondValue
        End Select

        currentInput = result.ToString()
        txtDisplay.Text = currentInput

        ' 計算式を完全な形で表示
        Dim fullExpression As String
        If expressionHistory <> "" Then
            ' 連続演算の場合
            fullExpression = expressionHistory & $"{secondValue} ="
        Else
            ' 通常の計算
            fullExpression = $"{firstVal} {operatorToUse} {secondValue} ="
        End If
        lblExpression.Text = fullExpression

        ' 履歴に追加（最新が上）
        lstHistory.Items.Insert(0, fullExpression & $" {result}")

        ' 計算式の履歴をリセット
        expressionHistory = ""

        ' 連続計算用に保存
        lastOperator = operatorToUse
        lastValue = secondValue

        ' 連続計算
        firstValue = result
        currentOperator = ""
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

    ' 計算を実行（連続演算用）
    Private Sub CalculateResult()
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
                Return
        End Select

        currentInput = result.ToString()
        txtDisplay.Text = currentInput
    End Sub

    ' 符号反転 (+/-)
    Private Sub btnSign_Click(sender As Object, e As EventArgs) Handles btnSign.Click
        If currentInput = "0" Then Return

        If currentInput.StartsWith("-") Then
            currentInput = currentInput.Substring(1)
        Else
            currentInput = "-" & currentInput
        End If

        txtDisplay.Text = currentInput
    End Sub

    ' 1文字削除 (delete)
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If isNewInput Then Return

        If currentInput.Length = 1 OrElse (currentInput.Length = 2 AndAlso currentInput.StartsWith("-")) Then
            currentInput = "0"
        Else
            currentInput = currentInput.Substring(0, currentInput.Length - 1)
        End If

        txtDisplay.Text = currentInput
    End Sub

    ' 履歴から再利用
    Private Sub lstHistory_Click(sender As Object, e As EventArgs) Handles lstHistory.Click
        If lstHistory.SelectedItem Is Nothing Then Return

        ' 履歴の形式: "5 + 3 = 8" → 結果(8)を取得
        Dim historyText As String = lstHistory.SelectedItem.ToString()
        Dim parts() As String = historyText.Split("="c)

        If parts.Length >= 2 Then
            Dim resultText As String = parts(1).Trim()
            currentInput = resultText
            txtDisplay.Text = currentInput
            isNewInput = True
        End If
    End Sub

    ' キーボード入力
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Select Case e.KeyChar
            Case "0"c : btn0.PerformClick()
            Case "1"c : btn1.PerformClick()
            Case "2"c : btn2.PerformClick()
            Case "3"c : btn3.PerformClick()
            Case "4"c : btn4.PerformClick()
            Case "5"c : btn5.PerformClick()
            Case "6"c : btn6.PerformClick()
            Case "7"c : btn7.PerformClick()
            Case "8"c : btn8.PerformClick()
            Case "9"c : btn9.PerformClick()
            Case "+"c : btnAdd.PerformClick()
            Case "-"c : btnSub.PerformClick()
            Case "*"c : btnMul.PerformClick()
            Case "/"c : btnDiv.PerformClick()
            Case "."c : btnDot.PerformClick()
            Case "="c, ChrW(13) : btnEqual.PerformClick()  ' Enter
            Case ChrW(27) : btnClear.PerformClick()        ' Escape
            Case ChrW(8) : btnDelete.PerformClick()        ' Backspace
            Case "c"c, "C"c : btnClear.PerformClick()
        End Select
    End Sub

    ' 常に最前面表示の切り替え
    Private Sub btnTopMost_Click(sender As Object, e As EventArgs) Handles btnTopMost.Click
        Me.TopMost = Not Me.TopMost
        btnTopMost.Text = If(Me.TopMost, "📌", "📍")
    End Sub

    ' ダークモードの切り替え
    Private Sub btnDarkMode_Click(sender As Object, e As EventArgs) Handles btnDarkMode.Click
        isDarkMode = Not isDarkMode
        ApplyTheme()
    End Sub

    ' テーマを適用
    Private Sub ApplyTheme()
        Dim backColor As Color
        Dim foreColor As Color
        Dim buttonBackColor As Color
        Dim displayBackColor As Color

        If isDarkMode Then
            backColor = Color.FromArgb(30, 30, 30)
            foreColor = Color.FromArgb(180, 180, 180)  ' グレー
            buttonBackColor = Color.FromArgb(40, 40, 40)
            displayBackColor = Color.FromArgb(35, 35, 35)
            btnDarkMode.Text = "☀"
        Else
            backColor = SystemColors.Control
            foreColor = SystemColors.ControlText
            buttonBackColor = SystemColors.Control
            displayBackColor = SystemColors.Window
            btnDarkMode.Text = "🌙"
        End If

        ' フォーム
        Me.BackColor = backColor

        ' 表示エリア
        txtDisplay.BackColor = displayBackColor
        txtDisplay.ForeColor = foreColor
        If isDarkMode Then
            txtDisplay.BorderStyle = BorderStyle.FixedSingle
        Else
            txtDisplay.BorderStyle = BorderStyle.Fixed3D
        End If

        ' 計算式ラベル
        lblExpression.ForeColor = foreColor

        ' 履歴リスト
        lstHistory.BackColor = displayBackColor
        lstHistory.ForeColor = foreColor
        If isDarkMode Then
            lstHistory.BorderStyle = BorderStyle.FixedSingle
        Else
            lstHistory.BorderStyle = BorderStyle.Fixed3D
        End If

        ' 全ボタン
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = CType(ctrl, Button)
                btn.BackColor = buttonBackColor
                btn.ForeColor = foreColor
                If isDarkMode Then
                    btn.FlatStyle = FlatStyle.Flat
                    btn.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60)
                    btn.FlatAppearance.BorderSize = 1
                Else
                    btn.FlatStyle = FlatStyle.Standard
                End If
            End If
        Next
    End Sub

    ' クリップボードにコピー
    Private Async Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        If String.IsNullOrEmpty(txtDisplay.Text) Then Return

        Clipboard.SetText(txtDisplay.Text)

        ' フィードバック表示
        btnCopy.Text = "✓"
        Await Task.Delay(500)
        btnCopy.Text = "📋"
    End Sub

End Class