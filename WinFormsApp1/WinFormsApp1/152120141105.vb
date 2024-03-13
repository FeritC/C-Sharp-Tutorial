Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer
        Dim num2 As Integer
        If Int32.TryParse(TextBox1.Text, num1) AndAlso Int32.TryParse(TextBox2.Text, num2) Then
            Label1.Text = (num1 + num2).ToString()
            If (Int32.Parse(Label1.Text) > 0) Then
                Label1.BackColor = Color.Green
            Else
                Label1.BackColor = Color.Red
            End If
        Else
            Label1.Text = "Error : Enter valid numbers "
            Label1.BackColor = Color.Red
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1 As Integer
        Dim num2 As Integer
        If Int32.TryParse(TextBox1.Text, num1) AndAlso Int32.TryParse(TextBox2.Text, num2) Then
            Label1.Text = (num1 - num2).ToString()
            If (Int32.Parse(Label1.Text) > 0) Then
                Label1.BackColor = Color.Green
            Else
                Label1.BackColor = Color.Red
            End If
        Else
            Label1.Text = "Error : Enter valid numbers "
            Label1.BackColor = Color.Red
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num1 As Integer
        Dim num2 As Integer
        If Int32.TryParse(TextBox1.Text, num1) AndAlso Int32.TryParse(TextBox2.Text, num2) Then
            Label1.Text = (num1 * num2).ToString()
            If (Int32.Parse(Label1.Text) > 0) Then
                Label1.BackColor = Color.Green
            Else
                Label1.BackColor = Color.Red
            End If
        Else
            Label1.Text = "Error : Enter valid numbers "
            Label1.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1 As Double
        Dim num2 As Double
        If Double.TryParse(TextBox1.Text, num1) AndAlso Double.TryParse(TextBox2.Text, num2) Then
            If (num1 = 0 And num2 = 0) Then
                Label1.Text = "0 diveded by 0.Undefined."
                Return
            End If
            If (num2 = 0) Then
                Label1.Text = "Division by 0.Undefined."
                Return
            End If
            Label1.Text = (num1 / num2).ToString()
            If (Double.Parse(Label1.Text) > 0) Then
                Label1.BackColor = Color.Green
            Else
                Label1.BackColor = Color.Red
            End If
        Else
            Label1.Text = "Error : Enter valid numbers "
            Label1.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.ForeColor = Color.Red
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.Black
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Button2.ForeColor = Color.Red
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.ForeColor = Color.Black
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        Button3.ForeColor = Color.Red
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.ForeColor = Color.Black
    End Sub

    Private Sub Button4_MouseHover(sender As Object, e As EventArgs) Handles Button4.MouseHover
        Button4.ForeColor = Color.Red
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Button4.ForeColor = Color.Black
    End Sub
End Class
