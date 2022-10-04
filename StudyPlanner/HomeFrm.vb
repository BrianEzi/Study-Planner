Imports System.Data.OleDb
Public Class HomeFrm
    Dim command As New OleDb.OleDbCommand
    Dim connection As New OleDb.OleDbConnection
    Dim myDataReader As OleDbDataReader
    Dim results As String
    Private Sub HomeFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'establishes the connection and opens the database ready for use
        Try
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\14ezinwokeb\OneDrive - Macmillan Academy\computer science project\StudyPlanner.mdb"
            connection.Open()
        Catch ex As Exception
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
            connection.Open()
        End Try
        command.Connection = connection

        Try
            Dim taskquery = "SELECT * FROM Calendar WHERE Eventtype = 't' AND Completed = FALSE" 'query to get all uncompleted tasks from events
            command.CommandText = taskquery
            Using myDataReader = command.ExecuteReader
                Do While myDataReader.Read()
                    CLBTasks.Items.Add(myDataReader.Item("Title")) 'adds the task to the checked list box
                Loop
            End Using
        Catch ex As Exception

        End Try

        Try
            Dim todoquery = "Select * From Calendar Where Caldatate =#" & DateTime.Today.ToShortDateString & "#" 'query to get all events for the day
            command.CommandText = todoquery
            Using myDataReader = command.ExecuteReader
                Do While myDataReader.Read()
                    DGVTodo.Rows.Add(myDataReader.Item("Start"), myDataReader.Item("Title")) 'adds the start time and title to the datagridview
                Loop
            End Using
        Catch ex As Exception

        End Try

        connection.Close() 'closes the connection to the database
    End Sub

    Private Sub BtnAnalytics_Click(sender As Object, e As EventArgs) Handles BtnAnalytics.Click
        'establishes the connection and opens the database ready for use
        Try
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\14ezinwokeb\OneDrive - Macmillan Academy\computer science project\StudyPlanner.mdb"
            connection.Open()
        Catch ex As Exception
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
            connection.Open()
        End Try
        'initialises variables
        Dim goalscompleted = 0
        Dim timespent = 0
        Dim taskscompleted = 0
        Dim goalsquery = "Select * From Goal Where Completed=True " ' query to select all completed form goal
        command.CommandText = goalsquery
        Using mydatareader = command.ExecuteReader
            Do While mydatareader.Read
                goalscompleted += 1 'increments counter by 1 for each row in database

            Loop
        End Using
        Dim taskscompletequery = "Select * From Event Where EventType ='t' AND Completed =True" 'query to get all the completed tasks
        command.CommandText = taskscompletequery
        Using mydatareader = command.ExecuteReader
            Do While mydatareader.Read
                taskscompleted += 1 'increments the counter by 1 for each completed task in the database
            Loop
        End Using
        Dim timespentquery = "Select * From Calendar Where Caldate <#" & Date.Today.ToString & "#" 'query to get the total length fo time
        command.CommandText = timespentquery
        Using mydatareader = command.ExecuteReader
            Do While mydatareader.Read
                timespent += Convert.ToInt32(mydatareader.Item("length")) 'adds all the times together
            Loop
        End Using
        connection.Close()
        MsgBox("Goals Completed:" & goalscompleted & vbNewLine & "Tasks Completed:" & taskscompleted & vbNewLine & "Time spent in minutes:" & timespent) 'displays all the information gathered
    End Sub
    'Public Sub DrawPieChart(ByVal PiePercents() As Integer, ByVal PieColors() As Color,
    '                          ByVal PieGraphic As Graphics, ByVal PieLocation As Point,
    '                          ByVal PieSize As Size)

    '    'Check values total is 100 or not...
    '    Dim sum = 0
    '    For Each percent In PiePercents
    '        sum += percent
    '    Next

    '    ' If sum not 100 then throw Exception...
    '    If sum <> 100 Then
    '        Throw New ArgumentException("Percentages do not add up to 100.")
    '    End If

    '    ' Here it will check that total values & colors value are same or not...
    '    ' If not same then throw Exception...
    '    If PiePercents.Length <> PieColors.Length Then
    '        Throw New ArgumentException("There must be the same number of percents and colors.")
    '    End If

    '    Dim PiePercentTotal = 0
    '    For PiePercent = 0 To PiePercents.Length() - 1
    '        Using brush As New SolidBrush(PieColors(PiePercent))
    '            PieGraphic.FillPie(brush, New Rectangle(Location, PieSize), CSng(PiePercentTotal * 360 / 100), CSng(PiePercents(PiePercent) * 360 / 100))
    '        End Using

    '        PiePercentTotal += PiePercents(PiePercent)
    '    Next
    '    Return
    'End Sub


    'Public Sub DrawPieChartOnForm()
    '    ' Here all values total must be 100...
    '    'Here you can increase or decrese value, but must total 100...
    '    Dim PiePercent = {50, 10, 30, 2, 5, 3}
    '    'Write color for each different parts of pie chart...
    '    'Depending on values set the values of color for each different part of pie chart...
    '    Dim PieColors = {Color.Red, Color.Lavender, Color.Blue, Color.Green, Color.Gold, Color.Orange}
    '    Using PieGraphic = Me.CreateGraphics()
    '        'Set location of pie chart...
    '        Dim PieLocation As New Point(10, 10)
    '        'Set size of pie chart...
    '        Dim PieSize As New Size(150, 150)
    '        'Call function which create a pie chart of given data...
    '        DrawPieChart(PiePercent, PieColors, PieGraphic, PieLocation, PieSize)
    '    End Using
    'End Sub


    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewTask.Click

    '    'call here function, which draw pie chart on the form...

    '    DrawPieChartOnForm()
    'End Sub
    Private Sub CLBTasks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CLBTasks.SelectedIndexChanged
        'establishes the connection and opens the database ready for use
        Try
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\14ezinwokeb\OneDrive - Macmillan Academy\computer science project\StudyPlanner.mdb"
            connection.Open()
        Catch ex As Exception
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
            connection.Open()
        End Try
        Dim query
        For x = 0 To CLBTasks.Items.Count - 1 'iterates thorugh each task
            If CLBTasks.GetItemChecked(x) = True Then 'checks if the item has been checked off
                'if it has, a query is created to update the record
                query = "Update Event Set Completed = True Where Title ='" & CLBTasks.Items(x).ToString & "' And EventType = 't'"
                command.CommandText = query
                command.ExecuteNonQuery() 'query is executed
            End If
        Next
        connection.Close()
    End Sub
End Class