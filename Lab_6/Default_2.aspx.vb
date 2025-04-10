Partial Class _Default_2
    Inherits System.Web.UI.Page

    <Serializable()>
    Public Class Customer

        Private _firstName As String
        Public Property FirstName() As String
            Get
                Return _firstName
            End Get
            Set(ByVal value As String)
                _firstName = value
            End Set
        End Property

        Private _lastName As String
        Public Property LastName() As String
            Get
                Return _lastName
            End Get
            Set(ByVal value As String)
                _lastName = value
            End Set
        End Property

        Public Sub New(ByVal firstName As String, ByVal lastName As String)
            Me.FirstName = firstName
            Me.LastName = lastName
        End Sub

    End Class

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim customers As New List(Of Customer) From {
                New Customer("Ali ", "Raza"),
                New Customer("Haider", "Khan"),
                New Customer("Mohsin", "Khan")
            }
            ViewState("Customers") = customers
        End If
    End Sub

    Protected Sub btnRetrieve_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRetrieve.Click
        Dim customers As List(Of Customer) = CType(ViewState("Customers"), List(Of Customer))
        If customers IsNot Nothing Then
            For Each customer As Customer In customers
                Response.Write("First Name: " & customer.FirstName & ", Last Name: " & customer.LastName & "<br/>")
            Next
        End If
    End Sub

End Class
