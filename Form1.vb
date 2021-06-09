Public Class Form1
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        txtName.Text = "Hello " + txtName.Text

    End Sub

    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        MessageBox.Show("Hello " & txtName.Text,
                        "Hello " & txtName.Text)


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim firstNum As Integer = CInt(txtValue1.Text)
            Dim secondNum As Integer = CInt(txtValue2.Text)
            Dim sum = firstNum + secondNum
            txtResult.Text = CStr(sum)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Please enter numbers to sum")
            Console.WriteLine("An Error occurred")

        Catch ex As Exception
            MessageBox.Show("An Error occurred")
        End Try
    End Sub
End Class
