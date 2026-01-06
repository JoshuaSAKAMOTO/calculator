<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtDisplay = New TextBox()
        btnClear = New Button()
        btnDiv = New Button()
        btnMul = New Button()
        btnDelete = New Button()
        btn7 = New Button()
        btn8 = New Button()
        btn9 = New Button()
        btnSub = New Button()
        btn4 = New Button()
        btn5 = New Button()
        btn6 = New Button()
        btnAdd = New Button()
        btn1 = New Button()
        btn2 = New Button()
        btn3 = New Button()
        btnEqual = New Button()
        btnSign = New Button()
        btn0 = New Button()
        btnDot = New Button()
        lblExpression = New Label()
        SuspendLayout()
        ' 
        ' txtDisplay
        ' 
        txtDisplay.Font = New Font("Yu Gothic UI", 18F)
        txtDisplay.Location = New Point(12, 47)
        txtDisplay.Margin = New Padding(3, 4, 3, 4)
        txtDisplay.Name = "txtDisplay"
        txtDisplay.ReadOnly = True
        txtDisplay.Size = New Size(326, 39)
        txtDisplay.TabIndex = 0
        txtDisplay.TextAlign = HorizontalAlignment.Right
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(12, 114)
        btnClear.Margin = New Padding(3, 4, 3, 4)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(69, 56)
        btnClear.TabIndex = 1
        btnClear.Text = "C"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnDiv
        ' 
        btnDiv.Font = New Font("Yu Gothic UI", 18F)
        btnDiv.Location = New Point(96, 114)
        btnDiv.Margin = New Padding(3, 4, 3, 4)
        btnDiv.Name = "btnDiv"
        btnDiv.Size = New Size(69, 56)
        btnDiv.TabIndex = 2
        btnDiv.Text = "÷"
        btnDiv.UseVisualStyleBackColor = True
        ' 
        ' btnMul
        ' 
        btnMul.Font = New Font("Yu Gothic UI", 18F)
        btnMul.Location = New Point(184, 114)
        btnMul.Margin = New Padding(3, 4, 3, 4)
        btnMul.Name = "btnMul"
        btnMul.Size = New Size(69, 56)
        btnMul.TabIndex = 3
        btnMul.Text = "×"
        btnMul.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(269, 114)
        btnDelete.Margin = New Padding(3, 4, 3, 4)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(69, 56)
        btnDelete.TabIndex = 4
        btnDelete.Text = "delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btn7
        ' 
        btn7.Location = New Point(12, 177)
        btn7.Margin = New Padding(3, 4, 3, 4)
        btn7.Name = "btn7"
        btn7.Size = New Size(69, 56)
        btn7.TabIndex = 5
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.Location = New Point(96, 177)
        btn8.Margin = New Padding(3, 4, 3, 4)
        btn8.Name = "btn8"
        btn8.Size = New Size(69, 56)
        btn8.TabIndex = 6
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = True
        ' 
        ' btn9
        ' 
        btn9.Location = New Point(184, 177)
        btn9.Margin = New Padding(3, 4, 3, 4)
        btn9.Name = "btn9"
        btn9.Size = New Size(69, 56)
        btn9.TabIndex = 7
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = True
        ' 
        ' btnSub
        ' 
        btnSub.Font = New Font("Yu Gothic UI", 18F)
        btnSub.Location = New Point(269, 177)
        btnSub.Margin = New Padding(3, 4, 3, 4)
        btnSub.Name = "btnSub"
        btnSub.Size = New Size(69, 56)
        btnSub.TabIndex = 8
        btnSub.Text = "-"
        btnSub.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Location = New Point(12, 240)
        btn4.Margin = New Padding(3, 4, 3, 4)
        btn4.Name = "btn4"
        btn4.Size = New Size(69, 56)
        btn4.TabIndex = 9
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.Location = New Point(96, 240)
        btn5.Margin = New Padding(3, 4, 3, 4)
        btn5.Name = "btn5"
        btn5.Size = New Size(69, 56)
        btn5.TabIndex = 10
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn6
        ' 
        btn6.Location = New Point(184, 240)
        btn6.Margin = New Padding(3, 4, 3, 4)
        btn6.Name = "btn6"
        btn6.Size = New Size(69, 56)
        btn6.TabIndex = 11
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Yu Gothic UI", 18F)
        btnAdd.Location = New Point(269, 240)
        btnAdd.Margin = New Padding(3, 4, 3, 4)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(69, 56)
        btnAdd.TabIndex = 12
        btnAdd.Text = "+"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btn1
        ' 
        btn1.Location = New Point(12, 304)
        btn1.Margin = New Padding(3, 4, 3, 4)
        btn1.Name = "btn1"
        btn1.Size = New Size(69, 56)
        btn1.TabIndex = 13
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Location = New Point(96, 304)
        btn2.Margin = New Padding(3, 4, 3, 4)
        btn2.Name = "btn2"
        btn2.Size = New Size(69, 56)
        btn2.TabIndex = 14
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn3
        ' 
        btn3.Location = New Point(184, 304)
        btn3.Margin = New Padding(3, 4, 3, 4)
        btn3.Name = "btn3"
        btn3.Size = New Size(69, 56)
        btn3.TabIndex = 15
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btnEqual
        ' 
        btnEqual.Location = New Point(269, 304)
        btnEqual.Margin = New Padding(3, 4, 3, 4)
        btnEqual.Name = "btnEqual"
        btnEqual.Size = New Size(69, 120)
        btnEqual.TabIndex = 16
        btnEqual.Text = "="
        btnEqual.UseVisualStyleBackColor = True
        ' 
        ' btnSign
        ' 
        btnSign.Location = New Point(12, 367)
        btnSign.Margin = New Padding(3, 4, 3, 4)
        btnSign.Name = "btnSign"
        btnSign.Size = New Size(69, 56)
        btnSign.TabIndex = 17
        btnSign.Text = "+/-"
        btnSign.UseVisualStyleBackColor = True
        ' 
        ' btn0
        ' 
        btn0.Location = New Point(96, 367)
        btn0.Margin = New Padding(3, 4, 3, 4)
        btn0.Name = "btn0"
        btn0.Size = New Size(69, 56)
        btn0.TabIndex = 18
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = True
        ' 
        ' btnDot
        ' 
        btnDot.Location = New Point(184, 367)
        btnDot.Margin = New Padding(3, 4, 3, 4)
        btnDot.Name = "btnDot"
        btnDot.Size = New Size(69, 56)
        btnDot.TabIndex = 19
        btnDot.Text = "."
        btnDot.UseVisualStyleBackColor = True
        ' 
        ' lblExpression
        ' 
        lblExpression.Location = New Point(289, 24)
        lblExpression.Name = "lblExpression"
        lblExpression.Size = New Size(41, 15)
        lblExpression.TabIndex = 20
        lblExpression.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(350, 604)
        Controls.Add(lblExpression)
        Controls.Add(btnDot)
        Controls.Add(btn0)
        Controls.Add(btnSign)
        Controls.Add(btnEqual)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Controls.Add(btnAdd)
        Controls.Add(btn6)
        Controls.Add(btn5)
        Controls.Add(btn4)
        Controls.Add(btnSub)
        Controls.Add(btn9)
        Controls.Add(btn8)
        Controls.Add(btn7)
        Controls.Add(btnDelete)
        Controls.Add(btnMul)
        Controls.Add(btnDiv)
        Controls.Add(btnClear)
        Controls.Add(txtDisplay)
        Font = New Font("Yu Gothic UI", 10F)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnMul As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btnSub As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btnEqual As Button
    Friend WithEvents btnSign As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnDot As Button
    Friend WithEvents lblExpression As Label

End Class
