Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Call aa()
    End Sub

    Private Sub aa()
        AddLV("Button.click")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = Me.Text & " " & My.Application.Info.Version.ToString
        Me.ToolStripStatusLabel3.Text = My.Application.Info.Copyright.ToString
        Me.ToolStripStatusLabel1.Text = Now.TimeOfDay.ToString & ": Starting"
        AddLV("Starting ..")
    End Sub

    Private Sub AddLV(ByVal Mess As String)
        Dim lvi As ListViewItem = Me.ListView1.Items.Add(Now.ToString)
        lvi.SubItems.Add(Mess)
    End Sub

    Private Sub LoadEden()
        Me.FbDataAdapter1.Fill(Me.DataSetEden.ZAZNAMY)
    End Sub


    Private Sub BtmLoadZaznamy_Click(sender As Object, e As EventArgs) Handles BtmLoadZaznamy.Click
        LoadEden()
    End Sub
End Class
