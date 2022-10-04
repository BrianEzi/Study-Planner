Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Public Class FrmCreateAcc
    'initialise variables
    Dim lengthflag As Boolean = False
    Dim uppercaseflag As Boolean = False
    Dim symbolflag As Boolean = False
    Dim numberflag As Boolean = False
    Dim command As New OleDb.OleDbCommand
    Dim connection As New OleDb.OleDbConnection
    Dim myDataReader As OleDbDataReader
    Dim results As String
    Dim flagformat As Boolean = False
    Dim flagnew As Boolean = False
    Dim flagsecq As Boolean = False
    Dim flagseca As Boolean = False
    Dim flagrepeat As Boolean = False
    Dim lenadded As Boolean = False
    Dim capadded As Boolean = False
    Dim symadded As Boolean = False
    Dim numadded As Boolean = False
    Private Function passwordchecker(ByVal password As String) 'checks if the password has passed the necessary criteria
        If lengthflag = True And uppercaseflag = True And symbolflag = True And numberflag = True Then
            passwordchecker = True
        Else
            passwordchecker = False
        End If
    End Function

    Private Function emailchecker(ByVal email As String)
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
        connection.Close() 'close the connection as database no longer needs to be accessed
        'if the email is new the variable flagnew indicates this
        If results = "" Then
            flagnew = True
        End If
        'if the email inputted matches the correct pattern/format then the variable flagformat indicates this
        If emailmatch.Success Then
            flagformat = True
        End If
        'if both flags are true then the function returns the value true otherwise it returns the value false
        If flagformat = True And flagnew = True Then
            emailchecker = True
        Else
            emailchecker = False
        End If
    End Function
    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged
        Dim password As String = TxtPassword.Text 'stores the inputted password in the variable password
        'checks if the length of the password is at least 8 characters
        If password.Length >= 8 Then
            lengthflag = True 'length flag is set as true to indicate that the password is at least 8 characters long
            lbllen.ForeColor = Color.Green ' the colour of the font of the label for length Is changed to green
            If lenadded = False Then 'checks if the progress bar has already been edited for this requirement
                ProgressBar1.Value += 25 'if it hasn't been edited fro this requirement, then the value is increased by a quarter of the max value
                lenadded = True 'indicates that the progress has been edited for this requirement so no longer needs to be increased
            End If
        Else
            lengthflag = False 'length flag is indicated as false if the password is not long enough
            lbllen.ForeColor = Color.Red 'the colour of the font of the label for length is changed to red
            If lenadded = True Then 'checks if the progress bar has already been edited for this requirement
                ProgressBar1.Value -= 25 'if it hasn been edited fro this requirement, then the value is decreased by a quarter of the max value
                lenadded = False 'indicates that the progress hasn't been edited for this requirement so now needs to be increased
            End If
        End If
        'checks if the password contains a capital letter
        If password.IndexOfAny("ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray) <> -1 Then
            uppercaseflag = True 'sets flag to true to indicate that there is an uppercase character
            lblcap.ForeColor = Color.Green 'changes the colour of the label's font to green to inform the user that they have met this criteria
            If capadded = False Then 'checks if the progressbar has already been increased for this criteria
                ProgressBar1.Value += 25 'increases the progress by 25 (max is 100)
                capadded = True 'sets capadded to true to indicate that the progress bar has been increased
            End If
        Else
            uppercaseflag = False 'sets the flag to false to indincate that there is no uppercase character
            lblcap.ForeColor = Color.Red 'changes the colour of the label's font to red to inform the user that they have not met this criteria
            If capadded = True Then 'checks if the progressbar has already been increased for this criteria
                ProgressBar1.Value -= 25 'decreases the progress bar by 25 (max is 100)
                capadded = False 'sets capadded to false to indicate that the progress bar has not been increased
            End If
        End If
        'checks if the password contains a symbol
        If password.IndexOfAny("[~`!@#$%^&*()-+=|{}':;.,<>/?]".ToCharArray) <> -1 Then
            symbolflag = True 'sets flag to true to indicate that there is a symbol in the password
            lblsym.ForeColor = Color.Green 'changes the colour of the label's font to green to inform the user that they have met this criteria
            If symadded = False Then 'checks if the porgressbar has already been icreased for this criteria
                ProgressBar1.Value += 25 'increases the progress by 25 (max is 100)
                symadded = True 'sets symadded to true to indicate that the progress bar has been increased
            End If
        Else
            symbolflag = False 'sets the flag to false to indincate that there is no symbol in the password
            lblsym.ForeColor = Color.Red 'changes the colour of the label's font to red to inform the user that they have not met this criteria
            If symadded = True Then 'checks if the progressbar has already been increased for this criteria
                ProgressBar1.Value -= 25 'decreases the progress bar by 25 (max is 100)
                symadded = False 'sets symadded to false to indicate that the progress bar has not been increased
            End If
        End If
        'checks if the password contains a number
        If password.IndexOfAny("0123456789".ToCharArray) <> -1 Then
            numberflag = True 'sets flag to true to indicate that there is a number in the password
            lblnum.ForeColor = Color.Green 'changes the colour of the label's font to green to inform the user that they have met this criteria
            If numadded = False Then 'checks if the porgressbar has already been icreased for this criteria
                ProgressBar1.Value += 25 'increases the progress by 25 (max is 100)
                numadded = True 'sets numadded to true to indicate that the progress bar has been increased
            End If
        Else
            numberflag = False 'sets flag to false to indicate that there is no number in the password
            lblnum.ForeColor = Color.Red 'changes the colour of the label's font to red to inform the user that they have not met this criteria
            If numadded = True Then 'checks if the progressbar has already been increased for this criteria
                ProgressBar1.Value -= 25 'decreases the progress bar by 25 (max is 100)
                numadded = False 'sets numadded to false to indicate that the progress bar has not been increased
            End If
        End If
    End Sub

    Private Sub BtnCreateAcc_Click(sender As Object, e As EventArgs) Handles BtnCreateAcc.Click
        'checks if all fields have been correctly filled
        If passwordchecker(TxtPassword.Text) = True And emailchecker(TxtEmail.Text) = True And flagsecq = True And flagseca = True And TxtRepeat.Text = TxtPassword.Text Then
            Dim sql
            Try
                connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\14ezinwokeb\OneDrive - Macmillan Academy\computer science project\StudyPlanner.mdb"
                connection.Open()
            Catch ex As Exception
                connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
                connection.Open()
            End Try
            command.Connection = connection
            'query to insert values is created
            sql = "INSERT into Login Values ('" & TxtEmail.Text & "','" & TxtPassword.Text & "','" & CBoxSecQ.SelectedItem.ToString & "','" & TxtSecA.Text & "')"
            command.CommandText = sql
            command.ExecuteNonQuery() 'values are inserted
            connection.Close()
            'form is closed
            Login.Show()
            Me.Close()
        Else
            'if fields have been incorrectly filled then an appropriate error message is outputted
            If flagnew = False Then 'if the email already exists
                MsgBox("The email address inputted already has an account attached to it. Use a different email address or log in.")
            ElseIf flagformat = False Then 'if the format is wrong
                MsgBox("The email address inputted is in the wrong format.")
            End If
            If passwordchecker(TxtPassword.Text) = False Then 'if the password does not meet criteria
                MsgBox("Password does not meet criteria")
            End If
            If TxtRepeat.Text <> TxtPassword.Text Then 'if the repeated password does not match
                MsgBox("Repeated password does not match")
            End If
            If flagsecq = False Then 'if no security question hasb een chosen
                MsgBox("Choose a security question")
            End If
            If flagseca = False Then 'if no security answer has been inputted
                MsgBox("Input an answer to the security question")
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxSecQ.SelectedIndexChanged
        flagsecq = True 'indicates that a security question has been picked
    End Sub

    Private Sub TxtSecA_TextChanged(sender As Object, e As EventArgs) Handles TxtSecA.TextChanged
        If Not String.IsNullOrWhiteSpace(TxtSecA.Text.Trim) Then 'checks if the text box is empty
            flagseca = True 'indicates that it has been filled
        Else
            flagseca = False 'indicates it is empty
        End If
    End Sub

    Private Sub LinkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLogin.LinkClicked
        Login.Show() 'goes back to login form
        Me.Close()
    End Sub
End Class