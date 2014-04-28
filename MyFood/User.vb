Public Class User
    Inherits Account
    Private _UserName As String

    Public Property USERNAME() As String
        Get
            Return Me._UserName
        End Get
        Set(ByVal value As String)
            Me._UserName = value
        End Set
    End Property

    Public Sub UpdateProduct()

    End Sub

End Class
''' <summary>
''' A Collection of users
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class UserCollection : Inherits System.Collections.ObjectModel.Collection(Of User)

End Class