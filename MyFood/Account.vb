Public Class Account
    Private _UserID As Integer
    Private _password As String
    Private _loginStatus As Boolean

    Public Property USERID() As Integer
        Get
            Return Me._UserID
        End Get
        Set(ByVal value As Integer)
            Me._UserID = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return Me._password
        End Get
        Set(ByVal value As String)
            Me._password = value
        End Set
    End Property

    Public Property LOGINSTASTUS() As Boolean
        Get
            Return Me._loginStatus
        End Get
        Set(ByVal value As Boolean)
            Me._loginStatus = value
        End Set
    End Property

    Public Sub AddAccount()

    End Sub

    Public Sub viewAccount()

    End Sub

    Public Sub updateUser()

    End Sub

    Public Sub deleteUser()

    End Sub

    Public Function VerifyLogin() As Boolean
        Return False
    End Function



End Class

''' <summary>
''' A Collection of Accounts
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class AccountCollection : Inherits System.Collections.ObjectModel.Collection(Of Account)

End Class
