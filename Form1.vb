Public Class Form1
#Region "Form load"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim userName As String = ""
        userName = InputBox("What is your name?", "Hello", "Marius Stefan", 200, 200)
        HelloUser.Text = "Welcome user: " & userName

        'passing byRef
        Dim num3 As Integer = 0
        MessageBox.Show(num3.ToString())
        LabelVariable.Text = num3.ToString()
        incrementVariable(num3)
        MessageBox.Show(num3.ToString())
        LabelVariable.Text = num3.ToString()
    End Sub
#End Region

#Region "event handlers"
    'buton sayHello
    Private Sub BtnSayHello_Click(sender As Object, e As EventArgs) Handles BtnSayHello.Click
        MessageBox.Show("Hi Marius")
        MessageBox.Show("Hi Marius", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If MessageBox.Show("click someting", "Title", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Abort Then
            MessageBox.Show("aborded")
        ElseIf MessageBox.Show("click someting", "Title", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
            MessageBox.Show("Please try again later")
        ElseIf MessageBox.Show("click someting", "Title", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Ignore Then
            MessageBox.Show("Bye bye.")
        End If
    End Sub

    'call addNumbers()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addNumbers()
    End Sub
    'solveMath()
    Private Sub BtnRunFuction_Click(sender As Object, e As EventArgs) Handles BtnRunFuction.Click
        MessageBox.Show(solveMath())
    End Sub
    'substractNumbers()
    Private Sub BtnSubstract_Click(sender As Object, e As EventArgs) Handles BtnSubstract.Click
        Dim answer As Double = substractNumbers(TextBox1.Text, TextBox2.Text)
        MessageBox.Show(answer)
    End Sub
#End Region

#Region "Methods"
    Private Sub addNumbers()
        Dim num1 As Integer = 23
        Dim num2 As Integer = 2
        MessageBox.Show(num1 + num2)
    End Sub

    Private Function solveMath() As Double
        Return 13 / 5
    End Function

    Private Function substractNumbers(ByVal num1 As Integer, ByVal num2 As Integer) As Double
        Return num1 - num2
    End Function

    Private Sub incrementVariable(ByRef x As Integer)
        x += 50
    End Sub

#End Region

End Class
