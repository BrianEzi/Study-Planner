Imports System.Data.OleDb
Public Class PlusFrm
    Dim connection As New OleDbConnection
    Dim command As New OleDbCommand
    Dim mydatareader As OleDbDataReader
    Private Sub BtnNewTask_Click(sender As Object, e As EventArgs) Handles Btnanalyse.Click
        'establishes the connection and opens the database ready for use
        Try
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\14ezinwokeb\OneDrive - Macmillan Academy\computer science project\StudyPlanner.mdb"
            connection.Open()
        Catch ex As Exception
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
            connection.Open()
        End Try
        'initialises variables
        command.Connection = connection
        Dim goalscompleted = 0
        Dim timespent = 0
        Dim taskscompleted = 0
        Dim goalsquery = "Select * From Goal Where Completed=True " ' query to select all completed form goal
        Command.CommandText = goalsquery
        Using mydatareader = Command.ExecuteReader
            Do While mydatareader.Read
                goalscompleted += 1 'increments counter by 1 for each row in database

            Loop
        End Using
        Dim taskscompletequery = "Select * From Event Where EventType ='t' AND Completed =True" 'query to get all the completed tasks
        Command.CommandText = taskscompletequery
        Using mydatareader = Command.ExecuteReader
            Do While mydatareader.Read
                taskscompleted += 1 'increments the counter by 1 for each completed task in the database
            Loop
        End Using
        Dim timespentquery = "Select * From Calendar Where Caldate <#" & Date.Today.ToString & "#" 'query to get the total length fo time
        Command.CommandText = timespentquery
        Using mydatareader = Command.ExecuteReader
            Do While mydatareader.Read
                timespent += Convert.ToInt32(mydatareader.Item("length")) 'adds all the times together
            Loop
        End Using
        connection.Close()
        MsgBox("Goals Completed:" & goalscompleted & vbNewLine & "Tasks Completed:" & taskscompleted & vbNewLine & "Time spent in minutes:" & timespent) 'displays all the information gathere
    End Sub
    Private Sub BtnNewActivity_Click(sender As Object, e As EventArgs) Handles BtnNewActivity.Click
        NewActivity.Show() 'displays the new activity form
    End Sub
End Class