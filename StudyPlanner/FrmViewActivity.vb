Imports System.Data.OleDb
Public Class FrmViewActivity
    'initialise variables
    Dim command As New OleDb.OleDbCommand
    Dim connection As New OleDb.OleDbConnection
    Dim myDataReader As OleDbDataReader
    Dim results As String
    Dim eventname
    Dim eventid, catid
    Dim goalarray()
    Dim repeat As String, desc As String, starttime As String, endtime As String
    Public ActivityEdit As Boolean = False

    Private Sub FrmViewActivity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'queries the database for the values necessary to show on the form
        Try
            eventname = My.Forms.ActivityFrm.DGV.CurrentCell.Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Close()
        End Try
        Dim activitysql As String = "Select * From Event Where Title ='" & eventname & "'"
        Try
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\14ezinwokeb\OneDrive - Macmillan Academy\computer science project\StudyPlanner.mdb"
            connection.Open()
        Catch ex As Exception
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
            connection.Open()
        End Try
        command.Connection = connection
        command.CommandText = activitysql
        Using myDataReader = command.ExecuteReader
            'stores the values from the database in the relevant variables
            Do While myDataReader.Read
                If Not String.IsNullOrWhiteSpace(myDataReader.Item("Description")) Then 'checks if description isnull
                    desc = myDataReader.Item("Description") 'stores description in desc if not null
                End If
                repeat = myDataReader.Item("Repeat")
                eventid = myDataReader.Item("EventID")
                starttime = myDataReader.Item("StartTime")
                If Not String.IsNullOrWhiteSpace(myDataReader.Item("EndTime").ToString) Then 'checks if endtime is null
                    endtime = myDataReader.Item("EndTime") 'stores description in desc if not null
                End If
                catid = myDataReader.Item("CatID")
            Loop
        End Using
        'puts the retrieved values into the correct containers
        Dim categorysql = "Select * From Category Where Catid =" & catid & "" 'query to retrieve the row where the category of the activity is
        command.CommandText = categorysql
        Using mydatareader = command.ExecuteReader
            Do While mydatareader.Read
                LblActType.Text = mydatareader.Item("Catname") 'stores the name of the category in the label so it can be displayed
            Loop
        End Using
        LblName.Text = eventname
        txtdesc.Text = desc
        For x = 1 To repeat.Length 'iterates through each character in repeat
            LblScheduledDays.Text &= vbNewLine & "-" & WeekdayName(Convert.ToInt32(Mid(repeat, x, 1)) + 1) 'adds on to the label with the corresponding weekday to the numbers stored in repeat
        Next
        If Not String.IsNullOrWhiteSpace(endtime) Then 'checks if there is a value for endtime
            LblStartTime.Text &= starttime & "-" & endtime
        Else
            LblStartTime.Text &= starttime
        End If
        'retrieves the goal ids from the link table
        Dim goaleventquery As String = "Select * From EventGoal Where EventID = " & eventid & ""
        Dim goalid
        Dim goalquery As String
        command.CommandText = goaleventquery
        Using mydatareader = command.ExecuteReader
            Do While mydatareader.Read()
                goalid &= mydatareader.Item("GoalID") & "," 'stores the goalid in the string
            Loop
        End Using
        'stores these goal ids into an array
        goalarray = Split(goalid, ",")
        'iterates through the array 
        Dim i = 0
        For x = 0 To goalarray.Length - 2
            'queries the database for the goals which correspond to the goal ids and puts them in the checked list box 
            goalquery = "Select * From Goal Where GoalID = " & goalarray(x) & ""
            command.CommandText = goalquery
            Using mydatareader = command.ExecuteReader
                Do While mydatareader.Read()
                    CLBGoals.Items.Add(mydatareader.Item("Goal")) 'adds each goal to the checkedlist box
                    If mydatareader.Item("Completed") = True Then
                        CLBGoals.SetItemChecked(i, True)
                    End If
                Loop
            End Using
        Next
        connection.Close()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        ActivityEdit = True
        NewActivity.Show()
        Me.Hide()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        'queries the database to delete the event from event table
        Try
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\14ezinwokeb\OneDrive - Macmillan Academy\computer science project\StudyPlanner.mdb"
            connection.Open()
        Catch ex As Exception
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
            connection.Open()
        End Try
        Dim deleteeventsql = "Delete From Event Where Title = '" & eventname & "'"
        command.Connection = connection
        command.CommandText = deleteeventsql
        command.ExecuteNonQuery()
        'queries the database to delete all instance where there the event id occurs 
        Dim deleteEGquery = "Delete From EventGoal Where EventID= " & eventid & ""
        command.CommandText = deleteEGquery
        command.ExecuteNonQuery()
        Dim deletegoalquery
        'iterates through the array full of goals
        For x = 0 To goalarray.Length - 2
            'queries the database to delete the current goal in the goal array 
            deletegoalquery = "Delete From Goal where GoalID= " & Convert.ToInt32(goalarray(x)) & ""
            command.CommandText = deletegoalquery
            command.ExecuteNonQuery()
        Next
        Dim deletecalendaryquery = "Delete From Calendar Where Title ='" & eventname & "'" 'queries the database to delete the current activity
        command.CommandText = deletecalendaryquery
        command.ExecuteNonQuery() 'executes the query, deleting the record
        connection.Close()
        MsgBox(eventname & "has been deleted") 'informs the user that the event has been deleted
        Me.Close() 'closes the form
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\14ezinwokeb\OneDrive - Macmillan Academy\computer science project\StudyPlanner.mdb"
            connection.Open()
        Catch ex As Exception
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
            connection.Open()
        End Try
        command.Connection = connection
        'iterates through all the goals
        For i = 0 To CLBGoals.Items.Count - 1
            'checks if the goal has already been checked
            If CLBGoals.GetItemChecked(i) = True Then
                'updates the database to set all completed goals
                Dim updatequery = "Update Goal Set Completed = TRUE Where Goal = '" & CLBGoals.Items(i).ToString & "'"
                MsgBox(CLBGoals.Items(i).ToString)
                MsgBox(updatequery)
                command.CommandText = updatequery
                command.ExecuteNonQuery()
            End If
        Next
        CLBGoals.Items.Clear()
        'connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
        'retrieves the goal ids from the link table
        Dim goaleventquery As String = "Select * From EventGoal Where EventID = " & eventid & ""
        Dim goalid
        Dim goalquery As String
        command.CommandText = goaleventquery
        Using mydatareader = command.ExecuteReader
            Do While mydatareader.Read()
                goalid &= mydatareader.Item("GoalID") & "," 'stores these goal ids in a string intially
            Loop
        End Using
        'stores these goal ids into an array
        goalarray = Split(goalid, ",")
        CLBGoals.Items.Clear() 'clears all items in the checked listbox so the same goals do not keep being added
        'iterates through the array 
        For x = 0 To goalarray.Length - 2
            'queries the database for the goals which correspond to the goal ids and puts them in the checked list box 
            goalquery = "Select * From Goal Where GoalID = " & goalarray(x) & " AND Completed = FALSE"
            command.CommandText = goalquery
            Using mydatareader = command.ExecuteReader
                Do While mydatareader.Read()
                    CLBGoals.Items.Add(mydatareader.Item("Goal")) 'adds the new items to the checked list box
                Loop
            End Using
        Next
        connection.Close()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        ActivityFrm.Show() 'brings up activity form
        Me.Close() 'closes the form 
    End Sub
End Class