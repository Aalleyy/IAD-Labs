Imports System.Data.SqlClient
Imports System.Security.Policy

Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim constr As String
        constr = "Data Source= localhost; Initial Catalog= ArtVault; User ID=ALI; Password= 12345"
        Dim con As New SqlConnection
        con.ConnectionString = constr
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO CUSTOMER_T (NAME, EMAIL, PHONE, CNIC)"
        cmd.CommandText &= " VALUES ('"
        cmd.CommandText &= name.Value & "', '"
        cmd.CommandText &= email.Value & "', '"
        cmd.CommandText &= phone.Value & "', '"
        cmd.CommandText &= cnic.Value & "')"
        Try
            con.Open()
            Dim insert As Integer = cmd.ExecuteNonQuery()
            If insert > 0 Then
                Response.Write("Record Inserted Successfully")
            Else
                Response.Write("Record Insertion Failed")
            End If
        Catch ex As Exception
            Response.Write(ex.Message)
        Finally
            con.Close()
            cmd.Dispose()
        End Try

    End Sub
End Class