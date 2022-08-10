Imports System.ComponentModel
Imports System.Text


Partial Public Class btnCalculate
    Public Sub New()
        InitializeComponent()
    End Sub
    'declare three variables to avoid repetition
    Dim firstNum, secondNum, result As Double

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        'Dim firstNum, secondNum, result As Double
        Try
            If numberOne.Text <> "" And numberTwo.Text <> "" Then
                firstNum = CDbl(numberOne.Text)
                secondNum = CDbl(numberTwo.Text)

                result = firstNum + secondNum
                outputResults.Text = "The result of " & firstNum & "+" & secondNum & "=" & result
            Else
                MessageBox.Show("PLease enter both numbers")
            End If
        Catch ex As Exception
            MsgBox("Only numbers accepted" & vbCrLf & ex.Message)
            'Finally
            '    MsgBox("Something went wrong")
        End Try

        'change backColor of addBtn
        addBtn.Appearance.BackColor = Color.Brown
        substrBtn.Appearance.BackColor = Color.FromArgb(240, 240, 240)
        multiplyBtn.Appearance.BackColor = Color.FromArgb(240, 240, 240)
    End Sub

    Private Sub numberOne_EditValueChanged(sender As Object, e As EventArgs) Handles numberOne.EditValueChanged
        outputResults.Text = Nothing
    End Sub

    Private Sub numberTwo_EditValueChanged(sender As Object, e As EventArgs) Handles numberTwo.EditValueChanged
        outputResults.Text = Nothing
    End Sub
    'display bill button
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim labor, parts, total As Double
        Dim name As String
        'clear the lstDisplay
        lstDisplay.Items.Clear()
        'check if user input right data
        If IsNumeric(txtLabor.Text) And IsNumeric(txtParts.Text) And txtName.Text <> "" Then
            labor = CDbl(txtLabor.Text)
            parts = CDbl(txtParts.Text)
            name = txtName.Text

            Dim laborCost As Double = labor * 35
            Dim partsCost As Double = parts + (parts * 0.05)
            total = laborCost + partsCost

            lstDisplay.Items.Add("Customer: " & name)
            lstDisplay.Items.Add("Labor Cost: " & FormatCurrency(laborCost))
            lstDisplay.Items.Add("Parts Cost: " & FormatCurrency(partsCost))
            lstDisplay.Items.Add("Total Cost: " & FormatCurrency(total))
        Else
            MessageBox.Show("Please enter valid input")
        End If
    End Sub
    'Change for a dollar
    Private Sub buttonCalculate_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'define needed variables
        Dim amount, cents25, cents10, cents5, cents1 As Double
        'convert amount input to bouble
        amount = CDbl(txtAmount.Text)
        'get how many cents25 for the amount and convert to int to get just integer from from the number
        cents25 = Int(amount / 25)
        txt25.Text = cents25

        amount = amount - (25 * cents25)

        cents10 = Int(amount / 10)
        txt10.Text = cents10

        amount = amount - (10 * cents10)

        cents5 = Int(amount / 5)
        txt5.Text = cents5

        amount = amount - (5 * cents5)

        cents1 = amount
        txt1.Text = cents1
    End Sub

    Private Sub substrBtn_Click(sender As Object, e As EventArgs) Handles substrBtn.Click
        'Dim firstNum, secondNum, result As Double

        Try
            If numberOne.Text <> "" And numberTwo.Text <> "" Then
                firstNum = CDbl(numberOne.Text)
                secondNum = CDbl(numberTwo.Text)

                result = firstNum - secondNum
                outputResults.Text = "The result of " & firstNum & "-" & secondNum & "=" & result
            Else
                MessageBox.Show("PLease enter both numbers")
            End If
        Catch ex As Exception
            MsgBox("Only numbers accepted" & vbCrLf & ex.Message)
            'Finally
            '    MsgBox("Something went wrong")
        End Try

        addBtn.Appearance.BackColor = Color.FromArgb(240, 240, 240)
        substrBtn.Appearance.BackColor = Color.Brown
        multiplyBtn.Appearance.BackColor = Color.FromArgb(240, 240, 240)
    End Sub

    Private Sub multiplyBtn_Click(sender As Object, e As EventArgs) Handles multiplyBtn.Click
        'Dim firstNum, secondNum, result As Double

        Try
            If numberOne.Text <> "" And numberTwo.Text <> "" Then
                firstNum = CDbl(numberOne.Text)
                secondNum = CDbl(numberTwo.Text)

                result = firstNum * secondNum
                outputResults.Text = "The result of " & firstNum & "*" & secondNum & "=" & result
            Else
                MessageBox.Show("PLease enter both numbers")
            End If
        Catch ex As Exception
            MsgBox("Only numbers accepted" & vbCrLf & ex.Message)
            'Finally
            '    MsgBox("Something went wrong")
        End Try

        addBtn.Appearance.BackColor = Color.FromArgb(240, 240, 240)
        substrBtn.Appearance.BackColor = Color.FromArgb(240, 240, 240)
        multiplyBtn.Appearance.BackColor = Color.Brown
    End Sub
End Class
