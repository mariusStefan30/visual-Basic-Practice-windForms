Public Class Calculator
    'application load
    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome to Calculator.")
    End Sub
#Region "events"
    'add event
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'input validation
        If TextNum1.Text.Length <> 0 And TextNum2.Text.Length <> 0 Then
            Dim answer As Double = add(CType(TextNum1.Text, Double), CType(TextNum2.Text, Double))
            TextAnswer.Text = answer
        Else
            MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
    End Sub
    'substract event
    Private Sub btnSubstract_Click(sender As Object, e As EventArgs) Handles btnSubstract.Click
        'input validation
        If TextNum1.Text.Length <> 0 And TextNum2.Text.Length <> 0 Then
            Dim answer As Double = substract(CType(TextNum1.Text, Double), CType(TextNum2.Text, Double))
            TextAnswer.Text = answer
        Else
            MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
    End Sub
    'divide  
    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        'input validation
        If TextNum1.Text.Length <> 0 And TextNum2.Text.Length <> 0 Then
            Dim answer As Double = divide(CType(TextNum1.Text, Double), CType(TextNum2.Text, Double))
            TextAnswer.Text = answer
        Else
            MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
    End Sub

    Private Sub btnMultiplys_Click(sender As Object, e As EventArgs) Handles btnMultiplys.Click
        'input validation
        If TextNum1.Text.Length <> 0 And TextNum2.Text.Length <> 0 Then
            Dim answer As Double = multiply(CType(TextNum1.Text, Double), CType(TextNum2.Text, Double))
            TextAnswer.Text = answer
        Else
            MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
    End Sub

    Private Sub btnModulus_Click(sender As Object, e As EventArgs) Handles btnModulus.Click
        'input validation
        If TextNum1.Text.Length <> 0 And TextNum2.Text.Length <> 0 Then
            Dim answer As Double = modulus(CType(TextNum1.Text, Double), CType(TextNum2.Text, Double))
            TextAnswer.Text = answer
        Else
            MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
    End Sub

    Private Sub btnPI_Click(sender As Object, e As EventArgs) Handles btnPI.Click
        'Error handling
        Try
            Dim answer As Double = pI(CType(TextNum1.Text, Double), CType(TextNum2.Text, Double))
            TextAnswer.Text = answer.ToString()
        Catch ex As Exception
            MessageBox.Show("Sorry, Something went wrong.")
        End Try


    End Sub
    'Clear event
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextNum1.Clear()
        TextNum2.Clear()
        TextAnswer.Clear()
    End Sub

#End Region
    'add function
    Private Function add(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 + num2
    End Function
    'substract function
    Private Function substract(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 - num2
    End Function
    'divide function
    Private Function divide(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 / num2
    End Function
    'multiply function
    Private Function multiply(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 * num2
    End Function

    'modulus function
    Private Function modulus(ByVal num1 As Double, ByVal num2 As Double) As Integer
        Return num1 Mod num2
    End Function
    'PI function
    Private Function pI(ByVal num1 As Double, ByVal num2 As Double) As Double
        If num1 Then
            Return num1 * Math.PI
        ElseIf num2 Then
            Return num2 * Math.PI
        End If
    End Function

End Class