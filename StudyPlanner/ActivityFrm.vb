Imports System.Data.OleDb
Public Class ActivityFrm
    Dim command As New OleDbCommand
    Dim connection As New OleDb.OleDbConnection
    Dim mydatareader As OleDbDataReader
    Dim catnameresultstring As String
    Dim catnameresults()
    Dim catid()
    Dim catidresultstring
    Dim colourstring
    Dim colour()
    Public Categoryedit As Boolean = False
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        FrmViewActivity.Show()
    End Sub

    Private Sub BtnNewAct_Click(sender As Object, e As EventArgs) Handles BtnNewAct.Click
        NewActivity.Show()
    End Sub

    Private Sub ActivityFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\14ezinwokeb\OneDrive - Macmillan Academy\computer science project\StudyPlanner.mdb"
            connection.Open()
        Catch ex As Exception
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
            connection.Open()
        End Try
        command.Connection = connection
        Dim query = "select * from Category" 'query to select all the categories
        command.CommandText = query
        Using mydatareader = command.ExecuteReader
            Do While mydatareader.Read
                catnameresultstring &= mydatareader.Item("Catname") & "," 'stores all the cateogy names in a string
                catidresultstring &= mydatareader.Item("CatID") & "," 'stores all the category ids in a string
                colourstring &= mydatareader.Item("Catcolour") & "," ' stores all the category colours in a string
            Loop
        End Using
        catnameresults = Split(catnameresultstring, ",") 'transfers the names into an array
        catid = Split(catidresultstring, ",") 'transfers the ids into an array
        colour = Split(colourstring, ",") 'transfers the colours into an array
        For i = 0 To catnameresults.Length - 2 'iterates through each item in the name array
            ListBox1.Items.Add(catnameresults(i)) 'adds the current category to the listbox
        Next
        connection.Close()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\14ezinwokeb\OneDrive - Macmillan Academy\computer science project\StudyPlanner.mdb"
            connection.Open()
        Catch ex As Exception
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bezin_1\OneDrive\Documents\Computer Science Project\StudyPlanner.mdb"
            connection.Open()
        End Try
        command.Connection = connection
        Dim query As String 'intialises the query
        DGV.Rows.Clear()
        Dim colourconvert As New ColorConverter
        Dim x As Integer = 0
        For i = 0 To ListBox1.Items.Count - 1 'iterates through all the categories
            If ListBox1.SelectedIndices.Contains(i) Then 'checks if the a selected index has been reached
                query = "Select * From Event Where CatID = " & catid(i) & " AND Eventtype = 'a' " 'creates query to selects all events which have the chosen categories
                command.CommandText = query
                Using mydatareader = command.ExecuteReader 'executes the query
                    Do While mydatareader.Read
                        DGV.Rows.Add(mydatareader.Item("Title")) 'adds a row to datagrid and inputs the title of the event
                        DGV.Rows(x).Cells(0).Style.BackColor = colourconvert.ConvertFromString(colour(i)) 'sets the background of the cell to be the colour of the relevant category
                        x += 1
                    Loop
                End Using
            End If
        Next 'goes to the next item in the listbox
        connection.Close() 'closes the connection
    End Sub
    Private Sub BtnNewCat_Click(sender As Object, e As EventArgs) Handles BtnNewCat.Click
        Category.Show() 'opens the category form
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If ListBox1.SelectedIndex <> -1 Then 'makes sure a category ahs been selected
            Categoryedit = True 'indicates to the category form that it shoudl go into edit mode
            Category.Show() 'opens the category form
        End If
    End Sub
End Class