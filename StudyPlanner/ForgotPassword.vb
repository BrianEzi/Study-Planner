Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class ForgotPassword
    'initialise variables
    Dim emailflag As Boolean = False
    Dim connection As New OleDbConnection
    Dim mydatareader As OleDbDataReader
    Dim command As New OleDbCommand
    Dim results As String = ""
    Dim flagexists As Boolean = False
    Dim flagformat As Boolean = False
    Dim secq As String, secA As String, password As String
    Private Sub BtnGetPass_Click(sender As Object, e As EventArgs) Handles BtnGetPass.Click
        If flagexists And flagformat = True Then 'checks the email given is valid
            If TxtSecA.Text = secA Then 'checks if the security answer is correct
                MsgBox("Your password is:" & password) 'reveals the password to the user
                'closes the form and opens a new
                Login.Show()
                Me.Close()
            Else
                MsgBox("Wrong Answer") 'prompts the user if the answer was wrong
            End If
        Else
            MsgBox("Enter a valid email") 'prompts the user that email was invalid
        End If
    End Sub
    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtSecQ.Enabled = False 'disables the textbox
    End Sub

    Private Sub ChkboxConfirm_CheckedChanged(sender As Object, e As EventArgs) Handles ChkboxConfirm.CheckedChanged
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
        If Not String.IsNullOrEmpty(TxtEmail.Text.Trim) Then 'checks if the textbox has data in it
            command.Connection = connection
            Dim sql As String
            'creates sql query to check if the email exists in the databae
            sql = "SELECT * from Login WHERE Email='" & TxtEmail.Text & "'"
            command.CommandText = sql
            Using myDataReader = command.ExecuteReader
                Do While myDataReader.Read()
                    results = myDataReader.Item("Email")
                    secq = myDataReader.Item("SecQ")
                    secA = myDataReader.Item("SecA")
                    password = myDataReader.Item("Pwd")
                Loop
            End Using
            connection.Close() 'close the connection as database no longer needs to be accessed       
            'if the email inputted matches the correct pattern/format then the variable flagformat indicates this 
            'or an error messgage is given 
            If emailmatch.Success Then
                flagformat = True
            Else
                MsgBox("Email is in wrong format")
                ChkboxConfirm.Checked = False 'unchecks the textbox 
            End If
            'if the email exists the variable flagexists indicates this or an error message is given
            If results <> "" Then
                flagexists = True
            Else
                MsgBox("No account has been registered to this email")
                ChkboxConfirm.Checked = False 'unchecks the textbox 
            End If
            TxtSecQ.Text = secq
        Else
            MsgBox("Enter an email") 'indicates that it is empty to the user and prompts them to fill it in
            ChkboxConfirm.Checked = False 'unchecks the textbox 
        End If
        connection.Close()
    End Sub
End Class