Public Class Form1
    Private Sub Version_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim proc As New System.Diagnostics.Process()
        proc = Process.Start("adbrecovery.bat", "")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim initadb As New System.Diagnostics.Process()
        initadb = Process.Start("initadb.bat", "")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim proc2 As New System.Diagnostics.Process()
        proc2 = Process.Start("adbreboot.bat", "")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim proc5 As New System.Diagnostics.Process()
        proc5 = Process.Start("killadb.bat", "")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim proc3 As New System.Diagnostics.Process()
        proc3 = Process.Start("adbrestart.bat", "")
    End Sub

    Private Sub Shutdown_Click(sender As Object, e As EventArgs) Handles Shutdown.Click
        Dim proc3 As New System.Diagnostics.Process()
        proc3 = Process.Start("shutdown.bat", "")
    End Sub
End Class
