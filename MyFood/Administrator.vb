Public Class Administrator
    Inherits Account
    Private _AdminName As String

    Public Property ADMINNAME() As String
        Get
            Return Me._AdminName
        End Get
        Set(ByVal value As String)
            Me._ADMINNAME = value
        End Set
    End Property

    Public Sub updateCatalog()

    End Sub
    Public Sub restore()

    End Sub

    Public Sub backup()

    End Sub

End Class
''' <summary>
''' A Collection of Administrator
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class AdminCollection : Inherits System.Collections.ObjectModel.Collection(Of Administrator)

End Class