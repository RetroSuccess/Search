Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name() As String = {"", "Alice", "Bob", "Charlie", "David", "Emma"}
        Dim sname As String
        Dim search As Boolean
        sname = TextBox1.Text

        For i = 0 To name.Length - 1
            If name(i) = sname Then
                MsgBox("Found")
                search = True
                Exit For
            End If
        Next

        If search = False Then
            MsgBox("Not Found")
        End If
    End Sub
End Class
