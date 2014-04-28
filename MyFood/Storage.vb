Public Class Storage

    Private _StorageLocation As String
    Private _StorageStatus As Boolean

    Public Sub New(storageLocation As String, storageStatus As Boolean)

        Me._StorageLocation = storageLocation
        Me._StorageStatus = storageStatus
    End Sub

    Public Property StorageLocation() As String
        Get
            Return Me._StorageLocation
        End Get
        Set(ByVal value As String)
            Me._StorageLocation = value
        End Set
    End Property

    Public Property StorageStatus() As Boolean
        Get
            Return Me._StorageStatus
        End Get
        Set(ByVal value As Boolean)
            Me._StorageStatus = value
        End Set
    End Property
End Class
''' <summary>
''' A Collection of Products
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class StorageCollection : Inherits System.Collections.ObjectModel.Collection(Of Storage)

End Class

