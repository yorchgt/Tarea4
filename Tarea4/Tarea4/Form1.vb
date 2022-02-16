Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Desea Salir?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim i, j, n As Integer

        j = 1
        n = TextBox1.Text
        For i = 1 To n Step 1
                    j = j * i
                Next
                Label3.Text = j.ToString
        TextBox1.Text = ""

    End Sub
   

End Class
