Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call aa()
    End Sub

    Private Sub aa()
        AddLV("Button.click")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddLV("Starting ..")
    End Sub

    Private Sub AddLV(ByVal Mess As String)
        Dim lvi As ListViewItem = Me.ListView1.Items.Add(Now.ToString)
        lvi.SubItems.Add(Mess)
    End Sub

End Class
