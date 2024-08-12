Public Class Form1

    Private currentNumber As String = ""

    Private firstNumber As Double
    Private operation As String

    ' Botões numéricos
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        currentNumber &= "0"
        txtDisplay.Text = currentNumber
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        currentNumber &= "1"
        txtDisplay.Text = currentNumber
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        currentNumber &= "2"
        txtDisplay.Text = currentNumber
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        currentNumber &= "3"
        txtDisplay.Text = currentNumber
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        currentNumber &= "4"
        txtDisplay.Text = currentNumber
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        currentNumber &= "5"
        txtDisplay.Text = currentNumber
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        currentNumber &= "6"
        txtDisplay.Text = currentNumber
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        currentNumber &= "7"
        txtDisplay.Text = currentNumber
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        currentNumber &= "8"
        txtDisplay.Text = currentNumber
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        currentNumber &= "9"
        txtDisplay.Text = currentNumber
    End Sub

    Private Sub btnVirgula_Click(sender As Object, e As EventArgs) Handles btnVirgula.Click
        ' Evita múltiplas vírgulas no número atual
        If Not currentNumber.Contains(",") Then
            currentNumber &= ","
            txtDisplay.Text = currentNumber
        End If
    End Sub

    ' Operações
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        firstNumber = Double.Parse(currentNumber)
        operation = "+"
        currentNumber = ""
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        firstNumber = Double.Parse(currentNumber)
        operation = "-"
        currentNumber = ""
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        firstNumber = Double.Parse(currentNumber)
        operation = "*"
        currentNumber = ""
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        firstNumber = Double.Parse(currentNumber)
        operation = "/"
        currentNumber = ""
    End Sub

    Private Sub btnDouble_Click(sender As Object, e As EventArgs) Handles btnDouble.Click
        firstNumber = Double.Parse(currentNumber)
        operation = "^"
        currentNumber = ""
    End Sub

    Private Sub btnDel1_Click(sender As Object, e As EventArgs) Handles btnDel1.Click
        currentNumber = ""
        txtDisplay.Text = currentNumber
    End Sub

    ' Botão igual para calcular o resultado
    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        Dim secondNumber As Double = Double.Parse(currentNumber)
        Dim result As Double

        Select Case operation
            Case "+"
                result = firstNumber + secondNumber
            Case "-"
                result = firstNumber - secondNumber
            Case "*"
                result = firstNumber * secondNumber
            Case "/"
                result = firstNumber / secondNumber
            Case "^"
                result = firstNumber ^ secondNumber
        End Select

        txtDisplay.Text = result.ToString()
        currentNumber = result.ToString()
    End Sub

End Class
