'To do: add buttons to move to the next weeks, 
Imports System.Data.OleDb
Public Class WeekFrm
    ReadOnly daysofweek() As String = {"Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"}
    Dim eventstarthour As Integer, eventstartmin As Integer, eventlength As Integer, day As Integer
    Dim hour As Integer = 0
    Dim command As New OleDb.OleDbCommand
    Dim connection As New OleDb.OleDbConnection
    Dim myDataReader As OleDbDataReader
    Dim tempresult As String
    Dim result As String()
    Dim fdow As Date
    Dim title As String, currentdate As String
    Dim columnwidth As Integer, rowheight As Integer
    Dim eventid
    Dim eventids()
    Dim colour As Color
    Private Sub WeekFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fdow = Firstdayofweek() 'stores the date of the first day of the week in the variable fdow
        ' CreateDGV(hour) ' creates the datagrid view
        getEvents() 'gets all the events for the week
        CreateDGV(hour)
        columnwidth = (DGVWeek.Width - DGVWeek.Columns.Item("Time").Width) / 7
        rowheight = (DGVWeek.Height - DGVWeek.ColumnHeadersHeight) / 8
        Lblweekstart.Text = fdow.ToShortDateString
        lblweekend.Text = fdow.AddDays(6).ToShortDateString
        'iterates throught each hour and adds a row to the datagrid view as well as inputs the hour into the cell and sets it's height
        For i = 1 To 7 ' iterates through each column of the datagrid and sets the width
            DGVWeek.Columns.Item(daysofweek(i - 1)).Width = (DGVWeek.Width) / 8
        Next
    End Sub
    Private Sub CreateDGV(firsthour)
        Dim x = 0
        DGVWeek.Rows.Clear()
        'iterates throught each hour and adds a row to the datagrid view as well as inputs the hour into the cell and sets it's height
        For i = firsthour To firsthour + 7
            DGVWeek.Rows.Add()
            DGVWeek.Rows(x).Cells(0).Value = i
            DGVWeek.Rows(x).Height = 60
            x += 1
        Next 'clears the previous state of the datagrid 
    End Sub
    Private Sub BtnUp_Click(sender As Object, e As EventArgs) Handles BtnUp.Click
        If hour <= 0 Then 'checks if the hour is equal 0 to prevent it becoming negative
            BtnUp.Enabled = False 'sets the button to be false so that the user knows that they can no longer go up 
        Else
            hour -= 8 'goes back 8 hours
            CreateDGV(hour) 'clears and recreates the datagrid view
            BtnDown.Enabled = True 'enables the down button incase the final 8 hours have been reached and it has been disabled
        End If
    End Sub
    Private Sub BtnDown_Click(sender As Object, e As EventArgs) Handles BtnDown.Click
        If hour >= 16 Then 'checks if the hour is equal 16 to prevent it from getting out of the range of a day
            BtnDown.Enabled = False 'sets the up button to be false so that user can no longer go down
        Else
            hour += 8 'goes forward 8 hours
            CreateDGV(hour) 'clears and recreates the datagridview
            BtnUp.Enabled = True 'enables the up button incase the first 8 hours had been reached and it was disabled
        End If
    End Sub
    Private Sub BtnPrevWeek_Click(sender As Object, e As EventArgs) Handles BtnPrevWeek.Click
        fdow = fdow.AddDays(-7)
        CreateDGV(hour)
        Lblweekstart.Text = fdow.ToShortDateString
        lblweekend.Text = fdow.AddDays(6).ToShortDateString
    End Sub
    Private Sub BtnNextWeek_Click(sender As Object, e As EventArgs) Handles BtnNextWeek.Click
        fdow = fdow.AddDays(7)
        CreateDGV(hour)
        Lblweekstart.Text = fdow.ToShortDateString
        lblweekend.Text = fdow.AddDays(6).ToShortDateString
    End Sub
    Private Sub BtnMonth_Click(sender As Object, e As EventArgs) Handles BtnMonth.Click
        MonthFrm.Show() 'shows the month view form 
        Me.Hide() 'hides the week view form
    End Sub

    Private Sub DGVWeek_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVWeek.CellClick
        Dim currentdayresults As String
        Dim row As Integer = DGVWeek.CurrentCell.RowIndex
        Dim currenthour = DGVWeek.Rows(row).Cells(0).Value & ":00:00"
        Dim endhour = DGVWeek.Rows(row).Cells(0).Value + 1 & ":00:00"
        Dim currentday As String = fdow.AddDays(DGVWeek.CurrentCell.ColumnIndex - 1).ToShortDateString 'forms a string form of the date of the cell to be used in the query
        Dim sqlquery As String = "Select * From Calendar Where CalDate=#" & currentday & "# AND Start >=#" & currenthour & "# AND Start <=#" & endhour & "#" 'creates the query
        'sets the connection to the connection string
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDbCommand
        Try
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\14ezinwokeb\OneDrive - Macmillan Academy\computer science project\StudyPlanner.mdb"
            con.Open()
        Catch ex As Exception
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
            con.Open()
        End Try
        cmd.Connection = con
        cmd.CommandText = sqlquery 'sets the command to be the sql query
        'makes sure that the cell isn't empty so that a null error does not occur
        Using mydatareader = cmd.ExecuteReader 'executes the query
            Do While mydatareader.Read()
                'concatenates the currentdayresults to include the relevant events of that day
                currentdayresults &= mydatareader.Item("Start") & " - " & mydatareader.Item("Title") & vbLf
            Loop
        End Using
        If Not String.IsNullOrWhiteSpace(currentdayresults) Then 'checks if the there were events on that day
            MsgBox("These are your events for today:" & vbNewLine & currentdayresults) ' outputs the events for the day if currentday had a value
        Else
            MsgBox("There are no results on this day") ' outputs the messae saying there are no events if currentdayresults was empty
        End If
        con.Close() 'close the connection
    End Sub


    Private Sub Dgv_CellPainting(ByVal sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DGVWeek.RowPostPaint
        '  initialises the variables for colour
        Dim colourquery
        Dim colourconvert As New ColorConverter
        Dim catidquery = ""
        Dim catid = ""
        Try
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\14ezinwokeb\OneDrive - Macmillan Academy\computer science project\StudyPlanner.mdb"
            connection.Open()
        Catch ex As Exception
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
            connection.Open()
        End Try
        command.Connection = connection
        For x = 0 To result.Length - 2 'iterates through each item in the array
            ExtractValues(x) 'gets the values for the current event
            Dim xcoord As Integer = (day - 1) * columnwidth + 125 + day + 1 'sets the x coordinate of the rectangle where the event will be 
            Dim ycoord As Integer 'sets the y coordinate of the rectangle where the event will be
            If eventstarthour > 15 Then
                ycoord = (eventstarthour - 16) * (rowheight - 1) + DGVWeek.ColumnHeadersHeight + eventstartmin
            ElseIf eventstarthour > 7 Then
                ycoord = (eventstarthour - 8) * (rowheight - 1) + DGVWeek.ColumnHeadersHeight + eventstartmin
            Else
                ycoord = eventstarthour * (rowheight - 1) + DGVWeek.ColumnHeadersHeight + eventstartmin
            End If
            catidquery = "Select * From Event Where EventID =" & eventids(x) & "" 'query to get the category ids from the databae
            command.CommandText = catidquery
            Using myDataReader = command.ExecuteReader
                Do While myDataReader.Read
                    catid = myDataReader.Item("CatID") 'stores the category id of the current event
                Loop
            End Using
            colourquery = "select * From Category Where Catid =" & catid & "" 'query to get the colour fo the cateogry
            command.CommandText = colourquery
            Using myDataReader = command.ExecuteReader
                Do While myDataReader.Read
                    colour = colourconvert.ConvertFromString(myDataReader.Item("Catcolour")) 'converts and then stores the colour of the cateogry
                Loop
            End Using
            Dim rectheight = (eventlength * 480) / (DGVWeek.Height - DGVWeek.ColumnHeadersHeight)
            Dim r1 As New Rectangle(xcoord, ycoord, columnwidth, rectheight) 'creates the new rectangle based on the parameters
            Dim b1 As Brush = Brushes.Black
            Dim p1 As New Pen(b1)
            e.Graphics.DrawRectangle(p1, r1) ' draws the rectangle
            e.Graphics.FillRectangle(New SolidBrush(colour), r1) 'fills in the rectangle with the category colour
            e.Graphics.DrawString(title, Font, Brushes.White, xcoord + 5, ycoord + 5) 'writes the title on the rectangle
        Next
        connection.Close()
        Array.Clear(eventids, 0, eventids.Length)
        Array.Clear(result, 0, result.Length)
    End Sub
    Private Sub getEvents()
        tempresult = "" 'clears the string result so that extra concatenation does not occur
        eventid = ""
        'sets the connection string
        Try
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\14ezinwokeb\OneDrive - Macmillan Academy\computer science project\StudyPlanner.mdb"
            connection.Open()
        Catch ex As Exception
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
            connection.Open()
        End Try
        command.Connection = connection
        Dim startdatestring = fdow.ToString("MM/dd/yyyy") 'converts the date of the first of the week to a string 
        Dim enddate = fdow.AddDays(6) ' gets the date of the last day of the week
        Dim enddatestring As String = enddate.ToString("MM/dd/yyyy") ' converts the date of the last day of the week to a string
        Dim starthourstring = hour & ":00:00" 'sets the bounds for the start and end hours so only hours within the time range shown are displayed
        Dim endhourstring = hour + 7 & ":00:00"
        'sql query created to selected all events during the stated week 
        Dim sqlquery = "SELECT * FROM Calendar WHERE CalDate>=#" & startdatestring & "# AND CalDate<= #" & enddatestring & "# AND Start >= #" & starthourstring & "# AND Start <= #" & endhourstring & "#"
        command.CommandText = sqlquery 'sets the command to be the sql query 
        Using myDataReader = command.ExecuteReader 'executes the query and stores the results in the datareader
            Do While myDataReader.Read()
                'uses temp result to store a string of the necessary values of the event
                tempresult = tempresult & myDataReader.Item("Start") & " " & myDataReader.Item("Length") & " " & myDataReader.Item("CalDate") & " " & myDataReader.Item("Title") & ","
                'gets all the event ids and stores them in a string
                eventid &= myDataReader.Item("EventID") & ","
            Loop
        End Using
        'close the connection
        connection.Close()
        result = Split(tempresult, ",") 'split the string up into the individual events and storese each event in a different position in the result array
        eventids = Split(eventid, ",") 'transfers the values into an array 
    End Sub
    Private Sub ExtractValues(x)
        Dim starthour = Mid(result(x), 1, 2) 'seperates the hour from the rest of the string and stores in the variable
        eventstarthour = Convert.ToInt32(starthour) ' converts the value to an integer and sets this value to evenstarthour
        Dim startmin = Mid(result(x), 4, 2) 'seperates the minute from the rest of the string and stores in the variable
        eventstartmin = Convert.ToInt32(startmin) ' converts the value to an integer and sets this value to evenstartmin
        Dim xlen = Mid(result(x), 10, 4) 'seperates the length from the rest of the string and stores in the variable
        eventlength = Convert.ToInt32(xlen) ' converts the value to an integer and sets this value to eventlength
        Dim xdate = Mid(result(x), 15, 10) 'seperates the date from the rest of the string and stores in the variable
        currentdate = Convert.ToDateTime(xdate) ' converts the value to a date and sets this value to current date
        day = Weekday(currentdate, 2) 'finds the weekday of the currentdate as this corresponds to the column in the datagrid view
        title = Mid(result(x), 26) 'seperates the title from the rest of the string and stores in the variable title
    End Sub
    Private Function Firstdayofweek() As String 'gets the first day of the week 
        Dim currentdate = Date.Today ' finds the current day
        Dim currentdayofweek = Weekday(currentdate, 2) ' works out the weekday from the current date
        Dim daydiff = currentdayofweek - 1 ' calculates the difference in days between the current day and monday and sets this as daydiff 
        Dim mondate As Date = currentdate.AddDays(-daydiff) ' works out the date of the monday which the week begins
        Return mondate 'returns the date of the monday
    End Function
End Class