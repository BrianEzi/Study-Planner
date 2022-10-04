Imports System.Data.OleDb
Public Class MonthFrm
    'array containing the name of each month
    ReadOnly monthnames() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
    'array containing the length of each month
    Dim monthlength() As Integer = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
    Dim month As Integer
    Dim year As Integer
    Dim command As New OleDb.OleDbCommand
    Dim connection As New OleDb.OleDbConnection
    Dim myDataReader As OleDbDataReader
    Dim results As String

    Private Sub MonthFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'gets the current date and sets the calendar to that month
        Dim regDate As Date = Date.Now() 'gets the current date
        Dim strDate As String = regDate.ToString("ddMMyyyy") ' converts the date to string so it can be manipulated
        Dim dayofmonth = Mid(strDate, 1, 2)
        month = Mid(strDate, 3, 2)
        LblMonth.Text = monthnames(month - 1)
        year = Mid(strDate, 5, 4)
        PopulateTable() 'calls the subroutine PopulateTable() so the calender is filled
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        'iterates backwards through the months of the year 
        month -= 1
        If month = 0 Then 'changes the month back 12 if it goes below 1 so it loops back round from january to december
            month = 12
            year -= 1
        End If
        LblMonth.Text = monthnames(month - 1) ' changes the month label to the appropriate month
        PopulateTable()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        'iterates forwards through the months of the year 
        month += 1
        If month = 13 Then 'changes the month back to 1 if it goes abouve 12 so it loops back round from december to january
            month = 1
            year += 1
        End If
        LblMonth.Text = monthnames(month - 1) ' changes the month label to the appropriate month
        PopulateTable() 'fills the table up again
    End Sub

    Private Sub PopulateTable() ' populates the datagridview with the dates for each day, displays the correct year as well and highlights any days which have an event booked in for that day 
        DGVMonth.Rows.Clear()
        DGVMonth.Rows.Add()
        'checks if it is a leap year and changes the array of month lengths for february to 29
        If year Mod 4 = 0 Then
            monthlength(1) = 29
        Else
            monthlength(1) = 28
        End If

        'gets the first day of the month as a string
        Dim firstofmonth = "01" & "/" & CStr(month) & "/" & year
        'converts the string to datetime 
        Dim fomdate As DateTime = DateTime.Parse(firstofmonth)
        'declares the month start to be the day the month begins on where monday is the first day of the week
        Dim monthstart = Weekday(fomdate, 2)
        'changes the year label to the current year
        LblYear.Text = year
        'declares the starting column to be the 
        Dim column = monthstart - 1
        Dim daynum As Integer, row As Integer = 0
        'opens the connection to the database and creates the command
        'connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
        Try
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\14ezinwokeb\OneDrive - Macmillan Academy\computer science project\StudyPlanner.mdb"
            connection.Open()
        Catch ex As Exception
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
            connection.Open()
        End Try
        command.Connection = connection
        Dim fulldatestring
        For daynum = 1 To monthlength(month - 1) 'iterate through the number of days in the month 
            'goes to new row if column is no longer in range
            If column = 7 Then
                column = 0
                DGVMonth.Rows.Add()
                row += 1
            End If
            DGVMonth.Rows(row).Cells(column).Value = daynum 'fills the cell with the date of that day
            fulldatestring = month & "/" & daynum & "/" & year
            'query to select all records where the there is an event on the currentdate in the cell
            Dim sqlquery = "Select * FROM Calendar WHERE CalDate= #" & fulldatestring & "#"
            command.CommandText = sqlquery
            Using myDataReader = command.ExecuteReader
                Do While myDataReader.Read()
                    results = results & myDataReader.Item("CalDate") & vbLf
                Loop
            End Using
            If results <> "" Then
                DGVMonth.Rows(row).Cells(column).Style.BackColor = Color.Red 'changes the colour of the cell to red if there is an event scheduled for that day 

            End If
            results = ""
            column += 1 'goes to the next column

        Next
        'correctly shapes the height of the columns so they fit on the page
        For i = 0 To DGVMonth.Rows.Count - 1
            DGVMonth.Rows(i).Height = (DGVMonth.Height - 25) / DGVMonth.Rows.Count
        Next
        connection.Close()
    End Sub
    'connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
    Private Sub DGVMonth_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVMonth.CellClick
        Dim currentdayresults As String
        Dim datestring As String = month & "/" & DGVMonth.CurrentCell.Value & "/" & year 'forms a string form of the date of the cell to be used in the query
        Dim sqlquery As String = "Select * From Calendar where CalDate=#" & datestring & "#" 'creates the query
        'sets the connection to the connection string
        Try
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\14ezinwokeb\OneDrive - Macmillan Academy\computer science project\StudyPlanner.mdb"
            connection.Open()
        Catch ex As Exception
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
            connection.Open()
        End Try
        command.Connection = connection
        command.CommandText = sqlquery 'sets the command to be the sql query
        If DGVMonth.CurrentCell.Value <> Nothing Then 'makes sure that the cell isn't empty so that a null error does not occur
            Using myDataReader = command.ExecuteReader 'executes the query
                Do While myDataReader.Read()
                    'concatenates the currentdayresults to include the relevant events of that day
                    currentdayresults = currentdayresults & myDataReader.Item("Start") & " - " & myDataReader.Item("Title") & vbLf
                Loop
            End Using
            If currentdayresults <> Nothing Then 'checks if the there were events on that day
                MsgBox("These are your events for today:" & vbNewLine & currentdayresults) ' outputs the events for the day if currentday had a value
            Else
                MsgBox("There are no results on this day") ' outputs the messae saying there are no events if currentdayresults was empty
            End If
        End If
        connection.Close() 'close the connection
    End Sub

    Private Sub BtnWeek_Click(sender As Object, e As EventArgs) Handles BtnWeek.Click
        WeekFrm.Show() 'shows the weekview form
        Me.Hide() 'hides the monthview form
    End Sub
End Class