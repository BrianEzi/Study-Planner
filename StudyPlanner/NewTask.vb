Imports System.Data.OleDb
Public Class NewTask
    Dim command As New OleDbCommand
    Dim connection As New OleDbConnection
    Dim flagname As Boolean = False
    Dim flagdays As Boolean = False
    Dim flagpriority As Boolean = False
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        If TrackBar1.Value <> 0 Then
            flagpriority = True
        Else flagpriority = False
        End If
        If Not String.IsNullOrWhiteSpace(TxtName.Text) Then
            flagname = True
        Else
            flagname = False
        End If
        If LboxDays.SelectedIndex <> -1 Or CboxAnytime.Checked = True Then
            flagdays = True
        Else
            flagdays = False
        End If
        If flagdays And flagname And flagpriority = True Then
            'establishes the connection and opens the database ready for use
            Try
                connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\14ezinwokeb\OneDrive - Macmillan Academy\computer science project\StudyPlanner.mdb"
                connection.Open()
            Catch ex As Exception
                connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
                connection.Open()
            End Try
            Dim query = "Insert Into Event () Values ()"
            command.CommandText = query
            command.ExecuteNonQuery()
        End If
    End Sub
End Class