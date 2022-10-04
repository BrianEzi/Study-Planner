Imports System.Data.OleDb
Public Class Category
    'initialise variables
    Dim nameflag As Boolean = False
    Dim colour As String = Color.White.ToArgb.ToString
    Dim command As New OleDbCommand
    Dim connection As New OleDbConnection
    Dim mydatareader As OleDbDataReader
    Dim catname
    Dim Edit = My.Forms.ActivityFrm.Categoryedit
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'opens the connection to the database
        Try
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\14ezinwokeb\OneDrive - Macmillan Academy\computer science project\StudyPlanner.mdb"
            connection.Open()
        Catch ex As Exception
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
            connection.Open()
        End Try
        command.Connection = connection
        'checks if the values inputted are in the correct format
        If nameflag = True Then
            'checks if the user is editing an existing category or if they are creating a new one
            If Edit = True Then
                'if they are editing an existing category a query is created to update the record with the changes
                Dim editquery = "UPDATE Category Set Catname ='" & TextBox1.Text & "', Catcolour = '" & colour & "' Where Catname = '" & catname & "'"
                command.CommandText = editquery
                command.ExecuteNonQuery() 'executes the update query
                'sets the result of the dialog to OK and closes this form
                Me.DialogResult = DialogResult.OK
                Me.Close() 'closes the dialogbox
                ActivityFrm.Refresh()
            Else
                'if they are creating a new category an query is created to insert a new record with the new category
                Dim newquery = "Insert into Category(CatName, Catcolour) VALUES('" & TextBox1.Text.Trim & "', '" & colour & "')"
                command.CommandText = newquery
                command.ExecuteNonQuery() 'execute sthe insert query
                'closes this form
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close() 'closes the dialogbox  
                ActivityFrm.Refresh()
            End If
        Else
            MsgBox("Enter a name") 'if incorrectly formatted, this message is given to the user so they know why it didn't work
        End If
        connection.Close()
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        'checks if the category is being edited
        If Edit = True Then
            'if the category exists and is being edited then the cancel button acts as a delete button 
            'opens the database and connects to it 
            Try
                connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\14ezinwokeb\OneDrive - Macmillan Academy\computer science project\StudyPlanner.mdb"
                connection.Open()
            Catch ex As Exception
                connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
                connection.Open()
            End Try
            command.Connection = connection
            Dim query = "Select * From Category Where Catname ='" & catname & "'" 'query to retrieve the category id
            command.CommandText = query
            Dim catid
            Using mydatareader = command.ExecuteReader
                Do While mydatareader.Read
                    catid = mydatareader.Item("CatID") 'stores the category id 
                Loop
            End Using
            query = "Update Event Set CatID = 6 Where CatID =" & catid & "" 'query to update the event wiht the delted category
            command.CommandText = query
            command.ExecuteNonQuery() 'updates the record
            query = "Delete From Category Where CatName = '" & catname & "'" 'a query is made to delete the record
            command.CommandText = query
            command.ExecuteNonQuery() 'deletes the record
            connection.Close() 'closes the connection
            'closes the form
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()
            ActivityFrm.Refresh()
        Else
            'if the form isn't being 
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()
        End If
    End Sub
    Private Sub BtnColour_Click(sender As Object, e As EventArgs) Handles BtnColour.Click
        ColorDialog1.ShowDialog() 'brings up the colour picker
        'checks if a colour has been picked
        If Not ColorDialog1.Color.IsEmpty Then
            'sets the variable colour to the chosen colour
            colour = ColorDialog1.Color.ToArgb.ToString
            BtnColour.BackColor = ColorDialog1.Color 'changes the background of the colour to the chosen colour
        Else
            'resets the colour variable to white if no colour has been picked
            colour = Color.White.ToArgb.ToString
            BtnColour.BackColor = SystemColors.Control 'changes teh background of the button back to the default
        End If
    End Sub

    Private Sub Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'checks if the category is being edited
        If Edit = True Then
            If catname = "No Category" Then
                Cancel_Button.Enabled = False
            End If
            catname = My.Forms.ActivityFrm.ListBox1.SelectedItem.ToString
            'if the category is being edited then changes are made to the form
            Cancel_Button.Text = "Delete" 'cancel button shows delete instead of cancel
            TextBox1.Text = catname 'the name textbox now shows the name of the category being edited
            ' a connection to the database is estabished
            Try
                connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\14ezinwokeb\OneDrive - Macmillan Academy\computer science project\StudyPlanner.mdb"
                connection.Open()
            Catch ex As Exception
                connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
                connection.Open()
            End Try
            command.Connection = connection
            'query is created to ger the information from the category
            Dim query As String = "SELECT * FROM Category Where Catname ='" & catname & "'"
            command.CommandText = query
            Dim colourconvert As New ColorConverter
            Using mydatareader = command.ExecuteReader 'query is executed
                Do While mydatareader.Read
                    colour = mydatareader.Item("CatColour") 'colour is given the value of hte category colour
                    BtnColour.BackColor = colourconvert.ConvertFromString(colour)  'sets the background colour of the activity to the colour in the database if there is one
                    ColorDialog1.Color = colourconvert.ConvertFromString(colour) 'picks the colour in the colordialog
                Loop
            End Using
            connection.Close()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\14ezinwokeb\OneDrive - Macmillan Academy\computer science project\StudyPlanner.mdb"
            connection.Open()
        Catch ex As Exception
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
            connection.Open()
        End Try
        command.Connection = connection
        'query to check if there is already an existing category with the inputted name
        Dim query As String = "select * from category where Catname = '" & TextBox1.Text.Trim & "'"
        command.CommandText = query
        Dim results = "" 'creates a variable results to hold the result of the query 
        Using mydatareader = command.ExecuteReader
            Do While mydatareader.Read
                results = mydatareader.Item("Catname") 'stores the result
            Loop
        End Using
        'checks if there is a clash in names with an existing category
        If results = "" Or (results = catname And Edit = True) Then
            If Not String.IsNullOrWhiteSpace(TextBox1.Text) Then
                nameflag = True
            End If
        Else
            nameflag = False
        End If
        connection.Close()
    End Sub
End Class
