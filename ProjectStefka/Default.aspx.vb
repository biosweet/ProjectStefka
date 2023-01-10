
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.EnterpriseServices

Partial Class _Default
    Inherits Page

    Dim connect As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=traveldb;Integrated Security=True")


    Private txtdestinationID As Object
    Private txtdestinationname As Object
    Private txtdays As Object
    Private txtbudget As Object
    Private txtattraction As Object
    Private txthotel As Object





    Protected Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

        Dim DestinationID As Integer = txtdestinationID.Text
        Dim DestinationName As String = txtdestinationname.Text
        Dim Hotel As String = txthotel.Text
        Dim Days As Integer = txtdays.Text
        Dim Budget As Integer = txtbudget.Text
        Dim Attraction As String = txtattraction.Text

        connect.Open()
        Dim command As New SqlCommand("Insert into TravelPlanner_tab values('" & DestinationID & "','" & DestinationName & "','" & Hotel & "','" & Days & "','" & Budget & "','" & Attraction & "')", connect)
        command.ExecuteNonQuery()

        MsgBox("Successfully inserted", MsgBoxStyle.Information, "Message")
        connect.Close()
        ListProduct()

    End Sub

    Private Sub ListProduct()
        Dim command As New SqlCommand("select * from TravelPlanner_tab", connect)
        Dim sd As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sd.Fill(dt)
        GridView1.DataSource = dt
        GridView1.DataBind()

    End Sub

    Protected Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click

        Dim DestinationID As Integer = txtdestinationID.Text
        Dim DestinationName As String = txtdestinationname.Text
        Dim Hotel As String = txthotel.Text
        Dim Days As Integer = txtdays.Text
        Dim Budget As Integer = txtbudget.Text
        Dim Attraction As String = txtattraction.Text

        connect.Open()
        Dim command As New SqlCommand("Update TravelPlanner_tab set DestinationName = '" & DestinationName & "', Hotel = '" & Hotel & "',Days = '" & Days & "', Budget = '" & Budget & "', Attraction = '" & Attraction & "' where DestinationID= '" & DestinationID & "'", connect)
        command.ExecuteNonQuery()
        MsgBox("Successfully Updated", MsgBoxStyle.Information, "Message")
        connect.Close()
        ListProduct()
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        ListProduct()
    End Sub


    Protected Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim DestinationID As Integer = txtdestinationID.Text

        connect.Open()
        Dim command As New SqlCommand("Delete TravelPlanner_tab where DestinationID= '" & DestinationID & "'", connect)
        command.ExecuteNonQuery()
        MsgBox("Successfully Deleted", MsgBoxStyle.Information, "Message")
        connect.Close()
        ListProduct()
    End Sub

    Protected Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Dim DestinationID As Integer = txtdestinationID.Text
        Dim command As New SqlCommand("select * from TravelPlanner_tab where DestinationID = '" & DestinationID & "'", connect)
        Dim sd As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sd.Fill(dt)
        GridView1.DataSource = dt
        GridView1.DataBind()
    End Sub
End Class
