Imports System.Data.OleDb


Public Class Form1

    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtusername.Text = "david" And txtpassword.Text = "david" Then
            grplogin.Visible = False
        Else
            MessageBox.Show("You have entered Incorrect login details", "Invlaid Login", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtusername.Clear()
        txtpassword.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim result = MessageBox.Show("Are you sure you would like to exit?", "Close",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim result = MessageBox.Show("Are you sure you would like to exit?", "Close",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result = MessageBox.Show("Are you sure you would like to exit?", "Close",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result = MessageBox.Show("Are you sure you would like to exit?", "Close",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_sparesDataSet.Stock_In' table. You can move, or remove it, as needed.
        Me.Stock_InTableAdapter.Fill(Me.Db_sparesDataSet.Stock_In)
        'TODO: This line of code loads data into the 'Db_sparesDataSet.New_Spare_Part' table. You can move, or remove it, as needed.
        Me.New_Spare_PartTableAdapter.Fill(Me.Db_sparesDataSet.New_Spare_Part)
        'TODO: This line of code loads data into the 'Db_sparesDataSet.Inventory_list' table. You can move, or remove it, as needed.
        Me.Inventory_listTableAdapter.Fill(Me.Db_sparesDataSet.Inventory_list)
        'TODO: This line of code loads data into the 'Db_sparesDataSet.Total_price' table. You can move, or remove it, as needed.
        Me.Total_priceTableAdapter.Fill(Me.Db_sparesDataSet.Total_price)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnadding_Click(sender As Object, e As EventArgs) Handles btnadding.Click
        InventoryListBindingSource.AddNew()
        TotalPriceBindingSource.AddNew()
    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        TotalPriceBindingSource.MovePrevious()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        TotalPriceBindingSource.MoveNext()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        On Error GoTo Feedback
        Me.Validate()
        Me.TotalPriceBindingSource.EndEdit()
        Me.Total_priceTableAdapter.Update(Me.Db_sparesDataSet)
Feedback:
        MsgBox("Checkyour record", vbInformation)
        Exit Sub
    End Sub

    Private Sub btnend_Click(sender As Object, e As EventArgs) Handles btnend.Click
        Dim result = MessageBox.Show("Are you sure you would like to exit?", "Close",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnnewsave_Click(sender As Object, e As EventArgs) Handles btnnewsave.Click
        On Error GoTo Feedback
        Me.Validate()
        Me.TotalPriceBindingSource.EndEdit()
        Me.Total_priceTableAdapter.Update(Me.Db_sparesDataSet)
Feedback:
        MsgBox("Checkyour record", vbInformation)
        Exit Sub
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        NewSparePartBindingSource.AddNew()
        InventoryListBindingSource.AddNew()
        TotalPriceBindingSource.AddNew()
    End Sub

    Private Sub btntoexit_Click(sender As Object, e As EventArgs) Handles btntoexit.Click
        Dim result = MessageBox.Show("Are you sure you would like to exit?", "Close",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnnewentry_Click(sender As Object, e As EventArgs) Handles btnnewentry.Click

    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click

    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click

    End Sub

    Private Sub btntoend_Click(sender As Object, e As EventArgs) Handles btntoend.Click
        Dim result = MessageBox.Show("Are you sure you would like to exit?", "Close",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub
End Class
