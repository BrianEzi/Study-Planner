Imports System.Text.RegularExpressions
Imports System.Data.OleDb

Public Class Login
    'initialise variables
    Dim command As New OleDb.OleDbCommand
    Dim connection As New OleDb.OleDbConnection
    Dim myDataReader As OleDbDataReader
    Dim results As String
    Dim flagformat As Boolean = False
    Dim flagexists As Boolean = False
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function emailchecker(ByVal emailaddress As String)
        'sets the pattern for which all email addresses abide to
        Dim pattern As String = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        'creates a variable storing the results of the whether the email inputted and the pattern match
        Dim emailmatch As Match = Regex.Match(TxtEmail.Text, pattern)
        'connects to the database and opens it ready for use
        Try
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\14ezinwokeb\OneDrive - Macmillan Academy\computer science project\StudyPlanner.mdb"
            connection.Open()
        Catch ex As Exception
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
            connection.Open()
        End Try
        command.Connection = connection
        Dim sql As String
        'creates sql query to check if the email exists in the databae
        sql = "SELECT * from Login WHERE Email='" & TxtEmail.Text & "'"
        command.CommandText = sql
        Using myDataReader = command.ExecuteReader
            Do While myDataReader.Read()
                results = myDataReader.Item("Email")
            Loop
        End Using
        connection.Close() 'close the connection as databae no longer needs to be accessed
        'if the email exists and the variable flagexists indicates this
        If results <> "" Then
            flagexists = True
        Else
            flagexists = False
        End If
        'if the email inputted matches the correct pattern/format then the variable flagformat indicates this
        If emailmatch.Success Then
            flagformat = True
        Else
            flagformat = False
        End If
        'if both flags are true then the function returns the value true otherwise it returns the value false
        If flagformat = True And flagexists = True Then
            emailchecker = True
        Else
            emailchecker = False
        End If
    End Function
    Private Function passwordchecker(ByVal password As String)
        'establishes the connection and opens the database ready for use
        Try
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\14ezinwokeb\OneDrive - Macmillan Academy\computer science project\StudyPlanner.mdb"
            connection.Open()
        Catch ex As Exception
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
            connection.Open()
        End Try
        command.Connection = connection
        Dim sql As String
        'creates sql query to select all values for the inputted email
        sql = "SELECT * from Login WHERE Email='" & TxtEmail.Text & "' "
        command.CommandText = sql
        Using myDataReader = command.ExecuteReader
            Do While myDataReader.Read()
                results = myDataReader.Item("Pwd") 'the value for password is retrieved
            Loop
        End Using
        connection.Close() 'connection is closed as databae no longer needs to be accessed
        'checks if the password in the database matches the password that was inputted and the function returns true or false depending on the outcome
        If results = TxtPassword.Text Then
            passwordchecker = True
        Else passwordchecker = False
        End If
    End Function
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim emailcheck = emailchecker(TxtEmail.Text)
        'if the inputted email did not exist then error message is worked out
        If emailcheck = False Then
            If flagformat = False Then
                MsgBox("The email is in the wrong format") '
            End If
            If flagexists = False Then
                MsgBox("An account with this email does not exist")
            End If
        End If
        Dim passwordcheck = passwordchecker(TxtPassword.Text)
        If passwordcheck = False Then
            MsgBox("Password does not match email address")
        End If
        If emailcheck = True And passwordcheck = True Then
            'load homepage
            MonthFrm.Show()
            ' Me.Close()
        End If
    End Sub
    Private Sub LinkPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkPassword.LinkClicked
        'load forgot password form
        ForgotPassword.Show()
    End Sub
    Private Sub LinkNewAcc_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkNewAcc.LinkClicked
        FrmCreateAcc.Show() 'shows from for creating a new account
    End Sub
End Class