Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function precedence(myOperator) As Integer
        If myOperator = "+" Or myOperator = "-" Then
            Return 1
        ElseIf myOperator = "*" Or myOperator = "/" Then
            Return 2
        Else
            Return 3
        End If
    End Function

    Private Function IsOperator(myOperator) As Boolean
        If myOperator = "*" Or myOperator = "/" Or myOperator = "+" Or myOperator = "-" Or myOperator = "^" Or myOperator = "(" Or myOperator = ")" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Evaluate()

        'Clear last result
        ResultTextBox.Text = ""

        'Takes the string in the expression box and gives back an array with
        'all of the operands and operators.
        Dim expression As String = Trim(ExpressionTextBox.Text)
        Dim ArrExpression As String()
        ArrExpression = Split(expression, " ")

        Dim stk As Stack = New Stack()

        For index = 0 To ArrExpression.Length - 1
            'Push all operands that we encounter
            If Not IsOperator(ArrExpression(index)) Then
                ResultTextBox.Text += ArrExpression(index)
                ResultTextBox.Text += " "

                'Handle opening parenthesis
            ElseIf ArrExpression(index) = "(" Then
                stk.Push(ArrExpression(index))

                'Handle closing parenthesis
            ElseIf ArrExpression(index) = ")" Then
                While stk.Count > 0 And stk.Peek() <> "("
                    ResultTextBox.Text += stk.Pop()
                    ResultTextBox.Text += " "
                End While
                If stk.Count > 0 And stk.Peek() <> "(" Then
                    'panic
                Else
                    stk.Pop()
                End If

                'Handle operators
            Else
                While stk.Count > 0 AndAlso stk.Peek() <> "(" AndAlso precedence(ArrExpression(index)) < precedence(stk.Peek())
                    ResultTextBox.Text += stk.Pop()
                    ResultTextBox.Text += " "
                End While
                stk.Push(ArrExpression(index))

            End If
        Next

        While stk.Count > 0
            ResultTextBox.Text += stk.Pop()
            ResultTextBox.Text += " "
        End While

        ResultTextBox.Text = Trim(ResultTextBox.Text)

    End Sub

    Private Sub Button_close_Click(sender As Object, e As EventArgs) Handles Button_close.Click
        Me.Close()
    End Sub

    Private Sub Button_convert_Click(sender As Object, e As EventArgs) Handles Button_convert.Click
        Evaluate()
    End Sub
End Class