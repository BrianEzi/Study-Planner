Imports System.Data.OleDb
Module AutoSchedule
    Dim connection As New OleDbConnection
    Dim command As New OleDb.OleDbCommand
    Dim mydatareader As OleDbDataReader
    Dim results As String
    Dim resultarray()
    Dim geteventquery As String

    'retrieves the events which have flexible times from the database and stores them in an array
    Private Sub GetEvents()
        Dim eventid As Integer
        Dim starttime As Date, endtime As Date
        Dim priority As Integer
        Dim repeat As String
        Dim length As Integer
        Dim calendarquery As String = ""
        Dim start As String
        Dim title As String
        Dim weekstart As Date
        Dim daydiff = Weekday(Today)
        weekstart = Today.AddDays(1 - daydiff)
        Dim allqueries()
        Try
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
            connection.Open()
        Catch ex As Exception
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\14ezinwokeb\OneDrive - Macmillan Academy\computer science project\StudyPlanner.mdb"
            connection.Open()
        End Try
        command.Connection = connection
        geteventquery = "SELECT * FROM Event WHERE Autoschedule = TRUE"
        command.CommandText = geteventquery
        Using mydatareader = command.ExecuteReader
            Do While mydatareader.Read
                eventid = mydatareader.Item("EventID")
                starttime = mydatareader.Item("StartTime")
                endtime = mydatareader.Item("EndTime")
                priority = mydatareader.Item("Priority")
                repeat = mydatareader.Item("Repeat")
                length = mydatareader.Item("Length")
                title = mydatareader.Item("Title")
                Randomize()
                If priority = 10 Then
                    start = starttime.ToShortTimeString
                Else
                    start = starttime.AddMinutes(((endtime.Hour * 60) + endtime.Minute - (starttime.Hour * 60) + starttime.Minute) * Rnd()).ToShortTimeString
                End If
                For x = 0 To 52
                    For i = 0 To repeat.Length - 1
                        daydiff = CInt(Mid(repeat, i, 1))
                        calendarquery &= "Insert Into Calendar Values (" & eventid & ",#" & start & "#,#" & weekstart.AddDays(daydiff) & "#,'" & title & "'," & length & ")" & "/-/"
                    Next
                    weekstart.AddDays(7)
                Next
            Loop
        End Using
        allqueries = Split(calendarquery, "/-/")
        For x = 0 To allqueries.Length - 2
            command.CommandText = allqueries(x)
            command.ExecuteNonQuery()
        Next
        connection.Close()
    End Sub
    'checks if there is an available time slot for the events
    Private Sub CheckAvailable()

    End Sub
    'Arranges the events and inputs them into the Calendar table based on priority
    Private Sub InputEvents()

    End Sub
End Module
