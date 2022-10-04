Imports System.Data.OleDb
Public Class NewActivity
    'initialise variables
    Dim command As New OleDb.OleDbCommand
    Dim connection As New OleDb.OleDbConnection
    Dim myDataReader As OleDbDataReader
    Dim catidresults As String
    Dim catidarray() As String
    Dim goalresults As String
    Dim goalarray() As String
    Dim egoalresults As String
    Dim egoalarray() As String
    Dim goalidarray()
    Dim goalidstring
    'create the flags
    Dim flagdays As Boolean = False
    Dim flagtime1 As Boolean = False
    Dim flagtime2 As Boolean = False
    Dim flaglength As Boolean = False
    Dim flagpriority As Boolean = False
    Dim flagname As Boolean = False
    Dim flagToA As Boolean = False

    Dim flaggoal As Boolean = False
    Dim flaggoal1 As Boolean = False
    Dim flaggoal2 As Boolean = False
    Dim flaggoal3 As Boolean = False
    Dim flaggoal4 As Boolean = False
    Dim flaggoal5 As Boolean = False

    Dim repeat As String
    Dim eventid As String, sqleventid As String
    Dim edit As Boolean = My.Forms.FrmViewActivity.ActivityEdit

    Private Sub NewActivity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'retrieve the different categories from the database and the display in the 'Type of Activity' combo box
        'opens the database and establishes a connection
        Try
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\14ezinwokeb\OneDrive - Macmillan Academy\computer science project\StudyPlanner.mdb"
            connection.Open()
        Catch ex As Exception
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
            connection.Open()
        End Try
        command.Connection = connection
        Dim catsql As String
        'query to get all the rows from category
        catsql = "SELECT * from Category"
        command.CommandText = catsql
        Using myDataReader = command.ExecuteReader
            Do While myDataReader.Read()
                CBoxActType.Items.Add(myDataReader.Item("CatName")) 'adds each category to the combo box
                catidresults &= myDataReader.Item("CatID") & "," 'stores all the categories in a string separated by commas
            Loop
        End Using
        catidarray = Split(catidresults, ",") 'splits up the categories into an array where the commas are 
        ' edit = True
        If edit = True Then 'checks if an activity is being edited 
            Dim categoryid As Integer, length As Integer, priority As Boolean
            Dim actname = My.Forms.ActivityFrm.DGV.CurrentCell.Value.ToString 'this stores the name of the activity chosen locally
            TxtActName.Text = actname ''this sets the textbox for the activity name to the chosen name
            sqleventid = "SELECT * FROM Event WHERE Title='" & TxtActName.Text & "'" 'creates a query so that the eventID can be retrieved from the database
            command.CommandText = sqleventid
            Using myDataReader = command.ExecuteReader
                Do While myDataReader.Read()
                    eventid = myDataReader.Item("EventID") 'stores the eventid
                Loop
            End Using
            MsgBox(eventid)
            BtnCreateAct.Text = "Confirm Changes" 'create activity button displays a different message as a new activity isn't being created
            Dim sqleventgoal = "Select * FROM EventGoal where EventID =" & eventid & "" 'query to select all the goal ids from the eventgoal link table
            command.CommandText = sqleventgoal
            Using mydatareader = command.ExecuteReader
                Do While mydatareader.Read
                    egoalresults &= mydatareader.Item("GoalID") & "," 'stores the eventgoal
                Loop
            End Using
            egoalarray = Split(egoalresults, ",") 'transfers the results into an array
            Dim goalsql
            For i = 0 To egoalarray.Length - 2 'iterates through each item in the array 
                'query to select the name of the goal at the current position in the array where completed is also false
                goalsql = "Select * From Goal Where GoalID =" & egoalarray(i) & " AND Completed = False"
                command.CommandText = goalsql
                Using mydatareader = command.ExecuteReader
                    Do While mydatareader.Read
                        goalresults &= mydatareader.Item("Goal") & "," 'stores the uncompleted goals in a string
                        goalidstring &= mydatareader.Item("GoalID") & "," 'stores the goal ids of uncompleted goals in a string
                    Loop
                End Using
            Next
            goalidarray = Split(goalidstring, ",") 'transfers the goal ids into an arrray
            goalarray = Split(goalresults, ",") 'transfers the goals to an array
            For x = 1 To goalarray.Length - 1 'iterates through each goal and places it in the textboxes
                Me.Controls("TxtGoal" & x.ToString).Text = goalarray(x - 1)
            Next
            Dim eventsql = "SELECT * FROM Event Where Title='" & actname & "'" 'query to select all from event name
            command.CommandText = eventsql
            Using mydatareader = command.ExecuteReader
                Do While mydatareader.Read
                    'stores all the relevant values in their relevant variables
                    TxtDescription.Text = mydatareader.Item("Description")
                    DateTimePicker1.Value = mydatareader.Item("StartTime")
                    DateTimePicker2.Value = mydatareader.Item("EndTime")
                    TrackBar1.Value = mydatareader.Item("Priority")
                    CheckBoxReminder.Checked = mydatareader.Item("Reminder")
                    repeat = mydatareader.Item("Repeat")
                    length = mydatareader.Item("Length")
                    categoryID = mydatareader.Item("CatID")
                Loop
            End Using
            'transfers these values into the different containers on the form
            For x = 1 To repeat.Length 'iterates through each character in repeat
                'selects the correct day in the days listbox
                LboxDays.SetSelected(Convert.ToInt32(Mid(repeat, x, 1)), True)
            Next
            NumUDHour.Value = length \ 60 'puts the hours into the hour box for length
            NumUDMin.Value = length Mod 60 'puts the minutes into the min box for length
            Dim categoryquery = "Select * From Category Where CatID=" & categoryID & "" 'query to get the activity type
            command.CommandText = categoryquery
            Using mydatareader = command.ExecuteReader 'executes the query
                Do While mydatareader.Read
                    CBoxActType.SelectedItem = mydatareader.Item("CatName") 'selects the correct activity type from the combo-box
                Loop
            End Using
        End If
        connection.Close() 'closes the connection to the database
    End Sub
    Private Sub Allcompleted()

        If flaggoal1 Or flaggoal2 Or flaggoal3 Or flaggoal4 Or flaggoal5 = True Then 'checks if any goals have been given
            flaggoal = True 'changes the flag for all goals to true if one goal is given
        Else
            flaggoal = False 'sets the flag for all goals to false if no goals have been given
        End If
        'checks if the relevant flags for the regular times are true
        'if the flags are all true then the Create Activity Button is enabled allowing the user to create the new activity
        'The colour of the button changes to green to indicate to the user that the button can be pushed
        'if any of the flags are not clicked the btn is disabled and the colour is made red so the user knows that each field must be correctly filled
        If RbtnRegular.Checked = True Then
            If flagdays = True And flagtime1 = True And flaglength = True And flagname = True And flagToA = True And flaggoal = True Then
                BtnCreateAct.Enabled = True
                BtnCreateAct.BackColor = Color.LimeGreen
            Else
                BtnCreateAct.Enabled = False
                BtnCreateAct.BackColor = Color.Tomato
            End If
        End If
        'the same process is done but for the relevant flags for flexible times
        If RbtnFlexible.Checked = True Then
            If flagdays = True And flagtime1 = True And flagtime2 = True And flaglength = True And flagpriority = True And flagname = True And flagToA = True And flaggoal = True Then
                BtnCreateAct.Enabled = True
                BtnCreateAct.BackColor = Color.LimeGreen
            Else
                BtnCreateAct.Enabled = False
                BtnCreateAct.BackColor = Color.Tomato
            End If
        End If
        'the same process is done but for the relevant flags for self selected times
        If RbtnSelfSelect.Checked = True Then
            If flagname = True And flagToA = True And flaggoal = True Then
                BtnCreateAct.Enabled = True
                BtnCreateAct.BackColor = Color.LimeGreen
            Else
                BtnCreateAct.Enabled = False
                BtnCreateAct.BackColor = Color.Tomato
            End If
        End If
    End Sub

    Private Sub BtnCreateAct_Click(sender As Object, e As EventArgs) Handles BtnCreateAct.Click
        'connects to the database and opens it ready for interaction
        Try
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
            connection.Open()
        Catch ex As Exception
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\14ezinwokeb\OneDrive - Macmillan Academy\computer science project\StudyPlanner.mdb"
            connection.Open()
        End Try
        command.Connection = connection
        If edit = True Then 'checks if the activity is being edited or a new activity is being created
            'formats the input for repeated days
            repeat = "" 'clears repeat
            For i = 0 To 6
                If LboxDays.SelectedIndices.Contains(i) Then
                    repeat &= i
                End If
            Next
            'creates the query for updating the event table with all the values
            Dim sqleventupdate
            'changes the qeury depending on why radio button was selected, clearing or adding values to columns in the record
            If RbtnRegular.Checked = True Then
                sqleventupdate = "Update Event Set CatID =" & Convert.ToInt32(catidarray(CBoxActType.SelectedIndex)) & ", Title='" & TxtActName.Text.Trim & "', Description='" & TxtDescription.Text.Trim & "', StartTime=#" & DateTimePicker1.Value.ToShortTimeString & "#, "
                sqleventupdate &= "EndTime=#00:00:00#, Priority=10, Reminder=" & CheckBoxReminder.Checked & ", Repeat= '" & repeat & "', Length=" & (NumUDHour.Value * 60) + NumUDMin.Value & " Where EventID = " & Convert.ToInt32(eventid) & ""
            ElseIf RbtnFlexible.Checked = True Then
                sqleventupdate = "Update Event Set CatID =" & Convert.ToInt32(catidarray(CBoxActType.SelectedIndex)) & ", Title='" & TxtActName.Text.Trim & "', Description='" & TxtDescription.Text.Trim & "', StartTime=#" & DateTimePicker1.Value.ToShortTimeString & "#, "
                sqleventupdate &= "EndTime=#" & DateTimePicker2.Value.ToShortTimeString & "#, Priority=" & TrackBar1.Value & ", Reminder=" & CheckBoxReminder.Checked & ", Repeat= '" & repeat & "', Length=" & (NumUDHour.Value * 60) + NumUDMin.Value & " "
                sqleventupdate &= "Where EventID = " & Convert.ToInt32(eventid) & ""
            ElseIf RbtnSelfSelect.Checked = True Then
                sqleventupdate = "Update Event Set CatID =" & Convert.ToInt32(catidarray(CBoxActType.SelectedIndex)) & ", Title='" & TxtActName.Text.Trim & "', Description='" & TxtDescription.Text.Trim & "', StartTime=#00:00:00#,"
                sqleventupdate &= "EndTime=#00:00:00#, Priority=10, Reminder=" & CheckBoxReminder.Checked & ", Repeat= ' ', Length=0 Where EventID = " & Convert.ToInt32(eventid) & ""
            End If
            command.CommandText = sqleventupdate
            command.ExecuteNonQuery()
            Dim sqlgoalupdate, sqlegupdate
            Dim currentgoalsql, currentgoalid
            For x = 0 To 4 ' iterates through each goal
                'removes whitespaces preceding and proceeding text and if the textbox is not empty then the the context of the box are inputted in the database
                If Not String.IsNullOrWhiteSpace(Me.Controls("TxtGoal" & (x + 1).ToString).Text.Trim) Then 'checks if the textbox is empty or not 
                    If x < goalidarray.Length - 1 Then 'checks if it is an already existing goal which can be updated
                        sqlgoalupdate = "Update Goal Set Goal ='" & Me.Controls("TxtGoal" & (x + 1).ToString).Text.Trim & "' WHERE GoalID =" & goalidarray(x) & ""
                        command.CommandText = sqlgoalupdate
                        command.ExecuteNonQuery()
                    Else
                        'if a new goal has been inputted:
                        'query is created for inserting the new goal
                        sqlgoalupdate = "INSERT into Goal(Goal) values('" & Me.Controls("TxtGoal" & (x + 1).ToString).Text.Trim & "')"
                        command.CommandText = sqlgoalupdate
                        command.ExecuteNonQuery() 'executes the query 
                        'creates a query to get the goal id of the new inserted goal
                        currentgoalsql = "SELECT GoalID FROM Goal WHERE Goal ='" & Me.Controls("TxtGoal" & (x + 1).ToString).Text.Trim & "'"
                        command.CommandText = currentgoalsql
                        Using myDataReader = command.ExecuteReader
                            Do While myDataReader.Read
                                currentgoalid = myDataReader.Item("GoalID") 'stores the id 
                            Loop
                        End Using
                        'creates query to insert the goal id and event id into the link table
                        sqlegupdate = "Insert into EventGoal (EventID, GoalID) Values (" & eventid & "," & currentgoalid & ")"
                        command.CommandText = sqlegupdate
                        command.ExecuteNonQuery() 'executes the query
                    End If
                End If
            Next
            'creates query to delete all future versions which haven't been updated 
            Dim calendardelete As String = "Delete From Calendar Where EventID =" & Convert.ToInt32(eventid) & " And Caldate >=#" & Date.Today.ToString & "#"
            command.CommandText = calendardelete
            command.ExecuteNonQuery() 'executes query 
            'inputs into calendar
            If RbtnSelfSelect.Checked = False Then 'makes sure that either regular or flexible times was selected
                'initilises some variables
                Dim start
                Dim starttime As Date = DateTimePicker1.Value
                Dim endtime As Date = DateTimePicker2.Value
                Dim calendarquery As String = ""
                Dim allcalqueries()
                Dim weekstart As Date
                Dim daydiff = Weekday(Today, 2)
                weekstart = Today.AddDays(1 - daydiff) 'gets the date of the start of the current week
                Dim length = (NumUDHour.Value * 60) + NumUDMin.Value 'calculates the length of the activity
                Dim title = TxtActName.Text.Trim ' gets the title of the activity
                Randomize()
                If RbtnRegular.Checked = True Then
                    start = starttime.ToShortTimeString 'sets the start as being starttime as a priority of 10 indicates that it is a regular time
                Else
                    'calculates the start of the activity based on the random time range of 
                    start = starttime.AddMinutes(((endtime.Hour * 60) + endtime.Minute - (starttime.Hour * 60) + starttime.Minute) * Rnd()).ToShortTimeString
                End If
                For x = 0 To 52 'iterates through every week in the year
                    For i = 1 To repeat.Length 'iterates through each repeated day
                        daydiff = CInt(Mid(repeat, i, 1)) 'calculates the number of days from the start of the week
                        'creates query ot insert all the values into the database
                        calendarquery &= "Insert Into Calendar (EventID, Start, Caldate, Title, Length) Values (" & eventid & ",#" & start & "#,#" & weekstart.AddDays(daydiff) & "#,'" & title & "'," & length & ")" & "/-/"
                    Next
                    weekstart = weekstart.AddDays(7) 'goes to the start of the next week 
                Next
                allcalqueries = Split(calendarquery, "/-/") 'transfers all the queries to an array
                For i = 0 To allcalqueries.Length - 2
                    'iterates through each query in the array and executes them
                    command.CommandText = allcalqueries(i)
                    command.ExecuteNonQuery()
                Next
            End If
            My.Forms.FrmViewActivity.ActivityEdit = False
        Else
            Dim sqlname As String, name As String
            'query to check if there is an event which already has the inputted name
            sqlname = "SELECT * FROM Event WHERE Title='" & TxtActName.Text.Trim & "'"
            command.CommandText = sqlname
            Using myDataReader = command.ExecuteReader
                Do While myDataReader.Read()
                    name = myDataReader.Item("Title") 'stores the result of the query in the variable name
                Loop
            End Using
            'checks if name is empty
            If name = "" Then
                'name is empty so adding the new activity can continue
                Dim sqlevent
                Dim sqlgoals
                Dim sqleventgoals
                'formats the input for repeated days
                For i = 0 To 6
                    If LboxDays.SelectedIndices.Contains(i) Then
                        repeat &= i
                    End If
                Next
                'alters the query to insert into the relevant fields depending on which button was clicked
                If RbtnRegular.Checked = True Then
                    sqlevent = "INSERT Into Event (CatID, Title, Description, StartTime, Priority, Reminder, Repeat, EventType, Length)"
                    sqlevent &= " VALUES (" & Convert.ToInt32(catidarray(CBoxActType.SelectedIndex)) & ",'" & TxtActName.Text.Trim & "','-" & TxtDescription.Text.Trim & "',#" & DateTimePicker1.Value.ToShortTimeString & "#"
                    sqlevent &= "," & 10 & "," & CheckBoxReminder.Checked & ",'" & repeat & "','a'," & (NumUDHour.Value * 60) + NumUDMin.Value & ")"
                ElseIf RbtnFlexible.Checked = True Then
                    sqlevent = "INSERT Into Event (CatID, Title, Description, StartTime, EndTime, Priority, Reminder, Repeat, EventType, Length, Autoschedule)"
                    sqlevent &= " VALUES (" & Convert.ToInt32(catidarray(CBoxActType.SelectedIndex)) & ",'" & TxtActName.Text.Trim & "','-" & TxtDescription.Text.Trim & "',#" & DateTimePicker1.Value.ToShortTimeString & "#,"
                    sqlevent &= "#" & DateTimePicker2.Value.ToShortTimeString & "#," & TrackBar1.Value & "," & CheckBoxReminder.Checked & ",'" & repeat & "','a', " & (NumUDHour.Value * 60) + NumUDMin.Value & ", TRUE)"
                ElseIf RbtnSelfSelect.Checked = True Then
                    sqlevent = "INSERT Into Event (CatID, Title, Description, Reminder, EventType) VALUES (" & Convert.ToInt32(catidarray(CBoxActType.SelectedIndex)) & ",'" & TxtActName.Text.Trim & "','-" & TxtDescription.Text.Trim & "'," & CheckBoxReminder.Checked & ",'a')"
                End If
                'executes the query
                Debug.Write(sqlevent)
                command.CommandText = sqlevent
                command.ExecuteNonQuery()
                'query to get the eventid of the recently inputted activity
                sqleventid = "SELECT * FROM Event WHERE Title='" & TxtActName.Text & "'"
                command.CommandText = sqleventid
                Using myDataReader = command.ExecuteReader
                    Do While myDataReader.Read()
                        eventid = myDataReader.Item("EventID")
                    Loop
                End Using
                'iterates through each textbox for goal and 
                Dim currentgoalid As String, currentgoalsql As String
                For x = 1 To 5
                    'removes whitespaces preceding and proceeding text and if the textbox is not empty then the the context of the box are inputted in the database
                    If Me.Controls("TxtGoal" & x.ToString).Text.Trim <> "" Then
                        'query for inserting the each goal into the goal table
                        sqlgoals = "INSERT into Goal(Goal) values('" & Me.Controls("TxtGoal" & x.ToString).Text.Trim & "')"
                        command.CommandText = sqlgoals
                        command.ExecuteNonQuery() 'executes the query
                        'query to get the goalid from the newly inputted goal
                        currentgoalsql = "SELECT GoalID FROM Goal WHERE Goal ='" & Me.Controls("TxtGoal" & x.ToString).Text.Trim & "'"
                        command.CommandText = currentgoalsql
                        Using myDataReader = command.ExecuteReader
                            Do While myDataReader.Read
                                currentgoalid = myDataReader.Item("GoalID") 'stores the goalid
                            Loop
                        End Using
                        'query for executing the goal and the eventid into the eventgoal link table
                        sqleventgoals = "INSERT into EventGoal(EventID,GoalID) values('" & eventid & "','" & currentgoalid & "')"
                        command.CommandText = sqleventgoals
                        command.ExecuteNonQuery() 'executes the query
                    End If
                Next
                'code for inputting in calendar
                If RbtnSelfSelect.Checked = False Then 'makes sure that either regular or flexible times was selected
                    'initilises some variables
                    Dim start
                    Dim starttime As Date = DateTimePicker1.Value
                    Dim endtime As Date = DateTimePicker2.Value
                    Dim calendarquery As String = ""
                    Dim allcalqueries()
                    Dim weekstart As Date
                    Dim daydiff = Weekday(Today, 2)
                    weekstart = Today.AddDays(1 - daydiff) 'gets the date of the start of the current week
                    Dim length = (NumUDHour.Value * 60) + NumUDMin.Value 'calculates the length of the activity
                    Dim title = TxtActName.Text.Trim ' gets the title of the activity
                    Randomize()
                    Dim priority As Integer
                    Randomize()
                    If RbtnRegular.Checked = True Then
                        start = starttime.ToShortTimeString 'sets the start as being starttime as a priority of 10 indicates that it is a regular time
                    Else
                        'calculates the start of the activity based on the random time range of 
                        start = starttime.AddMinutes(((endtime.Hour * 60) + endtime.Minute - (starttime.Hour * 60) + starttime.Minute) * Rnd()).ToShortTimeString
                    End If
                    For x = 0 To 52 'iterates through every week in the year
                        For i = 1 To repeat.Length 'iterates through each repeated day
                            daydiff = CInt(Mid(repeat, i, 1)) 'calculates the number of days from the start of the week
                            'creates query ot insert all the values into the database
                            calendarquery &= "Insert Into Calendar (EventID, Start, Caldate, Title, Length) Values (" & eventid & ",#" & start & "#,#" & weekstart.AddDays(daydiff) & "#,'" & title & "'," & length & ")" & "/-/"
                        Next
                        weekstart = weekstart.AddDays(7) 'goes to the start of the next week 
                    Next
                    allcalqueries = Split(calendarquery, "/-/") 'transfers all the queries to an array
                    For i = 0 To allcalqueries.Length - 2
                        'iterates through each query in the array and executes them
                        command.CommandText = allcalqueries(i)
                        command.ExecuteNonQuery()
                    Next
                End If
                Me.Close()
            Else
                'if an activity with the name already exists then a message is outputted telling the user to change the name
                MsgBox("An Activity with this name already exists. Use a different name to create a new activity")
            End If
        End If
        connection.Close() 'connection to the database is closed
    End Sub

    Private Sub RbtnRegular_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnRegular.CheckedChanged
        'only shows the input fields relevant to the regular times choice. All irrelevant fields are made invisble
        LboxDays.Visible = True
        TrackBar1.Visible = False
        NumUDHour.Visible = True
        NumUDMin.Visible = True
        DateTimePicker1.Visible = True
        DateTimePicker2.Visible = False
        LblPriority.Visible = False
        LblActLen.Visible = True
        LblChooseDays.Visible = True
        LblChooseTime.Visible = True
        lbldash.Visible = False
        LblH.Visible = True
        LblM.Visible = True
        CheckBoxReminder.Visible = True
        Allcompleted()
    End Sub
    Private Sub RbtnFlexible_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnFlexible.CheckedChanged
        'only shows the input fields relevant to the flexible times choice. All irrelevant fields are made invisble
        LboxDays.Visible = True
        TrackBar1.Visible = True
        NumUDHour.Visible = True
        NumUDMin.Visible = True
        DateTimePicker1.Visible = True
        DateTimePicker2.Visible = True
        LblPriority.Visible = True
        LblActLen.Visible = True
        LblChooseDays.Visible = True
        LblChooseTime.Visible = True
        lbldash.Visible = True
        LblH.Visible = True
        LblM.Visible = True
        CheckBoxReminder.Visible = True
        Allcompleted()
    End Sub

    Private Sub RbtnSelfSelect_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnSelfSelect.CheckedChanged
        'only shows the input fields relevant to the self selected times choice. All irrelevant fields are made invisble
        LboxDays.Visible = False
        TrackBar1.Visible = False
        NumUDHour.Visible = False
        NumUDMin.Visible = False
        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False
        LblPriority.Visible = False
        LblActLen.Visible = False
        LblChooseDays.Visible = False
        LblChooseTime.Visible = False
        lbldash.Visible = False
        LblH.Visible = False
        LblM.Visible = False
        CheckBoxReminder.Visible = True
        Allcompleted()
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LboxDays.SelectedIndexChanged
        'validates flagdays as true if a day is chosen
        If LboxDays.SelectedIndex = -1 Then
            flagdays = False
        Else
            flagdays = True
        End If
        Allcompleted() ' calls the function to check if all flags have been filled
    End Sub
    Private Sub TrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar1.ValueChanged
        If TrackBar1.Value <> 0 Then 'sets the priority flag to be true if the trackbar has a value
            flagpriority = True
        Else
            flagpriority = False
        End If
        Allcompleted() ' calls the function to check if all flags have been filled
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        flagtime1 = True
        Allcompleted() ' calls the function to check if all flags have been filled
    End Sub
    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        'checks if the end hour is greater than the starting hour. Sets flag time to true if so
        If DateTimePicker2.Value > DateTimePicker1.Value Then
            flagtime2 = True
        Else
            flagtime2 = False
        End If
        Allcompleted() ' calls the function to check if all flags have been filled
    End Sub
    Private Sub CBoxActType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxActType.TextChanged
        If CBoxActType.SelectedIndex = -1 Then 'checks if an index has been selected
            flagToA = False 'sets flag to false if now index has been selected
        Else
            flagToA = True 'sets to true if a value is selected
        End If
        Allcompleted() ' calls the function to check if all flags have been filled
    End Sub
    Private Sub TxtActName_TextChanged(sender As Object, e As EventArgs) Handles TxtActName.TextChanged
        'removes whitespace and checks if the txtbox for name has been filled
        If Not String.IsNullOrWhiteSpace(TxtActName.Text) Then
            flagname = True
        Else
            flagname = False
        End If
        Allcompleted() ' calls the function to check if all flags have been filled
    End Sub

    Private Sub InfoRT_Click(sender As Object, e As EventArgs) Handles InfoRT.Click
        MsgBox("You pick a regular time slot and the activity will always be scheduled for that time")
    End Sub

    Private Sub InfoFT_Click(sender As Object, e As EventArgs) Handles InfoFT.Click
        MsgBox("The computer will generate sessions for you in your chosen time frame. If this is picked then the activity can be rearranged if a higher priority task must be completed.")
    End Sub

    Private Sub InfoSST_Click(sender As Object, e As EventArgs) Handles InfoSST.Click
        MsgBox("You will pick a time for the activity straight from the calendar. This is best for activities which are done at completely random times")
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumUDHour.ValueChanged
        'checks if the minute input is 0
        If NumUDMin.Value = 0 Then
            'checks if hour is 0 
            If NumUDHour.Value = 0 Then
                'sets the length flag to false if no time length is given
                flaglength = False
            Else
                'sets the length flag to false if a time length is given
                flaglength = True
            End If
        End If
        Allcompleted() ' calls the function to check if all flags have been filled
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumUDMin.ValueChanged
        If NumUDHour.Value = 0 Then
            If NumUDMin.Value = 0 Then
                flaglength = False 'sets length flag to false if a time length is given
            Else
                flaglength = True 'sets length flag to true if a time length is given
            End If
        Else
            flaglength = True 'sets length flag to true if the hour value is already given
        End If
        Allcompleted() ' calls the function to check if all flags have been filled
    End Sub

    Private Sub TxtGoal1_TextChanged(sender As Object, e As EventArgs) Handles TxtGoal1.TextChanged
        'changes the flag to true if there is text in the textbox
        If Not String.IsNullOrWhiteSpace(TxtGoal1.Text) Then
            flaggoal1 = True
        Else
            flaggoal1 = False
        End If
        Allcompleted() ' calls the function to check if all flags have been filled
    End Sub

    Private Sub TxtGoal2_TextChanged(sender As Object, e As EventArgs) Handles TxtGoal2.TextChanged
        'changes the flag to true if there is text in the textbox
        If Not String.IsNullOrWhiteSpace(TxtGoal2.Text) Then
            flaggoal2 = True
        Else
            flaggoal2 = False
        End If
        Allcompleted() ' calls the function to check if all flags have been filled
    End Sub

    Private Sub TxtGoal3_TextChanged(sender As Object, e As EventArgs) Handles TxtGoal3.TextChanged '
        'changes the flag to true if there is text in the textbox
        If Not String.IsNullOrWhiteSpace(TxtGoal3.Text) Then
            flaggoal3 = True
        Else
            flaggoal3 = False
        End If
        Allcompleted() ' calls the function to check if all flags have been filled
    End Sub

    Private Sub TxtGoal4_TextChanged(sender As Object, e As EventArgs) Handles TxtGoal4.TextChanged
        'changes the flag to true if there is text in the textbox
        If Not String.IsNullOrWhiteSpace(TxtGoal4.Text) Then
            flaggoal4 = True
        Else
            flaggoal4 = False
        End If
        Allcompleted() ' calls the function to check if all flags have been filled
    End Sub

    Private Sub TxtGoal5_TextChanged(sender As Object, e As EventArgs) Handles TxtGoal5.TextChanged
        'changes the flag to true if there is text in the textbox
        If Not String.IsNullOrWhiteSpace(TxtGoal5.Text) Then
            flaggoal5 = True
        Else
            flaggoal5 = False
        End If
        Allcompleted() ' calls the function to check if all flags have been filled
    End Sub
End Class