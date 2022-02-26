Public Class Form1
    Dim score1 As Integer
    Dim score2 As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler Button1.Click, AddressOf MyClickHandler
        AddHandler Button2.Click, AddressOf MyClickHandler
        TextBox1.Text = ("0 :  0")

    End Sub

    Private Sub MyClickHandler(sender As Object, e As EventArgs)

        Select Case CType(sender, Button).Name
            Case "Button1"
                If score1 = 0 Then
                    score1 = score1 + 15
                    TextBox1.Text = score1
                ElseIf score1 = 15 Then
                    score1 = score1 + 15
                    TextBox1.Text = score1
                ElseIf score1 = 30 Then
                    score1 = score1 + 10
                    TextBox1.Text = score2
                ElseIf score1 = 40 Then
                    score1 = score1 + 10
                    TextBox1.Text = "Player 1 wins"
                ElseIf score1 = score1 Then
                    score1 = score1 - score1
                    TextBox1.Text = score1

                Else
                    MsgBox("incorrect")
                End If


            Case "Button2"
                If score2 = 0 Then
                    score2 = score2 + 15
                    TextBox1.Text = score2
                ElseIf score2 = 15 Then
                    score2 = score2 + 15
                    TextBox1.Text = score2
                ElseIf score2 = 30 Then
                    score2 = score2 + 10
                    TextBox1.Text = score2
                ElseIf score2 = 40 Then
                    score2 = score2 + 10
                    TextBox1.Text = "Player 2 wins"
                ElseIf score2 = 50 Then
                    score2 = score2 - score2
                    TextBox1.Text = score2
                Else
                    MsgBox("incorrect")
                End If


        End Select
    End Sub
End Class