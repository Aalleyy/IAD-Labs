Imports System.Data.SqlClient

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub add_ServerClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim constr As String = "workstation id=ArtVault.mssql.somee.com;packet size=4096;user id=Aalleyy_SQLLogin_1;pwd=6hqepy6m5t;data source=ArtVault.mssql.somee.com;persist security info=False;initial catalog=ArtVault;TrustServerCertificate=True"
        Using con As New SqlConnection(constr)
            Dim query As String = "INSERT INTO PERSON (PERSON_ID, FIRST_NAME, LAST_NAME, EMAIL, PHONE_NO, GENDER, CITY, STATE, POSTAL_CODE, COUNTRY, ROLE, PASSWORD) " &
                                  "VALUES (@person_id, @fname, @lname, @email, @phone, @gender, @city, @state, @postal, @country, @role, @password)"

            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@person_id", cnic.Value)
                cmd.Parameters.AddWithValue("@fname", fname.Value)
                cmd.Parameters.AddWithValue("@lname", lname.Value)
                cmd.Parameters.AddWithValue("@email", email.Value)
                cmd.Parameters.AddWithValue("@phone", phone.Value)
                cmd.Parameters.AddWithValue("@gender", gender.Value)
                cmd.Parameters.AddWithValue("@city", city.Value)
                cmd.Parameters.AddWithValue("@state", state.Value)
                cmd.Parameters.AddWithValue("@postal", postal.Value)
                cmd.Parameters.AddWithValue("@country", country.Value)
                cmd.Parameters.AddWithValue("@role", role.Value)
                cmd.Parameters.AddWithValue("@password", password.Value)

                Try
                    con.Open()
                    Dim result As Integer = cmd.ExecuteNonQuery()
                    If result > 0 Then
                        Response.Write("Record Inserted Successfully!")
                    Else
                        Response.Write("Insertion Failed.")
                    End If
                Catch ex As Exception
                    Response.Write("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Class
