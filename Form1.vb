Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim filePath As String = "sample.txt"
            Using writer As New StreamWriter(filePath) ' Comment
                writer.WriteLine("Hello, this is a test file!")
                writer.WriteLine("Second line of text.")
            End Using
            MessageBox.Show("Data written successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error writing to file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
