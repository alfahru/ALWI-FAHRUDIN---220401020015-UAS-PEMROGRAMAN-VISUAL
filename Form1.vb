Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim writefile As StreamWriter
        writefile = File.CreateText(TextBox1.Text)
        Dim writedata As String = TextBox2.Text
        writefile.WriteLine(writedata)
        writefile.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim readfile As String
        readfile = My.Computer.FileSystem.ReadAllText(TextBox1.Text)
        TextBox2.Text = readfile
    End Sub
End Class
