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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim filePath As String = "sample.txt"
            Using reader As New StreamReader(filePath) ' Comment
                Dim content As String = reader.ReadToEnd()
                MessageBox.Show(content, "File Content", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error reading from file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
