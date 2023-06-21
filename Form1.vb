'TODO: Deal with trailing spaces

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Evaluate()

        'Clear last result
        ResultTextBox.Text = ""

        'Takes the string in the expression box and gives back an array with
        'all of the operands and operators.
        Dim expression As String = ExpressionTextBox.Text
        Dim ArrExpression As String()
        ArrExpression = Split(expression, " ")

        Dim stk As Stack = New Stack()

        For index = 0 To ArrExpression.Length - 1
            If IsOperator(ArrExpression(index)) Then
                Dim right As Double = stk.Pop()
                Dim left As Double = stk.Pop()
                Dim result As Double = calculate(ArrExpression(index), right, left)
                stk.Push(result)
            Else
                stk.Push(ArrExpression(index))
            End If
        Next

        'Whatever is left in the stack should be the result
        'Should not have more than
        If stk.Count > 1 Then
            ResultTextBox.Text = "0.0"
        Else
            ResultTextBox.Text = stk.Pop()
        End If

    End Sub

    Private Function IsOperator(myOperator) As Boolean
        If myOperator = "*" Or myOperator = "/" Or myOperator = "+" Or myOperator = "-" Or myOperator = "^" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function calculate(myOperator, right, left) As Double
        If myOperator = "*" Then
            Return left * right
        ElseIf myOperator = "/" Then
            Return left / right
        ElseIf myOperator = "+" Then
            Return left + right
        ElseIf myOperator = "-" Then
            Return left - right
        ElseIf myOperator = "^" Then
            Return left ^ right
        Else
            Return 0.0
        End If
    End Function

    ''''
    ''All of the button press code.
    ''''
    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        ExpressionTextBox.SelectedText = "0"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ExpressionTextBox.SelectedText = "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ExpressionTextBox.SelectedText = "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ExpressionTextBox.SelectedText = "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ExpressionTextBox.SelectedText = "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ExpressionTextBox.SelectedText = "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ExpressionTextBox.SelectedText = "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ExpressionTextBox.SelectedText = "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ExpressionTextBox.SelectedText = "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ExpressionTextBox.SelectedText = "9"
    End Sub

    Private Sub Button_divide_Click(sender As Object, e As EventArgs) Handles Button_divide.Click
        ExpressionTextBox.SelectedText = "/"
    End Sub

    Private Sub Button_times_Click(sender As Object, e As EventArgs) Handles Button_times.Click
        ExpressionTextBox.SelectedText = "*"
    End Sub

    Private Sub Button_subtract_Click(sender As Object, e As EventArgs) Handles Button_subtract.Click
        ExpressionTextBox.SelectedText = "-"
    End Sub

    Private Sub Button_plus_Click(sender As Object, e As EventArgs) Handles Button_plus.Click
        ExpressionTextBox.SelectedText = "+"
    End Sub

    Private Sub Button_space_Click(sender As Object, e As EventArgs) Handles Button_space.Click
        ExpressionTextBox.SelectedText = " "
    End Sub

    Private Sub Button_equals_Click(sender As Object, e As EventArgs) Handles Button_equals.Click
        Evaluate()
    End Sub

    Private Sub Button_exponent_Click(sender As Object, e As EventArgs) Handles Button_exponent.Click
        ExpressionTextBox.SelectedText = "^"
    End Sub

    Private Sub Button_clear_Click(sender As Object, e As EventArgs) Handles Button_clear.Click
        ExpressionTextBox.Text = ""
        ResultTextBox.Text = ""
    End Sub

    Private Sub Button_period_Click(sender As Object, e As EventArgs) Handles Button_period.Click
        ExpressionTextBox.SelectedText = "."
    End Sub

    Private Sub Button_convert_Click(sender As Object, e As EventArgs) Handles Button_convert.Click
        Me.Hide()
        Dim myForm As New Form2
        myForm.ShowDialog()
        Me.Show()
    End Sub
End Class
